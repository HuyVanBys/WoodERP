using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using BOSReport;
using Localization;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using DevExpress.XtraRichEdit;

namespace BOSERP.Modules.PriceSheet
{
    public class PriceSheetModule : BaseTransactionModule
    {
        #region Constants
        public const string ARPriceSheetItemsGridControlName = "fld_dgcARPriceSheetItemsGridControl";
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        public const string ModuleName = "PriceSheet";
        public const string ProspectCustomerLookupEditControlName = "fld_lkeFK_ARProspectCustomerID";
        public const string CustomerTypeLookupEditControlName = "fld_lkeARCustomerType123";
        public const string ObjectAccessKeyLookupEditControlName = "fld_lkeACObjectAccessKey";
        public const string UpdateEndDateButtonName = "fld_btnUpdateEndDate";
        public const string ProductPicturePictureBoxName = "fld_pteARPriceSheetItemProductPicture";
        public const string stPriceSheetCommentNote = "fld_recARPriceSheetComment";
        #endregion

        #region Private properties
        private Workbook WorkBook;
        private Worksheet WorkSheet;
        private Microsoft.Office.Interop.Excel.Application App;
        public BOSButton UpdateEndDateButton;
        private BOSRichEditControl PriceSheetCommentEditControl;
        #endregion

        #region Public properties
        public BOSLookupEdit SearchBranchLookupEditControl;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public List<BRBranchsInfo> BranchList;
        public ARPriceSheetItemComponentsGridControl PriceSheetItemComponentsGridControl;
        public Dictionary<string, string> Operation = new Dictionary<string, string>()
            {
                {"Plus","+"},
                {"Minus","-"},
                {"Multi","*"},
                {"Split","/"},
            };
        public bool IsEditAfterCompleting = false;
        public BOSLookupEdit ARCustomerDistributionChannelLookupEditControl = null;
        public BOSLookupEdit CustomerTypeLookupEdit = null;
        public BOSPictureEdit ProductPicturePictureBox;
        #endregion

        public PriceSheetModule()
        {
            Name = ModuleName;
            CurrentModuleEntity = new PriceSheetEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            GetCurrentModuleDataViewPermission();
            CustomerTypeLookupEdit = (BOSLookupEdit)Controls[PriceSheetModule.CustomerTypeLookupEditControlName];
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[PriceSheetModule.SearchBranchLookupEditControlName];
            if(SearchBranchLookupEditControl != null)
            {
                SearchBranchLookupEditControl.Properties.DataSource = BranchList;
            }
            UpdateEndDateButton = (BOSButton)Controls[PriceSheetModule.UpdateEndDateButtonName];
            ProductPicturePictureBox = (BOSPictureEdit)Controls[ProductPicturePictureBoxName];
            PriceSheetCommentEditControl = (BOSRichEditControl)Controls[stPriceSheetCommentNote];
        }

        public override int ActionSave()
        {
            PriceSheetEntities entity = (PriceSheetEntities)CurrentModuleEntity;
            ARPriceSheetsInfo mainObject = (ARPriceSheetsInfo)CurrentModuleEntity.MainObject;
            entity.PriceSheetItemList.ForEach(o => o.Selected = false);
            entity.PriceSheetItemList.EndCurrentEdit();

            if (DateTime.Compare(mainObject.ARPriceSheetStartDate.Date, mainObject.ARPriceSheetEndDate.Date) > 0)
            {
                MessageBox.Show("Lỗi thời gian hiệu lực" + Environment.NewLine + "Vui lòng kiểm tra lại!"
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Information);
                return 0;
            }
            if (string.IsNullOrWhiteSpace(mainObject.ARCustomerType))
            {
                MessageBox.Show("Vui lòng chọn Loại khách hàng!"
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Information);
                return 0;
            }
            if (mainObject.FK_GECurrencyID <= 0)
            {
                MessageBox.Show("Vui lòng chọn Loại tiền tệ!"
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Information);
                return 0;
            }
            ARPriceSheetItemsController controllerItem = new ARPriceSheetItemsController();
            ARPriceSheetItemsInfo validatePriceSheetItemInfo = new ARPriceSheetItemsInfo();
            List<ARPriceSheetItemsInfo> listPriceSheetItems = controllerItem.GetPriceSheetItemsByDateActiveAndCustomer(mainObject.ARCustomerType, mainObject.FK_ARCustomerID, mainObject.ARPriceSheetStartDate, mainObject.ARPriceSheetEndDate, mainObject.FK_BRBranchID, mainObject.FK_GECurrencyID);
            
            foreach (ARPriceSheetItemsInfo item in entity.PriceSheetItemList)
            {
                if(entity.PriceSheetItemList.Where(o => o.FK_ICProductID == item.FK_ICProductID && o.ARPriceSheetItemQty == item.ARPriceSheetItemQty).ToList().Count > 1)
                {
                    MessageBox.Show(string.Format("Sản phẩm {0} tồn tại 2 dòng có cùng số lượng {1}"
                                            + Environment.NewLine + "Vui lòng kiểm tra lại!"
                                            , item.ARPriceSheetItemProductNo
                                            , item.ARPriceSheetItemQty)
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Information);
                    return 0;
                }
                if (entity.PriceSheetItemList.Where(o => o.FK_ICProductID == item.FK_ICProductID && o.ARPriceSheetItemSOQ == true).ToList().Count > 1)
                {
                    MessageBox.Show(string.Format("Sản phẩm {0} tồn tại 2 dòng check SOL"
                                            + Environment.NewLine + "Vui lòng kiểm tra lại!"
                                            , item.ARPriceSheetItemProductNo)
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Information);
                    return 0;
                }
                validatePriceSheetItemInfo = listPriceSheetItems.FirstOrDefault(o => o.FK_ICProductID == item.FK_ICProductID && o.FK_ARPriceSheetID != mainObject.ARPriceSheetID);
                if (validatePriceSheetItemInfo != null)
                {
                    item.Selected = true;
                }
            }    
            if(entity.PriceSheetItemList.Where(o => o.Selected == true).ToList().Count > 0)
            {
                entity.PriceSheetItemList.GridControl?.RefreshDataSource();
                MessageBox.Show("Một số sản phẩm đã tồn tại trong bảng giá khác có cùng thời gian hiệu lực"
                                + Environment.NewLine + "Vui lòng kiểm tra lại!"
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Information);
                return 0;
            }          
            return base.ActionSave();
        }
        public override void ModuleAfterSaved(int iObjectID)
        {
            ARPriceSheetCommentsController objPriceSheetCommentsController = new ARPriceSheetCommentsController();
            ARPriceSheetCommentsInfo info = (ARPriceSheetCommentsInfo)objPriceSheetCommentsController.GetCommentNoteByPriceSheetID(iObjectID);
            if (PriceSheetCommentEditControl != null)
            {
                if (info.ARPriceSheetCommentID > 0)
                {
                    info.ARPriceSheetCommentNote = PriceSheetCommentEditControl.OpenXmlBytes;
                    objPriceSheetCommentsController.UpdateObject(info);
                }
                else
                {
                    info = new ARPriceSheetCommentsInfo();
                    info.FK_ARPriceSheetID = iObjectID;
                    info.ARPriceSheetCommentNote = PriceSheetCommentEditControl.OpenXmlBytes;
                    objPriceSheetCommentsController.CreateObject(info);
                }
            }
            base.ModuleAfterSaved(iObjectID);
        }

        public void ActionValidate()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                PriceSheetEntities entity = (PriceSheetEntities)CurrentModuleEntity;
                //ARPriceSheetsInfo mainObject = (ARPriceSheetsInfo)entity.MainObject;
                //if (DateTime.Compare(mainObject.ARPriceSheetDate.AddDays(90).Date, mainObject.ARPriceSheetEndDate.Date) < 0)
                //{
                //    MessageBox.Show("Thời gian hiệu lực của Bảng giá không vượt quá 90 ngày" + Environment.NewLine + "Vui lòng kiểm tra lại!"
                //                    , CommonLocalizedResources.MessageBoxDefaultCaption
                //                    , MessageBoxButtons.OK
                //                    , MessageBoxIcon.Information);
                //    return;
                //}
                bool isValidated = entity.Validate();
                if (isValidated)
                {
                    InvalidateToolbar();
                }
            }
        }

        public override void ActionCancel()
        {
            base.ActionCancel();
            IsEditAfterCompleting = false;
        }

        public void GetCurrentModuleDataViewPermission()
        {
            CurrentModuleDataViewPermissionList = BOSApp.CurrentADDataViewPermissionList.Where(i => i.STModuleName == Name && i.ADDataViewPermissionType == ADDataViewPermissionType.Module).ToList();

            List<int> branchIDList = new List<int>();
            foreach (ADDataViewPermissionsInfo dataViewPermissionsInfo in CurrentModuleDataViewPermissionList)
            {
                branchIDList.Add(dataViewPermissionsInfo.FK_BRBranchID);
            }

            if (branchIDList.Count == 0)
            {
                BranchList = new List<BRBranchsInfo>();
            }
            else
            {
                BRBranchsController objBranchsController = new BRBranchsController();
                List<BRBranchsInfo> branchList = objBranchsController.GetAllBranches();

                BranchList = branchList.Where(i => branchIDList.IndexOf(i.BRBranchID) > -1).ToList();
            }
        }

        public override void InvalidateToolbar()
        {
            base.InvalidateToolbar();
            ARPriceSheetsInfo mainObject = (ARPriceSheetsInfo)CurrentModuleEntity.MainObject;
            ParentScreen.SetEnableOfToolbarButton("ValidatePriceSheet", false);
            ParentScreen.SetEnableOfToolbarButton("CancelValidatePriceSheet", false);
            ParentScreen.SetEnableOfToolbarButton("ApprovePriceSheet", false);
            ParentScreen.SetEnableOfToolbarButton("ImportPriceSheetExcel", false);
            ParentScreen.SetEnableOfToolbarButton("CanceledApprove", false);
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
            ParentScreen.SetEnableOfToolbarButton("ExportPriceSheetTemplate", false);
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancelComplete, false);

            if (mainObject.ARPriceSheetID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton("ExportPriceSheetTemplate", true);
                if (mainObject.ARPriceSheetStatus == ConfigSalesTargetStatus.New.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                    ParentScreen.SetEnableOfToolbarButton("ValidatePriceSheet", true);                    
                }
                else if (mainObject.ARPriceSheetStatus == PriceSheetStatus.Verified.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton("CancelValidatePriceSheet", true);
                    ParentScreen.SetEnableOfToolbarButton("ApprovePriceSheet", true);
                }
                else if (mainObject.ARPriceSheetStatus == PriceSheetStatus.Approved.ToString())
                {               
                    ParentScreen.SetEnableOfToolbarButton("CanceledApprove", true);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancelComplete, true);
                }

                if(Toolbar.IsEditAction())
                {
                    ParentScreen.SetEnableOfToolbarButton("ImportPriceSheetExcel", true);
                }    
            }
            if (UpdateEndDateButton != null)
            {
                UpdateEndDateButton.Enabled = false;
                if (mainObject.ARPriceSheetID > 0 && mainObject.ARPriceSheetStatus == PriceSheetStatus.Approved.ToString())
                {
                    UpdateEndDateButton.Enabled = true;
                }
            }          
        }

        public override void ActionNew()
        {
            base.ActionNew();
            if (UpdateEndDateButton != null)
            {
                UpdateEndDateButton.Enabled = false;
            }
            if (CustomerTypeLookupEdit != null)
            {
                CustomerTypeLookupEdit.Properties.ReadOnly = false;
            }
            SetDefaultPriceSheetNote();
        }

        public override bool ActionComplete()
        {
            bool isComplete = base.ActionComplete();
            return isComplete;
        }
        public override bool ActionCancelComplete()
        {
            bool isComplete = base.ActionCancelComplete();
            if (isComplete)
            {
                InvalidateToolbar();
            }
            return isComplete;
        }

        public void DeleteItemFromPriceSheetItemList()
        {
            PriceSheetEntities entity = (PriceSheetEntities)CurrentModuleEntity;
            entity.PriceSheetItemList.RemoveSelectedRowObjectFromList();
            int index = 1;
            entity.PriceSheetItemList.OrderBy(o => o.ARPriceSheetItemSortOrder).ToList().ForEach(o => o.ARPriceSheetItemSortOrder = index++);
            entity.PriceSheetItemList.GridControl.RefreshDataSource();
        }

        public void AddItemToPriceSheetItemsList()
        {
            PriceSheetEntities entity = (PriceSheetEntities)CurrentModuleEntity;
            ARPriceSheetsInfo mainObject = (ARPriceSheetsInfo)entity.MainObject;
            ARPriceSheetItemsInfo objPriceSheetItemsInfo = (ARPriceSheetItemsInfo)entity.ModuleObjects[TableName.ARPriceSheetItemsTableName];
            if (objPriceSheetItemsInfo.FK_ICProductID > 0)
            {
                ICProductsForViewInfo objProductsInfo = BOSApp.CurrentProductList.FirstOrDefault(o1 => o1.ICProductID == objPriceSheetItemsInfo.FK_ICProductID);
                if (objProductsInfo != null)
                {
                    ICProductsInfo newObj = new ICProductsInfo();
                    BOSUtil.CopyViewObject(objProductsInfo, newObj);
                    objPriceSheetItemsInfo = entity.ToPriceSheetItemsInfo(newObj);
                    objPriceSheetItemsInfo.ARPriceSheetItemSortOrder = entity.PriceSheetItemList.Count > 0 ? entity.PriceSheetItemList.Max(p => p.ARPriceSheetItemSortOrder) + 1 : 1;
                    entity.PriceSheetItemList.Add(objPriceSheetItemsInfo);
                    entity.PriceSheetItemList.OrderBy(o => o.ARPriceSheetItemSortOrder);
                    entity.PriceSheetItemList.GridControl?.RefreshDataSource();
                }
            }
        }

        public void AddProductToPriceSheetItemList()
        {
            if (IsEditable())
            {
                ActionEdit();
            }
            PriceSheetEntities entity = (PriceSheetEntities)CurrentModuleEntity;
            ARPriceSheetsInfo mainObject = (ARPriceSheetsInfo)entity.MainObject;

            int departmentID = 0;
            List<ICProductsInfo> productList = new List<ICProductsInfo>();
            ACObjectsInfo customer = new ACObjectsInfo();
            List<ICProductsForViewInfo> productViewList = BOSApp.CurrentProductList.Where(o => o.ICProductActiveCheck && o.ICProductType == ProductType.Product.ToString()).ToList();
            if (productViewList.Count() > 0) productViewList.ForEach(o =>
            {
                ICProductsInfo newObj = new ICProductsInfo();
                BOSUtil.CopyViewObject(o, newObj);
                customer = BOSApp.AccountingObjects.FirstOrDefault(ob => ob.ACObjectType == ObjectType.Customer.ToString() && ob.ACObjectID == newObj.FK_ARCustomerID);
                newObj.ARCustomerName = customer != null ? customer.ACObjectName : string.Empty;
                productList.Add(newObj);
            });
            string defaultDepartmentNo = "06";
            ICDepartmentsController objDepartmentsController = new ICDepartmentsController();
            ICDepartmentsInfo objDepartmentsInfo = (ICDepartmentsInfo)objDepartmentsController.GetObjectByNo(defaultDepartmentNo);
            if (objDepartmentsInfo != null)
            {
                departmentID = objDepartmentsInfo.ICDepartmentID;
            }
            else if (productList != null && productList.Count > 0)
            {
                departmentID = productList[0].FK_ICDepartmentID;
            }

            guiAddProduct<ICProductsInfo> guiAddProduct = new guiAddProduct<ICProductsInfo>(productList, departmentID);
            guiAddProduct.Module = this;
            guiAddProduct.ShowDialog();
            if (guiAddProduct.DialogResult != DialogResult.OK)
                return;

            List<ICProductsInfo> results = (List<ICProductsInfo>)guiAddProduct.SelectedObjects;
            entity.GeneratePriceSheetItems(results);
            int index = 1;
            entity.PriceSheetItemList.OrderBy(o => o.ARPriceSheetItemSortOrder).ToList().ForEach(o => o.ARPriceSheetItemSortOrder = index++);
            entity.PriceSheetItemList.GridControl?.RefreshDataSource();
        }

        public void ActionApprove()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                PriceSheetEntities entity = (PriceSheetEntities)CurrentModuleEntity;
                bool isApproved = entity.Approve();
                if (isApproved)
                {
                    InvalidateToolbar();
                }   
            }
        }

        public void UpdatePriceSheetItemPrice(ARPriceSheetItemsInfo item)
        {
            PriceSheetEntities entity = (PriceSheetEntities)CurrentModuleEntity;
            item.ARPriceSheetItemDiscountAmount = item.ARPriceSheetItemPrice * item.ARPriceSheetItemQty * item.ARPriceSheetItemDiscountPercent / 100;
            item.ARPriceSheetItemTaxAmount = (item.ARPriceSheetItemPrice * item.ARPriceSheetItemQty - item.ARPriceSheetItemDiscountAmount) * item.ARPriceSheetItemTaxPercent / 100;
            entity.PriceSheetItemList.GridControl?.RefreshDataSource();
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            ARPriceSheetsInfo mainObject = (ARPriceSheetsInfo)CurrentModuleEntity.MainObject;
            DateTime toDay = BOSApp.GetCurrentServerDate();
            mainObject.ARPriceSheetApprovedStatus = PriceSheetApprovedStatus.None.ToString();
            if(mainObject.ARPriceSheetStatus == PriceSheetStatus.Approved.ToString())
            {
                if (mainObject.ARPriceSheetStartDate.Date > toDay.Date)
                {
                    mainObject.ARPriceSheetApprovedStatus = PriceSheetApprovedStatus.NotActive.ToString();
                }
                else if (mainObject.ARPriceSheetEndDate.Date < toDay.Date)
                {
                    mainObject.ARPriceSheetApprovedStatus = PriceSheetApprovedStatus.OutOfActive.ToString();
                }
                else
                {
                    mainObject.ARPriceSheetApprovedStatus = PriceSheetApprovedStatus.IsActive.ToString();
                }
            }
            if(CustomerTypeLookupEdit != null)
            {
                if(mainObject.FK_ARCustomerID > 0)
                {
                    CustomerTypeLookupEdit.Properties.ReadOnly = true;
                }
                else
                {
                    CustomerTypeLookupEdit.Properties.ReadOnly = false;
                }    
            }
            if (PriceSheetCommentEditControl != null)
            {
                ARPriceSheetCommentsInfo objPriceSheetCommentsInfo = (ARPriceSheetCommentsInfo)(new ARPriceSheetCommentsController()).GetCommentNoteByPriceSheetID(mainObject.ARPriceSheetID);
                PriceSheetCommentEditControl.OpenXmlBytes = (objPriceSheetCommentsInfo.ARPriceSheetCommentNote != null && objPriceSheetCommentsInfo.ARPriceSheetCommentNote.Length > 0) ? objPriceSheetCommentsInfo.ARPriceSheetCommentNote : null;
            }    
            CurrentModuleEntity.UpdateMainObjectBindingSource();
        }

        public void CancelValidatePriceSheet()
        {
            PriceSheetEntities entity = (PriceSheetEntities)CurrentModuleEntity;
            ARPriceSheetsInfo objPriceSheetsInfo = (ARPriceSheetsInfo)entity.MainObject;
            ARPriceSheetsController objPriceSheetsController = new ARPriceSheetsController();
            objPriceSheetsInfo.ARPriceSheetStatus = ConfigSalesTargetStatus.New.ToString();
            objPriceSheetsController.UpdateObject(objPriceSheetsInfo);
            InvalidateToolbar();
        }

        public override void ActionDuplicate()
        {
            base.ActionDuplicate();
            PriceSheetEntities entity = (PriceSheetEntities)CurrentModuleEntity;
            ARPriceSheetsInfo objPriceSheetsInfo = (ARPriceSheetsInfo)entity.MainObject;
            objPriceSheetsInfo.ARPriceSheetStatus = PriceSheetStatus.New.ToString();
            objPriceSheetsInfo.ARPriceSheetDate = BOSApp.GetCurrentServerDate();
        }

        public void PrintDetailOfEstimateProposal()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                RPDetailOfEstimateProposal report = new RPDetailOfEstimateProposal();
                guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevInvoiceItemReportPath, false);
                reviewer.Show();
            }
        }

        private void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            ARPriceSheetsController objPriceSheetsController = new ARPriceSheetsController();
            ARPriceSheetsInfo searchObject = (ARPriceSheetsInfo)CurrentModuleEntity.SearchObject;
            DataSet ds;
            if (searchObject.FK_BRBranchID == 0)
            {
                if (BranchList.Count == 0)
                {
                    ds = objPriceSheetsController.GetDataSetByID(-1);
                }
                else
                {
                    ds = objPriceSheetsController.GetPriceSheetListByListOfBranchID(searchObject.ARPriceSheetNo,
                                                                                        searchObject.ARCustomerType,
                                                                                        searchObject.FK_HREmployeeID,
                                                                                        searchObject.ARPriceSheetDateFrom,
                                                                                        searchObject.ARPriceSheetDateTo,
                                                                                        searchObject.FK_ARCustomerID,
                                                                                        searchObject.FK_ICProductID,
                                                                                        BranchList);
                }
            }
            else
            {
                ds = objPriceSheetsController.GetPriceSheetListByBranchID(searchObject.ARPriceSheetNo,
                                                                            searchObject.ARCustomerType,
                                                                            searchObject.FK_HREmployeeID,
                                                                            searchObject.ARPriceSheetDateFrom,
                                                                            searchObject.ARPriceSheetDateTo,
                                                                            searchObject.FK_ARCustomerID,
                                                                            searchObject.FK_ICProductID,
                                                                            searchObject.FK_BRBranchID);
            }

            return ds;
        }

        public string CheckValidProduct(int productID)
        {
            ICProductsController objProductsController = new ICProductsController();
            ICProductsForViewInfo objProductsInfo = BOSApp.CurrentProductList.FirstOrDefault(o1 => o1.ICProductID == productID);
            if (objProductsInfo != null)
            {
                if (objProductsInfo.ICProductLockedPurchaseOrder)
                {
                    return SaleOrderLocalizedResources.ProductLockedErrorMessage;
                }
                if (objProductsInfo.ICProductNonRetail)
                {
                    return SaleOrderLocalizedResources.ProductNonRetailMessages;
                }
                if (!objProductsInfo.ICProductActiveCheck)
                {
                    return SaleOrderLocalizedResources.ProductNonActiveCheck;
                }
            }
            return string.Empty;
        }

        public void UpdatePriceSheetEndDate()
        {
            ARPriceSheetsInfo mainObject = (ARPriceSheetsInfo)CurrentModuleEntity.MainObject;
            CurrentModuleEntity.SetPropertyChangeEventLock(false);
            guiUpdatePriceSheetEndDate guiUpdate = new guiUpdatePriceSheetEndDate(mainObject);
            guiUpdate.Module = this;
            if (guiUpdate.ShowDialog() == DialogResult.OK)
            {
                guiUpdate.Dispose();
                try
                {
                    CurrentModuleEntity.UpdateMainObject();
                    MessageBox.Show(CommonLocalizedResources.SaveSuccessful
                                    , CommonLocalizedResources.MessageBoxDefaultCaption
                                    , MessageBoxButtons.OK
                                    , MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(BaseLocalizedResources.SaveObjectErrorMessage
                                    , CommonLocalizedResources.MessageBoxDefaultCaption
                                    , MessageBoxButtons.OK
                                    , MessageBoxIcon.Error);
                }
            }
            else
            {
                if(mainObject.OldObject != null)
                {
                    mainObject.ARPriceSheetEndDate = ((ARPriceSheetsInfo)mainObject.OldObject).ARPriceSheetEndDate;
                    CurrentModuleEntity.UpdateMainObjectBindingSource();
                }    
                else
                {
                    Invalidate(mainObject.ARPriceSheetID);
                }
            }    
            CurrentModuleEntity.SetPropertyChangeEventLock(true);
        }

        public void ChangeCustomer(int customerID)
        {
            PriceSheetEntities entity = (PriceSheetEntities)CurrentModuleEntity;
            ARPriceSheetsInfo mainObject = (ARPriceSheetsInfo)entity.MainObject;
            ARCustomersController objCustomersController = new ARCustomersController();
            ICProductCustomersController objProductCustomersController = new ICProductCustomersController();
            ARCustomersInfo objCustomersInfo = (ARCustomersInfo)objCustomersController.GetObjectByID(customerID);
            if (objCustomersInfo != null)
            {
                mainObject.ARCustomerType = objCustomersInfo.ARCustomerTypeCombo;
                mainObject.FK_ARCustomerID = objCustomersInfo.ARCustomerID;
                mainObject.FK_GECurrencyID = objCustomersInfo.FK_GECurrencyID;
            }
            else
            {
                mainObject.FK_ARCustomerID = 0;
            }
            if (CustomerTypeLookupEdit != null)
            {
                if (mainObject.FK_ARCustomerID > 0)
                {
                    CustomerTypeLookupEdit.Properties.ReadOnly = true;
                }
                else
                {
                    CustomerTypeLookupEdit.Properties.ReadOnly = false;
                }
            }
            entity.PriceSheetItemList.ForEach(o =>
            {
                ICProductCustomersInfo objProductCustomersInfo = (ICProductCustomersInfo)objProductCustomersController.GetProductCustomerByProductIDAndCustomerID(o.FK_ICProductID, mainObject.FK_ARCustomerID);
                o.ARPriceSheetItemProductCustomerNumber = objProductCustomersInfo != null ? objProductCustomersInfo.ICProductCustomerNumber : string.Empty;
            });
            entity.PriceSheetItemList.GridControl?.RefreshDataSource();
            entity.UpdateMainObjectBindingSource();
        }

        public void InitProductPictureImage(int productID)
        {
            if (productID > 0 && ProductPicturePictureBox != null)
            {
                ProductPicturePictureBox.Image = BOSApp.GetProductPictureImageByProductID(productID);
                ProductPicturePictureBox.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            }
        }

        #region Export Import Excel
        public void ExportPriceSheetTemplate()
        {
            try
            {
                PriceSheetEntities entity = (PriceSheetEntities)CurrentModuleEntity;
                ARPriceSheetsInfo mainObject = (ARPriceSheetsInfo)CurrentModuleEntity.MainObject;
                ACObjectsInfo objEmployeesInfo = BOSApp.AccountingObjects.FirstOrDefault(o => o.ACObjectID == mainObject.FK_HREmployeeID && o.ACObjectType == ObjectType.Employee.ToString());
                ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                ADConfigValuesInfo objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue("CustomerType", mainObject.ARCustomerType);
                if (objConfigValuesInfo != null)
                {
                    mainObject.ARCustomerTypeName = objConfigValuesInfo.ADConfigText;
                }
                guiExportPriceSheetProcess process = new guiExportPriceSheetProcess(entity.PriceSheetItemList, mainObject.ARPriceSheetStartDate, mainObject.ARPriceSheetEndDate, mainObject.ARCustomerTypeName);
                process.ShowDialog();
                if (File.Exists(process.FilePath))
                {
                    Process.Start(process.FilePath);
                }
            }
            catch (Exception ex)
            {
                BOSProgressBar.Close();
                MessageBox.Show(ex.ToString()
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Error);
            }
        }

        public void ImportPriceSheetExcel()
        {
            PriceSheetEntities entity = (PriceSheetEntities)CurrentModuleEntity;
            ARPriceSheetsInfo mainobject = (ARPriceSheetsInfo)entity.MainObject;

            if (Toolbar.IsNullOrNoneAction())
                return;
            
            List<Range> ranges = InitializeDataImport();
            if (ranges == null)
                return;

            if (ranges.Count() != 1)
            {
                MessageBox.Show(PriceSheetLocalizedResources.TeamplateMalformed, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show(ImportDataLocalizedResources.QuestionImportDataMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            BOSProgressBar.Start(ImportDataLocalizedResources.ProgressBarMessage);

            Range woods = ranges[0];

            ImportPriceSheetItem(woods);

            BOSProgressBar.Close();
        }

        public List<Range> InitializeDataImport()
        {
            string filePath = string.Empty;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = ImportDataLocalizedResources.DialogFilter;
            if (dialog.ShowDialog() != DialogResult.Cancel)
                filePath = dialog.FileName;

            if (!String.IsNullOrEmpty(filePath))
            {
                Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("vi-VN");
                App = new ApplicationClass();
                WorkBook = App.Workbooks.Open(filePath, 0, true, 5, string.Empty, string.Empty, true, XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                List<Range> result = new List<Range>();
                for (int i = 1; i <= WorkBook.Worksheets.Count; i++)
                {
                    WorkSheet = (Worksheet)WorkBook.Worksheets.get_Item(i);
                    Range range = WorkSheet.UsedRange;
                    result.Add(range);
                }
                return result;
            }
            return null;
        }

        private void ImportPriceSheetItem(Range range)
        {
            if (range == null)
                return;

            PriceSheetEntities entity = (PriceSheetEntities)CurrentModuleEntity;
            ARPriceSheetsInfo mainobject = (ARPriceSheetsInfo)entity.MainObject;

            List<ARPriceSheetItemsImportInfo> importInfoList = new List<ARPriceSheetItemsImportInfo>();
            ARPriceSheetItemsImportInfo objPriceSheetItemsImportInfo = new ARPriceSheetItemsImportInfo();
            string cellValue = string.Empty;
            decimal value = 0;
            bool SOQ = false;
            for (int row = 2; row <= range.Rows.Count; row++)
            {
                objPriceSheetItemsImportInfo = new ARPriceSheetItemsImportInfo();
                objPriceSheetItemsImportInfo.ARPriceSheetItemsImportProductNo = (range.Cells[row, 2] as Range).Text.ToString().Trim();
                if (string.IsNullOrEmpty(objPriceSheetItemsImportInfo.ARPriceSheetItemsImportProductNo))
                    continue;

                objPriceSheetItemsImportInfo.ARPriceSheetItemsImportProductSupplierNumber = (range.Cells[row, 3] as Range).Text.ToString().Trim();
                objPriceSheetItemsImportInfo.ARPriceSheetItemsImportProductNoOfOldSys = (range.Cells[row, 4] as Range).Text.ToString().Trim();
                objPriceSheetItemsImportInfo.ARPriceSheetItemsImportProductCustomerNumber = (range.Cells[row, 5] as Range).Text.ToString().Trim();
                objPriceSheetItemsImportInfo.ARPriceSheetItemsImportProductName = (range.Cells[row, 6] as Range).Text.ToString().Trim();
                objPriceSheetItemsImportInfo.ARPriceSheetItemsImportProductDesc = (range.Cells[row, 7] as Range).Text.ToString().Trim();
                objPriceSheetItemsImportInfo.ARPriceSheetItemsImportMeasureUnitName = (range.Cells[row, 8] as Range).Text.ToString().Trim();

                cellValue = (range.Cells[row, 9] as Range).Text.ToString().Replace(",", string.Empty).Trim();
                cellValue = cellValue.Replace(".", ",").Trim();
                cellValue = cellValue.Replace(" ", string.Empty).Trim();
                Decimal.TryParse(cellValue, out value);
                value = Math.Round(value, 4, MidpointRounding.AwayFromZero);
                objPriceSheetItemsImportInfo.ARPriceSheetItemsImportProductQty= value;

                value = 0;
                cellValue = (range.Cells[row, 10] as Range).Text.ToString().Replace(",", string.Empty).Trim();
                cellValue = cellValue.Replace(".", ",").Trim();
                cellValue = cellValue.Replace(" ", string.Empty).Trim();
                Decimal.TryParse(cellValue, out value);
                value = Math.Round(value, 4, MidpointRounding.AwayFromZero);
                objPriceSheetItemsImportInfo.ARPriceSheetItemsImportBasicPrice = value;

                value = 0;
                cellValue = (range.Cells[row, 11] as Range).Text.ToString().Replace(",", string.Empty).Trim();
                cellValue = cellValue.Replace(".", ",").Trim();
                cellValue = cellValue.Replace(" ", string.Empty).Trim();
                Decimal.TryParse(cellValue, out value);
                value = Math.Round(value, 4, MidpointRounding.AwayFromZero);
                objPriceSheetItemsImportInfo.ARPriceSheetItemsImportCostingPrice = value;

                value = 0;
                cellValue = (range.Cells[row, 12] as Range).Text.ToString().Replace(",", string.Empty).Trim();
                cellValue = cellValue.Replace(".", ",").Trim();
                cellValue = cellValue.Replace(" ", string.Empty).Trim();
                Decimal.TryParse(cellValue, out value);
                value = Math.Round(value, 4, MidpointRounding.AwayFromZero);
                objPriceSheetItemsImportInfo.ARPriceSheetItemsImportNetPrice = value;

                value = 0;
                cellValue = (range.Cells[row, 13] as Range).Text.ToString().Replace(",", string.Empty).Trim();
                cellValue = cellValue.Replace(".", ",").Trim();
                cellValue = cellValue.Replace(" ", string.Empty).Trim();
                Decimal.TryParse(cellValue, out value);
                value = Math.Round(value, 4, MidpointRounding.AwayFromZero);
                objPriceSheetItemsImportInfo.ARPriceSheetItemsImportPrice = value;

                objPriceSheetItemsImportInfo.ARPriceSheetItemsImportCommand = (range.Cells[row, 14] as Range).Text.ToString().Trim();

                cellValue = (range.Cells[row, 15] as Range).Text.ToString().Replace(",", string.Empty).Trim();
                bool.TryParse(cellValue, out SOQ);
                objPriceSheetItemsImportInfo.ARPriceSheetItemsImportSOQ = SOQ;

                importInfoList.Add(objPriceSheetItemsImportInfo);
            }

            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = new ICProductsInfo();

            ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
            ICMeasureUnitsInfo objMeasureUnitsInfo = new ICMeasureUnitsInfo();

            ICProductCustomersController objProductCustomersController = new ICProductCustomersController();
            ICProductCustomersInfo objProductCustomersInfo = new ICProductCustomersInfo();

            ARPriceSheetItemsController objPriceSheetItemsController = new ARPriceSheetItemsController();
            List<ARPriceSheetItemsInfo> priceSheetItemList = new List<ARPriceSheetItemsInfo>();
            ARPriceSheetItemsInfo objPriceSheetItemsInfo = new ARPriceSheetItemsInfo();

            List<ICMeasureUnitsInfo> measureUnitList = objMeasureUnitsController.GetAllAliveMeasureUnit();

            importInfoList.ForEach(o =>
            {
                objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByNo(o.ARPriceSheetItemsImportProductNo);
                if (objProductsInfo == null)
                    return;
                objMeasureUnitsInfo = measureUnitList.Where(o1 => o1.ICMeasureUnitName == o.ARPriceSheetItemsImportMeasureUnitName).FirstOrDefault();
                objProductCustomersInfo = (ICProductCustomersInfo)objProductCustomersController.GetProductCustomerByProductIDAndCustomerID(objProductsInfo.ICProductID, mainobject.FK_ARCustomerID);


                objPriceSheetItemsInfo = new ARPriceSheetItemsInfo()
                {
                    FK_ICProductID = objProductsInfo.ICProductID,
                    AACreatedUser = BOSApp.CurrentUser,
                    ARPriceSheetItemProductNo = objProductsInfo.ICProductNo,
                    ARPriceSheetItemProductName = objProductsInfo.ICProductName,
                    ARPriceSheetItemProductDesc = objProductsInfo.ICProductDesc,
                    ARPriceSheetItemProductHeight = objProductsInfo.ICProductHeight,
                    ARPriceSheetItemProductWidth = objProductsInfo.ICProductWidth,
                    ARPriceSheetItemProductLength = objProductsInfo.ICProductLength,
                    ARPriceSheetItemProductNoOfOldSys = objProductsInfo.ICProductNoOfOldSys,
                    ARPriceSheetItemProductCustomerNumber = objProductCustomersInfo != null ? objProductCustomersInfo.ICProductCustomerNumber : string.Empty,
                    ARPriceSheetItemBasicPrice = objProductsInfo.ICProductPrice01,
                    ARPriceSheetItemPrice = o.ARPriceSheetItemsImportPrice,
                    ARPriceSheetItemQty = o.ARPriceSheetItemsImportProductQty,
                    ARPriceSheetItemCostingPrice = o.ARPriceSheetItemsImportCostingPrice,
                    ARPriceSheetItemNetPrice = o.ARPriceSheetItemsImportNetPrice,
                    ARPriceSheetItemCommand = o.ARPriceSheetItemsImportCommand,
                    ARPriceSheetItemSOQ = o.ARPriceSheetItemsImportSOQ,
                    FK_ICMeasureUnitID = objMeasureUnitsInfo == null ? objProductsInfo.FK_ICProductBasicUnitID : objMeasureUnitsInfo.ICMeasureUnitID,
                };
                priceSheetItemList.Add(objPriceSheetItemsInfo);
            });

            entity.PriceSheetItemList.AddRange(priceSheetItemList);
            entity.PriceSheetItemList.GridControl?.RefreshDataSource();
        }
        #endregion
        private void SetDefaultPriceSheetNote()
        {
            ARPriceSheetsInfo mainObject = (ARPriceSheetsInfo)CurrentModuleEntity.MainObject;

            byte[] RTFByte = BOSApp.GetDefaultDescConfig(this.Name, string.Empty);
            if (PriceSheetCommentEditControl != null)
            {
                if (RTFByte != null && RTFByte.Length > 0)
                {
                    MemoryStream RTFStream = new MemoryStream(RTFByte);
                    PriceSheetCommentEditControl.LoadDocument(RTFStream, DocumentFormat.Rtf);
                }
                else
                {
                    PriceSheetCommentEditControl.OpenXmlBytes = null;
                }
            }
            CurrentModuleEntity.UpdateMainObjectBindingSource();
        }
    }
}

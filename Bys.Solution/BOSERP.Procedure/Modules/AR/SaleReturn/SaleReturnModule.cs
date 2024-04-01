using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSERP.Utilities;
using BOSLib;
using BOSReport;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
using System.Drawing;
using System.Diagnostics;
using DevExpress.XtraRichEdit;

namespace BOSERP.Modules.SaleReturn
{
    public class SaleReturnModule : BaseTransactionModule
    {
        #region Constants
        public const string DocumentEntryGridControlName = "fld_dgcACDocumentEntrys";
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        public const string ProductPicturePictureBoxName = "fld_pteARSaleReturnItemProductPicture";
        private const string ProductLookupControlName = "fld_lkeFK_ICProductID";
        #endregion

        #region Private properties
        private bool IsEditAfterCompleting = false;
        private BOSPictureEdit ProductPicturePictureBox;
        private BOSLookupEdit ProductLookupControl;
        private string FilePath { get; set; }
        private BOSRichEditControl SaleReturnNoteEditControl;
        private const string stSaleReturnNoteRichEdit = "fld_recARSaleReturnNote";
        private ARSaleReturnItemsGridControl SaleReturnItemsGridControl { get; set; }
        private const string strSaleReturnItemsGridControl = "fld_dgcARSaleReturnItems";
        #endregion

        #region Public properties
        public BOSLookupEdit SearchBranchLookupEditControl;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public List<BRBranchsInfo> BranchList;
        public List<ARInvoiceItemsInfo> ListInvoiceItemsInfo;
        #endregion

        #region Constructor
        public SaleReturnModule()
        {
            Name = "SaleReturn";
            CurrentModuleEntity = new SaleReturnEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            GetCurrentModuleDataViewPermission();
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[SearchBranchLookupEditControlName];
            SearchBranchLookupEditControl.Properties.DataSource = BranchList;
            ProductPicturePictureBox = (BOSPictureEdit)Controls[ProductPicturePictureBoxName];
            SaleReturnNoteEditControl = (BOSRichEditControl)Controls[stSaleReturnNoteRichEdit];
            ProductLookupControl = (BOSLookupEdit)Controls[ProductLookupControlName];
            SaleReturnItemsGridControl = (ARSaleReturnItemsGridControl)Controls[strSaleReturnItemsGridControl];
            ARInvoiceItemsController objInvoiceItemsController = new ARInvoiceItemsController();
            ListInvoiceItemsInfo = objInvoiceItemsController.GetInvoiceItemsForLookupSaleReturn(null, true);
            if(SaleReturnItemsGridControl != null)
            {
                SaleReturnItemsGridControl.ListInvoiceItemsInfo = ListInvoiceItemsInfo;
            }    
            StartGettingInventoryThread();
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
        #endregion

        #region Override
        protected override DataSet GetSearchData(ref string searchQuery)
        {
            ARSaleReturnsController objSaleReturnsController = new ARSaleReturnsController();
            ARSaleReturnsInfo searchObject = (ARSaleReturnsInfo)CurrentModuleEntity.SearchObject;

            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(searchObject.ACObjectAccessKey);

            DataSet ds;
            if (SearchBranchLookupEditControl.EditValue.ToString() == "" || SearchBranchLookupEditControl.EditValue.ToString() == "0")
            {
                if (BranchList.Count == 0)
                {
                    ds = objSaleReturnsController.GetDataSetByID(-1);
                }
                else
                {

                    ds = objSaleReturnsController.GetSaleReturnListByListOfBranchID(
                                                                            searchObject.ARSaleReturnNo,
                                                                            searchObject.ARInvoiceNo,
                                                                            objObjectsInfo.ACObjectID,
                                                                            objObjectsInfo.ACObjectName,
                                                                            searchObject.FK_HREmployeeID,
                                                                            searchObject.SaleReturnDateFrom,
                                                                            searchObject.SaleReturnDateTo,
                                                                            searchObject.FK_BRBranchID,
                                                                            BOSApp.CurrentUsersInfo.ADUserID,
                                                                            BranchList);
                }
            }
            else
            {
                ds = objSaleReturnsController.GetSaleReturnListByBranchIDAndUser(
                                                                    searchObject.ARSaleReturnNo,
                                                                    searchObject.ARInvoiceNo,
                                                                    objObjectsInfo.ACObjectID,
                                                                    objObjectsInfo.ACObjectName,
                                                                    searchObject.FK_HREmployeeID,
                                                                    searchObject.SaleReturnDateFrom,
                                                                    searchObject.SaleReturnDateTo,
                                                                    searchObject.FK_BRBranchID,
                                                                    BOSApp.CurrentUsersInfo.ADUserID
                                                                    );
            }
            return ds;
        }

        public override void InvalidateToolbar()
        {
            base.InvalidateToolbar();
            ARSaleReturnsInfo objSaleReturnsInfo = (ARSaleReturnsInfo)CurrentModuleEntity.MainObject;
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDelete, false);
            if (objSaleReturnsInfo.ARSaleReturnID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions, false);
                ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions, false);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, true);
                if (objSaleReturnsInfo.ARSaleReturnStatus == SaleReturnStatus.New.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDelete, true);
                }
                    if (objSaleReturnsInfo.ARSaleReturnStatus == SaleReturnStatus.Complete.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                    ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions,
                        objSaleReturnsInfo.ARSaleReturnPostedStatus != PostedTransactionStatus.Posted.ToString());
                    ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions,
                        objSaleReturnsInfo.ARSaleReturnPostedStatus == PostedTransactionStatus.Posted.ToString());
                }
            }
            if(Toolbar.IsEditAction() || Toolbar.IsNewAction())
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonImport, true);
            }
            else
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonImport, false);
            }    
        }

        public override int ActionSave()
        {
            SetDefaultDesc();

            SaleReturnEntities entity = (SaleReturnEntities)CurrentModuleEntity;
            ARSaleReturnsInfo mainObject = (ARSaleReturnsInfo)CurrentModuleEntity.MainObject;
            entity.SaleReturnItemsList.EndCurrentEdit();
            if (mainObject.FK_ARInvoiceID > 0)
            {
                ARInvoicesController objInvoicesController = new ARInvoicesController();
                ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)objInvoicesController.GetObjectByID(mainObject.FK_ARInvoiceID);
                if (objInvoicesInfo != null
                    && (objInvoicesInfo.FK_ACObjectID != mainObject.FK_ACObjectID
                        || objInvoicesInfo.ARObjectType != mainObject.ARObjectType))
                {
                    MessageBox.Show("Đối tượng trả hàng không trùng khớp đối tượng của hóa đơn"
                                + Environment.NewLine + "Vui lòng kiểm tra lại!",
                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    return 0;
                }
            }

            foreach (ARSaleReturnItemsInfo item in entity.SaleReturnItemsList)
            {
                if (item.FK_ICStockID == 0)
                {
                    MessageBox.Show("Vui lòng chọn kho cho sản phẩm !",
                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    return 0;
                }
                if(item.FK_ARInvoiceID > 0 && item.FK_ARInvoiceID != mainObject.FK_ARInvoiceID && mainObject.STToolbarActionName == "FromInvoice")
                {
                    MessageBox.Show("Tồn tại nhiều sản phẩm trả hàng từ nhiều hóa đơn khác nhau" 
                                + Environment.NewLine + "Vui lòng kiểm tra lại!",
                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    return 0;
                }    
                ChangeSaleReturnItemProductQty(item);
            }
            UpdateTotalAmount();

            bool isSave = CheckSerialNoInSaleReturnItemsList();
            if (!isSave)
            {
                return 0;
            }
            if (SaleReturnNoteEditControl != null)
            {
                mainObject.ARSaleReturnNote = SaleReturnNoteEditControl.OpenXmlBytes;
            }
            int objectID = base.ActionSave();
            if (objectID > 0)
            {
                if (IsEditAfterCompleting)
                {
                    entity.InvalidateItemComponents();
                    ActionComplete();
                    IsEditAfterCompleting = false;
                }
               (new ARSaleReturnsController()).UpdateUniCost(objectID);
            }
            return objectID;
        }

        public override bool ActionComplete()
        {
            //Check the serie no is mandatory
            SaleReturnEntities entity = (SaleReturnEntities)CurrentModuleEntity;
            ARSaleReturnsInfo saleReturn = (ARSaleReturnsInfo)CurrentModuleEntity.MainObject;
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            foreach (ARSaleReturnItemsInfo objSaleReturnItemsInfo in entity.SaleReturnItemsList)
            {
                objProductsInfo = (ICProductsInfo)objProductsController.GetObjectFromDataRow( BOSApp.GetObjectFromCatche("ICProducts", "ICProductID", objSaleReturnItemsInfo.FK_ICProductID));
                if (objProductsInfo.ICProductType != ProductType.Service.ToString() && !objProductsInfo.IsAsset && !objProductsInfo.HasComponent)
                {
                    if (string.IsNullOrEmpty( objSaleReturnItemsInfo.ARSaleReturnItemProductSerialNo)
                        && objProductsInfo.ICPriceCalculationMethodMethod == PriceCalculationMethod.Specific.ToString())
                    {
                        MessageBox.Show(string.Format(SaleReturnLocalizedResources.SerieNoIsRequiredMessage,
                                                     objSaleReturnItemsInfo.ARSaleReturnItemProductDesc),
                                                     CommonLocalizedResources.MessageBoxDefaultCaption,
                                                     MessageBoxButtons.OK,
                                                     MessageBoxIcon.Error);
                        return false;
                    }
                }
                if (objProductsInfo.HasComponent)
                {
                    foreach (ARSaleReturnItemComponentsInfo objSaleReturnItemComponentsInfo in objSaleReturnItemsInfo.SaleReturnItemComponentList)
                    {
                        objProductsInfo = (ICProductsInfo)objProductsController.GetObjectFromDataRow(BOSApp.GetObjectFromCatche("ICProducts", "ICProductID", objSaleReturnItemComponentsInfo.FK_ICProductID));
                        if (objProductsInfo.ICProductType != ProductType.Service.ToString() && !objProductsInfo.IsAsset)
                        {
                            if (string.IsNullOrEmpty(objSaleReturnItemComponentsInfo.ICProductSerieNo)
                                && objProductsInfo.ICPriceCalculationMethodMethod == PriceCalculationMethod.Specific.ToString())
                            {
                                MessageBox.Show(string.Format(SaleReturnLocalizedResources.SerieNoIsRequiredMessage,
                                                             objSaleReturnItemComponentsInfo.ICProductDesc),
                                                             CommonLocalizedResources.MessageBoxDefaultCaption,
                                                             MessageBoxButtons.OK,
                                                             MessageBoxIcon.Error);
                                return false;
                            }
                        }
                    }
                }
            }

            bool isSave = CheckSerialNoInSaleReturnItemsList();
            if (!isSave)
            {
                return false;
            }
            if (!InvalidProductUnitCost())
            {
                return false;
            }
            //Set cost of goods sold for sale return items
            bool isComplete = base.ActionComplete();
            if (isComplete)
            {
                ActionPosted();
                //Back up the sale return
                saleReturn.BackupObject = (BusinessObject)saleReturn.Clone();

                //Back up invoice item list
                entity.SaleReturnItemsList.BackupList.Clear();
                foreach (ARSaleReturnItemsInfo objInvoiceItemsInfo in entity.SaleReturnItemsList)
                {
                    entity.SaleReturnItemsList.BackupList.Add((ARSaleReturnItemsInfo)objInvoiceItemsInfo.Clone());
                }

                //Back up component invoice item list
                entity.ComponentSaleReturnItemList.BackupList.Clear();
                foreach (ARSaleReturnItemsInfo item in entity.ComponentSaleReturnItemList)
                {
                    entity.ComponentSaleReturnItemList.BackupList.Add((ARSaleReturnItemsInfo)item.Clone());
                }
            }
            return isComplete;
        }

        public override void ModuleAfterCompleted()
        {
            SaleReturnEntities entity = (SaleReturnEntities)CurrentModuleEntity;
            ARSaleReturnsInfo mainObject = (ARSaleReturnsInfo)CurrentModuleEntity.MainObject;

            entity.SetPropertyChangeEventLock(false);
            mainObject.ARSaleReturnPostedStatus = PostedTransactionStatus.Posted.ToString();
            entity.UpdateMainObject();
            GLHelper.PostedTransactions(this.Name, mainObject.ARSaleReturnID, ModulePostingType.Accounting, ModulePostingType.InvoiceTrans, ModulePostingType.Stock);
            entity.SetPropertyChangeEventLock(true);
            base.ModuleAfterCompleted();
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);

            SaleReturnEntities entity = (SaleReturnEntities)CurrentModuleEntity;
            ARSaleReturnsInfo mainObject = (ARSaleReturnsInfo)CurrentModuleEntity.MainObject;
            if (SaleReturnNoteEditControl != null)
            {
                SaleReturnNoteEditControl.OpenXmlBytes = (mainObject.ARSaleReturnNote != null && mainObject.ARSaleReturnNote.Length > 0) ? mainObject.ARSaleReturnNote : null;
            }
            ARInvoiceItemsController objInvoiceItemsController = new ARInvoiceItemsController();
            ListInvoiceItemsInfo = objInvoiceItemsController.GetInvoiceItemsForLookupSaleReturn(iObjectID, false);
            if (SaleReturnItemsGridControl != null)
            {
                SaleReturnItemsGridControl.ListInvoiceItemsInfo = ListInvoiceItemsInfo;
            }
            bool isWoodType = BOSApp.IsWoodTypeDocument(mainObject.ARSaleReturnProductType, entity.SaleReturnItemsList.FirstOrDefault());
            ChangeDisplayColumnByWoodType(entity.SaleReturnItemsList.GridControl, isWoodType);
        }

        public override void ChangeDisplayColumnByWoodType(BOSGridControl gridControl, bool isWoodType)
        {
            base.ChangeDisplayColumnByWoodType(gridControl, isWoodType);
            if (gridControl == null)
                return;
            GridView gridView = (GridView)gridControl.MainView;
            if (gridView == null)
                return;
            GridColumn woodQtyColumn = gridView.Columns["ARSaleReturnItemWoodQty"];
            GridColumn qtyColumn = gridView.Columns["ARSaleReturnItemProductQty"];

            List<string> qtyColumnsList = new List<string>() { "ARSaleReturnItemProductQty" };

            if (isWoodType)
            {
                if (woodQtyColumn == null)
                {
                    woodQtyColumn = new GridColumn();
                    woodQtyColumn.FieldName = "ARSaleReturnItemWoodQty";
                    woodQtyColumn.Caption = CommonLocalizedResources.WoodQtyText;
                    woodQtyColumn.OptionsColumn.AllowEdit = true;
                    woodQtyColumn.VisibleIndex = qtyColumn.VisibleIndex + 1;
                    gridView.Columns.Add(woodQtyColumn);
                }
                else
                {
                    woodQtyColumn.Caption = CommonLocalizedResources.WoodQtyText;
                    woodQtyColumn.VisibleIndex = qtyColumn.VisibleIndex + 1;
                    woodQtyColumn.OptionsColumn.AllowEdit = true;
                }
            }
            else
            {
                if (woodQtyColumn != null)
                    gridView.Columns.Remove(woodQtyColumn);
            }
            //SetQtyColumnFormat(gridControl, isWoodType, qtyColumnsList);
        }

        public void ActionPosted()
        {
            if (!CheckLock()) return;
            SaleReturnEntities entity = (SaleReturnEntities)CurrentModuleEntity;
            ARSaleReturnsInfo mainObject = (ARSaleReturnsInfo)CurrentModuleEntity.MainObject;

            entity.SetPropertyChangeEventLock(false);
            mainObject.ARSaleReturnPostedStatus = PostedTransactionStatus.Posted.ToString();
            entity.UpdateMainObject();
            entity.SetPropertyChangeEventLock(true);
            GLHelper.PostedTransactions(this.Name, mainObject.ARSaleReturnID, ModulePostingType.Accounting, ModulePostingType.InvoiceTrans, ModulePostingType.Stock);
            InvalidateToolbar();
        }

        public void ActionUnPosted()
        {
            if (!CheckLock()) return;
            SaleReturnEntities entity = (SaleReturnEntities)CurrentModuleEntity;
            ARSaleReturnsInfo mainObject = (ARSaleReturnsInfo)CurrentModuleEntity.MainObject;

            entity.SetPropertyChangeEventLock(false);
            mainObject.ARSaleReturnPostedStatus = PostedTransactionStatus.UnPosted.ToString();
            entity.UpdateMainObject();
            entity.SetPropertyChangeEventLock(true);
            GLHelper.UnPostedTransactions(this.Name, mainObject.ARSaleReturnID, ModulePostingType.Accounting, ModulePostingType.InvoiceTrans, ModulePostingType.Stock);
            InvalidateToolbar();
        }
        #endregion

        #region Action
        public override void ActionNew()
        {
            base.ActionNew();
            SaleReturnEntities entity = (SaleReturnEntities)CurrentModuleEntity;
            ARSaleReturnsInfo mainObject = (ARSaleReturnsInfo)entity.MainObject;
            mainObject.ARSaleReturnSerialNo = entity.GetSaleReturnSerialNo();
            mainObject.ARSaleReturnProductType = SaleReturnProductType.Product.ToString();
            SetDefaulSaleReturnNote();
            if (ProductLookupControl != null)
            {
                ProductLookupControl.EditValue = 0;
            }
            entity.UpdateMainObjectBindingSource();
        }

        public void ActionNewFromInvoice()
        {
            base.ActionNew();

            SetDefaulSaleReturnNote();
            SaleReturnEntities entity = (SaleReturnEntities)CurrentModuleEntity;
            entity.RefundableInvoiceItems.SetDefaultListAndRefreshGridControl();
            ARInvoicesController objInvoicesController = new ARInvoicesController();
            guiChooseInvoiceItem guiChooseInvoiceItem = new guiChooseInvoiceItem();
            guiChooseInvoiceItem.Module = this;

        stampp:
            guiChooseInvoiceItem.ShowDialog();
            if (guiChooseInvoiceItem.DialogResult != DialogResult.OK || guiChooseInvoiceItem.SelectedObject.Count == 0)
            {
                ActionCancel();
                return;
            }
            List<ARInvoiceItemsInfo> invoiceItems = (List<ARInvoiceItemsInfo>)guiChooseInvoiceItem.SelectedObject;
            if (invoiceItems.Select(o => o.FK_ARInvoiceID).Distinct().Count() > 1)
            {
                MessageBox.Show(SaleReturnLocalizedResources.ChooseInvoiceItemMessage,
                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                goto stampp;
            }
            ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)objInvoicesController.GetObjectByID(invoiceItems.Select(o => o.FK_ARInvoiceID).FirstOrDefault());
            entity.GenerateEntitiesFromInvoice(objInvoicesInfo, invoiceItems);
            SetDefaultDesc();
            UpdateTotalAmount();

            if (entity.SaleReturnItemsList.Count() > 0)
            {
                entity.SaleReturnItemsList.GridControl.RefreshDataSource();
                entity.SaleReturnItemsList.GridViewFocusRow(entity.SaleReturnItemsList.Count() - 1);
            }
            ChangeDisplayAndDataItemListGridView();
        }

        public void AddItemToSaleReturnItemsList()
        {
            SaleReturnEntities entity = (SaleReturnEntities)CurrentModuleEntity;
            ARSaleReturnsInfo mainObject = (ARSaleReturnsInfo)entity.MainObject;
            ARSaleReturnItemsInfo objSaleReturnItemsInfo = (ARSaleReturnItemsInfo)entity.ModuleObjects[TableName.ARSaleReturnItemsTableName];
            if (objSaleReturnItemsInfo.FK_ICProductID > 0)
            {
                entity.SetValuesAfterValidateProduct(objSaleReturnItemsInfo.FK_ICProductID);
                ICProductsController objProductsController = new ICProductsController();
                ICProductsInfo objProductsInfo = new ICProductsInfo();
                ARCustomersController objCustomersController = new ARCustomersController();
                ARCustomersInfo objCustomersInfo = (ARCustomersInfo)objCustomersController.GetObjectByID(mainObject.FK_ARCustomerID);
                objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objSaleReturnItemsInfo.FK_ICProductID);
                objSaleReturnItemsInfo.ARSaleReturnItemProductCustomerNumber = objProductsInfo.ICProductCustomerNumber;
                objSaleReturnItemsInfo.ARSaleReturnItemProductNoOfOldSys = objProductsInfo.ICProductNoOfOldSys;
                objSaleReturnItemsInfo.ICProductNo = objProductsInfo.ICProductNo;
                objSaleReturnItemsInfo.FK_ICStockID = mainObject.FK_ICStockID;
                objSaleReturnItemsInfo.ARSaleReturnItemProductSerialNo = mainObject.ARSaleReturnSerialNo;
                objSaleReturnItemsInfo.ARSaleReturnItemProductFactor = 1;
                objSaleReturnItemsInfo.ARSaleReturnItemProductUnitPrice = BOSApp.CalculaterProductUnitPrice(objProductsInfo,
                                                                                                                objSaleReturnItemsInfo.ARSaleReturnItemProductUnitPrice,
                                                                                                                objSaleReturnItemsInfo.ARSaleReturnItemProductQty,
                                                                                                                objSaleReturnItemsInfo.FK_ICMeasureUnitID,
                                                                                                                objCustomersInfo != null ? objCustomersInfo.ARCustomerID : 0,
                                                                                                                mainObject.ARSaleReturnGetPriceDate,
                                                                                                                mainObject.FK_GECurrencyID);
                entity.SetProductPriceByProductUnitPrice(objSaleReturnItemsInfo);
                entity.SaleReturnItemsList.AddObjectToList();
                UpdateTotalAmount();
            }
        }

        public void ChangeItemFromSaleReturnItemsList()
        {
            SaleReturnEntities entity = (SaleReturnEntities)CurrentModuleEntity;
            entity.SetProductPriceByProductUnitPrice();
            entity.SaleReturnItemsList.ChangeObjectFromList();
            UpdateTotalAmount();
        }

        public void DeleteItemFromSaleReturnItemsList()
        {
            SaleReturnEntities entity = (SaleReturnEntities)CurrentModuleEntity;
            entity.SaleReturnItemsList.RemoveSelectedRowObjectFromList();
            UpdateTotalAmount();
        }

        public void ChangeDiscountPercent()
        {
            UpdateTotalAmount();
        }

        public void ChangeDiscountAmount()
        {
            SaleReturnEntities entity = (SaleReturnEntities)CurrentModuleEntity;
            ARSaleReturnsInfo objSaleReturnsInfo = (ARSaleReturnsInfo)entity.MainObject;
            if (objSaleReturnsInfo.ARSaleReturnSubTotalAmount > 0)
            {
                objSaleReturnsInfo.ARSaleReturnDiscountPerCent = objSaleReturnsInfo.ARSaleReturnDiscountFix / objSaleReturnsInfo.ARSaleReturnSubTotalAmount * 100;
            }
            UpdateTotalAmount();
        }

        public void ChangeTaxPercent()
        {
            UpdateTotalAmount();
        }

        public void ChangeTaxAmount()
        {
            SaleReturnEntities entity = (SaleReturnEntities)CurrentModuleEntity;
            ARSaleReturnsInfo objSaleReturnsInfo = (ARSaleReturnsInfo)entity.MainObject;
            if (objSaleReturnsInfo.ARSaleReturnSubTotalAmount - objSaleReturnsInfo.ARSaleReturnDiscountFix > 0)
            {
                objSaleReturnsInfo.ARSaleReturnTaxPercent = objSaleReturnsInfo.ARSaleReturnTaxAmount /
                                                            (objSaleReturnsInfo.ARSaleReturnSubTotalAmount - objSaleReturnsInfo.ARSaleReturnDiscountFix) * 100;
            }
            UpdateTotalAmount();
        }

        public void UpdateTotalAmount()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                SaleReturnEntities entity = (SaleReturnEntities)CurrentModuleEntity;
                entity.UpdateTotalAmount();
                UpdateDocumentEntries();
            }
        }

        private void SetDefaultDesc()
        {
            ARSaleReturnsInfo saleReturn = (ARSaleReturnsInfo)CurrentModuleEntity.MainObject;
            ARCustomersController objCustomersController = new ARCustomersController();
            if (saleReturn.ARObjectType == ObjectType.Customer.ToString() && saleReturn.FK_ACObjectID != 0)
                saleReturn.FK_ARCustomerID = saleReturn.FK_ACObjectID;
            ARCustomersInfo customer = (ARCustomersInfo)objCustomersController.GetObjectByID(saleReturn.FK_ARCustomerID);
            if (customer != null)
            {
                saleReturn.ARSaleReturnDesc = "Nhập hàng trả lại của {0} {1}";
                saleReturn.ARSaleReturnDesc = saleReturn.ARSaleReturnDesc.Replace("{0}", customer.ARCustomerName);
                saleReturn.ARSaleReturnDesc = saleReturn.ARSaleReturnDesc.Replace("{1}", saleReturn.ARInvoiceNo);
            }
        }

        private void SetDefaulSaleReturnNote()
        {
            ARSaleReturnsInfo mainObject = (ARSaleReturnsInfo)CurrentModuleEntity.MainObject;

            byte[] RTFByte = BOSApp.GetDefaultDescConfig(this.Name, string.Empty);
            if (SaleReturnNoteEditControl != null)
            {
                if (RTFByte != null && RTFByte.Length > 0)
                {
                    MemoryStream RTFStream = new MemoryStream(RTFByte);
                    SaleReturnNoteEditControl.LoadDocument(RTFStream, DocumentFormat.Rtf);
                    mainObject.ARSaleReturnNote = SaleReturnNoteEditControl.OpenXmlBytes;
                }
                else
                {
                    SaleReturnNoteEditControl.OpenXmlBytes = null;
                    mainObject.ARSaleReturnNote = SaleReturnNoteEditControl.OpenXmlBytes;
                }
            }
            CurrentModuleEntity.UpdateMainObjectBindingSource();
        }


        public void ActionEditAfterCompleting()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                IsEditAfterCompleting = true;
                if (!CheckRelativeDocument()) {
                    IsEditAfterCompleting = false;
                    return;
                }
               
                ActionUnPosted();
                base.ActionEdit();

                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonSave, true);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
            }
        }
        private bool CheckRelativeDocument()
        {
            ARSaleReturnsInfo mainObject = (ARSaleReturnsInfo)CurrentModuleEntity.MainObject;
            ICTransactionsController objTransactionsController = new ICTransactionsController();
            List<ICTransactionsInfo> listShipment = objTransactionsController.GetShipmentReferenceByReceiptID(mainObject.ARSaleReturnID, TableName.ARSaleReturnItemsTableName);
            if (listShipment.Count() > 0)
            {
                MessageBox.Show("Chứng từ này đã tạo chứng từ xuất kho hoặc số lượng tồn kho hiện tại không đủ." + Environment.NewLine
                                + string.Join(",", listShipment.Select(o => o.ICTransactionReferenceNo).Distinct().ToArray())
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public void ChangeACEInvoiceTypeNo(int invoiceTypeID)
        {
            SaleReturnEntities entity = (SaleReturnEntities)CurrentModuleEntity;
            ARSaleReturnsInfo objSaleReturnsInfo = (ARSaleReturnsInfo)entity.MainObject;
            ACEInvoiceTypesController objEInvoiceTypesController = new ACEInvoiceTypesController();
            ACEInvoiceTypesInfo objEInvoiceTypesInfo = (ACEInvoiceTypesInfo)objEInvoiceTypesController.GetObjectByID(invoiceTypeID);
            if (objEInvoiceTypesInfo != null)
            {
                objSaleReturnsInfo.ARSaleReturnVATFormNo = objEInvoiceTypesInfo.ACEInvoiceTypeTemplateCode;
                objSaleReturnsInfo.ARSaleReturnVATSymbol = objEInvoiceTypesInfo.ACEInvoiceTypeSeries;
            }
            else
            {
                objSaleReturnsInfo.ARSaleReturnVATFormNo = string.Empty;
                objSaleReturnsInfo.ARSaleReturnVATSymbol = string.Empty;
            }
            entity.UpdateMainObjectBindingSource();
        }

        public void ChangeSaleReturnProductType(string saleReturnProductType)
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                ARSaleReturnsInfo mainObject = (ARSaleReturnsInfo)CurrentModuleEntity.MainObject;
                mainObject.ARSaleReturnProductType = saleReturnProductType;
                CurrentModuleEntity.UpdateMainObjectBindingSource();
                ChangeDisplayAndDataItemListGridView();
            }
        }

        public void ChangeDisplayAndDataItemListGridView()
        {
            SaleReturnEntities entity = (SaleReturnEntities)CurrentModuleEntity;
            ARSaleReturnsInfo mainObject = (ARSaleReturnsInfo)CurrentModuleEntity.MainObject;

            bool isWoodType = BOSApp.IsWoodTypeDocument(mainObject.ARSaleReturnProductType, entity.SaleReturnItemsList.FirstOrDefault());

            ChangeDisplayColumnByWoodType(entity.SaleReturnItemsList.GridControl, isWoodType);
            if (!isWoodType)
                entity.SaleReturnItemsList.ForEach(o1 => o1.ARSaleReturnItemLotNo = string.Empty);
        }

        public void ChangeComponentItemQty()
        {
            SaleReturnEntities entity = (SaleReturnEntities)CurrentModuleEntity;
            if (entity.SaleReturnItemsList.CurrentIndex >= 0)
            {
                ARSaleReturnItemsInfo objSaleReturnItemsInfo = entity.SaleReturnItemsList[entity.SaleReturnItemsList.CurrentIndex];
                if (objSaleReturnItemsInfo.SaleReturnItemComponentList != null)
                {
                    objSaleReturnItemsInfo.SaleReturnItemComponentList.Clear();
                    BOSList<ARSaleReturnItemComponentsInfo> listComponents = new BOSList<ARSaleReturnItemComponentsInfo>();
                    listComponents.InitBOSList(
                                        entity,
                                        TableName.ARSaleReturnItemsTableName,
                                        TableName.ARSaleReturnItemComponentsTableName,
                                        BOSList<ARSaleReturnItemComponentsInfo>.cstRelationForeign);
                    listComponents.ItemTableForeignKey = "FK_ARSaleReturnItemID";
                    ICProductComponentsController objProductComponentsController = new ICProductComponentsController();
                    List<ICProductComponentsInfo> components = objProductComponentsController.GetProductComponentListByProductID(objSaleReturnItemsInfo.FK_ICProductID);
                    foreach (ICProductComponentsInfo objProductComponentsInfo in components)
                    {
                        ARSaleReturnItemComponentsInfo objSaleReturnItemComponentsInfo = new ARSaleReturnItemComponentsInfo();
                        objSaleReturnItemComponentsInfo.FK_ICProductID = objProductComponentsInfo.FK_ICProductComponentChildID;
                        objSaleReturnItemComponentsInfo.ARSaleReturnItemComponentQty = objProductComponentsInfo.ICProductComponentQty * objSaleReturnItemsInfo.ARSaleReturnItemProductQty;
                        objSaleReturnItemComponentsInfo.ICProductComponentQty = objProductComponentsInfo.ICProductComponentQty;
                        objSaleReturnItemComponentsInfo.ICProductDesc = objProductComponentsInfo.ICProductDesc;
                        objSaleReturnItemComponentsInfo.ICProductSupplierNo = objProductComponentsInfo.ICProductSupplierNo;
                        objSaleReturnItemComponentsInfo.FK_ICStockID = objSaleReturnItemsInfo.FK_ICStockID;
                        objSaleReturnItemComponentsInfo.FK_ICProductSerieID = objSaleReturnItemsInfo.FK_ICProductSerieID;
                        listComponents.Add(objSaleReturnItemComponentsInfo);
                    }
                    if (listComponents != null && listComponents.Count > 0)
                    {
                        foreach (ARSaleReturnItemComponentsInfo item in listComponents)
                        {
                            item.ARSaleReturnItemComponentQty = objSaleReturnItemsInfo.ARSaleReturnItemProductQty * item.ICProductComponentQty;
                            objSaleReturnItemsInfo.SaleReturnItemComponentList.Add(item);
                        }
                    }
                }
            }
        }

        public void InitProductPictureImage(int productID)
        {
            if (productID > 0 && ProductPicturePictureBox != null)
            {
                ProductPicturePictureBox.Image = BOSApp.GetProductPictureImageByProductID(productID);
                ProductPicturePictureBox.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            }
        }
        #endregion

        #region Item component
        /// <summary>
        /// Show invoice item component form
        /// </summary>
        public void ShowItemComponent()
        {
            if (IsEditable())
            {
                ActionEdit();
            }

            SaleReturnEntities entity = (SaleReturnEntities)CurrentModuleEntity;
            if (entity.SaleReturnItemsList.CurrentIndex >= 0)
            {
                ARSaleReturnItemsInfo objSaleReturnItemsInfo = entity.SaleReturnItemsList[entity.SaleReturnItemsList.CurrentIndex];
                //if (objSaleReturnItemsInfo.SaleReturnItemComponentList == null || objSaleReturnItemsInfo.SaleReturnItemComponentList.Count == 0)
                //{
                //    MessageBox.Show(SaleReturnLocalizedResources.ItemHasNoComponent,
                //                    CommonLocalizedResources.MessageBoxDefaultCaption,
                //                    MessageBoxButtons.OK,
                //                    MessageBoxIcon.Information);
                //    return;
                //}

                guiItemComponent<ARSaleReturnItemComponentsInfo> guiItemComponent = new guiItemComponent<ARSaleReturnItemComponentsInfo>(objSaleReturnItemsInfo.SaleReturnItemComponentList);
                guiItemComponent.Module = this;
                if (guiItemComponent.ShowDialog() == DialogResult.OK)
                {
                    objSaleReturnItemsInfo.SaleReturnItemComponentList.Clear();
                    if (guiItemComponent.ItemComponentList.Count > 0)
                    {
                        foreach (ICProductComponentsInfo objProductComponentsInfo in guiItemComponent.ItemComponentList)
                        {
                            ARSaleReturnItemComponentsInfo itemComponent = new ARSaleReturnItemComponentsInfo();
                            itemComponent.ARSaleReturnItemComponentID = objProductComponentsInfo.ItemComponentID;
                            itemComponent.FK_ICProductID = objProductComponentsInfo.FK_ICProductComponentChildID;
                            itemComponent.ICProductSupplierNo = objProductComponentsInfo.ICProductSupplierNo;
                            itemComponent.ICProductDesc = objProductComponentsInfo.ICProductDesc;
                            itemComponent.FK_ICStockID = objProductComponentsInfo.FK_ICStockID;
                            itemComponent.FK_ICProductSerieID = objProductComponentsInfo.FK_ICProductSerieID;
                            itemComponent.ICProductSerieNo = objProductComponentsInfo.ICProductSerialNo;
                            itemComponent.ARSaleReturnItemComponentQty = objProductComponentsInfo.ICProductComponentQty;
                            objSaleReturnItemsInfo.SaleReturnItemComponentList.Add(itemComponent);
                        }
                    }
                }
            }
        }

        public void UpdateTotalAmountByCurrency(int currencieID)
        {
            SaleReturnEntities entity = (SaleReturnEntities)CurrentModuleEntity;
            ARSaleReturnsInfo mainObject = (ARSaleReturnsInfo)CurrentModuleEntity.MainObject;
            mainObject.FK_GECurrencyID = currencieID;
            foreach (ARSaleReturnItemsInfo item in entity.SaleReturnItemsList)
            {
                BOSApp.RoundByCurrency(item, mainObject.FK_GECurrencyID);
            }
            GECurrencyExchangeRatesController objCurrencyExchangeRatesController = new GECurrencyExchangeRatesController();
            decimal exchangeRateValue = objCurrencyExchangeRatesController.GetCurrencyExchangeRateTransferByCurrencyIDAndDate(currencieID, mainObject.ARSaleReturnDate);
            if (exchangeRateValue > 0)
            {
                mainObject.ARSaleReturnExchangeRate = exchangeRateValue;
            }
            UpdateTotalAmount();
            entity.SaleReturnItemsList.GridControl.RefreshDataSource();

            entity.UpdateMainObjectBindingSource();
        }

        public void ChangeObject(string acObjectAssetKey)
        {
            SaleReturnEntities entity = (SaleReturnEntities)CurrentModuleEntity;
            ARSaleReturnsInfo objSaleReturnsInfo = (ARSaleReturnsInfo)entity.MainObject;
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(acObjectAssetKey);
            objObjectsInfo = objObjectsController.GetObjectByIDAndType(objObjectsInfo.ACObjectID, objObjectsInfo.ACObjectType);
            if (objObjectsInfo.ACObjectType == ObjectType.Customer.ToString())
                objSaleReturnsInfo.FK_ARCustomerID = objObjectsInfo.ACObjectID;
            objSaleReturnsInfo.FK_ACObjectID = objObjectsInfo.ACObjectID;
            objSaleReturnsInfo.ARObjectType = objObjectsInfo.ACObjectType;
            SetDefaultDesc();
            entity.UpdateMainObjectBindingSource();
            CalculaterProductUnitPrice();
            UpdateDocumentEntries();
        }

        public void ChangeCustomer(int customerID)
        {
            SaleReturnEntities entity = (SaleReturnEntities)CurrentModuleEntity;
            ARSaleReturnsInfo objSaleReturnsInfo = (ARSaleReturnsInfo)entity.MainObject;
            objSaleReturnsInfo.FK_ARCustomerID = customerID;
            UpdateDocumentEntries();
        }

        public void ShowRefundableInvoiceItems(string invoiceNo, string VATInvoiceNo, int? customerID, DateTime? fromDate, DateTime? toDate)
        {
            ARInvoiceItemsController objInvoiceItemsController = new ARInvoiceItemsController();
            List<ARInvoiceItemsInfo> invoiceItems = objInvoiceItemsController.GetRefundableInvoiceItemsByUserPermission(invoiceNo, VATInvoiceNo, customerID, fromDate, toDate,
                                                                                                        BOSApp.CurrentUsersInfo.ADUserID,
                                                                                                        ModuleName.Invoice,
                                                                                                        ADDataViewPermissionType.Module);
            SaleReturnEntities entity = (SaleReturnEntities)CurrentModuleEntity;
            entity.RefundableInvoiceItems.Invalidate(invoiceItems.OrderByDescending(o => o.ARInvoiceDate).ToList());
        }

        public void ChangeSaleReturnItemProductQty(ARSaleReturnItemsInfo objSaleReturnItemsInfo)
        {
            SaleReturnEntities entity = (SaleReturnEntities)CurrentModuleEntity;
            ARSaleReturnsInfo mainobject = (ARSaleReturnsInfo)entity.MainObject;
            if (mainobject.FK_ARInvoiceID == 0)
                return;
            ARSaleReturnItemsController objSaleReturnItemsController = new ARSaleReturnItemsController();
            List<ARSaleReturnItemsInfo> saleReturnItemList = objSaleReturnItemsController.GetSaleReturnItemsByInvoiceItemID(objSaleReturnItemsInfo.FK_ARInvoiceItemID);
            decimal sumQty = saleReturnItemList.Where(o => objSaleReturnItemsInfo.ARSaleReturnItemID != 0 && o.ARSaleReturnItemID != objSaleReturnItemsInfo.ARSaleReturnItemID)
                                               .Select(o => o.ARSaleReturnItemProductExchangeQty).Sum();
            ARInvoiceItemsController objInvoiceItemsController = new ARInvoiceItemsController();
            ARInvoiceItemsInfo objInvoiceItemsInfo = (ARInvoiceItemsInfo)objInvoiceItemsController.GetObjectByID(objSaleReturnItemsInfo.FK_ARInvoiceItemID);
            if (objInvoiceItemsInfo == null)
                objInvoiceItemsInfo = new ARInvoiceItemsInfo();
            if (objInvoiceItemsInfo.ARInvoiceItemProductExchangeQty >= (sumQty + objSaleReturnItemsInfo.ARSaleReturnItemProductExchangeQty))
                return;
            MessageBox.Show(String.Format(SaleReturnLocalizedResources.ProductQtyErrorMessage, objSaleReturnItemsInfo.ICProductNo),
                            CommonLocalizedResources.MessageBoxDefaultCaption,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
            objSaleReturnItemsInfo.ARSaleReturnItemProductExchangeQty = objInvoiceItemsInfo.ARInvoiceItemProductExchangeQty - sumQty;
            objSaleReturnItemsInfo.ARSaleReturnItemProductQty = (objInvoiceItemsInfo.ARInvoiceItemProductExchangeQty - sumQty) / (objSaleReturnItemsInfo.ARSaleReturnItemProductFactor != 0 ? objSaleReturnItemsInfo.ARSaleReturnItemProductFactor: 1) ;
            entity.SaleReturnItemsList.GridControl.RefreshDataSource();
        }

        public void CalculaterProductUnitPrice()
        {
            if(Toolbar.IsNullOrNoneAction())
            {
                return;
            }    

            SaleReturnEntities entity = (SaleReturnEntities)CurrentModuleEntity;
            ARSaleReturnsInfo mainObject = (ARSaleReturnsInfo)entity.MainObject;
            decimal calUnitPrice = 0M;
            CSCompanysInfo objCompanysInfo = BOSApp.CurrentCompanyInfo;
            ICProductsInfo product = new ICProductsInfo();
            ARCustomersController objCustomersController = new ARCustomersController();
            ARCustomersInfo objCustomersInfo = (ARCustomersInfo)objCustomersController.GetObjectByID(mainObject.FK_ARCustomerID);

            foreach (ARSaleReturnItemsInfo item in entity.SaleReturnItemsList)
            {
                calUnitPrice = 0M;
                product = BOSApp.GetProductFromCurrentProductList(item.FK_ICProductID);
                if (product != null && objCompanysInfo != null)
                {
                    if (objCompanysInfo.CSSourceSellingPriceMethod == SourceSellingPriceMethod.MasterData.ToString())
                    {
                        calUnitPrice = product.ICProductPrice01;
                    }
                    else if (objCompanysInfo.CSSourceSellingPriceMethod == SourceSellingPriceMethod.PriceSheet.ToString())
                    {
                        ARPriceSheetItemsController objPriceSheetItemsController = new ARPriceSheetItemsController();
                        List<ARPriceSheetItemsInfo> newParams = new List<ARPriceSheetItemsInfo>()
                        {
                            new ARPriceSheetItemsInfo(objCustomersInfo != null ? objCustomersInfo.ARCustomerID : 0, product.ICProductID, item.FK_ICMeasureUnitID, mainObject.ARSaleReturnGetPriceDate)
                        };
                        List<ARPriceSheetItemsInfo> listPriceSheets = objPriceSheetItemsController.GetPriceSheetInActiveByProductIDs(newParams);
                        ARPriceSheetItemsInfo objPriceSheetItemsInfo = listPriceSheets.Where(o => o.ARPriceSheetItemQty <= item.ARSaleReturnItemProductQty
                                                                                                && o.FK_ICProductID == product.ICProductID
                                                                                                && o.FK_GECurrencyID == mainObject.FK_GECurrencyID).OrderByDescending(o => o.ARPriceSheetItemQty).FirstOrDefault();
                        if (objPriceSheetItemsInfo == null)
                            calUnitPrice = 0;
                        else
                            calUnitPrice = objPriceSheetItemsInfo.ARPriceSheetItemPrice;
                    }
                    item.ARSaleReturnItemProductUnitPrice = calUnitPrice;
                    entity.SetProductPriceByProductUnitPrice(item);
                }
            }
            UpdateTotalAmount();
        }
        public void CheckSaleReturnProductQty()
        {
            SaleReturnEntities entity = (SaleReturnEntities)CurrentModuleEntity;
            ARSaleReturnsInfo mainObject = (ARSaleReturnsInfo)entity.MainObject;
            ARSaleReturnItemsInfo objSaleReturnItemsInfo = (ARSaleReturnItemsInfo)entity.SaleReturnItemsList[entity.SaleReturnItemsList.CurrentIndex];
            ARInvoiceItemsController objInvoiceItemsController = new ARInvoiceItemsController();
            ARInvoiceItemsInfo objInvoiceItemsInfo = (ARInvoiceItemsInfo)objInvoiceItemsController.GetReturnInvoiceItemByInvoiceItemID(objSaleReturnItemsInfo.FK_ARInvoiceItemID, objSaleReturnItemsInfo.ARSaleReturnItemID);
            if (objInvoiceItemsInfo != null)
            {
                if (objSaleReturnItemsInfo.ARSaleReturnItemProductQty > objInvoiceItemsInfo.ARInvoiceItemProductQty - objInvoiceItemsInfo.ARInvoiceItemReturnQty)
                {
                    MessageBox.Show(SaleReturnLocalizedResources.CheckSaleReturnItemProductQty, CommonLocalizedResources.MessageBoxDefaultCaption,
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    objSaleReturnItemsInfo.ARSaleReturnItemProductQty = objInvoiceItemsInfo.ARInvoiceItemProductQty - objInvoiceItemsInfo.ARInvoiceItemReturnQty;
                }    
            }    
        }

        public bool CheckSerialNoInSaleReturnItemsList()
        {
            SaleReturnEntities entity = (SaleReturnEntities)CurrentModuleEntity;
            ARSaleReturnsInfo mainObject = (ARSaleReturnsInfo)entity.MainObject;
            List<string> productError = new List<string>();

            List<ICTransactionsInfo> invalidSerialNoList = mainObject.ARSaleReturnID == 0 ? entity.SaleReturnItemsList.GetInvalidSerialNo() : entity.SaleReturnItemsList.GetInvalidSerialNoBySomeCriteria();
            if (invalidSerialNoList.Count() > 0 && mainObject.FK_ARInvoiceID <= 0)
            {
                MessageBox.Show(string.Format("Mã lô hàng của các sản phẩm sau đã tồn tại:\n- {0}", string.Join("\n- ", invalidSerialNoList.Select(o1 => string.Format("{0}: {1}", o1.ICProductNo, o1.ICTransactionReceiptSerialNo)).ToArray())),
                                CommonLocalizedResources.MessageBoxDefaultCaption, 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            foreach (ARSaleReturnItemsInfo saleReturnItemsInfo in entity.SaleReturnItemsList)
            {
                if (saleReturnItemsInfo.FK_ICStockID == 0)
                {
                    MessageBox.Show("Vui lòng chọn kho cho sản phẩm !",
                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    return false;
                }

                List<ARSaleReturnItemsInfo> listValidateItems = entity.SaleReturnItemsList.Where(p => p.FK_ICProductID == saleReturnItemsInfo.FK_ICProductID
                                                                                           && p.ARSaleReturnItemProductSerialNo == saleReturnItemsInfo.ARSaleReturnItemProductSerialNo
                                                                                           && p.ARSaleReturnItemLotNo == saleReturnItemsInfo.ARSaleReturnItemLotNo
                                                                                           && p.ARSaleReturnItemProductUnitCost != saleReturnItemsInfo.ARSaleReturnItemProductUnitCost).ToList();
                if (listValidateItems.Count > 0)
                {
                    productError.Add(saleReturnItemsInfo.ARSaleReturnItemProductDesc);
                }
            }
            if (productError.Count > 0)
            {
                MessageBox.Show(string.Format("Mã lô/ Mã kiện (Mã đầu lóng) của sản phẩm trùng nhau nhưng khác giá vốn: \n -{0}", string.Join("\n-", productError.Distinct().ToArray()))
                                 + Environment.NewLine + "Vui lòng kiểm tra lại!"
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        public void ChangeStock(int stockID)
        {
            SaleReturnEntities entity = (SaleReturnEntities)CurrentModuleEntity;
            ARSaleReturnsInfo mainObject = (ARSaleReturnsInfo)entity.MainObject;
            mainObject.FK_ICStockID = stockID;
            if (!Toolbar.IsNullOrNoneAction())
            {
                if (entity.SaleReturnItemsList.Count > 0)
                {
                    if (MessageBox.Show(ShipmentLocalizedResources.ConfirmChangeItemStockMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (ARSaleReturnItemsInfo item in entity.SaleReturnItemsList)
                        {
                            item.FK_ICStockID = stockID;
                            if(mainObject.FK_ARInvoiceID > 0)
                            {
                                InvalidateItemSerieNo(item, "ARSaleReturnItems", "ARSaleReturnItemProductSerialNo");
                            }
                            ChangeItemComponentStock(item);
                        }
                        entity.SaleReturnItemsList.GridControl.RefreshDataSource();
                    }
                }
            }
            UpdateTotalAmount();
        }
        public List<ICProductsInfo> LoadProductList()
        {
            SaleReturnEntities entity = (SaleReturnEntities)CurrentModuleEntity;
            ARSaleReturnsInfo mainObject = (ARSaleReturnsInfo)entity.MainObject;
            ICProductsController objProductsController = new ICProductsController();
            List<ICProductsInfo> listProduct = new List<ICProductsInfo>();
            CSCompanysInfo objCompanysInfo = BOSApp.CurrentCompanyInfo;
            string sellingPriceMethod = objCompanysInfo.CSSourceSellingPriceMethod;
            if (sellingPriceMethod == ADConfigValueUtility.cstSourceSellingPriceMethodMasterData)
            {
                listProduct = objProductsController.GetAllProductForSaleToLookupEditBySaleOrderProductType(mainObject.ARSaleReturnProductType);
            }
            else if (sellingPriceMethod == ADConfigValueUtility.cstSourceSellingPriceMethodPriceSheet)
            {
                listProduct = objProductsController.GetSRProductListByInActivePriceSheet(mainObject.FK_ARCustomerID, mainObject.ARSaleReturnDate, mainObject.ARSaleReturnProductType);
            }
            return listProduct;
        }
        public void ChangeItemComponentStock(ARSaleReturnItemsInfo item)
        {
            if (item.SaleReturnItemComponentList != null && item.SaleReturnItemComponentList.Count > 0)
            {
                foreach (ARSaleReturnItemComponentsInfo com in item.SaleReturnItemComponentList)
                {
                    com.FK_ICStockID = item.FK_ICStockID;
                    com.FK_ICProductSerieID = item.FK_ICProductSerieID;
                };
            }
        }

        public bool InvalidProductUnitCost()
        {
            SaleReturnEntities entity = (SaleReturnEntities)CurrentModuleEntity;
            ARSaleReturnsInfo mainObject = (ARSaleReturnsInfo)entity.MainObject;
            //if(mainObject.FK_ARInvoiceID <= 0)
            //{
            //    return true;
            //}    

            ARSaleReturnItemsController objSaleReturnItemsController = new ARSaleReturnItemsController();
            List<ARSaleReturnItemsInfo> validateList = objSaleReturnItemsController.GetItemForInvalidProductUnitCost(mainObject.ARSaleReturnID);
            ARSaleReturnItemsInfo objValidate = new ARSaleReturnItemsInfo();
            string messageError = string.Empty;
            entity.SaleReturnItemsList.ForEach(item =>
            {
                objValidate = validateList.Where(o => o.ARSaleReturnItemID == item.ARSaleReturnItemID).FirstOrDefault();
                if (objValidate == null)
                    return;

                if (Math.Abs(item.ARSaleReturnItemExchangeUnitCost - objValidate.ICTransactionUnitCost) > 1 && item.ARSaleReturnItemExchangeUnitCost != 0)
                {
                    messageError = string.Format("Sản phẩm [{0}]- {1} - Lô [{2}] có giá vốn {3} khác với giá vốn nhập kho {4}.", objValidate.ICProductNo, objValidate.ICProductName, item.ARSaleReturnItemProductSerialNo, item.ARSaleReturnItemProductUnitCost, objValidate.ICTransactionUnitCost);                    
                }
            });
            if (!string.IsNullOrWhiteSpace(messageError))
            {
                messageError += "Bạn vui lòng kiểm tra lại!";
                MessageBox.Show(messageError, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public void ChangeSaleReturnItemSerieNo(ARSaleReturnItemsInfo item)
        {
            SaleReturnEntities entity = (SaleReturnEntities)CurrentModuleEntity;
            ARSaleReturnsInfo mainObject = (ARSaleReturnsInfo)entity.MainObject;
            if(mainObject.FK_ARInvoiceID > 0)
            {
                ARInvoicesController objInvoicesController = new ARInvoicesController();
                ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)objInvoicesController.GetObjectByID(mainObject.FK_ARInvoiceID);
                if(objInvoicesInfo != null)
                {
                    ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
                    ICProductSeriesInfo objProductSeriesInfo = (ICProductSeriesInfo)objProductSeriesController.GetObjectByNo(item.ARSaleReturnItemProductSerialNo);
                    if(objProductSeriesInfo != null)
                    {
                        item.FK_ICProductSerieID = objProductSeriesInfo.ICProductSerieID;
                        decimal unitCost = AccountHelper.GetProductUnitCost(item.FK_ICStockID, item.FK_ICProductID, item.ARSaleReturnItemProductSerialNo, objInvoicesInfo.ARInvoiceDate);
                        item.ARSaleReturnItemProductUnitCost = unitCost;
                        entity.SetProductPriceByProductUnitPrice(item);

                        ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(item.FK_ICProductID);
                        if (objProductsInfo != null)
                        {
                            if (objProductsInfo.ICProductType == ProductType.IngredientPaint.ToString() ||
                                   objProductsInfo.ICProductType == ProductType.Roundwood.ToString() ||
                                   objProductsInfo.ICProductType == ProductType.Reuse.ToString() ||
                                   objProductsInfo.ICProductType == ProductType.Lumber.ToString() ||
                                   objProductsInfo.ICProductType == ProductType.ArtificialBoard.ToString() ||
                                   objProductsInfo.ICProductType == ProductType.Verneer.ToString())
                            {
                                item.ARSaleReturnItemProductQty = Math.Round(item.ARSaleReturnItemProductQty, 5, MidpointRounding.AwayFromZero);
                            }
                            else
                            {
                                item.ARSaleReturnItemProductQty = Math.Round(item.ARSaleReturnItemProductQty, 3, MidpointRounding.AwayFromZero);
                            }
                        }
                        BOSApp.RoundByCurrency(item, mainObject.FK_GECurrencyID);
                        entity.SaleReturnItemsList.GridControl?.RefreshDataSource();
                        UpdateTotalAmount();
                    }
                }
            }
        }

        public void ChangeItemMeasureUnit()
        {
            SaleReturnEntities entity = (SaleReturnEntities)CurrentModuleEntity;
            ARSaleReturnsInfo mainObject = (ARSaleReturnsInfo)entity.MainObject;
            if (entity.SaleReturnItemsList.CurrentIndex < 0)
                return;

            ARSaleReturnItemsInfo item = entity.SaleReturnItemsList[entity.SaleReturnItemsList.CurrentIndex];
            ICProductMeasureUnitsController objProductMeasureUnitsController = new ICProductMeasureUnitsController();
            ICProductMeasureUnitsInfo objProductmeasureUnitsInfo = new ICProductMeasureUnitsInfo();
            objProductmeasureUnitsInfo = (ICProductMeasureUnitsInfo)objProductMeasureUnitsController.GetProductMeasureUnitByProductIDAndMeasureUnitID(item.FK_ICProductID, item.FK_ICMeasureUnitBeforeChangeID);
            decimal oldFactor = objProductmeasureUnitsInfo != null ? objProductmeasureUnitsInfo.ICProductMeasureUnitFactor : 1;
            objProductmeasureUnitsInfo = (ICProductMeasureUnitsInfo)objProductMeasureUnitsController.GetProductMeasureUnitByProductIDAndMeasureUnitID(item.FK_ICProductID, item.FK_ICMeasureUnitID);
            item.ARSaleReturnItemProductFactor = (objProductmeasureUnitsInfo != null && objProductmeasureUnitsInfo.ICProductMeasureUnitFactor > 0)
                                                ? objProductmeasureUnitsInfo.ICProductMeasureUnitFactor
                                                : 1;
            entity.SetProductPriceByProductUnitPrice(item);
            entity.SaleReturnItemsList.GridControl.RefreshDataSource();
        }

        public void ChangeItemInvoice(ARSaleReturnItemsInfo objSaleReturnItemsInfo)
        {
            SaleReturnEntities entity = (SaleReturnEntities)CurrentModuleEntity;
            ARSaleReturnsInfo mainObject = (ARSaleReturnsInfo)CurrentModuleEntity.MainObject;
            int invoiceItemID = objSaleReturnItemsInfo.FK_ARInvoiceItemID;
            if(invoiceItemID <= 0)
            {
                List<int> listInvoiceItemID = ListInvoiceItemsInfo.Where(o => o.FK_ICProductID == objSaleReturnItemsInfo.FK_ICProductID
                                                                         && o.FK_ARInvoiceID == objSaleReturnItemsInfo.FK_ARInvoiceID).Select(p => p.ARInvoiceItemID).Distinct().ToList();

                if (listInvoiceItemID.Count == 1)
                {
                    invoiceItemID = listInvoiceItemID[0];
                }
            }    
 
            if(invoiceItemID > 0)
            {
                ARInvoiceItemsController objInvoiceItemsController = new ARInvoiceItemsController();
                ARInvoiceItemsInfo objInvoiceItemsInfo = (ARInvoiceItemsInfo)objInvoiceItemsController.GetReturnInvoiceItemByInvoiceItemID(invoiceItemID, objSaleReturnItemsInfo.ARSaleReturnItemID);
                if (objInvoiceItemsInfo != null)
                {
                    if (objSaleReturnItemsInfo.ARSaleReturnItemProductQty <= objInvoiceItemsInfo.ARInvoiceItemProductQty - objInvoiceItemsInfo.ARInvoiceItemReturnQty)
                    {
                        objSaleReturnItemsInfo.FK_ARInvoiceItemID = objInvoiceItemsInfo.ARInvoiceItemID;
                        objSaleReturnItemsInfo.ICProductSerieNo = objInvoiceItemsInfo.ARInvoiceItemProductSerialNo;
                        objSaleReturnItemsInfo.ARSaleReturnItemProductSerialNo = objInvoiceItemsInfo.ARInvoiceItemProductSerialNo;
                        objSaleReturnItemsInfo.FK_ICProductSerieID = objInvoiceItemsInfo.FK_ICProductSerieID;
                        objSaleReturnItemsInfo.ARSaleReturnItemExchangeUnitCost = objInvoiceItemsInfo.ARInvoiceItemExchangeUnitCost;
                        objSaleReturnItemsInfo.ARSaleReturnItemProductUnitCost = objSaleReturnItemsInfo.ARSaleReturnItemExchangeUnitCost * objSaleReturnItemsInfo.ARSaleReturnItemProductFactor / (mainObject.ARSaleReturnExchangeRate > 0 ? mainObject.ARSaleReturnExchangeRate : 1);
                        entity.SetProductPriceByProductUnitPrice(objSaleReturnItemsInfo);
                    }
                }
            }  
        }

        public void CopyLine()
        {
            SaleReturnEntities entity = (SaleReturnEntities)CurrentModuleEntity;

            int index = entity.SaleReturnItemsList.CurrentIndex;
            if (index >= 0)
            {
                ARSaleReturnItemsInfo item = (ARSaleReturnItemsInfo)entity.SaleReturnItemsList[index];
                if (item != null)
                {
                    ARSaleReturnItemsInfo newItem = new ARSaleReturnItemsInfo();
                    BOSUtil.CopyObject(item, newItem);
                    newItem.ARSaleReturnItemProductSerialNo = string.Empty;
                    newItem.ICProductSerieNo = string.Empty;
                    newItem.FK_ARInvoiceID = 0;
                    newItem.FK_ARInvoiceItemID = 0;
                    newItem.ARSaleReturnItemProductUnitCost = 0;
                    newItem.ARSaleReturnItemExchangeUnitCost = 0;
                    entity.SetProductPriceByProductUnitPrice(newItem);

                    entity.SaleReturnItemsList.Add(newItem);
                    entity.SaleReturnItemsList.GridControl?.RefreshDataSource();
                }
            }
        }
        #endregion

        #region Load item from excel
        public void ActionImportProductFromExcel()
        {
            SaleReturnEntities entity = (SaleReturnEntities)CurrentModuleEntity;
            ARSaleReturnsInfo mainObject = (ARSaleReturnsInfo)entity.MainObject;
            if (mainObject.FK_ACObjectID == 0)
            {
                if (BOSApp.ShowMessageYesNo("Bạn chưa chọn khách hàng, hệ thống sẽ KHÔNG tự động lấy giá theo bảng giá, bạn có muốn tiếp tục không?") == DialogResult.No) return;
            }
            ImportProductToItem();
        }

        public bool ImportProductToItem()
        {
            string filePath = string.Empty;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Tập tin excel (*.xls;*.xlsx)|*.xls;*.xlsx";//MESLocalizedResources.DialogFilter;
            if (dialog.ShowDialog() == DialogResult.Cancel)
                return false;

            filePath = dialog.FileName;
            string extension = Path.GetExtension(filePath);
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + filePath + "';Extended Properties=\"Excel 8.0;HDR=YES;\"";
            if (extension.Equals(".xlsx"))
            {
                connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + filePath + "';Extended Properties=\"Excel 12.0;HDR=YES;\"";
            }
            BOSProgressBar.Start("Đang khởi tạo dữ liệu");
            DataSet ds = GetDataFromExcel(filePath, connectionString);
            DataTable dt = ds.Tables[0];            
            string tableName = string.Empty;
            AAColumnAliasController objColumnAliasController = new AAColumnAliasController();
            List<AAColumnAliasInfo> aliasImportsList = BOSApp.LstColumnAlias.Where(o => o.AATableName == "IPProducts").ToList();
            List<IPProductsInfo> listProductsInfo = new List<IPProductsInfo>();
            MappingToProductionItem(dt, listProductsInfo, aliasImportsList);
            BOSProgressBar.Close();
            
            guiImportProductItems guiFind = new guiImportProductItems(listProductsInfo, false);
            guiFind.Module = this;
            DialogResult rs = guiFind.ShowDialog();
            if (rs != DialogResult.OK)
                return false;

            return SaveSaleReturnItemsFromImport(guiFind.ProductsList);
        }

        public DataSet GetDataFromExcel(string filePath, string connectionString)
        {
            DataSet ds = new DataSet();
            try
            {
                List<string> sheetNames = new List<string>();
                System.Data.OleDb.OleDbDataAdapter command;

                string commandTemplate = "SELECT * FROM [{0}]";
                string commandRun = string.Empty;
                using (OleDbConnection cn = new OleDbConnection(connectionString))
                {
                    cn.Open();
                    DataTable dt = cn.GetSchema("Tables");
                    foreach (DataRow dr in dt.Rows)
                    {
                        sheetNames.Add(dr["TABLE_NAME"].ToString());
                    }
                    sheetNames.ForEach(o =>
                    {
                        commandRun = string.Format(commandTemplate, o);
                        command = new System.Data.OleDb.OleDbDataAdapter(commandRun, cn);
                        command.TableMappings.Add("Table", o);
                        command.Fill(ds);
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return ds;
        }

        public void MappingToProductionItem(DataTable dt, List<IPProductsInfo> productList, List<AAColumnAliasInfo> aliasImportsList)
        {
            IPProductsInfo objProductsInfo = new IPProductsInfo();
            foreach (DataRow row in dt.Rows)
            {
                objProductsInfo = (IPProductsInfo)GetObjectFromDataRow(row, objProductsInfo.GetType(), aliasImportsList);
                if (objProductsInfo != null && !string.IsNullOrWhiteSpace(objProductsInfo.IPProductNo))
                {
                    productList.Add(objProductsInfo);
                }
            }
        }

        public object GetObjectFromDataRow(DataRow row, Type type, List<AAColumnAliasInfo> aliasList)
        {
            object obj = type.InvokeMember("", System.Reflection.BindingFlags.CreateInstance, null, null, null);
            string columnName = string.Empty;
            AAColumnAliasInfo objColumnAliasInfo = new AAColumnAliasInfo();
            decimal decimalValue = 0;
            bool isConverter = false;
            foreach (DataColumn column in row.Table.Columns)
            {
                isConverter = false;
                object objValue = row[column];
                objColumnAliasInfo = aliasList.Where(o => o.AAColumnAliasCaption.ToLower() == column.ColumnName.ToLower()).FirstOrDefault();
                if (objColumnAliasInfo == null)
                    continue;

                PropertyInfo property = obj.GetType().GetProperty(objColumnAliasInfo.AAColumnAliasName);
                if (property != null)
                    property.SetValue(obj, ToPropertyDataType(column.DataType, property.PropertyType, objValue), null);
            }
            return obj;
        }

        public object ToPropertyDataType(Type fromType, Type toType, object objValue)
        {
            if (toType.Equals(typeof(string)) || toType.Equals(typeof(String)))
            {
                return objValue == null ? string.Empty : objValue.ToString().Trim();
            }
            if (objValue == null)
                return objValue;

            if (fromType.Equals(toType))
                return objValue;

            if (toType.Equals(typeof(decimal)) || toType.Equals(typeof(Decimal)))
            {
                decimal value = 0;
                Decimal.TryParse(objValue.ToString(), out value);
                return Math.Round(value, 5, MidpointRounding.AwayFromZero);
            }
            if (toType.Equals(typeof(int)))
            {
                decimal value = 0;
                Decimal.TryParse(objValue.ToString(), out value);
                return (int)value;
            }
            if (toType.Equals(typeof(bool)) || toType.Equals(typeof(Boolean)))
            {
                return !string.IsNullOrWhiteSpace(objValue.ToString());
            }
            return objValue;
        }

        public bool SaveSaleReturnItemsFromImport(List<IPProductsInfo> productList)
        {
            BOSProgressBar.Start("Đang lưu dữ liệu");
            bool isSaveSucess = true;

            SaleReturnEntities entity = (SaleReturnEntities)CurrentModuleEntity;
            ARSaleReturnsInfo mainObject = (ARSaleReturnsInfo)entity.MainObject;
            ICProductMeasureUnitsController controller = new ICProductMeasureUnitsController();
            ARSaleReturnItemsInfo item = new ARSaleReturnItemsInfo();
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            ARCustomersController objCustomersController = new ARCustomersController();
            ARCustomersInfo objCustomersInfo = (ARCustomersInfo)objCustomersController.GetObjectByID(mainObject.FK_ARCustomerID);
            List<ARInvoiceItemsInfo> listInvoiceItems = new List<ARInvoiceItemsInfo>();

            productList.ForEach(o =>
            {
                objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByNo(o.IPProductNo);
                item = new ARSaleReturnItemsInfo();
                item.FK_ICProductID = objProductsInfo.ICProductID;
                entity.SetValuesAfterValidateProduct(item.FK_ICProductID);
                item.ARSaleReturnItemProductCustomerNumber = objProductsInfo.ICProductCustomerNumber;
                item.ARSaleReturnItemProductNoOfOldSys = objProductsInfo.ICProductNoOfOldSys;
                item.ARSaleReturnItemProductName = objProductsInfo.ICProductName;
                item.ARSaleReturnItemProductDesc = objProductsInfo.ICProductDesc;
                item.ICProductNo = objProductsInfo.ICProductNo;
                item.FK_ICStockID = o.FK_ICStockID;
                item.ARSaleReturnItemProductSerialNo = string.IsNullOrWhiteSpace(o.IPProductSerieNo) ? mainObject.ARSaleReturnSerialNo : o.IPProductSerieNo;                
                item.FK_ICMeasureUnitID = o.FK_ICMeasureUnitID;
                ICProductMeasureUnitsInfo measureUnit = controller.GetProductMeasureUnitByProductIDAndMeasureUnitID(item.FK_ICProductID, item.FK_ICMeasureUnitID);
                item.ARSaleReturnItemProductFactor = (measureUnit != null && measureUnit.ICProductMeasureUnitFactor > 0)
                                                    ? measureUnit.ICProductMeasureUnitFactor
                                                    : 1;
                item.ARSaleReturnItemProductQty = Math.Round(o.IPProductQuantity, 4);
                item.ARSaleReturnItemProductUnitPrice = o.IPProductUnitPrice;
                if (item.ARSaleReturnItemProductUnitPrice == 0)
                {
                    item.ARSaleReturnItemProductUnitPrice = BOSApp.CalculaterProductUnitPrice(objProductsInfo,
                                                                                                item.ARSaleReturnItemProductUnitPrice,
                                                                                                item.ARSaleReturnItemProductQty,
                                                                                                item.FK_ICMeasureUnitID,
                                                                                                objCustomersInfo != null ? objCustomersInfo.ARCustomerID : 0,
                                                                                                mainObject.ARSaleReturnGetPriceDate,
                                                                                                mainObject.FK_GECurrencyID);
                }

                if (o.IPProductUnitCost > 0)
                    item.ARSaleReturnItemProductUnitCost = o.IPProductUnitCost;
                else { //Lấy giá vốn gần nhất theo đối tượng

                
                }
                item.ARSaleReturnItemExchangeUnitCost = o.IPProductUnitCost;
                item.ARSaleReturnItemProductDiscount = o.IPProductDiscount;
                listInvoiceItems = ListInvoiceItemsInfo.Where(iv => iv.FK_ICProductID == item.FK_ICProductID
                                                            && iv.ARInvoiceItemProductExchangeQty >= item.ARSaleReturnItemProductExchangeQty).ToList();
                if(listInvoiceItems != null && listInvoiceItems.Count > 1)
                {
                    listInvoiceItems = listInvoiceItems.OrderByDescending(iv => iv.ARInvoiceDate).ToList();
                    item.FK_ARInvoiceID = listInvoiceItems[0].FK_ARInvoiceID;
                    item.FK_ARInvoiceItemID = listInvoiceItems[0].ARInvoiceItemID;
                    mainObject.FK_ARInvoiceID = listInvoiceItems[0].FK_ARInvoiceID;                    
                    ChangeItemInvoice(item);
                }
                if (objProductsInfo.HasComponent)
                {
                    BOSList<ARSaleReturnItemComponentsInfo> listComponents = new BOSList<ARSaleReturnItemComponentsInfo>();
                    listComponents.InitBOSList(
                                        entity,
                                        TableName.ARSaleReturnItemsTableName,
                                        TableName.ARSaleReturnItemComponentsTableName,
                                        BOSList<ARSaleReturnItemComponentsInfo>.cstRelationForeign);
                    listComponents.ItemTableForeignKey = "FK_ARSaleReturnItemID";
                    ICProductComponentsController objProductComponentsController = new ICProductComponentsController();
                    List<ICProductComponentsInfo> components = objProductComponentsController.GetProductComponentListByProductID(item.FK_ICProductID);
                    foreach (ICProductComponentsInfo objProductComponentsInfo in components)
                    {
                        ARSaleReturnItemComponentsInfo objSaleReturnItemComponentsInfo = new ARSaleReturnItemComponentsInfo();
                        objSaleReturnItemComponentsInfo.FK_ICProductID = objProductComponentsInfo.FK_ICProductComponentChildID;
                        objSaleReturnItemComponentsInfo.ARSaleReturnItemComponentQty = objProductComponentsInfo.ICProductComponentQty * item.ARSaleReturnItemProductQty;
                        objSaleReturnItemComponentsInfo.ICProductComponentQty = objProductComponentsInfo.ICProductComponentQty;
                        objSaleReturnItemComponentsInfo.ICProductDesc = objProductComponentsInfo.ICProductDesc;
                        objSaleReturnItemComponentsInfo.ICProductSupplierNo = objProductComponentsInfo.ICProductSupplierNo;
                        objSaleReturnItemComponentsInfo.FK_ICStockID = item.FK_ICStockID;
                        objSaleReturnItemComponentsInfo.FK_ICProductSerieID = item.FK_ICProductSerieID;
                        listComponents.Add(objSaleReturnItemComponentsInfo);
                    }
                    item.SaleReturnItemComponentList = listComponents;
                }

                entity.SetProductPriceByProductUnitPrice(item);
                entity.SaleReturnItemsList.Add(item);
            });
            if(mainObject.FK_ARInvoiceID > 0)
            {
                ARInvoicesController objInvoicesController = new ARInvoicesController();
                ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)objInvoicesController.GetObjectByID(mainObject.FK_ARInvoiceID);
                if (objInvoicesInfo != null)
                {
                    mainObject.ARInvoiceNo = objInvoicesInfo.ARInvoiceNo;
                    mainObject.ARInvoiceDate = objInvoicesInfo.ARInvoiceDate;
                    mainObject.ARInvoiceVATInvoiceNo = objInvoicesInfo.ARInvoiceVATInvoiceNo;
                    mainObject.ARSaleReturnInvoiceVATNo = objInvoicesInfo.ARInvoiceVATInvoiceNo;
                    mainObject.ARInvoiceVATSymbol = objInvoicesInfo.ARInvoiceVATSymbol;
                    mainObject.ARInvoiceTaxNumber = objInvoicesInfo.ARInvoiceTaxNumber;
                    entity.UpdateMainObjectBindingSource();
                }
            }    
            UpdateTotalAmount();
            entity.SaleReturnItemsList.GridControl?.RefreshDataSource();

            BOSProgressBar.Close();
            return isSaveSucess;
        }
        #endregion

        #region Export template
        public void ExportPriceSheetTemplate()
        {
            try
            {
                BOSProgressBar.Start("Đang Export dữ liệu");
                ExportWorker_DoWork();                
                BOSProgressBar.Close();
                if (File.Exists(FilePath))
                {
                    Process.Start(FilePath);
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

        private void ExportWorker_DoWork()
        {
            SaleReturnEntities entity = (SaleReturnEntities)CurrentModuleEntity;
            ARSaleReturnsInfo mainObject = (ARSaleReturnsInfo)entity.MainObject;
            List<ARSaleReturnItemsInfo> listExport = entity.SaleReturnItemsList.ToList();

            List<ICMeasureUnitsInfo> listMeasureUnitsInfo = new List<ICMeasureUnitsInfo>();
            if (BOSApp.LookupTables.Contains("ICMeasureUnits"))
            {
                listMeasureUnitsInfo = (List<ICMeasureUnitsInfo>)(new ICMeasureUnitsController()).GetListFromDataSet((DataSet)BOSApp.LookupTables["ICMeasureUnits"]);
            }
            else
            {
                listMeasureUnitsInfo = (new ICMeasureUnitsController()).GetAllAliveMeasureUnit();
            }

            List<ICStocksInfo> listStocksInfo = new List<ICStocksInfo>();
            if (BOSApp.LookupTables.Contains("ICStocks"))
            {
                listStocksInfo = (List<ICStocksInfo>)(new ICStocksController()).GetListFromDataSet((DataSet)BOSApp.LookupTables["ICStocks"]);
            }
            else
            {
                listStocksInfo = (new ICStocksController()).GetListRealStock();
            }
            ICMeasureUnitsInfo objMeasureUnitsInfo = new ICMeasureUnitsInfo();
            ICStocksInfo objStocksInfo = new ICStocksInfo();
            ICProductsForViewInfo objProductsInfo = new ICProductsForViewInfo();

            string documentPath = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "BYSERP");
            if (!Directory.Exists(documentPath))
            {
                DirectoryInfo di = Directory.CreateDirectory(documentPath);
            }
            FilePath = Path.Combine(documentPath,
                                    String.Format("HangBanTraLai_{0}_Ngay_{1}_{2}.xlsx",
                                    mainObject.ARSaleReturnNo,
                                    mainObject.ARSaleReturnDate.ToString("yyyy_MM_dd"),
                                    DateTimeOffset.Now.ToUnixTimeSeconds()));
            object misValue = System.Reflection.Missing.Value;
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook workbook = xlApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.ActiveSheet;
            xlApp.StandardFont = "Times New Roman";
            xlApp.StandardFontSize = 13;
            var header = worksheet.get_Range("A1", "J1");
            header.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.FromArgb(9, 132, 227));
            header.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);
            header.Font.Bold = true;
            header.Range["A1"].Value = "STT";
            header.Range["B1"].Value = "Mã sản phẩm (*)";
            header.Range["C1"].Value = "Mã sp đối tác";
            header.Range["D1"].Value = "Mã hệ thống cũ";
            header.Range["E1"].Value = "Tên sản phẩm";
            header.Range["F1"].Value = "Mô tả";
            header.Range["G1"].Value = "Đơn vị tính";
            header.Range["H1"].Value = "Số lượng";
            header.Range["I1"].Value = "Mã kho";
            header.Range["J1"].Value = "Mã lô hàng/Mã kiện";
            worksheet.Range["A:A"].EntireColumn.NumberFormat = "0";
            worksheet.Range["B:B"].EntireColumn.NumberFormat = "@";
            worksheet.Range["C:C"].EntireColumn.NumberFormat = "@";
            worksheet.Range["D:D"].EntireColumn.NumberFormat = "@";
            worksheet.Range["E:E"].EntireColumn.NumberFormat = "@";
            worksheet.Range["F:F"].EntireColumn.NumberFormat = "@";
            worksheet.Range["G:G"].EntireColumn.NumberFormat = "@";
            worksheet.Range["H:H"].EntireColumn.NumberFormat = "#,##0.00";
            worksheet.Range["I:I"].EntireColumn.NumberFormat = "@";
            worksheet.Range["J:J"].EntireColumn.NumberFormat = "@";

            int index = 2;
            int totalItem = listExport.Count() + 10;
            listExport.ForEach(o =>
            {
                worksheet.Range[$"A{index}"].Value = index - 1;
                objProductsInfo = BOSApp.CurrentProductList.FirstOrDefault(a => a.ICProductID == o.FK_ICProductID);
                if (objProductsInfo != null)
                {
                    worksheet.Range[$"B{index}"].Value = objProductsInfo.ICProductNo.Trim();
                }
                else
                {
                    worksheet.Range[$"B{index}"].Value = string.Empty;
                }
                worksheet.Range[$"C{index}"].Value = o.ARSaleReturnItemProductCustomerNumber.Trim();
                worksheet.Range[$"D{index}"].Value = o.ARSaleReturnItemProductNoOfOldSys.Trim();
                worksheet.Range[$"E{index}"].Value = o.ARSaleReturnItemProductName.Trim();
                worksheet.Range[$"F{index}"].Value = o.ARSaleReturnItemProductDesc.Trim();
                objMeasureUnitsInfo = listMeasureUnitsInfo.FirstOrDefault(a => a.ICMeasureUnitID == o.FK_ICMeasureUnitID);
                if (objMeasureUnitsInfo != null)
                {
                    worksheet.Range[$"G{index}"].Value = objMeasureUnitsInfo.ICMeasureUnitName.Trim();
                }
                else
                {
                    worksheet.Range[$"G{index}"].Value = string.Empty;
                }

                worksheet.Range[$"H{index}"].Value = o.ARSaleReturnItemProductQty;
                objStocksInfo = listStocksInfo.FirstOrDefault(a => a.ICStockID == o.FK_ICStockID);
                if (objStocksInfo != null)
                {
                    worksheet.Range[$"I{index}"].Value = objStocksInfo.ICStockName.Trim();
                }
                else
                {
                    worksheet.Range[$"I{index}"].Value = string.Empty;
                }
                worksheet.Range[$"J{index}"].Value = o.ARSaleReturnItemProductSerialNo.Trim();
                index++;
            });
            var usedRange = worksheet.get_Range($"A1", $"J{index - 1}");
            usedRange.Borders.get_Item(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous;
            usedRange.Borders.get_Item(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous;
            usedRange.Borders.get_Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous;
            usedRange.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous;
            usedRange.Borders.Color = Color.Black;
            worksheet.get_Range("A1", "J1").EntireColumn.AutoFit();
            workbook.SaveAs(FilePath);
            workbook.Close(true, misValue, misValue);
            xlApp.Quit();
            ReleaseObject(worksheet);
            ReleaseObject(workbook);
            ReleaseObject(xlApp);
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
        #endregion
        #region Upload data to HDĐT BKAV
        public void UpLoadDataToHDDT()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                if (MessageBox.Show(InvoiceLocalizedResources.ConfirmUpLoadDataToHDDT,
                    CommonLocalizedResources.MessageBoxDefaultCaption,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
                    return;
                SaleReturnEntities entity = (SaleReturnEntities)CurrentModuleEntity;
                ARSaleReturnsInfo mainObject = (ARSaleReturnsInfo)entity.MainObject;
                if (mainObject.ARSaleReturnPostedStatus != PostedTransactionStatus.Posted.ToString())
                {
                    MessageBox.Show(InvoiceLocalizedResources.ErrorUpLoadDataToHDDT,
                                        CommonLocalizedResources.MessageBoxDefaultCaption,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    return;
                }
                //if (!string.IsNullOrWhiteSpace(mainObject.AROutputVATDocumentType)
                //   || !string.IsNullOrWhiteSpace(mainObject.ARSaleReturnVATFormNo)
                //   || !string.IsNullOrWhiteSpace(mainObject.ARSaleReturnVATSymbol)
                //   || !string.IsNullOrWhiteSpace(mainObject.ARSaleReturnVATInvoiceNo)
                //   )
                //{
                //    MessageBox.Show("Chứng từ không đủ điều kiện để đẩy lên HDĐT",
                //                        CommonLocalizedResources.MessageBoxDefaultCaption,
                //                        MessageBoxButtons.OK,
                //                        MessageBoxIcon.Error);
                //    return;
                //}
                List<ARSaleReturnItemsInfo> mergeItems = entity.SaleReturnItemsList.GroupBy(o => new
                {
                    o.FK_ICProductID,
                    o.ARSaleReturnItemProductName,
                    o.FK_ICMeasureUnitID,
                    o.ARSaleReturnItemProductUnitPrice,
                    o.FK_ARInvoiceID,
                    o.ARSaleReturnNo
                }).Select(o => new ARSaleReturnItemsInfo()
                {
                    FK_ICProductID = o.Key.FK_ICProductID,
                    ARSaleReturnItemProductName = o.Key.ARSaleReturnItemProductName,
                    FK_ICMeasureUnitID = o.Key.FK_ICMeasureUnitID,
                    ARSaleReturnItemProductUnitPrice = o.Key.ARSaleReturnItemProductUnitPrice,
                    ARSaleReturnItemProductQty = o.Sum(item => item.ARSaleReturnItemProductQty),
                    FK_ARInvoiceID = o.Key.FK_ARInvoiceID,
                    ARInvoiceNo = o.Key.ARSaleReturnNo,
                    ARSaleReturnItemID = o.Select(item => item.ARSaleReturnItemID).FirstOrDefault()
                }).ToList();
                EInvoiceHelper.ToEInvoice(mainObject, mergeItems);
            }
        }
        #endregion
    }
}

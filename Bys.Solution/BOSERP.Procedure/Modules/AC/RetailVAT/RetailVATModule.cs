using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSERP.Utilities;
using BOSLib;
using BOSReport;
using CrystalDecisions.CrystalReports.Engine;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using DevExpress.XtraTab;
using Localization;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.RetailVAT
{
    #region RetailVATModule
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:RetailVATModule
    //Created Date:Monday, Septemper 13, 2010
    //-----------------------------------------------------------

    public class RetailVATModule : BaseTransactionModule
    {
        #region Constants
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        public const string ProductPicturePictureBoxName = "fld_pteACRetailVATItemProductPicture";
        #endregion

        private BOSPictureEdit ProductPicturePictureBox;
        private BOSLookupEdit SearchBranchLookupEditControl;
        private List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        private List<BRBranchsInfo> BranchList;
                
        public RetailVATModule()
        {
            Name = ModuleName.RetailVAT;
            CurrentModuleEntity = new RetailVATEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            GetCurrentModuleDataViewPermission();
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[RetailVATModule.SearchBranchLookupEditControlName];
            if(SearchBranchLookupEditControl != null)
            {
                SearchBranchLookupEditControl.Properties.DataSource = BranchList;
            }
            ProductPicturePictureBox = (BOSPictureEdit)Controls[ProductPicturePictureBoxName];
        }

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            ACRetailVATsController objRetailVATsController = new ACRetailVATsController();
            ACRetailVATsInfo searchObject = (ACRetailVATsInfo)CurrentModuleEntity.SearchObject;

            DataSet ds = new DataSet();
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = new ACObjectsInfo();
            if (!string.IsNullOrEmpty(searchObject.ACObjectAccessKey))
            {
                objObjectsInfo = (ACObjectsInfo)objObjectsController.GetObjectByAccessKey(searchObject.ACObjectAccessKey);
                objObjectsInfo = objObjectsController.GetObjectByIDAndType(objObjectsInfo.ACObjectID, objObjectsInfo.ACObjectType);
            }
            if (searchObject.FK_BRBranchID == 0)
            {
                if (BranchList.Count == 0)
                {
                    ds = objRetailVATsController.GetDataSetByID(-1);
                }
                else
                {
                    ds = objRetailVATsController.GetRetailVATListDatasetByListOfBranchID(searchObject.ACRetailVATNo,
                                                                                         objObjectsInfo.ACObjectID, 
                                                                                         objObjectsInfo.ACObjectType, 
                                                                                         searchObject.FK_HREmployeeID, 
                                                                                         searchObject.ACRetailVATDateFrom, 
                                                                                         searchObject.ACRetailVATDateTo, 
                                                                                         BranchList);
                }
            }
            else
            {
                ds = objRetailVATsController.GetRetailVATListDataset(searchObject.ACRetailVATNo,
                                                                     objObjectsInfo.ACObjectID,
                                                                     objObjectsInfo.ACObjectType,
                                                                     searchObject.FK_HREmployeeID,
                                                                     searchObject.ACRetailVATDateFrom,
                                                                     searchObject.ACRetailVATDateTo,
                                                                     searchObject.FK_BRBranchID);
            }
            return ds;
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
        
        #region Local
        public void ChangeItemFromInvoiceItemsList()
        {
            RetailVATEntities entity = (RetailVATEntities)CurrentModuleEntity;
            entity.SetProductPriceByProductUnitPrice();
            entity.RetailVATItemsList.ChangeObjectFromList();
            UpdateTotalAmount();
        }

        public void DeleteItemFromInvoiceItemsList()
        {
            RetailVATEntities entity = (RetailVATEntities)CurrentModuleEntity;
            entity.RetailVATItemsList.RemoveSelectedRowObjectFromList();
            UpdateTotalAmount();
        }

        public void UpdateTotalAmount()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                RetailVATEntities entity = (RetailVATEntities)CurrentModuleEntity;
                entity.UpdateTotalAmount();
            }
        }
        #endregion

        public override void ActionNew()
        {
            base.ActionNew();
            RetailVATEntities entity = (RetailVATEntities)CurrentModuleEntity;
            ACRetailVATsInfo mainObject = (ACRetailVATsInfo)entity.MainObject;

            ARInvoiceItemsController objInvoiceItemsController = new ARInvoiceItemsController();
            List<ARInvoiceItemsInfo> posItems = objInvoiceItemsController.GetPOSItemsForRetailVAT();
            guiChoosePOSItems guiPOSItem = new guiChoosePOSItems(posItems);
            guiPOSItem.Module = this;
            if (guiPOSItem.ShowDialog() != DialogResult.OK)
            {
                ActionCancel();
                return;
            }
            List<ARInvoiceItemsInfo> results = (List<ARInvoiceItemsInfo>)guiPOSItem.SelectedObjects;
            if (results.Count == 0)
                return;

            ARInvoiceItemsInfo posItemsInfo = results.FirstOrDefault();
            ARInvoicesController objInvoicesController = new ARInvoicesController();
            ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)objInvoicesController.GetObjectByID(posItemsInfo.FK_ARInvoiceID);
            if (objInvoicesInfo == null)
            {
                objInvoicesInfo = new ARInvoicesInfo();
            }

            mainObject.FK_ACObjectID = objInvoicesInfo.FK_ACObjectID;
            mainObject.ARObjectType = objInvoicesInfo.ARObjectType;
            mainObject.ACObjectAccessKey = string.Format("{0};{1}", mainObject.FK_ACObjectID, mainObject.ARObjectType);
            mainObject.FK_ARSellerID = objInvoicesInfo.FK_ARSellerID;
            mainObject.FK_GECurrencyID = objInvoicesInfo.FK_GECurrencyID;
            mainObject.ACRetailVATExchangeRate = objInvoicesInfo.ARInvoiceExchangeRate;
            mainObject.ACRetailVATInvoiceRequest = objInvoicesInfo.ARInvoiceInvoiceRequest;            
            mainObject.FK_ACTaxUnitID = objInvoicesInfo.FK_ACTaxUnitID;
            mainObject.FK_ACEInvoiceTypeID = objInvoicesInfo.FK_ACEInvoiceTypeID;
            mainObject.ACRetailVATTaxNumber = objInvoicesInfo.ARInvoiceTaxNumber;
            mainObject.ARPaymentMethodCombo = objInvoicesInfo.ARPaymentMethodCombo;
            mainObject.AROutputVATDocumentType = objInvoicesInfo.AROutputVATDocumentType;
            mainObject.ACRetailVATVATFormNo = objInvoicesInfo.ARInvoiceVATFormNo;
            mainObject.ACRetailVATVATSymbol = objInvoicesInfo.ARInvoiceVATSymbol;
            mainObject.ACRetailVATVATInvoiceNo = objInvoicesInfo.ARInvoiceVATInvoiceNo;
            mainObject.ACRetailVATVATPaymentContactInformation = objInvoicesInfo.ARInvoiceVATPaymentContactInformation;
            mainObject.AROutputVATInvoiceNoCombo = objInvoicesInfo.AROutputVATInvoiceNoCombo;
            mainObject.ACRetailVATReference = string.Join(",", results.Select(o => o.FK_ARInvoiceID).Distinct().ToArray());
            mainObject.ACRetailVATSOContactName = objInvoicesInfo.ARInvoiceSOContactName;
            if(posItemsInfo.ARInvoiceItemProductTaxPercent == 0)
            {
                mainObject.AROutputVATDocumentType = OutputVATDocumentType.InvoiceType2.ToString();
            }
            else if (posItemsInfo.ARInvoiceItemProductTaxPercent == 5)
            {
                mainObject.AROutputVATDocumentType = OutputVATDocumentType.InvoiceType3.ToString();
            }
            else if (posItemsInfo.ARInvoiceItemProductTaxPercent == 8)
            {
                mainObject.AROutputVATDocumentType = OutputVATDocumentType.InvoiceType4.ToString();
            }
            else if (posItemsInfo.ARInvoiceItemProductTaxPercent == 10)
            {
                mainObject.AROutputVATDocumentType = OutputVATDocumentType.InvoiceType6.ToString();
            }
            ChangeObject(mainObject.ACObjectAccessKey);
            
            entity.GenarateRetailVATItem(results);                  
            entity.RetailVATItemsList.GridControl.RefreshDataSource();
            UpdateTotalAmount();
            entity.UpdateMainObjectBindingSource();
        }

        public override int ActionSave()
        {
            //SetDefaultDesc();
            RetailVATEntities entity = (RetailVATEntities)CurrentModuleEntity;
            ACRetailVATsInfo mainObject = (ACRetailVATsInfo)entity.MainObject;
            entity.RetailVATItemsList.EndCurrentEdit();            
            //ACObjectsController objObjectsController = new ACObjectsController();
            //ACObjectsInfo objObjectsInfo = (ACObjectsInfo)objObjectsController.GetObjectByIDAndType(objInvoicesInfo.FK_ACObjectID, objInvoicesInfo.ARObjectType);
            //if (objObjectsInfo != null)
            //{
            //    if (objObjectsInfo.ACObjectCreditLimit > 0 && objInvoicesInfo.ARInvoiceBalanceDue > (objObjectsInfo.ACObjectCreditLimit - objObjectsInfo.ACObjectCreditOwing))
            //    {
            //        if (MessageBox.Show(InvoiceLocalizedResources.AvailableCreditIsNotEnoughMessage,
            //                            CommonLocalizedResources.MessageBoxDefaultCaption,
            //                            MessageBoxButtons.YesNo,
            //                            MessageBoxIcon.Question) == DialogResult.No)
            //        {
            //            isContinue = false;
            //            ActionCancel();
            //        }
            //    }
            //}
            entity.UpdateTotalAmount();
            int iObjectID = base.ActionSave();
            if (iObjectID > 0)
            {
                ACRetailVATsController objRetailVATsController = new ACRetailVATsController();
                objRetailVATsController.UpdateVATInvoiceNoRetailVAT(iObjectID);
            }
            return iObjectID;
        }

        //private void SetDefaultDesc()
        //{
        //    ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)CurrentModuleEntity.MainObject;
        //    ACObjectsController objObjectsController = new ACObjectsController();
        //    ACObjectsInfo objObjectInfo = (ACObjectsInfo)objObjectsController.GetObjectByIDAndType(objInvoicesInfo.FK_ACObjectID, objInvoicesInfo.ARObjectType);
        //    if (objObjectInfo != null)
        //    {
        //        objInvoicesInfo.ARInvoiceDesc = objInvoicesInfo.ARInvoiceDesc.Replace("{0}", string.IsNullOrEmpty(objObjectInfo.ACObjectContactName) ? objObjectInfo.ACObjectContactName : objObjectInfo.ACObjectName);
        //    }
        //}

        public override bool ActionComplete()
        {
            return base.ActionComplete();
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);

            CurrentModuleEntity.SetPropertyChangeEventLock(false);
            ACRetailVATsInfo mainObject = (ACRetailVATsInfo)CurrentModuleEntity.MainObject;
            mainObject.ACObjectAccessKey = string.Format("{0};{1}", mainObject.FK_ACObjectID, mainObject.ARObjectType);
            CurrentModuleEntity.UpdateMainObjectBindingSource();
            CurrentModuleEntity.SetPropertyChangeEventLock(true);
        }

        public override void InvalidateToolbar()
        {
            base.InvalidateToolbar();
            ACRetailVATsInfo mainObject = (ACRetailVATsInfo)CurrentModuleEntity.MainObject;

            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancelComplete, false);
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
            ParentScreen.SetEnableOfToolbarButton("UpLoadDataToHDDT", false);
            if (mainObject.ACRetailVATID > 0)
            {
                if (mainObject.ACRetailVATStatus == RetailVATStatus.New.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, true);
                }
                else if (mainObject.ACRetailVATStatus == RetailVATStatus.Completed.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancelComplete, true);
                    ParentScreen.SetEnableOfToolbarButton("UpLoadDataToHDDT", true);
                }
                if (Toolbar.IsEditAction())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDelete, true);
                }
            }
        }

        public void ChangeDiscountPercent()
        {
            UpdateTotalAmount();
        }

        public void ChangeDiscountAmount()
        {
            RetailVATEntities entity = (RetailVATEntities)CurrentModuleEntity;
            ACRetailVATsInfo mainObject = (ACRetailVATsInfo)entity.MainObject;
            if (mainObject.ACRetailVATSubTotalAmount > 0)
            {
                mainObject.ACRetailVATDiscountPerCent = mainObject.ACRetailVATDiscountAmount / mainObject.ACRetailVATSubTotalAmount * 100;
            }   
            UpdateTotalAmount();
        }

        public void ChangeTaxPercent()
        {
            UpdateTotalAmount();
        }

        public void ChangeTaxAmount()
        {
            RetailVATEntities entity = (RetailVATEntities)CurrentModuleEntity;
            ACRetailVATsInfo mainObject = (ACRetailVATsInfo)entity.MainObject;
            if (mainObject.ACRetailVATSubTotalAmount - mainObject.ACRetailVATDiscountAmount > 0)
            {
                mainObject.ACRetailVATTaxPercent = mainObject.ACRetailVATTaxAmount / (mainObject.ACRetailVATSubTotalAmount - mainObject.ACRetailVATDiscountAmount) * 100;
            }
            UpdateTotalAmount();
        }

        public void ChangeObject(string objectAccessKey)
        {
            RetailVATEntities entity = (RetailVATEntities)CurrentModuleEntity;
            ACRetailVATsInfo mainObject = (ACRetailVATsInfo)CurrentModuleEntity.MainObject;
            mainObject.ACObjectAccessKey = objectAccessKey;
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(objectAccessKey);
            objObjectsInfo = objObjectsController.GetObjectByIDAndType(objObjectsInfo.ACObjectID, objObjectsInfo.ACObjectType);
            if (objObjectsInfo != null)
            {
                mainObject.FK_ACObjectID = objObjectsInfo.ACObjectID;
                mainObject.ARObjectType = objObjectsInfo.ACObjectType;
                mainObject.FK_GECurrencyID = objObjectsInfo.GECurrencyID;
                mainObject.ARPaymentMethodCombo = string.IsNullOrEmpty(objObjectsInfo.ACObjectPaymentMethodCombo) ? "" : objObjectsInfo.ACObjectPaymentMethodCombo;
                mainObject.ACRetailVATSOContactName = string.IsNullOrEmpty(objObjectsInfo.ACObjectContactName) ? objObjectsInfo.ACObjectName : objObjectsInfo.ACObjectContactName;
                mainObject.ACRetailVATVATPaymentContactInformation = objObjectsInfo.ACObjectName;
                mainObject.ACRetailVATTaxNumber = objObjectsInfo.ACObjectTaxNumber;
            }  
            entity.UpdateMainObjectBindingSource();
        }

        public void UpLoadDataToHDDT()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                if (MessageBox.Show(InvoiceLocalizedResources.ConfirmUpLoadDataToHDDT,
                    CommonLocalizedResources.MessageBoxDefaultCaption,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
                    return;

                RetailVATEntities entity = (RetailVATEntities)CurrentModuleEntity;
                ACRetailVATsInfo mainObject = (ACRetailVATsInfo)CurrentModuleEntity.MainObject;
                if (mainObject.ACRetailVATStatus == RetailVATStatus.New.ToString())
                {
                    MessageBox.Show("Vui lòng Hoàn tất chứng từ!",
                                    CommonLocalizedResources.MessageBoxDefaultCaption,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }
                EInvoiceHelper.ToEInvoice(mainObject, entity.RetailVATItemsList);
            }
        }

        public void ChangeACEInvoiceTypeNo(int invoiceID)
        {
            RetailVATEntities entity = (RetailVATEntities)CurrentModuleEntity;
            ACRetailVATsInfo mainObject = (ACRetailVATsInfo)CurrentModuleEntity.MainObject;
            ACEInvoiceTypesController objEInvoiceTypesController = new ACEInvoiceTypesController();
            ACEInvoiceTypesInfo objEInvoiceTypesInfo = (ACEInvoiceTypesInfo)objEInvoiceTypesController.GetObjectByID(invoiceID);
            if (objEInvoiceTypesInfo != null)
            {
                mainObject.ACRetailVATVATFormNo = objEInvoiceTypesInfo.ACEInvoiceTypeTemplateCode;
                mainObject.ACRetailVATVATSymbol = objEInvoiceTypesInfo.ACEInvoiceTypeSeries;
            }
            else
            {
                mainObject.ACRetailVATVATFormNo = string.Empty;
                mainObject.ACRetailVATVATSymbol = string.Empty;
            }
            entity.UpdateMainObjectBindingSource();
        }

        public override bool ActionCancelComplete()
        {
            RetailVATEntities entity = (RetailVATEntities)CurrentModuleEntity;
            ACRetailVATsInfo mainObject = (ACRetailVATsInfo)CurrentModuleEntity.MainObject;

            //ACDocumentsController objDocumentsController = new ACDocumentsController();
            //List<ACDocumentsInfo> documentsList = objDocumentsController.GetRelativeDocumentListByInvoiceID(objInvoicesInfo.ARInvoiceID);

            //if (documentsList.Count() > 0)
            //{
            //    MessageBox.Show(string.Format("Không thể mở chứng từ này do đã tạo các chứng từ sau: -{0}", string.Join("\n-", documentsList.Select(o => o.ACDocumentNo).ToArray())), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return false;
            //}

            bool isComplete = base.ActionCancelComplete();
            if (isComplete)
            {
                InvalidateToolbar();
            }
            return isComplete;
        }

        public void InitProductPictureImage(int productID)
        {
            if (productID > 0 && ProductPicturePictureBox != null)
            {
                ProductPicturePictureBox.Image = BOSApp.GetProductPictureImageByProductID(productID);
                ProductPicturePictureBox.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            }
        }
    }
    #endregion
}
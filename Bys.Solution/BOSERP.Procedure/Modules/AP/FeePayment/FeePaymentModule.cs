using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSERP.Modules.AP.FeePayment.Localization;
using BOSLib;
using DevExpress.XtraTab;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.FeePayment
{
    public class FeePaymentModule : BaseTransactionModule
    {
        #region Constants
        public const string FeeCommentColumnName = "APFeePaymentFeeConfigComment";
        public const string FeePaymentReceiptGridControlName = "fld_dgcReceipt1s";
        public const string FeePaymentInvoiceInternalReceiptGridControlName = "fld_dgcAPFeePaymentInvoiceInternalReceipts";
        public const string FeePaymentTransferGridControlName = "fld_dgcAPFeePaymentTransfers";
        public const string DocumentEntryGridControlName = "fld_dgcDocumentEntry1s";
        public const string TotalAmountTextBox = "bosTextBox1";
        public const string ExchangeRateTextBox = "fld_txtACDocumentExchangeRate";
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END

        //TNDLoc [ADD][30/07/2018][Fee Payment InvoiceIn],START
        public const string CreateTypeControlName = "fld_cbbDocumentCreateType";
        public const string DetailTabControlName = "fld_tcDetail";
        public const string InvoiceInTabPage = "fld_tpInvoiceIn";
        public const string InvoiceTabPage = "fld_tpInvoice";
        public const string ReceiptTabPage = "fld_tpReceipt";
        public const string DocumentEntryTabPage = "fld_tpDocumentEntry";
        public const string FeeConfigTabPage = "fld_tpFeeConfig";
        public const string TransferTabPage = "fld_tpTransfer";
        public const string InvoiceInternalReceiptTabPage = "fld_tpInvoiceInternalReceipt";
        public const string FeePaymentInvoiceInGridControlName = "fld_dgcAPFeePaymentInvoiceIns";
        public const string FeePaymentItemGridControlName = "fld_dgcAPFeePaymentItems";
        public const string FeePaymentInvoiceGridControlName = "fld_dgcAPFeePaymentInvoices";
        public const string InvoiceInItemTabPage = "fld_tpInvoiceInItem";
        //TNDLoc [ADD][30/07/2018][Fee Payment InvoiceIn],END
        public const string ACVATDocumentTypeFeePaymentControlName = "fld_lkeACVATDocumentTypeFeePayment";
        public const string DocumentStatusControlName = "fld_cbbDocumentStatus";
        public const string ChooseReceiptControlName = "fld_btnChooseReceipt";
        #endregion

        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public BOSLookupEdit SearchBranchLookupEditControl = null;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public List<BRBranchsInfo> BranchList;
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
        public const string FeePaymentPurchaseOrderGridControlName = "fld_dgcPurchaseOrders";
        //TNDLoc [ADD][30/07/2018][Fee Payment InvoiceIn],START
        public BOSComboBox CreateTypeControl;
        public BOSTabControl DetailTabControl;
        public BOSComboBox DocumentStatusControl;
        public BOSButton ChooseReceiptControl;
        public string FocusTabName = string.Empty;
        public bool IsNewImport = false;
        public bool IsNewSaleInvoice = false;
        //TNDLoc [ADD][30/07/2018][Fee Payment InvoiceIn],END
        public BOSLookupEdit ACVATDocumentTypeFeePaymentLookupEditControl;
        public List<ADConfigValuesInfo> configValueList;
        public FeePaymentModule()
        {
            Name = ModuleName.FeePayment;
            CurrentModuleEntity = new FeePaymentEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
            GetCurrentModuleDataViewPermission();
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[SearchBranchLookupEditControlName];
            SearchBranchLookupEditControl.Properties.DataSource = BranchList;
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END

            //TNDLoc [ADD][30/07/2018][Fee Payment InvoiceIn],START
            CreateTypeControl = (BOSComboBox)Controls[CreateTypeControlName];
            DetailTabControl = (BOSTabControl)Controls[DetailTabControlName];
            //TNDLoc [ADD][30/07/2018][Fee Payment InvoiceIn],END
            ACVATDocumentTypeFeePaymentLookupEditControl = (BOSLookupEdit)Controls[FeePaymentModule.ACVATDocumentTypeFeePaymentControlName];
            DocumentStatusControl = (BOSComboBox)Controls[DocumentStatusControlName];
            ChooseReceiptControl = (BOSButton)Controls[ChooseReceiptControlName];
            GetVATDocumentType();
            ACVATDocumentTypeFeePaymentLookupEditControl.Properties.DataSource = configValueList;
        }

        //TNDLoc [ADD][30/07/2018][Fee Payment InvoiceIn],START
        public void NewImportFeePayment()
        {
            IsNewImport = true;
            IsNewSaleInvoice = false;
            FeePaymentEntities entity = (FeePaymentEntities)CurrentModuleEntity;
            entity.FeePaymentInvoiceList.Clear();
            base.ActionNew();
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            mainObject.ACDocumentCreateFrom = DocumentCreateFrom.InvoiceIn.ToString();
            entity.UpdateMainObjectBindingSource();
            SetDocumentStatusValue(DocumentStatus.New.ToString());
            SetCreateTypeControlValue(IsNewImport, false, false, false, IsNewSaleInvoice, false);
        }

        public void NewSaleInvoiceFeePayment()
        {
            IsNewImport = false;
            IsNewSaleInvoice = true;
            FeePaymentEntities entity = (FeePaymentEntities)CurrentModuleEntity;
            entity.FeePaymentInvoiceInList.Clear();
            base.ActionNew();
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            mainObject.ACDocumentCreateFrom = DocumentCreateFrom.Invoice.ToString();
            entity.UpdateMainObjectBindingSource();
            SetCreateTypeControlValue(IsNewImport, false, false, false, IsNewSaleInvoice, true);
        }

        public void SetCreateTypeControlValue(bool isImport, bool isPurchaseReceipt, bool isTransfer, bool isInvoiceInternalReceipt, bool isSaleInvoice, bool isInvoiceInItem)
        {
            if (CreateTypeControl != null)
            {
                CreateTypeControl.SelectedIndex = (isImport) ? 0 : ((isSaleInvoice) ? 2 : 1);

                XtraTabPage pageReceipt = DetailTabControl.TabPages.FirstOrDefault(t => t.Name == ReceiptTabPage);
                XtraTabPage pageInvoiceIn = DetailTabControl.TabPages.FirstOrDefault(t => t.Name == InvoiceInTabPage);
                XtraTabPage pageInvoice = DetailTabControl.TabPages.FirstOrDefault(t => t.Name == InvoiceTabPage);
                XtraTabPage pageDocumentEntry = DetailTabControl.TabPages.FirstOrDefault(t => t.Name == DocumentEntryTabPage);
                XtraTabPage pageFeeConfig = DetailTabControl.TabPages.FirstOrDefault(t => t.Name == FeeConfigTabPage);
                XtraTabPage pageTransfer = DetailTabControl.TabPages.FirstOrDefault(t => t.Name == TransferTabPage);
                XtraTabPage pageInvoiceInternalReceipt = DetailTabControl.TabPages.FirstOrDefault(t => t.Name == InvoiceInternalReceiptTabPage);
                XtraTabPage pageInvoiceInItem = DetailTabControl.TabPages.FirstOrDefault(t => t.Name == InvoiceInItemTabPage);
                //pageInvoiceInItem.PageVisible = isInvoiceInItem;
                pageInvoiceInItem.PageVisible = false;
                if (isImport)
                {
                    if (FocusTabName != DocumentEntryTabPage)
                    {
                        pageReceipt.PageVisible = true;
                        pageTransfer.PageVisible = false;
                        pageInvoiceInternalReceipt.PageVisible = false;
                        pageInvoice.PageVisible = false;
                        pageDocumentEntry.PageVisible = true;
                        pageInvoiceIn.PageVisible = true;
                        pageFeeConfig.PageVisible = true;
                        DetailTabControl.SelectedTabPage = pageInvoiceIn;
                    }
                    else
                    {
                        pageReceipt.PageVisible = true;
                        pageTransfer.PageVisible = false;
                        pageInvoiceInternalReceipt.PageVisible = false;
                        pageInvoice.PageVisible = false;
                        pageInvoiceIn.PageVisible = true;
                        pageDocumentEntry.PageVisible = true;
                        pageFeeConfig.PageVisible = true;
                        DetailTabControl.SelectedTabPage = pageDocumentEntry;
                    }

                }
                else if (isSaleInvoice)
                {
                    if (FocusTabName != DocumentEntryTabPage)
                    {
                        pageReceipt.PageVisible = false;
                        pageTransfer.PageVisible = false;
                        pageInvoiceInternalReceipt.PageVisible = false;
                        pageInvoice.PageVisible = true;
                        pageDocumentEntry.PageVisible = true;
                        pageInvoiceIn.PageVisible = false;
                        pageFeeConfig.PageVisible = true;
                        DetailTabControl.SelectedTabPage = pageInvoice;
                    }
                    else
                    {
                        pageReceipt.PageVisible = false;
                        pageTransfer.PageVisible = false;
                        pageInvoiceInternalReceipt.PageVisible = false;
                        pageInvoice.PageVisible = true;
                        pageInvoiceIn.PageVisible = false;
                        pageDocumentEntry.PageVisible = true;
                        pageFeeConfig.PageVisible = true;
                        DetailTabControl.SelectedTabPage = pageDocumentEntry;
                    }

                }
                else
                {
                    if (FocusTabName != DocumentEntryTabPage)
                    {
                        pageInvoiceIn.PageVisible = false;
                        pageDocumentEntry.PageVisible = true;
                        pageReceipt.PageVisible = true;
                        pageInvoiceInternalReceipt.PageVisible = isInvoiceInternalReceipt;
                        pageInvoice.PageVisible = false;
                        pageTransfer.PageVisible = isTransfer;
                        pageFeeConfig.PageVisible = true;
                        DetailTabControl.SelectedTabPage = pageReceipt;
                    }
                    else
                    {
                        pageInvoiceIn.PageVisible = false;
                        pageReceipt.PageVisible = true;
                        pageInvoiceInternalReceipt.PageVisible = isInvoiceInternalReceipt;
                        pageInvoice.PageVisible = false;
                        pageTransfer.PageVisible = isTransfer;
                        pageDocumentEntry.PageVisible = true;
                        pageFeeConfig.PageVisible = true;
                        DetailTabControl.SelectedTabPage = pageDocumentEntry;
                    }
                }
            }
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);

            FeePaymentEntities entity = (FeePaymentEntities)CurrentModuleEntity;
            ACDocumentsInfo objDocumentsInfo = (ACDocumentsInfo)entity.MainObject;
            objDocumentsInfo.ACVATDocumentTypeFeePayment = objDocumentsInfo.ACVATDocumentType;
            bool isImport = (entity.FeePaymentInvoiceInList.Count > 0);
            bool isSaleInvoice = (entity.FeePaymentInvoiceList.Count > 0);
            bool isPurchaseReceipt = (entity.FeePaymentReceiptList.Count > 0);
            bool isInvoiceInternalReceipt = (entity.FeePaymentInvoiceInternalReceiptList.Count > 0);
            bool isTransfer = (entity.FeePaymentTransferList.Count > 0);
            bool isInvoiceInItem = true;
            if (objDocumentsInfo.ACDocumentCreateFrom == DocumentCreateFrom.InvoiceIn.ToString())
                isInvoiceInItem = false;
            SetCreateTypeControlValue(isImport, isPurchaseReceipt, isTransfer, isInvoiceInternalReceipt, isSaleInvoice, isInvoiceInItem);
            SetDocumentStatusValue(objDocumentsInfo.ACDocumentStatus, objDocumentsInfo.ACDocumentFollowPosted);
            entity.UpdateMainObjectBindingSource();
        }

        public void RemoveSelectedInvoiceIn()
        {
            FeePaymentEntities entity = (FeePaymentEntities)CurrentModuleEntity;
            APFeePaymentInvoiceInsInfo objFeePaymentInvoiceInsInfo = (APFeePaymentInvoiceInsInfo)entity.FeePaymentInvoiceInList[entity.FeePaymentInvoiceInList.CurrentIndex];
            if (entity.FeePaymentInvoiceInList.CurrentIndex >= 0)
            {
                string referenceNo = entity.FeePaymentInvoiceInList[entity.FeePaymentInvoiceInList.CurrentIndex].APInvoiceInNo;
                if (!string.IsNullOrEmpty(referenceNo))
                {
                    RemoveFeePaymentItem(referenceNo);
                }
            }
            entity.FeePaymentInvoiceInList.RemoveSelectedRowObjectFromList();

            entity.FeePaymentItemList.GridControl.RefreshDataSource();
        }
        public void RemoveSelectedInvoice()
        {
            FeePaymentEntities entity = (FeePaymentEntities)CurrentModuleEntity;
            if (entity.FeePaymentInvoiceList.CurrentIndex >= 0)
            {
                string referenceNo = entity.FeePaymentInvoiceList[entity.FeePaymentInvoiceList.CurrentIndex].ARInvoiceNo;
                if (!string.IsNullOrEmpty(referenceNo))
                {
                    RemoveFeePaymentFeeConfig(referenceNo);
                    RemoveFeePaymentItem(referenceNo);
                }
            }
            entity.FeePaymentInvoiceList.RemoveSelectedRowObjectFromList();
        }

        public void RemoveSelectedFeeConfig()
        {
            FeePaymentEntities entity = (FeePaymentEntities)CurrentModuleEntity;
            if (entity.FeePaymentFeeConfigList != null && entity.FeePaymentFeeConfigList.CurrentIndex >= 0)
            {
                APFeePaymentFeeConfigsInfo objFeePaymentFeeConfigsInfo = entity.FeePaymentFeeConfigList[entity.FeePaymentFeeConfigList.CurrentIndex];
                if (objFeePaymentFeeConfigsInfo != null)
                {
                    if (!string.IsNullOrEmpty(objFeePaymentFeeConfigsInfo.APFeePaymentFeeConfigNo))
                    {
                        BOSApp.ShowMessage("Không được xóa vì giữ liệu được kế thừa!");
                        return;
                    }
                }
                entity.FeePaymentFeeConfigList.RemoveSelectedRowObjectFromList();
            }

        }

        public void AddInvoiceIn()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                FeePaymentEntities entity = (FeePaymentEntities)CurrentModuleEntity;
                ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
                APInvoiceInsController invoiceInController = new APInvoiceInsController();
                APInvoiceInItemsController objInvoiceInItemsController = new APInvoiceInItemsController();
                List<APInvoiceInsInfo> iiList = invoiceInController.GetInvoiceInForFeePayment(BOSApp.CurrentUsersInfo.ADUserID,
                                                                                                            ModuleName.InvoiceIn,
                                                                                                            ADDataViewPermissionType.Module);

                guiFind<APInvoiceInsInfo> guiChoose = new guiFind<APInvoiceInsInfo>(TableName.APInvoiceInsTableName
                                                                                    , iiList
                                                                                    , this
                                                                                    , true);

                if (guiChoose.ShowDialog() == DialogResult.OK)
                {
                    mainObject.ACDocumentProject = String.Join(", ", guiChoose.SelectedObjects.Select(o => o.APInvoiceInProject).Distinct().ToArray());
                    entity.UpdateMainObjectBindingSource();
                    APFeePaymentInvoiceInsInfo feePaymentInvoiceIn;

                    foreach (APInvoiceInsInfo invoiceIn in guiChoose.SelectedObjects)
                    {
                        feePaymentInvoiceIn = entity.FeePaymentInvoiceInList.FirstOrDefault(t => t.FK_APInvoiceInID == invoiceIn.APInvoiceInID);

                        if (feePaymentInvoiceIn == null)
                        {
                            feePaymentInvoiceIn = new APFeePaymentInvoiceInsInfo();
                            feePaymentInvoiceIn.FK_APInvoiceInID = invoiceIn.APInvoiceInID;
                            feePaymentInvoiceIn.APInvoiceInDate = invoiceIn.APInvoiceInDate;
                            feePaymentInvoiceIn.APInvoiceInNo = invoiceIn.APInvoiceInNo;
                            feePaymentInvoiceIn.APInvoiceInPackNo = invoiceIn.APInvoiceInPackNo;
                            feePaymentInvoiceIn.APInvoiceInSupplierNo = invoiceIn.APInvoiceInSupplierNo;
                            feePaymentInvoiceIn.APInvoiceInTotalCost = invoiceIn.APInvoiceInTotalCost;
                            feePaymentInvoiceIn.APInvoiceInVATDate = invoiceIn.APInvoiceInVATDate;
                            feePaymentInvoiceIn.APInvoiceInVATFormNo = invoiceIn.APInvoiceInVATFormNo;
                            feePaymentInvoiceIn.APInvoiceInVATSymbol = invoiceIn.APInvoiceInVATSymbol;
                            feePaymentInvoiceIn.APSupplierName = invoiceIn.APSupplierName;
                            //feePaymentInvoiceIn.APTerminalType = invoiceIn.APTerminalType;
                            entity.FeePaymentInvoiceInList.Add(feePaymentInvoiceIn);
                        }
                        List<APInvoiceInItemsInfo> invoiceItems = objInvoiceInItemsController.GetListInvoiceInItemByInvoiceInID(invoiceIn.APInvoiceInID);
                        APFeePaymentItemsInfo objFeePaymentItemsInfo;
                        foreach (APInvoiceInItemsInfo item in invoiceItems)
                        {
                            objFeePaymentItemsInfo = new APFeePaymentItemsInfo();
                            objFeePaymentItemsInfo.FK_ACAccountID = item.FK_ACAccountID;
                            objFeePaymentItemsInfo.FK_ICProductID = item.FK_ICProductID;
                            objFeePaymentItemsInfo.APFeePaymentItemName = item.APInvoiceInItemProductDesc;
                            objFeePaymentItemsInfo.APFeePaymentItemQty = item.APInvoiceInItemProductQty;
                            objFeePaymentItemsInfo.APFeePaymentItemUnitCost = item.APInvoiceInItemProductUnitCost;
                            objFeePaymentItemsInfo.APFeePaymentItemTotalCost = item.APInvoiceInItemTotalCost;
                            objFeePaymentItemsInfo.APFeePaymentItemReferenceNo = invoiceIn.APInvoiceInNo;
                            objFeePaymentItemsInfo.APFeePaymentItemReferenceItemID = item.APInvoiceInItemID;

                            entity.FeePaymentItemList.Add(objFeePaymentItemsInfo);
                        }
                    }
                    entity.FeePaymentItemList.GridControl.RefreshDataSource();
                    entity.FeePaymentInvoiceInList.GridControl.RefreshDataSource();
                }

            }
        }
        //TNDLoc [ADD][30/07/2018][Fee Payment InvoiceIn],END

        public void AddInvoice()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                FeePaymentEntities entity = (FeePaymentEntities)CurrentModuleEntity;

                ARInvoicesController invoiceController = new ARInvoicesController();
                List<ARInvoicesInfo> iiList = invoiceController.GetInvoiceInForFeePayment(BOSApp.CurrentUsersInfo.ADUserID,
                                                                                                            ModuleName.InvoiceIn,
                                                                                                            ADDataViewPermissionType.Module);

                guiFind<ARInvoicesInfo> guiChoose = new guiFind<ARInvoicesInfo>(TableName.ARInvoicesTableName
                                                                                    , iiList
                                                                                    , this
                                                                                    , true);

                if (guiChoose.ShowDialog() == DialogResult.OK)
                {

                    APFeePaymentInvoicesInfo feePaymentInvoiceIn;

                    foreach (ARInvoicesInfo invoiceIn in guiChoose.SelectedObjects)
                    {
                        feePaymentInvoiceIn = entity.FeePaymentInvoiceList.FirstOrDefault(t => t.FK_ARInvoiceID == invoiceIn.ARInvoiceID);

                        if (feePaymentInvoiceIn == null)
                        {
                            feePaymentInvoiceIn = new APFeePaymentInvoicesInfo();
                            feePaymentInvoiceIn.FK_ARInvoiceID = invoiceIn.ARInvoiceID;
                            feePaymentInvoiceIn.ARInvoiceDate = invoiceIn.ARInvoiceDate;
                            feePaymentInvoiceIn.ARInvoiceNo = invoiceIn.ARInvoiceNo;
                            feePaymentInvoiceIn.ARInvoiceVATInvoiceNo = invoiceIn.ARInvoiceVATInvoiceNo;
                            feePaymentInvoiceIn.ARInvoiceVATFormNo = invoiceIn.ARInvoiceVATFormNo;
                            feePaymentInvoiceIn.ARInvoiceVATSymbol = invoiceIn.ARInvoiceVATSymbol;
                            feePaymentInvoiceIn.ARInvoiceTotalAmount = invoiceIn.ARInvoiceTotalAmount;
                            feePaymentInvoiceIn.ARObjectName = invoiceIn.ARObjectName;
                            entity.FeePaymentInvoiceList.Add(feePaymentInvoiceIn);
                        }
                    }

                    entity.FeePaymentInvoiceList.GridControl.RefreshDataSource();
                }

            }
        }

        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
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
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END

        //protected override DataSet GetSearchData(ref string searchQuery)
        //{
        //    ACDocumentsController objDocumentsController = new ACDocumentsController();
        //    ACDocumentsInfo searchObject = (ACDocumentsInfo)CurrentModuleEntity.SearchObject;
        //    ACObjectsController objObjectsController = new ACObjectsController();
        //    ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(searchObject.ACObjectAccessKey);
        //    //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        //    //DataSet ds = objDocumentsController.GetFeePaymentSet(searchObject.ACDocumentNo,                                                                
        //    //                                                    objObjectsInfo.ACObjectID,
        //    //                                                    objObjectsInfo.ACObjectType,
        //    //                                                    searchObject.FK_HREmployeeID,
        //    //                                                    searchObject.ICReceiptPackNo,
        //    //                                                    searchObject.DocumentDateFrom,
        //    //                                                    searchObject.DocumentDateTo,
        //    //                                                    searchObject.FK_BRBranchID);
        //    //return ds;

        //    DataSet ds;
        //    if (SearchBranchLookupEditControl.EditValue.ToString() == "" || SearchBranchLookupEditControl.EditValue.ToString() == "0")
        //    {
        //        if (BranchList.Count == 0)
        //        {
        //            ds = objDocumentsController.GetDataSetByID(-1);
        //        }
        //        else
        //        {
        //            ds = objDocumentsController.GetFeePaymentSet(searchObject.ACDocumentNo,
        //                                                        objObjectsInfo.ACObjectID,
        //                                                        objObjectsInfo.ACObjectType,
        //                                                        searchObject.FK_HREmployeeID,
        //                                                        searchObject.ICReceiptPackNo,
        //                                                        searchObject.DocumentDateFrom,
        //                                                        searchObject.DocumentDateTo,
        //                                                        BranchList);
        //        }
        //    }
        //    else
        //    {
        //        ds = objDocumentsController.GetFeePaymentSet(searchObject.ACDocumentNo,
        //                                                        objObjectsInfo.ACObjectID,
        //                                                        objObjectsInfo.ACObjectType,
        //                                                        searchObject.FK_HREmployeeID,
        //                                                        searchObject.ICReceiptPackNo,
        //                                                        searchObject.DocumentDateFrom,
        //                                                        searchObject.DocumentDateTo,
        //                                                        searchObject.FK_BRBranchID);
        //    }
        //    //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END

        //    return ds;
        //}

        public override void ModuleAfterSaved(int iObjectID)
        {
            base.ModuleAfterSaved(iObjectID);

            FeePaymentEntities entity = (FeePaymentEntities)CurrentModuleEntity;
            //foreach (APFeePaymentReceiptsInfo feePaymentReceipt in entity.FeePaymentReceiptList)
            //{
            //    entity.UpdateInventoryCost(feePaymentReceipt.FK_ICReceiptID);
            //}
            //foreach (int id in entity.RemovedItemIDs)
            //{
            //    entity.UpdateInventoryCost(id);
            //}

            //foreach (APFeePaymentTransfersInfo feePaymentTransfer in entity.FeePaymentTransferList)
            //{
            //    entity.UpdateTransferInventoryCost(feePaymentTransfer.FK_ICTransferID);
            //}
            //foreach (int id in entity.RemovedTransferItemIDs)
            //{
            //    entity.UpdateTransferInventoryCost(id);
            //}

            //foreach (APFeePaymentInvoiceInternalReceiptsInfo feePaymentReceipt in entity.FeePaymentInvoiceInternalReceiptList)
            //{
            //    entity.UpdateInvoiceInternalReceiptInventoryCost(feePaymentReceipt.FK_ICInvoiceInternalReceiptID);
            //}
            //foreach (int id in entity.RemovedInvoiceInternalReceiptItemIDs)
            //{
            //    entity.UpdateInvoiceInternalReceiptInventoryCost(id);
            //}

            //UpdateReferenceShipmentReceipt();
            //ActionPosted();
        }

        public override int GetDocumentTypeID()
        {
            //TNDLoc [ADD][30/07/2018][Fee Payment InvoiceIn],START
            FeePaymentEntities entity = (FeePaymentEntities)CurrentModuleEntity;
            ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
            int documentTypeID = 0;
            if (entity.FeePaymentInvoiceInList.Count > 0 || IsNewImport)
            {
                documentTypeID = objDocumentTypesController.GetObjectIDByName(AccDocumentType.ThanhToanPhiNhapKhau.ToString());
            }
            else if (entity.FeePaymentInvoiceList.Count > 0 || IsNewSaleInvoice)
            {
                documentTypeID = objDocumentTypesController.GetObjectIDByName(AccDocumentType.ThanhToanPhiHoaDonBanHang.ToString());
            }
            else
            {
                documentTypeID = objDocumentTypesController.GetObjectIDByName(AccDocumentType.ThanhToanPhi.ToString());
            }

            //TNDLoc [ADD][30/07/2018][Fee Payment InvoiceIn],END
            return documentTypeID;
        }

        public override void ActionNew()
        {
            FeePaymentEntities entity = CurrentModuleEntity as FeePaymentEntities;
            entity.ReceiptItemList.Clear();
            base.ActionNew();
        }

        public override int ActionSave()
        {
            FeePaymentEntities entity = (FeePaymentEntities)CurrentModuleEntity;
            ACDocumentsInfo objDocumentsInfo = (ACDocumentsInfo)entity.MainObject;
            if (string.IsNullOrEmpty(objDocumentsInfo.ACObjectAccessKey))
            {
                MessageBox.Show("Vui lòng chọn đối tượng người thanh toán.", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }
            if (IsNewImport && entity.FeePaymentInvoiceInList.Count() == 0)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn mua hàng cho thanh toán phí nhập khẩu.", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }    
            entity.FeePaymentFeeConfigList.EndCurrentEdit();
            bool isInValidateFeeConfig = entity.FeePaymentFeeConfigList.Where(o => string.IsNullOrEmpty(o.APFeePaymentFeeConfigInvoiceNumber) && o.APFeePaymentFeeConfigVATStatus == "VAT").Count() > 0;
            if (isInValidateFeeConfig)
            {
                MessageBox.Show(FeePaymentLocalizedResources.EnterInvoiceAgreementForFeePayment, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }
            isInValidateFeeConfig = entity.FeePaymentFeeConfigList.Where(o => o.FK_ICFeeConfigID <= 0).Count() > 0;
            if (isInValidateFeeConfig)
            {
                MessageBox.Show(FeePaymentLocalizedResources.ErrorFeeConfigID, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }
            entity.DocumentEntryList.EndCurrentEdit();
            UpdateTotalAmount();
            SetDocumentStatusValue(DocumentStatus.New.ToString());
            return base.ActionSave();
        }
        public override bool ActionComplete()
        {
            FeePaymentEntities entity = CurrentModuleEntity as FeePaymentEntities;
            CurrentModuleEntity.SetPropertyChangeEventLock(false);
            SetDocumentStatusValue(DocumentStatus.Complete.ToString(), false);
            bool isCompleted = base.ActionComplete();
            CurrentModuleEntity.SetPropertyChangeEventLock(true);
            ActionPosted();
            return isCompleted;
        }
        public void ActionAllotment()
        {
            FeePaymentEntities entity = CurrentModuleEntity as FeePaymentEntities;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            APFeePaymentReceiptsController objFeePaymentReceiptsController = new APFeePaymentReceiptsController();
            ICReceiptsController objReceiptsController = new ICReceiptsController();
            CurrentModuleEntity.SetPropertyChangeEventLock(false);
            if (entity.FeePaymentReceiptList.Count() == 0)
            {
                MessageBox.Show("Vui lòng chọn chứng từ nhập kho trước khi chạy phân bổ!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            List<string> receiptNo = new List<string>();
            foreach (APFeePaymentReceiptsInfo item in entity.FeePaymentReceiptList)
            {
                item.IsExistShipment = false;
                if (!CheckIsExistShipment(item.FK_ICReceiptID))
                {
                    item.IsExistShipment = true;
                }
                ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)objReceiptsController.GetObjectByID(item.FK_ICReceiptID);
                if (objReceiptsInfo != null)
                {
                    if (objReceiptsInfo.ICReceiptStatus != ReceiptStatus.Complete.ToString())
                    {
                        receiptNo.Add(objReceiptsInfo.ICReceiptNo);
                    }
                }    
            }
            if (receiptNo.Count() > 0)
            {
                BOSApp.ShowMessage(String.Format("Không thể chạy phân bổ được! \n- Các chứng từ NKMH chưa hoàn tất: {0}", string.Join(",", receiptNo)));
                return;
            }    
            if (entity.FeePaymentReceiptList.Where(o => o.IsExistShipment).Count() > 0)
            {
                BOSApp.ShowMessage("Không thể chạy phân bổ được!. Đã có chứng từ xuất kho");
                return;
            }
            AllocationReceiptCost();
            entity.FeePaymentReceiptList.ForEach(o => GLHelper.PostedTransactions(ModuleName.PurchaseReceipt, o.FK_ICReceiptID, ModulePostingType.Accounting, ModulePostingType.Stock));
            mainObject.ACDocumentFollowPosted = true;
            SetDocumentStatusValue(DocumentStatus.Complete.ToString(), true);
            //string tableName = mainObject.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
            entity.UpdateMainObject();
            CurrentModuleEntity.SetPropertyChangeEventLock(true);
            InvalidateToolbar();
        }

        public void AllocationReceiptCost()
        {
            FeePaymentEntities entity = (FeePaymentEntities)CurrentModuleEntity;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            APFeePaymentReceiptsController objFeePaymentReceiptsController = new APFeePaymentReceiptsController();
            decimal sumCost = entity.FeePaymentFeeConfigList.Sum(o => o.APFeePaymentFeeConfigAmount);
            decimal allocationCost = 0;
            foreach (APFeePaymentReceiptsInfo item in entity.FeePaymentReceiptList)
            {
                decimal totalAmount = entity.FeePaymentReceiptList.Sum(o => o.ICReceiptTotalCost);
                if (totalAmount == 0)
                {
                    item.APFeePaymentReceiptAllocationCost = 0;
                }
                else
                {
                    allocationCost = entity.FeePaymentReceiptList.Sum(o => o.APFeePaymentReceiptAllocationCost);
                    item.APFeePaymentReceiptAllocationCost = Math.Round(item.ICReceiptTotalCost * sumCost / totalAmount, 2, MidpointRounding.AwayFromZero);
                    if (allocationCost + item.APFeePaymentReceiptAllocationCost > sumCost)
                        item.APFeePaymentReceiptAllocationCost = sumCost - allocationCost;
                }
                objFeePaymentReceiptsController.UpdateObject(item);
            }
            entity.FeePaymentReceiptList.GridControl.RefreshDataSource();
        }    
        public void UpdateTotalAmount()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                FeePaymentEntities entity = (FeePaymentEntities)CurrentModuleEntity;
                ACDocumentsInfo objDocumentsInfo = (ACDocumentsInfo)entity.MainObject;
                UpdateDocumentEntryList();
                objDocumentsInfo.ACDocumentTotalAmount = entity.FeePaymentFeeConfigList.Sum(e => (e.APFeePaymentFeeConfigAmount + e.APFeePaymentFeeConfigTaxAmount));
                objDocumentsInfo.ACDocumentExchangeAmount = objDocumentsInfo.ACDocumentTotalAmount * objDocumentsInfo.ACDocumentExchangeRate;
                entity.UpdateMainObjectBindingSource();
            }
        }

        public override void GenerateAccountingData()
        {
            //TNDLoc [ADD][30/07/2018][Fee Payment InvoiceIn],START
            if (IsNewImport)
            {
                GenerateAccountingData(new string[] { AccDocumentType.ThanhToanPhiNhapKhau.ToString() });
            }
            else if (IsNewSaleInvoice)
            {
                GenerateAccountingData(new string[] { AccDocumentType.ThanhToanPhiHoaDonBanHang.ToString() });
            }
            else
            {
                GenerateAccountingData(new string[] { AccDocumentType.ThanhToanPhi.ToString() });
            }
            //TNDLoc [ADD][30/07/2018][Fee Payment InvoiceIn],END
        }

        /// <summary>
        /// Called when the user chooses receipts for the fee payment
        /// </summary>
        public void ChooseReceipts()
        {
            ICReceiptsController objReceiptsController = new ICReceiptsController();
            FeePaymentEntities entity = (FeePaymentEntities)CurrentModuleEntity;
            ACDocumentsInfo objDocumentsInfo = (ACDocumentsInfo)entity.MainObject;
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
            //List<ICReceiptsInfo> receipts = objReceiptsController.GetReceiptsForFeePayment();
            List<int> listInvoiceInIds = entity.FeePaymentInvoiceInList.Select(o => o.FK_APInvoiceInID).ToList();
            string InvoiceInIDs = string.Join(", ", listInvoiceInIds);
            List<ICReceiptsInfo> receipts = objReceiptsController.GetReceiptsForFeePaymentByUserPermission( InvoiceInIDs,
                                                                                                            BOSApp.CurrentUsersInfo.ADUserID,
                                                                                                            ModuleName.PurchaseReceipt,
                                                                                                            ADDataViewPermissionType.Module);
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END

            guiFind<ICReceiptsInfo> guiFind = new guiFind<ICReceiptsInfo>(TableName.ICReceiptsTableName, receipts, this, true);
            guiFind.Module = this;
            if (guiFind.ShowDialog() == DialogResult.OK)
            {
                ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
                ICProductsController obj = new ICProductsController();
                objDocumentsInfo.ACDocumentProject = String.Join(", ", guiFind.SelectedObjects.Select(o => o.APPurchaseOrderProject).Distinct().ToArray());
                entity.UpdateMainObjectBindingSource();
                foreach (ICReceiptsInfo objReceiptsInfo in guiFind.SelectedObjects)
                {
                    if (!entity.FeePaymentReceiptList.Exists(r => r.FK_ICReceiptID == objReceiptsInfo.ICReceiptID))
                    {
                        APFeePaymentReceiptsInfo feePaymentReceipt = new APFeePaymentReceiptsInfo();
                        feePaymentReceipt.FK_ICReceiptID = objReceiptsInfo.ICReceiptID;
                        feePaymentReceipt.ICReceiptNo = objReceiptsInfo.ICReceiptNo;
                        feePaymentReceipt.ICReceiptDate = objReceiptsInfo.ICReceiptDate;
                        feePaymentReceipt.ICReceiptPackNo = objReceiptsInfo.ICReceiptPackNo;
                        feePaymentReceipt.ICReceiptInvoiceInNo = objReceiptsInfo.ICReceiptInvoiceInNo;
                        feePaymentReceipt.ICReceiptTotalCost = objReceiptsInfo.ICReceiptTotalCost;
                        feePaymentReceipt.APSupplierName = objReceiptsInfo.ACObjectName;
                        entity.FeePaymentReceiptList.Add(feePaymentReceipt);

                        List<ICReceiptItemsInfo> items = objReceiptItemsController.GetItemsByReceiptID(objReceiptsInfo.ICReceiptID);
                        APFeePaymentItemsInfo objFeePaymentItemsInfo;
                        foreach (var item in items)
                        {
                            ICProductsInfo objProductsInfo = (ICProductsInfo)obj.GetObjectByID(item.FK_ICProductID);
                            if (objProductsInfo != null)
                            {
                                //UpdateDocumentEntryList(objProductsInfo.FK_ACAccountID, 0, entity, 0);
                                item.FK_ACAccountID = objProductsInfo.FK_ACAccountID;
                                entity.ReceiptItemList.Add(item);
                            }
                            objFeePaymentItemsInfo = new APFeePaymentItemsInfo();
                            objFeePaymentItemsInfo.FK_ACAccountID = item.FK_ACAccountID;
                            objFeePaymentItemsInfo.FK_ICProductID = item.FK_ICProductID;
                            objFeePaymentItemsInfo.APFeePaymentItemName = item.ICReceiptItemProductDesc;
                            objFeePaymentItemsInfo.APFeePaymentItemQty = item.ICReceiptItemProductQty;
                            objFeePaymentItemsInfo.APFeePaymentItemUnitCost = item.ICReceiptItemProductUnitCost;
                            objFeePaymentItemsInfo.APFeePaymentItemTotalCost = item.ICReceiptItemTotalCost;
                            objFeePaymentItemsInfo.APFeePaymentItemReferenceNo = objReceiptsInfo.ICReceiptNo;
                            objFeePaymentItemsInfo.APFeePaymentItemReferenceItemID = item.Id;
                            entity.FeePaymentItemList.Add(objFeePaymentItemsInfo);
                        }
                        // Lấy danh sách
                        //ICReceiptItemContFeesController objReceiptItemContFeesController = new ICReceiptItemContFeesController();
                        //List<ICReceiptItemContFeesInfo> receiptItemContFeeList = objReceiptItemContFeesController.GetDataByICReceiptID(objReceiptsInfo.ICReceiptID);
                        //if (receiptItemContFeeList != null && receiptItemContFeeList.Count > 0)
                        //{
                        //    receiptItemContFeeList.ForEach(o =>
                        //    {
                        //        APFeePaymentFeeConfigsInfo objAPFeePaymentFeeConfigsInfo = new APFeePaymentFeeConfigsInfo();
                        //        objAPFeePaymentFeeConfigsInfo.APFeePaymentFeeConfigNo = objReceiptsInfo.ICReceiptNo;
                        //        objAPFeePaymentFeeConfigsInfo.FK_GETerminalID = objReceiptsInfo.FK_GETerminalID;
                        //        objAPFeePaymentFeeConfigsInfo.FK_GEContainerID = o.FK_GEContainerID;
                        //        objAPFeePaymentFeeConfigsInfo.FK_GEUnitCostID = o.FK_GEUnitCostID;
                        //        objAPFeePaymentFeeConfigsInfo.APFeePaymentFeeConfigQty = 1;
                        //        objAPFeePaymentFeeConfigsInfo.APFeePaymentFeeConfigAmount = o.ICReceiptItemContFeeTotalCost;
                        //        objAPFeePaymentFeeConfigsInfo.APFeePaymentFeeConfigTotalAmount = o.ICReceiptItemContFeeTotalCost;
                        //        entity.FeePaymentFeeConfigList.Add(objAPFeePaymentFeeConfigsInfo);
                        //    });
                        //}
                    }
                }

                UpdateDocumentEntryList();
                if (objDocumentsInfo.ACDocumentStatus == DocumentStatus.Complete.ToString())
                    entity.FeePaymentReceiptList.SaveItemObjects();
                entity.FeePaymentReceiptList.GridControl.RefreshDataSource();
                entity.FeePaymentItemList.GridControl.RefreshDataSource();
                entity.FeePaymentFeeConfigList.GridControl.RefreshDataSource();

                //string feePaymentAllocationCriteria = string.Empty;
                //if (objDocumentsInfo.ACDocumentAllocationCriteria == DocumentAllocationCriteria.Qty.ToString() ||
                //    objDocumentsInfo.ACDocumentAllocationCriteria == DocumentAllocationCriteria.Amount.ToString()
                //    )
                //{
                //    feePaymentAllocationCriteria = objDocumentsInfo.ACDocumentAllocationCriteria;
                //}
                //UpdateFeePaymentItemByAllocationCriteria(feePaymentAllocationCriteria);
            }
        }

        public void ChooseInvoiceInternalReceipts()
        {
            ICReceiptsController objReceiptsController = new ICReceiptsController();
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
            //List<ICReceiptsInfo> receipts = objReceiptsController.GetReceiptsForFeePayment();
            List<ICReceiptsInfo> receipts = objReceiptsController.GetInvoiceInternalReceiptsForFeePaymentByUserPermission(BOSApp.CurrentUsersInfo.ADUserID,
                                                                                                            ModuleName.PurchaseReceipt,
                                                                                                            ADDataViewPermissionType.Module);
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END

            guiFind<ICReceiptsInfo> guiFind = new guiFind<ICReceiptsInfo>(TableName.ICReceiptsTableName, receipts, this, true);
            guiFind.Module = this;
            if (guiFind.ShowDialog() == DialogResult.OK)
            {
                FeePaymentEntities entity = (FeePaymentEntities)CurrentModuleEntity;
                ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
                ICProductsController obj = new ICProductsController();

                foreach (ICReceiptsInfo objReceiptsInfo in guiFind.SelectedObjects)
                {
                    if (!entity.FeePaymentReceiptList.Exists(r => r.FK_ICReceiptID == objReceiptsInfo.ICReceiptID))
                    {
                        APFeePaymentInvoiceInternalReceiptsInfo feePaymentReceipt = new APFeePaymentInvoiceInternalReceiptsInfo();
                        feePaymentReceipt.FK_ICInvoiceInternalReceiptID = objReceiptsInfo.ICReceiptID;
                        feePaymentReceipt.ICReceiptNo = objReceiptsInfo.ICReceiptNo;
                        feePaymentReceipt.ICReceiptDate = objReceiptsInfo.ICReceiptDate;
                        feePaymentReceipt.ICReceiptPackNo = objReceiptsInfo.ICReceiptPackNo;
                        feePaymentReceipt.ICReceiptTotalCost = objReceiptsInfo.ICReceiptTotalCost * objReceiptsInfo.ICReceiptExchangeRate;
                        feePaymentReceipt.APSupplierName = objReceiptsInfo.ACObjectName;
                        entity.FeePaymentInvoiceInternalReceiptList.Add(feePaymentReceipt);

                        List<ICReceiptItemsInfo> items = objReceiptItemsController.GetItemsByReceiptID(objReceiptsInfo.ICReceiptID);
                        APFeePaymentItemsInfo objFeePaymentItemsInfo;
                        foreach (var item in items)
                        {
                            ICProductsInfo objProductsInfo = (ICProductsInfo)obj.GetObjectByID(item.FK_ICProductID);
                            if (objProductsInfo != null)
                            {
                                //UpdateDocumentEntryList(objProductsInfo.FK_ACAccountID, 0, entity, 0);
                                item.FK_ACAccountID = objProductsInfo.FK_ACAccountID;
                                entity.InvoiceInternalReceiptItemList.Add(item);
                            }
                            objFeePaymentItemsInfo = new APFeePaymentItemsInfo();
                            objFeePaymentItemsInfo.FK_ACAccountID = item.FK_ACAccountID;
                            objFeePaymentItemsInfo.FK_ICProductID = item.FK_ICProductID;
                            objFeePaymentItemsInfo.APFeePaymentItemName = item.ICReceiptItemProductDesc;
                            objFeePaymentItemsInfo.APFeePaymentItemQty = item.ICReceiptItemProductQty;
                            objFeePaymentItemsInfo.APFeePaymentItemUnitCost = item.ICReceiptItemProductUnitCost;
                            objFeePaymentItemsInfo.APFeePaymentItemTotalCost = item.ICReceiptItemTotalCost;
                            objFeePaymentItemsInfo.APFeePaymentItemReferenceNo = objReceiptsInfo.ICReceiptNo;
                            objFeePaymentItemsInfo.APFeePaymentItemReferenceItemID = item.Id;
                            entity.FeePaymentItemList.Add(objFeePaymentItemsInfo);
                        }
                    }
                }

                UpdateDocumentEntryList();
                entity.FeePaymentItemList.GridControl.RefreshDataSource();
                entity.FeePaymentInvoiceInternalReceiptList.GridControl.RefreshDataSource();
            }
        }

        public void ChooseTransfer()
        {

            ICTransfersController transferController = new ICTransfersController();
            List<ICTransfersInfo> transfers = transferController.GetTransfersForFeePaymentByUserPermission(BOSApp.CurrentUsersInfo.ADUserID,
                                                                                                            ModuleName.Transfer,
                                                                                                            ADDataViewPermissionType.Module);

            guiFind<ICTransfersInfo> guiFind = new guiFind<ICTransfersInfo>(TableName.ICTransfersTableName, transfers, this, true);
            guiFind.Module = this;
            if (guiFind.ShowDialog() == DialogResult.OK)
            {
                FeePaymentEntities entity = (FeePaymentEntities)CurrentModuleEntity;
                ICTransferItemsController objTransferItemsController = new ICTransferItemsController();
                ICProductsController obj = new ICProductsController();

                foreach (ICTransfersInfo objTransfersInfo in guiFind.SelectedObjects)
                {
                    if (!entity.FeePaymentTransferList.Exists(r => r.FK_ICTransferID == objTransfersInfo.ICTransferID))
                    {
                        APFeePaymentTransfersInfo feePaymentTransfer = new APFeePaymentTransfersInfo();
                        feePaymentTransfer.FK_ICTransferID = objTransfersInfo.ICTransferID;
                        feePaymentTransfer.ICTransferNo = objTransfersInfo.ICTransferNo;
                        feePaymentTransfer.ICTransferDate = objTransfersInfo.ICTransferDate;
                        entity.FeePaymentTransferList.Add(feePaymentTransfer);

                        List<ICTransferItemsInfo> items = objTransferItemsController.GetItemsByTransferID(objTransfersInfo.ICTransferID);
                        APFeePaymentItemsInfo objFeePaymentItemsInfo;
                        foreach (var item in items)
                        {
                            ICProductsInfo objProductsInfo = (ICProductsInfo)obj.GetObjectByID(item.FK_ICProductID);
                            if (objProductsInfo != null)
                            {
                                item.FK_ACAccountID = objProductsInfo.FK_ACAccountID;
                                entity.TransferItemList.Add(item);
                            }

                            objFeePaymentItemsInfo = new APFeePaymentItemsInfo();
                            objFeePaymentItemsInfo.FK_ACAccountID = item.FK_ACAccountID;
                            objFeePaymentItemsInfo.FK_ICProductID = item.FK_ICProductID;
                            objFeePaymentItemsInfo.APFeePaymentItemName = item.ICTransferItemProductDesc;
                            objFeePaymentItemsInfo.APFeePaymentItemQty = item.ICTransferItemProductQty;
                            objFeePaymentItemsInfo.APFeePaymentItemUnitCost = item.ICTransferItemProductUnitCost;
                            objFeePaymentItemsInfo.APFeePaymentItemTotalCost = objFeePaymentItemsInfo.APFeePaymentItemUnitCost * objFeePaymentItemsInfo.APFeePaymentItemTotalCost;
                            objFeePaymentItemsInfo.APFeePaymentItemReferenceNo = objTransfersInfo.ICTransferNo;
                            objFeePaymentItemsInfo.APFeePaymentItemReferenceItemID = item.ICTransferItemID;
                            //objFeePaymentItemsInfo.APFeePaymentItemType = FeePaymentItemType
                            entity.FeePaymentItemList.Add(objFeePaymentItemsInfo);

                        }
                    }
                }

                UpdateDocumentEntryList();
                entity.FeePaymentItemList.GridControl.RefreshDataSource();
                entity.FeePaymentTransferList.GridControl.RefreshDataSource();
            }
        }

        public void ChooseDryLumberReceipts()
        {
            ICReceiptsController objReceiptsController = new ICReceiptsController();
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
            //List<ICReceiptsInfo> receipts = objReceiptsController.GetReceiptsForFeePayment();
            List<ICReceiptsInfo> receipts = objReceiptsController.GetHeatReceiptsForFeePayment();
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END

            guiFind<ICReceiptsInfo> guiFind = new guiFind<ICReceiptsInfo>(TableName.ICReceiptsTableName, receipts, this, true);
            guiFind.Module = this;
            if (guiFind.ShowDialog() == DialogResult.OK)
            {
                FeePaymentEntities entity = (FeePaymentEntities)CurrentModuleEntity;
                ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
                ICProductsController obj = new ICProductsController();

                foreach (ICReceiptsInfo objReceiptsInfo in guiFind.SelectedObjects)
                {
                    if (!entity.FeePaymentReceiptList.Exists(r => r.FK_ICReceiptID == objReceiptsInfo.ICReceiptID))
                    {
                        APFeePaymentReceiptsInfo feePaymentReceipt = new APFeePaymentReceiptsInfo();
                        feePaymentReceipt.FK_ICReceiptID = objReceiptsInfo.ICReceiptID;
                        feePaymentReceipt.ICReceiptNo = objReceiptsInfo.ICReceiptNo;
                        feePaymentReceipt.ICReceiptDate = objReceiptsInfo.ICReceiptDate;
                        feePaymentReceipt.ICReceiptPackNo = objReceiptsInfo.ICReceiptPackNo;
                        feePaymentReceipt.ICReceiptInvoiceInNo = objReceiptsInfo.ICReceiptInvoiceInNo;
                        //feePaymentReceipt.ICReceiptTotalCost = objReceiptsInfo.ICReceiptTotalCost;
                        feePaymentReceipt.ICReceiptTotalCost = objReceiptsInfo.ICReceiptTotalCost * objReceiptsInfo.ICReceiptExchangeRate;
                        feePaymentReceipt.APSupplierName = objReceiptsInfo.APSupplierName;
                        entity.FeePaymentReceiptList.Add(feePaymentReceipt);

                        List<ICReceiptItemsInfo> items = objReceiptItemsController.GetItemsByReceiptID(objReceiptsInfo.ICReceiptID);
                        APFeePaymentItemsInfo objFeePaymentItemsInfo;
                        foreach (var item in items)
                        {
                            ICProductsInfo objProductsInfo = (ICProductsInfo)obj.GetObjectByID(item.FK_ICProductID);
                            if (objProductsInfo != null)
                            {
                                //UpdateDocumentEntryList(objProductsInfo.FK_ACAccountID, 0, entity, 0);
                                item.FK_ACAccountID = objProductsInfo.FK_ACAccountID;
                                entity.ReceiptItemList.Add(item);
                            }
                            objFeePaymentItemsInfo = new APFeePaymentItemsInfo();
                            objFeePaymentItemsInfo.FK_ACAccountID = item.FK_ACAccountID;
                            objFeePaymentItemsInfo.FK_ICProductID = item.FK_ICProductID;
                            objFeePaymentItemsInfo.APFeePaymentItemName = item.ICReceiptItemProductDesc;
                            objFeePaymentItemsInfo.APFeePaymentItemQty = item.ICReceiptItemProductQty;
                            objFeePaymentItemsInfo.APFeePaymentItemUnitCost = item.ICReceiptItemProductUnitCost;
                            objFeePaymentItemsInfo.APFeePaymentItemTotalCost = item.ICReceiptItemTotalCost;
                            objFeePaymentItemsInfo.APFeePaymentItemReferenceNo = objReceiptsInfo.ICReceiptNo;
                            objFeePaymentItemsInfo.APFeePaymentItemReferenceItemID = item.Id;
                            entity.FeePaymentItemList.Add(objFeePaymentItemsInfo);
                        }
                    }
                }

                UpdateDocumentEntryList();
                entity.FeePaymentItemList.GridControl.RefreshDataSource();
                entity.FeePaymentReceiptList.GridControl.RefreshDataSource();
            }
        }
        public void ChoosePurchaseOrders()
        {
            APPurchaseOrdersController objPurchaseOrdersController = new APPurchaseOrdersController();
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
            //List<ICReceiptsInfo> receipts = objReceiptsController.GetReceiptsForFeePayment();
            List<APPurchaseOrdersInfo> purchaseOrders = objPurchaseOrdersController.GetPurchaseOrdersForFeePaymentByUserPermission(BOSApp.CurrentUsersInfo.ADUserID,
                                                                                                            ModuleName.PurchaseOrder,
                                                                                                            ADDataViewPermissionType.Module);
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END

            guiFind<APPurchaseOrdersInfo> guiFind = new guiFind<APPurchaseOrdersInfo>(TableName.APPurchaseOrdersTableName, purchaseOrders, this, true);
            guiFind.Module = this;
            if (guiFind.ShowDialog() == DialogResult.OK)
            {
                FeePaymentEntities entity = (FeePaymentEntities)CurrentModuleEntity;
                APPurchaseOrderItemsController objPurchaseOrderItemsController = new APPurchaseOrderItemsController();
                ICProductsController obj = new ICProductsController();

                foreach (APPurchaseOrdersInfo objPurchaseOrdersInfo in guiFind.SelectedObjects)
                {
                    if (!entity.FeePaymentPurchaseOrderList.Exists(r => r.FK_APPurchaseOrderID == objPurchaseOrdersInfo.APPurchaseOrderID))
                    {
                        APFeePaymentPurchaseOrdersInfo feePaymentPurchaseOrder = new APFeePaymentPurchaseOrdersInfo();
                        feePaymentPurchaseOrder.FK_APPurchaseOrderID = objPurchaseOrdersInfo.APPurchaseOrderID;
                        feePaymentPurchaseOrder.APPurchaseOrderNo = objPurchaseOrdersInfo.APPurchaseOrderNo;
                        feePaymentPurchaseOrder.APPurchaseOrderDate = objPurchaseOrdersInfo.APPurchaseOrderDate;
                        feePaymentPurchaseOrder.APPurchaseOrderTotalCost = objPurchaseOrdersInfo.APPurchaseOrderTotalCost;
                        feePaymentPurchaseOrder.APSupplierName = objPurchaseOrdersInfo.APSupplierName;

                        entity.FeePaymentPurchaseOrderList.Add(feePaymentPurchaseOrder);
                    }
                }

                //entity.GetValueFeePaymentItemByObjectID();
                entity.FeePaymentItemList.GridControl.RefreshDataSource();
                entity.FeePaymentPurchaseOrderList.GridControl.RefreshDataSource();
            }
        }

        public void updateTotalAmountbyCurrecy()
        {
            ACDocumentsInfo mainObject = (ACDocumentsInfo)CurrentModuleEntity.MainObject;
            GECurrencyExchangeRatesController objCurrencyExchangeRatesController = new GECurrencyExchangeRatesController();
            decimal exchangeRateValue = objCurrencyExchangeRatesController.GetCurrencyExchangeRateByCurrencyIDAndDate(mainObject.FK_GECurrencyID, mainObject.ACDocumentDate);
            if (exchangeRateValue > 0)
            {
                mainObject.ACDocumentExchangeRate = exchangeRateValue;
            }
            CurrentModuleEntity.UpdateMainObjectBindingSource();
            UpdateDocumentEntryList();
        }

        /// <summary>
        /// Remove the selected receipt from the receipt list
        /// </summary>
        public void RemoveSelectedReceipt()
        {
            FeePaymentEntities entity = (FeePaymentEntities)CurrentModuleEntity;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            if (mainObject.ACDocumentFollowPosted)
                return;
            //remove from receipt item list
            if (entity.FeePaymentReceiptList.CurrentIndex >= 0)
            {
                string referenceNo = entity.FeePaymentReceiptList[entity.FeePaymentReceiptList.CurrentIndex].ICReceiptNo;
                if (!string.IsNullOrEmpty(referenceNo))
                {
                    RemoveFeePaymentFeeConfig(referenceNo);
                    RemoveFeePaymentItem(referenceNo);
                }
            }
            entity.FeePaymentReceiptList.RemoveSelectedRowObjectFromList();
            RemoveReceiptItems();
            UpdateDocumentEntryList();
            PBAccount();
            if (mainObject.ACDocumentStatus == DocumentStatus.Complete.ToString())
                entity.FeePaymentReceiptList.SaveItemObjects();
        }

        private void RemoveFeePaymentItem(string referenceNo)
        {
            FeePaymentEntities entity = CurrentModuleEntity as FeePaymentEntities;
            List<APFeePaymentItemsInfo> removeItems = entity.FeePaymentItemList.Where(x => x.APFeePaymentItemReferenceNo == referenceNo).ToList();
            if (removeItems != null)
            {
                foreach (APFeePaymentItemsInfo receiptItem in removeItems)
                {
                    entity.FeePaymentItemList.Remove(receiptItem);
                }
                entity.FeePaymentItemList.GridControl.RefreshDataSource();
            }
        }

        private void RemoveFeePaymentFeeConfig(string referenceNo)
        {
            FeePaymentEntities entity = CurrentModuleEntity as FeePaymentEntities;
            List<APFeePaymentFeeConfigsInfo> removeItems = entity.FeePaymentFeeConfigList.Where(x => x.APFeePaymentFeeConfigNo == referenceNo).ToList();
            if (removeItems != null)
            {
                foreach (APFeePaymentFeeConfigsInfo receiptItem in removeItems)
                {
                    entity.FeePaymentFeeConfigList.Remove(receiptItem);
                }
                entity.FeePaymentFeeConfigList.GridControl.RefreshDataSource();
            }
        }

        public void RemoveSelectedInvoiceInternalReceipt()
        {
            FeePaymentEntities entity = (FeePaymentEntities)CurrentModuleEntity;
            if (entity.FeePaymentInvoiceInternalReceiptList.CurrentIndex >= 0)
            {
                string referenceNo = entity.FeePaymentInvoiceInternalReceiptList[entity.FeePaymentInvoiceInternalReceiptList.CurrentIndex].ICReceiptNo;
                if (!string.IsNullOrEmpty(referenceNo))
                {
                    RemoveFeePaymentFeeConfig(referenceNo);
                    RemoveFeePaymentItem(referenceNo);
                }
            }
            entity.FeePaymentInvoiceInternalReceiptList.RemoveSelectedRowObjectFromList();
            RemoveInvoiceInternalReceiptItems();
            UpdateDocumentEntryList();
            PBInvoiceInternalReceiptAccount();
        }

        public void RemoveSelectedTransfer()
        {
            FeePaymentEntities entity = (FeePaymentEntities)CurrentModuleEntity;
            if (entity.FeePaymentTransferList.CurrentIndex >= 0)
            {
                string referenceNo = entity.FeePaymentTransferList[entity.FeePaymentTransferList.CurrentIndex].ICTransferNo;
                if (!string.IsNullOrEmpty(referenceNo))
                {
                    RemoveFeePaymentFeeConfig(referenceNo);
                    RemoveFeePaymentItem(referenceNo);
                }
            }
            entity.FeePaymentTransferList.RemoveSelectedRowObjectFromList();
            RemoveTransferItems();
            UpdateDocumentEntryList();
            PBTransferAccount();
        }



        public void ChangeExchangeRate()
        {
            BOSTextBox bos = (BOSTextBox)Controls[ExchangeRateTextBox];
            decimal result = 0;
            decimal.TryParse(bos.EditValue.ToString(), out result);
            FeePaymentEntities entity = (FeePaymentEntities)CurrentModuleEntity;
            foreach (ACDocumentEntrysInfo entry in entity.DocumentEntryList)
            {
                entry.ACDocumentEntryExchangeAmount = entry.ACDocumentEntryAmount * result;
            }
        }

        public void PBInvoiceInternalReceiptAccount()
        {
            FeePaymentEntities entity = (FeePaymentEntities)CurrentModuleEntity;
            ACDocumentsInfo objDocumentsInfo = (ACDocumentsInfo)entity.MainObject;
            if (entity.FeePaymentInvoiceInternalReceiptList.Count == 0)
            {
                foreach (ACDocumentEntrysInfo entry in entity.DocumentEntryList)
                {
                    if (entry.ACEntryTypeName == AccEntryType.ChiPhiMuaHang.ToString())
                    {
                        BOSTextBox bos = (BOSTextBox)Controls[TotalAmountTextBox];
                        decimal result = 0;
                        //decimal.TryParse(bos.EditValue.ToString(), out result);
                        //entry.ACDocumentEntryAmount = result;
                        entry.ACDocumentEntryExchangeAmount = entry.ACDocumentEntryAmount * objDocumentsInfo.ACDocumentExchangeRate;
                        entity.DocumentEntryList.GridControl.RefreshDataSource();
                    }
                }
                return;
            }
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            Dictionary<int, object[]> list = new Dictionary<int, object[]>();
            int n = 1;
            decimal total = 0;
            foreach (var feePayment in entity.FeePaymentInvoiceInternalReceiptList)
            {
                List<ICReceiptItemsInfo> receiptItemList = objReceiptItemsController.GetItemsByReceiptID(feePayment.FK_ICInvoiceInternalReceiptID);
                ICProductsController obj = new ICProductsController();
                if (list.Where(p => p.Value[2].ToString() == feePayment.FK_ICInvoiceInternalReceiptID.ToString()).Count() == 0)
                {
                    foreach (var objReceiptItemsInfo in receiptItemList)
                    {
                        ICProductsInfo objProductsInfo = (ICProductsInfo)obj.GetObjectByID(objReceiptItemsInfo.FK_ICProductID);
                        decimal price = objReceiptItemsInfo.ICReceiptItemProductUnitCost * objReceiptItemsInfo.ICReceiptItemProductQty;
                        price -= price * (objReceiptItemsInfo.ICReceiptItemProductDiscount / Convert.ToDecimal(100.0));

                        total += price * objReceiptItemsInfo.ICReceiptExchangeRate;
                        list.Add(n++, new object[] {
                            objProductsInfo.FK_ACAccountID,
                            price * objReceiptItemsInfo.ICReceiptExchangeRate,
                            feePayment.FK_ICInvoiceInternalReceiptID});
                    }
                }
            }

            entity.DocumentEntryList.GridControl.RefreshDataSource();
        }

        public void PBAccount()
        {
            FeePaymentEntities entity = (FeePaymentEntities)CurrentModuleEntity;
            ACDocumentsInfo objDocumentsInfo = (ACDocumentsInfo)entity.MainObject;
            if (entity.FeePaymentReceiptList.Count == 0)
            {
                foreach (ACDocumentEntrysInfo entry in entity.DocumentEntryList)
                {
                    if (entry.ACEntryTypeName == AccEntryType.ChiPhiMuaHang.ToString())
                    {
                        BOSTextBox bos = (BOSTextBox)Controls[TotalAmountTextBox];
                        decimal result = 0;
                        //decimal.TryParse(bos.EditValue.ToString(), out result);
                        //entry.ACDocumentEntryAmount = result;
                        entry.ACDocumentEntryExchangeAmount = entry.ACDocumentEntryAmount * objDocumentsInfo.ACDocumentExchangeRate;
                        entity.DocumentEntryList.GridControl.RefreshDataSource();
                    }
                }
                return;
            }
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            Dictionary<int, object[]> list = new Dictionary<int, object[]>();
            int n = 1;
            decimal total = 0;
            foreach (var feePayment in entity.FeePaymentReceiptList)
            {
                List<ICReceiptItemsInfo> receiptItemList = objReceiptItemsController.GetItemsByReceiptID(feePayment.FK_ICReceiptID);
                ICProductsController obj = new ICProductsController();
                if (list.Where(p => p.Value[2].ToString() == feePayment.FK_ICReceiptID.ToString()).Count() == 0)
                {
                    foreach (var objReceiptItemsInfo in receiptItemList)
                    {
                        ICProductsInfo objProductsInfo = (ICProductsInfo)obj.GetObjectByID(objReceiptItemsInfo.FK_ICProductID);
                        decimal price = objReceiptItemsInfo.ICReceiptItemProductUnitCost * objReceiptItemsInfo.ICReceiptItemProductQty;
                        price -= price * (objReceiptItemsInfo.ICReceiptItemProductDiscount / Convert.ToDecimal(100.0));

                        total += price * objReceiptItemsInfo.ICReceiptExchangeRate;
                        list.Add(n++, new object[] {
                            objProductsInfo.FK_ACAccountID,
                            price * objReceiptItemsInfo.ICReceiptExchangeRate,
                            feePayment.FK_ICReceiptID});
                    }
                }
            }
            entity.DocumentEntryList.GridControl.RefreshDataSource();
        }

        public void PBTransferAccount()
        {
            FeePaymentEntities entity = (FeePaymentEntities)CurrentModuleEntity;
            ACDocumentsInfo objDocumentsInfo = (ACDocumentsInfo)entity.MainObject;
            if (entity.FeePaymentTransferList.Count == 0)
            {
                foreach (ACDocumentEntrysInfo entry in entity.DocumentEntryList)
                {
                    if (entry.ACEntryTypeName == AccEntryType.ChiPhiMuaHang.ToString())
                    {
                        BOSTextBox bos = (BOSTextBox)Controls[TotalAmountTextBox];
                        decimal result = 0;
                        //decimal.TryParse(bos.EditValue.ToString(), out result);
                        //entry.ACDocumentEntryAmount = result;
                        entry.ACDocumentEntryExchangeAmount = entry.ACDocumentEntryAmount * objDocumentsInfo.ACDocumentExchangeRate;
                        entity.DocumentEntryList.GridControl.RefreshDataSource();
                    }
                }
                return;
            }
            ICTransferItemsController objTransferItemsController = new ICTransferItemsController();
            Dictionary<int, object[]> list = new Dictionary<int, object[]>();
            int n = 1;
            decimal total = 0;
            foreach (var feePayment in entity.FeePaymentTransferList)
            {
                List<ICTransferItemsInfo> receiptItemList = objTransferItemsController.GetItemsByTransferID(feePayment.FK_ICTransferID);
                ICProductsController obj = new ICProductsController();
                if (list.Where(p => p.Value[2].ToString() == feePayment.FK_ICTransferID.ToString()).Count() == 0)
                {
                    foreach (var objReceiptItemsInfo in receiptItemList)
                    {
                        ICProductsInfo objProductsInfo = (ICProductsInfo)obj.GetObjectByID(objReceiptItemsInfo.FK_ICProductID);
                        decimal price = objReceiptItemsInfo.ICTransferItemProductUnitCost * objReceiptItemsInfo.ICTransferItemProductQty;
                        //price -= price * (objReceiptItemsInfo.ICReceiptItemProductDiscount / Convert.ToDecimal(100.0));

                        total += price;
                        list.Add(n++, new object[] {
                            objProductsInfo.FK_ACAccountID,
                            price,
                            feePayment.FK_ICTransferID});
                    }
                }
            }


            entity.DocumentEntryList.GridControl.RefreshDataSource();
        }

        private void RemoveInvoiceInternalReceiptItems()
        {
            FeePaymentEntities entity = CurrentModuleEntity as FeePaymentEntities;
            List<ICReceiptItemsInfo> removeItems = entity.InvoiceInternalReceiptItemList.Where(item =>
                                                           !entity.FeePaymentInvoiceInternalReceiptList.Any(feePaymentReceipt =>
                                                               item.FK_ICReceiptID == feePaymentReceipt.FK_ICInvoiceInternalReceiptID)).ToList();
            if (removeItems != null)
            {
                foreach (ICReceiptItemsInfo receiptItem in removeItems)
                {
                    entity.InvoiceInternalReceiptItemList.Remove(receiptItem);
                }
            }
        }


        private void RemoveReceiptItems()
        {
            FeePaymentEntities entity = CurrentModuleEntity as FeePaymentEntities;
            List<ICReceiptItemsInfo> removeItems = entity.ReceiptItemList.Where(item =>
                                                           !entity.FeePaymentReceiptList.Any(feePaymentReceipt =>
                                                               item.FK_ICReceiptID == feePaymentReceipt.FK_ICReceiptID)).ToList();
            if (removeItems != null)
            {
                foreach (ICReceiptItemsInfo receiptItem in removeItems)
                {
                    entity.ReceiptItemList.Remove(receiptItem);
                }
            }
        }

        private void RemoveTransferItems()
        {
            FeePaymentEntities entity = CurrentModuleEntity as FeePaymentEntities;
            List<ICTransferItemsInfo> removeItems = entity.TransferItemList.Where(item =>
                                                           !entity.FeePaymentTransferList.Any(feePaymentReceipt =>
                                                               item.FK_ICTransferID == feePaymentReceipt.FK_ICTransferID)).ToList();
            if (removeItems != null)
            {
                foreach (ICTransferItemsInfo receiptItem in removeItems)
                {
                    entity.TransferItemList.Remove(receiptItem);
                }
            }
        }

        private void UpdateDocumentEntryList()
        {
            FeePaymentEntities entity = CurrentModuleEntity as FeePaymentEntities;
            ACDocumentsInfo objDocumentsInfo = (ACDocumentsInfo)entity.MainObject;
            ACEntryTypesController objEntryTypesController = new ACEntryTypesController();
            int PurchaseID = objEntryTypesController.GetEntryTypeIDByName(AccEntryType.ChiPhiMuaHang.ToString());
            int ThueGTGT = objEntryTypesController.GetEntryTypeIDByName(AccEntryType.ThueGTGT.ToString());
            int ThueGTGTPN = objEntryTypesController.GetEntryTypeIDByName(AccEntryType.ThueGTGTPhaiNop.ToString());
            if (entity.FeePaymentInvoiceInList.Count == 0
                && entity.FeePaymentInvoiceList.Count == 0)
            {
                ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();
                ACDocTypeEntrysInfo defaultEntry = objDocTypeEntrysController.GetEntryByDocumentTypeAndEntryType(
                                                                           AccDocumentType.ThanhToanPhi.ToString(),
                                                                           AccEntryType.ChiPhiMuaHang.ToString());

                List<int> productAccountID = new List<int>();
                if (entity.ReceiptItemList != null
                    && entity.ReceiptItemList.Count > 0)
                {
                    foreach (ICReceiptItemsInfo receiptItem in entity.ReceiptItemList)
                    {
                        ACDocumentEntrysInfo entry = entity.DocumentEntryList.FirstOrDefault(e => e.ACEntryTypeName == AccEntryType.ChiPhiMuaHang.ToString()
                                                                                    && e.FK_ACDebitAccountID == receiptItem.FK_ACAccountID);
                        if (entry == null && defaultEntry != null)
                        {
                            entry = AccountHelper.AddItemToDocumentEntryList(defaultEntry, entity.DocumentEntryList);
                            entry.FK_ACDebitAccountID = receiptItem.FK_ACAccountID;
                        }
                        BOSApp.RoundByCurrency(entry, objDocumentsInfo.FK_GECurrencyID);
                    }

                    List<ACDocumentEntrysInfo> removedItems = entity.DocumentEntryList.Where(item => item.ACEntryTypeName == AccEntryType.ChiPhiMuaHang.ToString()
                                                                                  && !entity.ReceiptItemList.Any(receiptItem =>
                                                                                                                receiptItem.FK_ACAccountID == item.FK_ACDebitAccountID)).ToList();
                    if (removedItems != null)
                    {
                        foreach (ACDocumentEntrysInfo item in removedItems)
                            entity.DocumentEntryList.Remove(item);
                    }
                }
                else if (entity.TransferItemList != null
                    && entity.TransferItemList.Count > 0)
                {
                    foreach (ICTransferItemsInfo TransferItem in entity.TransferItemList)
                    {
                        ACDocumentEntrysInfo entry = entity.DocumentEntryList.FirstOrDefault(e => e.ACEntryTypeName == AccEntryType.ChiPhiMuaHang.ToString()
                                                                                    && e.FK_ACDebitAccountID == TransferItem.FK_ACAccountID);
                        if (entry == null && defaultEntry != null)
                        {
                            entry = AccountHelper.AddItemToDocumentEntryList(defaultEntry, entity.DocumentEntryList);
                            entry.FK_ACDebitAccountID = TransferItem.FK_ACAccountID;
                        }
                        BOSApp.RoundByCurrency(entry, objDocumentsInfo.FK_GECurrencyID);
                    }

                    List<ACDocumentEntrysInfo> removedItems = entity.DocumentEntryList.Where(item => item.ACEntryTypeName == AccEntryType.ChiPhiMuaHang.ToString()
                                                                                  && !entity.TransferItemList.Any(TransferItem =>
                                                                                                                TransferItem.FK_ACAccountID == item.FK_ACDebitAccountID)).ToList();
                    if (removedItems != null)
                    {
                        foreach (ACDocumentEntrysInfo item in removedItems)
                            entity.DocumentEntryList.Remove(item);
                    }
                }
                else if (entity.InvoiceInternalReceiptItemList != null
                    && entity.InvoiceInternalReceiptItemList.Count > 0)
                {
                    foreach (ICReceiptItemsInfo receiptItem in entity.InvoiceInternalReceiptItemList)
                    {
                        ACDocumentEntrysInfo entry = entity.DocumentEntryList.FirstOrDefault(e => e.ACEntryTypeName == AccEntryType.ChiPhiMuaHang.ToString()
                                                                                    && e.FK_ACDebitAccountID == receiptItem.FK_ACAccountID);
                        if (entry == null && defaultEntry != null)
                        {
                            entry = AccountHelper.AddItemToDocumentEntryList(defaultEntry, entity.DocumentEntryList);
                            entry.FK_ACDebitAccountID = receiptItem.FK_ACAccountID;
                        }
                        BOSApp.RoundByCurrency(entry, objDocumentsInfo.FK_GECurrencyID);
                    }

                    List<ACDocumentEntrysInfo> removedItems = entity.DocumentEntryList.Where(item => item.ACEntryTypeName == AccEntryType.ChiPhiMuaHang.ToString()
                                                                                  && !entity.InvoiceInternalReceiptItemList.Any(receiptItem =>
                                                                                                                receiptItem.FK_ACAccountID == item.FK_ACDebitAccountID)).ToList();
                    if (removedItems != null)
                    {
                        foreach (ACDocumentEntrysInfo item in removedItems)
                            entity.DocumentEntryList.Remove(item);
                    }
                }
                entity.DocumentEntryList.GridControl.RefreshDataSource();
            }
            if (entity.FeePaymentFeeConfigList != null && entity.FeePaymentFeeConfigList.Count > 0)
            {
                int SaleID = objEntryTypesController.GetEntryTypeIDByName(AccEntryType.ChiPhiBanHang.ToString());
                if (entity.FeePaymentInvoiceList.Count > 0)
                {
                    ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
                    ACDocumentEntrysInfo objDocumentEntrysInfo = entity.DocumentEntryList.FirstOrDefault(o => o.FK_ACEntryTypeID == PurchaseID || o.FK_ACEntryTypeID == SaleID);
                    objDocumentEntrysInfo.ACDocumentEntryID = 0;
                    entity.DocumentEntryList.Where(s => s.FK_ACEntryTypeID == PurchaseID || s.FK_ACEntryTypeID == SaleID)
                                        .ToList().ForEach(s => entity.DocumentEntryList.Remove(s));
                    entity.FeePaymentFeeConfigList.GroupBy(o => new { o.FK_ACCostCenterID, o.FK_ACSegmentID }).All(o =>
                    {
                        objDocumentEntrysInfo.FK_ACSegmentID = o.Key.FK_ACSegmentID;
                        objDocumentEntrysInfo.FK_ACCostCenterID = o.Key.FK_ACCostCenterID;
                        entity.DocumentEntryList.Add(objDocumentEntrysInfo.Clone() as ACDocumentEntrysInfo);

                        return true;
                    });

                    foreach (ACDocumentEntrysInfo item in entity.DocumentEntryList)
                    {
                        if (item.FK_ACEntryTypeID == PurchaseID || item.FK_ACEntryTypeID == SaleID)
                        {
                            item.ACDocumentEntryAmount = entity.FeePaymentFeeConfigList.Where(o => o.FK_ACSegmentID == item.FK_ACSegmentID && o.FK_ACCostCenterID == item.FK_ACCostCenterID)
                                                                                        .Sum(a => a.APFeePaymentFeeConfigAmount);
                            item.ACDocumentEntryExchangeAmount = item.ACDocumentEntryAmount * objDocumentsInfo.ACDocumentExchangeRate;
                        }
                        if (item.FK_ACEntryTypeID == ThueGTGT)
                        {
                            item.ACDocumentEntryAmount = entity.FeePaymentFeeConfigList.Sum(a => a.APFeePaymentFeeConfigTaxAmount);
                            item.ACDocumentEntryExchangeAmount = item.ACDocumentEntryAmount * objDocumentsInfo.ACDocumentExchangeRate;
                        }
                    }
                }
                else if (entity.FeePaymentReceiptList.Count > 0 || entity.FeePaymentInvoiceInternalReceiptList.Count > 0 || entity.FeePaymentTransferList.Count > 0)
                {
                    decimal totalAmountWithoutDiscount = 0;
                    decimal totalFeeConfigAmount = 0;

                    totalFeeConfigAmount = entity.FeePaymentFeeConfigList.Sum(o => o.APFeePaymentFeeConfigAmount);
                    foreach (ACDocumentEntrysInfo item in entity.DocumentEntryList)
                    {
                        if (item.FK_ACEntryTypeID == PurchaseID || item.FK_ACEntryTypeID == SaleID)
                        {
                            if (entity.ReceiptItemList != null && entity.ReceiptItemList.Count > 0 && totalFeeConfigAmount > 0)
                            {
                                totalAmountWithoutDiscount = entity.ReceiptItemList.Sum(o => ((1 - o.ICReceiptItemProductDiscount / 100)
                                                                                        * o.ICReceiptItemProductUnitCost * o.ICReceiptItemProductQty));
                                if (totalAmountWithoutDiscount > 0)
                                    item.ACDocumentEntryAmount = entity.ReceiptItemList.Where(o => o.FK_ACAccountID == item.FK_ACDebitAccountID)
                                                                        .Sum(o => ((1 - o.ICReceiptItemProductDiscount / 100)
                                                                            * o.ICReceiptItemProductUnitCost * o.ICReceiptItemProductQty / totalAmountWithoutDiscount) * totalFeeConfigAmount);
                            }
                            else if (entity.TransferItemList != null && entity.TransferItemList.Count > 0 && totalFeeConfigAmount > 0)
                            {
                                totalAmountWithoutDiscount = entity.TransferItemList.Sum(o => ((1 - o.ICTransferItemProductDiscount / 100)
                                                                                        * o.ICTransferItemProductUnitCost * o.ICTransferItemProductQty));
                                if (totalAmountWithoutDiscount > 0)
                                    item.ACDocumentEntryAmount = entity.TransferItemList.Where(o => o.FK_ACAccountID == item.FK_ACDebitAccountID)
                                                                                            .Sum(o => ((1 - o.ICTransferItemProductDiscount / 100)
                                                                                                * o.ICTransferItemProductUnitCost * o.ICTransferItemProductQty / totalAmountWithoutDiscount) * totalFeeConfigAmount);
                            }
                            else if (entity.InvoiceInternalReceiptItemList != null && entity.InvoiceInternalReceiptItemList.Count > 0)
                            {
                                totalAmountWithoutDiscount = entity.InvoiceInternalReceiptItemList.Sum(o => ((1 - o.ICReceiptItemProductDiscount / 100)
                                                                                        * o.ICReceiptItemProductUnitCost * o.ICReceiptItemProductQty));
                                if (totalAmountWithoutDiscount > 0)
                                    item.ACDocumentEntryAmount = entity.InvoiceInternalReceiptItemList.Where(o => o.FK_ACAccountID == item.FK_ACDebitAccountID)
                                                                        .Sum(o => ((1 - o.ICReceiptItemProductDiscount / 100)
                                                                            * o.ICReceiptItemProductUnitCost * o.ICReceiptItemProductQty / totalAmountWithoutDiscount) * totalFeeConfigAmount);
                            }
                            item.ACDocumentEntryExchangeAmount = item.ACDocumentEntryAmount * objDocumentsInfo.ACDocumentExchangeRate;
                        }
                        if (item.FK_ACEntryTypeID == ThueGTGT)
                        {
                            item.ACDocumentEntryAmount = entity.FeePaymentFeeConfigList.Sum(a => a.APFeePaymentFeeConfigTaxAmount);
                            item.ACDocumentEntryExchangeAmount = item.ACDocumentEntryAmount * objDocumentsInfo.ACDocumentExchangeRate;
                        }
                        BOSApp.RoundByCurrency(item, "ACDocumentEntryExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                        BOSApp.RoundByCurrency(item, "ACDocumentEntryAmount", objDocumentsInfo.FK_GECurrencyID);
                    }
                }
                else
                {
                    foreach (ACDocumentEntrysInfo item in entity.DocumentEntryList)
                    {
                        if (item.FK_ACEntryTypeID == PurchaseID || item.FK_ACEntryTypeID == SaleID)
                        {
                            item.ACDocumentEntryAmount = entity.FeePaymentFeeConfigList.Sum(a => a.APFeePaymentFeeConfigAmount);
                            item.ACDocumentEntryExchangeAmount = item.ACDocumentEntryAmount * objDocumentsInfo.ACDocumentExchangeRate;
                        }
                        if (item.FK_ACEntryTypeID == ThueGTGT)
                        {
                            item.ACDocumentEntryAmount = entity.FeePaymentFeeConfigList.Sum(a => a.APFeePaymentFeeConfigTaxAmount);
                            item.ACDocumentEntryExchangeAmount = item.ACDocumentEntryAmount * objDocumentsInfo.ACDocumentExchangeRate;
                        }
                    }
                }
            }
            if (objDocumentsInfo.FK_PMProjectID > 0)
            {
                entity.DocumentEntryList.ForEach(o =>
                {
                    o.FK_PMProjectID = objDocumentsInfo.FK_PMProjectID;
                });
            }
            entity.DocumentEntryList.GridControl.RefreshDataSource();
        }
        public void UpdateReferenceShipmentReceipt()
        {
            FeePaymentEntities entity = CurrentModuleEntity as FeePaymentEntities;
            BOSProgressBar.Start("Đang cập nhật dự liệu");
            ICReceiptsController receiptController = new ICReceiptsController();
            ICReceiptsInfo receipt;
            foreach (APFeePaymentReceiptsInfo item in entity.FeePaymentReceiptList)
            {
                receipt = (ICReceiptsInfo)receiptController.GetObjectByID(item.FK_ICReceiptID);
                if (receipt != null)
                {
                    BOSProgressBar.Start("Đang cập nhật " + receipt.ICReceiptNo);
                    receiptController.UpdateReferenceDocumentByFeePayment(item.FK_ICReceiptID);
                }
            }
            BOSProgressBar.Close();
        }


        public void UpdateAccountDebitDocumentEntrys(ACDocumentEntrysInfo objDocumentEntrysInfo)
        {
            FeePaymentEntities entity = (FeePaymentEntities)CurrentModuleEntity;
            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            ACUnfinishedConstructionCostsController objUnfinishedConstructionCostsController = new ACUnfinishedConstructionCostsController();
            ACUnfinishedConstructionCostsInfo objUnfinishedConstructionCostsInfo = (ACUnfinishedConstructionCostsInfo)objUnfinishedConstructionCostsController.GetObjectByID(objDocumentEntrysInfo.FK_ACUnfinishedConstructionCostID);
            objDocumentEntrysInfo.FK_ACDebitAccountID = objUnfinishedConstructionCostsInfo.FK_ACAccountID;
            entity.DocumentEntryList.GridControl.RefreshDataSource();
        }
        public override void ActionEdit()
        {

            FeePaymentEntities entity = CurrentModuleEntity as FeePaymentEntities;

            ACDocumentsInfo document = (ACDocumentsInfo)entity.MainObject;

            APPaymentProposalItemsController ppiController = new APPaymentProposalItemsController();
            List<APPaymentProposalItemsInfo> ppiList = ppiController.GetPaymentProposalItemByDocumentID(document.ACDocumentID);

            if (ppiList != null &&
                    ppiList.Count > 0)
            {
                MessageBox.Show("Chứng từ đã đề nghị thanh toán. Không thể chỉnh sửa."
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Information);
                return;
            }


            base.ActionEdit();
        }

        public void GetVATDocumentType()
        {
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
            configValueList = new List<ADConfigValuesInfo>();
            DataSet ds = objConfigValuesController.GetADConfigValuesByGroup("VATDocumentType");
            if (ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectFromDataRow(row);
                    configValueList.Add(objConfigValuesInfo);
                }
            }
            configValueList = configValueList.Where(o => o.ADConfigKeyValue.Substring(0, o.ADConfigKeyValue.Length - 1) == "InvoiceInType").ToList();
        }

        public void ChangeFeeConfig(APFeePaymentFeeConfigsInfo item)
        {
            if (item.APFeePaymentFeeConfigAmount > 0)
            {
                if (item.APFeePaymentFeeConfigTaxPercent > 0)
                {
                    item.APFeePaymentFeeConfigTaxAmount = (item.APFeePaymentFeeConfigAmount * item.APFeePaymentFeeConfigTaxPercent) / 100;
                }
                item.APFeePaymentFeeConfigTotalAmount = item.APFeePaymentFeeConfigAmount + item.APFeePaymentFeeConfigTaxAmount;
            }
            else
            {
                item.APFeePaymentFeeConfigTaxAmount = 0;
                item.APFeePaymentFeeConfigTaxPercent = 0;
                item.APFeePaymentFeeConfigTotalAmount = 0;
            }
        }
        public override void ActionDuplicate()
        {
            base.ActionDuplicate();
        }
        public void ChangeObject()
        {
            FeePaymentEntities entity = CurrentModuleEntity as FeePaymentEntities;
            ACDocumentsInfo document = (ACDocumentsInfo)entity.MainObject;
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo ObjectsInfo = objObjectsController.GetObjectByAccessKey(document.ACObjectAccessKey);
            if (ObjectsInfo != null)
            {
                document.FK_ACObjectID = ObjectsInfo.ACObjectID;
                document.ACObjectType = ObjectsInfo.ACObjectType;
                ACObjectsInfo objectsInfo = objObjectsController.GetObjectByIDAndType(ObjectsInfo.ACObjectID, ObjectsInfo.ACObjectType);
                if (objectsInfo != null)
                {
                    if (entity.DocumentEntryList != null && entity.DocumentEntryList.Count > 0)
                    {
                        entity.DocumentEntryList.ForEach(a => a.FK_ACCreditAccountID = objectsInfo.FK_ACAccountPurchaseID);
                    }
                }
            }
            entity.DocumentEntryList.GridControl.RefreshDataSource();
        }
        public void ChangeItemFromFeePaymentFeeConfigsList()
        {
            FeePaymentEntities entity = (FeePaymentEntities)CurrentModuleEntity;
            entity.FeePaymentFeeConfigList.ChangeObjectFromList();
            UpdateDocumentEntryList();
        }

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            ACDocumentsController objDocumentsController = new ACDocumentsController();
            ACDocumentsInfo searchObject = (ACDocumentsInfo)CurrentModuleEntity.SearchObject;
            DataSet ds = new DataSet();
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = new ACObjectsInfo();
            if (!string.IsNullOrEmpty(searchObject.ACObjectAccessKey))
            {
                objObjectsInfo = (ACObjectsInfo)objObjectsController.GetObjectByAccessKey(searchObject.ACObjectAccessKey);
                objObjectsInfo = objObjectsController.GetObjectByIDAndType(objObjectsInfo.ACObjectID, objObjectsInfo.ACObjectType);
            }
            if (SearchBranchLookupEditControl.EditValue.ToString() == "" || SearchBranchLookupEditControl.EditValue.ToString() == "0")
            {
                if (BranchList.Count == 0)
                {
                    ds = objDocumentsController.GetDataSetByID(-1);
                }
                else
                {
                    ds = objDocumentsController.GetInvoiceListDatasetByListOfBranchIDForFeePayment(
                                                                       searchObject.ACDocumentNo,
                                                        objObjectsInfo.ACObjectID,
                                                        objObjectsInfo.ACObjectType,
                                                        searchObject.FK_HREmployeeID,
                                                        searchObject.DocumentDateFrom,
                                                        searchObject.DocumentDateTo,
                                                        searchObject.ICReceiptPackNo,
                                                                        BranchList);
                }
            }
            else
            {
                ds = objDocumentsController.GetDocumentListDatasetForFeePayment(
                                                         searchObject.ACDocumentNo,
                                                        objObjectsInfo.ACObjectID,
                                                        objObjectsInfo.ACObjectType,
                                                        searchObject.FK_HREmployeeID,
                                                        searchObject.DocumentDateFrom,
                                                        searchObject.DocumentDateTo,
                                                        searchObject.FK_BRBranchID,
                                                        searchObject.ICReceiptPackNo);
            }
            return ds;
        }

        public void NewPurchaseReceipt()
        {
            IsNewImport = false;
            IsNewSaleInvoice = false;
            FeePaymentEntities entity = (FeePaymentEntities)CurrentModuleEntity;
            entity.FeePaymentInvoiceInList.Clear();
            entity.FeePaymentInvoiceList.Clear();
            ActionNew();
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            mainObject.ACDocumentCreateFrom = DocumentCreateFrom.PurchaseReceipt.ToString();
            entity.UpdateMainObjectBindingSource();
            SetDocumentStatusValue(DocumentStatus.New.ToString());
            SetCreateTypeControlValue(IsNewImport, true, false, false, false, true);
        }

        public void TransferReceipt()
        {
            IsNewImport = false;
            IsNewSaleInvoice = false;
            FeePaymentEntities entity = (FeePaymentEntities)CurrentModuleEntity;
            entity.FeePaymentInvoiceInList.Clear();
            entity.FeePaymentInvoiceList.Clear();
            ActionNew();
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            mainObject.ACDocumentCreateFrom = DocumentCreateFrom.TransferReceipt.ToString();
            entity.UpdateMainObjectBindingSource();
            SetCreateTypeControlValue(IsNewImport, false, true, false, false, true);
        }

        public void InvoiceInternalReceipt()
        {
            IsNewImport = false;
            IsNewSaleInvoice = false;
            FeePaymentEntities entity = (FeePaymentEntities)CurrentModuleEntity;
            entity.FeePaymentInvoiceInList.Clear();
            entity.FeePaymentInvoiceList.Clear();
            ActionNew();
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            mainObject.ACDocumentCreateFrom = DocumentCreateFrom.InvoiceInternalReceipt.ToString();
            entity.UpdateMainObjectBindingSource();
            SetCreateTypeControlValue(IsNewImport, false, false, true, false, true);
        }

        public void ChangeProject(int projectID)
        {
            FeePaymentEntities entity = CurrentModuleEntity as FeePaymentEntities;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            mainObject.FK_PMProjectID = projectID;

            entity.DocumentEntryList.ForEach(o =>
            {
                o.FK_PMProjectID = mainObject.FK_PMProjectID;
            });
            entity.DocumentEntryList.GridControl.RefreshDataSource();
        }

        public void ActionPosted()
        {
            if (!CheckLock()) return;
            FeePaymentEntities entity = CurrentModuleEntity as FeePaymentEntities;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            mainObject.ACDocumentPostedStatus = PostedTransactionStatus.Posted.ToString();
            string tableName = mainObject.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
            GLHelper.UpdatePostedStatus(this.Name, tableName, mainObject.ACDocumentID, PostedTransactionStatus.Posted.ToString());
            entity.SetPropertyChangeEventLock(true);
            GLHelper.PostedTransactions(this.Name, mainObject.ACDocumentID, ModulePostingType.Accounting, ModulePostingType.Stock, ModulePostingType.InvoiceInTrans);
            InvalidateToolbar();
        }

        public void ActionUnPosted()
        {
            if (!CheckLock()) return;
            FeePaymentEntities entity = CurrentModuleEntity as FeePaymentEntities;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            mainObject.ACDocumentPostedStatus = PostedTransactionStatus.UnPosted.ToString();
            string tableName = mainObject.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
            GLHelper.UpdatePostedStatus(this.Name, tableName, mainObject.ACDocumentID, PostedTransactionStatus.UnPosted.ToString());
            entity.SetPropertyChangeEventLock(true);
            GLHelper.UnPostedTransactions(this.Name, mainObject.ACDocumentID, ModulePostingType.Accounting, ModulePostingType.Stock, ModulePostingType.InvoiceInTrans);
            InvalidateToolbar();
        }

        public override void InvalidateToolbar()
        {
            FeePaymentEntities entity = CurrentModuleEntity as FeePaymentEntities;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions,false);
            ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions, false);
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonAllotment, false);
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
            if (mainObject.ACDocumentID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                if (mainObject.ACDocumentStatus == DocumentStatus.New.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, true);
                }
                else if (mainObject.ACDocumentStatus == DocumentStatus.Complete.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                    ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions,
                        mainObject.ACDocumentPostedStatus != PostedTransactionStatus.Posted.ToString());
                    ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions,
                        mainObject.ACDocumentPostedStatus == PostedTransactionStatus.Posted.ToString());
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonAllotment, !mainObject.ACDocumentFollowPosted);
                }
            }
            base.InvalidateToolbar();
        }

        public void UpdateFeePaymentAllocatedAmountByFeeConfigAmount(APFeePaymentFeeConfigsInfo objFeePaymentFeeConfigsInfo)
        {
            FeePaymentEntities entity = CurrentModuleEntity as FeePaymentEntities;
            ACDocumentsInfo objDocumentsInfo = (ACDocumentsInfo)entity.MainObject;
            BOSDbUtil dbUtil = new BOSDbUtil();
            //string feePaymentAllocationCriteria = string.Empty;
            //if (objDocumentsInfo.ACDocumentAllocationCriteria == DocumentAllocationCriteria.Qty.ToString() ||
            //    objDocumentsInfo.ACDocumentAllocationCriteria == DocumentAllocationCriteria.Amount.ToString()
            //    )
            //{
            //    feePaymentAllocationCriteria = objDocumentsInfo.ACDocumentAllocationCriteria;
            //}
            //UpdateFeePaymentItemByAllocationCriteria(feePaymentAllocationCriteria);
        }

        public void UpdateFeePaymentItemByAllocationCriteria(string documentAllocationCriteria)
        {
            FeePaymentEntities entity = CurrentModuleEntity as FeePaymentEntities;
            ACDocumentsInfo objDocumentsInfo = (ACDocumentsInfo)entity.MainObject;
            BOSDbUtil dbUtil = new BOSDbUtil();
            decimal AllocationAmount = entity.FeePaymentFeeConfigList.Sum(x => x.APFeePaymentFeeConfigAmount * (x.APFeePaymentFeeConfigQty == 0 ? 1 : x.APFeePaymentFeeConfigQty));
            if (documentAllocationCriteria == DocumentAllocationCriteria.Amount.ToString())
            {
                foreach (APFeePaymentItemsInfo item in entity.FeePaymentItemList)
                {
                    decimal sumAmount = entity.FeePaymentItemList.Sum(x => x.APFeePaymentItemTotalCost);
                    if (sumAmount == 0)
                    {
                        item.APFeePaymentItemCostAttribution = 0;
                    }
                    else
                    {
                        item.APFeePaymentItemCostAttribution = Math.Round(item.APFeePaymentItemTotalCost / sumAmount * AllocationAmount, 2, MidpointRounding.AwayFromZero);
                    }
                    dbUtil.SetPropertyValue(entity.FeePaymentItemList, "APFeePaymentItemCostAttribution", item.APFeePaymentItemCostAttribution);
                }
                UpdateDocumentEntryList();
            }
            else if (documentAllocationCriteria == DocumentAllocationCriteria.Qty.ToString())
            {
                foreach (APFeePaymentItemsInfo item in entity.FeePaymentItemList)
                {
                    decimal sumQty = entity.FeePaymentItemList.Sum(x => x.APFeePaymentItemQty);
                    if (sumQty == 0)
                    {
                        item.APFeePaymentItemCostAttribution = 0;
                    }
                    else
                    {
                        item.APFeePaymentItemCostAttribution = Math.Round(item.APFeePaymentItemQty / sumQty * AllocationAmount, 2, MidpointRounding.AwayFromZero);
                    }
                    dbUtil.SetPropertyValue(entity.FeePaymentItemList, "APFeePaymentItemCostAttribution", item.APFeePaymentItemCostAttribution);
                }
                UpdateDocumentEntryList();
            }
            entity.FeePaymentItemList.GridControl.RefreshDataSource();
        }

        public void ChangeDocumentAllocationCriteria(string documentAllocationCriteria)
        {
            FeePaymentEntities entity = (FeePaymentEntities)CurrentModuleEntity;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            mainObject.ACDocumentAllocationCriteria = documentAllocationCriteria;
            entity.UpdateMainObjectBindingSource();
            //UpdateFeePaymentItemByAllocationCriteria(mainObject.ACDocumentAllocationCriteria);
            UpdateDocumentEntryList();
        }
        public void SetDocumentStatusValue(string documentStatus, bool isAllocate = false)
        {
            FeePaymentEntities entity = (FeePaymentEntities)CurrentModuleEntity;
            if (DocumentStatusControl != null)
            {
                if (ChooseReceiptControl != null)
                {
                    ChooseReceiptControl.Enabled = true;
                    if (documentStatus == DocumentStatus.New.ToString())
                        DocumentStatusControl.SelectedIndex = 0;
                    else if (!isAllocate)
                        DocumentStatusControl.SelectedIndex = 1;
                    else
                    {
                        DocumentStatusControl.SelectedIndex = 2;
                        ChooseReceiptControl.Enabled = false;
                    }
                }
            }
        }
        public bool CheckIsExistShipment(int receiptID)
        {
            bool result = true;
            ICShipmentsController objShipmentsController = new ICShipmentsController();
            List<ICShipmentsInfo> listItems = objShipmentsController.GetShipmentReferenceByReceipt(receiptID);
            if (listItems != null && listItems.Count() > 0)
                result = false;
            return result;
        }
    }
}

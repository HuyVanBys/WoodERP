using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSERP.Modules.Invoice;
using BOSERP.Utilities;
using BOSLib;
using BOSReport;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Transactions;
using System.Windows.Forms;

namespace BOSERP.Modules.POS
{
    public class POSModule : BaseTransactionModule
    {
        #region Constants
        public const string ToolbarButtonTakePayment = "TakePayment";
        public const string ToolbarButtonEditPayment = "EditPayment";
        public const string ToolbarButtonEditAfterCompleting = "EditAfterCompleting";
        public const string DocumentEntryGridControlName = "fld_dgcACDocumentEntrys";
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        public const string ProductLookupControlName = "fld_lkeFK_ICProductAttributeID";
        public const string ProductPicturePictureBoxName = "fld_pteARInvoiceItemProductPicture";
        public const string InvoiceItemGridControlName = "fld_dgcARInvoiceItems";
        #endregion

        private bool IsEditAfterCompleting = false;
        private bool SellGiftVoucher = false;
        private decimal ReceivingAmount = 0;
        private decimal ChangeAmount = 0;
        public BOSLookupEdit SearchBranchLookupEditControl;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public List<BRBranchsInfo> BranchList;
        private BOSPictureEdit ProductPicturePictureBox;
        public ItemLookupEdit ProductLookupControl;
        public ARInoviceItemsGridControl InvoiceItemGridControl;

        public POSModule()
        {
            Name = "POS";
            CurrentModuleEntity = new POSEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            GetCurrentModuleDataViewPermission();
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[POSModule.SearchBranchLookupEditControlName];
            SearchBranchLookupEditControl.Properties.DataSource = BranchList;
            StartGettingInventoryThread();
            ProductLookupControl = (ItemLookupEdit)Controls[ProductLookupControlName];
            //ProductLookupControl.QueryPopUp += new System.ComponentModel.CancelEventHandler(ProductLookupControl_QueryPopUp);
            ProductPicturePictureBox = (BOSPictureEdit)Controls[ProductPicturePictureBoxName];
            InvoiceItemGridControl = (ARInoviceItemsGridControl)Controls[InvoiceItemGridControlName];
        }

        void ProductLookupControl_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;
            lke.Properties.DataSource = GetProductList();
        }

        public List<ICProductsInfo> GetProductList()
        {
            ICProductsController productController = new ICProductsController();
            List<ICProductsInfo> productList = productController.GetProductForModuleExceptDepartment(this.Name);

            return productList;
        }

        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        //public override string GenerateSearchQuery(string strTableName)
        //{
        //    //string query = base.GenerateSearchQuery(strTableName);
        //    //query += string.Format(" and ARInvoiceTypeCombo = '{0}' ", InvoiceType.SaleReceipt.ToString());
        //    //return query;
        //}

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            ARInvoicesController objInvoicesController = new ARInvoicesController();
            ARInvoicesInfo searchObject = (ARInvoicesInfo)CurrentModuleEntity.SearchObject;

            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(searchObject.ACObjectAccessKey);

            DataSet ds;
            if (SearchBranchLookupEditControl.EditValue.ToString() == "" || SearchBranchLookupEditControl.EditValue.ToString() == "0")
            {
                if (BranchList.Count == 0)
                {
                    ds = objInvoicesController.GetDataSetByID(-1);
                }
                else
                {
                    ds = objInvoicesController.GetInvoiceDatasetByListOfBranchID(searchObject.ARInvoiceNo,
                                                            objObjectsInfo.ACObjectID,
                                                            objObjectsInfo.ACObjectName,
                                                            searchObject.FK_BRBranchID,
                                                            searchObject.FK_HREmployeeID,
                                                            InvoiceType.SaleReceipt.ToString(),
                                                            searchObject.InvoiceDateFrom,
                                                            searchObject.InvoiceDateTo,
                                                                            BranchList);
                }
            }
            else
            {
                ds = objInvoicesController.GetInvoiceDataset(searchObject.ARInvoiceNo,
                                                            objObjectsInfo.ACObjectID,
                                                            objObjectsInfo.ACObjectName,
                                                            searchObject.FK_BRBranchID,
                                                            searchObject.FK_HREmployeeID,
                                                            InvoiceType.SaleReceipt.ToString(),
                                                            searchObject.InvoiceDateFrom,
                                                            searchObject.InvoiceDateTo);
            }

            return ds;
        }
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END

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

        public override void InvalidateToolbar()
        {
            ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)CurrentModuleEntity.MainObject;
            if (objInvoicesInfo.ARInvoiceID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions, false);
                ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions, false);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, true);
                ParentScreen.SetEnableOfToolbarButton(POSModule.ToolbarButtonEditAfterCompleting, false);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancelComplete, false);
                if (objInvoicesInfo.ARInvoiceStatus == InvoiceStatus.Complete.ToString() ||
                    objInvoicesInfo.ARInvoiceStatus == InvoiceStatus.Paid.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                    ParentScreen.SetEnableOfToolbarButton(POSModule.ToolbarButtonEditAfterCompleting, true);
                    ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions,
                        objInvoicesInfo.ARInvoicePostedStatus != PostedTransactionStatus.Posted.ToString());
                    ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions,
                        objInvoicesInfo.ARInvoicePostedStatus == PostedTransactionStatus.Posted.ToString());
                }

                ParentScreen.SetEnableOfToolbarButton(POSModule.ToolbarButtonTakePayment, false);
                if (objInvoicesInfo.ARInvoiceStatus == InvoiceStatus.Complete.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(POSModule.ToolbarButtonTakePayment, true);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancelComplete, true);
                }

                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonPrint, true);
                if (objInvoicesInfo.ARInvoiceStatus == InvoiceStatus.New.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonPrint, false);
                }

                ParentScreen.SetEnableOfToolbarButton(POSModule.ToolbarButtonEditPayment, false);
                if (objInvoicesInfo.ARInvoiceStatus == InvoiceStatus.Paid.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(POSModule.ToolbarButtonEditPayment, true);
                }
            }

            base.InvalidateToolbar();
        }

        #region Gift voucher
        /// <summary>
        /// Called when the user wants to issue a gift voucher
        /// </summary>
        public void ActionIssueGiftVoucher()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                POSEntities entity = (POSEntities)CurrentModuleEntity;
                entity.SetDefaultModuleObject(TableName.ARCreditNotesTableName);
                ARCreditNotesInfo creditNote = (ARCreditNotesInfo)entity.ModuleObjects[TableName.ARCreditNotesTableName];
                creditNote.ARCreditNoteNo = POSEntities.cstNewObjectText;
                creditNote.ARCreditNoteDate = DateTime.Now;
                ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                ADConfigValuesInfo objConfigValuesInfo = objConfigValuesController.GetObjectByConfigKey(ConfigValueKey.CreditNoteValidDays);
                if (objConfigValuesInfo != null)
                {
                    int validDays = Convert.ToInt32(objConfigValuesInfo.ADConfigKeyValue);
                    creditNote.ARCreditNoteExpiryDate = creditNote.ARCreditNoteDate.AddDays(validDays);
                }
                creditNote.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
                creditNote.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
                creditNote.ARCreditNoteType = CreditNoteType.GiftVoucher.ToString();

                guiIssueGiftVoucher guiIssueGiftVoucher = new guiIssueGiftVoucher(IssueGiftVoucherMode.Create);
                guiIssueGiftVoucher.Module = this;
                guiIssueGiftVoucher.ShowDialog();
                if (guiIssueGiftVoucher.DialogResult == DialogResult.OK)
                {
                    using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew))
                    {
                        ARCreditNotesController objCreditNotesController = new ARCreditNotesController();
                        if (creditNote.ARCreditNoteNo == POSEntities.cstNewObjectText)
                        {
                            creditNote.ARCreditNoteNo = BOSApp.GetMainObjectNo(ModuleName.CreditNote, creditNote);
                            BOSApp.UpdateObjectNumbering(ModuleName.CreditNote);
                        }
                        objCreditNotesController.CreateObject(creditNote);
                        scope.Complete();
                    }
                    MessageBox.Show(POSLocalizedResources.CreateGiftVoucherSuccessfullyMessage,
                                        CommonLocalizedResources.MessageBoxDefaultCaption,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// Called when ther user wants to sell a gift voucher
        /// </summary>
        public void ActionSellGiftVoucher()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                SellGiftVoucher = true;

                ActionNew();

                POSEntities entity = (POSEntities)CurrentModuleEntity;
                ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)entity.MainObject;
                ARCreditNotesInfo objCreditNotesInfo = (ARCreditNotesInfo)entity.ModuleObjects[TableName.ARCreditNotesTableName];
                BOSUtil.CopyObject(objInvoicesInfo, objCreditNotesInfo);
                objCreditNotesInfo.ARCreditNoteDesc = string.Empty;
                objCreditNotesInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
                ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                ADConfigValuesInfo objConfigValuesInfo = objConfigValuesController.GetObjectByConfigKey(ConfigValueKey.CreditNoteValidDays);
                if (objConfigValuesInfo != null)
                {
                    int validDays = Convert.ToInt32(objConfigValuesInfo.ADConfigKeyValue);
                    objCreditNotesInfo.ARCreditNoteExpiryDate = objCreditNotesInfo.ARCreditNoteDate.AddDays(validDays);
                }

                guiIssueGiftVoucher guiIssueGiftVoucher = new guiIssueGiftVoucher(IssueGiftVoucherMode.Create);
                guiIssueGiftVoucher.Module = this;
                guiIssueGiftVoucher.ShowDialog();
                if (guiIssueGiftVoucher.DialogResult == DialogResult.OK)
                {
                    objInvoicesInfo.FK_ARCustomerID = objCreditNotesInfo.FK_ARCustomerID;
                    objInvoicesInfo.ARInvoiceDate = objCreditNotesInfo.ARCreditNoteDate;
                    entity.UpdateMainObjectBindingSource();

                    ARInvoiceItemsInfo objInvoiceItemsInfo = new ARInvoiceItemsInfo();
                    objInvoiceItemsInfo.ARInvoiceItemProductType = CreditNoteType.GiftVoucher.ToString();
                    objInvoiceItemsInfo.ARInvoiceItemProductDesc = POSLocalizedResources.GiftVoucher;
                    objInvoiceItemsInfo.ARInvoiceItemProductUnitPrice = objCreditNotesInfo.ARCreditNoteTotalAmount;
                    objInvoiceItemsInfo.ARInvoiceItemProductQty = 1;
                    objInvoiceItemsInfo.ARInvoiceItemPrice = objInvoiceItemsInfo.ARInvoiceItemProductUnitPrice * objInvoiceItemsInfo.ARInvoiceItemProductQty;
                    objInvoiceItemsInfo.ARInvoiceItemNetAmount = objInvoiceItemsInfo.ARInvoiceItemPrice;
                    objInvoiceItemsInfo.ARInvoiceItemTotalAmount = objCreditNotesInfo.ARCreditNoteTotalAmount;
                    entity.InvoiceItemList.Add(objInvoiceItemsInfo);
                    entity.InvoiceItemList.GridControl.RefreshDataSource();
                    UpdateTotalAmount();
                }
                else
                {
                    ActionCancel();
                }

                SellGiftVoucher = false;
            }
        }

        /// <summary>
        /// Called when the user wants to view gift vouchers
        /// </summary>
        public void ActionViewGiftVoucher()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                guiGiftVoucherList guiGiftVoucherList = new guiGiftVoucherList();
                guiGiftVoucherList.Module = this;
                guiGiftVoucherList.ShowDialog();
            }
        }

        /// <summary>
        /// Update a gift voucher
        /// </summary>
        public void UpdateGiftVoucher()
        {
            POSEntities entity = (POSEntities)CurrentModuleEntity;
            ARCreditNotesController objCreditNotesController = new ARCreditNotesController();
            ARCreditNotesInfo objCreditNotesInfo = (ARCreditNotesInfo)entity.ModuleObjects[TableName.ARCreditNotesTableName];
            if (objCreditNotesInfo.ARCreditNoteID == 0)
            {
                MessageBox.Show(POSLocalizedResources.ChooseGiftVoucherMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(objCreditNotesInfo.ARCreditNoteNo))
            {
                MessageBox.Show(POSLocalizedResources.GiftVoucherNoIsRequiredMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            objCreditNotesInfo.ARCreditNoteRemainedAmount = objCreditNotesInfo.ARCreditNoteTotalAmount - objCreditNotesInfo.ARCreditNoteDueAmount;
            objCreditNotesController.UpdateObject(objCreditNotesInfo);
            MessageBox.Show(POSLocalizedResources.SaveSuccessfullyMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Search gift vouchers based on some criteria
        /// </summary>
        /// <param name="creditNoteNo">Gift voucher no</param>
        /// <param name="customerID">Customer id</param>
        /// <param name="fromDate">Date the result is filtered from</param>
        /// <param name="toDate">Date the result is filtered to</param>
        public void SearchGiftVouchers(string creditNoteNo, int customerID, DateTime fromDate, DateTime toDate)
        {
            ARCreditNotesController objCreditNotesController = new ARCreditNotesController();
            List<ARCreditNotesInfo> creditNotes = objCreditNotesController.GetCreditNoteList(
                                                                                        creditNoteNo,
                                                                                        CreditNoteType.GiftVoucher.ToString(),
                                                                                        customerID,
                                                                                        ObjectType.Customer.ToString(),
                                                                                        BOSApp.CurrentUsersInfo.FK_HREmployeeID,
                                                                                        fromDate,
                                                                                        toDate,
                                                                                        BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            POSEntities entity = (POSEntities)CurrentModuleEntity;
            entity.CreditNoteList.Invalidate(creditNotes);
        }

        /// <summary>
        /// View a gift voucher 
        /// </summary>
        /// <param name="objCreditNotesInfo">Gift voucher needs to be viewed</param>
        public void ViewGiftVoucher(ARCreditNotesInfo objCreditNotesInfo)
        {
            POSEntities entity = (POSEntities)CurrentModuleEntity;
            entity.ModuleObjects[TableName.ARCreditNotesTableName] = objCreditNotesInfo;
            entity.UpdateModuleObjectBindingSource(TableName.ARCreditNotesTableName);

            guiIssueGiftVoucher guiIssueGiftVoucher = new guiIssueGiftVoucher(IssueGiftVoucherMode.View);
            guiIssueGiftVoucher.Module = this;
            guiIssueGiftVoucher.ShowDialog();
        }
        #endregion

        /// <summary>
        /// Add item to invoice item list
        /// </summary>
        public void AddItemToInvoiceItemList(int productID)
        {
            POSEntities entity = (POSEntities)CurrentModuleEntity;
            ARInvoicesInfo mainObject = (ARInvoicesInfo)entity.MainObject;
            ARInvoiceItemsInfo objInvoiceItemsInfo = (ARInvoiceItemsInfo)entity.ModuleObjects[TableName.ARInvoiceItemsTableName];
            objInvoiceItemsInfo.FK_ICProductID = productID;
            if (objInvoiceItemsInfo.FK_ICProductID > 0)
            {
                ARCustomersController objCustomersController = new ARCustomersController();
                ARCustomersInfo objCustomersInfo = (ARCustomersInfo)objCustomersController.GetObjectByID(mainObject.FK_ARCustomerID);
                ICProductsController objProductsController = new ICProductsController();
                ICProductsInfo product = (ICProductsInfo)objProductsController.GetObjectByID(objInvoiceItemsInfo.FK_ICProductID);
                if (product != null)
                {
                    objInvoiceItemsInfo.ICProductUnitPrice = objInvoiceItemsInfo.ICProductUnitPrice <= 0 ? product.ICProductPrice01 : objInvoiceItemsInfo.ICProductUnitPrice;
                    objInvoiceItemsInfo.ARInvoiceItemProductUnitPrice = BOSApp.CalculaterProductUnitPrice(product,
                                                                                                          objInvoiceItemsInfo.ARInvoiceItemProductUnitPrice,
                                                                                                          objInvoiceItemsInfo.ARInvoiceItemProductQty,
                                                                                                          objInvoiceItemsInfo.FK_ICMeasureUnitID,
                                                                                                          objCustomersInfo != null ? objCustomersInfo.ARCustomerID : 0,
                                                                                                          mainObject.ARInvoiceDate,
                                                                                                          mainObject.FK_GECurrencyID);
                    entity.SetValuesAfterValidateProduct(objInvoiceItemsInfo.FK_ICProductID);
                    SetDefaultSaleOrderTaxPercent(objInvoiceItemsInfo);
                    entity.InvoiceItemList.AddObjectToList();
                    UpdateTotalAmount();
                }
            }
        }

        /// <summary>
        /// Change item from invoice item list
        /// </summary>
        public void ChangeItemFromInvoiceItemList(bool isRecalculation)
        {
            POSEntities entity = (POSEntities)CurrentModuleEntity;
            ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)entity.MainObject;
            ARInvoiceItemsInfo objInvoiceItemsInfo = (ARInvoiceItemsInfo)entity.InvoiceItemList[entity.InvoiceItemList.CurrentIndex];
            if (isRecalculation)
            {
                ICProductsController objProductsController = new ICProductsController();
                ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objInvoiceItemsInfo.FK_ICProductID);
                ARCustomersController objCustomersController = new ARCustomersController();
                ARCustomersInfo objCustomersInfo = (ARCustomersInfo)objCustomersController.GetObjectByID(objInvoicesInfo.FK_ARCustomerID);
                if (objProductsInfo != null)
                {
                    objInvoiceItemsInfo.ARInvoiceItemProductUnitPrice = BOSApp.CalculaterProductUnitPrice(objProductsInfo
                                                                                                        , objInvoiceItemsInfo.ARInvoiceItemProductUnitPrice
                                                                                                        , objInvoiceItemsInfo.ARInvoiceItemProductQty
                                                                                                        , objInvoiceItemsInfo.FK_ICMeasureUnitID
                                                                                                        , objCustomersInfo != null ? objCustomersInfo.ARCustomerID : 0
                                                                                                        , objInvoicesInfo.ARInvoiceDate
                                                                                                        , objInvoicesInfo.FK_GECurrencyID);
                }
            }    
            entity.SetProductPriceByProductUnitPrice(objInvoiceItemsInfo);            
            UpdateTotalAmount();
            entity.InvoiceItemList.GridControl?.RefreshDataSource();
        }

        public void UpdateInvoiceItemProductUnitPriceFromInvoiceItemList()
        {
            POSEntities entity = (POSEntities)CurrentModuleEntity;
            ARInvoicesInfo mainObject = (ARInvoicesInfo)entity.MainObject;
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            ARCustomersController objCustomersController = new ARCustomersController();
            ARCustomersInfo objCustomersInfo = (ARCustomersInfo)objCustomersController.GetObjectByID(mainObject.FK_ARCustomerID);
            foreach (ARInvoiceItemsInfo item in entity.InvoiceItemList)
            {
                objProductsInfo = BOSApp.GetProductFromCurrentProductList(item.FK_ICProductID);
                if (objProductsInfo != null)
                {
                    item.ARInvoiceItemProductUnitPrice = BOSApp.CalculaterProductUnitPrice(objProductsInfo
                                                                                        , item.ARInvoiceItemProductUnitPrice
                                                                                        , item.ARInvoiceItemProductQty
                                                                                        , item.FK_ICMeasureUnitID
                                                                                        , objCustomersInfo != null ? objCustomersInfo.ARCustomerID : 0
                                                                                        , mainObject.ARInvoiceDate
                                                                                        , mainObject.FK_GECurrencyID);
                    entity.SetProductPriceByProductUnitPrice(item);
                }
            }
            UpdateTotalAmount();
            entity.InvoiceItemList.GridControl?.RefreshDataSource();
        }

        /// <summary>
        /// Change the quantity of components of the current item
        /// when its quantity changes
        /// </summary>
        public void ChangeComponentItemQty()
        {
            POSEntities entity = (POSEntities)CurrentModuleEntity;
            if (entity.InvoiceItemList.CurrentIndex >= 0)
            {
                ARInvoiceItemsInfo objInvoiceItemsInfo = entity.InvoiceItemList[entity.InvoiceItemList.CurrentIndex];
                if (objInvoiceItemsInfo.InvoiceItemComponentList == null)
                {
                    objInvoiceItemsInfo.InvoiceItemComponentList = new BOSList<ARInvoiceItemComponentsInfo>();
                    objInvoiceItemsInfo.InvoiceItemComponentList.InitBOSList(entity, TableName.ARInvoiceItemsTableName
                                                                       , TableName.ARInvoiceItemComponentsTableName
                                                                       , BOSList<ARInvoiceItemComponentsInfo>.cstRelationForeign);
                    objInvoiceItemsInfo.InvoiceItemComponentList.ItemTableForeignKey = "FK_ARInvoiceItemID";

                }
                if (objInvoiceItemsInfo.ARInvoiceItemID == 0 && objInvoiceItemsInfo.InvoiceItemComponentList != null)
                {
                    objInvoiceItemsInfo.InvoiceItemComponentList.Clear();
                    BOSList<ARInvoiceItemComponentsInfo> defaultComponents = GetDefaultComponentList(objInvoiceItemsInfo);
                    foreach (ARInvoiceItemComponentsInfo objInvoiceItemComponentsInfo in defaultComponents)
                    {
                        objInvoiceItemComponentsInfo.ARInvoiceItemComponentQty = objInvoiceItemsInfo.ARInvoiceItemProductQty * objInvoiceItemComponentsInfo.ICProductComponentQty;
                        objInvoiceItemsInfo.InvoiceItemComponentList.Add(objInvoiceItemComponentsInfo);
                    }
                }
                else if (objInvoiceItemsInfo.ARInvoiceItemID > 0)
                {
                    ARInvoiceItemComponentsController objInvoiceItemComponentsController
                                                            = new ARInvoiceItemComponentsController();
                    List<ARInvoiceItemComponentsInfo> components = objInvoiceItemComponentsController.GetInvoiceItemComponentListByInvoiceItemID(objInvoiceItemsInfo.ARInvoiceItemID);
                    objInvoiceItemsInfo.InvoiceItemComponentList.Clear();
                    foreach (ARInvoiceItemComponentsInfo objInvoiceItemComponentsInfo in components)
                    {
                        objInvoiceItemComponentsInfo.ARInvoiceItemComponentQty = objInvoiceItemsInfo.ARInvoiceItemProductQty * objInvoiceItemComponentsInfo.ICProductComponentQty;
                        objInvoiceItemsInfo.InvoiceItemComponentList.Add(objInvoiceItemComponentsInfo);
                    }
                }

            }
        }

        /// <summary>
        /// Delete item from invoice item list
        /// </summary>
        public void DeleteItemFromInvoiceItemList()
        {
            POSEntities entity = (POSEntities)CurrentModuleEntity;
            entity.InvoiceItemList.RemoveSelectedRowObjectFromList();
            UpdateTotalAmount();
        }

        /// <summary>
        /// Change customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ChangeCustomer(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSComponent.BOSLookupEdit lke = (BOSComponent.BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                POSEntities entity = (POSEntities)CurrentModuleEntity;
                ((ARInvoicesInfo)entity.MainObject).FK_ARCustomerID = Convert.ToInt32(e.Value);
                if (!Toolbar.IsNullOrNoneAction())
                {
                    SetDefaultValuesFromCustomer();
                }
            }
            UpdateDocumentEntries();
        }

        /// <summary>
        /// Change price level
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ChangePriceLevel(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSComponent.BOSLookupEdit lke = (BOSComponent.BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                POSEntities entity = (POSEntities)CurrentModuleEntity;
                ((ARInvoicesInfo)entity.MainObject).FK_ARPriceLevelID = Convert.ToInt32(e.Value);
                if (!Toolbar.IsNullOrNoneAction())
                {
                    if (entity.InvoiceItemList.Count > 0)
                    {
                        if (MessageBox.Show(POSLocalizedResources.UpdatePriceLevelMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            foreach (ARInvoiceItemsInfo entItem in entity.InvoiceItemList)
                            {
                                entity.SetProductPrice(entItem, TableName.ARInvoiceItemsTableName);
                            }
                            entity.InvoiceItemList.GridControl.RefreshDataSource();
                            UpdateTotalAmount();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Change discount percent
        /// </summary>
        public void ChangeDiscountPercent()
        {
            UpdateTotalAmount();
        }

        /// <summary>
        /// Change discount amount
        /// </summary>
        public void ChangeDiscountAmount()
        {
            POSEntities entity = (POSEntities)CurrentModuleEntity;
            ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)entity.MainObject;
            if (objInvoicesInfo.ARInvoiceSubTotalAmount > 0)
                objInvoicesInfo.ARInvoiceDiscountPerCent = objInvoicesInfo.ARInvoiceDiscountFix / objInvoicesInfo.ARInvoiceSubTotalAmount * 100;
            UpdateTotalAmount();
        }
        /// <summary>
        /// Change discount amount
        /// </summary>
        public void ChangeShippingFeeAmount()
        {
            POSEntities entity = (POSEntities)CurrentModuleEntity;
            ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)entity.MainObject;
            UpdateTotalAmount();
        }

        /// <summary>
        /// Called when user wants to change tax percent
        /// </summary>
        public void ChangeTaxPercent()
        {
            UpdateTotalAmount();
        }

        /// <summary>
        /// Called when user wants to change tax amount 
        /// </summary>
        public void ChangeTaxAmount()
        {
            POSEntities entity = (POSEntities)CurrentModuleEntity;
            ARInvoicesInfo objInvoiceInfo = (ARInvoicesInfo)entity.MainObject;
            if (objInvoiceInfo.ARInvoiceSubTotalAmount - objInvoiceInfo.ARInvoiceDiscountFix > 0)
            {
                objInvoiceInfo.ARInvoiceTaxPercent = objInvoiceInfo.ARInvoiceTaxAmount / (objInvoiceInfo.ARInvoiceSubTotalAmount - objInvoiceInfo.ARInvoiceDiscountFix) * 100;
            }
            UpdateTotalAmount();
        }

        /// <summary>
        /// Update the total amounts of the sale receipt
        /// </summary>
        public void UpdateTotalAmount()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                POSEntities entity = (POSEntities)CurrentModuleEntity;
                entity.UpdateTotalAmount();
                UpdateDocumentEntries();
            }
        }

        /// <summary>
        /// Print POS report
        /// </summary>
        public void PrintPOSReport()
        {
            //if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            //{
            //    String[] copies = { POSLocalizedResources.Contact1, POSLocalizedResources.Contact2 };
            //    ADReportsController objReportsController = new ADReportsController();
            //    PrintDialog printDialog = new PrintDialog();
            //    ADReportsInfo objReportsInfo = (ADReportsInfo)objReportsController.GetObjectByNo(typeof(RPPOS).Name);
            //    short numCopies = 1;
            //    if (objReportsInfo != null)
            //    {
            //        numCopies = objReportsInfo.ADReportCopies;
            //    }
            //    printDialog.PrinterSettings.Copies = numCopies;
            //    DialogResult result = printDialog.ShowDialog();
            //    if (result == DialogResult.OK)
            //    {
            //        for (int i = 0; i < printDialog.PrinterSettings.Copies; i++)
            //        {
            //            string copy = copies[i % copies.Length];
            //            RPPOS report = new RPPOS();
            //            //report.LoadLayout(BOSCommon.Constants.Report.DevPOSItemReportPath);
            //            InitPOSReport(report);
            //            XRLabel contact = (XRLabel)report.Bands[BandKind.PageHeader].Controls["xr_lblContact"];
            //            if (contact != null)
            //                contact.Text = copies[i];
            //            XtraReportHelper.PrintToPrinter(report, printDialog.PrinterSettings.PrinterName);
            //        }
            //    }
            //}
        }

        /// <summary>
        /// Called when user changes the invoice after completing it
        /// </summary>
        public void ActionEditAfterCompleting()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                IsEditAfterCompleting = true;

                base.ActionEdit();

                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonSave, true);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
            }
        }

        public override int ActionSave()
        {
            POSEntities entity = (POSEntities)CurrentModuleEntity;
            ARInvoicesInfo invoice = (ARInvoicesInfo)entity.MainObject;

            if (invoice.FK_ACObjectID == 0)
            {
                MessageBox.Show("Vui lòng chọn Đối tượng"
                                , "Thông báo"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Information);
                return 0;
            }

            SetDefaultDesc();
            entity.InvoiceItemList.EndCurrentEdit();
            UpdateTotalAmount();

            int invoiceID = base.ActionSave();
            if (invoiceID > 0)
            {
                if (IsEditAfterCompleting)
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, true);
                    IsEditAfterCompleting = false;
                }
                entity.InvalidateItemComponents();
            }
            return invoiceID;
        }

        /// <summary>
        /// Set the default desc for the invoice
        /// </summary>
        private void SetDefaultDesc()
        {
            ARInvoicesInfo invoice = (ARInvoicesInfo)CurrentModuleEntity.MainObject;
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByIDAndType(invoice.FK_ACObjectID, invoice.ARObjectType);
            if (objObjectsInfo != null)
            {
                invoice.ARInvoiceDesc = invoice.ARInvoiceDesc.Replace("{0}", objObjectsInfo.ACObjectName);
            }
        }

        public override bool ActionComplete()
        {
            //Check all items must have serie no
            POSEntities entity = (POSEntities)CurrentModuleEntity;
            ARInvoicesInfo invoice = (ARInvoicesInfo)entity.MainObject;
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = new ICProductsInfo();

            foreach (ARInvoiceItemsInfo item in entity.ComponentInvoiceItemList)
            {
                objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                if (objProductsInfo.ICProductType != ProductType.Service.ToString()
                    && !objProductsInfo.IsAsset
                    && (objProductsInfo.ICPriceCalculationMethodMethod != PriceCalculationMethod.Average.ToString()
                        || (objProductsInfo.ICPriceCalculationMethodMethod == PriceCalculationMethod.Average.ToString() && item.ARInvoiceItemIsSpecificCalculation)))
                {
                    if (item.FK_ICProductSerieID == 0)
                    {
                        MessageBox.Show(string.Format(POSLocalizedResources.ItemSerialNoIsRequiredMessage, item.ARInvoiceItemProductDesc), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }

            if (entity.ComponentInvoiceItemList.IsInvalidInventory(TransactionUtil.cstInventoryShipment))
                return false;

            bool isCompleted = base.ActionComplete();
            if (isCompleted)
            {
                //Back up component invoice item list
                entity.ComponentInvoiceItemList.BackupList.Clear();
                foreach (ARInvoiceItemsInfo item in entity.ComponentInvoiceItemList)
                {
                    entity.ComponentInvoiceItemList.BackupList.Add((ARInvoiceItemsInfo)item.Clone());
                }

            }
            return isCompleted;
        }
        #region Print
        /// <summary>
        /// Preview POS report before print
        /// </summary>
        public void PreviewPOSReport()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                RPPOS report = new RPPOS();
                InitPOSReport(report);
                //report.LoadLayout(BOSCommon.Constants.Report.DevPOSItemReportPath);              
                guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevPOSItemReportPath, false);
                reviewer.Show();
            }
        }
        private void InitPOSReport(XtraReport report)
        {
            CSCompanysController objCompanysController = new CSCompanysController();
            CSCompanysInfo objCompanyInfo = (CSCompanysInfo)objCompanysController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);

            if (objCompanyInfo != null)
            {
                XRLabel label = (XRLabel)report.Bands[BandKind.PageHeader].Controls["xrThue"];
                if (label != null)
                {
                    label.Text += objCompanyInfo.CSCompanyTaxNumber;
                }

                label = (XRLabel)report.Bands[BandKind.PageHeader].Controls["xrDiachihoadon"];
                if (label != null)
                {
                    label.Text += objCompanyInfo.CSCompanyAddressLine1;
                }

                label = (XRLabel)report.Bands[BandKind.PageHeader].Controls["xrDiachinhamay"];
                if (label != null)
                {
                    label.Text += objCompanyInfo.CSCompanyAddressLine2;
                }

                label = (XRLabel)report.Bands[BandKind.PageHeader].Controls["xrWebsite"];
                if (label != null)
                {
                    label.Text += objCompanyInfo.CSCompanyWebsite;
                }

                label = (XRLabel)report.Bands[BandKind.PageHeader].Controls["xrEmail"];
                if (label != null)
                {
                    label.Text += objCompanyInfo.CSCompanyEmail;
                }

                label = (XRLabel)report.Bands[BandKind.PageHeader].Controls["xrCellphone"];
                if (label != null)
                {
                    label.Text += objCompanyInfo.CSCompanyCellPhone;
                }

                label = (XRLabel)report.Bands[BandKind.PageHeader].Controls["xrCompanyphone"];
                if (label != null)
                {
                    label.Text += objCompanyInfo.CSCompanyPhone;
                }
            }

            ADReportsController objReportsController = new ADReportsController();
            ARInvoicesController objInvoicesController = new ARInvoicesController();
            DataSet ds = objReportsController.GetInvoiceItemByInvoiceID(Toolbar.CurrentObjectID);
            if (ds.Tables.Count > 0)
            {
                ARInvoiceItemsController objInvoiceItemsController = new ARInvoiceItemsController();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ARInvoiceItemsInfo objInvoiceItemsInfo = (ARInvoiceItemsInfo)objInvoiceItemsController.GetObjectFromDataRow(row);
                    objInvoiceItemsInfo.ARInvoiceItemComment = string.Empty;
                    if (objInvoiceItemsInfo.ARInvoiceItemProductDiscount > 0)
                    {
                        objInvoiceItemsInfo.ARInvoiceItemComment += string.Format(" {0}: {1}%;", InvoiceLocalizedResources.Discount, objInvoiceItemsInfo.ARInvoiceItemProductDiscount);
                    }
                    if (objInvoiceItemsInfo.ARInvoiceItemProductTaxPercent > 0)
                    {
                        objInvoiceItemsInfo.ARInvoiceItemComment += string.Format(" {0}: {1}%;", InvoiceLocalizedResources.VAT, objInvoiceItemsInfo.ARInvoiceItemProductTaxPercent);
                    }
                    row["ARInvoiceItemComment"] = objInvoiceItemsInfo.ARInvoiceItemComment;

                    if (!string.IsNullOrEmpty(objInvoiceItemsInfo.ICStockName))
                    {
                        string stockName = string.Empty;
                        int firstSpaceIndex = objInvoiceItemsInfo.ICStockName.Trim().IndexOf(" ");
                        if (firstSpaceIndex >= 0)
                        {
                            stockName = objInvoiceItemsInfo.ICStockName.Substring(firstSpaceIndex + 1);
                        }
                        else
                        {
                            stockName = objInvoiceItemsInfo.ICStockName;
                        }
                        row["ICStockName"] = stockName;
                    }

                    objInvoiceItemsInfo.ARInvoiceItemProductDesc += string.Format(" {0} / {1}", objInvoiceItemsInfo.ARInvoiceItemProductSerialNo, objInvoiceItemsInfo.ARInvoiceItemProductSupplierNo);
                    row["ARInvoiceItemProductDesc"] = objInvoiceItemsInfo.ARInvoiceItemProductDesc;
                }
            }
            report.DataSource = ds;
            report.DataMember = BOSCommon.Constants.Report.DevInvoiceItemReportName;
            ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)objInvoicesController.GetObjectByID(Toolbar.CurrentObjectID);
            if (objInvoicesInfo.ARInvoiceTotalAmount != 0)
            {
                XRLabel amountWord = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xr_lblAmountWord"];
                if (amountWord != null)
                    amountWord.Text = ConvertAmountToWord.ReadAmount(objInvoicesInfo.ARInvoiceTotalAmount.ToString(), objInvoicesInfo.FK_GECurrencyID);
            }

            if (objInvoicesInfo.ARInvoiceDiscountFix == 0)
            {
                XRPanel discountPanel = (XRPanel)report.Bands[BandKind.ReportFooter].Controls["xr_pnlDiscount"];
                if (discountPanel != null)
                {
                    discountPanel.Visible = false;
                }
            }
            if (objInvoicesInfo.ARInvoiceShippingFees == 0)
            {
                XRPanel discountPanel = (XRPanel)report.Bands[BandKind.ReportFooter].Controls["xr_pnlShippingFee"];
                if (discountPanel != null)
                {
                    discountPanel.Visible = false;
                }
            }
            if (objInvoicesInfo.ARInvoiceTaxAmount == 0)
            {
                XRPanel taxPanel = (XRPanel)report.Bands[BandKind.ReportFooter].Controls["xr_pnlVAT"];
                if (taxPanel != null)
                {
                    taxPanel.Visible = false;
                }
            }
        }

        public void PrintOutStock()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                POSEntities entity = (POSEntities)CurrentModuleEntity;
                ARInvoicesInfo objInvoiceInfo = (ARInvoicesInfo)entity.MainObject;
                RPPOSOutStock report = new RPPOSOutStock();

                HREmployeesController objEmployeesController = new HREmployeesController();
                HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objInvoiceInfo.FK_HREmployeeID);
                if (objEmployeesInfo != null)
                    objInvoiceInfo.HREmployeeName = objEmployeesInfo.HREmployeeName;

                ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
                ICProductsController objProductsController = new ICProductsController();
                List<ICMeasureUnitsInfo> measureUnitsList = objMeasureUnitsController.GetAllAliveMeasureUnit();
                foreach (ARInvoiceItemsInfo item in entity.InvoiceItemList)
                {
                    ICMeasureUnitsInfo objMeasureUnitsInfo = measureUnitsList.Where(x => x.ICMeasureUnitID == item.FK_ICMeasureUnitID).FirstOrDefault();
                    if (objMeasureUnitsInfo != null)
                    {
                        item.ICMeasureUnitName = objMeasureUnitsInfo.ICMeasureUnitName;
                    }
                    ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                    if (objProductsInfo != null)
                    {
                        item.ARInvoiceItemProductPicture = objProductsInfo.ICProductPicture;
                    }
                }
                InitPrintOutStock(report);
                report.bindingSource1.DataSource = entity.InvoiceItemList;
                report.bindingSource3.DataSource = objInvoiceInfo;
                ACObjectsController objObjectsController = new ACObjectsController();
                ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByIDAndType(objInvoiceInfo.FK_ACObjectID, objInvoiceInfo.ARObjectType);
                if (objObjectsInfo != null)
                {
                    report.bsACObjects.DataSource = objObjectsInfo;
                }

                guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevPOSItemReportPath, false);
                reviewer.Show();
            }
        }

        private void InitPrintOutStock(XtraReport report)
        {
            POSEntities entity = (POSEntities)CurrentModuleEntity;
            ARInvoicesInfo objInvoiceInfo = (ARInvoicesInfo)entity.MainObject;
            CSCompanysController objCompanysController = new CSCompanysController();
            CSCompanysInfo objCompanyInfo = (CSCompanysInfo)objCompanysController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            if (objCompanyInfo != null)
            {
                XRLabel label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrThue"];
                if (label != null)
                {
                    label.Text += objCompanyInfo.CSCompanyTaxNumber;
                }
                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrCompanyDesc"];
                if (label != null)
                {
                    label.Text = objCompanyInfo.CSCompanyDesc;
                }

                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrDiachihoadon"];
                if (label != null)
                {
                    label.Text += objCompanyInfo.CSCompanyAddressLine1;
                }

                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrDiachinhnhamay"];
                if (label != null)
                {
                    label.Text += objCompanyInfo.CSCompanyAddressLine2;
                }

                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrWebsite"];
                if (label != null)
                {
                    label.Text += objCompanyInfo.CSCompanyWebsite;
                }

                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrEmail"];
                if (label != null)
                {
                    label.Text += objCompanyInfo.CSCompanyEmail;
                }

                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrCellphone"];
                if (label != null)
                {
                    label.Text = objCompanyInfo.CSCompanyPhone;
                }

                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrCSCompanyFax"];
                if (label != null)
                {
                    label.Text += objCompanyInfo.CSCompanyFax;
                }
                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrNgayThangNam"];
                if (label != null)
                {
                    label.Text += "Ngày " + objInvoiceInfo.ARInvoiceDate.ToString("dd") + " tháng " + objInvoiceInfo.ARInvoiceDate.ToString("MM") + " năm " + objInvoiceInfo.ARInvoiceDate.ToString("yyyy");
                }
            }
        }
        #endregion

        /// <summary>
        /// Called when user wants to take payment
        /// </summary>
        public void TakePayment()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                ARInvoicesController objInvoicesController = new ARInvoicesController();
                ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)CurrentModuleEntity.MainObject;
                decimal paymentAmount = objInvoicesInfo.ARInvoiceTotalAmount;
                if ((objInvoicesInfo.ARInvoiceStatus == InvoiceStatus.Complete.ToString()|| objInvoicesInfo.ARInvoiceStatus == InvoiceStatus.Paid.ToString())  && !ActionUnPosted()) return;
                guiPOSPaymentDetails guiPaymentDetails = new guiPOSPaymentDetails(this, objInvoicesInfo.FK_ARCustomerID, paymentAmount);
                if (guiPaymentDetails.ShowDialog() == DialogResult.OK)
                {
                    CurrentModuleEntity.SetPropertyChangeEventLock(false);
                    POSEntities entity = (POSEntities)CurrentModuleEntity;
                    entity.POSPaymentDetailList = guiPaymentDetails.PaymentDetailList;
                    entity.TakePaymentDetail(paymentAmount);

                    //Update BalanceDue of MainObject
                    objInvoicesInfo.ARInvoiceDepositBalance = entity.POSPaymentDetailList.Sum(p => p.ARPOSPaymentDetailAmount);
                    objInvoicesInfo.ARInvoiceBalanceDue = objInvoicesInfo.ARInvoiceTotalAmount - entity.POSPaymentDetailList.Sum(p => p.ARPOSPaymentDetailAmount);
                    objInvoicesInfo.ARInvoiceReceivingAmount = guiPaymentDetails.ReceivingAmount;
                    objInvoicesInfo.ARInvoiceChangeAmount = guiPaymentDetails.ChangeAmount;
                    objInvoicesController.UpdateObject(objInvoicesInfo);

                    if (guiPaymentDetails.IsPrinted)
                    {
                        string rptFile = System.IO.Path.Combine("Reports", "RP_InvPOS" + ".repx");
                        BaseReport report = new BaseReport();
                        guiReportPreview reviewer;
                        bool bExists = System.IO.File.Exists(rptFile);
                        if (!bExists)
                        {
                            if (MessageBox.Show("Tệp mẫu báo cáo không tồn tại! Bạn có muốn thiết kế ?"
                                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                                , MessageBoxButtons.YesNo) == DialogResult.No)
                            {
                                return;
                            }
                            else
                            {
                                reviewer = new guiReportPreview(report, rptFile, true);
                                reviewer.Show();
                                return;
                            }
                        }
                        report.LoadLayout(rptFile);
                        //XRLabel label = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["label12"];
                        //if (label != null)
                        //    label.Text = guiPaymentDetails.ReceivingAmount.ToString("#,###");
                        //label = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["label14"];
                        //if (label != null)
                        //    label.Text = guiPaymentDetails.ChangeAmount.ToString("#,###");
                        DataSet dataSource = SqlDatabaseHelper.RunStoredProcedure("RP_PrintInvPOS", this.Name, objInvoicesInfo.ARInvoiceID);
                        report.DataSource = dataSource;
                        reviewer = new guiReportPreview(report, rptFile, true);
                        reviewer.Show();
                    }

                    entity.UpdateMainObjectBindingSource();
                    ParentScreen.SetEnableOfToolbarButton(POSModule.ToolbarButtonTakePayment, false);
                    CurrentModuleEntity.SetPropertyChangeEventLock(true);
                    InvalidateToolbar();
                }
                ActionPosted();
            }
        }

        /// <summary>
        /// Called when user wants to change the payment
        /// </summary>
        public void ChangePayment()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)CurrentModuleEntity.MainObject;
                ARInvoicesController objInvoicesController = new ARInvoicesController();

                decimal paymentAmount = objInvoicesInfo.ARInvoiceTotalAmount;
                if ((objInvoicesInfo.ARInvoiceStatus == InvoiceStatus.Complete.ToString() || objInvoicesInfo.ARInvoiceStatus == InvoiceStatus.Paid.ToString()) && !ActionUnPosted()) return;
                guiPOSPaymentDetails guiPaymentDetails = new guiPOSPaymentDetails(this, objInvoicesInfo.ARInvoiceID, objInvoicesInfo.FK_ARCustomerID, paymentAmount, objInvoicesInfo.ARInvoiceReceivingAmount);
                if (guiPaymentDetails.ShowDialog() == DialogResult.OK)
                {
                    CurrentModuleEntity.SetPropertyChangeEventLock(false);
                    POSEntities entity = (POSEntities)CurrentModuleEntity;
                    entity.POSPaymentDetailList = guiPaymentDetails.PaymentDetailList;
                    entity.POSPaymentDetailList.SaveItemObjects();
                    //Update BalanceDue of MainObject
                    objInvoicesInfo.ARInvoiceDepositBalance = entity.POSPaymentDetailList.Sum(p => p.ARPOSPaymentDetailAmount);
                    objInvoicesInfo.ARInvoiceBalanceDue = objInvoicesInfo.ARInvoiceTotalAmount - entity.POSPaymentDetailList.Sum(p => p.ARPOSPaymentDetailAmount);
                    objInvoicesInfo.ARInvoiceReceivingAmount = guiPaymentDetails.ReceivingAmount;
                    objInvoicesInfo.ARInvoiceChangeAmount = guiPaymentDetails.ChangeAmount;
                    objInvoicesController.UpdateObject(objInvoicesInfo);

                    if (guiPaymentDetails.IsPrinted)
                    {
                        string rptFile = System.IO.Path.Combine("Reports", "RP_InvPOS" + ".repx");
                        BaseReport report = new BaseReport();
                        guiReportPreview reviewer;
                        bool bExists = System.IO.File.Exists(rptFile);
                        if (!bExists)
                        {
                            if (MessageBox.Show("Tệp mẫu báo cáo không tồn tại! Bạn có muốn thiết kế ?"
                                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                                , MessageBoxButtons.YesNo) == DialogResult.No)
                            {
                                return;
                            }
                            else
                            {
                                reviewer = new guiReportPreview(report, rptFile, true);
                                reviewer.Show();
                                return;
                            }
                        }
                        report.LoadLayout(rptFile);
                        //XRLabel label = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["label12"];
                        //if (label != null)
                        //    label.Text = guiPaymentDetails.ReceivingAmount.ToString("#,###");
                        //label = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["label14"];
                        //if (label != null)
                        //    label.Text = guiPaymentDetails.ChangeAmount.ToString("#,###");
                        DataSet dataSource = SqlDatabaseHelper.RunStoredProcedure("RP_PrintInvPOS", this.Name, objInvoicesInfo.ARInvoiceID);
                        report.DataSource = dataSource;
                        reviewer = new guiReportPreview(report, rptFile, true);
                        reviewer.Show();
                    }

                    CurrentModuleEntity.SetPropertyChangeEventLock(true);
                    ActionPosted();
                }
            }
        }

        /// </summary>
        /// Show invoice item component form
        /// </summary>
        public void ShowItemComponent()
        {
            if (IsEditable())
            {
                ActionEdit();
            }

            POSEntities entity = (POSEntities)CurrentModuleEntity;
            if (entity.InvoiceItemList.CurrentIndex >= 0)
            {
                ARInvoiceItemsInfo objInvoiceItemsInfo = entity.InvoiceItemList[entity.InvoiceItemList.CurrentIndex];
                if (objInvoiceItemsInfo.InvoiceItemComponentList == null)
                {
                    objInvoiceItemsInfo.InvoiceItemComponentList = new BOSList<ARInvoiceItemComponentsInfo>();
                    objInvoiceItemsInfo.InvoiceItemComponentList.InitBOSList(entity, TableName.ARInvoiceItemsTableName
                                                                       , TableName.ARInvoiceItemComponentsTableName
                                                                       , BOSList<ARInvoiceItemComponentsInfo>.cstRelationForeign);
                    objInvoiceItemsInfo.InvoiceItemComponentList.ItemTableForeignKey = "FK_ARInvoiceItemID";
                    if (objInvoiceItemsInfo.ARInvoiceItemID > 0)
                    {
                        ARInvoiceItemComponentsController objInvoiceItemComponentsController
                                                                = new ARInvoiceItemComponentsController();
                        List<ARInvoiceItemComponentsInfo> components = objInvoiceItemComponentsController.GetInvoiceItemComponentListByInvoiceItemID(objInvoiceItemsInfo.ARInvoiceItemID);
                        objInvoiceItemsInfo.InvoiceItemComponentList.Invalidate(components);
                    }
                }
                if (objInvoiceItemsInfo.InvoiceItemComponentList.Count == 0)
                {
                    BOSList<ARInvoiceItemComponentsInfo> defaultComponentsList = GetDefaultComponentList(objInvoiceItemsInfo);
                    if (defaultComponentsList.Count == 0)
                    {
                        MessageBox.Show(POSLocalizedResources.ComponentIsNull, CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    objInvoiceItemsInfo.InvoiceItemComponentList = defaultComponentsList;
                }

                guiItemComponent<ARInvoiceItemComponentsInfo> guiItemComponent = new guiItemComponent<ARInvoiceItemComponentsInfo>(objInvoiceItemsInfo.InvoiceItemComponentList);
                guiItemComponent.Module = this;
                if (guiItemComponent.ShowDialog() == DialogResult.OK)
                {
                    objInvoiceItemsInfo.InvoiceItemComponentList.Clear();
                    if (guiItemComponent.ItemComponentList.Count > 0)
                    {
                        foreach (ICProductComponentsInfo objProductComponentsInfo in guiItemComponent.ItemComponentList)
                        {
                            ARInvoiceItemComponentsInfo objInvoiceItemComponentsInfo = new ARInvoiceItemComponentsInfo();
                            objInvoiceItemComponentsInfo.ARInvoiceItemComponentID = objProductComponentsInfo.ItemComponentID;
                            objInvoiceItemComponentsInfo.FK_ICProductID = objProductComponentsInfo.FK_ICProductComponentChildID;
                            objInvoiceItemComponentsInfo.ICProductSupplierNo = objProductComponentsInfo.ICProductSupplierNo;
                            objInvoiceItemComponentsInfo.ICProductDesc = objProductComponentsInfo.ICProductDesc;
                            objInvoiceItemComponentsInfo.FK_ICStockID = objProductComponentsInfo.FK_ICStockID;
                            objInvoiceItemComponentsInfo.FK_ICProductSerieID = objProductComponentsInfo.FK_ICProductSerieID;
                            objInvoiceItemComponentsInfo.ARInvoiceItemComponentQty = objProductComponentsInfo.ICProductComponentQty;
                            objInvoiceItemsInfo.InvoiceItemComponentList.Add(objInvoiceItemComponentsInfo);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Get default product component list of an item
        /// </summary>
        /// <param name="objInvoiceItemsInfo">Invoice item</param>
        /// <returns>List of default product component</returns>
        public BOSList<ARInvoiceItemComponentsInfo> GetDefaultComponentList(ARInvoiceItemsInfo objInvoiceItemsInfo)
        {
            POSEntities entity = (POSEntities)CurrentModuleEntity;
            BOSList<ARInvoiceItemComponentsInfo> itemComponentsList = new BOSList<ARInvoiceItemComponentsInfo>();
            itemComponentsList.InitBOSList(
                                        entity,
                                        TableName.ARInvoiceItemsTableName,
                                        TableName.ARInvoiceItemComponentsTableName,
                                        BOSList<ARInvoiceItemComponentsInfo>.cstRelationForeign);
            itemComponentsList.ItemTableForeignKey = "FK_ARInvoiceItemID";
            ICProductComponentsController objProductComponentsController = new ICProductComponentsController();
            List<ICProductComponentsInfo> components = objProductComponentsController.GetProductComponentListByProductID(objInvoiceItemsInfo.FK_ICProductID);
            foreach (ICProductComponentsInfo objProductComponentsInfo in components)
            {
                ARInvoiceItemComponentsInfo objInvoiceItemComponentsInfo = new ARInvoiceItemComponentsInfo();
                objInvoiceItemComponentsInfo.FK_ICProductID = objProductComponentsInfo.FK_ICProductComponentChildID;
                objInvoiceItemComponentsInfo.ARInvoiceItemComponentQty = objProductComponentsInfo.ICProductComponentQty * objInvoiceItemsInfo.ARInvoiceItemProductQty;
                objInvoiceItemComponentsInfo.ICProductComponentQty = objProductComponentsInfo.ICProductComponentQty;
                objInvoiceItemComponentsInfo.ICProductDesc = objProductComponentsInfo.ICProductDesc;
                objInvoiceItemComponentsInfo.ICProductSupplierNo = objProductComponentsInfo.ICProductSupplierNo;
                objInvoiceItemComponentsInfo.FK_ICStockID = objInvoiceItemsInfo.FK_ICStockID;
                objInvoiceItemComponentsInfo.FK_ICProductSerieID = objInvoiceItemsInfo.FK_ICProductSerieID;
                itemComponentsList.Add(objInvoiceItemComponentsInfo);
            }
            return itemComponentsList;
        }

        #region Accounting
        private ACDocTypeEntrysInfo NewDocumentEntryFromDocumentInfoForInvoices(string documentTypes)
        {

            ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
            ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();
            ACDocTypeEntrysInfo objDocTypeEntrysInfo = new ACDocTypeEntrysInfo();
            List<ACDocTypeEntrysInfo> entries = objDocTypeEntrysController.GetEntriesByDocumentType(documentTypes);
            objDocTypeEntrysInfo = entries.Where(x => x.ACEntryTypeName == AccEntryType.DoanhThuBanHang.ToString()).FirstOrDefault();
            return objDocTypeEntrysInfo;

        }

        private ACDocTypeEntrysInfo NewDocumentCKEntryFromDocumentInfoForInvoices(string documentTypes)
        {

            ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
            ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();
            ACDocTypeEntrysInfo objDocTypeEntrysInfo = new ACDocTypeEntrysInfo();
            List<ACDocTypeEntrysInfo> entries = objDocTypeEntrysController.GetEntriesByDocumentType(documentTypes);
            objDocTypeEntrysInfo = entries.Where(x => x.ACEntryTypeName == AccEntryType.ChietKhauThuongMai.ToString()).FirstOrDefault();
            return objDocTypeEntrysInfo;

        }

        protected override void UpdateDocumentEntries()
        {
            POSEntities entity = (POSEntities)CurrentModuleEntity;
            ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)entity.MainObject;
            ACDocTypeEntrysInfo defaultDocTypeEntrysCK = new ACDocTypeEntrysInfo();
            ACDocTypeEntrysInfo defaultDocTypeEntrysDTBH = new ACDocTypeEntrysInfo();
            List<int> productAccountID = new List<int>();
            AccountDebitandCredit objAccountDebitandCredit = new AccountDebitandCredit();
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            //if (objInvoicesInfo.ARInvoiceProductType == ProductType.Product.ToString())

            ACAccountsController objAccountsController = new ACAccountsController();
            defaultDocTypeEntrysDTBH = NewDocumentEntryFromDocumentInfoForInvoices(AccDocumentType.BanLe.ToString());
            int accountCreditIDDTBH = objAccountsController.GetObjectIDByNo(defaultDocTypeEntrysDTBH.DefaultCreditAccountNo);
            int accountDebitIDDTBH = objAccountsController.GetObjectIDByNo(defaultDocTypeEntrysDTBH.DefaultDebitAccountNo);

            defaultDocTypeEntrysCK = NewDocumentCKEntryFromDocumentInfoForInvoices(AccDocumentType.BanLe.ToString());
            int accountCreditCKTM = objAccountsController.GetObjectIDByNo(defaultDocTypeEntrysCK.DefaultCreditAccountNo);
            int accountDebitCKTM = objAccountsController.GetObjectIDByNo(defaultDocTypeEntrysCK.DefaultDebitAccountNo);

            List<ACDocumentEntrysInfo> removedDTBHDocuments = entity.DocumentEntryList.Where(item => item.ACEntryTypeName == AccEntryType.DoanhThuBanHang.ToString()).ToList();
            if (removedDTBHDocuments != null)
            {
                foreach (ACDocumentEntrysInfo item in removedDTBHDocuments)
                    entity.DocumentEntryList.Remove(item);
            }
            List<ACDocumentEntrysInfo> removedCKTMDocuments = entity.DocumentEntryList.Where(item => item.ACEntryTypeName == AccEntryType.ChietKhauThuongMai.ToString()).ToList();
            if (removedCKTMDocuments != null)
            {
                foreach (ACDocumentEntrysInfo item in removedCKTMDocuments)
                    entity.DocumentEntryList.Remove(item);
            }

            List<ICProductsInfo> listInvoiceItems = new List<ICProductsInfo>();
            {
                Dictionary<ACDocumentEntrysInfo, List<ARInvoiceItemsInfo>> documentEntryAccounts = new Dictionary<ACDocumentEntrysInfo, List<ARInvoiceItemsInfo>>();
                int objectID = 0;
                ACObjectsController objObjectsController = new ACObjectsController();
                ACObjectsInfo objObjectsInfo = (ACObjectsInfo)objObjectsController.GetObjectByIDAndType(objInvoicesInfo.FK_ACObjectID, objInvoicesInfo.ARObjectType);

                foreach (ARInvoiceItemsInfo InvoiceItemsInfo in entity.InvoiceItemList)
                {
                    listInvoiceItems.Add((ICProductsInfo)objProductsController.GetObjectByID(InvoiceItemsInfo.FK_ICProductID));
                }


                //Doanh thu bán hàng
                foreach (ARInvoiceItemsInfo InvoiceItemsInfo in entity.InvoiceItemList)
                {
                    foreach (ICProductsInfo item in listInvoiceItems)
                    {
                        if (item.ICProductID == InvoiceItemsInfo.FK_ICProductID)
                            objProductsInfo = item;
                    }

                    if (objProductsInfo != null)
                    {
                        if (objProductsInfo.FK_ACAccountRevenueID != 0)
                        {
                            objAccountDebitandCredit.AccountCredit = objProductsInfo.FK_ACAccountRevenueID;
                            objAccountDebitandCredit.AccountDebit = accountDebitIDDTBH;
                        }
                        else
                        {
                            objAccountDebitandCredit.AccountCredit = accountCreditIDDTBH;
                            objAccountDebitandCredit.AccountDebit = accountDebitIDDTBH;
                            objProductsInfo.FK_ACAccountRevenueID = accountCreditIDDTBH;
                        }

                        ACDocumentEntrysInfo entry = entity.DocumentEntryList.FirstOrDefault(e => e.ACEntryTypeName == AccEntryType.DoanhThuBanHang.ToString()
                                                                            && e.FK_ACCreditAccountID == objProductsInfo.FK_ACAccountRevenueID);
                        if (objObjectsInfo != null)
                        {
                            objectID = objObjectsInfo.FK_ACAccountSaleID; // CN bán
                            if (objectID != 0)
                                objAccountDebitandCredit.AccountDebit = objObjectsInfo.FK_ACAccountSaleID;
                            else
                                objAccountDebitandCredit.AccountDebit = accountDebitIDDTBH;
                        }
                        if (entry == null)
                        {
                            entry = AccountHelper.AddItemToDocumentEntryList(defaultDocTypeEntrysDTBH, entity.DocumentEntryList);
                            entry.FK_ACCreditAccountID = objAccountDebitandCredit.AccountCredit;
                            entry.FK_ACDebitAccountID = objAccountDebitandCredit.AccountDebit;
                        }
                        if (entry != null && !documentEntryAccounts.ContainsKey(entry))
                        {
                            documentEntryAccounts.Add(entry, new List<ARInvoiceItemsInfo>());
                            entry.FK_ACCreditAccountID = objAccountDebitandCredit.AccountCredit;
                            entry.FK_ACDebitAccountID = objAccountDebitandCredit.AccountDebit;
                            productAccountID.Add(entry.FK_ACCreditAccountID);
                        }
                        documentEntryAccounts[entry].Add(InvoiceItemsInfo);
                    }
                }

                //Thuế GTGT phải nộp
                foreach (ARInvoiceItemsInfo InvoiceItemsInfo in entity.InvoiceItemList)
                {
                    ACDocumentEntrysInfo entryThue = entity.DocumentEntryList.FirstOrDefault(e => e.ACEntryTypeName == AccEntryType.ThueGTGTPhaiNop.ToString());
                    if (entryThue != null)
                    {
                        entryThue.FK_ACCreditAccountID = ((ACAccountsInfo)objAccountsController.GetObjectByNo(AccAccount.Acc33311)).ACAccountID;
                        if (objectID != 0)
                            entryThue.FK_ACDebitAccountID = objectID;
                        else
                            entryThue.FK_ACDebitAccountID = accountDebitIDDTBH;
                    }
                }

                //CHiết khấu thương mại
                foreach (ARInvoiceItemsInfo InvoiceItemsInfo in entity.InvoiceItemList)
                {
                    //ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(InvoiceItemsInfo.FK_ICProductID);
                    foreach (ICProductsInfo item in listInvoiceItems)
                    {
                        if (item.ICProductID == InvoiceItemsInfo.FK_ICProductID)
                            objProductsInfo = item;
                    }
                    if (objProductsInfo != null)
                    {
                        ACDocumentEntrysInfo entry = entity.DocumentEntryList.FirstOrDefault(e => e.ACEntryTypeName == AccEntryType.ChietKhauThuongMai.ToString()
                                                                            && e.FK_ACDebitAccountID == objProductsInfo.FK_ACAccountDiscountID);

                        if (objectID != 0)
                            objAccountDebitandCredit.AccountCredit = objectID;
                        else
                            objAccountDebitandCredit.AccountCredit = accountCreditCKTM;
                        if (objProductsInfo.FK_ACAccountDiscountID != 0)
                            objAccountDebitandCredit.AccountDebit = objProductsInfo.FK_ACAccountDiscountID;
                        else
                            objAccountDebitandCredit.AccountDebit = accountDebitCKTM;

                        if (entry == null)
                        {
                            entry = AccountHelper.AddItemToDocumentEntryList(defaultDocTypeEntrysCK, entity.DocumentEntryList);
                            entry.FK_ACCreditAccountID = objAccountDebitandCredit.AccountCredit;
                            entry.FK_ACDebitAccountID = objAccountDebitandCredit.AccountDebit;
                        }
                        if (entry != null && !documentEntryAccounts.ContainsKey(entry))
                        {
                            documentEntryAccounts.Add(entry, new List<ARInvoiceItemsInfo>());
                            entry.FK_ACCreditAccountID = objAccountDebitandCredit.AccountCredit;
                            entry.FK_ACDebitAccountID = objAccountDebitandCredit.AccountDebit;
                            productAccountID.Add(entry.FK_ACDebitAccountID);
                        }
                        documentEntryAccounts[entry].Add(InvoiceItemsInfo);
                    }
                }
            }

            //Tính giá tiền
            foreach (ACDocumentEntrysInfo entry in entity.DocumentEntryList)
            {
                if (entry.ACEntryTypeName == AccEntryType.DoanhThuBanHang.ToString())
                {
                    entry.ACDocumentEntryAmount = 0;
                    foreach (ARInvoiceItemsInfo itemInvoiceItem in entity.InvoiceItemList)
                    {
                        foreach (ICProductsInfo itemProduct in listInvoiceItems)
                        {
                            if (itemProduct.ICProductID == itemInvoiceItem.FK_ICProductID)
                                objProductsInfo = itemProduct;
                        }
                        if (objProductsInfo != null)
                        {
                            if (objProductsInfo.FK_ACAccountRevenueID != 0)
                            {
                                if (objProductsInfo.FK_ACAccountRevenueID == entry.FK_ACCreditAccountID)
                                {
                                    entry.ACDocumentEntryAmount += itemInvoiceItem.ARInvoiceItemPrice;
                                }
                            }
                            else
                            {
                                if (accountCreditIDDTBH == entry.FK_ACCreditAccountID)
                                {
                                    entry.ACDocumentEntryAmount += itemInvoiceItem.ARInvoiceItemPrice;
                                }
                            }
                        }
                    }

                    BOSApp.RoundByCurrency(entry, "ACDocumentEntryAmount", objInvoicesInfo.FK_GECurrencyID);
                    entry.ACDocumentEntryExchangeAmount = entry.ACDocumentEntryAmount * objInvoicesInfo.ARInvoiceExchangeRate;
                    BOSApp.RoundByCurrency(entry, "ACDocumentEntryExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                }
                else if (entry.ACEntryTypeName == AccEntryType.ChietKhauThuongMai.ToString())
                {
                    entry.ACDocumentEntryAmount = 0;
                    foreach (ARInvoiceItemsInfo itemInvoiceItem in entity.InvoiceItemList)
                    {
                        foreach (ICProductsInfo itemProduct in listInvoiceItems)
                        {
                            if (itemProduct.ICProductID == itemInvoiceItem.FK_ICProductID)
                                objProductsInfo = itemProduct;
                        }

                        if (objProductsInfo != null)
                        {
                            if (objProductsInfo.FK_ACAccountDiscountID != 0)
                            {
                                if (objProductsInfo.FK_ACAccountDiscountID == entry.FK_ACDebitAccountID)
                                {
                                    entry.ACDocumentEntryAmount += itemInvoiceItem.ARInvoiceItemDiscountAmount;
                                }
                            }
                            else
                            {
                                if (accountDebitCKTM == entry.FK_ACDebitAccountID)
                                {
                                    entry.ACDocumentEntryAmount += itemInvoiceItem.ARInvoiceItemDiscountAmount;
                                }
                            }
                        }
                    }
                    entry.ACDocumentEntryAmount += objInvoicesInfo.ARInvoiceDiscountFix;
                    BOSApp.RoundByCurrency(entry, "ACDocumentEntryAmount", objInvoicesInfo.FK_GECurrencyID);
                    entry.ACDocumentEntryExchangeAmount = entry.ACDocumentEntryAmount * objInvoicesInfo.ARInvoiceExchangeRate;
                    BOSApp.RoundByCurrency(entry, "ACDocumentEntryExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                }
                else if (entry.ACEntryTypeName == AccEntryType.ThueGTGTPhaiNop.ToString())
                {
                    entry.ACDocumentEntryAmount = (from ii in entity.InvoiceItemList
                                                   select ii.ARInvoiceItemTaxAmount).Sum();
                    entry.ACDocumentEntryAmount += objInvoicesInfo.ARInvoiceTaxAmount;
                    BOSApp.RoundByCurrency(entry, "ACDocumentEntryAmount", objInvoicesInfo.FK_GECurrencyID);
                    entry.ACDocumentEntryExchangeAmount = entry.ACDocumentEntryAmount * objInvoicesInfo.ARInvoiceExchangeRate;

                    BOSApp.RoundByCurrency(entry, "ACDocumentEntryExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                }
            }
            {
                List<ACDocumentEntrysInfo> removedItems = entity.DocumentEntryList.Where(item => item.ACEntryTypeName == AccEntryType.DoanhThuBanHang.ToString()
                                                                                  && !productAccountID.Any(accountID => accountID == item.FK_ACCreditAccountID || accountID == accountCreditIDDTBH)).ToList();
                if (removedItems != null)
                {
                    foreach (ACDocumentEntrysInfo item in removedItems)
                        entity.DocumentEntryList.Remove(item);
                }

                List<ACDocumentEntrysInfo> removedCKItems = entity.DocumentEntryList.Where(item => item.ACEntryTypeName == AccEntryType.ChietKhauThuongMai.ToString()
                                                                                  && !productAccountID.Any(accountID => accountID == item.FK_ACDebitAccountID || accountID == accountDebitCKTM)).ToList();
                if (removedCKItems != null)
                {
                    foreach (ACDocumentEntrysInfo item in removedCKItems)
                        entity.DocumentEntryList.Remove(item);
                }
            }
            entity.DocumentEntryList.GridControl.RefreshDataSource();
        }


        public void ChangeDepositBalance()
        {
            POSEntities entity = (POSEntities)CurrentModuleEntity;
            UpdateTotalAmount();
        }

        public void ChangeObject(string objectAccessKey)
        {
            POSEntities entity = (POSEntities)CurrentModuleEntity;
            ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)CurrentModuleEntity.MainObject;
            objInvoicesInfo.ACObjectAccessKey = objectAccessKey;
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(objectAccessKey);
            objObjectsInfo = objObjectsController.GetObjectByIDAndType(objObjectsInfo.ACObjectID, objObjectsInfo.ACObjectType);
            if (objObjectsInfo != null)
            {
                objInvoicesInfo.FK_ACObjectID = objObjectsInfo.ACObjectID;
                objInvoicesInfo.ARObjectType = objObjectsInfo.ACObjectType;
                objInvoicesInfo.ACObjectName = objObjectsInfo.ACObjectName;
                objInvoicesInfo.ARInvoiceSOContactName = objObjectsInfo.ACObjectName;
                if (objObjectsInfo.ACObjectType == ObjectType.Customer.ToString())
                {
                    ARCustomersInfo customer = (ARCustomersInfo)(new ARCustomersController()).GetObjectByID(objObjectsInfo.ACObjectID);
                    if(customer != null)
                    {
                        objInvoicesInfo.FK_ARCustomerID = customer.ARCustomerID;
                        objInvoicesInfo.ARInvoiceSOContactName = customer.ARCustomerContactName;
                        objInvoicesInfo.ARInvoiceSOContactPhone = string.IsNullOrWhiteSpace(customer.ARCustomerContactPhone) ? customer.ARCustomerContactCellPhone : customer.ARCustomerContactPhone;
                        objInvoicesInfo.ARInvoiceSOContactEmail1 = customer.ARCustomerContactEmail1;
                    }
                }
                UpdateInvoiceItemProductUnitPriceFromInvoiceItemList();
                entity.SetProductPriceByProductUnitPrice();
                UpdateDocumentEntries();
            }
            else
            {
                objInvoicesInfo.FK_ACObjectID = 0;
                objInvoicesInfo.ARObjectType = string.Empty;
                objInvoicesInfo.ACObjectName = string.Empty;
                objInvoicesInfo.FK_ARCustomerID = 0;
                objInvoicesInfo.ARInvoiceSOContactName = string.Empty;
                objInvoicesInfo.ARInvoiceSOContactPhone = string.Empty;
                objInvoicesInfo.ARInvoiceSOContactEmail1 = string.Empty;
            }
            ICProductCustomersController objProductCustomersController = new ICProductCustomersController();
            ICProductCustomersInfo objProductCustomersInfo = new ICProductCustomersInfo();
            entity.InvoiceItemList.ForEach(o =>
            {
                objProductCustomersInfo = (ICProductCustomersInfo)objProductCustomersController.GetProductCustomerByProductIDAndCustomerID(o.FK_ICProductID, objInvoicesInfo.FK_ARCustomerID);
                o.ARInvoiceItemProductCustomerNumber = objProductCustomersInfo != null ? objProductCustomersInfo.ICProductCustomerNumber : string.Empty;
            });
            entity.InvoiceItemList.GridControl?.RefreshDataSource();
        }
        #endregion

        public void AddNewCustomer()
        {
            Customer.CustomerModule customerModule = (Customer.CustomerModule)BOSApp.ShowModule(ModuleName.Customer);
            if (customerModule == null)
                return;

            Customer.CustomerEntities customerEntities = (Customer.CustomerEntities)customerModule.CurrentModuleEntity;
            customerModule.ActionNew();
        }

        public void ChangeStockOfInvoiceItem()
        {
            POSEntities entity = (POSEntities)CurrentModuleEntity;
            if (entity.InvoiceItemList.CurrentIndex >= 0)
            {
                ARInvoiceItemsInfo objInvoiceItemsInfo = entity.InvoiceItemList[entity.InvoiceItemList.CurrentIndex];
                ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
                List<ICProductSeriesInfo> productSeriesList = objProductSeriesController.GetProductSerieByStockIDAndProductID(objInvoiceItemsInfo.FK_ICStockID, objInvoiceItemsInfo.FK_ICProductID);
                if (productSeriesList.Count == 0 || productSeriesList == null)
                {
                    objInvoiceItemsInfo.FK_ICProductSerieID = 0;
                    objInvoiceItemsInfo.ARInvoiceItemProductSerialNo = string.Empty;
                }
                else
                {
                    objInvoiceItemsInfo.FK_ICProductSerieID = productSeriesList.FirstOrDefault().ICProductSerieID;
                    objInvoiceItemsInfo.ARInvoiceItemProductSerialNo = productSeriesList.FirstOrDefault().ICProductSerieNo;
                }
                entity.InvoiceItemList.GridControl.RefreshDataSource();
            }
        }

        public void ActionPosted()
        {
            if (!CheckLock()) return;
            POSEntities entity = (POSEntities)CurrentModuleEntity;

            if (entity.InvoiceItemList.IsInvalidInventory(TransactionUtil.cstInventoryShipment))
                return;

            ARInvoicesInfo mainObject = (ARInvoicesInfo)entity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            mainObject.ARInvoicePostedStatus = PostedTransactionStatus.Posted.ToString();
            string tableName = mainObject.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
            GLHelper.UpdatePostedStatus(this.Name, tableName, mainObject.ARInvoiceID, PostedTransactionStatus.Posted.ToString());
            entity.SetPropertyChangeEventLock(true);
            GLHelper.PostedTransactions(this.Name, mainObject.ARInvoiceID, ModulePostingType.Accounting, ModulePostingType.Stock);
            InvalidateToolbar();
        }

        public bool ActionUnPosted()
        {
            bool result = true;
            if (!CheckLock()) return false;
            POSEntities entity = (POSEntities)CurrentModuleEntity;
            ARInvoicesInfo mainObject = (ARInvoicesInfo)entity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            mainObject.ARInvoicePostedStatus = PostedTransactionStatus.UnPosted.ToString();
            string tableName = mainObject.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
            GLHelper.UpdatePostedStatus(this.Name, tableName, mainObject.ARInvoiceID, PostedTransactionStatus.UnPosted.ToString());
            entity.SetPropertyChangeEventLock(true);
            GLHelper.UnPostedTransactions(this.Name, mainObject.ARInvoiceID, ModulePostingType.Accounting, ModulePostingType.Stock);
            InvalidateToolbar();
            return result;
        }

        public override void ModuleAfterCompleted()
        {
            ActionPosted();
            base.ModuleAfterCompleted();
        }

        #region Xử lí Popup thu tiền
        public static bool AcceptPayment(BOSList<ARPOSPaymentDetailsInfo> paymentDetails, int customerID, decimal paymentAmount)
        {
            decimal totalAmount = paymentDetails.Sum(pd => pd.ARPOSPaymentDetailAmount);
            if (totalAmount < paymentAmount)
            {
                MessageBox.Show(CommonLocalizedResources.TotalAmountCannotBeLessThanPaymentAmountMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            BOSDbUtil dbUtil = new BOSDbUtil();
            foreach (ARPOSPaymentDetailsInfo paymentDetail in paymentDetails)
            {
                if (paymentDetail.ARPOSPaymentDetailAmount > 0)
                {
                    if (paymentDetail.ARPOSPaymentMethodCombo == PaymentMethod.OwingExchange.ToString())
                    {

                    }
                    else if (paymentDetail.ARPOSPaymentMethodCombo == PaymentMethod.DepositTransfer.ToString())
                    {
                        ARCustomerPaymentsController objCustomerPaymentsController = new ARCustomerPaymentsController();
                        string[] depositNumbers = paymentDetail.ARPOSPaymentDetailInfo.Trim().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string temp in depositNumbers)
                        {
                            string depositNo = temp.Trim();
                            ARCustomerPaymentsInfo deposit = (ARCustomerPaymentsInfo)objCustomerPaymentsController.GetObjectByNo(depositNo);
                            if (deposit == null)
                            {
                                MessageBox.Show(string.Format(CommonLocalizedResources.DepositDoesNotExistMessage, depositNo),
                                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Error);
                                return false;
                            }
                        }
                        if (depositNumbers == null || depositNumbers.Length == 0)
                        {
                            MessageBox.Show(CommonLocalizedResources.InputDepositNumberForTranferingMessage,
                                        CommonLocalizedResources.MessageBoxDefaultCaption,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        #endregion

        public virtual void ChangeItemSerieNo(ARInvoiceItemsInfo item)
        {
            POSEntities entity = (POSEntities)CurrentModuleEntity;
            ARInvoicesInfo mainObject = (ARInvoicesInfo)entity.MainObject;
            decimal unitCost = AccountHelper.GetProductUnitCost(item.FK_ICStockID, item.FK_ICProductID, item.ARInvoiceItemProductSerialNo, mainObject.ARInvoiceDate);
            item.ARInvoiceItemProductUnitCost = unitCost * item.ARInvoiceItemProductFactor / (mainObject.ARInvoiceExchangeRate > 0? mainObject.ARInvoiceExchangeRate: 1);
            item.ARInvoiceItemExchangeUnitCost = unitCost;
            entity.SetProductPriceByProductUnitPrice(item);
            BOSApp.RoundByCurrency(item, mainObject.FK_GECurrencyID);
            entity.InvoiceItemList.GridControl?.RefreshDataSource();
            UpdateTotalAmount();
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
                POSEntities entity = (POSEntities)CurrentModuleEntity;
                ARInvoicesInfo invoice = (ARInvoicesInfo)entity.MainObject;
                if (invoice.ARInvoicePostedStatus != PostedTransactionStatus.Posted.ToString())
                {
                    MessageBox.Show(InvoiceLocalizedResources.ErrorUpLoadDataToHDDT,
                                        CommonLocalizedResources.MessageBoxDefaultCaption,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    return;
                }
                EInvoiceHelper.ToEInvoice(invoice, entity.InvoiceItemList);
            }
        }

        public void ChangeACEInvoiceTypeNo(int invoiceID)
        {
            POSEntities entity = (POSEntities)CurrentModuleEntity;
            ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)entity.MainObject;
            ACEInvoiceTypesController objEInvoiceTypesController = new ACEInvoiceTypesController();
            ACEInvoiceTypesInfo objEInvoiceTypesInfo = (ACEInvoiceTypesInfo)objEInvoiceTypesController.GetObjectByID(invoiceID);
            if (objEInvoiceTypesInfo != null)
            {
                objInvoicesInfo.ARInvoiceVATFormNo = objEInvoiceTypesInfo.ACEInvoiceTypeTemplateCode;
                objInvoicesInfo.ARInvoiceVATSymbol = objEInvoiceTypesInfo.ACEInvoiceTypeSeries;
            }
            else
            {
                objInvoicesInfo.ARInvoiceVATFormNo = string.Empty;
                objInvoicesInfo.ARInvoiceVATSymbol = string.Empty;
            }
            entity.UpdateMainObjectBindingSource();
        }

        public void ChangeCurrency(int currencyID)
        {
            POSEntities entity = (POSEntities)CurrentModuleEntity;
            ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)entity.MainObject;
            objInvoicesInfo.FK_GECurrencyID = currencyID;
            UpdateInvoiceItemProductUnitPriceFromInvoiceItemList();
            foreach (ARInvoiceItemsInfo item in entity.InvoiceItemList)
            {
                BOSApp.RoundByCurrency(item, objInvoicesInfo.FK_GECurrencyID);
            }
            decimal dExchangeRate = BOSApp.RealTimeExchageRateTransferByCurrencyAndDate(objInvoicesInfo.FK_GECurrencyID, objInvoicesInfo.ARInvoiceDate);
            objInvoicesInfo.ARInvoiceExchangeRate = (dExchangeRate > 0) ? dExchangeRate : 1;            
            UpdateTotalAmount();
        }

        public void ChangeStock(int stockID)
        {
            POSEntities entity = (POSEntities)CurrentModuleEntity;
            ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)entity.MainObject;
            objInvoicesInfo.FK_ICStockID = stockID;
            if (!Toolbar.IsNullOrNoneAction())
            {
                if (entity.InvoiceItemList.Count > 0)
                {
                    if (MessageBox.Show(ShipmentLocalizedResources.ConfirmChangeItemStockMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (ARInvoiceItemsInfo item in entity.InvoiceItemList)
                        {
                            item.FK_ICStockID = stockID;
                            InvalidateItemSerieNo(item, "ARInvoiceItems", "ARInvoiceItemProductSerialNo");
                            ChangeItemComponentStock(item);
                        }
                        entity.InvoiceItemList.GridControl.RefreshDataSource();
                    }
                }
            }
            UpdateTotalAmount();
        }

        public void ChangeItemComponentStock(ARInvoiceItemsInfo item)
        {
            if(item.InvoiceItemComponentList != null && item.InvoiceItemComponentList.Count > 0)
            {
                foreach (ARInvoiceItemComponentsInfo com in item.InvoiceItemComponentList)
                {
                    com.FK_ICStockID = item.FK_ICStockID;
                    com.FK_ICProductSerieID = item.FK_ICProductSerieID;
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

        public override void ActionNew()
        {
            base.ActionNew();

            POSEntities entity = (POSEntities)CurrentModuleEntity;
            ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)entity.MainObject;
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            List<ADConfigValuesInfo> ConfigValuesList = new List<ADConfigValuesInfo>();
            ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
            ConfigValuesList = objConfigValuesController.GetADConfigValuesByKeyGroup(ConfigValueGroup.ListOfSalesChannelType);
            if (ConfigValuesList != null && ConfigValuesList.Count > 0)
            {
                objInvoicesInfo.ARListOfSalesChannelType = ConfigValuesList[0].ADConfigKeyValue;
            }
            CSCompanysInfo objCompanysInfo = BOSApp.CurrentCompanyInfo;
            if (objCompanysInfo != null)
                InvoiceItemGridControl.LoadGridViewBySourceSelling(objCompanysInfo.CSSourceSellingPriceMethod);
            entity.UpdateMainObjectBindingSource();
        }
        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            POSEntities entity = (POSEntities)CurrentModuleEntity;
            ARInvoicesInfo mainObject = (ARInvoicesInfo)entity.MainObject;
            ICProductCustomersController objProductCustomerController = new ICProductCustomersController();
            entity.InvoiceItemList.ForEach(o =>
            {
                ICProductCustomersInfo objProductCustomersInfo = (ICProductCustomersInfo)objProductCustomerController.GetProductCustomerByProductIDAndCustomerID(o.FK_ICProductID, mainObject.FK_ARCustomerID);
                o.ARInvoiceItemProductCustomerNumber = objProductCustomersInfo != null ? objProductCustomersInfo.ICProductCustomerNumber : string.Empty;
            });
            entity.InvoiceItemList.GridControl?.RefreshDataSource();
            InvoiceItemGridControl.LoadGridViewBySourceSelling(String.Empty);
        }

        public void ChangeInvoiceDate()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                UpdateInvoiceItemProductUnitPriceFromInvoiceItemList();
            }
        }

        public void AutoSelectProductSerialNo()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                return;
            }

            POSEntities entity = (POSEntities)CurrentModuleEntity;
            ARInvoicesInfo mainObject = (ARInvoicesInfo)entity.MainObject;
            if (entity.InvoiceItemList.Count <= 0)
            {
                MessageBox.Show("Vui lòng thêm sản phẩm xuất kho để gắn mã lô!"
                                , CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (entity.InvoiceItemList.Count(o => o.FK_ICStockID <= 0) > 0)
            {
                MessageBox.Show("Vui lòng chọn kho cho tất cả sản phẩm!"
                                , CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            entity.InvoiceItemList.ForEach(o => o.ARInvoiceDate = mainObject.ARInvoiceDate);
            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            List<ICShipmentItemsInfo> listShipmentItems = objShipmentItemsController.GetListInventoryStockSerialNoForShipment((List<ARInvoiceItemsInfo>)entity.InvoiceItemList.Clone());
            listShipmentItems = listShipmentItems.OrderBy(o => o.ICProductSerieReceiptDate).ToList();
            ICShipmentItemsInfo shipmentItemQty = new ICShipmentItemsInfo();
            foreach (ARInvoiceItemsInfo item in entity.InvoiceItemList)
            {
                shipmentItemQty = listShipmentItems.FirstOrDefault(o => o.FK_ICProductID == item.FK_ICProductID && o.ICShipmentItemProductExchangeQty >= item.ARInvoiceItemProductExchangeQty);
                if (shipmentItemQty != null)
                {
                    item.FK_ICStockID = shipmentItemQty.FK_ICStockID;
                    item.FK_ICProductSerieID = shipmentItemQty.FK_ICProductSerieID;
                    item.ARInvoiceItemProductSerialNo = shipmentItemQty.ICShipmentItemProductSerialNo;
                    item.ARInvoiceItemLotNo = shipmentItemQty.ICShipmentItemLotNo;
                    shipmentItemQty.ICShipmentItemProductExchangeQty -= item.ARInvoiceItemProductExchangeQty;
                    ChangeItemSerieNo(item);
                }
            }
        }

        public void ChangeStaff(object sender, EventArgs e)
        {
            base.ChangeStaff(sender, e);
            POSEntities entity = (POSEntities)CurrentModuleEntity;
            ARInvoicesInfo mainObject = (ARInvoicesInfo)entity.MainObject;
            if (mainObject.FK_HREmployeeID > 0)
            {
                mainObject.FK_ARSellerID = mainObject.FK_HREmployeeID;
            }
        }
        public List<ICProductsInfo> LoadProductList()
        {
            POSEntities entity = (POSEntities)CurrentModuleEntity;
            ARInvoicesInfo mainObject = (ARInvoicesInfo)entity.MainObject;
            ICProductsController objProductsController = new ICProductsController();
            List<ICProductsInfo> listProduct = new List<ICProductsInfo>();
            CSCompanysInfo objCompanysInfo = BOSApp.CurrentCompanyInfo;
            string sellingPriceMethod = objCompanysInfo.CSSourceSellingPriceMethod;
            if (sellingPriceMethod == ADConfigValueUtility.cstSourceSellingPriceMethodMasterData)
            {
                listProduct = objProductsController.GetProductForModuleExceptDepartment(this.Name);
            }
            else if (sellingPriceMethod == ADConfigValueUtility.cstSourceSellingPriceMethodPriceSheet)
            {
                listProduct = objProductsController.GetAllProductListByInActivePriceSheet(mainObject.FK_ARCustomerID, mainObject.ARInvoiceDate, mainObject.ARInvoiceProductType);
            }
            return listProduct;
        }
        public override bool ActionCancelComplete()
        {
            if (!CheckLock()) return false;
            POSEntities entity = (POSEntities)CurrentModuleEntity;
            ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)entity.MainObject;

            ACDocumentsController objDocumentsController = new ACDocumentsController();
            List<ACDocumentsInfo> documentsList = objDocumentsController.GetRelativeDocumentListByInvoiceID(objInvoicesInfo.ARInvoiceID);

            if (documentsList.Count() > 0)
            {
                MessageBox.Show(string.Format("Không thể mở chứng từ này do đã tạo các chứng từ sau: -{0}", string.Join("\n-", documentsList.Select(o => o.ACDocumentNo).ToArray())), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            ActionUnPosted();

            bool isComplete = base.ActionCancelComplete();
            if (isComplete)
            {
                InvalidateToolbar();
            }
            return isComplete;
        }

        public void ChangeItemMeasureUnit()
        {
            POSEntities entity = (POSEntities)CurrentModuleEntity;
            ARInvoicesInfo mainObject = (ARInvoicesInfo)entity.MainObject;
            if (entity.InvoiceItemList.CurrentIndex < 0)
                return;
            ARInvoiceItemsInfo item = entity.InvoiceItemList[entity.InvoiceItemList.CurrentIndex];
            ICProductMeasureUnitsController objProductMeasureUnitsController = new ICProductMeasureUnitsController();
            ICProductMeasureUnitsInfo objProductmeasureUnitsInfo = new ICProductMeasureUnitsInfo();
            objProductmeasureUnitsInfo = (ICProductMeasureUnitsInfo)objProductMeasureUnitsController.GetProductMeasureUnitByProductIDAndMeasureUnitID(item.FK_ICProductID, item.FK_ICMeasureUnitBeforeChangeID);
            decimal oldFactor = objProductmeasureUnitsInfo != null ? objProductmeasureUnitsInfo.ICProductMeasureUnitFactor : 1;
            objProductmeasureUnitsInfo = (ICProductMeasureUnitsInfo)objProductMeasureUnitsController.GetProductMeasureUnitByProductIDAndMeasureUnitID(item.FK_ICProductID, item.FK_ICMeasureUnitID);
            item.ARInvoiceItemProductFactor = (objProductmeasureUnitsInfo != null && objProductmeasureUnitsInfo.ICProductMeasureUnitFactor > 0)
                                                ? objProductmeasureUnitsInfo.ICProductMeasureUnitFactor
                                                : 1;
            item.ARInvoiceItemProductUnitCost = item.ARInvoiceItemProductUnitCost * (item.ARInvoiceItemProductFactor / oldFactor) / mainObject.ARInvoiceExchangeRate;
            entity.SetProductPriceByProductUnitPrice(item);
            entity.InvoiceItemList.GridControl.RefreshDataSource();
        }
        public void SetDefaultSaleOrderTaxPercent(ARInvoiceItemsInfo item)
        {
            POSEntities entity = (POSEntities)CurrentModuleEntity;
            ARInvoicesInfo mainObject = (ARInvoicesInfo)entity.MainObject;
            GEVATsController objVATsController = new GEVATsController();
            GEVATsInfo objVATs = objVATsController.GetObjectByProductGroup(item.FK_ICProductGroupID);
            if (objVATs != null)
            {
                item.ARInvoiceItemProductTaxPercent = objVATs.GEVATPercentValue;
                entity.SetProductPriceByProductUnitPrice(item);
            }
            UpdateTotalAmount();
            entity.InvoiceItemList.GridControl.RefreshDataSource();
            entity.UpdateMainObjectBindingSource();
        }
    }
}

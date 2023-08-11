using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSERP.Utilities;
using BOSLib;
using BOSReport;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.GiftReceipt
{
    public class GiftReceiptModule : BaseTransactionModule
    {
        #region Constants
        public const string ToolbarButtonEditAfterCompleting = "EditAfterCompleting";
        public const string DocumentEntryGridControlName = "fld_dgcACDocumentEntrys";
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
        #endregion

        /// <summary>
        /// A variable indicates whether the uesr is changing the invoice
        /// after completing it
        /// </summary>
        private bool IsEditAfterCompleting = false;

        #region Public properties
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public BOSLookupEdit SearchBranchLookupEditControl;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public List<BRBranchsInfo> BranchList;
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END

        #endregion

        public GiftReceiptModule()
        {
            Name = "GiftReceipt";
            CurrentModuleEntity = new GiftReceiptEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
            GetCurrentModuleDataViewPermission();
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[GiftReceiptModule.SearchBranchLookupEditControlName];
            SearchBranchLookupEditControl.Properties.DataSource = BranchList;
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END

            StartGettingInventoryThread();
        }

        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        //public override string GenerateSearchQuery(string strTableName)
        //{
        //    string query = base.GenerateSearchQuery(strTableName);
        //    query += string.Format(" and ARInvoiceTypeCombo = '{0}'", InvoiceType.GiftReceipt.ToString());
        //    return query;
        //}
        protected override DataSet GetSearchData(ref string searchQuery)
        {
            ARInvoicesController objInvoicesController = new ARInvoicesController();
            ARInvoicesInfo searchObject = (ARInvoicesInfo)CurrentModuleEntity.SearchObject;
            //NUThao [ADD] [08/04/2014] [DB centre]earchObject.ARInvoiceSOContactPhone);
            DataSet ds = new DataSet();
            if (SearchBranchLookupEditControl.EditValue.ToString() == "" || SearchBranchLookupEditControl.EditValue.ToString() == "0")
            {
                if (BranchList.Count == 0)
                {
                    ds = objInvoicesController.GetDataSetByID(-1);
                }
                else
                {
                    ds = objInvoicesController.GetGiftReceiptListByListOfBranchID(
                                                                        searchObject.ARInvoiceNo,
                                                                        searchObject.FK_ARCustomerID,
                                                                        searchObject.FK_HREmployeeID,
                                                                        InvoiceType.GiftReceipt.ToString(),
                                                                        searchObject.InvoiceDateFrom,
                                                                        searchObject.InvoiceDateTo,
                                                                        BranchList);
                }
            }
            else
            {
                ds = objInvoicesController.GetGiftReceiptList(
                                                         searchObject.ARInvoiceNo,
                                                        searchObject.FK_ARCustomerID,
                                                        searchObject.FK_HREmployeeID,
                                                        InvoiceType.GiftReceipt.ToString(),
                                                        searchObject.InvoiceDateFrom,
                                                        searchObject.InvoiceDateTo,
                                                        searchObject.FK_BRBranchID);
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
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, true);
                if (objInvoicesInfo.ARInvoiceStatus == InvoiceStatus.Complete.ToString() ||
                    objInvoicesInfo.ARInvoiceStatus == InvoiceStatus.Paid.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                }

                ParentScreen.SetEnableOfToolbarButton(GiftReceiptModule.ToolbarButtonEditAfterCompleting, false);
                if (objInvoicesInfo.ARInvoiceStatus == InvoiceStatus.Complete.ToString() ||
                    objInvoicesInfo.ARInvoiceStatus == InvoiceStatus.Paid.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(GiftReceiptModule.ToolbarButtonEditAfterCompleting, true);
                }

                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonPrint, true);
                if (objInvoicesInfo.ARInvoiceStatus == InvoiceStatus.New.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonPrint, false);
                }
            }

            base.InvalidateToolbar();
        }

        /// <summary>
        /// Add item to invoice item list
        /// </summary>
        public void AddItemToInvoiceItemList()
        {
            GiftReceiptEntities entity = (GiftReceiptEntities)CurrentModuleEntity;
            ARInvoiceItemsInfo objInvoiceItemsInfo = (ARInvoiceItemsInfo)entity.ModuleObjects[TableName.ARInvoiceItemsTableName];
            if (objInvoiceItemsInfo.FK_ICProductID > 0)
            {
                entity.SetValuesAfterValidateProduct(objInvoiceItemsInfo.FK_ICProductID);
                entity.InvoiceItemList.AddObjectToList();
                UpdateTotalAmount();
            }
        }

        /// <summary>
        /// Change item from invoice item list
        /// </summary>
        public void ChangeItemFromInvoiceItemList()
        {
            GiftReceiptEntities entity = (GiftReceiptEntities)CurrentModuleEntity;
            ARInvoiceItemsInfo objInvoiceItemsInfo = (ARInvoiceItemsInfo)entity.ModuleObjects[TableName.ARInvoiceItemsTableName];
            entity.SetProductPriceByProductUnitPrice();
            entity.InvoiceItemList.ChangeObjectFromList();
            UpdateTotalAmount();
        }

        /// <summary>
        /// Change the quantity of components of the current item
        /// when its quantity changes
        /// </summary>
        public void ChangeComponentItemQty()
        {
            GiftReceiptEntities entity = (GiftReceiptEntities)CurrentModuleEntity;
            if (entity.InvoiceItemList.CurrentIndex >= 0)
            {
                ARInvoiceItemsInfo objInvoiceItemsInfo = entity.InvoiceItemList[entity.InvoiceItemList.CurrentIndex];
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
            }
        }

        /// <summary>
        /// Delete item from invoice item list
        /// </summary>
        public void DeleteItemFromInvoiceItemList()
        {
            GiftReceiptEntities entity = (GiftReceiptEntities)CurrentModuleEntity;
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
                GiftReceiptEntities entity = (GiftReceiptEntities)CurrentModuleEntity;
                ((ARInvoicesInfo)entity.MainObject).FK_ARCustomerID = Convert.ToInt32(e.Value);
                if (!Toolbar.IsNullOrNoneAction())
                {
                    SetDefaultValuesFromCustomer();
                }
            }
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
                GiftReceiptEntities entity = (GiftReceiptEntities)CurrentModuleEntity;
                ((ARInvoicesInfo)entity.MainObject).FK_ARPriceLevelID = Convert.ToInt32(e.Value);
                if (!Toolbar.IsNullOrNoneAction())
                {
                    if (entity.InvoiceItemList.Count > 0)
                    {
                        if (MessageBox.Show(GiftReceiptLocalizedResources.UpdatePriceLevelMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            GiftReceiptEntities entity = (GiftReceiptEntities)CurrentModuleEntity;
            ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)entity.MainObject;
            if (objInvoicesInfo.ARInvoiceSubTotalAmount > 0)
                objInvoicesInfo.ARInvoiceDiscountPerCent = objInvoicesInfo.ARInvoiceDiscountFix / objInvoicesInfo.ARInvoiceSubTotalAmount * 100;
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
            GiftReceiptEntities entity = (GiftReceiptEntities)CurrentModuleEntity;
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
                GiftReceiptEntities entity = (GiftReceiptEntities)CurrentModuleEntity;
                entity.UpdateTotalAmount();
                UpdateDocumentEntries();
            }
        }

        public override void ActionPrint()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                String[] copies = { GiftReceiptLocalizedResources.Copy1, GiftReceiptLocalizedResources.Copy2 };
                ADReportsController objReportsController = new ADReportsController();
                PrintDialog printDialog = new PrintDialog();
                ADReportsInfo objReportsInfo = (ADReportsInfo)objReportsController.GetObjectByNo(typeof(RPGiftReceipt).Name);
                short numCopies = 1;
                if (objReportsInfo != null)
                {
                    numCopies = objReportsInfo.ADReportCopies;
                }
                printDialog.PrinterSettings.Copies = numCopies;
                DialogResult result = printDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    for (int i = 0; i < printDialog.PrinterSettings.Copies; i++)
                    {
                        string copy = copies[i % copies.Length];
                        RPGiftReceipt report = new RPGiftReceipt();
                        InitGiftReceiptReport(report);
                        XRLabel copyLabel = (XRLabel)report.Bands[BandKind.PageHeader].Controls["xr_lblContact"];
                        if (copyLabel != null)
                            copyLabel.Text = copies[i];
                        XtraReportHelper.PrintToPrinter(report, printDialog.PrinterSettings.PrinterName);
                    }
                }
            }
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
            SetDefaultDesc();

            GiftReceiptEntities entity = (GiftReceiptEntities)CurrentModuleEntity;
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
            ARCustomersController objCustomersController = new ARCustomersController();
            ARCustomersInfo customer = (ARCustomersInfo)objCustomersController.GetObjectByID(invoice.FK_ARCustomerID);
            if (customer != null)
            {
                invoice.ARInvoiceDesc = invoice.ARInvoiceDesc.Replace("{0}", customer.ARCustomerName);
            }
        }

        public override bool ActionComplete()
        {
            //Check all items must have serie no
            GiftReceiptEntities entity = (GiftReceiptEntities)CurrentModuleEntity;
            ARInvoicesInfo invoice = (ARInvoicesInfo)CurrentModuleEntity.MainObject;
            foreach (ARInvoiceItemsInfo item in entity.ComponentInvoiceItemList)
            {
                if (!item.HasComponent && item.FK_ICProductSerieID == 0)
                {
                    MessageBox.Show(string.Format(GiftReceiptLocalizedResources.ItemSerialNoIsRequiredMessage, item.ARInvoiceItemProductDesc), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            //Set cost of goods sold for invoice items

            foreach (ARInvoiceItemsInfo item in entity.ComponentInvoiceItemList)
            {
                item.ARInvoiceItemProductUnitCost = AccountHelper.GetInventoryCost(item.FK_ICStockID, item.FK_ICProductID, item.ARInvoiceItemProductSerialNo, invoice.ARInvoiceDate);
            }

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

        /// <summary>
        /// Init gift receipt report for displaying
        /// </summary>
        /// <param name="report">Report</param>
        private void InitGiftReceiptReport(XtraReport report)
        {
            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            if (objBranchsInfo != null)
            {
                XRLabel label = (XRLabel)report.Bands[BandKind.PageHeader].Controls["xr_lblBRBranchAddressLine3"];
                if (label != null)
                {
                    label.Text = objBranchsInfo.BRBranchContactAddressLine3;
                }

                label = (XRLabel)report.Bands[BandKind.PageHeader].Controls["xr_lblBRBranchPhone"];
                if (label != null)
                {
                    label.Text = objBranchsInfo.BRBranchContactPhone;
                }

                label = (XRLabel)report.Bands[BandKind.PageHeader].Controls["xr_lblBRBranchFax"];
                if (label != null)
                {
                    label.Text = objBranchsInfo.BRBranchContactFax;
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

            if (objInvoicesInfo.ARInvoiceTaxAmount == 0)
            {
                XRPanel taxPanel = (XRPanel)report.Bands[BandKind.ReportFooter].Controls["xr_pnlVAT"];
                if (taxPanel != null)
                {
                    taxPanel.Visible = false;
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

            GiftReceiptEntities entity = (GiftReceiptEntities)CurrentModuleEntity;
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
                        MessageBox.Show(GiftReceiptLocalizedResources.ComponentIsNull, CommonLocalizedResources.MessageBoxDefaultCaption,
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
            GiftReceiptEntities entity = (GiftReceiptEntities)CurrentModuleEntity;
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
        protected override void UpdateDocumentEntries()
        {
            GiftReceiptEntities entity = (GiftReceiptEntities)CurrentModuleEntity;
            ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)entity.MainObject;
            foreach (ACDocumentEntrysInfo entry in entity.DocumentEntryList)
            {
                if (entry.ACEntryTypeName == AccEntryType.DoanhThuBanHang.ToString())
                {
                    entry.ACDocumentEntryAmount = (from ii in entity.InvoiceItemList
                                                   select ii.ARInvoiceItemProductUnitPrice * ii.ARInvoiceItemProductQty).Sum();
                    BOSApp.RoundByCurrency(entry, "ACDocumentEntryAmount", objInvoicesInfo.FK_GECurrencyID);
                    entry.ACDocumentEntryExchangeAmount = entry.ACDocumentEntryAmount * objInvoicesInfo.ARInvoiceExchangeRate;
                    BOSApp.RoundByCurrency(entry, "ACDocumentEntryExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                }
                else if (entry.ACEntryTypeName == AccEntryType.ChietKhauThuongMai.ToString())
                {
                    entry.ACDocumentEntryAmount = (from ii in entity.InvoiceItemList
                                                   select ii.ARInvoiceItemDiscountAmount).Sum();
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
            entity.DocumentEntryList.GridControl.RefreshDataSource();
        }
        #endregion
    }
}

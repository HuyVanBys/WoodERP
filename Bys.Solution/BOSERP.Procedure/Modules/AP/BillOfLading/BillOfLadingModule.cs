using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BOSComponent;

namespace BOSERP.Modules.BillOfLading
{
    public class BillOfLadingModule : BaseTransactionModule
    {
        public const string BillOfLadingGridControlName = "fld_dgcAPBillOfLadingItems";
        public const string BillOfLadingContractNoTextBoxName = "fld_txtAPBillOfLadingContractNo";
        public const string BillOfLadingContractDateEditName = "fld_dteAPBillOfLadingContractDate";

        APBillOfLadingItemsGridControl BillOfLadingGridControl;
        BOSTextBox BillOfLadingContractNoTextBox;
        BOSDateEdit BillOfLadingContractDateEdit;
        BOSLabel EnvironmentTaxLabel;

        public BillOfLadingModule()
        {
            Name = "BillOfLading";
            CurrentModuleEntity = new BillOfLadingEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            BillOfLadingGridControl = (APBillOfLadingItemsGridControl)Controls[BillOfLadingGridControlName];
            BillOfLadingContractNoTextBox = (BOSTextBox)Controls[BillOfLadingContractNoTextBoxName];
            if(BillOfLadingContractNoTextBox != null)
            {
                BillOfLadingContractNoTextBox.Enabled = true;
                BillOfLadingContractNoTextBox.Properties.ReadOnly = true;
            }    
            BillOfLadingContractDateEdit = (BOSDateEdit)Controls[BillOfLadingContractDateEditName];
            if (BillOfLadingContractDateEdit != null)
            {
                BillOfLadingContractDateEdit.Enabled = true;
                BillOfLadingContractDateEdit.Properties.ReadOnly = true;
            }
            EnvironmentTaxLabel = (BOSLabel)Controls["bosLabel20"];
            if (EnvironmentTaxLabel != null)
            {
                ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                if (objConfigValuesController.GetKeyValueByConfigKey("IsDTBillOfLadingTax") == "true")
                {
                    EnvironmentTaxLabel.Text = "Thuế khác";
                }
                else
                    EnvironmentTaxLabel.Text = "Bảo vệ môi trường";
            }    
            ReLocationCol();
        }

        public override void InvalidateToolbar()
        {
            APBillOfLadingsInfo mainObject = (APBillOfLadingsInfo)CurrentModuleEntity.MainObject;
            ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions, false);
            ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions, false);
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancelComplete, false);
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDelete, false);
            if (mainObject.APBillOfLadingID > 0)
            {
                if (mainObject.APBillOfLadingStatus == BillOfLadingStatus.Complete.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancelComplete, true);
                    ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions,
                        mainObject.APBillOfLadingPostedStatus != PostedTransactionStatus.Posted.ToString());
                    ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions,
                        mainObject.APBillOfLadingPostedStatus == PostedTransactionStatus.Posted.ToString());
                }
                else
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, true);
                }
                if (Toolbar.IsEditAction())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDelete, true);
                }
            }
            base.InvalidateToolbar();
        }

        public void ReLocationCol()
        {
            if (BillOfLadingGridControl != null)
            {
                GridView gridView = (GridView)BillOfLadingGridControl.MainView;

                string[] visibleColumns = new string[]{ "APBillOfLadingItemProductDesc",
                                                        "FK_ICProductID",
                                                        "APBillOfLadingItemProductQty",
                                                        "FK_ICMeasureUnitID",
                                                        "APBillOfLadingItemProductUnitCost",
                                                        "APBillOfLadingItemProductUnitCostExchange",
                                                        "APBillOfLadingItemTotalCost",
                                                        "APBillOfLadingItemTotalCostExchange",
                                                        "APBillOfLadingItemImportTaxPercent",
                                                        "APBillOfLadingItemImportTaxAmount",
                                                        "APBillOfLadingItemConsumptionTaxPercent",
                                                        "APBillOfLadingItemConsumptionTaxAmount",
                                                        "APBillOfLadingItemEnviromentTaxPercent",
                                                        "APBillOfLadingItemEnviromentTaxAmount",
                                                        "APBillOfLadingItemVATTaxPercent",
                                                        "APBillOfLadingItemVATTaxAmount",
                                                        "APBillOfLadingItemTotalTaxAmount"};

                BillOfLadingGridControl.ReLocationColumn(visibleColumns, gridView);

                foreach (GridColumn col in gridView.Columns)
                {
                    col.OptionsColumn.AllowEdit = true;

                    if (col.FieldName == "APBillOfLadingItemProductDesc"
                        || col.FieldName == "FK_ICProductID"
                        || col.FieldName == "FK_ICMeasureUnitID"
                        || col.FieldName == "APBillOfLadingItemProductQty"
                        || col.FieldName == "APBillOfLadingItemProductUnitCostExchange"
                        || col.FieldName == "APBillOfLadingItemProductUnitCost"
                        || col.FieldName == "APBillOfLadingItemTotalCost"
                        || col.FieldName == "APBillOfLadingItemTotalTaxAmount")
                    {
                        col.OptionsColumn.AllowEdit = false;
                    }
                }
            }
        }

        public override void ActionNew()
        {
            base.ActionNew();

            BillOfLadingEntities entity = (BillOfLadingEntities)CurrentModuleEntity;
            APBillOfLadingsInfo mainObject = (APBillOfLadingsInfo)entity.MainObject;

            APInvoiceInsController invoiceInsController = new APInvoiceInsController();
            List<APInvoiceInsInfo> invoiceInList = invoiceInsController.GetInvoiceInForBillOfLading();

            guiFind<APInvoiceInsInfo> findGui = new guiFind<APInvoiceInsInfo>("APInvoiceIns"
                                                                                , invoiceInList
                                                                                , this
                                                                                , false);
            if (findGui.ShowDialog() == DialogResult.OK)
            {
                int invoiceInID = Convert.ToInt32(findGui.Tag);

                APInvoiceInsInfo selectedInvoiceIn = invoiceInList.FirstOrDefault(t => t.APInvoiceInID == invoiceInID);

                APInvoiceInItemsController invoiceInItemController = new APInvoiceInItemsController();
                List<APInvoiceInItemsInfo> invoiceInItemList = invoiceInItemController.GetInvoiceInItemForBOL(invoiceInID);

                // thong tin chung
                CopyInvoiceInToMainObject(selectedInvoiceIn, mainObject, invoiceInItemList[0].FK_GEPaymentTermID);

                // chi tiet
                List<APBillOfLadingItemsInfo> bolList = new List<APBillOfLadingItemsInfo>();
                APBillOfLadingItemsInfo bol = new APBillOfLadingItemsInfo();
                foreach (APInvoiceInItemsInfo invoiceInItem in invoiceInItemList)
                {
                    bol = new APBillOfLadingItemsInfo();
                    bol.FK_ICProductID = invoiceInItem.FK_ICProductID;
                    bol.APBillOfLadingItemProductDesc = invoiceInItem.APInvoiceInItemProductDesc;

                    bol.APBillOfLadingItemProductUnitCostExchange = bol.APBillOfLadingItemProductUnitCost * mainObject.APBillOfLadingExchangeRate;
                    bol.APBillOfLadingItemTotalCost = bol.APBillOfLadingItemProductQty * bol.APBillOfLadingItemProductUnitCost;
                    bol.APBillOfLadingItemTotalCostExchange = (bol.APBillOfLadingItemTotalCost * mainObject.APBillOfLadingExchangeRate) + bol.APBillOfLadingItemDOFee + bol.APBillOfLadingItemCleaningContFee;
                    bol.APBillOfLadingItemVATTaxPercent = 10;
                    bol.APBillOfLadingItemVATTaxAmount = bol.APBillOfLadingItemVATTaxPercent
                                                                                        * (bol.APBillOfLadingItemTotalCostExchange
                                                                                        + bol.APBillOfLadingItemImportTaxAmount
                                                                                        + bol.APBillOfLadingItemConsumptionTaxAmount
                                                                                        + bol.APBillOfLadingItemEnviromentTaxAmount)
                                                                                        / 100;


                    bol.APBillOfLadingItemTotalTaxAmount = bol.APBillOfLadingItemImportTaxAmount
                                                                                   + bol.APBillOfLadingItemConsumptionTaxAmount
                                                                                   + bol.APBillOfLadingItemEnviromentTaxAmount
                                                                                   + bol.APBillOfLadingItemVATTaxAmount;

                    bolList.Add(bol);
                }

                entity.BillOfLadingItemList.Invalidate(bolList);
                entity.BillOfLadingItemList.GridControl.RefreshDataSource();
                UpdateDocumentEntries();
                entity.UpdateMainObjectBindingSource();
            }

        }

        public void ActionNewFromInvoiceIn()
        {
            base.ActionNew();
            BillOfLadingEntities entity = (BillOfLadingEntities)CurrentModuleEntity;
            APBillOfLadingsInfo mainObject = (APBillOfLadingsInfo)entity.MainObject;

            APInvoiceInsController invoiceInsController = new APInvoiceInsController();
            List<APInvoiceInsInfo> invoiceInList = invoiceInsController.GetInvoiceInForBillOfLading();
            guiFind<APInvoiceInsInfo> findGui = new guiFind<APInvoiceInsInfo>("APInvoiceIns"
                                                                                , invoiceInList
                                                                                , this
                                                                                , false);
            if (findGui.ShowDialog() == DialogResult.OK)
            {
                int invoiceInID = Convert.ToInt32(findGui.Tag);

                APInvoiceInsInfo selectedInvoiceIn = invoiceInList.FirstOrDefault(t => t.APInvoiceInID == invoiceInID);

                APInvoiceInItemsController invoiceInItemController = new APInvoiceInItemsController();
                List<APInvoiceInItemsInfo> invoiceInItemList = invoiceInItemController.GetInvoiceInItemForBOL(invoiceInID);

                // thong tin chung
                CopyInvoiceInToMainObject(selectedInvoiceIn, mainObject, invoiceInItemList[0].FK_GEPaymentTermID);

                // chi tiet
                List<APBillOfLadingItemsInfo> bolList = new List<APBillOfLadingItemsInfo>();
                APBillOfLadingItemsInfo bol = new APBillOfLadingItemsInfo();
                foreach (APInvoiceInItemsInfo invoiceInItem in invoiceInItemList)
                {
                    bol = new APBillOfLadingItemsInfo();
                    bol.FK_ICProductID = invoiceInItem.FK_ICProductID;
                    bol.APBillOfLadingItemProductDesc = invoiceInItem.APInvoiceInItemProductDesc;
                    bol.FK_ICMeasureUnitID = invoiceInItem.FK_ICMeasureUnitID;
                    bol.APBillOfLadingItemProductQty = invoiceInItem.APInvoiceInItemProductQty;
                    bol.APBillOfLadingItemProductUnitCost = invoiceInItem.APInvoiceInItemProductUnitCost;
                    bol.APBillOfLadingItemProductUnitCostExchange = bol.APBillOfLadingItemProductUnitCost * mainObject.APBillOfLadingExchangeRate;
                    bol.APBillOfLadingItemTotalCost = bol.APBillOfLadingItemProductUnitCost * bol.APBillOfLadingItemProductQty;
                    bol.APBillOfLadingItemTotalCostExchange = (bol.APBillOfLadingItemTotalCost * mainObject.APBillOfLadingExchangeRate)
                                                                + bol.APBillOfLadingItemDOFee
                                                                + bol.APBillOfLadingItemCleaningContFee;
                    //bol.APBillOfLadingItemVATTaxPercent = 10;
                    bol.APBillOfLadingItemVATTaxAmount = bol.APBillOfLadingItemVATTaxPercent
                                                                                        * (bol.APBillOfLadingItemTotalCostExchange
                                                                                        + bol.APBillOfLadingItemImportTaxAmount
                                                                                        + bol.APBillOfLadingItemConsumptionTaxAmount
                                                                                        + bol.APBillOfLadingItemEnviromentTaxAmount)
                                                                                        / 100;


                    bol.APBillOfLadingItemTotalTaxAmount = bol.APBillOfLadingItemImportTaxAmount
                                                                                   + bol.APBillOfLadingItemConsumptionTaxAmount
                                                                                   + bol.APBillOfLadingItemEnviromentTaxAmount
                                                                                   + bol.APBillOfLadingItemVATTaxAmount;

                    bolList.Add(bol);
                }

                entity.BillOfLadingItemList.Invalidate(bolList);
                entity.BillOfLadingItemList.GridControl.RefreshDataSource();
                GenerateAccountingData();
                UpdateDocumentEntries();
                entity.UpdateMainObjectBindingSource();
            }
            else
            {
                ActionCancel();
            }
        }

        public void ActionNewFromInvoice()
        {
            base.ActionNew();
            BillOfLadingEntities entity = (BillOfLadingEntities)CurrentModuleEntity;
            APBillOfLadingsInfo mainObject = (APBillOfLadingsInfo)entity.MainObject;

            ARInvoicesController invoiceInsController = new ARInvoicesController();
            List<ARInvoicesInfo> invoiceInList = invoiceInsController.GetInvoiceForBillOfLading();

            guiFind<ARInvoicesInfo> findGui = new guiFind<ARInvoicesInfo>("ARInvoices"
                                                                                , invoiceInList
                                                                                , this
                                                                                , false);
            if (findGui.ShowDialog() == DialogResult.OK)
            {
                int invoiceInID = Convert.ToInt32(findGui.Tag);

                ARInvoicesInfo selectedInvoiceIn = invoiceInList.FirstOrDefault(t => t.ARInvoiceID == invoiceInID);

                ARInvoiceItemsController invoiceInItemController = new ARInvoiceItemsController();
                List<ARInvoiceItemsInfo> invoiceInItemList = invoiceInItemController.GetInvoiceItemForBOL(invoiceInID);

                // thong tin chung
                CopyInvoiceToMainObject(selectedInvoiceIn, mainObject, invoiceInItemList[0].FK_GEPaymentTermID);

                // chi tiet
                List<APBillOfLadingItemsInfo> bolList = new List<APBillOfLadingItemsInfo>();
                APBillOfLadingItemsInfo bol = new APBillOfLadingItemsInfo();
                foreach (ARInvoiceItemsInfo invoiceInItem in invoiceInItemList)
                {
                    bol = new APBillOfLadingItemsInfo();
                    bol.FK_ICProductID = invoiceInItem.FK_ICProductID;
                    bol.APBillOfLadingItemProductDesc = invoiceInItem.ARInvoiceItemProductDesc;
                    bol.FK_ICMeasureUnitID = invoiceInItem.FK_ICMeasureUnitID;
                    bol.APBillOfLadingItemProductQty = invoiceInItem.ARInvoiceItemProductQty;
                    bol.APBillOfLadingItemProductUnitCost = invoiceInItem.ARInvoiceItemProductUnitPrice;
                    bol.APBillOfLadingItemProductUnitCostExchange = bol.APBillOfLadingItemProductUnitCost * mainObject.APBillOfLadingExchangeRate;
                    bol.APBillOfLadingItemTotalCost = bol.APBillOfLadingItemProductQty * bol.APBillOfLadingItemProductUnitCost;
                    bol.APBillOfLadingItemTotalCostExchange = (bol.APBillOfLadingItemTotalCost * mainObject.APBillOfLadingExchangeRate) + bol.APBillOfLadingItemDOFee + bol.APBillOfLadingItemCleaningContFee;
                    //bol.APBillOfLadingItemVATTaxPercent = 10;
                    bol.APBillOfLadingItemVATTaxAmount = bol.APBillOfLadingItemVATTaxPercent
                                                                                        * (bol.APBillOfLadingItemTotalCostExchange
                                                                                        + bol.APBillOfLadingItemImportTaxAmount
                                                                                        + bol.APBillOfLadingItemConsumptionTaxAmount
                                                                                        + bol.APBillOfLadingItemEnviromentTaxAmount)
                                                                                        / 100;


                    bol.APBillOfLadingItemTotalTaxAmount = bol.APBillOfLadingItemImportTaxAmount
                                                                                   + bol.APBillOfLadingItemConsumptionTaxAmount
                                                                                   + bol.APBillOfLadingItemEnviromentTaxAmount
                                                                                   + bol.APBillOfLadingItemVATTaxAmount;

                    bolList.Add(bol);
                }

                entity.BillOfLadingItemList.Invalidate(bolList);
                entity.BillOfLadingItemList.GridControl.RefreshDataSource();
                GenerateAccountingData();
                UpdateDocumentEntries();
                entity.UpdateMainObjectBindingSource();
            }
            else
            {
                ActionCancel();
            }
        }

        public void ChangeExchangeRate()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                BillOfLadingEntities entity = (BillOfLadingEntities)CurrentModuleEntity;
                APBillOfLadingsInfo mainObject = (APBillOfLadingsInfo)entity.MainObject;

                foreach (APBillOfLadingItemsInfo item in entity.BillOfLadingItemList)
                {
                    item.APBillOfLadingItemProductUnitCostExchange = item.APBillOfLadingItemProductUnitCost * mainObject.APBillOfLadingExchangeRate;
                    item.APBillOfLadingItemTotalCostExchange = (item.APBillOfLadingItemTotalCost * mainObject.APBillOfLadingExchangeRate) + item.APBillOfLadingItemDOFee + item.APBillOfLadingItemCleaningContFee;

                    item.APBillOfLadingItemImportTaxAmount = item.APBillOfLadingItemImportTaxPercent
                                                                * item.APBillOfLadingItemTotalCostExchange / 100;

                    item.APBillOfLadingItemConsumptionTaxAmount = item.APBillOfLadingItemConsumptionTaxPercent
                                                                * (item.APBillOfLadingItemTotalCostExchange
                                                                + item.APBillOfLadingItemImportTaxAmount) / 100;

                    item.APBillOfLadingItemEnviromentTaxAmount = item.APBillOfLadingItemEnviromentTaxPercent
                                                               * item.APBillOfLadingItemTotalCostExchange / 100;

                    item.APBillOfLadingItemVATTaxAmount = item.APBillOfLadingItemVATTaxPercent
                                                               * (item.APBillOfLadingItemTotalCostExchange
                                                               + item.APBillOfLadingItemImportTaxAmount
                                                               + item.APBillOfLadingItemConsumptionTaxAmount
                                                               + item.APBillOfLadingItemEnviromentTaxAmount) / 100;
                    item.APBillOfLadingItemTotalTaxAmount = item.APBillOfLadingItemImportTaxAmount
                                                         + item.APBillOfLadingItemConsumptionTaxAmount
                                                         + item.APBillOfLadingItemEnviromentTaxAmount
                                                         + item.APBillOfLadingItemVATTaxAmount;


                }
                entity.BillOfLadingItemList.GridControl.RefreshDataSource();
                UpdateDocumentEntries();

            }
        }

        public void CopyInvoiceInToMainObject(APInvoiceInsInfo selectedInvoiceIn, APBillOfLadingsInfo mainObject, int fk_gepaymentTermID)
        {
            mainObject.APBillOfLadingDeclarationNo = selectedInvoiceIn.APInvoiceInBillOfLanding;
            mainObject.APBillOfLadingImportExportType = BillOfLadingImportExportType.Import.ToString();
            mainObject.FK_BRBranchID = selectedInvoiceIn.FK_BRBranchID;
            mainObject.FK_APInvoiceInID = selectedInvoiceIn.APInvoiceInID;
            mainObject.APBillOfLadingStatus = BillOfLadingStatus.New.ToString();
            mainObject.FK_ACObjectID = selectedInvoiceIn.FK_ACAssObjectID;
            mainObject.APObjectType = selectedInvoiceIn.APAssObjectType;
            mainObject.ACObjectAccessKey = mainObject.FK_ACObjectID + ";" + mainObject.APObjectType;
            mainObject.APBillOfLadingReference = selectedInvoiceIn.APInvoiceInNo;
            mainObject.APBillOfLadingTaxNumber = selectedInvoiceIn.APInvoiceInTaxNumber;
            mainObject.APBillOfLadingSupplierNo = selectedInvoiceIn.APInvoiceInSupplierNo;
            mainObject.APBillOfLadingVATDate = selectedInvoiceIn.APInvoiceInVATDate;
            mainObject.FK_GECurrencyID = selectedInvoiceIn.FK_GECurrencyID;
            mainObject.APBillOfLadingExchangeRate = selectedInvoiceIn.APInvoiceInExchangeRate;
            mainObject.APBillOfLadingContractNo = selectedInvoiceIn.APInvoiceInContractNo;
            mainObject.APBillOfLadingContractDate = selectedInvoiceIn.APInvoiceInContractDate;            

            if (selectedInvoiceIn.FK_GEPaymentTermID > 0)
            {
                mainObject.FK_GEPaymentTermID = selectedInvoiceIn.FK_GEPaymentTermID;
            }
            else
            {
                mainObject.FK_GEPaymentTermID = fk_gepaymentTermID;
            }
            APPurchaseContractsController objPurchaseContractsController = new APPurchaseContractsController();
            APPurchaseContractsInfo objPurchaseContractsInfo = (APPurchaseContractsInfo)objPurchaseContractsController.GetObjectByID(selectedInvoiceIn.FK_APPurchaseContractID);
            if (objPurchaseContractsInfo != null)
            {
                mainObject.APBillOfLadingContractNo = objPurchaseContractsInfo.APPurchaseContractNo;
                mainObject.APBillOfLadingContractDate = objPurchaseContractsInfo.APPurchaseContractDate;
            }
        }

        public void CopyInvoiceToMainObject(ARInvoicesInfo selectedInvoice, APBillOfLadingsInfo mainObject, int fk_gepaymentTermID)
        {
            mainObject.APBillOfLadingImportExportType = BillOfLadingImportExportType.Export.ToString(); ;
            mainObject.FK_BRBranchID = selectedInvoice.FK_BRBranchID;
            mainObject.FK_ARInvoiceID = selectedInvoice.ARInvoiceID;
            mainObject.APBillOfLadingStatus = BillOfLadingStatus.New.ToString();
            mainObject.FK_ACObjectID = selectedInvoice.FK_ACObjectID;
            mainObject.APObjectType = selectedInvoice.ARObjectType;
            mainObject.ACObjectAccessKey = mainObject.FK_ACObjectID + ";" + mainObject.APObjectType;
            mainObject.APBillOfLadingTaxNumber = selectedInvoice.ARInvoiceTaxNumber;
            mainObject.APBillOfLadingSupplierNo = selectedInvoice.ARInvoiceVATInvoiceNo;
            mainObject.APBillOfLadingVATDate = selectedInvoice.ARInvoiceDate;
            mainObject.FK_GECurrencyID = selectedInvoice.FK_GECurrencyID;
            mainObject.APBillOfLadingExchangeRate = selectedInvoice.ARInvoiceExchangeRate;
            mainObject.FK_GEPaymentTermID = fk_gepaymentTermID;
            mainObject.APBillOfLadingReference = selectedInvoice.ARInvoiceNo;
            ARSaleContractsController objSaleContractsController = new ARSaleContractsController();
            ARSaleContractsInfo objSaleContractsInfo = (ARSaleContractsInfo)objSaleContractsController.GetObjectByID(selectedInvoice.FK_ARSaleContractID);
            if (objSaleContractsInfo != null)
            {
                mainObject.APBillOfLadingContractNo = objSaleContractsInfo.ARSaleContractKHNos;
                mainObject.APBillOfLadingContractDate = objSaleContractsInfo.ARSaleContractDate;
            }
        }

        #region Accounting
        public void UpdateDocumentEntriesExt()
        {
            UpdateDocumentEntries();
        }

        protected override void UpdateDocumentEntries()
        {
            BillOfLadingEntities entity = (BillOfLadingEntities)CurrentModuleEntity;
            APBillOfLadingsInfo objBillOfLadingsInfo = (APBillOfLadingsInfo)entity.MainObject;
            ACAccountsController objAccountsController = new ACAccountsController();
            decimal xrate = objBillOfLadingsInfo.APBillOfLadingExchangeRate;
            if (xrate == 0)
            {
                xrate = 1;
                objBillOfLadingsInfo.APBillOfLadingExchangeRate = 1;
            }
            ICProductsController pController = new ICProductsController();
            ICProductsInfo p;
            foreach (APBillOfLadingItemsInfo item in entity.BillOfLadingItemList)
            {
                p = BOSApp.GetProductFromCurrentProductList(item.FK_ICProductID);
                if (p != null)
                {
                    item.FK_ACAccountID = p.FK_ACAccountID;
                }
            }
            entity.BillOfLadingItemList.GridControl.RefreshDataSource();
        }
        #endregion

        public void ChangeImportTaxPercent(bool chageAll)
        {
            BillOfLadingEntities entity = (BillOfLadingEntities)CurrentModuleEntity;
            APBillOfLadingsInfo objBillOfLadingsInfo = (APBillOfLadingsInfo)entity.MainObject;

            decimal importTaxPercent = objBillOfLadingsInfo.APBillOfLadingImportTaxPercent;

            foreach (APBillOfLadingItemsInfo item in entity.BillOfLadingItemList)
            {
                if (chageAll)
                    item.APBillOfLadingItemImportTaxPercent = importTaxPercent;

                item.APBillOfLadingItemImportTaxAmount = item.APBillOfLadingItemImportTaxPercent
                                                                * item.APBillOfLadingItemTotalCostExchange / 100;

                item.APBillOfLadingItemConsumptionTaxAmount = item.APBillOfLadingItemConsumptionTaxPercent
                                                            * (item.APBillOfLadingItemTotalCostExchange
                                                            + item.APBillOfLadingItemImportTaxAmount) / 100;

                item.APBillOfLadingItemVATTaxAmount = item.APBillOfLadingItemVATTaxPercent
                                                          * (item.APBillOfLadingItemTotalCostExchange
                                                          + item.APBillOfLadingItemImportTaxAmount
                                                          + item.APBillOfLadingItemConsumptionTaxAmount
                                                          + item.APBillOfLadingItemEnviromentTaxAmount) / 100;

                item.APBillOfLadingItemTotalTaxAmount = item.APBillOfLadingItemImportTaxAmount
                                                         + item.APBillOfLadingItemConsumptionTaxAmount
                                                         + item.APBillOfLadingItemEnviromentTaxAmount
                                                         + item.APBillOfLadingItemVATTaxAmount;
            }
            entity.BillOfLadingItemList.GridControl.RefreshDataSource();
            UpdateDocumentEntries();
        }

        public void ChangeVATTaxPercent(bool chageAll)
        {
            BillOfLadingEntities entity = (BillOfLadingEntities)CurrentModuleEntity;
            APBillOfLadingsInfo objBillOfLadingsInfo = (APBillOfLadingsInfo)entity.MainObject;

            decimal _VATTaxPercent = objBillOfLadingsInfo.APBillOfLadingVATTaxPercent;

            foreach (APBillOfLadingItemsInfo item in entity.BillOfLadingItemList)
            {
                if (chageAll)
                    item.APBillOfLadingItemVATTaxPercent = _VATTaxPercent;

                item.APBillOfLadingItemVATTaxAmount = item.APBillOfLadingItemVATTaxPercent
                                                                * (item.APBillOfLadingItemTotalCostExchange
                                                                + item.APBillOfLadingItemImportTaxAmount
                                                                + item.APBillOfLadingItemConsumptionTaxAmount
                                                                + item.APBillOfLadingItemEnviromentTaxAmount) / 100;

                item.APBillOfLadingItemTotalTaxAmount = item.APBillOfLadingItemImportTaxAmount
                                                         + item.APBillOfLadingItemConsumptionTaxAmount
                                                         + item.APBillOfLadingItemEnviromentTaxAmount
                                                         + item.APBillOfLadingItemVATTaxAmount;
            }
            entity.BillOfLadingItemList.GridControl.RefreshDataSource();
            UpdateDocumentEntries();
        }

        public void ChangeConsumptionTaxPercent(bool chageAll)
        {
            BillOfLadingEntities entity = (BillOfLadingEntities)CurrentModuleEntity;
            APBillOfLadingsInfo objBillOfLadingsInfo = (APBillOfLadingsInfo)entity.MainObject;

            decimal consumptionTaxPercent = objBillOfLadingsInfo.APBillOfLadingConsumptionTaxPercent;

            foreach (APBillOfLadingItemsInfo item in entity.BillOfLadingItemList)
            {
                if (chageAll)
                    item.APBillOfLadingItemConsumptionTaxPercent = consumptionTaxPercent;
                item.APBillOfLadingItemConsumptionTaxAmount = item.APBillOfLadingItemConsumptionTaxPercent
                                                                 * (item.APBillOfLadingItemTotalCostExchange
                                                                 + item.APBillOfLadingItemImportTaxAmount) / 100;

                item.APBillOfLadingItemVATTaxAmount = item.APBillOfLadingItemVATTaxPercent
                                                          * (item.APBillOfLadingItemTotalCostExchange
                                                          + item.APBillOfLadingItemImportTaxAmount
                                                          + item.APBillOfLadingItemConsumptionTaxAmount
                                                          + item.APBillOfLadingItemEnviromentTaxAmount) / 100;

                item.APBillOfLadingItemTotalTaxAmount = item.APBillOfLadingItemImportTaxAmount
                                                         + item.APBillOfLadingItemConsumptionTaxAmount
                                                         + item.APBillOfLadingItemEnviromentTaxAmount
                                                         + item.APBillOfLadingItemVATTaxAmount;
            }
            entity.BillOfLadingItemList.GridControl.RefreshDataSource();
            UpdateDocumentEntries();
        }

        public void ChangeEnviromentTaxPercent(bool chageAll)
        {
            BillOfLadingEntities entity = (BillOfLadingEntities)CurrentModuleEntity;
            APBillOfLadingsInfo objBillOfLadingsInfo = (APBillOfLadingsInfo)entity.MainObject;

            decimal enviromentTaxPercent = objBillOfLadingsInfo.APBillOfLadingEnviromentTaxPercent;

            foreach (APBillOfLadingItemsInfo item in entity.BillOfLadingItemList)
            {
                if (chageAll)
                    item.APBillOfLadingItemEnviromentTaxPercent = enviromentTaxPercent;
                item.APBillOfLadingItemEnviromentTaxAmount = item.APBillOfLadingItemEnviromentTaxPercent
                                                                  * item.APBillOfLadingItemTotalCostExchange / 100;

                item.APBillOfLadingItemVATTaxAmount = item.APBillOfLadingItemVATTaxPercent
                                                           * (item.APBillOfLadingItemTotalCostExchange
                                                           + item.APBillOfLadingItemImportTaxAmount
                                                           + item.APBillOfLadingItemConsumptionTaxAmount
                                                           + item.APBillOfLadingItemEnviromentTaxAmount) / 100;

                item.APBillOfLadingItemTotalTaxAmount = item.APBillOfLadingItemImportTaxAmount
                                                         + item.APBillOfLadingItemConsumptionTaxAmount
                                                         + item.APBillOfLadingItemEnviromentTaxAmount
                                                         + item.APBillOfLadingItemVATTaxAmount;
            }
            entity.BillOfLadingItemList.GridControl.RefreshDataSource();
            UpdateDocumentEntries();
        }

        public void ActionPosted()
        {
            if (!CheckLock()) return;
            BillOfLadingEntities entity = (BillOfLadingEntities)CurrentModuleEntity;
            APBillOfLadingsInfo mainObject = (APBillOfLadingsInfo)entity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            mainObject.APBillOfLadingPostedStatus = PostedTransactionStatus.Posted.ToString();
            string tableName = mainObject.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
            GLHelper.UpdatePostedStatus(this.Name, tableName, mainObject.APBillOfLadingID, PostedTransactionStatus.Posted.ToString());
            entity.SetPropertyChangeEventLock(true);
            GLHelper.PostedTransactions(this.Name, mainObject.APBillOfLadingID, ModulePostingType.Accounting);
            InvalidateToolbar();
        }

        public void ActionUnPosted()
        {
            if (!CheckLock()) return;
            BillOfLadingEntities entity = (BillOfLadingEntities)CurrentModuleEntity;
            APBillOfLadingsInfo mainObject = (APBillOfLadingsInfo)entity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            mainObject.APBillOfLadingPostedStatus = PostedTransactionStatus.UnPosted.ToString();
            string tableName = mainObject.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
            GLHelper.UpdatePostedStatus(this.Name, tableName, mainObject.APBillOfLadingID, PostedTransactionStatus.UnPosted.ToString());
            entity.SetPropertyChangeEventLock(true);
            GLHelper.UnPostedTransactions(this.Name, mainObject.APBillOfLadingID, ModulePostingType.Accounting);
            InvalidateToolbar();
        }

        private void UpdateExchangeRateInvoice()
        {
            APBillOfLadingsInfo mainObject = (APBillOfLadingsInfo)CurrentModuleEntity.MainObject;
            if (mainObject.APBillOfLadingImportExportType == BillOfLadingImportExportType.Import.ToString())
            {
                APInvoiceInsController objInvoiceInsController = new APInvoiceInsController();
                APInvoiceInsInfo objInvoiceInsInfo = (APInvoiceInsInfo)objInvoiceInsController.GetObjectByID(mainObject.FK_APInvoiceInID);
                if (objInvoiceInsInfo != null)
                {
                    objInvoiceInsInfo.APInvoiceInExchangeRate = mainObject.APBillOfLadingExchangeRate;
                    objInvoiceInsController.UpdateObject(objInvoiceInsInfo);
                    GLHelper.PostedTransactions("InvoiceIn", objInvoiceInsInfo.APInvoiceInID, ModulePostingType.Accounting, ModulePostingType.Stock, ModulePostingType.Purchase, ModulePostingType.TransitIn, ModulePostingType.InvoiceInTrans);
                }
            }
            else if (mainObject.APBillOfLadingImportExportType == BillOfLadingImportExportType.Export.ToString())
            {
                ARInvoicesController objInvoicesController = new ARInvoicesController();
                ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)objInvoicesController.GetObjectByID(mainObject.FK_ARInvoiceID);
                if (objInvoicesInfo != null)
                {
                    objInvoicesInfo.ARInvoiceExchangeRate = mainObject.APBillOfLadingExchangeRate;
                    objInvoicesController.UpdateObject(objInvoicesInfo);
                    GLHelper.PostedTransactions("Invoice", objInvoicesInfo.ARInvoiceID, ModulePostingType.Accounting, ModulePostingType.Stock, ModulePostingType.SaleOrder, ModulePostingType.InvoiceTrans);
                }
            }
        }

        public override void ModuleAfterCompleted()
        {
            BillOfLadingEntities entity = (BillOfLadingEntities)CurrentModuleEntity;
            APBillOfLadingsInfo mainObject = (APBillOfLadingsInfo)entity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            mainObject.APBillOfLadingPostedStatus = PostedTransactionStatus.Posted.ToString();
            string tableName = mainObject.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
            GLHelper.UpdatePostedStatus(this.Name, tableName, mainObject.APBillOfLadingID, PostedTransactionStatus.Posted.ToString());
            GLHelper.PostedTransactions(this.Name, mainObject.APBillOfLadingID, ModulePostingType.Accounting);
            entity.SetPropertyChangeEventLock(true);
            UpdateExchangeRateInvoice();
            base.ModuleAfterCompleted();
        }

        #region Mở chứng từ
        public override bool ActionCancelComplete()
        {
            APBillOfLadingsInfo mainObject = (APBillOfLadingsInfo)CurrentModuleEntity.MainObject;
            if (mainObject.APBillOfLadingID > 0)
            {
                if (!CheckRelativeDocument())
                {
                    return false;
                }
                if (!base.ActionCancelComplete()) return false;
                CurrentModuleEntity.SetPropertyChangeEventLock(false);
                if (mainObject.APBillOfLadingPostedStatus == PostedTransactionStatus.Posted.ToString())
                {
                    ActionUnPosted();
                }
                mainObject.APBillOfLadingStatus = ShipmentStatus.New.ToString();
                CurrentModuleEntity.UpdateMainObject();
                CurrentModuleEntity.SetPropertyChangeEventLock(true);
                
                InvalidateToolbar();
            }
            return true;
        }
        #endregion

        #region Xóa chứng từ
        public override void ActionDelete()
        {
            APBillOfLadingsInfo mainObject = (APBillOfLadingsInfo)CurrentModuleEntity.MainObject.Clone();
            if (mainObject.APBillOfLadingID > 0)
            {
                if (!CheckRelativeDocument())
                {
                    return;
                }
                if (mainObject.APBillOfLadingPostedStatus == PostedTransactionStatus.Posted.ToString())
                {
                    ActionUnPosted();
                }
                base.ActionDelete();
            }
        }
        #endregion

        private bool CheckRelativeDocument()
        {
            APBillOfLadingsInfo mainObject = (APBillOfLadingsInfo)CurrentModuleEntity.MainObject;
            ACDocumentsController objDocumentsController = new ACDocumentsController();
            List<ACDocumentsInfo> documentsList = objDocumentsController.GetRelativeDocumentListByBillOfLadingID(mainObject.APBillOfLadingID);

            if (documentsList.Count() > 0)
            {
                MessageBox.Show(string.Format("Không thể thực hiện do đã tạo các chứng từ sau:" + Environment.NewLine + "-{0}", string.Join("\n-", documentsList.Select(o => o.ACDocumentNo).ToArray()))
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public override int ActionSave()
        {
            APBillOfLadingsInfo mainObject = (APBillOfLadingsInfo)CurrentModuleEntity.MainObject;
            if(string.IsNullOrWhiteSpace(mainObject.APBillOfLadingDeclarationNumber))
            {
                MessageBox.Show("Vui lòng nhập Số tờ khai!"
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Information);
                return 0;
            }    
            return base.ActionSave();
        }
    }
}

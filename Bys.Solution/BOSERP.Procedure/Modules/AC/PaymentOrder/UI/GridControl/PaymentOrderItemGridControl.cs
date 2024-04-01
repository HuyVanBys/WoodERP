using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.PaymentOrder
{
    public partial class PaymentOrderItemGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            PaymentOrderEntities entity = (PaymentOrderEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.BankTransactionItemList;
            DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn newColumn = new GridColumn();
            newColumn.Caption = PaymentOrderLocalizedResources.ACLoanReceiptNo;
            newColumn.FieldName = "ACBankTransactionItemReference";
            newColumn.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(newColumn);

            newColumn = new GridColumn();
            newColumn.Caption = "Mã đối tượng";
            newColumn.FieldName = "ACObjectAccessKey";
            newColumn.OptionsColumn.AllowEdit = true;
            ACObjectsController objObjectsController = new ACObjectsController();
            RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
            repositoryItemLookUpEdit.DataSource = objObjectsController.GetObjectList(null, null);
            repositoryItemLookUpEdit.DisplayMember = "ACObjectNo";
            repositoryItemLookUpEdit.ValueMember = "ACObjectAccessKey";
            repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            repositoryItemLookUpEdit.NullText = string.Empty;
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACObjectNo", "Mã đối tượng"));
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACObjectName", "Tên đối tượng"));
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACObjectContactAddressLine3", "Địa chỉ"));
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACObjectTaxNumber", "MST"));
            repositoryItemLookUpEdit.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditACObjectAccessKey_QueryPopUp);
            newColumn.ColumnEdit = repositoryItemLookUpEdit;
            gridView.Columns.Add(newColumn);
        }

        protected void repositoryItemLookUpEditACObjectAccessKey_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;
            lke.Properties.DataSource = BOSApp.AccountingObjects;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridView.OptionsView.ShowFooter = true;

            GridColumn column = gridView.Columns["ACBankTransactionItemAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                InitColumnSummary("ACBankTransactionItemAmount", DevExpress.Data.SummaryItemType.Sum);
            }
            column = gridView.Columns["ACBankTransactionItemExchangeAmount"];
            if (column != null)
            {
                InitColumnSummary("ACBankTransactionItemExchangeAmount", DevExpress.Data.SummaryItemType.Sum);
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["FK_ACDebitAccountID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["FK_ACCreditAccountID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }

            column = gridView.Columns["ACBankTransactionItemDesc"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["FK_ACCostObjectID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ACCostObjectName";
                repositoryItemLookUpEdit.ValueMember = "ACCostObjectID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACCostObjectNo", "Mã"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACCostObjectName", "Tên"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACCostObjectDesc", "Mô tả"));
                repositoryItemLookUpEdit.QueryPopUp += new CancelEventHandler(repositoryItemLookUpEditACCostObject_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }
            column = gridView.Columns["ACBankTransactionItemCodeChapter"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ACBankTransactionItemCodeNDKT"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ACUnfinishedConstructionCostID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                ACUnfinishedConstructionCostsController unController = new ACUnfinishedConstructionCostsController();
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ACUnfinishedConstructionCostName";
                repositoryItemLookUpEdit.ValueMember = "ACUnfinishedConstructionCostID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                DataSet ds = BOSApp.LookupTables[TableName.ACUnfinishedConstructionCostsTableName] as DataSet;
                if (ds == null)
                {
                    ACUnfinishedConstructionCostsController objUnfinishedConstructionCostsController = new ACUnfinishedConstructionCostsController();
                    repositoryItemLookUpEdit.DataSource = objUnfinishedConstructionCostsController.GetAllObjects();
                }
                else
                {
                    repositoryItemLookUpEdit.DataSource = ds.Tables[0];
                }
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACUnfinishedConstructionCostNo", "Mã chi phí"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACUnfinishedConstructionCostName", "Tên chi phí"));
                repositoryItemLookUpEdit.QueryPopUp += new CancelEventHandler(repositoryItemLookUpEditUnfinishedConstructionCost_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }
            column = gridView.Columns["FK_ACCostCenterID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ACSegmentID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_VMVehicleID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ACBankTransactionItemTotalAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["ACBankTransactionItemTotalExchangeAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["ACBankTransactionItemVATDocumentType"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DataSource = objConfigValuesController.GetActiveConfigValuesByADConfigKeyGroup(ConfigValueGroup.InputVATDocumentType).Tables[0];
                repositoryItemLookUpEdit.DisplayMember = "Text";
                repositoryItemLookUpEdit.ValueMember = "Value";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("Text", "Loại hóa đơn"));
                repositoryItemLookUpEdit.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditACBankTransactionItemVATDocumentType_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }
            column = gridView.Columns["FK_ACEInvoiceTypeID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ACEInvoiceTypeNo";
                repositoryItemLookUpEdit.ValueMember = "ACEInvoiceTypeID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACEInvoiceTypeNo", "Mã hóa đơn GTGT"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACEInvoiceTypeTemplateCode", "Mẫu số"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACEInvoiceTypeSeries", "Kí hiệu"));
                repositoryItemLookUpEdit.QueryPopUp += new CancelEventHandler(repositoryItemLookUpEditACEInvoiceTypeNo_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
                column.Caption = "Mã hóa đơn GTGT";
            }
            column = gridView.Columns["ACBankTransactionItemVATFormNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ACBankTransactionItemVoucherNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ACBankTransactionItemInvoiceDate"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ACBankTransactionItemVATSymbol"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ACBankTransactionItemTaxNumber"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["FK_PMProjectID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ACObjectName"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ACBankTransactionItemTaxPercent"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ACBankTransactionItemTaxAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }

        protected void repositoryItemLookUpEditACCostObject_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ACCostObjectsController unController = new ACCostObjectsController();
            List<ACCostObjectsInfo> coList = unController.GetAllAliveCostObject();
            List<ACCostObjectsInfo> coListFinal = new List<ACCostObjectsInfo>();
            coListFinal.Add(new ACCostObjectsInfo());
            coListFinal.AddRange(coList);
            if (coListFinal != null && coListFinal.Count > 0)
            {
                lookUpEdit.Properties.DataSource = coListFinal;
            }
        }

        protected void repositoryItemLookUpEditUnfinishedConstructionCost_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ACUnfinishedConstructionCostsController unController = new ACUnfinishedConstructionCostsController();
            List<ACUnfinishedConstructionCostsInfo> coList = unController.GetDataForLookupEditControl();
            List<ACUnfinishedConstructionCostsInfo> coListFinal = new List<ACUnfinishedConstructionCostsInfo>();
            coListFinal.Add(new ACUnfinishedConstructionCostsInfo());
            coListFinal.AddRange(coList);
            lookUpEdit.Properties.DataSource = coListFinal;
        }

        protected void repositoryItemLookUpEditACBankTransactionItemVATDocumentType_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            lke.Properties.DataSource = objConfigValuesController.GetActiveConfigValuesByADConfigKeyGroup(ConfigValueGroup.InputVATDocumentType).Tables[0];
            lke.Properties.DisplayMember = "Text";
            lke.Properties.ValueMember = "Value";
        }

        void repositoryItemLookUpEditACEInvoiceTypeNo_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ACEInvoiceTypesController controller = new ACEInvoiceTypesController();
            List<ACEInvoiceTypesInfo> objACEInvoiceTypesInfo = controller.GetAllACEInvoiceType(InvoiceTypeCombo.Purchase.ToString());
            if (objACEInvoiceTypesInfo != null && objACEInvoiceTypesInfo.Count > 0)
            {
                lookUpEdit.Properties.DataSource = objACEInvoiceTypesInfo;
            }
        }
        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ACEInvoiceTypeID")
            {
                if (e.Value != null)
                {
                    int matchCodeID = int.Parse(e.Value.ToString());
                    ACEInvoiceTypesController controller = new ACEInvoiceTypesController();
                    ACEInvoiceTypesInfo objACEInvoiceTypesInfo = (ACEInvoiceTypesInfo)controller.GetObjectByID(matchCodeID);
                    if (objACEInvoiceTypesInfo != null)
                        e.DisplayText = objACEInvoiceTypesInfo.ACEInvoiceTypeNo;
                    else
                        e.DisplayText = "";
                }
                else
                    e.DisplayText = "";
            }
            if (e.Column.FieldName == "FK_ACUnfinishedConstructionCostID")
            {
                if (e.Value != null)
                {
                    int matchCodeID = int.Parse(e.Value.ToString());
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche(TableName.ACUnfinishedConstructionCostsTableName, "ACUnfinishedConstructionCostID", matchCodeID, "ACUnfinishedConstructionCostName");
                }
                else
                    e.DisplayText = "";
            }

            if (e.Column.FieldName == "FK_ACCostObjectID")
            {
                if (e.Value != null)
                {
                    int matchCodeID = int.Parse(e.Value.ToString());
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche(TableName.ACCostObjectsTableName, "ACCostObjectID", matchCodeID, "ACCostObjectName");
                }
                else
                    e.DisplayText = "";
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            GridView gridView = (GridView)sender;
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)(((BaseModuleERP)Screen.Module).CurrentModuleEntity).MainObject;
            ACBankTransactionItemsInfo objBankTransactionItemsInfo = (ACBankTransactionItemsInfo)gridView.GetRow(e.RowHandle);
            if (objBankTransactionItemsInfo != null)
            {
                if (gridView.FocusedColumn.FieldName == "ACBankTransactionItemAmount"
                || gridView.FocusedColumn.FieldName == "ACBankTransactionItemTaxPercent")
                {
                    ((PaymentOrderModule)Screen.Module).ChangePaymentOrderItemAmount(objBankTransactionItemsInfo);
                }
                else if (gridView.FocusedColumn.FieldName == "ACBankTransactionItemTaxAmount")
                {
                    objBankTransactionItemsInfo.ACBankTransactionItemTaxPercent = objBankTransactionItemsInfo.ACBankTransactionItemTaxAmount / objBankTransactionItemsInfo.ACBankTransactionItemAmount * 100;
                    ((PaymentOrderModule)Screen.Module).ChangePaymentOrderItemAmount(objBankTransactionItemsInfo);
                }
                else if (e.Column.FieldName == "ACObjectAccessKey")
                {
                    if (objBankTransactionItemsInfo.ACObjectAccessKey != null)
                    {
                        string[] objArr = objBankTransactionItemsInfo.ACObjectAccessKey.ToString().Split(';');
                        if (objArr.Length == 2)
                        {
                            int objectID = int.Parse(objArr[0]);
                            ACObjectsInfo objObjectsInfo = BOSApp.AccountingObjects.FirstOrDefault(o => o.ACObjectID == objectID && o.ACObjectType == objArr[1]);
                            if (objObjectsInfo != null)
                            {
                                objBankTransactionItemsInfo.FK_ACObjectID = objObjectsInfo.ACObjectID;
                                objBankTransactionItemsInfo.ACObjectType = objObjectsInfo.ACObjectType;
                                objBankTransactionItemsInfo.ACObjectName = objObjectsInfo.ACObjectName;
                                objBankTransactionItemsInfo.ACBankTransactionItemTaxNumber = objObjectsInfo.ACObjectTaxNumber;
                            }
                        }
                    }
                }
                else if (e.Column.FieldName == "FK_ACCostObjectID")
                {
                    ACCostObjectsController objCostObjectsController = new ACCostObjectsController();
                    ACCostObjectsInfo objCostObjectsInfo = (ACCostObjectsInfo)objCostObjectsController.GetObjectByID(objBankTransactionItemsInfo.FK_ACCostObjectID);
                    if (objCostObjectsInfo != null && objCostObjectsInfo.FK_ACDepreciationWaitAccountID > 0)
                    {
                        objBankTransactionItemsInfo.FK_ACDebitAccountID = objCostObjectsInfo.FK_ACDepreciationWaitAccountID;
                    }
                }
                else if (e.Column.FieldName == "FK_ACUnfinishedConstructionCostID")
                {
                    ACUnfinishedConstructionCostsController objUnfinishedConstructionCostsController = new ACUnfinishedConstructionCostsController();
                    ACUnfinishedConstructionCostsInfo objUnfinishedConstructionCostsInfo = (ACUnfinishedConstructionCostsInfo)objUnfinishedConstructionCostsController.GetObjectByID(objBankTransactionItemsInfo.FK_ACUnfinishedConstructionCostID);
                    if (objUnfinishedConstructionCostsInfo != null)
                    {
                        objBankTransactionItemsInfo.FK_ACDebitAccountID = objUnfinishedConstructionCostsInfo.FK_ACAccountID;
                    }
                }
                else if (e.Column.FieldName == "FK_ACSegmentID")
                {
                    if (mainObject.STToolbarActionName == "NewfromManual" && objBankTransactionItemsInfo.FK_ACSegmentID > 0)
                    {
                        ACSegmentsController objSegmentsController = new ACSegmentsController();
                        ACSegmentsInfo objSegmentsInfo = (ACSegmentsInfo)objSegmentsController.GetObjectByID(objBankTransactionItemsInfo.FK_ACSegmentID);
                        if (objSegmentsInfo != null && objSegmentsInfo.FK_ACDepreciationCostAccountID > 0)
                        {
                            objBankTransactionItemsInfo.FK_ACDebitAccountID = objSegmentsInfo.FK_ACDepreciationCostAccountID;
                        }
                    }
                }
                else if (e.Column.FieldName == "FK_ACEInvoiceTypeID")
                {
                    ACEInvoiceTypesController objEInvoiceTypesController = new ACEInvoiceTypesController();
                    ACEInvoiceTypesInfo objEInvoiceTypesInfo = (ACEInvoiceTypesInfo)objEInvoiceTypesController.GetObjectByID(objBankTransactionItemsInfo.FK_ACEInvoiceTypeID);
                    if (objEInvoiceTypesInfo != null)
                    {
                        objBankTransactionItemsInfo.ACBankTransactionItemVATFormNo = objEInvoiceTypesInfo.ACEInvoiceTypeTemplateCode;
                        objBankTransactionItemsInfo.ACBankTransactionItemVATSymbol = objEInvoiceTypesInfo.ACEInvoiceTypeSeries;
                    }
                    else
                    {
                        objBankTransactionItemsInfo.ACBankTransactionItemVATFormNo = string.Empty;
                        objBankTransactionItemsInfo.ACBankTransactionItemVATSymbol = string.Empty;
                    }
                }
                else if (e.Column.FieldName == "ACBankTransactionItemExchangeAmount")
                {
                    objBankTransactionItemsInfo.ACBankTransactionItemAmount = objBankTransactionItemsInfo.ACBankTransactionItemExchangeAmount / (mainObject.ACBankTransactionExchangeRate == 0 ? 1 : mainObject.ACBankTransactionExchangeRate);
                    ((PaymentOrderModule)Screen.Module).ChangePaymentOrderItemAmount(objBankTransactionItemsInfo);
                }
            }

        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((PaymentOrderModule)Screen.Module).RemoveSelectedItem();
            }
        }

        protected override void GridView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            base.GridView_ValidatingEditor(sender, e);

            GridView gridView = (GridView)sender;
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)(((BaseModuleERP)Screen.Module).CurrentModuleEntity).MainObject;
            if (gridView.FocusedColumn.FieldName == "FK_ACDebitAccountID" || gridView.FocusedColumn.FieldName == "FK_ACCreditAccountID")
            {
                ACAccountsController objAccountsController = new ACAccountsController();
                ACAccountsInfo account = objAccountsController.GetAccountByID(Convert.ToInt32(e.Value));
                if (account != null && account.HasChildAccount)
                {
                    e.ErrorText = CommonLocalizedResources.CannotMakeEntryWithParentAccountMessage;
                    e.Valid = false;
                }
            }
        }

        private void repositoryLookupEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ACAccountsController objAccountsController = new ACAccountsController();
            lookUpEdit.Properties.DataSource = objAccountsController.GetListAccountNotChild().Tables[0];
        }

        protected override void GridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            base.GridView_InitNewRow(sender, e);
            PaymentOrderEntities entity = (PaymentOrderEntities)(((BaseModuleERP)Screen.Module).CurrentModuleEntity);
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)entity.MainObject;
            CSCompanyBanksController objCompanyBanksController = new CSCompanyBanksController();
            CSCompanyBanksInfo objCompanyBanksInfo = (CSCompanyBanksInfo)objCompanyBanksController.GetObjectByID(mainObject.FK_CSCompanyBankID);

            GridView gridView = (GridView)sender;
            ACBankTransactionItemsInfo objBankTransactionItemsInfo = (ACBankTransactionItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            objBankTransactionItemsInfo.ACBankTransactionItemDesc = mainObject.ACBankTransactionDesc;
            if (objCompanyBanksInfo != null)
            {
                objBankTransactionItemsInfo.FK_ACCreditAccountID = objCompanyBanksInfo.FK_ACAcountID;
            }
            ACObjectsInfo objObjectsInfo = BOSApp.AccountingObjects.FirstOrDefault(o => o.ACObjectID == mainObject.FK_ACObjectID && o.ACObjectType == mainObject.ACObjectType);
            if (objObjectsInfo != null && objObjectsInfo.FK_ACAccountPurchaseID > 0)
            {
                objBankTransactionItemsInfo.FK_ACDebitAccountID = objObjectsInfo.FK_ACAccountPurchaseID;
            }

            gridView.SetRowCellValue(e.RowHandle, "ACBankTransactionItemInvoiceDate", BOSApp.GetCurrentServerDate());
            gridView.SetRowCellValue(e.RowHandle, "ACObjectAccessKey", mainObject.ACObjectAccessKey);
        }
    }
}

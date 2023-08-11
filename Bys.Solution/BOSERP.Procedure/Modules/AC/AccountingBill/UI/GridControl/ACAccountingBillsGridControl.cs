using BOSCommon;
using BOSLib;
using BOSCommon.Constants;
using BOSComponent;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.AccountingBill
{
    public partial class ACAccountingBillsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            AccountingBillEntities entity = (AccountingBillEntities)(((BaseModuleERP)Screen.Module).CurrentModuleEntity);
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.AccountingBillsList;
            DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            ACObjectsController objObjectsController = new ACObjectsController();
            GridColumn newColumn = new GridColumn();
            newColumn.Caption = "Đối tượng nợ";
            newColumn.FieldName = "ACObjectAccessKey";
            newColumn.OptionsColumn.AllowEdit = true;
            RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
            repositoryItemLookUpEdit.DataSource = BOSApp.AccountingObjects; //objObjectsController.GetObjectList(null, null);
            repositoryItemLookUpEdit.DisplayMember = "ACObjectName";
            repositoryItemLookUpEdit.ValueMember = "ACObjectAccessKey";
            repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest;
            repositoryItemLookUpEdit.NullText = string.Empty;
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACObjectNo", "Mã đối tượng"));
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACObjectName", "Tên đối tượng"));
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACObjectContactAddressLine3", "Địa chỉ"));
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACObjectTaxNumber", "MST"));
            repositoryItemLookUpEdit.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditACObjectAccessKey_QueryPopUp);
            newColumn.ColumnEdit = repositoryItemLookUpEdit;
            gridView.Columns.Add(newColumn);

            newColumn = new GridColumn();
            newColumn.Caption = "Đối tượng có";
            newColumn.FieldName = "ACObjectCreditAccessKey";
            newColumn.OptionsColumn.AllowEdit = true;
            repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
            repositoryItemLookUpEdit.DataSource = BOSApp.AccountingObjects;  //objObjectsController.GetObjectList(null, null);
            repositoryItemLookUpEdit.DisplayMember = "ACObjectName";
            repositoryItemLookUpEdit.ValueMember = "ACObjectAccessKey";
            repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest;
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

            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            GridColumn column1 = gridView.Columns["FK_ACCostObjectID"];
            if (column1 != null)
            {
                column1.OptionsColumn.AllowEdit = true;
                DataSet ds = BOSApp.LookupTables[TableName.ACCostObjectsTableName] as DataSet;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ACCostObjectName";
                repositoryItemLookUpEdit.ValueMember = "ACCostObjectID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACCostObjectNo", "Mã"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACCostObjectName", "Tên"));
                if (ds == null)
                {
                    ACCostObjectsController objCostObjectsController = new ACCostObjectsController();
                    repositoryItemLookUpEdit.DataSource = objCostObjectsController.GetAllAliveCostObject();
                }
                else
                {
                    repositoryItemLookUpEdit.DataSource = ds.Tables[0];
                }
                repositoryItemLookUpEdit.QueryPopUp += new CancelEventHandler(repositoryItemLookUpEdit_QueryPopUp);
                column1.ColumnEdit = repositoryItemLookUpEdit;
            }
            column1 = gridView.Columns["FK_ACUnfinishedConstructionCostID"];
            if (column1 != null)
            {
                column1.OptionsColumn.AllowEdit = true;                
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ACUnfinishedConstructionCostName";
                repositoryItemLookUpEdit.ValueMember = "ACUnfinishedConstructionCostID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACUnfinishedConstructionCostNo", "Mã"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACUnfinishedConstructionCostName", "Tên"));
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
                repositoryItemLookUpEdit.QueryPopUp += new CancelEventHandler(repositoryItemUnfinishedLookUpEdit_QueryPopUp);
                column1.ColumnEdit = repositoryItemLookUpEdit;
            }

            ACAccountsController objAccountsController = new ACAccountsController();

            column1 = gridView.Columns["FK_ACCreditAccountID"];
            if (column1 != null)
            {
                column1.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ACAccountNo";
                repositoryItemLookUpEdit.ValueMember = "ACAccountID";
                repositoryItemLookUpEdit.DataSource = objAccountsController.GetListAccountNotChild().Tables[0];
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACAccountNo", "TK có"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACAccountName", "Tên tk có"));
                repositoryItemLookUpEdit.QueryPopUp += new CancelEventHandler(repositoryItemAccountLookUpEdit_QueryPopUp);
                column1.ColumnEdit = repositoryItemLookUpEdit;
            }

            column1 = gridView.Columns["FK_ACDebitAccountID"];
            if (column1 != null)
            {
                column1.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ACAccountNo";
                repositoryItemLookUpEdit.ValueMember = "ACAccountID";
                repositoryItemLookUpEdit.DataSource = objAccountsController.GetListAccountNotChild().Tables[0];
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACAccountNo", "TK nợ"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACAccountName", "Tên tk nợ"));
                repositoryItemLookUpEdit.QueryPopUp += new CancelEventHandler(repositoryItemAccountLookUpEdit_QueryPopUp);
                column1.ColumnEdit = repositoryItemLookUpEdit;
            }

            column1 = gridView.Columns["ACAccountingBillTaxAmount"];
            if (column1 != null)
            {
                column1.OptionsColumn.AllowEdit = true;
            }

            column1 = gridView.Columns["ACAccountingBillTotalAmount"];
            if (column1 != null)
            {
                column1.OptionsColumn.AllowEdit = false;
            }

            column1 = gridView.Columns["ACAccountingBillExchangeAmount"];
            if (column1 != null)
            {
                column1.OptionsColumn.AllowEdit = true;
            }

            column1 = gridView.Columns["FK_ICProductID"];
            if (column1 != null)
            {
                column1.OptionsColumn.AllowEdit = true;
                DataSet ds = BOSApp.LookupTables[TableName.ICProductsTableName] as DataSet;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ICProductNo";
                repositoryItemLookUpEdit.ValueMember = "ICProductID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductNo", "Mã sản phẩm"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductName", "Tên sản phẩm"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductDesc", "Mô tả"));
                if (ds == null)
                {
                    ICProductsController objProductsController = new ICProductsController();
                    repositoryItemLookUpEdit.DataSource = objProductsController.GetAllProductsForLookupControl(BOSApp.CurrentCompanyInfo.CSCompanyID);
                }
                else
                {
                    repositoryItemLookUpEdit.DataSource = ds.Tables[0];
                }
                repositoryItemLookUpEdit.QueryPopUp += new CancelEventHandler(repositoryItemProductLookUpEdit_QueryPopUp);
                column1.ColumnEdit = repositoryItemLookUpEdit;
            }
            column1 = gridView.Columns["FK_ACEInvoiceTypeID"];
            if (column1 != null)
            {
                column1.OptionsColumn.AllowEdit = true;
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
                column1.ColumnEdit = repositoryItemLookUpEdit;
                column1.Caption = "Mã hóa đơn GTGT";
            }
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);

            return gridView;
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
        void repositoryItemLookUpEdit_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;

            ACCostObjectsController coController = new ACCostObjectsController();
            List<ACCostObjectsInfo> coList = coController.GetAllAliveCostObject();
            List<ACCostObjectsInfo> coListFinal = new List<ACCostObjectsInfo>();
            coListFinal.Add(new ACCostObjectsInfo());
            coListFinal.AddRange(coList);

            lookUpEdit.Properties.DataSource = coListFinal;

            lookUpEdit.Properties.DisplayMember = "ACCostObjectName";
            lookUpEdit.Properties.ValueMember = "ACCostObjectID";
        }

        void repositoryItemUnfinishedLookUpEdit_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;

            ACUnfinishedConstructionCostsController unController = new ACUnfinishedConstructionCostsController();
            List<ACUnfinishedConstructionCostsInfo> coList = unController.GetDataNewStatusForLookupEditControl();
            List<ACUnfinishedConstructionCostsInfo> coListFinal = new List<ACUnfinishedConstructionCostsInfo>();
            coListFinal.Add(new ACUnfinishedConstructionCostsInfo());
            coListFinal.AddRange(coList);

            lookUpEdit.Properties.DataSource = coListFinal;
            lookUpEdit.Properties.DisplayMember = "ACUnfinishedConstructionCostName";
            lookUpEdit.Properties.ValueMember = "ACUnfinishedConstructionCostID";
        }

        void repositoryItemAccountLookUpEdit_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookup = (LookUpEdit)sender;
            DataSet ds = (DataSet)BOSApp.LookupTables["ACAccounts"];

            ACAccountsController objAccountsController = new ACAccountsController();
            List<ACAccountsInfo> AccountList = new List<ACAccountsInfo>();
            if (ds.Tables[0].Rows.Count > 0)
            {
                AccountList = (List<ACAccountsInfo>)objAccountsController.GetListFromDataSet(ds);
            }
            else
                AccountList = objAccountsController.GetListAccountForShowIdentifyMenu();
            lookup.Properties.DataSource = AccountList;
            lookup.Properties.DisplayMember = "ACAccountNo";
            lookup.Properties.ValueMember = "ACAccountID";
        }

        void repositoryItemProductLookUpEdit_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookup = (LookUpEdit)sender;
            ICProductsController objProductsController = new ICProductsController();
            DataSet ds = BOSApp.LookupTables[TableName.ICProductsTableName] as DataSet;
            if (ds == null)
            {
                ds = objProductsController.GetAllProductsForLookupControl(BOSApp.CurrentCompanyInfo.CSCompanyID);
            }
            lookup.Properties.DataSource = (List<ICProductsInfo>)objProductsController.GetListFromDataSet(ds);
            lookup.Properties.DisplayMember = "ICProductNo";
            lookup.Properties.ValueMember = "ICProductID";
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            AccountingBillEntities entity = (AccountingBillEntities)(((BaseModuleERP)Screen.Module).CurrentModuleEntity);
            AccountingBillModule module = (AccountingBillModule)entity.Module;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            GridView gridView = (GridView)sender;
            ACAccountingBillsInfo item = (ACAccountingBillsInfo)gridView.GetRow(e.RowHandle);
            if (item != null)
            {
                if (e.Column.FieldName == "ACObjectAccessKey")
                {
                    // Đối tượng nợ
                    if (item.ACObjectAccessKey != null)
                    {
                        string[] objArr = item.ACObjectAccessKey.ToString().Split(';');
                        if (objArr.Length == 2)
                        {
                            int objectID = int.Parse(objArr[0]);
                            ACObjectsInfo objObjectsInfo = BOSApp.AccountingObjects.FirstOrDefault(o => o.ACObjectID == objectID && o.ACObjectType == objArr[1]);
                            if (objObjectsInfo != null)
                            {
                                item.FK_ACDebitObjectID = objObjectsInfo.ACObjectID;
                                item.ACDebitObjectType = objObjectsInfo.ACObjectType;
                                item.ACDebitObjectName = objObjectsInfo.ACObjectName;
                                item.ACAccountingBillTaxNumber = objObjectsInfo.ACObjectTaxNumber;
                            }
                        }
                    }
                }
                else if (e.Column.FieldName == "ACObjectCreditAccessKey")
                {
                    if(item.ACObjectCreditAccessKey != null)
                    {
                        string[] objArr = item.ACObjectCreditAccessKey.ToString().Split(';');
                        if (objArr.Length == 2)
                        {
                            int objectID = int.Parse(objArr[0]);
                            ACObjectsInfo objObjectsInfo = BOSApp.AccountingObjects.FirstOrDefault(o => o.ACObjectID == objectID && o.ACObjectType == objArr[1]);
                            if (objObjectsInfo != null)
                            {
                                item.FK_ACCreditObjectID = objObjectsInfo.ACObjectID;
                                item.ACCreditObjectType = objObjectsInfo.ACObjectType;
                                item.ACCreditObjectName = objObjectsInfo.ACObjectName;
                            }
                        }
                    }
                }
                else if (e.Column.FieldName == "ACAccountingBillTaxPercent" || e.Column.FieldName == "ACAccountingBillAmount")
                {
                    STFieldFormatGroupsInfo formatsInfo = ((BaseModuleERP)Screen.Module).GetColumnFormat("ACAccountingBills", "ACAccountingBillTaxAmount", this.Screen.Module.ModuleID);
                    int formatGroupDecimalRound = formatsInfo != null ? formatsInfo.STFieldFormatGroupDecimalRound : 0;
                    // Tiền thuế = Số tiền * % thuế
                    item.ACAccountingBillTaxAmount = Math.Round(item.ACAccountingBillAmount * item.ACAccountingBillTaxPercent / 100, formatGroupDecimalRound);
                    BOSApp.RoundByCurrency(mainObject, "ACRetailVATTaxAmount", mainObject.FK_GECurrencyID);
                    ((AccountingBillModule)Screen.Module).UpdateAccountingBillList();
                }
                else if (e.Column.FieldName == "ACAccountingBillTaxAmount")
                {
                    ((AccountingBillModule)Screen.Module).UpdateAccountingBillList();
                }
                else if (e.Column.FieldName == "FK_ACCostObjectID")
                {
                    ACCostObjectsController objCostObjectsController = new ACCostObjectsController();
                    ACCostObjectsInfo objCostObjectsInfo = (ACCostObjectsInfo)objCostObjectsController.GetObjectByID(item.FK_ACCostObjectID);
                    if (objCostObjectsInfo != null && objCostObjectsInfo.FK_ACDepreciationWaitAccountID > 0)
                    {
                        item.FK_ACDebitAccountID = objCostObjectsInfo.FK_ACDepreciationWaitAccountID;
                    }
                }

                else if (e.Column.FieldName == "FK_ACUnfinishedConstructionCostID")
                {
                    ACUnfinishedConstructionCostsController objUnfinishedConstructionCostsController = new ACUnfinishedConstructionCostsController();
                    ACUnfinishedConstructionCostsInfo objUnfinishedConstructionCostsInfo = (ACUnfinishedConstructionCostsInfo)objUnfinishedConstructionCostsController.GetObjectByID(item.FK_ACUnfinishedConstructionCostID);
                    if (objUnfinishedConstructionCostsInfo != null)
                    {
                        item.FK_ACDebitAccountID = objUnfinishedConstructionCostsInfo.FK_ACAccountID;
                    }
                }
                else if (e.Column.FieldName == "FK_ACEInvoiceTypeID")
                {
                    ACEInvoiceTypesController objEInvoiceTypesController = new ACEInvoiceTypesController();
                    ACEInvoiceTypesInfo objEInvoiceTypesInfo = (ACEInvoiceTypesInfo)objEInvoiceTypesController.GetObjectByID(item.FK_ACEInvoiceTypeID);
                    if (objEInvoiceTypesInfo != null)
                    {
                        item.ACAccountingBillVATFormNo = objEInvoiceTypesInfo.ACEInvoiceTypeTemplateCode;
                        item.ACAccountingBillVATSymbol = objEInvoiceTypesInfo.ACEInvoiceTypeSeries;
                    }
                    else
                    {
                        item.ACAccountingBillVATFormNo = string.Empty;
                        item.ACAccountingBillVATSymbol = string.Empty;
                    }
                    entity.UpdateMainObjectBindingSource();
                }
                BOSApp.RoundByCurrency(item, "ACAccountingBillExchangeAmount", mainObject.FK_GECurrencyID);
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((AccountingBillModule)Screen.Module).RemoveSelectedAccountingBill();
            }
        }

        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ACAssetID")
            {
                if (e.Value != null)
                {
                    int assetID = int.Parse(e.Value.ToString());
                    ACAssetsController objAssetsController = new ACAssetsController();
                    ACAssetsInfo objAssetsInfo = new ACAssetsInfo();
                    objAssetsInfo = (ACAssetsInfo)objAssetsController.GetObjectByID(assetID);
                    if (objAssetsInfo != null)
                    {
                        e.DisplayText = objAssetsInfo.ACAssetNo;
                    }
                }
            }
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
        }

        protected override void GridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            base.GridView_InitNewRow(sender, e);
            AccountingBillEntities entity = (AccountingBillEntities)(((BaseModuleERP)Screen.Module).CurrentModuleEntity);
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            GridView gridView = (GridView)sender;
            ACAccountingBillsInfo objAccountingBillsInfo = (ACAccountingBillsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            objAccountingBillsInfo.ACAccountingBillDesc = mainObject.ACDocumentDesc;
            gridView.SetRowCellValue(e.RowHandle, "ACAccountingBillInvoiceDate", BOSApp.GetCurrentServerDate());
            gridView.SetRowCellValue(e.RowHandle, "ACObjectAccessKey", mainObject.ACObjectAccessKey);
            gridView.SetRowCellValue(e.RowHandle, "FK_ACSegmentID", mainObject.FK_ACSegmentID);
        }
    }
}

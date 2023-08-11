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
using System.Windows.Forms;
using System.Linq;
using System.Data;

namespace BOSERP.Modules.PaymentVoucher
{
    public partial class APPaymentVoucherItemsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            PaymentVoucherEntities entity = (PaymentVoucherEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.PaymentVoucherItemList;
            DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn newColumn = new GridColumn();
            newColumn.Caption = PaymentVoucherLocalizedResources.Reference;
            newColumn.FieldName = "APPaymentVoucherItemReference";
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

        protected void repositoryItemLookUpEditUnfinishedConstructionCost_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ACUnfinishedConstructionCostsController unController = new ACUnfinishedConstructionCostsController();
            List<ACUnfinishedConstructionCostsInfo> coList = unController.GetDataForLookupEditControl();
            List<ACUnfinishedConstructionCostsInfo> coListFinal = new List<ACUnfinishedConstructionCostsInfo>();
            coListFinal.Add(new ACUnfinishedConstructionCostsInfo());
            coListFinal.AddRange(coList);
            lookUpEdit.Properties.DataSource = coListFinal;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridView.OptionsView.ShowFooter = true;
            
            GridColumn column = gridView.Columns["APPaymentVoucherItemAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                InitColumnSummary("APPaymentVoucherItemAmount", DevExpress.Data.SummaryItemType.Sum);
            }
            column = gridView.Columns["APPaymentVoucherItemExchangeAmount"];
            if (column != null)
            {
                InitColumnSummary("APPaymentVoucherItemExchangeAmount", DevExpress.Data.SummaryItemType.Sum);
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
            column = gridView.Columns["APPaymentVoucherItemDesc"];
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
            column = gridView.Columns["FK_ACSegmentID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ACCostCenterID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_VMVehicleID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["APPaymentVoucherItemTotalAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["APPaymentVoucherItemTotalExchangeAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["APPaymentVoucherItemVATDocumentType"];
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
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditAPPaymentVoucherItemVATDocumentType_QueryPopUp);
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
            column = gridView.Columns["APPaymentVoucherItemVATFormNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["APPaymentVoucherItemVoucherNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["APPaymentVoucherItemInvoiceDate"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["APPaymentVoucherItemVATSymbol"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["APPaymentVoucherItemTaxNumber"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["FK_PMProjectID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["APObjectName"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }

        void repositoryItemLookUpEditACCostObject_QueryPopUp(object sender, CancelEventArgs e)
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
        protected void repositoryItemLookUpEditAPPaymentVoucherItemVATDocumentType_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            lke.Properties.DataSource = objConfigValuesController.GetActiveConfigValuesByADConfigKeyGroup(ConfigValueGroup.InputVATDocumentType).Tables[0];
            lke.Properties.DisplayMember = "Text";
            lke.Properties.ValueMember = "Value";
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
        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ACEInvoiceTypeID")
            {
                if (e.Value != null)
                {
                    int id = int.Parse(e.Value.ToString());
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche(TableName.ACEInvoiceTypesTableName, "ACEInvoiceTypeID", id, "ACEInvoiceTypeNo");
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
            GridView gridView = (GridView)MainView;
            APPaymentVouchersInfo mainObject = (APPaymentVouchersInfo)(((BaseModuleERP)Screen.Module).CurrentModuleEntity).MainObject;
            APPaymentVoucherItemsInfo objPaymentVoucherItemsInfo = (APPaymentVoucherItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (objPaymentVoucherItemsInfo != null)
            {
                if (gridView.FocusedColumn.FieldName == "APPaymentVoucherItemAmount"
                    || gridView.FocusedColumn.FieldName == "APPaymentVoucherItemTaxPercent")
                {
                    ((PaymentVoucherModule)Screen.Module).ChangePaymentVoucherItemAmount(objPaymentVoucherItemsInfo);
                }
                else if (gridView.FocusedColumn.FieldName == "APPaymentVoucherItemTaxAmount")
                {
                    objPaymentVoucherItemsInfo.APPaymentVoucherItemTaxPercent = Convert.ToInt32(objPaymentVoucherItemsInfo.APPaymentVoucherItemTaxAmount / objPaymentVoucherItemsInfo.APPaymentVoucherItemAmount * 100);
                    ((PaymentVoucherModule)Screen.Module).ChangePaymentVoucherItemAmount(objPaymentVoucherItemsInfo);
                }
                else if (gridView.FocusedColumn.FieldName == "FK_ACCostObjectID")
                {
                    ACCostObjectsController objCostObjectsController = new ACCostObjectsController();
                    ACCostObjectsInfo objCostObjectsInfo = (ACCostObjectsInfo)objCostObjectsController.GetObjectByID(objPaymentVoucherItemsInfo.FK_ACCostObjectID);
                    if (objCostObjectsInfo != null)
                    {
                        objPaymentVoucherItemsInfo.FK_ACDebitAccountID = objCostObjectsInfo.FK_ACDepreciationWaitAccountID;
                    }
                }
                else if (e.Column.FieldName == "ACObjectAccessKey")
                {
                    if (objPaymentVoucherItemsInfo.ACObjectAccessKey != null)
                    {
                        string[] objArr = objPaymentVoucherItemsInfo.ACObjectAccessKey.ToString().Split(';');
                        if (objArr.Length == 2)
                        {
                            int objectID = int.Parse(objArr[0]);
                            ACObjectsController objectController = new ACObjectsController();
                            ACObjectsInfo objObjectsInfo = objectController.GetObjectByIDAndType(objectID, objArr[1]);
                            if (objObjectsInfo != null)
                            {
                                objPaymentVoucherItemsInfo.FK_ACObjectID = objObjectsInfo.ACObjectID;
                                objPaymentVoucherItemsInfo.APObjectType = objObjectsInfo.ACObjectType;
                                objPaymentVoucherItemsInfo.APObjectName = objObjectsInfo.ACObjectName;
                                objPaymentVoucherItemsInfo.APPaymentVoucherItemTaxNumber = objObjectsInfo.ACObjectTaxNumber;
                            }
                        }
                    }
                }
                else if (e.Column.FieldName == "FK_ACUnfinishedConstructionCostID")
                {
                    ACUnfinishedConstructionCostsController objUnfinishedConstructionCostsController = new ACUnfinishedConstructionCostsController();
                    ACUnfinishedConstructionCostsInfo objUnfinishedConstructionCostsInfo = (ACUnfinishedConstructionCostsInfo)objUnfinishedConstructionCostsController.GetObjectByID(objPaymentVoucherItemsInfo.FK_ACUnfinishedConstructionCostID);
                    if (objUnfinishedConstructionCostsInfo != null)
                    {
                        objPaymentVoucherItemsInfo.FK_ACDebitAccountID = objUnfinishedConstructionCostsInfo.FK_ACAccountID;
                    }
                }
                else if (e.Column.FieldName == "FK_ACSegmentID")
                {
                    if (mainObject.STToolbarActionName == "NewNormal" && objPaymentVoucherItemsInfo.FK_ACSegmentID > 0)
                    {
                        ACSegmentsController objSegmentsController = new ACSegmentsController();
                        ACSegmentsInfo objSegmentsInfo = (ACSegmentsInfo)objSegmentsController.GetObjectByID(objPaymentVoucherItemsInfo.FK_ACSegmentID);
                        if (objSegmentsInfo != null && objSegmentsInfo.FK_ACDepreciationCostAccountID > 0)
                        {
                            objPaymentVoucherItemsInfo.FK_ACDebitAccountID = objSegmentsInfo.FK_ACDepreciationCostAccountID;
                        }
                    }
                }
                else if (e.Column.FieldName == "FK_ACEInvoiceTypeID")
                {
                    ACEInvoiceTypesController objEInvoiceTypesController = new ACEInvoiceTypesController();
                    ACEInvoiceTypesInfo objEInvoiceTypesInfo = (ACEInvoiceTypesInfo)objEInvoiceTypesController.GetObjectByID(objPaymentVoucherItemsInfo.FK_ACEInvoiceTypeID);
                    if (objEInvoiceTypesInfo != null)
                    {
                        objPaymentVoucherItemsInfo.APPaymentVoucherItemVATFormNo = objEInvoiceTypesInfo.ACEInvoiceTypeTemplateCode;
                        objPaymentVoucherItemsInfo.APPaymentVoucherItemVATSymbol = objEInvoiceTypesInfo.ACEInvoiceTypeSeries;
                    }
                    else
                    {
                        objPaymentVoucherItemsInfo.APPaymentVoucherItemVATFormNo = string.Empty;
                        objPaymentVoucherItemsInfo.APPaymentVoucherItemVATSymbol = string.Empty;
                    }
                }
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((PaymentVoucherModule)Screen.Module).RemoveSelectedItem();
            }
        }

        protected override void GridView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            base.GridView_ValidatingEditor(sender, e);

            GridView gridView = (GridView)sender;
            APPaymentVouchersInfo mainObject = (APPaymentVouchersInfo)(((BaseModuleERP)Screen.Module).CurrentModuleEntity).MainObject;
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
            lookUpEdit.Properties.DisplayMember = "ACAccountNo";
            lookUpEdit.Properties.ValueMember = "ACAccountID";
        }

        protected override void GridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            base.GridView_InitNewRow(sender, e);
            PaymentVoucherEntities entity = (PaymentVoucherEntities)(((BaseModuleERP)Screen.Module).CurrentModuleEntity);
            APPaymentVouchersInfo mainObject = (APPaymentVouchersInfo)entity.MainObject;
            GridView gridView = (GridView)sender;
            APPaymentVoucherItemsInfo objPaymentVoucherItemsInfo = (APPaymentVoucherItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            objPaymentVoucherItemsInfo.APPaymentVoucherItemDesc = mainObject.APPaymentVoucherDesc;
            CSCashFundsInfo objCSCashFundsInfo = (CSCashFundsInfo)(new CSCashFundsController()).GetObjectByID(mainObject.FK_CSCashFundID);
            if (objCSCashFundsInfo != null && objCSCashFundsInfo.FK_ACAcountID > 0)
            {
                objPaymentVoucherItemsInfo.FK_ACCreditAccountID = objCSCashFundsInfo.FK_ACAcountID;
            }
            ACObjectsInfo objObjectsInfo = BOSApp.AccountingObjects.FirstOrDefault(o => o.ACObjectID == mainObject.FK_ACObjectID && o.ACObjectType == mainObject.APObjectType);
            if(objObjectsInfo != null && objObjectsInfo.FK_ACAccountPurchaseID > 0)
            {
                objPaymentVoucherItemsInfo.FK_ACDebitAccountID = objObjectsInfo.FK_ACAccountPurchaseID;
            }    
            gridView.SetRowCellValue(e.RowHandle, "APPaymentVoucherItemInvoiceDate", BOSApp.GetCurrentServerDate());
            gridView.SetRowCellValue(e.RowHandle, "ACObjectAccessKey", mainObject.ACObjectAccessKey);
        }
    }
}

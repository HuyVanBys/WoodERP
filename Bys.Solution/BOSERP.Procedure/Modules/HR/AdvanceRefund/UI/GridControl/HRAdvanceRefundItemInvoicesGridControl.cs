using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.AdvanceRefund
{
    public class HRAdvanceRefundItemInvoicesGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            AdvanceRefundEntities entity = (AdvanceRefundEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.HRAdvanceRefundItemInvoiceHasInvoiceList;
            this.DataSource = bds;
        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();

            GridColumn column = gridView.Columns["FK_ACDebitAccountID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
                DataSet ds = BOSApp.LookupTables[TableName.ACAccountsTableName] as DataSet;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ACAccountNo";
                repositoryItemLookUpEdit.ValueMember = "ACAccountID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACAccountNo", "Mã tài khoản"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACAccountName", "Tên tài khoản"));
                if (ds == null)
                {
                    ACAccountsController objAccountsController = new ACAccountsController();
                    repositoryItemLookUpEdit.DataSource = objAccountsController.GetAllAccountList();
                }
                else
                {
                    repositoryItemLookUpEdit.DataSource = ds.Tables[0];
                }
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEdit_QueryPopUp1);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }

            column = gridView.Columns["FK_ACUnfinishedConstructionCostID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ACUnfinishedConstructionCostName";
                repositoryItemLookUpEdit.ValueMember = "ACUnfinishedConstructionCostID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACUnfinishedConstructionCostNo", "Mã chứng từ"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACUnfinishedConstructionCostName", "Tên chứng từ"));
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemUnfinishedLookUpEdit_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }
            column = gridView.Columns["HRAdvanceRefundItemInvoiceSubTotalAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["HRAdvanceRefundItemInvoiceTaxAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["HRAdvanceRefundItemInvoiceTotalAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["HRAdvanceRefundItemInvoiceObjectName"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["HRAdvanceRefundItemInvoiceTaxPercent"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["HRAdvanceRefundItemInvoiceVATDate"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["FK_VMVehicleID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "VMVehicleNoPlate";
                repositoryItemLookUpEdit.ValueMember = "VMVehicleID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("VMVehicleNo", CommonLocalizedResources.VMVehicleNo));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("VMVehicleName", CommonLocalizedResources.VMVehicleName));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("VMVehicleNoPlate", CommonLocalizedResources.VMVehicleNoPlate));
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditVehicle_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }

            return gridView;
        }
        void repositoryItemLookUpEdit_QueryPopUp1(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;

            ACAccountsController accountController = new ACAccountsController();
            List<ACAccountsInfo> accountList = accountController.GetAllAccountList();

            lke.Properties.DataSource = accountList;

        }


        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn newColumn = new GridColumn();
            newColumn.Caption = "Mã NCC";
            newColumn.FieldName = "ACObjectAccessKey";
            newColumn.OptionsColumn.AllowEdit = true;
            RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
            repositoryItemLookUpEdit.DisplayMember = "ACObjectNo";
            repositoryItemLookUpEdit.ValueMember = "ACObjectAccessKey";
            repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            repositoryItemLookUpEdit.NullText = string.Empty;
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACObjectNo", "Mã NCC"));
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACObjectName", "Tên NCC"));
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACObjectContactAddressLine3", "Địa chỉ"));
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACObjectContactTaxCode", "MST"));
            repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEdit_QueryPopUp);
            newColumn.ColumnEdit = repositoryItemLookUpEdit;
            gridView.Columns.Add(newColumn);

            newColumn = new GridColumn();
            newColumn.Caption = "Mã chứng từ";
            newColumn.FieldName = "HRAdvanceRefundItemInvoiceDocumentNo";
            newColumn.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(newColumn);

            foreach (GridColumn column in gridView.Columns)
            {
                if (column.FieldName != "HRAdvanceRefundItemInvoiceTotalAmount" && column.FieldName != "HRAdvanceRefundItemInvoiceDocumentNo")
                {
                    column.OptionsColumn.AllowEdit = true;
                }

            }
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(gridView_ValidateRow);
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
        }

        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Value != null
                && e.Column.FieldName == "ACObjectAccessKey")
            {


                string[] objArr = e.Value.ToString().Split(';');
                if (objArr.Length == 2)
                {
                    int objectID = int.Parse(objArr[0]);
                    ACObjectsController objectController = new ACObjectsController();
                    List<ACObjectsInfo> objList = objectController.GetObjectsByType(ObjectType.Supplier.ToString());
                    ACObjectsInfo matchObj = objList.FirstOrDefault(t => t.ACObjectID == objectID);
                    if (matchObj != null)
                    {
                        e.DisplayText = matchObj.ACObjectNo;
                    }
                }
            }
            if (e.Column.FieldName == "FK_VMVehicleID")
            {
                if (e.Value != null)
                {
                    int matchCodeID = int.Parse(e.Value.ToString());
                    VMVehiclesController objVehiclesController = new VMVehiclesController();
                    VMVehiclesInfo objVehiclesInfo = (VMVehiclesInfo)objVehiclesController.GetObjectByID(matchCodeID);
                    if (objVehiclesInfo != null)
                        e.DisplayText = objVehiclesInfo.VMVehicleNoPlate;
                    else
                        e.DisplayText = "";
                }
                else
                    e.DisplayText = "";
            }
        }

        void repositoryItemLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;
            ACObjectsController objectController = new ACObjectsController();
            List<ACObjectsInfo> objList = objectController.GetObjectsByType(ObjectType.Supplier.ToString());

            lke.Properties.DataSource = objList;

        }

        void gridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = this.MainView as GridView;
            if (view.IsNewItemRow(e.RowHandle))
            {
                //if (((AdvanceRefundModule)Screen.Module).GetAdvanceRefundType() == AdvanceRefundType.HasInvoice.ToString())
                //{
                //    e.Valid = false;
                //    e.ErrorText = "Loại chứng từ không phù hợp";
                //}
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            AdvanceRefundEntities entity = (AdvanceRefundEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            HRAdvanceRefundsInfo advanceRefund = (HRAdvanceRefundsInfo)entity.MainObject;
            if (entity.HRAdvanceRefundItemInvoiceHasInvoiceList.CurrentIndex >= 0)
            {
                HRAdvanceRefundItemInvoicesInfo item = (HRAdvanceRefundItemInvoicesInfo)entity.HRAdvanceRefundItemInvoiceHasInvoiceList[entity.HRAdvanceRefundItemInvoiceHasInvoiceList.CurrentIndex];

                bool updateNeeded = true;
                if (e.Column.FieldName == "HRAdvanceRefundItemInvoiceTaxPercent"
                    || e.Column.FieldName == "HRAdvanceRefundItemInvoiceSubTotalAmount")
                {
                    if (item.HRAdvanceRefundItemInvoiceSubTotalAmount != 0)
                    {
                        item.HRAdvanceRefundItemInvoiceTaxAmount = item.HRAdvanceRefundItemInvoiceSubTotalAmount / 100 * item.HRAdvanceRefundItemInvoiceTaxPercent;
                        BOSApp.RoundByCurrency(item, "HRAdvanceRefundItemInvoiceTaxAmount", advanceRefund.FK_GECurrencyID);
                        item.HRAdvanceRefundItemInvoiceTotalAmount = item.HRAdvanceRefundItemInvoiceTaxAmount + item.HRAdvanceRefundItemInvoiceSubTotalAmount;
                    }
                }
                else if (e.Column.FieldName == "HRAdvanceRefundItemInvoiceTaxAmount")
                {
                    if (item.HRAdvanceRefundItemInvoiceSubTotalAmount != 0)
                    {
                        item.HRAdvanceRefundItemInvoiceTaxPercent = item.HRAdvanceRefundItemInvoiceTaxAmount / item.HRAdvanceRefundItemInvoiceSubTotalAmount * 100;
                        item.HRAdvanceRefundItemInvoiceTotalAmount = item.HRAdvanceRefundItemInvoiceTaxAmount + item.HRAdvanceRefundItemInvoiceSubTotalAmount;
                    }
                }
                else if (e.Column.FieldName == "ACObjectAccessKey")
                {
                    string[] objArr = item.ACObjectAccessKey.ToString().Split(';');
                    if (objArr.Length == 2)
                    {
                        int objectID = int.Parse(objArr[0]);
                        ACObjectsController objectController = new ACObjectsController();
                        List<ACObjectsInfo> objList = objectController.GetObjectsByType(ObjectType.Supplier.ToString());
                        ACObjectsInfo matchObj = objList.FirstOrDefault(t => t.ACObjectID == objectID);
                        if (matchObj != null)
                        {
                            item.HRAdvanceRefundItemInvoiceObjectName = matchObj.ACObjectName;
                            item.HRAdvanceRefundItemInvoiceObjectAddress = matchObj.ACObjectContactAddressLine3;
                            item.HRAdvanceRefundItemInvoiceObjectTaxNumber = matchObj.ACObjectContactTaxCode;
                        }
                    }

                    updateNeeded = false;
                }

                if (updateNeeded)
                {
                    (entity.Module as AdvanceRefundModule).UpdateTotalAmount();

                }
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((AdvanceRefundModule)Screen.Module).DeleteItemFromHRAdvanceRefundItemInvoiceHasInvoiceList();
            }
        }

        public void repositoryItemUnfinishedLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
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

        protected override void GridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            base.GridView_InitNewRow(sender, e);
            AdvanceRefundEntities entity = (AdvanceRefundEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            HRAdvanceRefundItemInvoicesInfo item = entity.HRAdvanceRefundItemInvoiceHasInvoiceList[entity.HRAdvanceRefundItemInvoiceHasInvoiceList.CurrentIndex];
            item.HRAdvanceRefundItemInvoiceStatus = AdvanceRefundItemInvoiceStatus.Allowable.ToString();
        }

        public void repositoryItemLookUpEditVehicle_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            VMVehiclesController objVehiclesController = new VMVehiclesController();
            List<VMVehiclesInfo> vehiclesList = objVehiclesController.GetAllVehicleList();
            VMVehiclesInfo objVehiclesInfo = new VMVehiclesInfo();
            objVehiclesInfo.VMVehicleID = 0;
            if (vehiclesList != null)
            {
                vehiclesList.Insert(0, objVehiclesInfo);
                lookUpEdit.Properties.DataSource = vehiclesList;
            }
            lookUpEdit.Properties.DisplayMember = "VMVehicleNoPlate";
            lookUpEdit.Properties.ValueMember = "VMVehicleID";
        }
    }
}
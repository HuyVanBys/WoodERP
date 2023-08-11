using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.AdvanceRefund
{
    public partial class DocumentEntryGridControl : BaseDocumentEntryGridControl
    {
        public override void InitGridControlDataSource()
        {
            AdvanceRefundEntities entity = (AdvanceRefundEntities)(((BaseModuleERP)Screen.Module).CurrentModuleEntity);
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.DocumentEntryList;
            DataSource = bds;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            AdvanceRefundEntities entity = (AdvanceRefundEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.DocumentEntryList.CurrentIndex >= 0)
            {
                ACDocumentEntrysInfo item = entity.DocumentEntryList[entity.DocumentEntryList.CurrentIndex];

                if (e.Column.FieldName == "FK_ACUnfinishedConstructionCostID")
                {
                    if (gridView.FocusedRowHandle >= 0)
                    {
                        item = (ACDocumentEntrysInfo)gridView.GetRow(gridView.FocusedRowHandle);
                        ((AdvanceRefundModule)Screen.Module).UpdateAccountDocumentEntrys(item);
                    }
                }
            }
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column = new GridColumn();
            column.Caption = "Số xe";
            column.FieldName = "FK_VMVehicleID";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);

            GridColumn column = gridView.Columns["FK_VMVehicleID"];
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

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
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

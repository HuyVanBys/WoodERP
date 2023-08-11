using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Windows.Forms;

namespace BOSERP.Modules.Home
{
    public partial class ICTransferProposalsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            HomeEntities entity = (HomeEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.TransferProposalList;
            DataSource = bds;
        }
        protected override void GridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            HomeEntities entity = (HomeEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            entity.TransferProposalList.SetEndCurrentEdit();
            return;
        }
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = HomeLocalizedResources.ICTransferProposalNo;
            column.FieldName = "ICTransferProposalNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = HomeLocalizedResources.ICTransferProposalDate;
            column.FieldName = "ICTransferProposalDate";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = HomeLocalizedResources.ICTransferProposalName;
            column.FieldName = "ICTransferProposalName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = HomeLocalizedResources.HREmployeeName;
            column.FieldName = "HREmployeeName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = HomeLocalizedResources.BRBranchName;
            column.FieldName = "BRBranchName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
    }
}

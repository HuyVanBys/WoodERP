using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Windows.Forms;

namespace BOSERP.Modules.HREmployeePieceWage
{
    public partial class HREmployeePieceWageItemsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            HREmployeePieceWageEntities entity = (HREmployeePieceWageEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.HREmployeePieceWageItemList;
            DataSource = bds;
        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn column in gridView.Columns)
            {
                if (column.FieldName == "HREmployeePieceWageItemIsAction" ||
                    column.FieldName == "HREmployeePieceWageItemAmount" ||
                    column.FieldName == "HREmployeePieceWageItemQty")
                    column.OptionsColumn.AllowEdit = true;
            }

            return gridView;
        }
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = OverTimeLocalizedResources.HREmployeeName;
            column.FieldName = "HREmployeeName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mã ID";
            column.FieldName = "HREmployeeCardNumber";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = gridView.Columns["FK_HREmployeeID"];
            if (column != null)
            {
                RepositoryItemBOSLookupEdit item = (RepositoryItemBOSLookupEdit)column.ColumnEdit;
                item.DisplayMember = "HREmployeeNo";
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((HREmployeePieceWageModule)Screen.Module).RemoveEmployeeFromEmployeePieceWageItemList();
            }
        }
    }
}

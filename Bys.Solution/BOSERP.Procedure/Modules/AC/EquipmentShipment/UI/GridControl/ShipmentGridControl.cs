using BOSCommon;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Data;
using System.Drawing;

namespace BOSERP.Modules.EquipmentShipment
{
    public partial class ShipmentGridControl : BOSSearchResultsGridControl
    {
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            GridColumn column = gridView.Columns["FK_MMAllocationProposalID"];
            if (column != null)
            {
                gridView.Columns.Remove(column);
            }
            return gridView;
        }
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();

            column = new GridColumn();
            column.Caption = "Lệnh cấp phát";
            column.FieldName = "MMAllocationPlanNo";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;

            gridView.Columns.Add(column);
        }
    }
}

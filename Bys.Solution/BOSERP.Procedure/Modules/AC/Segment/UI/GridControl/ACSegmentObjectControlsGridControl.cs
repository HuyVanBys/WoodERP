using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.Segment
{
    public class ACSegmentObjectControlsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            SegmentEntities entity = (SegmentEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ACSegmentObjectControlsList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((SegmentModule)Screen.Module).DeleteItemFromObjectControlsList();
            }
        }

    }
}

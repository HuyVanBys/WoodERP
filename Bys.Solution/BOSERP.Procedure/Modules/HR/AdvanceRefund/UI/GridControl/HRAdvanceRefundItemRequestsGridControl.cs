using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.AdvanceRefund
{
    public class HRAdvanceRefundItemRequestsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            AdvanceRefundEntities entity = (AdvanceRefundEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.HRAdvanceRefundItemRequestList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            foreach (GridColumn column in gridView.Columns)
            {
                if (column.FieldName == "HRAdvanceRefundItemRequestStatus")
                    column.OptionsColumn.AllowEdit = true;
                else
                    column.OptionsColumn.AllowEdit = false;
            }
            //gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((AdvanceRefundModule)Screen.Module).DeleteItemFromHRAdvanceRefundItemRequestList();
            }
        }
    }
}

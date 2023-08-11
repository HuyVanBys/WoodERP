using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;
//using BOSERP.Modules.MM.BatchReceipt.Localization;

namespace BOSERP.Modules.EmployeePieceWork
{
    public class HREmployeePieceWorksGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            EmployeePieceWorkEntities entity = (EmployeePieceWorkEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.EmployeePieceWorksList;
            this.DataSource = bds;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            if (e.KeyCode == Keys.Delete)
            {
                ((EmployeePieceWorkModule)Screen.Module).DeleteItemFromEmployeePieceWorksList();
            }
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            return gridView;
        }
    }
}

using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.ATMCardPayroll
{
    public partial class HREmployeeATMCardPayrollsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ATMCardPayrollEntities entity = (ATMCardPayrollEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.EmployeeATMCardPayrollList;
            DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

            GridColumn column = gridView.Columns["HREmployeeATMCardPayrollAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }


            return gridView;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((ATMCardPayrollModule)Screen.Module).RemoveItemFromList();
            }
        }
    }
}

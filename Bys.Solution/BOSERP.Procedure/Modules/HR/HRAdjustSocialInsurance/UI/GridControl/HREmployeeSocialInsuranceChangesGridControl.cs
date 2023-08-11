using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.HRAdjustSocialInsurance
{
    public partial class HREmployeeSocialInsuranceChangesGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            HRAdjustSocialInsuranceEntities entity = (HRAdjustSocialInsuranceEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.HREmployeeSocialInsuranceChangesList;
            DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            foreach (GridColumn col in gridView.Columns)
            {
                col.OptionsColumn.AllowEdit = true;
            }
            GridColumn column = gridView.Columns["FK_HREmployeeID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            return gridView;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((HRAdjustSocialInsuranceModule)Screen.Module).RemoveItemFromList();
            }
        }
    }
}

using System.Windows.Forms;

namespace BOSERP.Modules.ProjectType
{
    public partial class PMPhaseTypesGridControl : BOSComponent.BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ProjectTypeEntities entity = (ProjectTypeEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.PhaseTypeList;
            this.DataSource = bds;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((ProjectTypeModule)Screen.Module).DeletePhaseTypeFromGridview();
            }
        }
    }
}

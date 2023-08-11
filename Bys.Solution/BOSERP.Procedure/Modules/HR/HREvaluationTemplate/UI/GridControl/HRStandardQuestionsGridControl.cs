using BOSComponent;
using System.Windows.Forms;

namespace BOSERP.Modules.HREvaluationTemplate
{
    public class HRStandardQuestionsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            HREvaluationTemplateEntities entity = (HREvaluationTemplateEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.HRStandardQuestionList;
            DataSource = bds;
        }
    }
}

using BOSComponent;
using DevExpress.XtraTreeList.Columns;
using Localization;
using System;
using System.Data;

namespace BOSERP.Modules.HREvaluationTemplate
{
    public partial class HREvaluationStandardsTreeListControl : BOSTreeListControl
    {
        public override void InitializeControl()
        {
            base.InitializeControl();
            this.DoubleClick += new EventHandler(HREvaluationStandardsTreeListControl_DoubleClick);
        }

        private void HREvaluationStandardsTreeListControl_DoubleClick(object sender, EventArgs e)
        {
            ((HREvaluationTemplateModule)Screen.Module).AddItemToTemplateStandardList();
        }

        protected override void InitTreeListDataSource()
        {
            HREvaluationTemplateEntities entity = (HREvaluationTemplateEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BOSTreeList dataSource = new BOSTreeList();
            dataSource.Add(new HREvaluationStandardsInfo(EvaluationStandardLocalizedResources.EvaluationStandard));
            HREvaluationStandardsController objEvaluationStandardsController = new HREvaluationStandardsController();
            DataSet ds = objEvaluationStandardsController.GetAllRootEvaluationStandards();
            entity.HREvaluationStandardTreeList.Invalidate(ds);
            dataSource[0].SubList = entity.HREvaluationStandardTreeList;
            DataSource = dataSource;
        }

        public override void InitTreeListColumns(string strTableName)
        {
            base.InitTreeListColumns(strTableName);

            TreeListColumn column = Columns["HREvaluationStandardName"];
            if (column != null)
            {
                column.VisibleIndex = 1;
            }
        }
    }
}

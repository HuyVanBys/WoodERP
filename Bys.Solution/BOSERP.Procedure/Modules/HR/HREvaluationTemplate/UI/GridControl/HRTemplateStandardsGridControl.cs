using BOSComponent;
using DevExpress.XtraGrid.Views.Grid;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.HREvaluationTemplate
{
    public class HRTemplateStandardsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            HREvaluationTemplateEntities entity = (HREvaluationTemplateEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.HRTemplateStandardList;
            DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.RowClick += new RowClickEventHandler(GridView_RowClick);
            return gridView;
        }

        private void GridView_RowClick(object sender, RowClickEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                GridView gridView = (GridView)MainView;
                HRTemplateStandardsInfo objTemplateStandardsInfo = (HRTemplateStandardsInfo)gridView.GetRow(e.RowHandle);
                HREvaluationTemplateEntities entity = (HREvaluationTemplateEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                HRStandardQuestionsGridControl standardQuestionControl = (HRStandardQuestionsGridControl)Screen.Module.Controls[HREvaluationTemplateModule.StandardQuestionGridControlName];
                HRStandardQuestionsController objStandardQuestionsController = new HRStandardQuestionsController();
                DataSet ds = objStandardQuestionsController.GetAllDataByForeignColumn("FK_HREvaluationStandardID", objTemplateStandardsInfo.FK_HREvaluationStandardID);
                entity.HRStandardQuestionList.Invalidate(ds);
                standardQuestionControl.InitGridControlDataSource();
            }
        }
    }
}

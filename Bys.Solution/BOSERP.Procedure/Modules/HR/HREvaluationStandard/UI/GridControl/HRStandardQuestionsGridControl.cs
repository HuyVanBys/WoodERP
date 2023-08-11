using BOSComponent;
using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.HREvaluationStandard
{
    public partial class HRStandardQuestionsGridControl : BOSGridControl
    {
        /// <summary>
        /// Get RowHandle at the row of grid
        /// </summary>
        private int RowHandle;

        public void InvalidateDataSource(IBOSList<HRStandardQuestionsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);
            gridView.RowCellClick += new RowCellClickEventHandler(GridView_RowCellClick);
            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);
            return gridView;
        }

        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            if (RowHandle >= 0)
            {
                GridView gridView = (GridView)MainView;
                HRStandardQuestionsInfo objStandardQuestionsInfo = new HRStandardQuestionsInfo();
                HREvaluationQuestionsController objEvaluationQuestionsController = new HREvaluationQuestionsController();
                HREvaluationQuestionsInfo objEvaluationQuestionsInfo = new HREvaluationQuestionsInfo();
                objStandardQuestionsInfo = (HRStandardQuestionsInfo)gridView.GetRow(RowHandle);
                if (objStandardQuestionsInfo != null)
                {
                    objEvaluationQuestionsInfo = (HREvaluationQuestionsInfo)objEvaluationQuestionsController.GetObjectByID(objStandardQuestionsInfo.FK_HREvaluationQuestionID);
                    ((HREvaluationStandardModule)Screen.Module).EditEvaluationQuestion(objStandardQuestionsInfo.FK_HREvaluationQuestionID, objEvaluationQuestionsInfo.HREvaluationQuestionDesc);
                }
            }
        }

        private void GridView_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            RowHandle = e.RowHandle;
        }

        private void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((HREvaluationStandardModule)Screen.Module).RemoveSelectedQuestion();
            }
        }
    }
}

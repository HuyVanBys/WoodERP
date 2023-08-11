using System;

namespace BOSERP.Modules.Project.UI
{
    /// <summary>
    /// Summary description for DMHRM104
    /// </summary>
    public partial class DMPM104 : BOSERPScreen
    {

        public DMPM104()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
            fld_dteSearchHistoryFromDateView.EditValue = BOSApp.GetCurrentServerDate();
            fld_dteSearchHistoryToDateView.EditValue = BOSApp.GetCurrentServerDate();
        }

        private void fld_btnApplyView_Click(object sender, EventArgs e)
        {
            ProjectEntities entity = (ProjectEntities)(((ProjectModule)this.Module).CurrentModuleEntity);
            PMProjectsInfo mainObject = (PMProjectsInfo)entity.MainObject;
            DateTime searchHistoryFromDateView = Convert.ToDateTime(fld_dteSearchHistoryFromDateView.EditValue);
            DateTime searchHistoryToDateView = Convert.ToDateTime(fld_dteSearchHistoryToDateView.EditValue);
            PMProjectNormHistorysController objProjectNormHistorysController = new PMProjectNormHistorysController();
            fld_dgcPMProjectNormHistorysGridControl.DataSource = objProjectNormHistorysController.GetProjectNormHistorysBySomeCriteria(mainObject.PMProjectID, searchHistoryFromDateView, searchHistoryToDateView);

        }
    }
}

using System;

namespace BOSERP.Modules.Project.UI
{
    /// <summary>
    /// Summary description for DMPM102
    /// </summary>
    public partial class DMPM102 : BOSERPScreen
    {

        public DMPM102()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnShowTemplateList_Click(object sender, EventArgs e)
        {
            ((ProjectModule)Module).ShowTemplateList();
        }

        private void fld_tabProjectNorm_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            string tabSelected = fld_tabProjectNorm.SelectedTabPage.Name;
            ((ProjectModule)Module).SelectedTabPageProjectNorm(tabSelected);
        }

        private void fld_btnAddProductSection_Click(object sender, EventArgs e)
        {
            ((ProjectModule)Module).AddProductSectionToProjectNormsList();
        }

        private void fld_btnAddProductWork_Click(object sender, EventArgs e)
        {
            ((ProjectModule)Module).AddWorkToProjectNormsList();
        }

        private void fld_btnShowProject_Click(object sender, EventArgs e)
        {
            ((ProjectModule)Module).ShowProjectList();
        }

        private void fld_btnShowAllTasks_Click(object sender, EventArgs e)
        {
            ((ProjectModule)Module).ShowAllTask();
        }
    }
}

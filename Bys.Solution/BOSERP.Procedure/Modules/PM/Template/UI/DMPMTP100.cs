using System;

namespace BOSERP.Modules.Template.UI
{
    /// <summary>
    /// Summary description for DMPMTP100
    /// </summary>
    public partial class DMPMTP100 : BOSERPScreen
    {

        public DMPMTP100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnAddProductSection_Click(object sender, EventArgs e)
        {
            ((TemplateModule)Module).AddProductSectionToTemplateItemsList();
        }

        private void fld_btnProductWork_Click(object sender, EventArgs e)
        {
            ((TemplateModule)Module).AddWorkToTemplateItemsList();
        }

        private void fld_tabTemplateItem_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            string tabSelected = fld_tabTemplateItem.SelectedTabPage.Name;
            ((TemplateModule)Module).InvalidateTemplateItemByType(tabSelected);
        }
    }
}

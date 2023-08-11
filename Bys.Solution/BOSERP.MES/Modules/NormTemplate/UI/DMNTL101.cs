using System;
namespace BOSERP.Modules.NormTemplate.UI
{
    /// <summary>
    /// Summary description for DMNTL101
    /// </summary>
    public partial class DMNTL101 : BOSERPScreen
    {

        public DMNTL101()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnAdd_Click(object sender, EventArgs e)
        {
            ((NormTemplateModule)Module).ShowProducts();
        }

        private void fld_btnSave_Click(object sender, EventArgs e)
        {
            ((NormTemplateModule)Module).SaveNormTemplateProduct();
        }
    }
}

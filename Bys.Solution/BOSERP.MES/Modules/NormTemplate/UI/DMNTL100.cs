using System;
namespace BOSERP.Modules.NormTemplate.UI
{
    /// <summary>
    /// Summary description for SMNTS100
    /// </summary>
    public partial class DMNTL100 : BOSERPScreen
    {

        public DMNTL100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnImportTemplate_Click(object sender, EventArgs e)
        {
            ((NormTemplateModule)Module).ImportDataFromExcel();
        }

        private void fld_btnGetTemplate_Click(object sender, EventArgs e)
        {
            ((NormTemplateModule)Module).GetTemplateExcel();
        }


    }
}

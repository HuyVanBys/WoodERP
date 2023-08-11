using System;
namespace BOSERP.Modules.Processs.UI
{
    /// <summary>
    /// Summary description for DMPCE101
    /// </summary>
    public partial class DMPCE101 : BOSERPScreen
    {

        public DMPCE101()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnAdd_Click(object sender, EventArgs e)
        {
            ((ProcesssModule)Module).ShowProducts();
        }

        private void fld_btnSave_Click(object sender, EventArgs e)
        {
            ((ProcesssModule)Module).SaveProcessProduct();
        }
    }
}

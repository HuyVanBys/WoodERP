using System;

namespace BOSERP.Modules.SaleWork.UI
{
    /// <summary>
    /// Summary description for DMSW100
    /// </summary>
    public partial class DMSW100 : BOSERPScreen
    {

        public DMSW100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnAddProduct_Click(object sender, EventArgs e)
        {
            ((SaleWorkModule)Module).ShowProductWork();
        }
    }
}

using System;

namespace BOSERP.Modules.Line.UI
{
    /// <summary>
    /// Summary description for DMLM100
    /// </summary>
    public partial class DMLM100 : BOSERPScreen
    {

        public DMLM100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void Fld_btnInsertValueByEmployee_Click(object sender, EventArgs e)
        {
            ((LineModule)Module).InsertValueByEmployee();
        }
    }
}

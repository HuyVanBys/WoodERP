using System;

namespace BOSERP.Modules.PositionLine.UI
{
    /// <summary>
    /// Summary description for DMLM100
    /// </summary>
    public partial class DMPL100 : BOSERPScreen
    {

        public DMPL100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void Fld_btnInsertValueByEmployee_Click(object sender, EventArgs e)
        {
            //((LineModule)Module).InsertValueByEmployee();
        }

        private void fld_bedGELocationName_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((PositionLineModule)Module).ChooseLocation();
        }
    }
}

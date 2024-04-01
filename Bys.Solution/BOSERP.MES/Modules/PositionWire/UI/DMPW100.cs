using System;

namespace BOSERP.Modules.PositionWire.UI
{
    /// <summary>
    /// Summary description for DMLM100
    /// </summary>
    public partial class DMPW100 : BOSERPScreen
    {

        public DMPW100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_bedGELocationName_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((PositionWireModule)Module).ChooseLocation();
        }
    }
}

using System;

namespace BOSERP.Modules.PositionRange.UI
{
    /// <summary>
    /// Summary description for DMLM100
    /// </summary>
    public partial class DMPR100 : BOSERPScreen
    {

        public DMPR100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_bedGELocationName_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((PositionRangeModule)Module).ChooseLocation();
        }
    }
}

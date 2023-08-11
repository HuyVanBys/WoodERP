using System;

namespace BOSERP.Modules.WorkShop.UI
{
    /// <summary>
    /// Summary description for DMWS100
    /// </summary>
    public partial class DMWS100 : BOSERPScreen
    {

        public DMWS100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_bedGELocationName_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((WorkShopModule)Module).ChooseLocation();
        }

        private void Fld_btnInsertValueByEmployee_Click(object sender, EventArgs e)
        {
            ((WorkShopModule)Module).InsertValueByEmployee();
        }
    }
}

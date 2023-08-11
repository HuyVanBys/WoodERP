namespace BOSERP.Modules.DeviceProduct.UI
{
    /// <summary>
    /// Summary description for SMDVP100
    /// </summary>
    public partial class SMDVP100 : BOSERPScreen
    {

        public SMDVP100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_bteICProductGroupName_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((DeviceProductModule)Module).ShowCategoryTreeForSearch();
        }
    }
}

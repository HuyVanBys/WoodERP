namespace BOSERP.Modules.HardwareProduct.UI
{
    /// <summary>
    /// Summary description for SMHC100
    /// </summary>
    public partial class SMHC100 : BOSERPScreen
    {

        public SMHC100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_bteICProductGroupName1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((HardwareProductModule)Module).ShowCategoryTreeForSearch();
        }
    }
}

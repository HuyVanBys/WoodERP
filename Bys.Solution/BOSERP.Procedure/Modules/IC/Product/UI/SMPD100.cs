namespace BOSERP.Modules.Product.UI
{
    /// <summary>
    /// Summary description for SMPD100
    /// </summary>
    public partial class SMPD100 : BOSERPScreen
    {

        public SMPD100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_bteICProductGroupName_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((ProductModule)Module).ShowCategoryTreeForSearch();
        }
    }
}

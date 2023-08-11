namespace BOSERP.Modules.PackagingProduct.UI
{
    /// <summary>
    /// Summary description for SMPKP100
    /// </summary>
    public partial class SMPKP100 : BOSERPScreen
    {

        public SMPKP100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_bteICProductGroupName_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((PackagingProductModule)Module).ShowCategoryTreeForSearch();
        }
    }
}

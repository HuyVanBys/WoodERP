namespace BOSERP.Modules.LumberProduct.UI
{
    /// <summary>
    /// Summary description for SMLP100
    /// </summary>
    public partial class SMLP100 : BOSERPScreen
    {

        public SMLP100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_bteICProductGroupName_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((LumberProductModule)Module).ShowCategoryTreeForSearch();
        }
    }
}

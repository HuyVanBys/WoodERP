namespace BOSERP.Modules.PaintProduct.UI
{
    /// <summary>
    /// Summary description for SMPAP100
    /// </summary>
    public partial class SMPAP100 : BOSERPScreen
    {

        public SMPAP100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_bteICProductGroupName_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((PaintProductModule)Module).ShowCategoryTreeForSearch();
        }
    }
}

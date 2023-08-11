namespace BOSERP.Modules.CarProduct.UI
{
    /// <summary>
    /// Summary description for SMCP100
    /// </summary>
    public partial class SMCP100 : BOSERPScreen
    {

        public SMCP100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_bteICProductGroupName_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((CarProductModule)Module).ShowCategoryTreeForSearch();
        }
    }
}

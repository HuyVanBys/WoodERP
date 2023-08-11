namespace BOSERP.Modules.OtherProduct.UI
{
    /// <summary>
    /// Summary description for SMOP100
    /// </summary>
    public partial class SMOP100 : BOSERPScreen
    {

        public SMOP100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_bteICProductGroupName_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((OtherProductModule)Module).ShowCategoryTreeForSearch();
        }
    }
}

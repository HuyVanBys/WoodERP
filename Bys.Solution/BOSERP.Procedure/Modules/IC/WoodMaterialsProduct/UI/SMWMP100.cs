namespace BOSERP.Modules.WoodMaterialsProduct.UI
{
    /// <summary>
    /// Summary description for SMWMP100
    /// </summary>
    public partial class SMWMP100 : BOSERPScreen
    {

        public SMWMP100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_bteICProductGroupName1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((WoodMaterialsProductModule)Module).ShowCategoryTreeForSearch();
        }
    }
}

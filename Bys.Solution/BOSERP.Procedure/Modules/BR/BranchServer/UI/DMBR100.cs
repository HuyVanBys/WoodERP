namespace BOSERP.Modules.Branch.UI
{
    /// <summary>
    /// Summary description for DMBR100
    /// </summary>
    public partial class DMBR100 : BOSERPScreen
    {

        public DMBR100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_bedGELocationName_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((BranchModule)Module).ChooseLocation();
        }
    }
}

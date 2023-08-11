namespace BOSERP.Modules.PaintProcesses.UI
{
    /// <summary>
    /// Summary description for SMPP100
    /// </summary>
    public partial class SMPP100 : BOSERPScreen
    {

        public SMPP100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_bedFK_ICProductGroupID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((PaintProcessesModule)Module).ShowCategoryTreeForSearch();
        }
    }
}

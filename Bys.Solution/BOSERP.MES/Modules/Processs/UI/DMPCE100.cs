using BOSComponent;
using System;
namespace BOSERP.Modules.Processs.UI
{
    /// <summary>
    /// Summary description for SMNTS100
    /// </summary>
    public partial class DMPCE100 : BOSERPScreen
    {

        public DMPCE100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnAdd_Click(object sender, EventArgs e)
        {
            ((ProcesssModule)Module).ShowItemOperation();
        }
        private void fld_lkeMMProcessTypeCombo_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            string type = string.Empty;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((ProcesssModule)Module).ChangeProcessType(type);
            }
        }

    }
}

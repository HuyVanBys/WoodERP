using System;

namespace BOSERP.Modules.Package.UI
{
    /// <summary>
    /// Summary description for SMPK100
    /// </summary>
    public partial class SMPK100 : BOSERPScreen
    {

        public SMPK100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_txtICPackageNo_EditValueChanged(object sender, EventArgs e)
        {
            if (fld_txtICPackageNo.Text.Length > 12)
                fld_txtICPackageNo.Text = fld_txtICPackageNo.Text.Substring(0, 12);
        }
    }
}

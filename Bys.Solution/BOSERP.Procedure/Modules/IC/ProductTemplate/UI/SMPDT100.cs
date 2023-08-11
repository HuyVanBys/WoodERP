using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ProductTemplate.UI
{
	/// <summary>
    /// Summary description for SMPDT100
	/// </summary>
    public partial class SMPDT100 : BOSERPScreen
	{

        public SMPDT100()
		{
			//
			// Required designer variable
			//
			InitializeComponent();
		}

        private void fld_btnReset_Click(object sender, EventArgs e)
        {
            ((BaseModuleERP)this.Module).ResetSearchObject();
        }
	}
}

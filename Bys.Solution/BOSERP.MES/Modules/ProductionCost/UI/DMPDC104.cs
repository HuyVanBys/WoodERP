using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.MES.Modules.ProductionCost.UI
{
	/// <summary>
	/// Summary description for DMPDC104
	/// </summary>
	public partial class DMPDC104 : BOSERPScreen
	{

		public DMPDC104()
		{
			//
			// Required designer variable
			//
			InitializeComponent();
		}

        private void fld_btnApplyPrice_Click(object sender, EventArgs e)
        {
            ((ProductionCostModule)Module).ApplyProductPriceAllOperation();
        }

        private void fld_btnUpdateProductUnitCost_Click(object sender, EventArgs e)
        {
            ((ProductionCostModule)Module).AdjustCostOfGoodsSold();
        }
	}
}

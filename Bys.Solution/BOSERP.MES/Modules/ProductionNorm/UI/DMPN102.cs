using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ProductionNorm.UI
{
	/// <summary>
	/// Summary description for DMPN102
	/// </summary>
	public partial class DMPN102 : BOSERPScreen
	{

		public DMPN102()
		{
			//
			// Required designer variable
			//
			InitializeComponent();
		}

        private void DMPN102_Load(object sender, EventArgs e)
        {

        }

        private void fld_lkeMMProductionNormOperationStatus_Validated(object sender, EventArgs e)
        {
            ((ProductionNormModule)Module).EnableApproved(fld_btnOperationApprove);
        }

        private void fld_btnOperationApprove_Click(object sender, EventArgs e)
        {
            ((ProductionNormModule)Module).ApproveOperation();
        }
	}
}

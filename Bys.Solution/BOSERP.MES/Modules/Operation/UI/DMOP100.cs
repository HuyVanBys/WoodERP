using DevExpress.XtraEditors;
using System;

namespace BOSERP.Modules.Operation.UI
{
    /// <summary>
    /// Summary description for DMOP100
    /// </summary>
    public partial class DMOP100 : BOSERPScreen
    {

        public DMOP100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_chkMMOperationInOutStockCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void fld_chkMMOperationCapacity_CheckedChanged(object sender, EventArgs e)
        {
            //if (fld_chkMMOperationCapacity != null && fld_chkMMOperationCapacity.Checked)
            //    fld_chkMMOperationInOutStockCheck.Checked = false;
            //else
            //    fld_chkMMOperationInOutStockCheck.Checked = true;
            // ((OperationModule)this.Module).ChangeOutStockCheck(fld_chkMMOperationInOutStockCheck.Checked);
        }

        private void DMOP100_Load(object sender, EventArgs e)
        {

        }

        private void Fld_ckeMMOperationSyncProductCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (fld_ckeMMOperationSyncProductCheck.Checked)
            {
                fld_lblOperationSync.Visible = true;
                fld_lkeFK_MMOperationID.Visible = true;
            }
            else
            {
                fld_lblOperationSync.Visible = false;
                fld_lkeFK_MMOperationID.Visible = false;
            }
        }

        private void Fld_chkMMOperationCostCalculationCheck_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit cbSender = (CheckEdit)sender;
            if (cbSender.Checked == true)
                fld_chkMMOperationInOutStockCheck.Checked = true;
        }
    }
}

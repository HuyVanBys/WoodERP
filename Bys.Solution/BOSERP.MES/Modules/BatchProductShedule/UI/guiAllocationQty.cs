using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.BatchProductShedule
{
    public partial class guiAllocationQty : BOSERPScreen
    {
        #region Variables

        public decimal AllocationQty { get; set; }

        public bool IsRate { get; set; }

        public int RoundNum { get; set; }

        public decimal NormQty { get; set; }

        #endregion

        public guiAllocationQty()
        {
            InitializeComponent();
        }

        private void guiAllocationQty_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_rdeType1.Checked = true;
            fld_cbeRoundNumber.SelectedIndex = 6;
            fld_lkeQty.EditValue = NormQty;
        }

        public override void InitializeControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                InitializeControl(ctrl);
                if (ctrl.Controls.Count > 0)
                {
                    InitializeControls(ctrl.Controls);
                }
            }
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            AllocationQty = fld_lkeQty.EditValue == null ? 0 : decimal.Parse(fld_lkeQty.EditValue.ToString());
            IsRate = fld_rdeType1.Checked ? true : false;
            RoundNum = fld_cbeRoundNumber.SelectedIndex;
            if (AllocationQty <= 0 || AllocationQty > NormQty)
            {
                MessageBox.Show(string.Format("SL phân bổ phải lớn hơn 0 và nhỏ hơn {0}. Vui lòng kiểm tra lại!", NormQty)
                                , BaseLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Error);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fld_rdeType2_CheckedChanged(object sender, EventArgs e)
        {
            fld_cbeRoundNumber.Enabled = fld_rdeType1.Checked;
        }
    }
}
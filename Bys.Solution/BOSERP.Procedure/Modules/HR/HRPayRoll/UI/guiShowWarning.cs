using System;
using System.Windows.Forms;

namespace BOSERP.Modules.HRPayRoll
{
    /// <summary>
    /// Summary description for DSPL10
    /// </summary>
    public partial class guiShowWarning : BOSERPScreen
    {
        private HREmployeePayRollsInfo objEmployeePayRollsInfo;
        private HRPayRollConfigsInfo objPayRollConfigsInfo;
        public guiShowWarning(HREmployeePayRollsInfo info, HRPayRollConfigsInfo info2)
        {
            //
            // Required designer variable
            //
            InitializeComponent();

            objEmployeePayRollsInfo = info;
            objPayRollConfigsInfo = info2;
        }

        private void guiShowWarning_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            if (objEmployeePayRollsInfo != null)
            {
                fld_txtThucNhan.Text = objEmployeePayRollsInfo.HREmployeePayRollTotalSalary.ToString("N2");
                fld_txtMin.Text = objPayRollConfigsInfo.HRPayRollConfigMin.ToString("N2");
                fld_txtMax.Text = objPayRollConfigsInfo.HRPayRollConfigMax.ToString("N2");
            }
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

        private void fld_btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

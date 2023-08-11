using BOSCommon;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.HRPayRoll
{
    /// <summary>
    /// Summary description for DSPL10
    /// </summary>
    public partial class guiShowValidate : BOSERPScreen
    {
        private string typeValidate;
        private List<HREmployeePayRollsInfo> employeePayRollList;
        public guiShowValidate(List<HREmployeePayRollsInfo> employeePayRolls, string type)
        {
            //
            // Required designer variable
            //
            InitializeComponent();
            typeValidate = type;
            employeePayRollList = employeePayRolls;
        }

        private void guiShowValidate_Load(object sender, EventArgs e)
        {
            BOSProgressBar.Start("Đang tải ...");
            InitializeControls(Controls);

            if (typeValidate == ValidatePayRoll.Allowance.ToString())
            {
                fld_lblName.Text = "Danh sách khen thưởng";
                fld_dgcHREmployeePayRollValidates.InvalidateDataSource(employeePayRollList);
                fld_dgcHREmployeePayRollValidates.LoadGridViewByType(typeValidate);
            }
            else if (typeValidate == ValidatePayRoll.Discipline.ToString())
            {
                fld_lblName.Text = "Danh sách kỷ luật";
                fld_dgcHREmployeePayRollValidates.InvalidateDataSource(employeePayRollList);
                fld_dgcHREmployeePayRollValidates.LoadGridViewByType(typeValidate);
            }
            else if (typeValidate == ValidatePayRoll.KPI.ToString())
            {
                fld_lblName.Text = "Danh sách KPI";
                fld_dgcHREmployeePayRollValidates.InvalidateDataSource(employeePayRollList);
                fld_dgcHREmployeePayRollValidates.LoadGridViewByType(typeValidate);
            }
            else
            {
                fld_lblName.Text = "Danh sách lương khoán";
                fld_dgcHREmployeePayRollValidates.InvalidateDataSource(employeePayRollList);
                fld_dgcHREmployeePayRollValidates.LoadGridViewByType(typeValidate);
            }
            BOSProgressBar.Close();
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

        private void fld_btnValidated_Click(object sender, EventArgs e)
        {
            if (typeValidate != null)
            {
                //((HRPayRollModule)Module).UpdateObjectValidate(typeValidate);
            }
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

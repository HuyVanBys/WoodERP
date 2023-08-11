using System;
using System.Windows.Forms;

namespace BOSERP.Modules.HROverTime
{
    public partial class guiChooseEmployee : BOSERPScreen
    {
        public string ListEmployee { get; set; }
        public guiChooseEmployee()
        {
            InitializeComponent();
        }

        private void guiChooseEmployee_Load(object sender, EventArgs e)
        {

        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            ListEmployee = fld_medEmployeeNo.EditValue.ToString();
            ListEmployee = ListEmployee.Replace(" ", "").Replace(System.Environment.NewLine, "");
            Close();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            ListEmployee = string.Empty;
            Close();
        }
    }
}

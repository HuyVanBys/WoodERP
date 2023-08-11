using BOSComponent;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.OperationDetailPlan
{
    public partial class guiSearchEmployee : BOSERPScreen
    {
        /// <summary>
        /// A variable to store the employee list
        /// </summary>
        public List<MMDetailPlanHumanUnitsInfo> TicketEmployeeList { get; set; }
        public List<MMDetailPlanHumanUnitsInfo> TicketEmployeeSelectedList { get; set; }
        public guiSearchEmployee()
        {
            InitializeComponent();
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

        private void guiSearchEmployee_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            TicketEmployeeSelectedList = TicketEmployeeList;
            TicketEmployeeSelectedList.ForEach(o => o.Selected = true);
            fld_dgcMMDetailPlanHumanUnits.DataSource = TicketEmployeeSelectedList;
            fld_dgcMMDetailPlanHumanUnits.RefreshDataSource();
        }

        private void fld_chkSellectAll_CheckedChanged(object sender, EventArgs e)
        {
            BOSCheckEdit selectAllCheckEdit = (BOSCheckEdit)sender;
            foreach (MMDetailPlanHumanUnitsInfo objEmployeesInfo in TicketEmployeeSelectedList)
            {
                objEmployeesInfo.Selected = selectAllCheckEdit.Checked;
            }
            fld_dgcMMDetailPlanHumanUnits.RefreshDataSource();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void fld_btnChoose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void fld_btnSearch_Click(object sender, EventArgs e)
        {
            TicketEmployeeSelectedList = TicketEmployeeList;
            TicketEmployeeSelectedList.ForEach(o => o.Selected = true);
            fld_dgcMMDetailPlanHumanUnits.DataSource = TicketEmployeeSelectedList;
            fld_dgcMMDetailPlanHumanUnits.RefreshDataSource();
        }
    }
}

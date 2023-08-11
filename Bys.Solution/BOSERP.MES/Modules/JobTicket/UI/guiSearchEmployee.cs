using BOSCommon;
using BOSComponent;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.JobTicket
{
    public partial class guiSearchEmployee : BOSERPScreen
    {
        /// <summary>
        /// A variable to store the employee list
        /// </summary>
        private List<HREmployeesInfo> EmployeeList;

        /// <summary>
        /// A variable to store the employee list
        /// </summary>
        public List<MMJobTicketItemEmployeesInfo> TicketEmployeeSelectedList { get; set; }

        /// <summary>
        /// Gets or sets the selected employees
        /// </summary>
        public List<HREmployeesInfo> SelectedEmployeeList { get; set; }

        public List<string> roomIDList { get; set; }

        public guiSearchEmployee()
        {
            InitializeComponent();

            SelectedEmployeeList = new List<HREmployeesInfo>();
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
            GetDataSouce(roomIDList);
        }

        private void fld_chkSellectAll_CheckedChanged(object sender, EventArgs e)
        {
            BOSCheckEdit selectAllCheckEdit = (BOSCheckEdit)sender;
            foreach (HREmployeesInfo objEmployeesInfo in EmployeeList)
            {
                objEmployeesInfo.Selected = selectAllCheckEdit.Checked;
            }
            fld_dgcHREmployees.RefreshDataSource();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void fld_btnChoose_Click(object sender, EventArgs e)
        {
            SelectedEmployeeList = EmployeeList.Where(emp => emp.Selected == true).ToList();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void fld_btnSearch_Click(object sender, EventArgs e)
        {
            GetDataSouce(roomIDList);
        }


        /// <summary>
        /// Gets the data souce for employee grid control 
        /// </summary>
        public void GetDataSouce(List<string> roomIDList)
        {
            HREmployeesController objEmployeesController = new HREmployeesController();

            EmployeeList = objEmployeesController.GetEmployeeListByListRoomID(string.Join(",", roomIDList.ToArray()), EmployeeStatus.Working.ToString());
            if (TicketEmployeeSelectedList != null && TicketEmployeeSelectedList.Count > 0
                && EmployeeList != null && EmployeeList.Count > 0)
            {
                EmployeeList.ForEach(e =>
                {
                    if (TicketEmployeeSelectedList.Where(s => s.FK_HREmployeeID == e.HREmployeeID).FirstOrDefault() != null)
                        e.Selected = true;
                });
            }
            fld_dgcHREmployees.DataSource = EmployeeList;
            fld_dgcHREmployees.RefreshDataSource();
        }

        /// <summary>
        /// Gets the data souce for employee grid control 
        /// </summary>
        public void GetDataSouce()
        {
            HREmployeesController objEmployeesController = new HREmployeesController();

            if (SelectedEmployeeList != null && SelectedEmployeeList.Count > 0)
            {
                fld_dgcHREmployees.DataSource = SelectedEmployeeList;
                fld_dgcHREmployees.RefreshDataSource();
            }
        }
    }
}

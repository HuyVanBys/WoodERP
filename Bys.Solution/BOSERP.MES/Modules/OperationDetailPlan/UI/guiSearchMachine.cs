using BOSComponent;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.OperationDetailPlan
{
    public partial class guiSearchMachine : BOSERPScreen
    {
        /// <summary>
        /// A variable to store the employee list
        /// </summary>
        public List<MMDetailPlanMachineUnitsInfo> TicketMachineList { get; set; }
        public List<MMDetailPlanMachineUnitsInfo> TicketMachineSelectedList { get; set; }
        public guiSearchMachine()
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

        private void guiSearchMachine_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            TicketMachineSelectedList = TicketMachineList;
            TicketMachineSelectedList.ForEach(o => o.Selected = true);

            if (BOSApp.LookupTables.ContainsKey("ACAssets"))
            {
                DataSet ds = (DataSet)BOSApp.LookupTables["ACAssets"];
                if (ds != null && ds.Tables.Count > 0)
                {
                    List<ACAssetsInfo> list = (List<ACAssetsInfo>)(new ACAssetsController()).GetListFromDataSet(ds);
                    if (list != null)
                    {
                        foreach (var item in TicketMachineSelectedList)
                        {
                            ACAssetsInfo ass = list.Where(a => a.ACAssetID == item.FK_ACAssetID).FirstOrDefault();
                            if (ass != null) item.ACAssetNo = ass.ACAssetNo;
                        }
                    }
                }
            }
            fld_dgcMMDetailPlanMachineUnits.DataSource = TicketMachineSelectedList;
            fld_dgcMMDetailPlanMachineUnits.RefreshDataSource();
        }

        private void fld_chkSellectAll_CheckedChanged(object sender, EventArgs e)
        {
            BOSCheckEdit selectAllCheckEdit = (BOSCheckEdit)sender;
            foreach (MMDetailPlanMachineUnitsInfo objEmployeesInfo in TicketMachineSelectedList)
            {
                objEmployeesInfo.Selected = selectAllCheckEdit.Checked;
            }
            fld_dgcMMDetailPlanMachineUnits.RefreshDataSource();
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
            TicketMachineSelectedList = TicketMachineList;
            TicketMachineSelectedList.ForEach(o => o.Selected = true);
            fld_dgcMMDetailPlanMachineUnits.DataSource = TicketMachineSelectedList;
            fld_dgcMMDetailPlanMachineUnits.RefreshDataSource();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BOSERP.Modules.ManagerTimeKeeper.UI
{
    /// <summary>
    /// Summary description for DMHRM102
    /// </summary>
    public partial class DMHRM102 : BOSERPScreen
    {

        public DMHRM102()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            ((ManagerTimeKeeperModule)this.Module).CalculateData();
        }

        private void fld_btnSave_Click(object sender, EventArgs e)
        {
            ((ManagerTimeKeeperModule)this.Module).SaveDataComplete();
        }

        private void fld_lkeFK_HRDepartmentID_EditValueChanged(object sender, EventArgs e)
        {
            fld_lkeFK_HRDepartmentRoomID.EditValue = 0;
            fld_lkeHREmployeeID2.EditValue = 0;
            fld_lkeFK_HRDepartmentRoomGroupTeamItemID.EditValue = 0;
            fld_lkeFK_HRDepartmentRoomGroupItemID.EditValue = 0;
        }

        private void fld_lkeHREmployeeID2_QueryPopUp(object sender, CancelEventArgs e)
        {
            HREmployeesController objEmployeesController = new HREmployeesController();
            int departmentID = Convert.ToInt32(fld_lkeFK_HRDepartmentID.EditValue);
            int departmentRoomID = Convert.ToInt32(fld_lkeFK_HRDepartmentRoomID.EditValue);
            int departmentRoomGroupItemID = Convert.ToInt32(fld_lkeFK_HRDepartmentRoomGroupItemID.EditValue);
            int departmentRoomGroupTeamItemID = Convert.ToInt32(fld_lkeFK_HRDepartmentRoomGroupTeamItemID.EditValue);
            List<HREmployeesInfo> list = (List<HREmployeesInfo>)objEmployeesController.GetEmployeeList(null, departmentID, departmentRoomID, departmentRoomGroupItemID, departmentRoomGroupTeamItemID, null);
            if (list != null)
            {
                list.Insert(0, new HREmployeesInfo());
            }
            fld_lkeHREmployeeID2.Properties.DataSource = list;
        }

        private void fld_lkeFK_HRDepartmentRoomID_QueryPopUp(object sender, CancelEventArgs e)
        {
            int departmentID = Convert.ToInt32(fld_lkeFK_HRDepartmentID.EditValue);
            HRDepartmentRoomsController objDepartmentRoomsController = new HRDepartmentRoomsController();
            List<HRDepartmentRoomsInfo> list = null;
            if (departmentID != 0)
                list = objDepartmentRoomsController.GetRoomList(departmentID);
            if (list != null)
            {
                list.Insert(0, new HRDepartmentRoomsInfo());
            }
            fld_lkeFK_HRDepartmentRoomID.Properties.DataSource = list;
        }

        private void fld_lkeFK_HRDepartmentRoomGroupItemID_QueryPopUp(object sender, CancelEventArgs e)
        {
            int id = Convert.ToInt32(fld_lkeFK_HRDepartmentRoomGroupItemID.EditValue);
            int departmentID = Convert.ToInt32(fld_lkeFK_HRDepartmentID.EditValue);
            int departmentRoomID = Convert.ToInt32(fld_lkeFK_HRDepartmentRoomID.EditValue);

            HRDepartmentRoomGroupItemsController objDepartmentRoomGroupItemsController = new HRDepartmentRoomGroupItemsController();
            List<HRDepartmentRoomGroupItemsInfo> list = new List<HRDepartmentRoomGroupItemsInfo>();
            list = objDepartmentRoomGroupItemsController.GetBySomeConditions(null, departmentID, departmentRoomID);
            if (list != null)
            {
                list.Insert(0, new HRDepartmentRoomGroupItemsInfo());
            }
            fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.DataSource = list;
        }

        private void fld_lkeFK_HRDepartmentRoomGroupTeamItemID_QueryPopUp(object sender, CancelEventArgs e)
        {
            int id = Convert.ToInt32(fld_lkeFK_HRDepartmentRoomGroupItemID.EditValue);
            int departmentID = Convert.ToInt32(fld_lkeFK_HRDepartmentID.EditValue);
            int departmentRoomID = Convert.ToInt32(fld_lkeFK_HRDepartmentRoomID.EditValue);
            int departmentRoomGroupItemID = Convert.ToInt32(fld_lkeFK_HRDepartmentRoomGroupItemID.EditValue);

            HRDepartmentRoomGroupTeamItemsController objDepartmentRoomGroupTeamItemsController = new HRDepartmentRoomGroupTeamItemsController();
            List<HRDepartmentRoomGroupTeamItemsInfo> list = new List<HRDepartmentRoomGroupTeamItemsInfo>();
            list = objDepartmentRoomGroupTeamItemsController.GetListDepartmentRoomGroupTeamItemSet(null, departmentID, departmentRoomID, departmentRoomGroupItemID);
            if (list != null)
            {
                list.Insert(0, new HRDepartmentRoomGroupTeamItemsInfo());
            }
            fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Properties.DataSource = list;
        }

        private void fld_lkeFK_HRDepartmentRoomID_EditValueChanged(object sender, EventArgs e)
        {
            fld_lkeHREmployeeID2.EditValue = 0;
            fld_lkeFK_HRDepartmentRoomGroupTeamItemID.EditValue = 0;
            fld_lkeFK_HRDepartmentRoomGroupItemID.EditValue = 0;
        }

        private void fld_lkeFK_HRDepartmentRoomGroupItemID_EditValueChanged(object sender, EventArgs e)
        {
            fld_lkeHREmployeeID2.EditValue = 0;
            fld_lkeFK_HRDepartmentRoomGroupTeamItemID.EditValue = 0;
        }
    }
}

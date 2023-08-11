using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BOSERP.Modules.ManagerTimeKeeper.UI
{
    /// <summary>
    /// Summary description for DMHRM103
    /// </summary>
    public partial class DMHRM103 : BOSERPScreen
    {

        public DMHRM103()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnApplyView_Click(object sender, EventArgs e)
        {
            ((ManagerTimeKeeperModule)this.Module).GetDataCompleted();
        }

        private void fld_btnSaveTimeKeeperComplete_Click(object sender, EventArgs e)
        {
            ((ManagerTimeKeeperModule)this.Module).SaveDataCompletedView();
        }

        private void fld_lkeFK_HRDepartmentIDView_EditValueChanged(object sender, EventArgs e)
        {
            fld_lkeFK_HRDepartmentRoomIDView.EditValue = 0;
            fld_lkeHREmployeeIDView.EditValue = 0;
            fld_lkeFK_HRDepartmentRoomGroupTeamItemIDView.EditValue = 0;
            fld_lkeFK_HRDepartmentRoomGroupItemIDView.EditValue = 0;
        }

        private void fld_lkeHREmployeeIDView_QueryPopUp(object sender, CancelEventArgs e)
        {
            HREmployeesController objEmployeesController = new HREmployeesController();
            int departmentID = Convert.ToInt32(fld_lkeFK_HRDepartmentIDView.EditValue);
            int departmentRoomID = Convert.ToInt32(fld_lkeFK_HRDepartmentRoomIDView.EditValue);
            int departmentRoomGroupItemID = Convert.ToInt32(fld_lkeFK_HRDepartmentRoomGroupItemIDView.EditValue);
            int departmentRoomGroupTeamItemID = Convert.ToInt32(fld_lkeFK_HRDepartmentRoomGroupTeamItemIDView.EditValue);
            List<HREmployeesInfo> list = (List<HREmployeesInfo>)objEmployeesController.GetEmployeeList(null, departmentID, departmentRoomID, departmentRoomGroupItemID, departmentRoomGroupTeamItemID, null);
            if (list != null)
            {
                list.Insert(0, new HREmployeesInfo());
            }
            fld_lkeHREmployeeIDView.Properties.DataSource = list;
        }

        private void fld_lkeFK_HRDepartmentRoomIDView_QueryPopUp(object sender, CancelEventArgs e)
        {
            int departmentID = Convert.ToInt32(fld_lkeFK_HRDepartmentIDView.EditValue);
            HRDepartmentRoomsController objDepartmentRoomsController = new HRDepartmentRoomsController();
            List<HRDepartmentRoomsInfo> list = null;
            if (departmentID != 0)
                list = objDepartmentRoomsController.GetRoomList(departmentID);
            if (list != null)
            {
                list.Insert(0, new HRDepartmentRoomsInfo());
            }
            fld_lkeFK_HRDepartmentRoomIDView.Properties.DataSource = list;
        }

        private void fld_lkeFK_HRDepartmentRoomGroupItemID_QueryPopUp(object sender, CancelEventArgs e)
        {
            int id = Convert.ToInt32(fld_lkeFK_HRDepartmentRoomGroupItemIDView.EditValue);
            int departmentID = Convert.ToInt32(fld_lkeFK_HRDepartmentIDView.EditValue);
            int departmentRoomID = Convert.ToInt32(fld_lkeFK_HRDepartmentRoomIDView.EditValue);

            HRDepartmentRoomGroupItemsController objDepartmentRoomGroupItemsController = new HRDepartmentRoomGroupItemsController();
            List<HRDepartmentRoomGroupItemsInfo> list = new List<HRDepartmentRoomGroupItemsInfo>();
            list = objDepartmentRoomGroupItemsController.GetBySomeConditions(null, departmentID, departmentRoomID);
            if (list != null)
            {
                list.Insert(0, new HRDepartmentRoomGroupItemsInfo());
            }
            fld_lkeFK_HRDepartmentRoomGroupItemIDView.Properties.DataSource = list;
        }

        private void fld_lkeFK_HRDepartmentRoomGroupTeamItemID_QueryPopUp(object sender, CancelEventArgs e)
        {
            int id = Convert.ToInt32(fld_lkeFK_HRDepartmentRoomGroupItemIDView.EditValue);
            int departmentID = Convert.ToInt32(fld_lkeFK_HRDepartmentIDView.EditValue);
            int departmentRoomID = Convert.ToInt32(fld_lkeFK_HRDepartmentRoomIDView.EditValue);
            int departmentRoomGroupItemID = Convert.ToInt32(fld_lkeFK_HRDepartmentRoomGroupItemIDView.EditValue);

            HRDepartmentRoomGroupTeamItemsController objDepartmentRoomGroupTeamItemsController = new HRDepartmentRoomGroupTeamItemsController();
            List<HRDepartmentRoomGroupTeamItemsInfo> list = new List<HRDepartmentRoomGroupTeamItemsInfo>();
            list = objDepartmentRoomGroupTeamItemsController.GetListDepartmentRoomGroupTeamItemSet(null, departmentID, departmentRoomID, departmentRoomGroupItemID);
            if (list != null)
            {
                list.Insert(0, new HRDepartmentRoomGroupTeamItemsInfo());
            }
            fld_lkeFK_HRDepartmentRoomGroupTeamItemIDView.Properties.DataSource = list;
        }

        private void fld_lkeFK_HRDepartmentRoomIDView_EditValueChanged(object sender, EventArgs e)
        {
            fld_lkeHREmployeeIDView.EditValue = 0;
            fld_lkeFK_HRDepartmentRoomGroupTeamItemIDView.EditValue = 0;
            fld_lkeFK_HRDepartmentRoomGroupItemIDView.EditValue = 0;
        }

        private void fld_lkeFK_HRDepartmentRoomGroupItemIDView_EditValueChanged(object sender, EventArgs e)
        {
            fld_lkeHREmployeeIDView.EditValue = 0;
            fld_lkeFK_HRDepartmentRoomGroupTeamItemIDView.EditValue = 0;
        }
    }
}

using System;
using System.Collections.Generic;

namespace BOSERP.Modules.ManagerTimeKeeper.UI
{
    /// <summary>
    /// Summary description for DMHRM104
    /// </summary>
    public partial class DMHRM104 : BOSERPScreen
    {

        public DMHRM104()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnApplyView_Click(object sender, EventArgs e)
        {
            ((ManagerTimeKeeperModule)this.Module).GetDataForTimeKeeperHistoryDetails();
        }

        private void fld_lkeFK_HRDepartmentIDHistoryView_Validated(object sender, EventArgs e)
        {
            if (fld_lkeFK_HRDepartmentIDHistoryView.EditValue != fld_lkeFK_HRDepartmentIDHistoryView.OldEditValue)
            {
                //((SellStaffModule)Module).InvalidateDepartmentRoom(Convert.ToInt32(fld_lkeFK_HRDepartmentID.EditValue.ToString()));
                int departmentID = Convert.ToInt32(fld_lkeFK_HRDepartmentIDHistoryView.EditValue);
                HRDepartmentRoomsController objDepartmentRoomsController = new HRDepartmentRoomsController();
                List<HRDepartmentRoomsInfo> objDepartmentRoomsInfo = null;
                if (departmentID != 0)
                    objDepartmentRoomsInfo = objDepartmentRoomsController.GetRoomList(departmentID);
                fld_lkeFK_HRDepartmentRoomIDHistoryView.Properties.DataSource = objDepartmentRoomsInfo;
                fld_lkeFK_HRDepartmentRoomIDHistoryView.EditValue = 0;
            }
        }
    }
}

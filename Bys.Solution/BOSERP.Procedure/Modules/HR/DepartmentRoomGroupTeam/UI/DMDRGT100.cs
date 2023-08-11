using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace BOSERP.Modules.DepartmentRoomGroupTeam.UI
{
    /// <summary>
    /// Summary description for DMDRGT100
    /// </summary>
    public partial class DMDRGT100 : BOSERPScreen
    {

        public DMDRGT100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void DMDRGT100_Load(object sender, EventArgs e)
        {

        }

        private void fld_lkeFK_HRDepartmentID2_Validated(object sender, EventArgs e)
        {
            //((DepartmentRoomGroupModule)Module).InvalidateDepartmentRoom(Convert.ToInt32(fld_lkeFK_HRDepartmentID2.EditValue.ToString()));
        }

        private void fld_lkeFK_HRDepartmentRoomID2_QueryPopUp(object sender, CancelEventArgs e)
        {
            int departmentID = 0;
            if (fld_lkeFK_HRDepartmentID2.EditValue != null)
            {
                departmentID = Convert.ToInt32(fld_lkeFK_HRDepartmentID2.EditValue.ToString());
            }
            ((DepartmentRoomGroupTeamModule)Module).InvalidateDepartmentRoom(departmentID);
        }

        private void fld_lkeFK_HRDepartmentRoomGroupID_QueryPopUp(object sender, CancelEventArgs e)
        {
            int departmentRoomID = 0;
            if (fld_lkeFK_HRDepartmentRoomID2.EditValue != null && fld_lkeFK_HRDepartmentID2.EditValue != null)
            {
                departmentRoomID = Convert.ToInt32(fld_lkeFK_HRDepartmentRoomID2.EditValue.ToString());
                if (departmentRoomID > 0)
                {
                    HRDepartmentRoomGroupsController objDepartmentRoomGroupsController = new HRDepartmentRoomGroupsController();
                    HRDepartmentRoomGroupItemsController objDepartmentRoomGroupItemsController = new HRDepartmentRoomGroupItemsController();
                    List<HRDepartmentRoomGroupsInfo> list = (List<HRDepartmentRoomGroupsInfo>)objDepartmentRoomGroupsController.GetListFromDataSet(objDepartmentRoomGroupsController.GetAllDataByForeignColumn("FK_HRDepartmentRoomID", departmentRoomID));
                    if (list != null && list.Count > 0 && list.FirstOrDefault().HRDepartmentRoomGroupID > 0)
                    {
                        List<HRDepartmentRoomGroupItemsInfo> lstDepartmentRoomGroupItems = objDepartmentRoomGroupItemsController.GetDepartmentRoomGroupItemByDepartmentRoomGroupID(list.FirstOrDefault().HRDepartmentRoomGroupID);
                        fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.DataSource = lstDepartmentRoomGroupItems;
                    }
                    else
                        fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.DataSource = new List<HRDepartmentRoomGroupItemsInfo>();
                }
            }
        }
    }
}

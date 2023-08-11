using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BOSERP.Modules.SellStaff.UI
{
    /// <summary>
    /// Summary description for DMSS107
    /// </summary>
    public partial class DMSS107 : BOSERPScreen
    {
        public int brandID;
        public int deparmentID;
        public int deparmentroomID;
        public int departmentRoomGroupItemID;
        public int departmentRoomGroupTeamItemID;
        public int levelID;


        public DMSS107()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void bosButton3_Click(object sender, EventArgs e)
        {
            brandID = Convert.ToInt32(fld_lkeFK_BRBranchID.EditValue);
            deparmentID = Convert.ToInt32(fld_lkeFK_HRDepartmentID.EditValue);
            deparmentroomID = Convert.ToInt32(fld_lkeFK_HRDepartmentRoomID.EditValue);
            departmentRoomGroupItemID = Convert.ToInt32(fld_lkeFK_HRDepartmentRoomGroupItemID.EditValue);
            departmentRoomGroupTeamItemID = Convert.ToInt32(fld_lkeFK_HRDepartmentRoomGroupTeamItemID.EditValue);
            levelID = Convert.ToInt32(fld_lkeFK_HRLevelID.EditValue);
            ((SellStaffModule)Module).AddItemToTransferList();
        }

        private void bosButton2_Click(object sender, EventArgs e)
        {
            ((SellStaffModule)Module).RemoveSelectedItemFromTransferList();
        }

        private void bosButton1_Click(object sender, EventArgs e)
        {
            ((SellStaffModule)Module).ChangeSelectedItemFromTransferList();
        }

        private void bosButton4_Click(object sender, EventArgs e)
        {
            ((SellStaffModule)Module).PrintPL();
        }

        private void fld_lkeFK_HRDepartmentRoomGroupItemID1_QueryPopUp(object sender, CancelEventArgs e)
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

        private void fld_btnNew_Click(object sender, EventArgs e)
        {
            SellStaffEntities entity = (SellStaffEntities)((SellStaffModule)Module).CurrentModuleEntity;
            HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)entity.MainObject;
            if (objEmployeesInfo != null)
            {
                fld_lkeFK_HREmployeeContractID.EditValue = 0;
                fld_lkeHREmployeeTranferSigner.EditValue = 0;
                fld_lkeFK_HREmployeeReceivedID.EditValue = 0;
                fld_dteHREmployeeTranferDateFrom.EditValue = DateTime.Now;
                fld_dteHREmployeeTranferSignDate.EditValue = DateTime.Now;
                fld_txtHREmployeeTranferSalary.EditValue = "";
                fld_txtHREmployeeTranferSalaryFactor.EditValue = "";
                fld_txtHREmployeeTranferExtraSalary.EditValue = "";
                fld_txtHREmployeeTranferAllowances.EditValue = "";
                fld_txtHREmployeeTranferAllowanceAnother.EditValue = "";
                fld_medHREmployeeTranferRemark.EditValue = "";
                fld_txtHREmployeeTranferTotalSalaryOriginal.EditValue = objEmployeesInfo.HREmployeeWorkingSlrAmt;
                fld_txtHREmployeeTranferSalarySocialInsuranceOriginal.EditValue = objEmployeesInfo.HREmployeeSalarySocialInsurance;

                fld_lkeBRBranchIDOld.EditValue = objEmployeesInfo.FK_BRBranchID;
                fld_lkeHRDepartmentIDOld.EditValue = objEmployeesInfo.FK_HRDepartmentID;
                fld_lkeHRDepartmentRoomIDOld.EditValue = objEmployeesInfo.FK_HRDepartmentRoomID;
                fld_lkeHRDepartmentRoomGroupItemIDOld.EditValue = objEmployeesInfo.FK_HRDepartmentRoomGroupItemID;
                fld_lkeHRDepartmentRoomGroupTeamItemIDOld.EditValue = objEmployeesInfo.FK_HRDepartmentRoomGroupTeamItemID;
                fld_lkeHRLevelIDOld.EditValue = objEmployeesInfo.FK_HRLevelID;

                fld_lkeFK_BRBranchID.EditValue = 0;
                fld_lkeFK_HRDepartmentID.EditValue = 0;
                fld_lkeFK_HRDepartmentRoomID.EditValue = 0;
                fld_lkeFK_HRDepartmentRoomGroupItemID.EditValue = 0;
                fld_lkeFK_HRDepartmentRoomGroupTeamItemID.EditValue = 0;
                fld_lkeFK_HRLevelID.EditValue = 0;
            }
        }

        private void Fld_lkeFK_HRDepartmentID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            fld_lkeFK_HRDepartmentRoomID.EditValue = 0;
            fld_lkeFK_HRDepartmentRoomGroupTeamItemID.EditValue = 0;
            fld_lkeFK_HRDepartmentRoomGroupItemID.EditValue = 0;
        }

        private void Fld_lkeFK_HRDepartmentRoomID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            fld_lkeFK_HRDepartmentRoomGroupTeamItemID.EditValue = 0;
            fld_lkeFK_HRDepartmentRoomGroupItemID.EditValue = 0;
        }

        private void Fld_lkeFK_HRDepartmentRoomGroupItemID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            fld_lkeFK_HRDepartmentRoomGroupTeamItemID.EditValue = 0;
        }
    }
}

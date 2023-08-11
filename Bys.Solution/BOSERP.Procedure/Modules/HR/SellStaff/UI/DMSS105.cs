using BOSCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace BOSERP.Modules.SellStaff.UI
{
    /// <summary>
    /// Summary description for DMSS105
    /// </summary>
    public partial class DMSS105 : BOSERPScreen
    {

        public DMSS105()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void bosButton3_Click(object sender, EventArgs e)
        {
            ((SellStaffModule)Module).AddItemToContractList();
        }

        private void bosButton2_Click(object sender, EventArgs e)
        {
            ((SellStaffModule)Module).RemoveSelectedItemFromContractList();
        }

        private void bosButton1_Click(object sender, EventArgs e)
        {
            ((SellStaffModule)Module).ChangeSelectedItemFromContractList();
        }

        private void bosButton4_Click(object sender, EventArgs e)
        {
            ((SellStaffModule)Module).PrintContractByType(EmployeeContractType.KhongThoiHan.ToString());
        }

        private void fld_btnTBTN_Click(object sender, EventArgs e)
        {
            ((SellStaffModule)Module).PrintTBTN();
        }

        private void fld_btnHDHV_Click(object sender, EventArgs e)
        {
            ((SellStaffModule)Module).PrintContractByType(EmployeeContractType.HocViec.ToString());
        }

        private void bosButton5_Click(object sender, EventArgs e)
        {
            SellStaffEntities entity = (SellStaffEntities)((SellStaffModule)Module).CurrentModuleEntity;
            HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)entity.MainObject;
            HREmployeesController objEmployeesController = new HREmployeesController();
            HREmployeesInfo objEmployeesInfoSigner = (HREmployeesInfo)objEmployeesController.GetObjectByNo("002821");
            if (objEmployeesInfo != null)
            {
                fld_txtHREmployeeHoursPerDay.EditValue = objEmployeesInfo.HREmployeeContractSlrAmt;
                fld_txtHREmployeeContractExtraSalary.EditValue = objEmployeesInfo.HREmployeeSalarySocialInsurance;
                //fld_txtHREmployeeContractAllowances.EditValue = objEmployeesInfo.HREmployeeExtraSalary1;
                fld_lkeFK_HRDepartmentID.EditValue = objEmployeesInfo.FK_HRDepartmentID;
                fld_lkeFK_HRLevelID.EditValue = objEmployeesInfo.FK_HRLevelID;
                fld_lkeFK_HRDepartmentRoomID.EditValue = objEmployeesInfo.FK_HRDepartmentRoomID;
                fld_txtFK_BRBranchIDToWork.EditValue = objEmployeesInfo.FK_BRBranchID;
                //fld_txtHREmployeeContractSalaryFactor.EditValue = objEmployeesInfo.HREmployeeSalaryFactor;
                fld_lkeFK_HRDepartmentRoomGroupTeamItemID.EditValue = objEmployeesInfo.FK_HRDepartmentRoomGroupTeamItemID;
                fld_lkeFK_HRDepartmentRoomGroupItemID.EditValue = objEmployeesInfo.FK_HRDepartmentRoomGroupItemID;

                //Để trống các file không cần thiết 
                bosLookupEdit6.EditValue = 0;
                bosDateEdit2.EditValue = DateTime.MaxValue;
                fld_txtHREmployeeContractSalaryFactor.EditValue = 0;
                fld_txtHREmployeeContractAllowances.EditValue = 0;
                bosTextBox6.EditValue = string.Empty;
                bosTextBox7.EditValue = string.Empty;
                fld_txtHREmployeeContractCV.EditValue = string.Empty;
                bosTextBox9.EditValue = string.Empty;
                bosTextBox10.EditValue = string.Empty;
                bosDateEdit4.EditValue = DateTime.MaxValue;
                bosTextBox4.EditValue = string.Empty;
                bosLookupEdit6.EditValue = objEmployeesInfo.HRInsCalculatedSalaryType;

                fld_txtHREmployeeContractAllowances.EditValue = 0;
                fld_txtHREmployeeContractSalaryFactor.EditValue = 0;
                fld_dteHREmployeeContractDateFrom.EditValue = DateTime.MaxValue;
                if (entity.HREmployeeContractList != null && entity.HREmployeeContractList.Count > 0)
                {
                    fld_dteHREmployeeContractDateFrom.EditValue = entity.HREmployeeContractList.FirstOrDefault().HREmployeeContractDateFrom;
                }
                else
                    fld_dteHREmployeeContractDateFrom.EditValue = objEmployeesInfo.HREmployeeStartWorkingDate;

                if (objEmployeesInfoSigner != null)
                {
                    fld_lkeHREmployeeContractSigner.EditValue = objEmployeesInfoSigner.HREmployeeID;
                }

                fld_lkeHREmployeeContractStatus.EditValue = EmployeeContractStatus.Effective.ToString();
            }
        }

        private void fld_btnTMNV_Click(object sender, EventArgs e)
        {
            ((SellStaffModule)Module).PrintContractByType(EmployeeContractType.ThuMoiNhanViec.ToString());
        }

        private void fld_lkeHREmployeeContractType_Validated(object sender, EventArgs e)
        {
            SellStaffEntities entity = (SellStaffEntities)((SellStaffModule)Module).CurrentModuleEntity;
            HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)entity.MainObject;
            //if (objEmployeesInfo != null)
            //{
            //    fld_dteHREmployeeContractDateFrom.EditValue = objEmployeesInfo.HREmployeeApprenticeDay;
            //}
            bosTextBox5.EditValue = entity.GetNoSellStaff(fld_lkeHREmployeeContractType.EditValue.ToString());
            ((SellStaffModule)Module).UpdateContract();
        }

        private void fld_dteHREmployeeContractDateFrom_Validated(object sender, EventArgs e)
        {
            ((SellStaffModule)Module).UpdateContract();
        }

        private void fld_lkeFK_HRDepartmentRoomGroupItemID_QueryPopUp(object sender, CancelEventArgs e)
        {
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

        private void fld_lkeFK_HRDepartmentID_EditValueChanged(object sender, EventArgs e)
        {
            //fld_lkeFK_HRDepartmentRoomID.EditValue = 0;
            //fld_lkeFK_HRDepartmentRoomGroupTeamItemID.EditValue = 0;
            //fld_lkeFK_HRDepartmentRoomGroupItemID.EditValue = 0;
        }

        private void fld_lkeFK_HRDepartmentRoomID_EditValueChanged(object sender, EventArgs e)
        {
            //fld_lkeFK_HRDepartmentRoomGroupTeamItemID.EditValue = 0;
            //fld_lkeFK_HRDepartmentRoomGroupItemID.EditValue = 0;
        }

        private void fld_lkeFK_HRDepartmentRoomGroupItemID_EditValueChanged(object sender, EventArgs e)
        {
            //fld_lkeFK_HRDepartmentRoomGroupTeamItemID.EditValue = 0;
        }
    }
}

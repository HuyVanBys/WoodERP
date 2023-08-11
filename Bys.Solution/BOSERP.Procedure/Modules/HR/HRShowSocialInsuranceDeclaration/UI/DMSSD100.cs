using BOSComponent;
using BOSLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BOSERP.Modules.HRShowSocialInsuranceDeclaration.UI
{
    /// <summary>
    /// Summary description for DMSSD100
    /// </summary>
    public partial class DMSSD100 : BOSERPScreen
    {

        public DMSSD100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnView_Click(object sender, EventArgs e)
        {
            string status = Convert.ToString(fld_lkeHRSocialInsuranceDeclarationStatus.EditValue);
            DateTime month = BOSApp.GetCurrentServerDate();
            DateTime.TryParse(fld_dteMonthBHXH.EditValue.ToString(), out month);
            ((HRShowSocialInsuranceDeclarationModule)Module).ViewSocialInsuranceDeclarations(status, month);
        }

        private void fld_lkeHRSocialInsuranceDeclarationStatus_QueryPopUp(object sender, CancelEventArgs e)
        {
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            List<ADConfigValuesInfo> list = objConfigValuesController.GetADConfigValuesByKeyGroup("ShowSocialInsuranceDeclarationType");
            fld_lkeHRSocialInsuranceDeclarationStatus.Properties.DataSource = list;
            fld_lkeHRSocialInsuranceDeclarationStatus.Properties.DisplayMember = "ADConfigText";
            fld_lkeHRSocialInsuranceDeclarationStatus.Properties.ValueMember = "ADConfigKeyValue";
        }

        private void fld_chkSellectAll_CheckedChanged(object sender, EventArgs e)
        {
            BOSCheckEdit selectAllCheckEdit = (BOSCheckEdit)sender;
            HRShowSocialInsuranceDeclarationEntities entity = (HRShowSocialInsuranceDeclarationEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            foreach (HREmployeesInfo objEmployeesInfo in entity.EmployeeList)
            {
                objEmployeesInfo.Selected = selectAllCheckEdit.Checked;
            }
            fld_dgcHREmployees.RefreshDataSource();
        }

        private void fld_btnNewDocument_Click(object sender, EventArgs e)
        {
            string status = Convert.ToString(fld_lkeHRSocialInsuranceDeclarationStatus.EditValue);
            ((HRShowSocialInsuranceDeclarationModule)Module).NewSocialInsuranceDeclarations(status);
        }

        private void Fld_lkeBRBranchID_EditValueChanged(object sender, EventArgs e)
        {
            fld_lkeHRDepartmentRoomID.EditValue = 0;
            fld_lkeHREmployeeID.EditValue = 0;
            fld_lkeHRDepartmentID.EditValue = 0;
            fld_lkeHRDepartmentRoomGroupItemID.EditValue = 0;
        }

        private void Fld_lkeHRDepartmentID_EditValueChanged(object sender, EventArgs e)
        {
            fld_lkeHRDepartmentRoomID.EditValue = 0;
            fld_lkeHRDepartmentRoomGroupItemID.EditValue = 0;
            fld_lkeHREmployeeID.EditValue = 0;
        }

        private void Fld_lkeHRDepartmentID_QueryPopUp(object sender, CancelEventArgs e)
        {
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            HRDepartmentsController objDepartmentsController = new HRDepartmentsController();
            List<HRDepartmentsInfo> list = null;
            if (branchID != 0)
                list = objDepartmentsController.GetListByFK_BRBranchID(branchID);
            if (list != null)
            {
                list.Insert(0, new HRDepartmentsInfo());
            }
            fld_lkeHRDepartmentID.Properties.DataSource = list;
        }

        private void Fld_lkeHRDepartmentRoomID_EditValueChanged(object sender, EventArgs e)
        {
            fld_lkeHRDepartmentRoomGroupItemID.EditValue = 0;
            fld_lkeHREmployeeID.EditValue = 0;
        }

        private void Fld_lkeHRDepartmentRoomID_QueryPopUp(object sender, CancelEventArgs e)
        {
            int departmentID = Convert.ToInt32(fld_lkeHRDepartmentID.EditValue);
            HRDepartmentRoomsController objDepartmentRoomsController = new HRDepartmentRoomsController();
            List<HRDepartmentRoomsInfo> list = null;
            if (departmentID != 0)
                list = objDepartmentRoomsController.GetRoomList(departmentID);
            if (list != null)
            {
                list.Insert(0, new HRDepartmentRoomsInfo());
            }
            fld_lkeHRDepartmentRoomID.Properties.DataSource = list;
        }

        private void Fld_lkeHREmployeeID_QueryPopUp(object sender, CancelEventArgs e)
        {
            HREmployeesController objEmployeesController = new HREmployeesController();
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            int departmentID = Convert.ToInt32(fld_lkeHRDepartmentID.EditValue);
            int departmentRoomID = Convert.ToInt32(fld_lkeHRDepartmentRoomID.EditValue);
            int departmentRoomGroupItemID = Convert.ToInt32(fld_lkeHRDepartmentRoomGroupItemID.EditValue);
            string status = Convert.ToString(fld_lkeHRSocialInsuranceDeclarationStatus.EditValue);
            List<HREmployeesInfo> list = (List<HREmployeesInfo>)objEmployeesController.GetEmployeeListSocial(branchID, departmentID, departmentRoomID, departmentRoomGroupItemID);
            if (list != null)
            {
                list.Insert(0, new HREmployeesInfo());
            }
            fld_lkeHREmployeeID.Properties.DataSource = list;
        }

        private void Fld_lkeHRDepartmentRoomGroupItemID_QueryPopUp(object sender, CancelEventArgs e)
        {
            int departmentRoomID = Convert.ToInt32(fld_lkeHRDepartmentRoomID.EditValue);
            HRDepartmentRoomGroupItemsController objDepartmentRoomGroupItemsController = new HRDepartmentRoomGroupItemsController();
            List<HRDepartmentRoomGroupItemsInfo> list = null;
            if (departmentRoomID != 0)
                list = objDepartmentRoomGroupItemsController.GetDepartmentRoomGroupItemByDepartmentRoomID(departmentRoomID);
            if (list != null)
            {
                list.Insert(0, new HRDepartmentRoomGroupItemsInfo());
            }
            fld_lkeHRDepartmentRoomGroupItemID.Properties.DataSource = list;
        }

        private void Fld_lkeHRDepartmentRoomGroupItemID_EnabledChanged(object sender, EventArgs e)
        {
            fld_lkeHREmployeeID.EditValue = 0;
        }

        private void fld_btnViewInfo_Click(object sender, EventArgs e)
        {
            int employeeID = Convert.ToInt32(fld_lkeHREmployeeID.EditValue);
            string status = Convert.ToString(fld_lkeHRSocialInsuranceDeclarationStatusMain.EditValue);
            ((HRShowSocialInsuranceDeclarationModule)Module).ViewSocialInsuranceDeclarations(employeeID, status);
        }
    }
}

using BOSComponent;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BOSERP.Modules.RecruitmentPlan.UI
{
    /// <summary>
    /// Summary description for DMRMP100
    /// </summary>
    public partial class DMRMP100 : BOSERPScreen
    {

        public DMRMP100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_HRDepartmentID_Validated(object sender, EventArgs e)
        {
            if (fld_lkeFK_HRDepartmentID.EditValue != null)
            {
                int departmentID = Convert.ToInt32(fld_lkeFK_HRDepartmentID.EditValue);
                HRDepartmentRoomsController objDepartmentRoomsController = new HRDepartmentRoomsController();
                List<HRDepartmentRoomsInfo> objDepartmentRoomsInfo = null;
                if (departmentID != 0)
                    objDepartmentRoomsInfo = objDepartmentRoomsController.GetRoomList(departmentID);
                fld_lkeFK_HRDepartmentRoomID.Properties.DataSource = objDepartmentRoomsInfo;
                fld_lkeFK_HRDepartmentRoomID.EditValue = 0;
            }
        }

        private void fld_lkeFK_HRDepartmentRoomID_QueryPopUp(object sender, CancelEventArgs e)
        {
            int departmentID = Convert.ToInt32(fld_lkeFK_HRDepartmentID.EditValue);
            HRDepartmentRoomsController objDepartmentRoomsController = new HRDepartmentRoomsController();
            List<HRDepartmentRoomsInfo> objDepartmentRoomsInfo = null;
            objDepartmentRoomsInfo = objDepartmentRoomsController.GetRoomList(departmentID);
            fld_lkeFK_HRDepartmentRoomID.Properties.DataSource = objDepartmentRoomsInfo;
            fld_lkeFK_HRDepartmentRoomID.EditValue = 0;
        }

        private void Fld_lkeFK_BRBranchID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((RecruitmentPlanModule)this.Module).ChangeBranch(Convert.ToInt32(e.Value.ToString()));
            }
        }

        private void Fld_lkeFK_HRDepartmentID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((RecruitmentPlanModule)this.Module).ChangeDepartment(Convert.ToInt32(e.Value.ToString()));
            }
        }
    }
}

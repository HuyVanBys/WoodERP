using BOSComponent;
using System;
using System.Collections.Generic;

namespace BOSERP.Modules.RecruitmentNeed.UI
{
    /// <summary>
    /// Summary description for DMRN100
    /// </summary>
    public partial class DMRN100 : BOSERPScreen
    {

        public DMRN100()
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

        private void Fld_lkeFK_BRBranchID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((RecruitmentNeedModule)this.Module).ChangeBranch(Convert.ToInt32(e.Value.ToString()));
            }
        }

        private void Fld_lkeFK_HRDepartmentID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((RecruitmentNeedModule)this.Module).ChangeDepartment(Convert.ToInt32(e.Value.ToString()));
            }
        }
    }
}

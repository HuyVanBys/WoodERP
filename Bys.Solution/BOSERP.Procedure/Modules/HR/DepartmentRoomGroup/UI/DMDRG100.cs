using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BOSERP.Modules.DepartmentRoomGroup.UI
{
    /// <summary>
    /// Summary description for DMDRG100
    /// </summary>
    public partial class DMDRG100 : BOSERPScreen
    {

        public DMDRG100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void DMDRG100_Load(object sender, EventArgs e)
        {

        }

        private void fld_lkeFK_HRDepartmentID2_Validated(object sender, EventArgs e)
        {
            int departmentID = 0;
            if (fld_lkeFK_HRDepartmentID2.EditValue != null)
            {
                departmentID = Convert.ToInt32(fld_lkeFK_HRDepartmentID2.EditValue.ToString());
            }
            ((DepartmentRoomGroupModule)Module).InvalidateDepartmentRoom(departmentID);
        }

        private void fld_lkeFK_HRDepartmentRoomID2_QueryPopUp(object sender, CancelEventArgs e)
        {
            int departmentID = 0;
            if (fld_lkeFK_HRDepartmentID2.EditValue != null)
            {
                departmentID = Convert.ToInt32(fld_lkeFK_HRDepartmentID2.EditValue.ToString());
            }
            ((DepartmentRoomGroupModule)Module).InvalidateDepartmentRoom(departmentID);
        }

        private void fld_lkeFK_HRDepartmentID2_QueryPopUp(object sender, CancelEventArgs e)
        {
            int branchID = Convert.ToInt32(fld_lkeFK_BRBranchID2.EditValue);
            HRDepartmentsController objDepartmentsController = new HRDepartmentsController();
            List<HRDepartmentsInfo> objDepartmentsInfo = null;
            objDepartmentsInfo = (List<HRDepartmentsInfo>)objDepartmentsController.GetListByFK_BRBranchID(branchID);
            HRDepartmentsInfo obj = new HRDepartmentsInfo();
            if (objDepartmentsInfo != null)
            {
                objDepartmentsInfo.Insert(0, obj);
            }
            fld_lkeFK_HRDepartmentID2.Properties.DataSource = objDepartmentsInfo;
            fld_lkeFK_HRDepartmentID2.EditValue = 0;
        }
    }
}

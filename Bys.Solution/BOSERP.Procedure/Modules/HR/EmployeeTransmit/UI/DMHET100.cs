using BOSComponent;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BOSERP.Modules.EmployeeTransmit.UI
{
    /// <summary>
    /// Summary description for DMHET100
    /// </summary>
    public partial class DMHET100 : BOSERPScreen
    {

        public DMHET100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnAddEmployee_Click(object sender, EventArgs e)
        {
            ((EmployeeTransmitModule)Module).AddEmployeeToTransmitList();
        }
        private void fld_lkeFK_BRBranchID1_Validated(object sender, EventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (lke.EditValue != null && lke.EditValue != lke.OldEditValue)
                ((EmployeeTransmitModule)Module).UpdateSalaryConfig();
        }

        private void fld_lkeFK_HRDepartmentID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
                ((EmployeeTransmitModule)Module).UpdateSalaryConfig();
        }

        private void fld_dteEmployeeTransmitFromDate1_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            BOSDateEdit lke = (BOSDateEdit)sender;
            if (lke.OldEditValue != lke.EditValue)
            {
                ((EmployeeTransmitModule)Module).UpdateTransmitFromDateInfo();
            }
        }

        private void fld_txtEmployeeTransmitFromDate_Validated(object sender, EventArgs e)
        {
            ((EmployeeTransmitModule)Module).UpdateTransmitDateStartInfo();
        }

        private void fld_txtEmployeeTransmitDateEnd_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            BOSDateEdit lke = (BOSDateEdit)sender;
            if (lke.OldEditValue != lke.EditValue)
            {
                ((EmployeeTransmitModule)Module).UpdateTransmitToDateInfo();
            }
        }

        private void fld_txtEmployeeTransmitToDate_Validated(object sender, EventArgs e)
        {
            ((EmployeeTransmitModule)Module).UpdateTransmitDateEndInfo();
        }

        private void fld_lkeFK_HRDepartmentID_Validated(object sender, EventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (lke.EditValue != null && lke.EditValue != lke.OldEditValue)
                ((EmployeeTransmitModule)Module).UpdateSalaryConfig();
        }

        private void bosLookupEdit4_Validated(object sender, EventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (lke.EditValue != null && lke.EditValue != lke.OldEditValue)
                ((EmployeeTransmitModule)Module).UpdateSalaryConfig();
        }

        private void fld_lkeFFK_HRDepartmentRoomID_Validated(object sender, EventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (lke.EditValue != null && lke.EditValue != lke.OldEditValue)
                ((EmployeeTransmitModule)Module).UpdateSalaryConfig();
        }

        private void fld_lkeFK_HRDepartmentRoomGroupItemID_Validated(object sender, EventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (lke.EditValue != null && lke.EditValue != lke.OldEditValue)
                ((EmployeeTransmitModule)Module).UpdateSalaryConfig();
        }

        private void fld_lkeFK_HRLevelID_Validated(object sender, EventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (lke.EditValue != null && lke.EditValue != lke.OldEditValue)
                ((EmployeeTransmitModule)Module).UpdateSalaryConfig();
        }

        private void fld_dteHREmployeeTransmitFromDate_Validated(object sender, EventArgs e)
        {
            BOSDateEdit lke = (BOSDateEdit)sender;
            if (lke.OldEditValue != lke.EditValue)
            {
                ((EmployeeTransmitModule)Module).UpdateTransmitFromDateInfo();
            }
        }

        private void fld_dteHREmployeeTransmitToDate_Validated(object sender, EventArgs e)
        {
            BOSDateEdit lke = (BOSDateEdit)sender;
            if (lke.OldEditValue != lke.EditValue)
            {
                ((EmployeeTransmitModule)Module).UpdateTransmitToDateInfo();
            }
        }

        private void fld_lkeFFK_HRDepartmentRoomID_QueryPopUp(object sender, CancelEventArgs e)
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
    }
}

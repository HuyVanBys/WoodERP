using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP146 : ReportForm
    {
        // private List<ICProductsInfo> equipments;
        public RP146()
        {
            InitializeComponent();
        }

        public override void InitializeControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                InitializeControl(ctrl);
                if (ctrl.Controls.Count > 0)
                {
                    InitializeControls(ctrl.Controls);
                }
            }
        }

        private void RP146_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteToDate.EditValue = BOSUtil.GetMonthEndDate();

        }


        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        public void GeneralData()
        {
            DateTime Todate = fld_dteToDate.DateTime;
            int branchID = 0, departmentRoomID = 0;
            int.TryParse(fld_lkeBRBranchID.EditValue.ToString(), out branchID);
            int.TryParse(fld_lkeHRDepartmentRoomID.EditValue.ToString(), out departmentRoomID);
            List<BRBranchsInfo> selectedBranches = GetSelectedBranchesByBranchID(branchID);
            string branchNos = GetSelectedBranchNosByBranchID(branchID);

            HRDepartmentRoomsController departmentRoomController = new HRDepartmentRoomsController();
            ICStocksController objStocksController = new ICStocksController();
            List<HRDepartmentRoomsInfo> departmentRooms = new List<HRDepartmentRoomsInfo>();
            List<ICShipmentItemsInfo> ListShipmentItems = new List<ICShipmentItemsInfo>();
            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            string departmentRoomNos = string.Empty;
            if (departmentRoomID > 0)
            {
                HRDepartmentRoomsInfo departmentRoom = departmentRoomController.GetObjectByID(departmentRoomID) as HRDepartmentRoomsInfo;
                departmentRoomNos = departmentRoom.HRDepartmentRoomNo;
                departmentRooms.Add(departmentRoom);
            }
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            else //if (stockID == 0)
            {
                departmentRooms = departmentRoomController.GetRoomListByBranchNos(branchNos);
                foreach (HRDepartmentRoomsInfo departmentRoom in departmentRooms)
                {
                    if (!string.IsNullOrEmpty(departmentRoomNos))
                        departmentRoomNos += ";";
                    departmentRoomNos += departmentRoom.HRDepartmentRoomNo;
                }
            }

            ListShipmentItems = objShipmentItemsController.GetListShipmentItemForReport146(Todate, departmentRoomNos, branchNos);
            fld_dgcRP146Equipment1.DataSource = ListShipmentItems;

        }
        private void fld_btnExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.InitialDirectory = @"C:\";

                saveFileDialog1.Title = "Save Files";

                saveFileDialog1.DefaultExt = "xlsx";

                saveFileDialog1.Filter = "Excel files (*.xls)|*.xls|(*.xlsx)|*.xlsx|All files (*.*)|*.*";

                saveFileDialog1.FilterIndex = 2;

                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    string fileName = saveFileDialog1.FileName;

                    fld_dgcRP146Equipment1.ExportToXlsx(fileName);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The process cannot access the file") && ex.Message.Contains("because it is being used by another process."))
                    MessageBox.Show(ReportLocalizedResources.CannotExportToExcelFileBecauseTheFileIsBeingUsedByAnotherProcessMessage,
                                    ReportLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show(ReportLocalizedResources.ExportExelFileUnsuccessfullyMessage,
                                    ReportLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bosButton2_Click(object sender, EventArgs e)
        {
            GeneralData();
        }
    }

}
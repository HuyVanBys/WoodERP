using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP133 : ReportForm
    {
        /// <summary>
        /// A variable to store the asset list for selecting
        /// </summary>
        private List<ICDepartmentsInfo> departmentList;


        public RP133()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void RP093_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromDate.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            fld_dteSearchToDate.DateTime = BOSUtil.GetMonthEndDate();

            ICDepartmentsController objDepartmentsController = new ICDepartmentsController();
            departmentList = objDepartmentsController.GetallObjects();
            fld_cmbDepartments.Properties.DataSource = departmentList;
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

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
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

                    fld_dgcRP133PurchaseOrderItem.ExportToXlsx(fileName);
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

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            GetDataSearch();
        }

        public void GetDataSearch()
        {
            int purchaseOrderID = 0;
            int employeeID = 0;

            List<ICDepartmentsInfo> selectedDeepartments = GetDepartmentList();
            string departmentNoList = string.Empty;
            if (selectedDeepartments != null && selectedDeepartments.Count != 0)
            {
                foreach (ICDepartmentsInfo selectedStock in selectedDeepartments)
                {
                    if (!string.IsNullOrEmpty(departmentNoList))
                        departmentNoList += ", ";
                    departmentNoList += selectedStock.ICDepartmentNo;
                }
            }
            else
            {
                if (selectedDeepartments == null)
                    selectedDeepartments = new List<ICDepartmentsInfo>();
                selectedDeepartments.Add(new ICDepartmentsInfo());
            }


            //int.TryParse(fld_cmbDepartments.EditValue.ToString(), out fld_cmbDepartments);
            if (fld_lkeHREmployeeID.EditValue != null)
                int.TryParse(fld_lkeHREmployeeID.EditValue.ToString(), out employeeID);
            if (fld_lkeFK_APPurchaseOrderID.EditValue != null)
                int.TryParse(fld_lkeFK_APPurchaseOrderID.EditValue.ToString(), out purchaseOrderID);
            DateTime searchFromDate = fld_dteSearchFromDate.DateTime;
            DateTime searchToDate = fld_dteSearchToDate.DateTime;
            ADReportsController objReportsController = new ADReportsController();
            List<APPurchaseOrderItemsInfo> PurchaseOrderItemList = objReportsController.GetPurchaseOrderItemForReport(searchFromDate, searchToDate, purchaseOrderID, departmentNoList, employeeID);
            fld_dgcRP133PurchaseOrderItem.DataSource = PurchaseOrderItemList;
        }

        public List<ICDepartmentsInfo> GetDepartmentList()
        {
            List<ICDepartmentsInfo> departmentLists = new List<ICDepartmentsInfo>();
            string[] depatmentIDs = fld_cmbDepartments.EditValue.ToString().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            if (depatmentIDs.Length > 0)
            {
                for (int i = 0; i < depatmentIDs.Length; i++)
                {
                    int departmentID = Convert.ToInt32(depatmentIDs[i]);
                    ICDepartmentsInfo department = departmentList.FirstOrDefault(item => item.ICDepartmentID == departmentID);
                    if (department != null)
                        departmentLists.Add(department);
                }
            }
            return departmentLists;
        }
    }
}

using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP093 : ReportForm
    {
        /// <summary>
        /// A variable to store the asset list for selecting
        /// </summary>
        private List<ACAssetsInfo> AssetList;

        public RP093()
        {
            InitializeComponent();
        }

        private void RP093_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteToDate.DateTime = BOSUtil.GetMonthEndDate();
            GetAssetDataSource();
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


        /// <summary>
        /// Init the data source for the report
        /// </summary>
        /// <param name="report">Given report</param>        
        public void GetAssetDataSource()
        {

            string assetType = Convert.ToString(fld_lkeAssetType.EditValue);
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
            List<BRBranchsInfo> selectedBranches = GetSelectedBranchesByBranchID(branchID);
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END
            int roomID = Convert.ToInt32(fld_lkeHRDepartmentRoomID.EditValue);
            DateTime toDate = fld_dteToDate.DateTime;


            ACAssetsController objAssetsController = new ACAssetsController();
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            List<ACAssetsInfo> assetList = new List<ACAssetsInfo>();
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
            if (toDate != DateTime.MinValue)
            {
                //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
                foreach (BRBranchsInfo branch in selectedBranches)
                {
                    List<ACAssetsInfo> list = objAssetsController.GetAssetsBySomeCriteria(null, toDate, assetType, branch.BRBranchID, roomID);
                    assetList.AddRange(list);
                }
                //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
                if (assetList == null)
                    assetList = new List<ACAssetsInfo>();
            }

            fld_dgcRP093Assets.DataSource = assetList;
        }

        private void fld_dteToDate_EditValueChanged(object sender, EventArgs e)
        {
            GetAssetDataSource();
        }

        private void fld_lkeBRBranchID_EditValueChanged(object sender, EventArgs e)
        {
            GetAssetDataSource();
        }

        private void fld_lkeHRDepartmentRoomID_EditValueChanged(object sender, EventArgs e)
        {
            GetAssetDataSource();
        }

        private void fld_lkeAssetType_EditValueChanged(object sender, EventArgs e)
        {
            GetAssetDataSource();
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

                    fld_dgcRP093Assets.ExportToXlsx(fileName);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The process cannot access the file") && ex.Message.Contains("because it is being used by another process."))
                    MessageBox.Show(ReportLocalizedResources.CannotExportToExcelFileBecauseTheFileIsBeingUsedByAnotherProcessMessage,
                                    CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show(ReportLocalizedResources.ExportExelFileUnsuccessfullyMessage,
                                    CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}

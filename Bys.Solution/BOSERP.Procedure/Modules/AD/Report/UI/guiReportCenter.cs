using BOSCommon;
using BOSLib;
using DevExpress.Data;
using DevExpress.XtraGrid;
using Localization;
using System;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class guiReportCenter : BOSERPScreen
    {
        #region Declare Constant
        #endregion

        public guiReportCenter()
        {
            InitializeComponent();

            ADReportsController objReportsController = new ADReportsController();
            DataSet ds = objReportsController.GetReportByReportTypeAndReportPermission(ReportModule.cstReportTypeSale, BOSApp.CurrentUserGroupInfo.ADUserGroupID, Convert.ToByte(FieldPermissionType.None));
            if (ds.Tables.Count > 0)
                fld_dgcReports.DataSource = ds.Tables[0];

            fld_dgvReports.Columns["ADReportSection"].Group();
            GridGroupSummaryItem summaryItem = (GridGroupSummaryItem)fld_dgvReports.GroupSummary.Add(SummaryItemType.Average, "ADReportSortOrder");
            //summaryItem.ShowInGroupColumnFooter = fld_dgvReports.Columns["ADReportSection"];             
            fld_dgvReports.GroupSummarySortInfo.Add(summaryItem, ColumnSortOrder.Ascending, fld_dgvReports.Columns["ADReportSection"]);
        }

        private void navBarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ADReportsController objReportsController = new ADReportsController();
            DataSet ds = objReportsController.GetReportByReportTypeAndReportPermission(e.Link.Item.Tag.ToString(), BOSApp.CurrentUserGroupInfo.ADUserGroupID, Convert.ToByte(FieldPermissionType.None));
            if (ds.Tables.Count > 0)
                fld_dgcReports.DataSource = ds.Tables[0];
        }
        public bool ViewReportByTemplate(ADReportsInfo objADReportsInfo)
        {
            if (objADReportsInfo == null) return false;

            ADReportTemplatesInfo objADReportTemplatesInfo = (ADReportTemplatesInfo)new ADReportTemplatesController().GetFirstObjectByForeignColumn("FK_ADReportID", objADReportsInfo.ADReportID);
            if (objADReportTemplatesInfo != null)
            {
                ADTemplatesInfo objADTemplatesInfo = (ADTemplatesInfo)new ADTemplatesController().GetObjectByID(objADReportTemplatesInfo.FK_ADTemplateID);
                if (objADTemplatesInfo != null)
                {
                    ReportFormView formView = new ReportFormView();
                    formView.GridControlName = objADTemplatesInfo.ADTemplateNo;
                    formView.DataSourceName = objADTemplatesInfo.ADTemplateDataSource;
                    formView.TemplateID = objADTemplatesInfo.ADTemplateID;
                    formView.TemplateName = objADTemplatesInfo.ADTemplateName;
                    formView.Module = this.Module;
                    if (objADReportsInfo.ADReportViewType == ReportViewType.Form.ToString())
                        formView.MdiParent = BOSApp.MainScreen;
                    formView.GetBranchListByUserPermission();
                    formView.InitParam();
                    formView.InitGridView();
                    formView.StartPosition = FormStartPosition.CenterScreen;
                    formView.Show();
                    return true;
                }
            }
            return false;
        }

        private void fld_dgvReports_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Column.FieldName == "ADReportName")
            {
                //Sửa lại form hiển thị danh sách report tách làm 2 loại (loại query thì hiển thị form query, loại bản in thì hiển thị form nhập parameter => hiển thị bản in)
                DataRow row = fld_dgvReports.GetDataRow(e.RowHandle);
                ADReportsInfo objADReportsInfo = (ADReportsInfo)new ADReportsController().GetObjectFromDataRow(row);

                if (ViewReportByTemplate(objADReportsInfo))
                {
                    return;
                }

                ReportForm form = (ReportForm)BaseClassFactory.GetClass(String.Format("BOSERP.Modules.Report.{0}", row["ADReportNo"].ToString()));
                if (form != null && e.CellValue.ToString() != ReportLocalizedResources.ReportBudgetTracking)
                {
                    if (row["ADReportViewType"].ToString() == ReportViewType.Form.ToString())
                        form.MdiParent = BOSApp.MainScreen;
                    form.Module = this.Module;
                    form.GetBranchListByUserPermission();
                    form.Show();
                }
            }
        }
    }
}
using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP010 : ReportForm
    {
        public RP010()
        {
            InitializeComponent();
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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


        private void RP010_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_lblBranchName.Text = ((BRBranchsInfo)new BRBranchsController().GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID)).BRBranchName;

            fld_btnApply_Click(new object(), new EventArgs());
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            StringBuilder queryBuilder = new StringBuilder();
            queryBuilder.Append(GenerateSearchQuery(BOSUtil.GetTableNameFromBusinessObjectType(typeof(ARSaleOrdersInfo))));
            DataSet ds = new ARSaleOrdersController().GetDataSet(queryBuilder.ToString());
            if (ds.Tables.Count > 0)
            {
                fld_dgcARRP010SaleOrders.DataSource = ds.Tables[0];
                fld_dgcARRP010SaleOrders.RefreshDataSource();
            }
        }

        private void fld_btnExcel_Click(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)fld_dgcARRP010SaleOrders.MainView;
            ExportToExcel(gridView);
        }

        #region Initialize export excel parameter
        protected override List<ExportExcelParameter> GetReportHeader()
        {
            List<ExportExcelParameter> lstHeaderParameter = base.GetReportHeader();
            lstHeaderParameter.Add(SetDefaultHeaderParameter(fld_lblBranchName.Text, 1, 5));
            lstHeaderParameter.Add(SetDefaultSubHeaderParameter(fld_lblTitle.Text, 2, 5));
            return lstHeaderParameter;
        }
        #endregion
    }
}
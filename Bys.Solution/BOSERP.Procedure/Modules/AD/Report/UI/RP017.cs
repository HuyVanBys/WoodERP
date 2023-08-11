using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP017 : ReportForm
    {
        public RP017()
        {
            InitializeComponent();
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            StringBuilder queryBuilder = new StringBuilder();
            queryBuilder.Append(GenerateSearchQuery(BOSUtil.GetTableNameFromBusinessObjectType(typeof(APReturnSuppliersInfo))));
            DataSet ds = new APReturnSuppliersController().GetDataSet(queryBuilder.ToString());
            fld_dgcAPRP017ReturnSuppliers.DataSource = ds.Tables[0];
            fld_dgcAPRP017ReturnSuppliers.RefreshDataSource();
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
        private void RP017_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_btnApply_Click(new object(), new EventArgs());
        }

        private void fld_btnExcel_Click(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)fld_dgcAPRP017ReturnSuppliers.MainView;
            ExportToExcel(gridView);
        }

        #region Initialize export excel parameter
        protected override List<ExportExcelParameter> GetReportHeader()
        {
            List<ExportExcelParameter> lstHeaderParameter = base.GetReportHeader();
            lstHeaderParameter.Add(SetDefaultHeaderParameter(fld_lblTitle.Text, 1, 4));
            return lstHeaderParameter;
        }
        #endregion
    }
}
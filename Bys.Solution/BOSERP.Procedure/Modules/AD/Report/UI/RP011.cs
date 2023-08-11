using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP011 : ReportForm
    {
        public RP011()
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

        private void RP011_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            if (!Module.Controls.Contains(fld_lkeFK_ARCustomerID.Name))
                Module.Controls.Add(fld_lkeFK_ARCustomerID.Name, fld_lkeFK_ARCustomerID);

            fld_btnApply_Click(new object(), new EventArgs());
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            StringBuilder queryBuilder = new StringBuilder();
            queryBuilder.Append(GenerateSearchQuery(BOSUtil.GetTableNameFromBusinessObjectType(typeof(ARInvoicesInfo))));
            queryBuilder.Append(String.Format("AND ARInvoiceTypeCombo = '{0}'", ADConfigValueUtility.cstOpenDocumentTypeLayBy));
            if (Convert.ToInt32(fld_lkeARSaleOrderNo.EditValue) > 0)
            {
                String strSaleOrderNumber = ((ARSaleOrdersInfo)new ARSaleOrdersController().GetObjectByID((int)fld_lkeARSaleOrderNo.EditValue)).ARSaleOrderNo;
                queryBuilder.Append(String.Format("AND ARInvoiceReference = '{0}'", strSaleOrderNumber));
            }
            DataSet ds = new ARInvoicesController().GetDataSet(queryBuilder.ToString());
            fld_dgcARRP011Invoices.DataSource = ds.Tables[0];
            fld_dgcARRP011Invoices.RefreshDataSource();
        }

        private void fld_btnExcel_Click(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)fld_dgcARRP011Invoices.MainView;
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
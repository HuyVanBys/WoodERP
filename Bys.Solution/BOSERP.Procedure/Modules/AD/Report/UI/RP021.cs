using DevExpress.XtraCharts;
using System;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP021 : ReportForm
    {
        public RP021()
        {
            InitializeComponent();
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            InitializeDataChartControl(fld_lblAxisX.Text.Trim(), fld_lblAxisY.Text.Trim());
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RP021_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            InitializeDataChartControl(fld_lblAxisX.Text.Trim(), fld_lblAxisY.Text.Trim());
        }

        public void InitializeDataChartControl(String strDataAxisX, String strDataAxisY)
        {
            String strGroupBy = String.Empty;
            if (strDataAxisX.Contains("Department"))
                strGroupBy = "ii.FK_ICDepartmentID";
            else if (strDataAxisX.Contains("Category"))
                strGroupBy = "ii.FK_ICProductGroupID";
            else
                strGroupBy = "s.APSupplierID";

            DateTime fromDate = Convert.ToDateTime(fld_dteSearchFromARInvoiceDate.EditValue);
            DateTime toDate = Convert.ToDateTime(fld_dteSearchToARInvoiceDate.EditValue);
            String strQuery = ((ReportModule)Module).GenerateInvoiceItemSearchQuery(fromDate, toDate, 0, 0, 0, 0, strGroupBy);
            DataSet dsInvoiceItems = new ARInvoiceItemsController().GetDataSet(strQuery);
            BOSList<ARInvoiceItemsInfo> lstARInvoiceItems = new BOSList<ARInvoiceItemsInfo>();
            fld_cctrlARRP021InvoiceItems.Series[0].Points.Clear();
            if (dsInvoiceItems != null)
            {
                ICDepartmentsController objDepartmentsController = new ICDepartmentsController();
                ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
                APSuppliersController objSuppliersController = new APSuppliersController();
                foreach (DataRow row in dsInvoiceItems.Tables[0].Rows)
                {
                    ARInvoiceItemsInfo objARInvoiceItemsInfo = (ARInvoiceItemsInfo)new ARInvoiceItemsController().GetObjectFromDataRow(row);
                    if (objARInvoiceItemsInfo != null)
                    {
                        String strArgumemtName = String.Empty;
                        if (strGroupBy.Contains("Department"))
                            strArgumemtName = objDepartmentsController.GetObjectNameByID(objARInvoiceItemsInfo.FK_ICDepartmentID);
                        else if (strGroupBy.Contains("ProductGroup"))
                            strArgumemtName = objProductGroupsController.GetObjectNameByID(objARInvoiceItemsInfo.FK_ICProductGroupID);
                        else
                            strArgumemtName = objSuppliersController.GetObjectNameByID(Convert.ToInt32(row["APSupplierID"]));
                        if (!String.IsNullOrEmpty(strArgumemtName))
                        {
                            if (strDataAxisY.Contains("Cost"))
                                fld_cctrlARRP021InvoiceItems.Series[0].Points.Add(new SeriesPoint(strArgumemtName, new double[] { Convert.ToDouble(objARInvoiceItemsInfo.ARInvoiceItemTotalCost) }));
                            else if (strDataAxisY.Contains("Qty"))
                                fld_cctrlARRP021InvoiceItems.Series[0].Points.Add(new SeriesPoint(strArgumemtName, new double[] { Convert.ToDouble(objARInvoiceItemsInfo.ARInvoiceItemProductQty) }));
                            else
                                fld_cctrlARRP021InvoiceItems.Series[0].Points.Add(new SeriesPoint(strArgumemtName, new double[] { Convert.ToDouble(objARInvoiceItemsInfo.ARInvoiceItemNetAmount) }));
                        }

                    }

                }
            }
        }

        private void axisYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fld_lblAxisY.Text = (sender as ToolStripMenuItem).Text;
            InitializeDataChartControl(fld_lblAxisX.Text.Trim(), fld_lblAxisY.Text.Trim());
        }

        private void axisXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fld_lblAxisX.Text = (sender as ToolStripMenuItem).Text;
            InitializeDataChartControl(fld_lblAxisX.Text.Trim(), fld_lblAxisY.Text.Trim());
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
    }
}
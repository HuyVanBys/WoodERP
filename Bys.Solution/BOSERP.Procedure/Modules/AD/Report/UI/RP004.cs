using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP004 : ReportForm
    {
        private int ICProductGroupID;

        public RP004()
        {
            InitializeComponent();
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            BOSList<BRBranchsInfo> lstBranches = new BOSList<BRBranchsInfo>(null, String.Empty, BOSUtil.GetTableNameFromBusinessObjectType(typeof(BRBranchsInfo)));
            lstBranches.Invalidate((DataSet)BOSApp.LookupTables["BRBranchs"]);

            DateTime fromDate = Convert.ToDateTime(fld_dteSearchFromARInvoiceDate.EditValue);
            DateTime toDate = Convert.ToDateTime(fld_dteSearchToARInvoiceDate.EditValue);
            int iDepartmentID = Convert.ToInt32(fld_lkeFK_ICDepartmentID.EditValue);
            int iProductGroupID = ICProductGroupID;
            int iSupplierID = Convert.ToInt32(fld_lkeFK_APSupplierID.EditValue);
            String strQuery = ((ReportModule)Module).GenerateInvoiceItemSearchQuery(fromDate, toDate, iDepartmentID, iProductGroupID, iSupplierID, 0, "ii.FK_ICDepartmentID, ii.FK_ICProductGroupID, ii.FK_ICProductID, i.FK_BRBranchID");
            ARInvoiceItemsController objInvoiceItemsController = new ARInvoiceItemsController();
            DataSet ds = objInvoiceItemsController.GetDataSet(strQuery);
            if (ds.Tables.Count > 0)
            {
                ds.Tables[0].Columns.Add("ARInvoiceItemSupplierName");
                ds.Tables[0].Columns.Add("ARInvoiceItemProductDesc");
                ds.Tables[0].Columns.Add("ARInvoiceItemProductAttribute");
                foreach (BRBranchsInfo objBranchsInfo in lstBranches)
                    ds.Tables[0].Columns.Add(objBranchsInfo.BRBranchID.ToString(), typeof(double));

                DataRowCollection rows = ds.Tables[0].Rows;
                for (int i = 0; i < rows.Count; i++)
                {
                    foreach (BRBranchsInfo objBranchsInfo in lstBranches)
                        rows[i][objBranchsInfo.BRBranchID.ToString()] = 0;
                    rows[i][rows[i]["FK_BRBranchID"].ToString()] = rows[i]["ARInvoiceItemProductQty"];
                    for (int j = i + 1; j < rows.Count; j++)
                        if (rows[j]["FK_ICProductID"].Equals(rows[i]["FK_ICProductID"]))
                        {
                            rows[i][rows[j]["FK_BRBranchID"].ToString()] = rows[j]["ARInvoiceItemProductQty"];
                            ds.Tables[0].Rows.RemoveAt(j);
                            j--;
                        }
                }
                fld_dgcARRP004InvoiceItems.DataSource = ds.Tables[0];
                fld_dgcARRP004InvoiceItems.RefreshDataSource();
            }
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

        private void RP004_Load(object sender, EventArgs e)
        {
            //initalize search controller 
            InitializeControls(Controls);
            fld_btnApply_Click(new object(), new EventArgs());
        }

        private void fld_btnBrown_Click(object sender, EventArgs e)
        {
            ShowCategoryTree();
        }

        /// <summary>
        /// Show treelist category
        /// </summary>
        public void ShowCategoryTree()
        {
            int iDepartmentID = 0;
            int productGroupID = 0;
            ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
            productGroupID = objProductGroupsController.GetObjectIDByName(Convert.ToString(fld_txtFK_ICProductGroupID.EditValue));
            iDepartmentID = Convert.ToInt32(fld_lkeFK_ICDepartmentID.EditValue);
            guiProductGroupTree guiProductGroupTree = new guiProductGroupTree(productGroupID);
            guiProductGroupTree.Module = this.Module;
            guiProductGroupTree.ICDepartmentID = iDepartmentID;

            if (guiProductGroupTree.ShowDialog() == DialogResult.OK)
            {

                ICProductGroupsInfo objProductGroupsInfo = (ICProductGroupsInfo)guiProductGroupTree.TreeList.GetSelectedObject();
                if (objProductGroupsInfo != null)
                {
                    fld_txtFK_ICProductGroupID.Text = guiProductGroupTree.GetSelectedProductGroupName();
                    ICProductGroupID = objProductGroupsInfo.ICProductGroupID;
                    fld_lkeFK_ICDepartmentID.EditValue = guiProductGroupTree.ICDepartmentID;
                }
                else
                {
                    fld_txtFK_ICProductGroupID.Text = String.Empty;
                    ICProductGroupID = 0;
                }
            }
        }

        private String GetProductDescription(int iProductID)
        {
            ICProductsInfo objICProductsInfo = (ICProductsInfo)new ICProductsController().GetObjectByID(iProductID);
            if (objICProductsInfo != null)
                return objICProductsInfo.ICProductDesc;
            return String.Empty;

        }

        private void fld_btnExcel_Click(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)fld_dgcARRP004InvoiceItems.MainView;
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
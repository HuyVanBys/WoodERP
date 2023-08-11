using BOSCommon;
using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.BarCode
{
    public partial class guiAddProducts : BOSERPScreen
    {
        #region Variables

        public List<ICProductsInfo> SelectedObjects { get; set; }
        public int ICProductGroupID { get; private set; }
        #endregion

        public guiAddProducts()
        {
            InitializeComponent();
        }

        private void guiAddWorkGroup_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
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

        private void fld_btnClosed_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fld_btnFind_Click(object sender, EventArgs e)
        {
            int departmentID = 0;
            int supplierID = 0;
            string productBarCode = "";
            string productNo = "";
            int productGroupID = 0;
            
            if (fld_lkeFK_ICDepartmentID.EditValue != null)
                int.TryParse(fld_lkeFK_ICDepartmentID.EditValue.ToString(), out departmentID);
            if (fld_lkeFK_APSupplierID.EditValue != null)
                int.TryParse(fld_lkeFK_APSupplierID.EditValue.ToString(), out supplierID);
            if (fld_txtProductBarCode.EditValue != null)
                productBarCode = fld_txtProductBarCode.EditValue.ToString();
            if (fld_txtICProductNo.EditValue != null)
                productNo = fld_txtICProductNo.EditValue.ToString();
            ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
            productGroupID = objProductGroupsController.GetObjectIDByName(Convert.ToString(fld_txtFK_ICProductGroupID.EditValue));

            GridView gridView = (GridView)fld_dgcICProducts.MainView;
            ICProductsController objProductsController = new ICProductsController();
            List<ICProductsInfo> bindingList = new List<ICProductsInfo>();
            bindingList = objProductsController.GetBarcodeProductBySomeConditions(departmentID, productGroupID, productNo, supplierID, productBarCode);
            
            fld_dgcICProducts.DataSource = bindingList;
            fld_dgcICProducts.RefreshDataSource();
        }

        private void fld_btnChoose_Click(object sender, EventArgs e)
        {
            if (fld_dgcICProducts != null && fld_dgcICProducts.MainView != null)
            {
                GridView gridView = (GridView)fld_dgcICProducts.MainView;
                int[] rowSelected = gridView.GetSelectedRows();
                SelectedObjects = new List<ICProductsInfo>();
                foreach (int i in rowSelected)
                {
                    ICProductsInfo item = (ICProductsInfo)gridView.GetRow(i);

                    SelectedObjects.Add(item);
                }
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void fld_bedFK_ICProductGroupID_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void ShowCategoryTree()
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

        private void fld_txtFK_ICProductGroupID_Click(object sender, EventArgs e)
        {
            ShowCategoryTree();
        }
    }
}
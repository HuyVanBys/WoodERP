using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP
{
    public partial class guiItemList<T> : BOSERPScreen where T : BusinessObject
    {
        #region Variables
        private int ICProductGroupID;
        private bool ShowCheckColumn = false;
        #endregion

        #region Properties
        public List<ICProductsInfo> ProductList { get; set; }
        #endregion

        public guiItemList()
        {
            InitializeComponent();

            ProductList = new BOSList<ICProductsInfo>();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="showCheckColumn">Show first check column for selection</param>
        public guiItemList(bool showCheckColumn, IList<T> itemList)
        {
            InitializeComponent();

            BOSDbUtil dbUtil = new BOSDbUtil();
            ProductList = new List<ICProductsInfo>();
            fld_btnSearch_Click(new object(), new EventArgs());
            foreach (T obj in itemList)
            {
                int productID = dbUtil.GetPropertyIntValue(obj, "FK_ICProductID");
                foreach (ICProductsInfo objProductsInfo in ProductList)
                {
                    if (objProductsInfo.ICProductID == productID)
                    {
                        objProductsInfo.Selected = true;
                    }
                }
            }

            ShowCheckColumn = showCheckColumn;
        }

        private void guiItemList_Load(object sender, EventArgs e)
        {
            //Init grid control
            fld_dgcICProducts.Screen = this;
            fld_dgcICProducts.InitializeControl();

            DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)fld_dgcICProducts.MainView;
            //Init grid columns
            if (ShowCheckColumn)
            {
                gridView.Columns.AddVisible("Selected", CommonLocalizedResources.Selected).VisibleIndex = 0;
                gridView.Columns["Selected"].OptionsColumn.AllowEdit = true;
            }

            fld_lkeFK_ICDepartmentID.Screen = this;
            fld_lkeFK_ICDepartmentID.InitializeControl();
            fld_lkeFK_APSupplierID.Screen = this;
            fld_lkeFK_APSupplierID.InitializeControl();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void fld_btnAdd_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Search product by deparment,Category and supplier
        /// </summary>
        private void fld_btnSearch_Click(object sender, EventArgs e)
        {
            ICProductsController objProductsController = new ICProductsController();
            //NUThao [EDIT] [08/04/2014] [DB centre] [CSCompany issue], START
            //ProductList = objProductsController.GetProductList(Convert.ToInt32(fld_lkeFK_ICDepartmentID.EditValue),
            //                                            ICProductGroupID,
            //                                            Convert.ToInt32(fld_lkeFK_APSupplierID.EditValue), null);
            int companyID = BOSApp.CurrentCompanyInfo.CSCompanyID;
            ProductList = objProductsController.GetProductList(companyID, Convert.ToInt32(fld_lkeFK_ICDepartmentID.EditValue),
                                                        ICProductGroupID,
                                                        Convert.ToInt32(fld_lkeFK_APSupplierID.EditValue), null);
            //NUThao [EDIT] [08/04/2014] [DB centre] [CSCompany issue], END
            fld_dgcICProducts.DataSource = ProductList;
            fld_dgcICProducts.RefreshDataSource();
        }

        private void fld_chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            foreach (ICProductsInfo objProductsInfo in ProductList)
                objProductsInfo.Selected = fld_chkSelectAll.Checked;
            fld_dgcICProducts.RefreshDataSource();
        }

        private void fld_bteFK_ICProductGroupID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
            int productGroupID = objProductGroupsController.GetObjectIDByName(Convert.ToString(fld_bteFK_ICProductGroupID.EditValue));
            guiProductGroupTree guiProductGroupTree = new guiProductGroupTree(productGroupID);
            guiProductGroupTree.Module = Module;
            guiProductGroupTree.ICDepartmentID = Convert.ToInt32(fld_lkeFK_ICDepartmentID.EditValue);
            if (guiProductGroupTree.ShowDialog() == DialogResult.OK)
            {
                ICProductGroupsInfo objProductGroupsInfo = (ICProductGroupsInfo)guiProductGroupTree.TreeList.GetSelectedObject();
                if (objProductGroupsInfo != null)
                {
                    fld_bteFK_ICProductGroupID.Text = guiProductGroupTree.GetSelectedProductGroupName();
                    ICProductGroupID = objProductGroupsInfo.ICProductGroupID;
                    fld_lkeFK_ICDepartmentID.EditValue = guiProductGroupTree.ICDepartmentID;
                }
                else
                {
                    fld_bteFK_ICProductGroupID.Text = String.Empty;
                    ICProductGroupID = 0;
                }
            }
        }
    }
}
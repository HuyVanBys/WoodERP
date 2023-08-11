using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BOSLib;
using BOSComponent;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using Localization;
using BOSCommon;
using System.Linq;

namespace BOSERP.Modules.DiscountProgram
{
    public partial class guiAddProduct : BOSERPScreen
    {
        #region Variables
        public List<ICProductsInfo> ProductsList { get; set; }

        public List<ICProductsInfo> SelectedObjects { get; set; }

        public string ProductGroupReference { get; set; }

        public guiAddProduct()
        {
            InitializeComponent();
            ProductsList = new List<ICProductsInfo>();
        }
        #endregion
        public guiAddProduct(List<ICProductsInfo> productsList)
        {
            InitializeComponent();
            ProductsList = productsList;
        }

        private void guiAddProduct_Load(object sender, EventArgs e)
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

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            SelectedObjects = ProductsList.Where(s => s.Selected == true).ToList();
            if (SelectedObjects.Count == 0)
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Fld_btnFind_Click(object sender, EventArgs e)
        {
            int departmentID = Convert.ToInt32(fld_lkeFK_ICDepartmentID.EditValue);
            string productNo = Convert.ToString(fld_txtICProductNo.EditValue);
            ICProductsController objProductsController = new ICProductsController();
            ProductsList = objProductsController.GetProductListForDiscountProgram(departmentID, ProductGroupReference, productNo);
            fld_dgcProductsGridControl.DataSource = ProductsList;
            fld_dgcProductsGridControl.RefreshDataSource();
        } 

        private void Fld_bedICProductGroupID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ShowCategoryTree();
        }

        public void ShowCategoryTree()
        {
            int departmentID = 0;
            departmentID = Convert.ToInt32(fld_lkeFK_ICDepartmentID.EditValue);
            ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
            int productGroupID = objProductGroupsController.GetObjectIDByName(Convert.ToString(fld_bedICProductGroupID.EditValue));
            guiProductGroupTree guiProductGroupTree = new guiProductGroupTree(productGroupID);
            guiProductGroupTree.AllowMultipleSelect = true;
            guiProductGroupTree.Module = this.Module;
            guiProductGroupTree.ICDepartmentID = departmentID;

            if (guiProductGroupTree.ShowDialog() == DialogResult.OK)
            {
                if (guiProductGroupTree.SelectedObjects != null)
                {
                    fld_bedICProductGroupID.Text = guiProductGroupTree.GetSelectedProductGroupName();
                    ProductGroupReference = guiProductGroupTree.GetSelectedProductGroupReferenceID();
                }
                else
                {
                    fld_bedICProductGroupID.Text = String.Empty;
                    ProductGroupReference = string.Empty;
                }
            }
        }

        private void BosCheckEdit1_CheckedChanged(object sender, EventArgs e)
        {
            BOSCheckEdit bce = (BOSCheckEdit)sender;
            ProductsList.ForEach(i => i.Selected = bce.Checked);
            fld_dgcProductsGridControl.RefreshDataSource();
        }
    }
}
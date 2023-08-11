using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Alternative
{
    public partial class guiAddProduct : BOSERPScreen
    {
        #region Variables
        public BOSList<ICProductsInfo> ProductList { get; set; }

        public IList<ICProductsInfo> SelectedObjects { get; set; }

        private List<ICProductsInfo> DepartmentsList { get; set; }
        public ICProductsInfo Parent { get; set; }
        public List<ICProductsInfo> SelectedOld { get; set; }
        #endregion

        public guiAddProduct(List<ICProductsInfo> products)
        {
            InitializeComponent();
            ProductList = new BOSList<ICProductsInfo>("ICProducts");
            Parent = new ICProductsInfo();
            SelectedOld = products;
        }

        private void guiAddProduct_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            if (Parent != null && !string.IsNullOrEmpty(Parent.ICProductName))
            {
                fld_txtICProductHeight.EditValue = Parent.ICProductHeight;
                fld_txtICProductWidth.EditValue = Parent.ICProductWidth;

            }
            fld_dgcProductsGridControl.isMaterial = false;
            GetDataSource();
            if (fld_dgcProductsGridControl.Columns["ICProductItemQty"] != null)
                fld_dgcProductsGridControl.Columns["ICProductItemQty"].OptionsColumn.AllowEdit = true;
            fld_dgcProductsGridControl.InvalidateDataSource(ProductList);

        }
        public void ResetSelectOldObject()
        {
            foreach (ICProductsInfo item in SelectedOld)
            {
                ICProductsInfo found = ProductList.Where(o => o.ICProductID == item.ICProductID).FirstOrDefault();
                if (found != null) { found.ICProductItemQty = item.ICProductItemQty; found.Selected = true; }
            }
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
            SelectedObjects = ProductList.Where(s => s.Selected == true).ToList();
            if (SelectedObjects.Count == 0)
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void fld_btnFind_Click(object sender, EventArgs e)
        {
            GetDataSource();
        }



        private void fld_txtFind_Click(object sender, EventArgs e)
        {
            GetDataSource();
        }
        public void GetDataSource()
        {
            string carcassNo = fld_txtCarcassNo.Text.Trim();
            string carcassName = fld_txtCarcassName.Text.Trim();
            string semiNo = fld_txtSemiNo.Text.Trim();
            string semiName = fld_txtSemiName.Text.Trim();
            decimal heigth = 0;
            if (fld_txtICProductHeight.EditValue != null)
                decimal.TryParse(fld_txtICProductHeight.EditValue.ToString().Trim(), out heigth);
            decimal width = 0;
            if (fld_txtICProductWidth.EditValue != null)
                decimal.TryParse(fld_txtICProductWidth.EditValue.ToString().Trim(), out width);
            decimal length = 0;
            if (fld_txtICProductLength.EditValue != null)
                decimal.TryParse(fld_txtICProductLength.EditValue.ToString().Trim(), out length);
            int batchProductID = 0;
            int productGroupID = 0;
            if (fld_lkeICProductGroup.EditValue != null)
            {
                int.TryParse(fld_lkeICProductGroup.EditValue.ToString(), out productGroupID);
            }
            int collectionID = 0;
            int productMaterialID = 0;
            int customerID = 0;
            ICProductsController productCtrl = new ICProductsController();
            List<ICProductsInfo> carcassList = productCtrl.GetSemiProductFromProductAndSomeCriteria(carcassNo, carcassName, semiNo, semiName
                                                           , heigth, width, length, batchProductID
                                                           , productGroupID, collectionID, productMaterialID, customerID);
            if (carcassList != null && carcassList.Count > 0)
            {
                carcassList = carcassList.Where(o => o.ICProductID != Parent.ICProductID).ToList();
            }

            ProductList.Invalidate(carcassList);
            if (SelectedOld != null && SelectedOld.Count > 0)
                ResetSelectOldObject();
            fld_dgcProductsGridControl.RefreshDataSource();
        }

        private void Fld_btnFilter1_Click(object sender, EventArgs e)
        {
            GetDataSource();
        }
    }
}
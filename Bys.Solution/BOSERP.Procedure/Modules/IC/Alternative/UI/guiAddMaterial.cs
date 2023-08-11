using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Alternative
{
    public partial class guiAddMaterial : BOSERPScreen
    {
        #region Variables
        public BOSList<ICProductsInfo> ProductList { get; set; }

        public IList<ICProductsInfo> SelectedObjects { get; set; }

        private List<ICProductsInfo> DepartmentsList { get; set; }
        public ICProductsInfo Parent { get; set; }
        public List<ICProductsInfo> SelectedOld { get; set; }
        #endregion

        public guiAddMaterial(List<ICProductsInfo> products)
        {
            InitializeComponent();
            ProductList = new BOSList<ICProductsInfo>("ICProducts");
            Parent = new ICProductsInfo();
            SelectedOld = products;
        }

        private void guiAddMaterial_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            if (Parent != null && !string.IsNullOrEmpty(Parent.ICProductName))
            {
                fld_txtMaterialHeight.EditValue = Parent.ICProductHeight;
                fld_txtMaterialWidth.EditValue = Parent.ICProductWidth;
                fld_lkeICProductType.EditValue = Parent.ICProductType;
                fld_lkeMaterialGroup.EditValue = Parent.FK_ICProductGroupID;
            }
            fld_dgcProductsGridControl.isMaterial = true;
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
            string productNo = fld_txtMaterialNo.Text.Trim();
            string productName = fld_txtMaterialName.Text.Trim();
            string productType = fld_lkeICProductType.EditValue != null ? fld_lkeICProductType.EditValue.ToString() : null;
            decimal heigth = 0;
            if (fld_txtMaterialHeight.EditValue != null)
                decimal.TryParse(fld_txtMaterialHeight.EditValue.ToString().Trim(), out heigth);
            decimal width = 0;
            if (fld_txtMaterialWidth.EditValue != null)
                decimal.TryParse(fld_txtMaterialWidth.EditValue.ToString().Trim(), out width);
            decimal length = 0;
            if (fld_txtMaterialLength.EditValue != null)
                decimal.TryParse(fld_txtMaterialLength.EditValue.ToString().Trim(), out length);
            int productGroupID = 0;
            if (fld_lkeMaterialGroup.EditValue != null)
            {
                int.TryParse(fld_lkeMaterialGroup.EditValue.ToString(), out productGroupID);
            }
            int materialTypeID = 0;
            if (fld_lkeICProductAttributeID.EditValue != null)
            {
                int.TryParse(fld_lkeICProductAttributeID.EditValue.ToString(), out materialTypeID);
            }
            ICProductsController productCtrl = new ICProductsController();
            List<ICProductsInfo> materialList = productCtrl.GetMaterialProductBySomeCriteria(productNo, productName, productType
                                                            , heigth, width, length
                                                            , productGroupID, materialTypeID);

            if (materialList.Count() > 0)
            {
                materialList = materialList.Where(o => o.ICProductID != Parent.ICProductID).ToList();
            }

            ProductList.Invalidate(materialList);
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
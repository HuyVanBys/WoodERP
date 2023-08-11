using System;
namespace BOSERP.Modules.Alternative.UI
{
    /// <summary>
    /// Summary description for DMAL100
    /// </summary>
    public partial class DMAL100 : BOSERPScreen
    {

        public DMAL100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnFilter1_Click(object sender, EventArgs e)
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
            int productGroupID = 0;
            if (fld_lkeICProductGroup.EditValue != null)
            {
                int.TryParse(fld_lkeICProductGroup.EditValue.ToString(), out productGroupID);
            }
            ((AlternativeModule)this.Module).SearchSemiProduct(carcassNo, carcassName, semiNo, semiName, heigth, width, length, 0, productGroupID, 0, 0, 0);
        }

        private void Fld_btnSave_Click(object sender, EventArgs e)
        {
            ((AlternativeModule)this.Module).SaveAlternative();
        }

        private void fld_btnFilterMaterial_Click(object sender, EventArgs e)
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

            ((AlternativeModule)this.Module).SearchMaterialProduct(productNo, productName, productType, heigth, width, length, productGroupID, materialTypeID);
        }

        private void fld_btnSaveMaterial_Click(object sender, EventArgs e)
        {
            ((AlternativeModule)this.Module).SaveMaterialAlternative();
        }
    }
}

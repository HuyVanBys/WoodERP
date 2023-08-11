using BOSComponent;
using System;
using System.Drawing;
using System.IO;

namespace BOSERP.Modules.PackagingProduct.UI
{
    /// <summary>
    /// Summary description for DMPKP100
    /// </summary>
    public partial class DMPKP100 : BOSERPScreen
    {
        public DMPKP100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lnkEditPrice_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((PackagingProductModule)Module).ShowPriceLevelForm();
        }

        private void fld_lnkEditUnitOfMeasure_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((PackagingProductModule)Module).ShowMeasureOfUnits();
        }

        private void fld_bedICProductAttribute_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((PackagingProductModule)Module).ShowEditAttributeForm();
        }

        private void fld_btnMoveUp_Click(object sender, EventArgs e)
        {

        }

        private void fld_btnMoveDown_Click(object sender, EventArgs e)
        {

        }

        private void fld_lnkOpenSupplier_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((PackagingProductModule)Module).ShowSuppliersForm();
        }

        private void fld_lnkOpenBranchPrice_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((PackagingProductModule)Module).ShowProductBranchPrice();
        }

        private void fld_lnkSetDefaultDesc_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((PackagingProductModule)Module).SetDefaultProductDesc();
        }

        private void fld_lnkEditPurchasePrice_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((PackagingProductModule)Module).EditPurchasePriceByCurrency();
        }

        private void fld_bedFK_ICProductGroupID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((PackagingProductModule)Module).ShowCategoryTree();
        }
        private void fld_lnkShowHistoryBranchPrice_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((PackagingProductModule)Module).ShowProductBranchPriceHistory();
        }

        private void fld_txtICProductName_EditValueChanged(object sender, EventArgs e)
        {
            if (((PackagingProductModule)Module).Toolbar.IsNullOrNoneAction()) return;
            toolTipController1.HideHint();
            if (fld_txtICProductName.EditValue != null)
            {
                if (fld_txtICProductName.EditValue.ToString() == string.Empty)
                    return;
                string mess = ((PackagingProductModule)Module).FilterProduct(fld_txtICProductName.EditValue.ToString().ToLower());
                if (mess != string.Empty)
                {
                    Point toolTipLocation = fld_txtICProductName.PointToScreen(new Point(fld_txtICProductName.Width, fld_txtICProductName.Height));
                    toolTipController1.ShowHint(mess, "DS SP filter", toolTipLocation);
                }
            }

        }

        private void fld_lkeFK_ICProductTypeAccountConfigID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            int objectID = 0;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                Int32.TryParse(e.Value.ToString(), out objectID);
                ((PackagingProductModule)Module).ChangeProductTypeAccountConfig(objectID);
            }
        }

        private void fld_btnUpdateOverroll_Click(object sender, EventArgs e)
        {
            ((PackagingProductModule)Module).CalculateProductionNormItemPackaging(true);
        }

        private void fld_btnUpdateInside_Click(object sender, EventArgs e)
        {
            ((PackagingProductModule)Module).CalculateProductionNormItemPackaging(false);
        }

        private void fld_txtICProductOverallDimensionLength_Validated(object sender, EventArgs e)
        {
            ((PackagingProductModule)Module).CalculateBoxArea();
        }

        private void fld_txtICProductOverallDimensionWidth_Validated(object sender, EventArgs e)
        {
            ((PackagingProductModule)Module).CalculateBoxArea();
        }

        private void fld_txtICProductOverallDimensionHeight_Validated(object sender, EventArgs e)
        {
            ((PackagingProductModule)Module).CalculateBoxArea();
        }

        private void fld_txtICProductBoxUnitPrice_Validated(object sender, EventArgs e)
        {
            ((PackagingProductModule)Module).CalculateBoxArea();
        }

        private void fld_txtICProductBoxArea_Validated(object sender, EventArgs e)
        {
            ((PackagingProductModule)Module).CalculateBoxArea();
        }

        private void fld_txtFK_ICProdAttPackingMaterialSpecialityID_Validated(object sender, EventArgs e)
        {
            ((PackagingProductModule)Module).CalculateBoxArea();
        }

        private void fld_btnSaveProductMeasureUnit_Click(object sender, EventArgs e)
        {
            ((PackagingProductModule)Module).SaveProductMeasureUnitList();
        }

        private void Fld_bedICProductAttribute_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((PackagingProductModule)Module).ShowEditAttributeForm();
        }

        private void Fld_txtICProductInsideDimensionWidth_Validated(object sender, EventArgs e)
        {
            ((PackagingProductModule)Module).CalculateProductCapacity();
        }

        private void Fld_txtICProductInsideDimensionLength_Validated(object sender, EventArgs e)
        {
            ((PackagingProductModule)Module).CalculateProductCapacity();
        }

        private void Fld_txtICProductInsideDimensionHeight_Validated(object sender, EventArgs e)
        {
            ((PackagingProductModule)Module).CalculateProductCapacity();
        }

        private void fld_btnAddProductImageDefault_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"; ;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileInfo file = new FileInfo(openFileDialog1.FileName);
                ((PackagingProductModule)Module).UpdatePrimaryImage(file.FullName);
                //((ProductModule)Module).SetImageDefault(file.FullName);
                fld_ptbICProductPicture.Image = Image.FromFile(file.FullName);
            }
        }

        private void fld_lkeICProductType_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            ((PackagingProductModule)Module).SetDefaultAccountByProductType();
        }
    }
}

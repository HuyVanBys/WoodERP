using BOSCommon;
using BOSComponent;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
namespace BOSERP.Modules.Product.UI
{
    /// <summary>
    /// Summary description for DMPD100
    /// </summary>
    public partial class DMPD100 : BOSERPScreen
    {
        public DMPD100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
            this.fld_chkICProductLockedPurchaseOrder.Checked = false;
        }

        private void fld_lnkEditPrice_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((ProductModule)Module).ShowPriceLevelForm();
        }

        private void fld_lnkEditUnitOfMeasure_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((ProductModule)Module).ShowMeasureOfUnits();
        }

        private void fld_bedICProductAttribute_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((ProductModule)Module).ShowEditAttributeForm();
        }

        private void fld_btnMoveUp_Click(object sender, EventArgs e)
        {
            ((ProductModule)Module).SortProductComponentList("MoveUp");
        }

        private void fld_btnMoveDown_Click(object sender, EventArgs e)
        {
            ((ProductModule)Module).SortProductComponentList("MoveDown");
        }

        private void fld_lnkOpenSupplier_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((ProductModule)Module).ShowSuppliersForm();
        }

        private void fld_lnkOpenBranchPrice_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((ProductModule)Module).ShowProductBranchPrice();
        }

        private void fld_lnkSetDefaultDesc_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((ProductModule)Module).SetDefaultProductDesc();
        }

        private void fld_lnkEditPurchasePrice_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((ProductModule)Module).EditPurchasePriceByCurrency();
        }

        private void fld_bedFK_ICProductGroupID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((ProductModule)Module).ShowCategoryTree();
        }

        private void fld_lnkShowHistoryBranchPrice_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((ProductModule)Module).ShowProductBranchPriceHistory();
        }

        private void fld_lkeICProductIdentifyWoodType_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            int matchCodeID = Convert.ToInt32(fld_lkeICProductIdentifyWoodType.EditValue);
            if (matchCodeID == -1)
            {
                ((ProductModule)Module).CreateNewWoodType();
            }
        }

        private void fld_fld_bedICProductAttribute_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((ProductModule)Module).ShowEditAttributeForm();
        }

        private void fld_btnAddMoreProduct_Click(object sender, EventArgs e)
        {
            ((ProductModule)Module).ShowMoreProducts();
        }

        private void fld_kleICProductIdentifyColor_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            if (fld_kleICProductIdentifyColor.OldEditValue != e.Value)
            {
                int FK_ICProductAttributeColorID = 0;
                int.TryParse(e.Value.ToString(), out FK_ICProductAttributeColorID);
                if (FK_ICProductAttributeColorID > 0)
                {
                    ((ProductModule)Module).ChangeIdentifyColor(FK_ICProductAttributeColorID);
                }
            }
        }

        private void fld_ccbeColor_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            if (fld_ccbeColor.EditValue != e.Value)
            {
                ((ProductModule)Module).ChangeMoreColor(e.Value.ToString());
            }
        }

        private void fld_lkeICProductWorkType_Validated(object sender, EventArgs e)
        {
            ((ProductModule)Module).InvalidateProductOriginOfProduct();
        }
        private void fld_btnAddProductComponent_Click(object sender, EventArgs e)
        {
            ((ProductModule)Module).AddProductComponentToProductComponentList();
        }

        private void fld_btnAddProductWork_Click(object sender, EventArgs e)
        {
            ((ProductModule)Module).AddWorkToProductItemList();
        }

        private void fld_ccbeWoodType_QueryPopUp(object sender, CancelEventArgs e)
        {
            fld_ccbeWoodType.Properties.DataSource = ((ProductModule)Module).GetProductAttributeDatasource(ProductAttributeGroup.WoodType.ToString());
            fld_ccbeWoodType.Properties.DisplayMember = "ICProductAttributeValue";
            fld_ccbeWoodType.Properties.ValueMember = "ICProductAttributeID";
        }

        private void fld_ccbeColor_QueryPopUp(object sender, CancelEventArgs e)
        {
            fld_ccbeColor.Properties.DataSource = ((ProductModule)Module).GetProductAttributeDatasource(ProductAttributeGroup.COLOR.ToString());
            fld_ccbeColor.Properties.DisplayMember = "ICProductAttributeValue";
            fld_ccbeColor.Properties.ValueMember = "ICProductAttributeID";
        }

        private void fld_btnAddProductImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"; ;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileInfo file = new FileInfo(openFileDialog1.FileName);
                ((ProductModule)Module).AddImageToProductFilesList(file.FullName, false);
            }
        }

        private void fld_btnAddProductImageDefault_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"; ;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileInfo file = new FileInfo(openFileDialog1.FileName);
                ((ProductModule)Module).AddImageToProductFilesList(file.FullName, true);
                //((ProductModule)Module).SetImageDefault(file.FullName);
                fld_ptbICProductPicture.Image = Image.FromFile(file.FullName);
            }
        }

        private void fld_txtICProductName_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (((ProductModule)Module).Toolbar.IsNullOrNoneAction()) return;
            toolTipController1.HideHint();
            if (fld_txtICProductName.EditValue != null)
            {
                if (fld_txtICProductName.EditValue.ToString() == string.Empty)
                    return;
                string mess = ((ProductModule)Module).FilterProduct(fld_txtICProductName.EditValue.ToString().ToLower());
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
                ((ProductModule)Module).ChangeProductTypeAccountConfig(objectID);
            }
        }


        private void AddProductDetail_Click(object sender, EventArgs e)
        {
            ((ProductModule)Module).AddProductDetailToProductDetailList();
        }
        private void fld_lkeFK_ICProductCarcassID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            int chooseTempID = 0;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((ProductModule)Module).ChangeCarcass(Convert.ToInt32(e.Value));
                chooseTempID = int.Parse(e.Value.ToString());
            }
            if (chooseTempID > 0) fld_chkCarcass.Checked = false;
        }

        private void fld_btnSaveProductMeasureUnit_Click(object sender, EventArgs e)
        {
            ((ProductModule)Module).SaveProductMeasureUnitList();
        }
        private void fld_chkCarcass_CheckedChanged(object sender, EventArgs e)
        {
            BOSCheckEdit chk = (BOSCheckEdit)sender;
            //fld_lkeICProductIdentifyWoodType.Enabled = false;
            fld_lkeProductParentID.Enabled = false;
            if (chk.Checked)
            {
                //fld_lkeICProductIdentifyWoodType.Enabled = true;
                fld_lkeProductParentID.Enabled = true;
            }

            ((ProductModule)Module).InvalidateCarcass(chk.Checked);
        }

        private void fld_kleICProductIdentifyColor_CloseUp_1(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (lke != null && lke.OldEditValue != e.Value)
            {
                ((ProductModule)Module).ChangeProductAttribuiteFinishingByColor(Convert.ToInt32(e.Value));
            }
        }
		private void fld_chkHasComponent_CheckedChanged(object sender, EventArgs e)
        {
            fld_tabComponent.PageVisible = fld_chkHasComponent.Checked;
            fld_ckICProductIsFollowInventoryStock.Checked = !fld_chkHasComponent.Checked;
        }

        private void fld_btnAddProductComponentItem_Click(object sender, EventArgs e)
        {
            ((ProductModule)Module).AddProductComponentToProductComponentList();
        }

        private void fld_txtICProductImageFile_Click(object sender, EventArgs e)
        {
            string matchCode = Convert.ToString(fld_txtICProductImageFile.EditValue);
            if (!string.IsNullOrEmpty(matchCode))
            {
                //System.Diagnostics.Process.Start(matchCode);
            }
        }  
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ((ProductModule)Module).AddProductImage();
        }

        private void fld_pbxConverSize_Click(object sender, EventArgs e)
        {
            ((ProductModule)Module).ShowGuiConverSize();
        }
    }
}

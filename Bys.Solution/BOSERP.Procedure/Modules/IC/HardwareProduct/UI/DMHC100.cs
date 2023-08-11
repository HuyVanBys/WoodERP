using BOSComponent;
using System;
using System.Drawing;
using System.IO;

namespace BOSERP.Modules.HardwareProduct.UI
{
    /// <summary>
    /// Summary description for DMHC100
    /// </summary>
    public partial class DMHC100 : BOSERPScreen
    {

        public DMHC100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void DMHC100_Load(object sender, EventArgs e)
        {

        }

        private void fld_lnkSetDefaultDesc_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((HardwareProductModule)Module).SetDefaultProductDesc();
        }

        private void fld_bedFK_ICProductGroupID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((HardwareProductModule)Module).ShowCategoryTree();
        }



        private void fld_lnkOpenSupplier_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((HardwareProductModule)Module).ShowSuppliersForm();
        }

        private void fld_bedICProductAttribute_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((HardwareProductModule)Module).ShowEditAttributeForm();
        }

        private void fld_lnkEditPrice_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((HardwareProductModule)Module).ShowPriceLevelForm();
        }

        private void fld_lnkOpenBranchPrice_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((HardwareProductModule)Module).ShowProductBranchPrice();
        }

        private void fld_lnkEditPurchasePrice_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((HardwareProductModule)Module).EditPurchasePriceByCurrency();
        }

        private void fld_txtICProductName_EditValueChanged(object sender, EventArgs e)
        {
            if (((HardwareProductModule)Module).Toolbar.IsNullOrNoneAction()) return;
            toolTipController1.HideHint();
            if (fld_txtICProductName.EditValue != null)
            {
                if (fld_txtICProductName.EditValue.ToString() == string.Empty)
                    return;
                string mess = ((HardwareProductModule)Module).FilterProduct(fld_txtICProductName.EditValue.ToString().ToLower());
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
                ((HardwareProductModule)Module).ChangeProductTypeAccountConfig(objectID);
            }
        }

        private void fld_btnAddHardwareProductImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"; ;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileInfo file = new FileInfo(openFileDialog1.FileName);
                ((HardwareProductModule)Module).AddImageToProductFilesList(file.FullName, false);
            }
        }

        private void fld_btnAddProductImageDefault_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"; ;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileInfo file = new FileInfo(openFileDialog1.FileName);
                ((HardwareProductModule)Module).AddImageToProductFilesList(file.FullName, true);
                fld_ptbICProductPicture.Image = Image.FromFile(file.FullName);
            }
        }

        private void fld_btnShowProductComponent_Click(object sender, EventArgs e)
        {
            ((HardwareProductModule)Module).AddProductComponentToProductComponentList();
        }

        private void fld_btnAddProductComponentItem_Click(object sender, EventArgs e)
        {
            ((HardwareProductModule)Module).AddProductComponentToProductComponentList();
        }

        private void fld_btnSaveProductMeasureUnit_Click(object sender, EventArgs e)
        {
            ((HardwareProductModule)Module).SaveProductMeasureUnitList();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ((HardwareProductModule)Module).AddProductImage();
        }
        private void fld_txtICProductImageFile_DoubleClick(object sender, EventArgs e)
        {
            string matchCode = Convert.ToString(fld_txtICProductImageFile.EditValue);
            System.Diagnostics.Process.Start(matchCode);
        }
    }
}

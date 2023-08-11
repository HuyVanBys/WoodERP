using DevExpress.XtraEditors;
using System;
using System.Drawing;
using System.IO;

namespace BOSERP.Modules.DeviceProduct.UI
{
    /// <summary>
    /// Summary description for DMPD100
    /// </summary>
    public partial class DMDVP100 : BOSERPScreen
    {
        public DMDVP100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lnkEditPrice_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((DeviceProductModule)Module).ShowPriceLevelForm();
        }

        private void fld_lnkEditUnitOfMeasure_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((DeviceProductModule)Module).ShowMeasureOfUnits();
        }

        private void fld_bedICProductAttribute_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((DeviceProductModule)Module).ShowEditAttributeForm();
        }

        private void fld_btnMoveUp_Click(object sender, EventArgs e)
        {
            ((DeviceProductModule)Module).SortProductComponentList("MoveUp");
        }

        private void fld_btnMoveDown_Click(object sender, EventArgs e)
        {
            ((DeviceProductModule)Module).SortProductComponentList("MoveDown");
        }

        private void fld_lnkOpenSupplier_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((DeviceProductModule)Module).ShowSuppliersForm();
        }

        private void fld_lnkOpenBranchPrice_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((DeviceProductModule)Module).ShowProductBranchPrice();
        }

        private void fld_lnkSetDefaultDesc_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((DeviceProductModule)Module).SetDefaultProductDesc();
        }

        private void fld_lnkEditPurchasePrice_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((DeviceProductModule)Module).EditPurchasePriceByCurrency();
        }

        private void fld_bedFK_ICProductGroupID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((DeviceProductModule)Module).ShowCategoryTree();
        }
        private void fld_lnkShowHistoryBranchPrice_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((DeviceProductModule)Module).ShowProductBranchPriceHistory();
        }

        private void fld_lkeICProductTrademark_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;
            if (lke.OldEditValue != lke.EditValue)
                ((DeviceProductModule)Module).ShowTrademarkInProductDesc((int)lke.OldEditValue, lke.Text);
        }

        private void fld_btnAddProductImageDefault_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"; ;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileInfo file = new FileInfo(openFileDialog1.FileName);
                ((DeviceProductModule)Module).AddImageToProductFilesList(file.FullName, true);
                fld_ptbICProductPicture.Image = Image.FromFile(file.FullName);
            }
        }

        private void fld_btnAddDeviceProductImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"; ;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileInfo file = new FileInfo(openFileDialog1.FileName);
                ((DeviceProductModule)Module).AddImageToProductFilesList(file.FullName, false);
            }
        }

        private void fld_btnSaveProductMeasureUnit_Click(object sender, EventArgs e)
        {
            ((DeviceProductModule)Module).SaveProductMeasureUnitList();
        }

        private void Fld_lkeFK_ICProductTypeAccountConfigID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            ((DeviceProductModule)Module).ChangeProductTypeAccountConfig();
        }
    }
}

using BOSComponent;
using System;
using System.Drawing;
using System.IO;

namespace BOSERP.Modules.PaintProduct.UI
{
    /// <summary>
    /// Summary description for DMPAP100
    /// </summary>
    public partial class DMPAP100 : BOSERPScreen
    {
        public DMPAP100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lnkEditPrice_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((PaintProductModule)Module).ShowPriceLevelForm();
        }

        private void fld_lnkEditUnitOfMeasure_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((PaintProductModule)Module).ShowMeasureOfUnits();
        }

        private void fld_bedICProductAttribute_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((PaintProductModule)Module).ShowEditAttributeForm();
        }

        private void fld_btnMoveUp_Click(object sender, EventArgs e)
        {
            ((PaintProductModule)Module).SortProductComponentList("MoveUp");
        }

        private void fld_btnMoveDown_Click(object sender, EventArgs e)
        {
            ((PaintProductModule)Module).SortProductComponentList("MoveDown");
        }

        private void fld_lnkOpenSupplier_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((PaintProductModule)Module).ShowSuppliersForm();
        }

        private void fld_lnkOpenBranchPrice_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((PaintProductModule)Module).ShowProductBranchPrice();
        }

        private void fld_lnkSetDefaultDesc_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((PaintProductModule)Module).SetDefaultProductDesc();
        }

        private void fld_lnkEditPurchasePrice_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((PaintProductModule)Module).EditPurchasePriceByCurrency();
        }

        private void fld_bedFK_ICProductGroupID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((PaintProductModule)Module).ShowCategoryTree();
        }
        private void fld_lnkShowHistoryBranchPrice_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((PaintProductModule)Module).ShowProductBranchPriceHistory();
        }

        private void fld_txtICProductName_EditValueChanged(object sender, EventArgs e)
        {
            if (((PaintProductModule)Module).Toolbar.IsNullOrNoneAction()) return;
            toolTipController1.HideHint();
            if (fld_txtICProductName.EditValue != null)
            {
                if (fld_txtICProductName.EditValue.ToString() == string.Empty)
                    return;
                string mess = ((PaintProductModule)Module).FilterProduct(fld_txtICProductName.EditValue.ToString().ToLower());
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
                ((PaintProductModule)Module).ChangeProductTypeAccountConfig(objectID);
            }
        }

        private void fld_btnSaveProductMeasureUnit_Click(object sender, EventArgs e)
        {
            ((PaintProductModule)Module).SaveProductMeasureUnitList();
        }

        private void fld_btnAddProductImageDefault_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"; ;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileInfo file = new FileInfo(openFileDialog1.FileName);
                ((PaintProductModule)Module).UpdatePrimaryImage(file.FullName);
                //((ProductModule)Module).SetImageDefault(file.FullName);
                fld_ptbICProductPicture.Image = Image.FromFile(file.FullName);
            }
        }

        private void fld_lkeICProductType_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            ((PaintProductModule)Module).SetDefaultAccountByProductType();
        }
    }
}

using BOSCommon;
using BOSComponent;
using DevExpress.XtraEditors;
using System;
using System.Drawing;
using System.IO;

namespace BOSERP.Modules.OtherProduct.UI
{
    /// <summary>
    /// Summary description for DMPD100
    /// </summary>
    public partial class DMOP100 : BOSERPScreen
    {
        public DMOP100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lnkEditPrice_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((OtherProductModule)Module).ShowPriceLevelForm();
        }

        private void fld_lnkEditUnitOfMeasure_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((OtherProductModule)Module).ShowMeasureOfUnits();
        }

        private void fld_bedICProductAttribute_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((OtherProductModule)Module).ShowEditAttributeForm();
        }

        private void fld_btnMoveUp_Click(object sender, EventArgs e)
        {
            ((OtherProductModule)Module).SortProductComponentList("MoveUp");
        }

        private void fld_btnMoveDown_Click(object sender, EventArgs e)
        {
            ((OtherProductModule)Module).SortProductComponentList("MoveDown");
        }

        private void fld_lnkOpenSupplier_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((OtherProductModule)Module).ShowSuppliersForm();
        }

        private void fld_lnkOpenBranchPrice_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((OtherProductModule)Module).ShowProductBranchPrice();
        }

        private void fld_lnkSetDefaultDesc_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((OtherProductModule)Module).SetDefaultProductDesc();
        }

        private void fld_lnkEditPurchasePrice_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((OtherProductModule)Module).EditPurchasePriceByCurrency();
        }

        private void fld_bedFK_ICProductGroupID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((OtherProductModule)Module).ShowCategoryTree();
        }
        private void fld_lnkShowHistoryBranchPrice_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((OtherProductModule)Module).ShowProductBranchPriceHistory();
        }
        private void fld_txtICProductName_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (((OtherProductModule)Module).Toolbar.IsNullOrNoneAction()) return;
            toolTipController1.HideHint();
            if (fld_txtICProductName.EditValue != null)
            {
                if (fld_txtICProductName.EditValue.ToString() == string.Empty)
                    return;
                string mess = ((OtherProductModule)Module).FilterProduct(fld_txtICProductName.EditValue.ToString().ToLower());
                if (mess != string.Empty)
                {
                    Point toolTipLocation = fld_txtICProductName.PointToScreen(new Point(fld_txtICProductName.Width, fld_txtICProductName.Height));
                    toolTipController1.ShowHint(mess, "DS SP filter", toolTipLocation);
                }
            }
        }
        private void fld_lkeICProductType_EditValueChanged(object sender, EventArgs e)
        {
            string productTargetType = fld_lkeICProductType.EditValue.ToString();
            if (productTargetType.Equals(ProductType.Equipment.ToString()))
            {
                this.fld_lkeICProductTargetType.Enabled = true;
            }
            else
            {
                ((OtherProductModule)Module).ResetProductTargetTypeLookup();
                this.fld_lkeICProductTargetType.Enabled = false;
            }
        }

        private void fld_lkeICProductTrademark_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;
            if (lke.OldEditValue != lke.EditValue)
                ((OtherProductModule)Module).ShowTrademarkInProductDesc((int)lke.OldEditValue, lke.Text);
        }

        private void fld_lkeFK_ICProductTypeAccountConfigID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            int objectID = 0;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                Int32.TryParse(e.Value.ToString(), out objectID);
                ((OtherProductModule)Module).ChangeProductTypeAccountConfig(objectID);
            }
        }

        private void fld_btnSaveProductMeasureUnit_Click(object sender, EventArgs e)
        {
            ((OtherProductModule)Module).SaveProductMeasureUnitList();
        }

        private void fld_lkeICProductType_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            ((OtherProductModule)Module).SetDefaultAccountByProductType();
        }

        private void fld_btnAddProductImageDefault_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"; ;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileInfo file = new FileInfo(openFileDialog1.FileName);
                ((OtherProductModule)Module).UpdatePrimaryImage(file.FullName);
                //((ProductModule)Module).SetImageDefault(file.FullName);
                fld_ptbICProductPicture.Image = Image.FromFile(file.FullName);
            }
        }

        private void Fld_btnAdd_Click(object sender, EventArgs e)
        {
            ((OtherProductModule)Module).GetDataOperation();
        }

        private void Fld_btnAddProduct_Click(object sender, EventArgs e)
        {
            ((OtherProductModule)Module).GetDataBOM();
        }
    }
}

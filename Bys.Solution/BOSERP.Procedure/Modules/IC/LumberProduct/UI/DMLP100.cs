using BOSComponent;
using DevExpress.XtraEditors;
using System;
using System.Drawing;
using System.IO;

namespace BOSERP.Modules.LumberProduct.UI
{
    /// <summary>
    /// Summary description for DMPD100
    /// </summary>
    public partial class DMLP100 : BOSERPScreen
    {
        public DMLP100()
        {
            InitializeComponent();
        }

        private void fld_lnkEditPrice_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((LumberProductModule)Module).ShowPriceLevelForm();
        }

        private void fld_lnkEditUnitOfMeasure_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((LumberProductModule)Module).ShowMeasureOfUnits();
        }

        private void fld_bedICProductAttribute_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((LumberProductModule)Module).ShowEditAttributeForm();
        }

        private void fld_btnMoveUp_Click(object sender, EventArgs e)
        {
            ((LumberProductModule)Module).SortProductComponentList("MoveUp");
        }

        private void fld_btnMoveDown_Click(object sender, EventArgs e)
        {
            ((LumberProductModule)Module).SortProductComponentList("MoveDown");
        }

        private void fld_lnkOpenSupplier_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((LumberProductModule)Module).ShowSuppliersForm();
        }

        private void fld_lnkOpenBranchPrice_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((LumberProductModule)Module).ShowProductBranchPrice();
        }

        private void fld_lnkSetDefaultDesc_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((LumberProductModule)Module).SetDefaultProductDesc();
        }

        private void fld_lnkEditPurchasePrice_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((LumberProductModule)Module).EditPurchasePriceByCurrency();
        }

        private void fld_bedFK_ICProductGroupID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((LumberProductModule)Module).ShowCategoryTree();
        }
        private void fld_lnkShowHistoryBranchPrice_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((LumberProductModule)Module).ShowProductBranchPriceHistory();
        }

        //private void fld_chkICProductIdentifyAttribute_CheckedChanged_1(object sender, EventArgs e)
        //{
        //    if (fld_chkICProductIdentifyAttribute.Checked == true)
        //    {
        //        fld_txtICProductHeight.Visible = true;
        //        fld_txtICProductWidth.Visible = true;
        //        fld_txtICProductLength.Visible = true;
        //    }
        //    else
        //    {
        //        fld_txtICProductHeight.Visible = false;
        //        fld_txtICProductWidth.Visible = false;
        //        fld_txtICProductLength.Visible = false;
        //    }
        //}

        private void fld_lkeFK_ICProductGroupHeightID_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;
            if (lke.OldEditValue != lke.EditValue) ;
            ((LumberProductModule)Module).ShowHeightMinMax();
        }

        private void fld_lkeFK_ICProductTypeAccountConfigID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {

            BOSLookupEdit lke = (BOSLookupEdit)sender;
            int objectID = 0;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                Int32.TryParse(e.Value.ToString(), out objectID);
                ((LumberProductModule)Module).ChangeProductTypeAccountConfig(objectID);
            }
        }

        private void fld_bedICProductAttribute_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((LumberProductModule)Module).ShowEditAttributeForm();
        }

        private void fld_btnAddProductAlternatives_Click(object sender, EventArgs e)
        {
            ((LumberProductModule)Module).ShowChooseProductAlternatives();
        }

        private void fld_lkeICProductOriginOfProduct_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value == null || (e.Value != null && e.Value == lke.OldEditValue))
                return;
            ((LumberProductModule)Module).ChangeProductOriginOfProduct(e.Value.ToString());
        }

        private void fld_btnChooseProductOutsourcings_Click(object sender, EventArgs e)
        {
            ((LumberProductModule)Module).ShowChooseProductOutsourcings();
        }

        private void fld_btnSaveProductMeasureUnit_Click(object sender, EventArgs e)
        {
            ((LumberProductModule)Module).SaveProductMeasureUnitList();
        }

        private void fld_lkeThick_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            if (e.Value != null)
            {
                int thickGroupID = 0;
                int.TryParse(e.Value.ToString(), out thickGroupID);
                ((LumberProductModule)Module).ChangeThickValue(thickGroupID);
            }
            else
            {
                ((LumberProductModule)Module).ChangeThickValue(0);
            }
        }

        private void fld_lkeFK_ICProductAttributeWoodTypeID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            if (e.Value != null)
            {
                int woodTypeID = 0;
                int.TryParse(e.Value.ToString(), out woodTypeID);
                ((LumberProductModule)Module).RefreshLookupDataSource(woodTypeID);
            }
        }

        private void fld_btnAddProductImageDefault_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"; ;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileInfo file = new FileInfo(openFileDialog1.FileName);
                ((LumberProductModule)Module).UpdatePrimaryImage(file.FullName);
                //((ProductModule)Module).SetImageDefault(file.FullName);
                fld_ptbICProductPicture.Image = Image.FromFile(file.FullName);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ((LumberProductModule)Module).AddProductImage();
        }

        private void fld_lkeICProductType_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            ((LumberProductModule)Module).SetDefaultAccountByProductType();
        }
    }
}

using BOSComponent;
using System;
using System.Drawing;
using System.IO;

namespace BOSERP.Modules.WoodMaterialsProduct.UI
{
    /// <summary>
    /// Summary description for DMWMP100
    /// </summary>
    public partial class DMWMP100 : BOSERPScreen
    {

        public DMWMP100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_bedFK_ICProductGroupID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((WoodMaterialsProductModule)Module).ShowCategoryTree();
        }

        private void fld_bedICProductAttribute_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((WoodMaterialsProductModule)Module).ShowEditAttributeForm();
        }

        private void fld_lnkOpenSupplier_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((WoodMaterialsProductModule)Module).ShowSuppliersForm();
        }

        //private void fld_chkICProductIdentifyWoodType_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (fld_chkICProductIdentifyWoodType.Checked == true)
        //    {
        //        fld_lkeFK_ICProductAttributeWoodTypeID.Visible = true;
        //    }
        //    else
        //    {
        //        fld_lkeFK_ICProductAttributeWoodTypeID.Visible = false;
        //    }
        //}



        //private void fld_chkICProductIdentifyAttribute_CheckedChanged_1(object sender, EventArgs e)
        //{
        //    if (fld_chkICProductIdentifyAttribute.Checked == true)
        //    {
        //        fld_txtICProductWeight.Visible = true;
        //        fld_txtICProductWidth.Visible = true;
        //        fld_txtICProductLength.Visible = true;

        //    }
        //    else
        //    {
        //        fld_txtICProductWeight.Visible = false;
        //        fld_txtICProductWidth.Visible = false;
        //        fld_txtICProductLength.Visible = false;
        //    }
        //}

        private void fld_lnkSetDefaultDesc_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((WoodMaterialsProductModule)Module).SetDefaultProductDesc();
        }

        private void fld_lkeFK_ICProductTypeAccountConfigID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            int objectID = 0;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                Int32.TryParse(e.Value.ToString(), out objectID);
                ((WoodMaterialsProductModule)Module).ChangeProductTypeAccountConfig(objectID);
            }
        }

        private void fld_btnAddProductImageDefault_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"; ;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileInfo file = new FileInfo(openFileDialog1.FileName);
                ((WoodMaterialsProductModule)Module).UpdatePrimaryImage(file.FullName);
                //((ProductModule)Module).SetImageDefault(file.FullName);
                fld_ptbICProductPicture.Image = Image.FromFile(file.FullName);
            }
        }
    }
}

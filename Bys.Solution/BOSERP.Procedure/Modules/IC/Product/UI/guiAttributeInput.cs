using BOSCommon.Constants;
using Localization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Product
{
    public partial class guiAttributeInput : Form
    {
        public string guiAttributeInputType { get; set; }
        public int ProductAttributeParentID { get; set; }
        public guiAttributeInput()
        {
            InitializeComponent();
            guiAttributeInputType = string.Empty;
            ProductAttributeParentID = 0;
        }

        public guiAttributeInput(String value, int parentID)
        {
            InitializeComponent();

            fld_txtICProductAttributeValue.Text = value;
            fld_lkeICProductAttributeID.EditValue = parentID;
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(fld_txtICProductAttributeValue.Text))
            {
                MessageBox.Show(ICDepartmentLocalizedResources.AttributeNameRequiredMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void guiAttributeInput_Load(object sender, EventArgs e)
        {
            fld_txtICProductAttributeAbbreviation.Visible = false;
            fld_lblICProductAttributeAbbreviation.Visible = false;

            if (guiAttributeInputType.Equals(MatchCodeConst.MatchCodeFirstNameColumnName) ||
                guiAttributeInputType.Equals(MatchCodeConst.MatchCodeColorColumnName) ||
                guiAttributeInputType.Equals(MatchCodeConst.MatchCodeHTTypeColumnName) ||
                guiAttributeInputType.Equals(MatchCodeConst.MatchCodeWoodTypeColumnName))
            {
                fld_lkeICProductAttributeID.Visible = false;
                fld_lblFirstName.Visible = false;
                if (guiAttributeInputType.Equals(MatchCodeConst.MatchCodeColorColumnName))
                {
                    fld_txtICProductAttributeAbbreviation.Visible = true;
                    fld_lblICProductAttributeAbbreviation.Visible = true;
                }
            }
            else
            {
                fld_lkeICProductAttributeID.Visible = true;
                fld_lblFirstName.Visible = true;
            }
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            List<ICProductAttributesInfo> productAttributesList = new List<ICProductAttributesInfo>();

            //Invalidate dataSource to lookupedit
            if (ProductAttributeParentID == 0)
            {
                productAttributesList = objProductAttributesController.GetProductAttributesByProductAttributeGroup(MatchCodeConst.MatchCodeFirstNameColumnName);
                fld_lkeICProductAttributeID.Properties.DataSource = productAttributesList;
                fld_txtICProductAttributeValue.Focus();
            }
            else
            {
                ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
                objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(ProductAttributeParentID);
                if (objProductAttributesInfo != null)
                {
                    productAttributesList.Add(objProductAttributesInfo);
                    if (productAttributesList.Count > 0)
                    {
                        fld_lkeICProductAttributeID.Properties.DataSource = productAttributesList;
                        fld_lkeICProductAttributeID.EditValue = objProductAttributesInfo.ICProductAttributeID;
                    }
                }
                fld_lkeICProductAttributeID.Focus();
            }


        }
    }
}
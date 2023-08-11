using BOSCommon.Constants;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace BOSERP.Modules.Product
{
    public partial class guiConversionSize : Form
    {
        public string guiConversionSizeType { get; set; }
        public int ProductAttributeParentID { get; set; }
        public guiConversionSize(ICProductsInfo objProductsInfo)
        {
            InitializeComponent();
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            List<ADConfigValuesInfo> productConverSizeFactor = objConfigValuesController.GetADConfigValuesByKeyGroup("ProductConverSizeFactor");
            decimal factor = 0;
            if (productConverSizeFactor != null)
                factor = Convert.ToDecimal(productConverSizeFactor.FirstOrDefault().ADConfigKeyDesc);

            fld_txtICProductWidth.EditValue = objProductsInfo.ICProductWidth * factor;
            fld_txtICProductLength.EditValue = objProductsInfo.ICProductLength * factor;
            fld_txtICProductHeight.EditValue = objProductsInfo.ICProductHeight * factor;
        }


        private void guiConversionSize_Load(object sender, EventArgs e)
        {
        }
    }
}
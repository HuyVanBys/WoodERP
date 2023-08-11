using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BOSCommon;
using BOSComponent;
using Localization;
using DevExpress.XtraGrid.Views.Grid;
using BOSLib;
using DevExpress.XtraGrid.Columns;

namespace BOSERP.Modules.ProductionNorm.UI
{
    public partial class guiProductDetails : BOSERPScreen
    {


         ICProductsInfo ProductsInfo;
        public override void InitializeControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                InitializeControl(ctrl);
                if (ctrl.Controls.Count > 0)
                {
                    InitializeControls(ctrl.Controls);
                }
            }
        }
        public guiProductDetails(ICProductsInfo objProductsInfo)
        {
            InitializeComponent();
            ProductsInfo = objProductsInfo;
        }
        private void guiProductDetails_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
          if (ProductsInfo != null)
            {
                fld_kleICProductIdentifyColor.EditValue = ProductsInfo.FK_ICProductAttributeColorID;
                fld_kleICProductIdentifyFinishing.EditValue = ProductsInfo.FK_ICProductAttributeFinishingID;
                fld_lkeICProductIdentifyWoodType.EditValue = ProductsInfo.FK_ICProductAttributeWoodTypeID;
                fld_txtICProductHeight.EditValue = ProductsInfo.ICProductHeight;
                fld_txtICProductWidth.EditValue = ProductsInfo.ICProductWidth;
                fld_txtICProductLength.EditValue = ProductsInfo.ICProductLength;
                fld_txtICProductName.Text = ProductsInfo.ICProductName;
                fld_txtICProductNo.Text = ProductsInfo.ICProductNo;
                fld_medICProductDesc.Text = ProductsInfo.ICProductDesc;
            }
        }

       

       
    }
}

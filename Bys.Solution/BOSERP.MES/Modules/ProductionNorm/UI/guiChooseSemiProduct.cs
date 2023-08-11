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
    public partial class guiChooseSemiProduct : BOSERPScreen
    {
        public string ObjectType = string.Empty;

        public guiChooseSemiProduct()
        {
            InitializeComponent();  
        }

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

        private void guiChooseSemiProduct_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            ProductionNormEntities entity = (ProductionNormEntities)((ProductionNormModule)Module).CurrentModuleEntity;
            entity.SemiProductList.GridControl = fld_dgcSemiProduct;
            if (ObjectType == ProductType.IngredientPackaging.ToString())
            {
                ((ProductionNormModule)Module).InitPackagingList(true);
            }
            else
            {
                ((ProductionNormModule)Module).InitSemiProductList(true);
            }
        }

        private void fld_btnAddNewItem_Click(object sender, EventArgs e)
        {
            if (ObjectType == ProductType.IngredientPackaging.ToString())
            {
                ((ProductionNormModule)Module).AddNewPackagingItem();
            }
            else
            {
                ((ProductionNormModule)Module).AddNewSemiProductItem();
            }
        }

        private void fld_btnChoose_Click(object sender, EventArgs e)
        {
            ProductionNormEntities entity = (ProductionNormEntities)((ProductionNormModule)Module).CurrentModuleEntity;
            bool isSelected = false;
            foreach (ICProductsInfo objProductsInfo in entity.SemiProductList)
            {
                if (objProductsInfo.Selected)
                {
                    isSelected = true;
                    break;
                }
            }
            if (isSelected)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

       
    }
}

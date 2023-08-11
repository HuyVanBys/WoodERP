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
    public partial class guiCreateProductStructure : BOSERPScreen
    {    
        public string ObjectType = string.Empty;
        public int ProductID = 0;
        public guiCreateProductStructure(int productID)
        {
            InitializeComponent();
            ProductID = productID;
            fld_lkeICProductID1.EditValue = productID;
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

        private void guiCreateProductStructure_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            ProductionNormEntities entity = (ProductionNormEntities)((ProductionNormModule)Module).CurrentModuleEntity;
            entity.ProductItemList.InitBOSListGridControl(fld_dgcSemiProduct1);
            entity.ProductItemList.GridControl.RefreshDataSource();
        }

        private void fld_btnSave_Click(object sender, EventArgs e)
        {
            ProductionNormEntities entity = (ProductionNormEntities)((ProductionNormModule)Module).CurrentModuleEntity;
            ICProductsInfo selectedItem = entity.ProductItemList.FirstOrDefault(item => item.Selected);
            if (selectedItem == null)
                MessageBox.Show("Vui lòng chọn BTP con cho cụm được chọn.");
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }


        //private void fld_btnAddGroup_Click(object sender, EventArgs e)
        //{
        //    if (ObjectType == ProductType.IngredientPackaging.ToString())
        //    {
        //        ((ProductionNormModule)Module).AddNewPackagingProductParent();
        //    }
        //    else
        //    {
        //        ((ProductionNormModule)Module).AddNewSemiProductParent();
        //    }
        //}

        //private void fld_btnSave_Click(object sender, EventArgs e)
        //{
        //    if (ObjectType == ProductType.IngredientPackaging.ToString())
        //    {
        //        ((ProductionNormModule)Module).SavePackagingProductDetail();
        //    }
        //    else
        //    {
        //        ((ProductionNormModule)Module).SaveSemiProductDetail();
        //    }
        //}

        //private void fld_btnAddNew_Click(object sender, EventArgs e)
        //{
        //    if (ObjectType == ProductType.IngredientPackaging.ToString())
        //    {
        //        ((ProductionNormModule)Module).AddNewPackagingProductChild();
        //    }
        //    else
        //    {
        //        ((ProductionNormModule)Module).AddNewSemiProductChild();
        //    }
        //}

        //private void fld_btnCancel_Click(object sender, EventArgs e)
        //{
        //    ((ProductionNormModule)Module).CancelCreateItem();
        //}

        //private void fld_btnAddPiece_Click(object sender, EventArgs e)
        //{
        //    if (ObjectType == ProductType.IngredientPackaging.ToString())
        //    {
        //   //     ((ProductionNormModule)Module).AddNewPackagingProductChild();
        //    }
        //    else
        //    {
        //        ((ProductionNormModule)Module).AddNewSemiProductPiece();
        //    }
        //}

       
    }
}

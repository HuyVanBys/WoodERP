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
    public partial class guiAddSemiProduct : BOSERPScreen
    {

        public string ObjectType = string.Empty;
        public int ProductID = 0;
        public guiAddSemiProduct(int productID)
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

        private void guiAddSemiProduct_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            ProductionNormEntities entity = (ProductionNormEntities)((ProductionNormModule)Module).CurrentModuleEntity;
            entity.SemiProductListParent.GridControl = fld_dgcSemiProductParent;
            entity.SemiProductListChild.GridControl =fld_dgcSemiProductChild;
            if (ObjectType == ProductType.IngredientPackaging.ToString())
            {
                ((ProductionNormModule)Module).InitPackagingProduct();
                if (entity.SemiProductListChild.GridControl != null)
                {
                    GridView gridView = (GridView)entity.SemiProductListChild.GridControl.MainView;
                    if (gridView != null)
                    {
                        if (gridView.Columns["ICProductOverallDimension"] != null)
                        {
                            gridView.Columns["ICProductOverallDimension"].Visible = true;
                            gridView.Columns["ICProductOverallDimension"].VisibleIndex = 12;
                            gridView.Columns["ICProductOverallDimension"].OptionsColumn.AllowEdit = true;
                        }
                        if (gridView.Columns["ICProductInsideDimension"] != null)
                        {
                            gridView.Columns["ICProductInsideDimension"].Visible = true;
                            gridView.Columns["ICProductInsideDimension"].VisibleIndex = 13;
                            gridView.Columns["ICProductInsideDimension"].OptionsColumn.AllowEdit = true;
                        }
                        if (gridView.Columns["ICProductSizeAndSpecifiCations"] != null)
                        {
                            gridView.Columns["ICProductSizeAndSpecifiCations"].Visible = true;
                            gridView.Columns["ICProductSizeAndSpecifiCations"].VisibleIndex = 14;
                            gridView.Columns["ICProductSizeAndSpecifiCations"].OptionsColumn.AllowEdit = true;
                        }
                    
                    }
                }
            }
            else
            {
                ((ProductionNormModule)Module).InitSemiProduct();
            }
        }

        private void fld_btnAddGroup_Click(object sender, EventArgs e)
        {
            if (ObjectType == ProductType.IngredientPackaging.ToString())
            {
                ((ProductionNormModule)Module).AddNewPackagingProductParent();
            }
            else
            {
                ((ProductionNormModule)Module).AddNewSemiProductParent();
            }
        }

        private void fld_btnSave_Click(object sender, EventArgs e)
        {
            if (ObjectType == ProductType.IngredientPackaging.ToString())
            {
                ((ProductionNormModule)Module).SavePackagingProductDetail();
            }
            else
            {
                ((ProductionNormModule)Module).SaveSemiProductDetail();
            }
        }

        private void fld_btnAddNew_Click(object sender, EventArgs e)
        {
            if (ObjectType == ProductType.IngredientPackaging.ToString())
            {
                ((ProductionNormModule)Module).AddNewPackagingProductChild();
            }
            else
            {
                ((ProductionNormModule)Module).AddNewSemiProductChild();
            }
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            ((ProductionNormModule)Module).CancelCreateItem();
        }

        private void fld_btnAddPiece_Click(object sender, EventArgs e)
        {
            if (ObjectType == ProductType.IngredientPackaging.ToString())
            {
           //     ((ProductionNormModule)Module).AddNewPackagingProductChild();
            }
            else
            {
                ((ProductionNormModule)Module).AddNewSemiProductPiece();
            }
        }

       
    }
}

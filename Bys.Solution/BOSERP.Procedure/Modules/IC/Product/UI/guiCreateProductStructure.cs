using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Product.UI
{
    public partial class guiCreateProductStructure : BOSERPScreen
    {
        List<ICProductsInfo> objProductsInfoList;
        public string ObjectType = string.Empty;
        public int ProductID = 0;
        public decimal Qty = 0;
        public bool HasComponent = false;
        public int ProcessID = 0;
        public string ProductDesc = string.Empty;
        public guiCreateProductStructure(int productID, decimal qty, bool hasComponent, int processID, string productDesc)
        {
            InitializeComponent();
            ProductID = productID;
            Qty = qty;
            HasComponent = hasComponent;
            ProcessID = processID;
            ProductDesc = productDesc;

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

            fld_lkeICProductID1.EditValue = ProductID;
            //fld_lkeICProductID1.Text = ProductDesc;
            fld_txtQty.EditValue = Qty;
            fld_lkeMMProcessID.EditValue = ProcessID;
            objProductsInfoList = ((ProductModule)Module).GetWoodIngredient();
            ProductEntities entity = (ProductEntities)((ProductModule)Module).CurrentModuleEntity;
            entity.ProductItemList.InitBOSListGridControl(fld_dgcSemiProduct1);
            entity.ProductItemList.GridControl.RefreshDataSource();

            entity.PNIMList.InitBOSListGridControl(fld_dgcICProductItemMaterials);
            ((ICProductItemMaterialsGridControl)entity.PNIMList.GridControl).ProductID = ProductID;
            entity.PNIMList.GridControl.RefreshDataSource();

            entity.PIProcessList.InitBOSListGridControl(fld_dgcICProductItemProcesss);
            entity.PIProcessList.GridControl.RefreshDataSource();

            if (HasComponent)
            {
                fld_dgcICProductItemMaterials.Enabled = false;
                fld_btnSaveProductionNormItemMeterial.Enabled = false;
            }

        }



        private void fld_btnSave_Click(object sender, EventArgs e)
        {
            //ProductEntities entity = (ProductEntities)((ProductModule)Module).CurrentModuleEntity;
            //ICProductsInfo selectedItem = entity.ProductItemList.FirstOrDefault(item => item.Selected);
            //if (selectedItem == null)
            //    MessageBox.Show("Vui lòng chọn BTP con cho cụm được chọn.");
            //else
            //{
            decimal.TryParse(fld_txtQty.EditValue.ToString(), out Qty);
            this.DialogResult = DialogResult.OK;
            this.Close();
            // }
        }

        private void fld_btnSaveProductionNormItemMeterial_Click(object sender, EventArgs e)
        {
            ((ProductModule)Module).SaveProductMaterial(ProductID);
        }

        private void fld_btnChooseProcess_Click(object sender, EventArgs e)
        {
            //((ProductModule)Module).ChooseProcess(ProductID);
        }

        private void bosButton3_Click(object sender, EventArgs e)
        {
            int operationID = 0;
            if (fld_lkeMMOperationID.EditValue != null)
            {
                int.TryParse(fld_lkeMMOperationID.EditValue.ToString(), out operationID);
            }
            ((ProductModule)Module).ChooseProcessOperation(ProductID, operationID);

        }

        private void bosButton2_Click(object sender, EventArgs e)
        {
            ((ProductModule)Module).SaveProductProcess(ProductID);
        }

        private void fld_lkeMMProcessID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int processID = 0;

                if (fld_lkeMMProcessID.EditValue != null)
                {
                    int.TryParse(fld_lkeMMProcessID.EditValue.ToString(), out processID);
                }

                ((ProductModule)Module).ChooseProcess(ProductID, processID);
            }
        }

        private void fld_lkeMMOperationID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int processID = 0;

                if (fld_lkeMMOperationID.EditValue != null)
                {
                    int.TryParse(fld_lkeMMOperationID.EditValue.ToString(), out processID);
                }

                ((ProductModule)Module).ChooseProcessOperation(ProductID, processID);
            }
        }


    }
}

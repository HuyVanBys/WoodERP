using System;

namespace BOSERP.Modules.InventoryStockCount.UI
{
    /// <summary>
    /// Summary description for DMISC100
    /// </summary>
    public partial class DMISC100 : BOSERPScreen
    {

        public DMISC100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnStockQuantity_Click(object sender, EventArgs e)
        {
            ((Modules.InventoryStockCount.InventoryStockCountModule)this.Module).InventoryStockCountItemsBindingDataSource();
        }

        private void fld_bedICProductGroupID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((Modules.InventoryStockCount.InventoryStockCountModule)this.Module).ShowCategoryTree();
        }

        private void fld_ccbeICInventoryStockCountEmployeeInspector_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            if (fld_ccbeICInventoryStockCountEmployeeInspector.EditValue != e.Value)
            {
                ((InventoryStockCountModule)Module).ChangeEmployeeInspector(e.Value.ToString());
            }
        }

        private void fld_ccbeICInventoryStockCountEmployeeRepresentatives_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            if (fld_ccbeICInventoryStockCountEmployeeRepresentatives.EditValue != e.Value)
            {
                ((InventoryStockCountModule)Module).ChangeEmployeeRepresentatives(e.Value.ToString());
            }
        }

        private void bosButton1_Click(object sender, EventArgs e)
        {
            ((InventoryStockCountModule)Module).ImportInventoryStockCount();
        }
    }
}

using System;
using System.Windows.Forms;

namespace BOSERP.Modules.WoodMaterialsProduct
{
    public partial class guiChooseSupplier : BOSERPScreen
    {
        public guiChooseSupplier()
        {
            InitializeComponent();
        }

        private void guiChooseSupplier_Load(object sender, EventArgs e)
        {
            fld_dgcICProductSuppliers.Screen = this;
            fld_dgcICProductSuppliers.InitializeControl();
            //Bind grid control to their list
            WoodMaterialsProductEntities entity = (WoodMaterialsProductEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            entity.ICProductSuppliersList.InitBOSListGridControl(fld_dgcICProductSuppliers);
        }



        private void bosButton2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void bosButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

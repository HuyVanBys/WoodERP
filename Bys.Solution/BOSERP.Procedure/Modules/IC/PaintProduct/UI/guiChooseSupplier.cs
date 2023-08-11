using System;
using System.Windows.Forms;

namespace BOSERP.Modules.PaintProduct
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
            PaintProductEntities entity = (PaintProductEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            entity.ICProductSuppliersList.InitBOSListGridControl(fld_dgcICProductSuppliers);
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

using System;

namespace BOSERP.Modules.Collection.UI
{
    /// <summary>
    /// Summary description for DMCT100
    /// </summary>
    public partial class DMCT100 : BOSERPScreen
    {

        public DMCT100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void DMCT100_Load(object sender, EventArgs e)
        {

        }

        private void fld_btnAddProduct_Click(object sender, EventArgs e)
        {
            ((CollectionModule)Module).AddProductToCollectionItemsList();
        }

        private void bosButton1_Click(object sender, EventArgs e)
        {
            ((CollectionModule)Module).AddProductToCollectionItemsList();
        }

        private void fld_btnAddProductWork_Click(object sender, EventArgs e)
        {
            ((CollectionModule)Module).AddProductToCollectionItemWorksList();
        }

        private void fld_btnAddProductMaterial_Click(object sender, EventArgs e)
        {
            ((CollectionModule)Module).AddProductToCollectionItemMaterialList();
        }
    }
}

using System;

namespace BOSERP.Modules.ProductionCostFormula.UI
{
    /// <summary>
    /// Summary description for DMPCF100
    /// </summary>
    public partial class DMPCF100 : BOSERPScreen
    {

        public DMPCF100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnAddProduct_Click(object sender, EventArgs e)
        {
            ((ProductionCostFormulaModule)Module).AddProduct();
        }

        private void fld_btnAddProductGroup_Click(object sender, EventArgs e)
        {
            ((ProductionCostFormulaModule)Module).AddProductGroup();
        }


    }
}

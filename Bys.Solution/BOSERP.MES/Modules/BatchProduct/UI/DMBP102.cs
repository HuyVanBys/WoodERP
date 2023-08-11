using System;

namespace BOSERP.Modules.BatchProduct.UI
{
    /// <summary>
    /// Summary description for DMBP102
    /// </summary>
    public partial class DMBP102 : BOSERPScreen
    {

        public DMBP102()
        {
            InitializeComponent();
        }

        private void fld_btnAddProducts_Click(object sender, EventArgs e)
        {
            ((BatchProductModule)Module).AddProductOutSouring();
        }

        private void fld_btnSaveOutSourcings_Click(object sender, EventArgs e)
        {
            ((BatchProductModule)Module).SaveOutSouringList();
        }

        private void fld_btnApproved_Click(object sender, EventArgs e)
        {
            ((BatchProductModule)Module).ApproveOutSouringItems();
        }

        private void fld_btnUpdateDate_Click(object sender, EventArgs e)
        {
            ((BatchProductModule)Module).UpdateOutSouringItemNeedDate();
        }

        private void fld_btnUpdateResourceType_Click(object sender, EventArgs e)
        {
            ((BatchProductModule)Module).UpdateOutSouringItemResourceType();
        }

        private void fld_btnCloseOutSourcing_Click(object sender, EventArgs e)
        {
            ((BatchProductModule)Module).CloseBatchProductOutSourcing();
        }

        private void fld_btnUnApproved_Click(object sender, EventArgs e)
        {
            ((BatchProductModule)Module).UnApproveOutSouringItems();
        }
    }
}
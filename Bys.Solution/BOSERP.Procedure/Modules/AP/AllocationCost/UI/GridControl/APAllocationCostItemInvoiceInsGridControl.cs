using BOSComponent;
using System.Windows.Forms;

namespace BOSERP.Modules.AllocationCost
{
    public partial class APAllocationCostItemInvoiceInsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            AllocationCostEntities entity = (AllocationCostEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ACIInvoiceInList;
            this.DataSource = bds;
        }


    }
}

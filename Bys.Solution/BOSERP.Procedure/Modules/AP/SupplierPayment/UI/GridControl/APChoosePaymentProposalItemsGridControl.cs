using BOSComponent;
using System.Collections.Generic;
using System.Windows.Forms;
namespace BOSERP.Modules.SupplierPayment
{
    public partial class APChoosePaymentProposalItemsGridControl : BOSGridControl
    {
        public void InvalidateDataSource(List<APPaymentProposalItemsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

    }
}

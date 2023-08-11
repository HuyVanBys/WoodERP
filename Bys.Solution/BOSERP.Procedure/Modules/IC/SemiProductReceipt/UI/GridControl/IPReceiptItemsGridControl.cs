using BOSComponent;
using BOSERP.Procedure.Modules.IC.SemiProductReceipt.ImportInfo;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.SemiProductReceipt
{
    public class IPReceiptItemsGridControl : BOSGridControl
    {
        public void InvalidateDataSource(List<IPReceiptItemsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            this.DataSource = bds;
            RefreshDataSource();
        }
    }
}

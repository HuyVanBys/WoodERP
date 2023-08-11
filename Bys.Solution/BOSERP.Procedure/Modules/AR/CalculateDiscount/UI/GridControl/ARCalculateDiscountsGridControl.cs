using BOSComponent;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.CalculateDiscount
{
    public class ARCalculateDiscountsGridControl : BOSGridControl
    {
        public void InvalidateDataSource(List<ARCalculateDiscountsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }
    }
}

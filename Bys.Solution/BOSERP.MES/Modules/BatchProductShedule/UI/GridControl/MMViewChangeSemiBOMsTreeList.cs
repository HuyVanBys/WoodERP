using BOSComponent;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.BatchProductShedule
{
    public class MMViewChangeSemiBOMsTreeList : BOSTreeListControl
    {
        public void InitTreeListDataSource(List<MMBatchProductProductionNormItemsViewInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
        }

        public override void InitializeControl()
        {
            base.InitializeControl();
        }
    }
}

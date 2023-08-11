using BOSERP;
using System.Collections.Generic;

namespace BOSReport
{
    public partial class RPInventoryStockCount : BaseReport
    {
        /// <summary>
        /// Inventory Stock Count
        /// </summary>
        public RPInventoryStockCount(List<ICInventoryStockCountItemsInfo> inventoryStockCountItemsList, ICInventoryStockCountsInfo inventoryStockCountsInfo)
        {
            InitializeComponent();
            this.bindingSource1.DataSource = inventoryStockCountItemsList;
            this.bindingSource2.DataSource = inventoryStockCountsInfo;
        }
    }
}

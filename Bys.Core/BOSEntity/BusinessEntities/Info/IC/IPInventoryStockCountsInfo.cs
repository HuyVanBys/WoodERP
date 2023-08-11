using BOSLib;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOSERP
{
    public class IPInventoryStockCountsInfo : BusinessObject
    {
        public int STT { get; set; } = 0;

        [Column("FK_ICProductID")]
        public int ProductID { get; set; } = 0;

        [Column("ICProductNo")]
        public string ProductNo { get; set; } = string.Empty;

        [Column("ICProductName")]
        public string ProductName { get; set; } = string.Empty;

        [Column("ICProductDesc")]
        public string ProductDesc { get; set; } = string.Empty;

        public int StockID { get; set; }

        [Column("ICStockNo")]
        public string StockNo { get; set; } = string.Empty;

        [Column("ICStockName")]
        public string StockName { get; set; } = string.Empty;

        [Column("ICMeasureUnitName")]
        public string MeasureUnitName { get; set; } = string.Empty;

        public string ProductSerieNo { get; set; } = string.Empty;

        [Column("ICInventoryStockCountItemQuantity")]
        public decimal ProgramInventoryQty { get; set; } = 0;

        [Column("ICInventoryStockCountItemActualQuantity")]
        public decimal ActualInventoryQty { get; set; } = 0;

        [Column("ICInventoryStockUnitCostAVG")]
        public decimal ProgramInventoryCost { get; set; } = 0;

        [Column("ICInventoryStockActualUnitCost")]
        public decimal ActualInventoryCost { get; set; } = 0;

        public string InventoryStockCountNote { get; set; } = string.Empty;
    }
}

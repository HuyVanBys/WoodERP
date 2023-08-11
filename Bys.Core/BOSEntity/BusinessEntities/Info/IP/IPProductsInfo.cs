using BOSLib;

namespace BOSERP
{
    public class IPProductsInfo : BusinessObject
    {
        public string IPProductSortOrder { get; set; }

        public string IPProductNo { get; set; }

        public string IPProductCustomerNumber { get; set; }

        public string IPProductNoOfOldSys { get; set; }

        public string IPProductName { get; set; }

        public string IPProductDesc { get; set; }

        public string IPMeasureUnitName { get; set; }

        public decimal IPProductQuantity { get; set; }

        public string IPStockNo { get; set; }

        public string IPProductSerieNo { get; set; }

        public int FK_ICMeasureUnitID { get; set; }

        public int FK_ICStockID { get; set; }

        public int FK_ICProductSerieID { get; set; }

        public int FK_ICProductID { get; set; }
        public decimal P { get; set; }
        public decimal IPProductUnitCost { get; set; }
        public decimal IPProductUnitPrice { get; set; }
        public decimal IPProductDiscount { get; set; }
    }
}
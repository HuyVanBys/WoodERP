namespace BOSERP
{
    public class MMBatchProductionNormItemView
    {
        public int FK_ICProductID { get; set; }

        public string ICProductNo { get; set; }

        public int FK_MMBatchProductID { get; set; }

        public int FK_ICDepartmentID { get; set; }

        public int FK_ICProductGroupID { get; set; }

        public int FK_ICMeasureUnitID { get; set; }

        public int FK_MMBatchProductItemID { get; set; }

        public string MMBatchProductProductionNormItemGroup { get; set; }

        public decimal MMBatchProductProductionNormItemQuantity { get; set; }

        public string MMBatchProductProductionNormItemProductName { get; set; }

        public string MMBatchProductProductionNormItemProductDesc { get; set; }

        public string MMBatchProductNo { get; set; }

        public decimal MMBatchProductProductionNormItemProductHeight { get; set; }

        public decimal MMBatchProductProductionNormItemProductWidth { get; set; }

        public decimal MMBatchProductProductionNormItemProductLength { get; set; }
    }
}


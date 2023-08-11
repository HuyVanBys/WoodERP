namespace BOSERP.MES.Modules.CarcassBOM.ImportInfo
{
    public class IPProductItemMaterialsInfo
    {
        public string IPProductionItemCode { get; set; }

        public string IPProductionItemParentCode { get; set; }

        public int FK_ICProductMaterialID { get; set; }

        public decimal ICProductLength { get; set; }

        public decimal ICProductWidth { get; set; }

        public decimal ICProductHeight { get; set; }

        public decimal ICProductItemMaterialQty { get; set; }

        public decimal ICProductItemMaterialDepreciationRate { get; set; }

        public decimal ICProductItemMaterialDepreciationQty { get; set; }

        public int FK_ICMeasureUnitID { get; set; }

        public int FK_MMFormulaID { get; set; }

        public int FK_MMOperationID { get; set; }

        public string ICProductNo { get; set; }

        public string ICProductName { get; set; }

        public string ICProductDesc { get; set; }

        public string ICMeasureUnitName { get; set; }

        public string MMOperationNo { get; set; }

        public string MMOperationName { get; set; }

        public string MMFormulaNo { get; set; }

        public decimal ICProductQuantitative { get; set; }
    }
}

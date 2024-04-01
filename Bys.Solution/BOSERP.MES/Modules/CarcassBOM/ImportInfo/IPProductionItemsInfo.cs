namespace BOSERP.MES.Modules.CarcassBOM.ImportInfo
{
    public class IPProductionItemsInfo
    {
        public string IPProductionItemCode { get; set; }

        public string IPProductionItemParentCode { get; set; }

        public string IPProductionItemGroup { get; set; }

        public string IPProductionItemComment { get; set; }

        public string ICProductNo { get; set; }

        public string ICProductName { get; set; }

        public string ICProductDesc { get; set; }

        public decimal ICProductLength { get; set; }

        public decimal ICProductWidth { get; set; }

        public decimal ICProductHeight { get; set; }

        public decimal ICProductDepth { get; set; }

        public string ICMeasureUnitName { get; set; }

        public decimal IPProductionItemProductQty { get; set; }

        public bool IPProductionItemHasPaint { get; set; }

        public int FK_ICMeasureUnitID { get; set; }

        public decimal IPProductionItemInsideDimensionLength { get; set; }

        public decimal IPProductionItemInsideDimensionWidth { get; set; }

        public decimal IPProductionItemInsideDimensionHeight { get; set; }

        public decimal IPProductionItemOverallDimensionLength { get; set; }

        public decimal IPProductionItemOverallDimensionWidth { get; set; }

        public decimal IPProductionItemOverallDimensionHeight { get; set; }

        public decimal IPProductionItemPaint { get; set; }

        public decimal ICProductDepreciationRate { get; set; }

        public string MMOperationNo { get; set; }

        public string MMOperationName { get; set; }

        public int FK_MMOperationID { get; set; }

        public decimal ICProductQuantitative { get; set; }

        public decimal ICProductDiameter { get; set; }

        public string IPProductionItemPaintProcessNo { get; set; }

        public string IPProductionItemPaintProcessDesc { get; set; }

        public int FK_MMPaintProcessID { get; set; }

        public string MMFormulaPaintANo { get; set; }

        public string MMFormulaPaintBNo { get; set; }

        public string MMFormulaPaintCNo { get; set; }

        public decimal MMFormulaPaintA { get; set; }

        public decimal MMFormulaPaintB { get; set; }

        public decimal MMFormulaPaintC { get; set; }

        public int FK_MMFormulaPaintAID { get; set; }

        public int FK_MMFormulaPaintBID { get; set; }

        public int FK_MMFormulaPaintCID { get; set; }

        public string IPProductionItemProductCode { get; set; }

        public string ICProductAttributeColorNo { get; set; }

        public int FK_ICProductAttributeColorID { get; set; }

        public string IPProductJoinery { get; set; }

        public string IPProductAttributeSemiProductSpecialityNo { get; set; }

        public int FK_ICProductAttributeSemiProductSpecialityID { get; set; }

        public string ICProductGroupNo { get; set; }

        public string ICProductGroupName { get; set; }

        public int FK_ICProductGroupID { get; set; }
        public string ICProductAttributeColorText { get; set; }
        public string ICProductAttributeOtherColor { get; set; }
        public string ICProductAttributeOtherColorID { get; set; }
        public string ICProductColorPaintA { get; set; }
        public string ICProductColorPaintAText { get; set; }
        public string ICProductColorPaintB { get; set; }
        public string ICProductColorPaintBText { get; set; }
        public string ICProductColorPaintC { get; set; }
        public string ICProductColorPaintCText { get; set; }
        public string ICProductPaintProcessA { get; set; }
        public string ICProductPaintProcessAText { get; set; }
        public string ICProductPaintProcessB { get; set; }
        public string ICProductPaintProcessBText { get; set; }
        public string ICProductPaintProcessC { get; set; }
        public string ICProductPaintProcessCText { get; set; }

    }
}

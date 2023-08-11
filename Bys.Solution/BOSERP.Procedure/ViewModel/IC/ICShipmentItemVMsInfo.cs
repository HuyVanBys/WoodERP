using BOSLib;

namespace BOSERP
{
    public class ICShipmentItemVMsInfo : BusinessObject
    {
        public int FK_ICProductID { get; set; }

        public string ICShipmentItemProductDesc { get; set; }

        public decimal ICShipmentItemProductUnitPrice { get; set; }

        public decimal ICShipmentItemProductQty { get; set; }

        public string ICShipmentItemProductName { get; set; }

        public decimal ICShipmentItemTotalAmount { get; set; }

        public string ICShipmentItemProductSerialNo { get; set; }

        public int FK_ICStockID { get; set; }

        public int FK_ICMeasureUnitID { get; set; }

        public int FK_MMBatchProductID { get; set; }

        public decimal ICShipmentItemHeight { get; set; }

        public decimal ICShipmentItemWidth { get; set; }

        public decimal ICShipmentItemLength { get; set; }

        public decimal ICShipmentItemWidthMax { get; set; }

        public decimal ICShipmentItemLengthMax { get; set; }

        public string ICShipmentItemBatchProductItemProductSerial { get; set; }

        public string ICShipmentItemComment { get; set; }

        public int FK_HRDepartmentRoomGroupItemID { get; set; }

        public int FK_MMLineID { get; set; }

        public int FK_MMWorkShopID { get; set; }

        public decimal ICShipmentItemProductFactor { get; set; }

        public decimal ICShipmentItemProductUnitCost { get; set; }

        public decimal ICShipmentItemTotalCost { get; set; }

        public int FK_ICProductSerieID { get; set; }

        public string ICShipmentItemRef { get; set; }

        public string ICShipmentItemRefID { get; set; }

        public string MMAllocationPlanItemRef { get; set; }

        public byte[] ICShipmentItemProductPicture { get; set; }

        public decimal ICShipmentItemProductExchangeQty { get; set; }

        public int FK_ICProductForBatchID { get; set; }

        public int FK_MMBatchProductItemID { get; set; }

        public bool ICShipmentItemIsSpecificCalculation { get; set; }

        public string ICShipmentItemLotNo { get; set; }

        public decimal ICShipmentItemPerimeter { get; set; }

        public decimal ICShipmentItemWoodQty { get; set; }

        public int FK_MMOperationID { get; set; }

        public int FK_ICProductAttributeQualityID { get; set; }
        public int FK_ICProductAttributeTTMTID { get; set; }
        public int FK_GECountryID { get; set; }
        public string ICShipmentItemProductName2 { get; set; }
        public decimal MMBatchProductProductionNormItemProductLength { get; set; }
        public decimal MMBatchProductProductionNormItemProductHeight { get; set; }
        public decimal MMBatchProductProductionNormItemProductWidth { get; set; }
        public string ICShipmentItemSOName { get; set; }
    }
}

using BOSLib;

namespace BOSERP
{
    public class IPShipmentItemsInfo : BusinessObject
    {
        public string ICShipmentItemSOName { get; set; }
        public string MMBatchProductNo { get; set; }
        public string ICShipmentItemProductNo { get; set; }
        public string ICProductNo { get; set; }
        public string ICProductName { get; set; }
        public string ICMeasureUnitName { get; set; }
        public decimal ICShipmentItemProductHeight { get; set; }
        public decimal ICShipmentItemProductWidth { get; set; }
        public decimal ICShipmentItemProductLength { get; set; }
        public decimal ICShipmentItemQty1 { get; set; }
        public decimal ICShipmentItemProductQty { get; set; }
        public decimal ICShipmentItemProductUnitPrice { get; set; }
        public string ICImportAndExportReasonName { get; set; }

        #region Extra
        public string MessageError { get; set; }
        public int FK_ICProductID { get; set; }
        public int FK_MMBatchProductID { get; set; }
        public int FK_ICMeasureUnitID { get; set; }
        public int FK_ICShipmentItemProductID { get; set; }
        public int FK_ICShipmentItemID { get; set; }
        #endregion
    }
}
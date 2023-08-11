using System;

namespace BOSERP.Procedure.Modules.IC.SemiProductReceipt.ImportInfo
{
    public class IPReceiptItemsInfo
    {
        public string ICStockNo { get; set; }
        public DateTime ICReceiptDate { get; set; }
        public string ICReceiptType { get; set; }
        public string MMOperationNo { get; set; }
        public string ARCustomerName { get; set; }
        public string MMWorkShopNo { get; set; }
        public string MMLineNo { get; set; }
        public string HRDepartmentRoomGroupItemNo { get; set; }
        public string MMBatchProductNo { get; set; }
        public string MMBatchProductItemProductSerial { get; set; }
        public string ICProductForBatchNo { get; set; }
        public string ICProductNo { get; set; }
        public decimal ICReceiptItemProductQty { get; set; }
        public int FK_MMOperationID { get; set; }
        public int FK_MMWorkShopID { get; set; }
        public int FK_MMLineID { get; set; }
        public int FK_HRDepartmentRoomGroupItemID { get; set; }
        public int FK_ACAccountID { get; set; }
        public int FK_ICStockID { get; set; }
        public string ICReceiptItemProductSerialNo { get; set; }
        public string ICReceiptItemLotNo { get; set; }
        public decimal ICReceiptItemProductUnitCost { get; set; }
    }
}

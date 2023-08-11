using BOSLib;
using System;
namespace BOSERP
{
    public class ICReceiptItemForViews : ICReceiptItemsInfo
    {
        #region Extra Properties

        public string ICProductNo { get; set; }
        public string RowNumber { get; set; }
        public decimal ICProductComponentQty { get; set; }
        public string ICReceiptType { get; set; }
        public string ICReceiptStatus { get; set; }
        public string ICReceiptStatusDisplayText { get; set; }
        public String ICReceiptPackNo { get; set; }
        public String ICDepartmentName { get; set; }
        public String ICProductGroupName { get; set; }
        public String APSupplierName { get; set; }
        public String ICStockName { get; set; }
        public String ICMeasureUnitName { get; set; }


        public string GECurrencyName { get; set; }
        public string ICProductName { get; set; }
        public string ICProductSupplierNumber { get; set; }
        public string ICProductDesc { get; set; }

        public DateTime ICProductSerieReceiptDate { get; set; }

        public int ICProductID { get; set; }
        public string MMBatchProductNo { get; set; }
        public string MMOperationName { get; set; }
        public decimal ICInventoryStockQuantity { get; set; }
        public decimal ICReceiptItemQtyreceived { get; set; }
        public string SerialNo { get; set; }
        public string ICDocumentType { get; set; }
        public string ICDocumentTypeVN { get; set; }
        [FormatGroup(FormatGroupAttribute.csFormatGroupN3)]
        public decimal ICReceiptItemWoodQtyToDate { get; set; }

        public int FK_MMBatchProductIDInReceipt { get; set; }
        public int FK_MMOperationIDInReceipt { get; set; }
        public int FK_ICProductAttributeTTMTIDInReceipt { get; set; }
        public int FK_ICStockIDInReceipt { get; set; }
        public int FK_ACSegmentID { get; set; }
        public int FK_ACAccountIDInProduct { get; set; }
        public decimal ReceiptItemRemainQty { get; set; }


        #endregion
        #region Report

        public string ĐVT { get; set; }
        public string Kho { get; set; }
        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal ICReceiptTotalCost { get; set; }
        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal ICReceiptSubTotalCost { get; set; }
        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal ICReceiptDiscountPerCent { get; set; }
        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal ICReceiptDiscountFix { get; set; }
        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal ICReceiptShippingFees { get; set; }
        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal ICReceiptShippingExtraFees { get; set; }
        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal ICReceiptTaxPercent { get; set; }
        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal ICReceiptTaxAmount { get; set; }

        public String HRDepartmentName { get; set; }

        public String ICShipmentDesc { get; set; }
        public String ICReceiptInvoiceInNo { get; set; }
        public String ICReceiptDeliveryContactName { get; set; }
        public String HRDepartmentRoomName { get; set; }
        public DateTime ICReceiptInvoiceInDate { get; set; }
        public string APSupplierNo { get; set; }

        //[HAnh][ADD][report 137],START
        [FormatGroup(FormatGroupAttribute.csFormatGroupN3)]
        public decimal ICShipmentItemProductQty { get; set; }
        [FormatGroup(FormatGroupAttribute.csFormatGroupN3)]
        public decimal ICShipmentItemWoodQty { get; set; }
        [FormatGroup(FormatGroupAttribute.csFormatGroupN3)]
        public decimal ICReceiptItemProductQtyLumber { get; set; }
        [FormatGroup(FormatGroupAttribute.csFormatGroupN3)]
        public decimal ICReceiptItemWoodQtyLumber { get; set; }
        public string ICProductAttributeValueRoundWood { get; set; }
        [FormatGroup(FormatGroupAttribute.csFormatGroupN3)]
        public decimal SLDauky { get; set; }
        [FormatGroup(FormatGroupAttribute.csFormatGroupN3)]
        public decimal KLDauky { get; set; }
        [FormatGroup(FormatGroupAttribute.csFormatGroupN3)]
        public decimal SLTonkho { get; set; }
        [FormatGroup(FormatGroupAttribute.csFormatGroupN3)]
        public decimal KLTonkho { get; set; }
        [FormatGroup(FormatGroupAttribute.csFormatGroupN3)]
        public decimal Tongdaixuat { get; set; }
        [FormatGroup(FormatGroupAttribute.csFormatGroupN3)]
        public decimal Tongdainhap { get; set; }
        [FormatGroup(FormatGroupAttribute.csFormatGroupN3)]
        public decimal Tongdaitondau { get; set; }
        [FormatGroup(FormatGroupAttribute.csFormatGroupN3)]
        public decimal Tongdaiton { get; set; }
        [FormatGroup(FormatGroupAttribute.csFormatGroupN3)]
        public decimal Tilethuhoi { get; set; }
        //[HAnh][ADD][report 137],END
        #endregion


        #region Stock card
        public string StockCardNo { get; set; }
        public string StockCardReceiptNo { get; set; }
        public string StockCardShipmentNo { get; set; }
        public DateTime StockCardDate { get; set; }
        public string StockCardDesc { get; set; }

        [FormatGroup(FormatGroupAttribute.csFormatGroupN4)]
        public decimal StockCardOpeningBalance { get; set; }

        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal StockCardOpeningBalanceAmount { get; set; }

        [FormatGroup(FormatGroupAttribute.csFormatGroupN4)]
        public decimal StockCardBalanceProductQty { get; set; }

        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal StockCardBalanceAmount { get; set; }

        [FormatGroup(FormatGroupAttribute.csFormatGroupN4)]
        public decimal StockCardReceiptItemProductQty { get; set; }

        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal StockCardReceiptAmount { get; set; }

        [FormatGroup(FormatGroupAttribute.csFormatGroupN4)]
        public decimal StockCardShipmentItemProductQty { get; set; }

        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal StockCardShipmentAmount { get; set; }

        [FormatGroup(FormatGroupAttribute.csFormatGroupN4)]
        public decimal StockCardEndBalance { get; set; }

        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal StockCardEndBalanceAmount { get; set; }

        public decimal ICReceiptItemM3PercentCPGo { get; set; }
        public decimal ICReceiptItemM3PercentCPChung { get; set; }
        public decimal ICReceiptItemCPNguyenLieuGo { get; set; }
        public decimal ICReceiptItemCPNguyenLieuKhac { get; set; }
        public decimal ICReceiptItemCPNCTT { get; set; }
        public decimal ICReceiptItemCPChung { get; set; }
        public decimal ICReceiptItemCPChungNhaMay { get; set; }
        public decimal ICReceiptItemCostBTP { get; set; }
        public decimal ICReceiptItemOutSoucingFee { get; set; }

        public decimal ReceiptTotalCost { get; set; }
        public decimal ICReceiptItemProductPerimeterMin { get; set; }

        public int FK_APSupplierID { get; set; }

        public String ICReceiptTypeCombo { get; set; }
        public string PurchaseOrderNo { get; set; }
        public int ICProductAccountID { get; set; }



        public string ICProductAttributeWoodType { get; set; }

        public string APPurchaseOrderContractNo { get; set; }
        public DateTime APPurchaseOrderContractDate { get; set; }
        public string APInvoiceInSupplierNo { get; set; }
        public DateTime APInvoiceInVATDate { get; set; }
        public string ICProductAttributeTTMT { get; set; }
        public string ThangNam { get; set; }
        public string ReceiptDate { get; set; }
        public string PurchaseOrderContractDate { get; set; }
        public string InvoiceInVATDate { get; set; }

        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string MaCum { get; set; }
        public string TenCum { get; set; }
        public string MaCT { get; set; }
        public string TenCT { get; set; }
        public decimal SLDM { get; set; }
        public decimal SLDMCT { get; set; }
        public decimal SLSP { get; set; }
        public decimal SLHoanThanh { get; set; }
        public decimal TyLeHoanThanh { get; set; }
        public decimal SLDaNhap { get; set; }
        public decimal SLXuatChuyen { get; set; }


        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal ARSaleOrderItemProductUnitPrice { get; set; }

        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal ARSaleOrderItemTotalAmount { get; set; }

        public string APPurchaseOrderChannel { get; set; }

        [FormatGroup(FormatGroupAttribute.csFormatGroupN4)]
        public decimal TotalBlock { get; set; }
        [FormatGroup(FormatGroupAttribute.csFormatGroupN4)]
        public decimal KLNhapPhoi { get; set; }
        [FormatGroup(FormatGroupAttribute.csFormatGroupN4)]
        public decimal KLNhapSoChe { get; set; }
        [FormatGroup(FormatGroupAttribute.csFormatGroupN4)]
        public decimal KLNhapTinhChe { get; set; }
        [FormatGroup(FormatGroupAttribute.csFormatGroupN4)]
        public decimal KLNhapLapRap { get; set; }
        [FormatGroup(FormatGroupAttribute.csFormatGroupN4)]
        public decimal KLNhapSon { get; set; }
        [FormatGroup(FormatGroupAttribute.csFormatGroupN4)]
        public decimal KLNhapDongGoi { get; set; }

        [FormatGroup(FormatGroupAttribute.cstFormatGroupPercent)]
        public decimal TyLePhoi { get; set; }
        [FormatGroup(FormatGroupAttribute.cstFormatGroupPercent)]
        public decimal TyLeSoChe { get; set; }
        [FormatGroup(FormatGroupAttribute.cstFormatGroupPercent)]
        public decimal TyLeTinhChe { get; set; }
        [FormatGroup(FormatGroupAttribute.cstFormatGroupPercent)]
        public decimal TyLeLapRap { get; set; }
        [FormatGroup(FormatGroupAttribute.cstFormatGroupPercent)]
        public decimal TyLeSon { get; set; }
        [FormatGroup(FormatGroupAttribute.cstFormatGroupPercent)]
        public decimal TyLeDongGoi { get; set; }
        public string MMOperationDetailPlanNo { get; set; }
        public string MMOperationDetailPlanName { get; set; }
        public string MMOperationDetailPlanWeek { get; set; }
        public string ProductNoForBachNo { get; set; }

        public decimal ICReceiptItemShipmentItemQty { get; set; }
        public decimal ICReceiptItemBatchProductItemQty { get; set; }


        #endregion

        public int FK_MMBatchProductTransferID { get; set; }
        public int FK_ICProductTransferID { get; set; }
        public int ICShipmetSerieID { get; set; }
        public bool IsSameSerieID { get; set; }



    }
}

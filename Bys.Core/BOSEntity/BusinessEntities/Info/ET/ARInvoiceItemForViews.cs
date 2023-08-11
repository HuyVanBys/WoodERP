using BOSLib;
using System;
namespace BOSERP
{
    public class ARInvoiceItemForViews : ARInvoiceItemsInfo
    {
        public ARInvoiceItemForViews()
        {
        }

        public String ARInvoiceItemSupplierName { get; set; }
        public String ARCustomerContactAddressLine3 { get; set; }
        public String ARCustomerName { get; set; }
        public String ARSellerName { get; set; }
        public String ARCustomerContactPhone { get; set; }
        public String ARCustomerContactCellPhone { get; set; }
        public String ARInvoiceNo { get; set; }
        public String ARInvoiceRowNumber { get; set; }
        public string ARInvoiceStatus { get; set; }
        public string ARInvoiceStatusDisplayedText { get; set; }
        public string ARInvoiceItemProductNo { get; set; }

        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal ARInvoiceTotalAmount { get; set; }

        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal ARInvoiceDepositBalance { get; set; }

        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal ARInvoiceBalanceDue { get; set; }

        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal ARInvoicePaymentAmount { get; set; }

        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal ARInvoiceReturnAmount { get; set; }

        public DateTime ARInvoiceDeliveryDate { get; set; }

        public DateTime ARInvoiceDate { get; set; }

        public string ICProductSerieNo { get; set; }

        public DateTime ICProductSerieReceiptDate { get; set; }

        public string ARSaleOrderNo { get; set; }

        public DateTime ARSaleOrderDate { get; set; }

        public string ICStockName { get; set; }
        public decimal ICProductUnitCost { get; set; }
        public decimal ICProductTotalUnitCost { get; set; }
        public decimal ICProductGrossProfit { get; set; }

        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal ARCustomerRepaid { get; set; }

        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal CustomerPaymentByOwingExchangeMethod { get; set; }

        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal CustomerRepaidByOwingExchangeMethod { get; set; }

        public string ARInvoiceReference { get; set; }
        public string ARSaleOrderDateString { get; set; }
        public string ARCustomerNo { get; set; }
        public decimal ARInvoiceDiscountPerCent { get; set; }
        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal ARInvoiceDiscountFix { get; set; }
        public decimal ARInvoiceTaxPercent { get; set; }
        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal ARInvoiceTaxAmount { get; set; }

        public string HREmployeeName { get; set; }
        public string ICMeasureUnitName { get; set; }
        public decimal ARInvoiceSubTotalAmount { get; set; }
        public string ICProductDesc { get; set; }
        public string ICProductNo { get; set; }
        public string ARInvoicePONo { get; set; }
        public int FK_GEPaymentTermID { get; set; }
        #region RP140
        public string MMBatchProductNo { get; set; }
        //public int FK_ARCustomerID { get; set; }
        [FormatGroup(FormatGroupAttribute.csFormatGroupQtyN2)]
        public decimal MMBatchProductItemProductQty { get; set; }
        [FormatGroup(FormatGroupAttribute.csFormatGroupN4)]
        public decimal MMBatchProductProductionNormItemBlockPerOne { get; set; }
        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal ICReceiptItemWoodFee { get; set; }
        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal ICReceiptItemPaintFee { get; set; }
        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal ICReceiptItemHardwareFee { get; set; }
        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal ICReceiptItemMaintainFee { get; set; }
        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal ICReceiptItemDirectSalaryFee { get; set; }
        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal ICReceiptItemElecFee { get; set; }
        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal ICReceiptItemDepreciationFee { get; set; }
        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal ICReceiptItemOtherFee { get; set; }
        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal ICReceiptItemChiPhiPhanBo { get; set; }
        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal ICReceiptItemChiPhiKhauHao { get; set; }
        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal ICReceiptItemChiPhiVatLieuChung { get; set; }
        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal ICReceiptItemChiPhiTienDien { get; set; }
        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal ICReceiptItemChiPhiTienLuong { get; set; }
        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal CongGiaVon { get; set; }
        [FormatGroup(FormatGroupAttribute.csFormatGroupN4)]
        public decimal MMProductionNormTotalPaint { get; set; }
        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal LNGop { get; set; }
        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal ICInventoryStockUnitCost { get; set; }

        public string ICProductGroupName { get; set; }
        public string ICDepartmentName { get; set; }
        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal CPGiaCong { get; set; }
        public string ICShipmentProposalNo { get; set; }
        public string ProductAttributeWoodTypeValue { get; set; }
        public string ProductAttributeTTMTValue { get; set; }
        public string MouthAndYear { get; set; }
        public string ARInvoiceVATInvoiceNo { get; set; }
        public string ARSaleOrderPONo { get; set; }
        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal InventoryStockUnitCost { get; set; }
        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal ICInventoryStockTotalCost { get; set; }

        public string WoodType { get; set; } // lo?i g?
        public string ARInvoiceVATInvoiceNoNK { get; set; }
        public string ARInvoiceDateNK { get; set; }
        public string ARInvoiceVATInvoiceNoND { get; set; }
        public string ARInvoiceDateND { get; set; }
        public string ARSaleOrderSaleType { get; set; }
        public decimal MMBatchProductProductionNormItemBlockPerOneTotal { get; set; }
        public int TPtrongLSX { get; set; }
        public decimal BatchProductProductionNormItemBlockPerOne { get; set; }

        public string ARInvoiceDateText { get; set; }
        public string ARInvoiceDeliveryDateText { get; set; }

        public string ICProductAttributeValueTTMT { get; set; }
        public decimal TongM3TinhTheoPG { get; set; }
        public decimal TongM3TinhTheoLSX { get; set; }
        public decimal TongM3TinhTheoHDCTG { get; set; }
        public decimal TongM3TinhDaXuat { get; set; }
        public decimal TongSoLuongDaXuat { get; set; }
        public string HoSoNhap { get; set; }
        public decimal SoLuong { get; set; }
        public decimal KhoiLuong { get; set; }

        public string ARSaleOrderDateText { get; set; }
        public string ICProductCustomerNumber { get; set; }

        public string ICProductWoodGroup { get; set; }
        public string InvoiceInSupplierNo { get; set; }
        public string QuyCach { get; set; }
        public decimal KLTinhXuat { get; set; }
        public decimal M3TinhTheoSP { get; set; }
        #endregion
        public string ICProductAttributeValue { get; set; }
        public int FK_APSupplierID { get; set; }
        public string APSupplierName { get; set; }
        public int FK_HREmployeeID { get; set; }
        public decimal TongSL { get; set; }

        public int ARInvoiceItemRecordOrder { get; set; }
    }
}

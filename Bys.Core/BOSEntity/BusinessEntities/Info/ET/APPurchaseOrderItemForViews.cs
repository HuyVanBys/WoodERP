using BOSLib;
using System;
namespace BOSERP
{
    public class APPurchaseOrderItemForViews : APPurchaseOrderItemsInfo
    {
        /// <summary>
        /// Gets or sets text of purchase order item type
        /// </summary>
        public string ADConfigText { get; set; }
        public String ICReceiptStatus { get; set; }
        public String APPurchaseOrderType { get; set; }
        public string APPurchaseOrderTypeDisplayText { get; set; }
        public String APPurchaseOrderStatus { get; set; }
        public string APPurchaseOrderStatusDisplayText { get; set; }
        public String APSupplierName { get; set; }
        public String ICMeasureUnitName { get; set; }
        public String APSupplierContactPhone1 { get; set; }
        public String APSupplierContactPhone2 { get; set; }
        public int FK_GECurrencyID { get; set; }
        public DateTime APPurchaseOrderDate { get; set; }
        public DateTime APPurchaseOrderDeliveryDate { get; set; }
        public DateTime APPurchaseOrderPackingDate { get; set; }
        public String APPurchaseOrderDesc { get; set; }
        public string APPurchaseOrderComment { get; set; }
        public String APPurchaseOrderRowNumber { get; set; }

        [FormatGroup(FormatGroupAttribute.cstFormatGroupPriceByCurrency)]
        public decimal APPurchaseOrderTotalCost { get; set; }

        [FormatGroup(FormatGroupAttribute.cstFormatGroupPriceByCurrency)]
        public decimal APPurchaseOrderDepositBalance { get; set; }

        [FormatGroup(FormatGroupAttribute.cstFormatGroupPriceByCurrency)]
        public decimal APPurchaseOrderBalanceDue { get; set; }

        [FormatGroup(FormatGroupAttribute.cstFormatGroupExchangeRate)]
        public decimal APPurchaseOrderVolume { get; set; }



        public string ICModelName { get; set; }
        public string ICModelDetailsName { get; set; }
        public string GECountryName { get; set; }
        public string ICProductNo { get; set; }
        public string ICProductName { get; set; }
        public string ICProductAttributeTTMT { get; set; }
        public string APProposalNo { get; set; }
        //public string MMBatchProductNo { get; set; }
        public string MMFromOperationName { get; set; }
        public string MMToOperationName { get; set; }
        public String APSupplierNo { get; set; }

        public DateTime APProposalDate { get; set; }
        public decimal SoNgayTre { get; set; }
        public decimal RemainQty { get; set; }

        public string QuantityDetail { get; set; }
        public string ICProductDesc { get; set; }
        public string QuyCach { get; set; }
        public string ARCustomerName { get; set; }
        [FormatGroup(FormatGroupAttribute.csFormatGroupN4)]
        public decimal APPurchaseOrderItemNotReceiptYet { get; set; }
        public string ICProductAttributeValue { get; set; }
        public string APPurchaseOrderContractNo { get; set; }

        public string APPurchaseOrderQtyStr { get; set; }
        public string HRDepartmentRoomName { get; set; }
        public string HRDepartmentName { get; set; }
        public string PurchaseOrderProposedEmployeeName { get; set; }

        public string ProductForBacthNo { get; set; }
        public int FK_ICProductSerieID { get; set; }
        public int ICReceiptID { get; set; }
        public string ProductNoForBachNo { get; set; }
        public string MMOperationName { get; set; }
        public decimal APPurchaseOrderItemReceiptItemQty { get; set; }
        public decimal APPurchaseOrderItemShipmentItemQty { get; set; }
        public decimal APPurchaseOrderItemBatchProductItemQty { get; set; }
        public decimal MMOperationDetailPlanItemPlanProductQty { get; set; }
        public string MMOperationDetailPlanNo { get; set; }
        public string MMOperationDetailPlanWeek { get; set; }
        public string ICShipmentNo { get; set; }
        public string ICProductEquipmentDesc { get; set; }


        //BDVIET ADD EMAIL
        public string MaDMH { get; set; }
        public string DienGiai { get; set; }
        public string NhaCungCap { get; set; }
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string MoTa { get; set; }
        public string DonViTinh { get; set; }
        public decimal SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get; set; }
        public string GhiChu { get; set; }
        public decimal Thue { get; set; }
        public decimal ChietKhau { get; set; }
        public string LoaiHangDat { get; set; }
        public int FK_ARSaleOrderID { get; set; }
        public string ARSaleOrderNo { get; set; }
        public string MMBatchProductItemProductSerial { get; set; }
        public string APPurchaseOrderReceiptTypeCombo { get; set; }
        public decimal LeadTime { get; set; }
        public DateTime ThoiGianCan { get; set; }
        //public decimal ICReceiptItemConversionFactor { get; set; }
        public int ICMeasureUnitID2 { get; set; }
        public bool ICProductMeasureUnitIsEdit { get; set; }

    }
}

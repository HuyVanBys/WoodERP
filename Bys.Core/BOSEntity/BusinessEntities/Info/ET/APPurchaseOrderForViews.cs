using BOSLib;
using System;
namespace BOSERP
{
    public class APPurchaseOrderForViews : APPurchaseOrdersInfo
    {
        [FormatGroup(FormatGroupAttribute.cstFormatGroupPriceByCurrency)]
        public decimal APDocumentPaymentAmount { get; set; }

        public string GECurrencyName { get; set; }

        [FormatGroup(FormatGroupAttribute.cstFormatGroupExchangeRate)]
        public decimal APDocumentPaymentExchangeRate { get; set; }

        public string APDocumentPaymentExchangeWay { get; set; }

        public decimal APDocumentPaymentDueAmount { get; set; }


        public string APSupplierPaymentNo { get; set; }


        public string ReportReferencesNo { get; set; }
        [FormatGroup(FormatGroupAttribute.cstFormatGroupPriceByCurrency)]
        public decimal ReportTotalAmount { get; set; }
        [FormatGroup(FormatGroupAttribute.cstFormatGroupPriceByCurrency)]
        public decimal ReportPaidAmount { get; set; }
        [FormatGroup(FormatGroupAttribute.cstFormatGroupPriceByCurrency)]
        public decimal ReportBalanceDueAmount { get; set; }
        public DateTime ReportContractFromDate { get; set; }
        public DateTime ReportContractToDate { get; set; }
        public string ReportDocumentType { get; set; }
        public string ReportObjectType { get; set; }

        [FormatGroup(FormatGroupAttribute.cstFormatGroupPriceByCurrency)]
        public decimal ReportLeftAmount { get; set; }

        public string APSupplierContactAddressLine3 { get; set; }
        public string HREmployeeName { get; set; }
        public string ADConfigText { get; set; }
        public string APPurchaseOrderSupplierContractName { get; set; }
        public string HREmployeeTel2 { get; set; }
        public string GEPaymentTermName { get; set; }
        public string APSupplierNo { get; set; }
        public string APInvoiceInNo { get; set; }
        [FormatGroup(FormatGroupAttribute.cstFormatGroupPriceByCurrency)]
        public decimal APInvoiceIntotalAmount { get; set; }
        public DateTime APInvoiceIndate { get; set; }
        public DateTime APInvoiceVATIndate { get; set; }
        public int deadline { get; set; }
        [FormatGroup(FormatGroupAttribute.cstFormatGroupPriceByCurrency)]
        public decimal APPurchaseOrderPaymentTimeAmountDeposit { get; set; }
        public DateTime PurchaseOrderPaymentTimeDateDeposit { get; set; }
        public string PurchaseOrderNo { get; set; }
        [FormatGroup(FormatGroupAttribute.cstFormatGroupPriceByCurrency)]
        public decimal PurchaseOrdertotalAmount { get; set; }
        [FormatGroup(FormatGroupAttribute.cstFormatGroupPriceByCurrency)]
        public decimal Notronghan { get; set; }
        [FormatGroup(FormatGroupAttribute.cstFormatGroupPriceByCurrency)]
        public decimal Noqua5den15ngay { get; set; }
        [FormatGroup(FormatGroupAttribute.cstFormatGroupPriceByCurrency)]
        public decimal Noqua16den30ngay { get; set; }
        [FormatGroup(FormatGroupAttribute.cstFormatGroupPriceByCurrency)]
        public decimal Noquatren30ngay { get; set; }
        public string HREmployessName { get; set; }
        public string APInvoiceInSupplierNo { get; set; }
        public string purchaseOrderDateDelivery { get; set; }
        public string purchaseOrderDate { get; set; }
        public decimal TienDaTra { get; set; }

        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal APPurchaseOrderItemRemainValue { get; set; }
        public decimal SoNgayTre { get; set; }
        public string GECurrencyNo { get; set; }
        public DateTime NgayToiHan { get; set; }
        public string APProposalNo { get; set; }
        public DateTime APProposalDate { get; set; }
    }
}

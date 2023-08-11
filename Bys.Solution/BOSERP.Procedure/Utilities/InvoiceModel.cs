using System.Xml.Serialization;

namespace BOSERP.Utilities
{
    [XmlRoot("invoice", Namespace = "http://laphoadon.gdt.gov.vn/2014/09/invoicexml/v1")]
    public class InvoiceModel
    {
        public invoiceData invoiceData { get; set; }

        public controlData controlData { get; set; }
    }

    public class invoiceData
    {
        public invoiceData()
        {
            id = "data";
        }
        [XmlAttribute]
        public string id { get; set; }
        public string sellerAppRecordId { get; set; }
        public string invoiceAppRecordId { get; set; }
        public string invoiceType { get; set; }
        public string templateCode { get; set; }
        public string invoiceSeries { get; set; }
        public string invoiceNumber { get; set; }
        public string invoiceName { get; set; }
        public string invoiceIssuedDate { get; set; }
        public string signedDate { get; set; }
        public string submittedDate { get; set; }
        public string currencyCode { get; set; }
        public string adjustmentType { get; set; }
        public string originalInvoiceId { get; set; }
        public payment[] payments { get; set; }
        public delivery delivery { get; set; }
        public string sellerLegalName { get; set; }
        public string sellerTaxCode { get; set; }
        public string sellerAddressLine { get; set; }
        public string sellerPhoneNumber { get; set; }
        public string sellerFaxNumber { get; set; }
        public string sellerEmail { get; set; }
        public string sellerContactPersonName { get; set; }
        //public string sellerCreatedInvoicePersonName { get; set; }
        public string sellerSignedPersonName { get; set; }
        public string sellerSubmittedPersonName { get; set; }
        public string buyerDisplayName { get; set; }
        public string buyerLegalName { get; set; }
        public string buyerTaxCode { get; set; }
        public string buyerFaxNumber { get; set; }
        public string buyerEmail { get; set; }
        public item[] items { get; set; }
        public invoiceTaxBreakdown[] invoiceTaxBreakdowns { get; set; }
        public string sumOfTotalLineAmountWithoutVAT { get; set; }
        public string totalAmountWithoutVAT { get; set; }
        public string totalVATAmount { get; set; }
        public string totalAmountWithVAT { get; set; }
        public string totalAmountWithVATInWords { get; set; }
        public string isTotalAmountPos { get; set; }
        public string isTotalAmtWithoutVatPos { get; set; }
        public string isTotalVATAmountPos { get; set; }
        public string isDiscountAmtPos { get; set; }
    }

    public class payment
    {
        public string paymentMethodName { get; set; }
    }

    public class delivery
    {
        public string deliveryOrderDate { get; set; }
        public string deliveryOrderNumber { get; set; }
    }

    public class item
    {
        public string lineNumber { get; set; }
        public string itemCode { get; set; }
        public string itemName { get; set; }
        public string unitCode { get; set; }
        public string unitName { get; set; }
        public string quantity { get; set; }
        public string itemTotalAmountWithoutVat { get; set; }
        public string vatPercentage { get; set; }
        public string vatAmount { get; set; }
        public string unitPrice { get; set; }
        public string isIncreaseItem { get; set; }
    }

    public class invoiceTaxBreakdown
    {
        public string vatPercentage { get; set; }
        public string vatTaxableAmount { get; set; }
        public string vatTaxAmount { get; set; }
    }

    public class controlData
    {
        public string systemCode { get; set; }
    }

    public class certifiedData
    {
        public string sellerTaxCode { get; set; }
        public string buyerTaxCode { get; set; }
        public string totalAmount { get; set; }
        public string totalVATAmount { get; set; }
        public string issuedDate { get; set; }
        public string sellerSignatureHash { get; set; }
        public string originalCertifiedId { get; set; }
        public string certifiedId { get; set; }
        public string certifiedDate { get; set; }
        public string signature { get; set; }
        public string publicKey { get; set; }
    }
}
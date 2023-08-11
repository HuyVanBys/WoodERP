using System.Xml.Serialization;

namespace BOSERP.Utilities
{
    [XmlRoot("Invoices")]
    public class Invoices
    {
        public Inv Inv { get; set; }
    }
    public class Inv
    {
        public string key { get; set; }
        public Invoice Invoice { get; set; }
    }
    public class CInvoices
    {
        public InvC Inv { get; set; }
    }
    public class HashInv
    {
        public Haskey Inv { get; set; }
    }
    public class PublicInv
    {
        public HashInvData Inv { get; set; }
    }
    public class HashInvData
    {
        public string key { get; set; }
        public string idInv { get; set; }
        public string hashValue { get; set; }
        public string pattern { get; set; }
        public string serial { get; set; }
    }
    public class StatusInvData
    {
        public string key { get; set; }
        public string Status { get; set; }
    }
    public class Haskey
    {
        public string key { get; set; }
    }
    public class InvC
    {
        public string Serial { get; set; }
        public string InvNo { get; set; }
    }
    public class Invoice
    {
        //public string OrderNo { get; set; }
        //public string OrderDate { get; set; }
        public string CusCode { get; set; }
        public string CusName { get; set; }
        //public string CusCom { get; set; }
        public string CusAddress { get; set; }
        public string CusPhone { get; set; }
        public string CusTaxCode { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentStatus { get; set; }
        public string KindOfService { get; set; }
        public Product[] Products { get; set; }
        //public string GrossValue { get; set; }
        //public string VatAmount0 { get; set; }
        //public string GrossValue0 { get; set; }
        //public string VatAmount5 { get; set; }
        //public string GrossValue5 { get; set; }
        //public string VatAmount10 { get; set; }
        //public string GrossValue10 { get; set; }
        public string Total { get; set; }
        public string DiscountAmount { get; set; }
        public string VATRate { get; set; }
        public string VATAmount { get; set; }
        public string Amount { get; set; }
        public string AmountInWords { get; set; }
        //public string ArisingDate { get; set; }
        public string EmailDeliver { get; set; }
        public string SMSDeliver { get; set; }
    }

    //public class Products
    //{
    //    public Product[] Product { get; set; }
    //}
    public class Product
    {
        //public string Code { get; set; }
        public string ProdName { get; set; }
        public string ProdUnit { get; set; }
        public string ProdQuantity { get; set; }
        public string ProdPrice { get; set; }
        //public string Total { get; set; }
        //public string VATRate { get; set; }
        //public string VATAmount { get; set; }
        public string Amount { get; set; }
    }
}
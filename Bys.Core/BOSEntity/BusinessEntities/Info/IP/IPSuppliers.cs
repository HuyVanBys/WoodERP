using BOSLib;
using System;

namespace BOSERP
{
    public class IPSuppliersInfo : BusinessObject
    {
        public string IPSupplierNo { get; set; }       //
        public string IPSupplierName { get; set; }    //
        public string IPSupplierOtherType { get; set; }  //
        public string IPSupplierTypeCombo { get; set; }  //
        public DateTime IPSupplierStartDate { get; set; }  //
        public string IPSupplierContactPhone { get; set; }  //
        public string IPSupplierContactPhone1 { get; set; }  //
        public string IPSupplierContactFax { get; set; }  //
        public string FK_BRBranchID { get; set; }  //
        public string IPSupplierWebsite { get; set; }  //
        public string IPSupplierContactEmail1 { get; set; }  //
        public string IPSupplierContactAddressLine1 { get; set; }  //
        public string FK_GECountryID { get; set; }  //
        public string FK_GEStateProvinceID { get; set; }  //
        public string FK_GEDistrictID { get; set; }  //
        public string IPSupplierContactAddressPostalCode { get; set; }  //
        public bool IPSupplierActiveCheck { get; set; }  //
        public string IPSuppliersDiscountType { get; set; }  //
        public string IPSupplierNoOfOldSys { get; set; }  //
        public string IPSupplierSWIFTCode { get; set; }  //
        public string FK_APSupplierTypeAccountConfigID { get; set; }  //
        public string FK_ACAccountID { get; set; }  //
        public string FK_ACAccountSaleID { get; set; }  //
        public string FK_ACAccountPurchaseID { get; set; }  //
        public string APPaymentMethodCombo { get; set; }  //
        public string IPSupplierTaxNumber { get; set; }  //
        public string FK_GECurrencyID { get; set; }  //
        public int IPSupplierDueDays { get; set; }  //
        public string FK_GEPaymentTermID { get; set; }  //
        public string IPSupplierBankName { get; set; }  //
        public string IPSupplierBankCode { get; set; }  //
        public string IPSupplierBankAccount1 { get; set; }  //
        public string IPSupplierBankAccount2 { get; set; }  //
        public string IPSupplierBankAccountCurrency1 { get; set; }  //
        public string IPSupplierBankAccountCurrency2 { get; set; }  //
        public bool IsPaymentLocked { get; set; }  //
        public bool IsBuyingLocked { get; set; }  //
        #region Extra
        public string MessageError { get; set; }
        public int BRBranchID { get; set; }
        public int GECountryID { get; set; }
        public int GEStateProvinceID { get; set; }
        public int GEDistrictID { get; set; }
        public int APSupplierTypeAccountConfigID { get; set; }
        public int ACAccountID { get; set; }
        public int ACAccountSaleID { get; set; }
        public int ACAccountPurchaseID { get; set; }
        public int GECurrencyID { get; set; }
        public int GEPaymentTermID { get; set; }
        public int SupplierBankAccountCurrency1 { get; set; }
        public int SupplierBankAccountCurrency2 { get; set; }
        public string SupplierOtherType { get; set; }
        public string SupplierTypeCombo { get; set; }
        public string PaymentMethodCombo { get; set; }
        
        #endregion
    }
}


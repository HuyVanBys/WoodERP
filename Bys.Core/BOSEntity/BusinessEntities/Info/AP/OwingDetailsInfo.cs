using BOSLib;

namespace BOSERP
{
    public class OwingDetailsInfo : BusinessObject
    {
        public int FK_GECurrencyID { get; set; }

        public string GECurrencyName { get; set; }

        [FormatGroup(FormatGroupAttribute.cstFormatGroupPriceByCurrency)]
        public decimal DueAmount { get; set; }
    }
}

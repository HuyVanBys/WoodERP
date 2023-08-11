using System;

namespace BOSLib
{
    public class FormatGroupAttribute : Attribute
    {
        public const String cstFormatGroupPrice = "FormatGroupPrice";
        public const String cstFormatGroupQty = "FormatGroupQty";
        public const string cstFormatGroupPriceByCurrency = "FormatGroupPriceByCurrency";
        public const string cstFormatGroupExchangeRate = "FormatGroupExchangeRate";
        public const string cstFormatGroupPercent = "FormatGroupPercent";
        public const string csFormatGroupDayMonth = "FormatGroupDayMonth";
        public const string csFormatGroupNumberOfHours = "FormatGroupNumberOfHours";
        public const string csFormatGroupN3 = "FormatGroupN3";
        public const string csFormatGroupN4 = "FormatGroupN4";
        public const string csFormatGroupQtyN2 = "FormatGroupQtyN2";
        public const string csFormatGroupN5 = "FormatGroupN5";

        public FormatGroupAttribute(String formatGroup)
        {
            this.FormatGroup = formatGroup;
        }

        public String FormatGroup
        {
            get;
            set;
        }
    }
}

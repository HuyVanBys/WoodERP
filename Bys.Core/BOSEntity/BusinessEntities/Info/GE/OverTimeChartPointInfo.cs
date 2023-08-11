using BOSLib;
using System;

namespace BOSERP
{
    public class OverTimeChartPointInfo : BusinessObject
    {
        public DateTime DocumentDate { get; set; }

        public decimal TotalAmount { get; set; }

        public decimal TotalQty { get; set; }
    }
}

﻿using BOSLib;
using System;

namespace BOSERP
{
    public class EmployeeSaleDetailInfo : BusinessObject
    {
        public string DocumentNo { get; set; }

        public DateTime DocumentDate { get; set; }

        public string DocumentType { get; set; }

        public string DocumentComment { get; set; }

        public string SaleOrderNo { get; set; }

        public DateTime SaleOrderDate { get; set; }

        public string SellerName { get; set; }

        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public double TotalAmount { get; set; }

        public string ARSaleOrderDateString { get; set; }
    }
}

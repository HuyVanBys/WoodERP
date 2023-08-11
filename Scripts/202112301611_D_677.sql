Insert into AAColumnAlias Values(0,'','Alive','ARSaleOrderPaymentTimeClearingAmount', N'Đã cấn trừ', 'ARSaleOrderPaymentTimes', '', '', '','', 1, 1)

Insert into STFieldFormats Values('SaleOrder','ARSaleOrderPaymentTimes',(select STFieldFormatGroupID from STFieldFormatGroups Where STFieldFormatGroupName = 'FormatGroupN3'),'ARSaleOrderPaymentTimeClearingAmount')
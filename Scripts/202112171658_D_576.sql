UPDATE dbo.AAColumnAlias
SET AAColumnAliasCaption = N'Đơn giá chưa thuế'
WHERE AATableName = 'APPriceSheetItems'
AND AAColumnAliasName = 'APPriceSheetItemPrice'
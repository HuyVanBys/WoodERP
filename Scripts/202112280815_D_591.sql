
UPDATE dbo.AAColumnAlias
SET AAColumnAliasCaption = N'Số lượng đã hủy'
WHERE AATableName = 'ARCancelVoucherItems'
AND AAColumnAliasName = 'ARCancelVoucherItemTotalQty'
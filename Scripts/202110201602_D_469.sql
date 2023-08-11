-----Báo giá-----
INSERT INTO dbo.STFieldFormats
VALUES
(   'Proposal', -- STFieldFormatModuleName - varchar(50)
    'ARProposals', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN3'),  -- STFieldFormatGroupID - int
    'ARProposalTaxAmount'  -- STFieldFormatColumnName - varchar(100)
)
GO

UPDATE dbo.STFieldFormats 
SET STFieldFormatGroupID = (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN3')
WHERE STFieldFormatColumnName IN ('ARProposalItemTaxAmount', 'ARProposalItemDiscountAmount', 'ARProposalItemTotalAmount',
'ARProposalTotalAmount', 'ARProposalTaxAmount', 'ARProposalDiscountFix', 'ARProposalSubTotalAmount',
'ARProposalItemTotalAmount2', 'ARProposalItemProductUnitPrice', 'ARProposalItemProductUnitPrice2', 'ARProposalItemPrice',
'ICProductUnitPrice','ARProposalItemInternalPrice')

-----Đơn bán hàng-----
INSERT INTO dbo.STFieldFormats
VALUES
(   'SaleOrder', -- STFieldFormatModuleName - varchar(50)
    'ARSaleOrderItems', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN3'),  -- STFieldFormatGroupID - int
    'ARSaleOrderItemTotalAmount2'  -- STFieldFormatColumnName - varchar(100)
)
GO

INSERT INTO dbo.STFieldFormats
VALUES
(   'SaleOrder', -- STFieldFormatModuleName - varchar(50)
    'ARSaleOrders', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN3'),  -- STFieldFormatGroupID - int
    'ARSaleOrderPriceCostTotalAmount'  -- STFieldFormatColumnName - varchar(100)
)
GO

INSERT INTO dbo.STFieldFormats
VALUES
(   'SaleOrder', -- STFieldFormatModuleName - varchar(50)
    'ARSaleOrders', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN3'),  -- STFieldFormatGroupID - int
    'ARSaleOrderTotalDiscountFix'  -- STFieldFormatColumnName - varchar(100)
)
GO

INSERT INTO dbo.STFieldFormats
VALUES
(   'SaleOrder', -- STFieldFormatModuleName - varchar(50)
    'ARSaleOrderItems', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN3'),  -- STFieldFormatGroupID - int
    'ARSaleOrderItemProductUnitPrice2'  -- STFieldFormatColumnName - varchar(100)
)
GO

INSERT INTO dbo.STFieldFormats
VALUES
(   'SaleOrder', -- STFieldFormatModuleName - varchar(50)
    'ARSaleOrderPaymentTimes', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN3'),  -- STFieldFormatGroupID - int
    'ARSaleOrderPaymentTimeAmount'  -- STFieldFormatColumnName - varchar(100)
)
GO

UPDATE dbo.STFieldFormats 
SET STFieldFormatGroupID = (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN3')
WHERE STFieldFormatColumnName IN ('ARSaleOrderItemDiscountAmount', 'ARSaleOrderItemPrice', 'ARSaleOrderItemTotalAmount',
'ARSaleOrderItemTaxAmount', 'ARSaleOrderItemTotalAmount2', 'ARSaleOrderPriceCostTotalAmount', 'ARSaleOrderSubTotalAmount',
'ARSaleOrderDiscountFix', 'ICProductUnitPrice','ARSaleOrderItemProductUnitPrice','ARSaleOrderItemProductUnitPrice2',
'ARSaleOrderTotalDiscountFix', 'ARSaleOrderTaxAmount', 'ARSaleOrderTotalAmount', 'ARSaleOrderDepositBalance', 'ARSaleOrderBalanceDue')
AND STFieldFormatModuleName = 'SaleOrder'

UPDATE dbo.STFieldFormats 
SET STFieldFormatGroupID = (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN3')
WHERE STFieldFormatColumnName IN ('ARSaleOrderPaymentTimeAmount', 'ARSaleOrderPaymentTimeDepositBalance','ARSaleOrderPaymentTimeBalanceDue','ARSaleOrderPaymentTimeGuaranteeAmount')

-----Phiếu hủy đơn bán hàng-----
UPDATE dbo.STFieldFormats 
SET STFieldFormatGroupID = (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN3')
WHERE STFieldFormatColumnName IN ('ARCancelVoucherSubTotalAmount', 'ARCancelVoucherDiscountFix' , 'ARCancelVoucherTaxAmount', 'ARCancelVoucherTotalAmount',
'ARCancelVoucherItemTotalAmount', 'ARCancelVoucherItemDiscountAmount' , 'ARCancelVoucherItemTaxAmount', 'ARCancelVoucherItemProductUnitPrice')
AND STFieldFormatModuleName = 'CancelVoucher'

-----Hàng bán trả lại-----
UPDATE dbo.STFieldFormats 
SET STFieldFormatGroupID = (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN3')
WHERE STFieldFormatModuleName = 'SaleReturn'
AND STFieldFormatColumnName IN ('ARSaleReturnItemTaxAmount', 'ARSaleReturnItemTotalAmount', 'ARSaleReturnItemDiscountAmount',
'ARSaleReturnSubTotalAmount', 'ARSaleReturnDiscountFix', 'ARSaleReturnTaxAmount', 'ARSaleReturnTotalAmount', 'ARSaleReturnItemProductUnitPrice')

-----Hóa đơn bán hàng-----
INSERT INTO dbo.STFieldFormats
VALUES
(   'Invoice', -- STFieldFormatModuleName - varchar(50)
    'ARClearingDetails', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN3'),  -- STFieldFormatGroupID - int
    'ARClearingDetailAmount'  -- STFieldFormatColumnName - varchar(100)
)
GO
INSERT INTO dbo.STFieldFormats
VALUES
(   'Invoice', -- STFieldFormatModuleName - varchar(50)
    'ARClearingDetails', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN3'),  -- STFieldFormatGroupID - int
    'ARCustomerPaymentClearingTotalAmount'  -- STFieldFormatColumnName - varchar(100)
)
GO
INSERT INTO dbo.STFieldFormats
VALUES
(   'Invoice', -- STFieldFormatModuleName - varchar(50)
    'ARClearingDetails', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN3'),  -- STFieldFormatGroupID - int
    'ARCustomerPaymentRemainAmount'  -- STFieldFormatColumnName - varchar(100)
)
GO
UPDATE dbo.STFieldFormats 
SET STFieldFormatGroupID = (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN3')
WHERE STFieldFormatModuleName = 'Invoice'
AND STFieldFormatColumnName IN ('ARInvoiceItemTaxAmount', 'ARInvoiceItemDiscountAmount', 'ARInvoiceItemNetAmount',
'ARInvoiceItemTotalAmount', 'ARInvoiceSubTotalAmount', 'ARInvoiceDiscountFix', 'ARInvoiceTaxAmount',
'ARInvoiceTotalAmount', 'ARInvoiceDepositBalance', 'ARInvoiceBalanceDue', 'ARInvoiceItemProductUnitPrice','ICProductUnitPrice')

-----Thu tiền khách hàng-----
UPDATE dbo.STFieldFormats 
SET STFieldFormatGroupID = (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN3')
WHERE STFieldFormatColumnName IN ('ARCustomerPaymentTimePaymentTotalAmount', 'ARCustomerPaymentTimePaymentRemainAmount', 'ARCustomerPaymentTimePaymentPaidAmount',
'ARCustomerPaymentTimePaymentAmount', 'ARCustomerPaymentTimePaymentWaitingPayment', 'ARCustomerPaymentTotalAmount')

-----Phân bổ tiền-----
UPDATE dbo.STFieldFormats 
SET STFieldFormatGroupID = (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN3')
WHERE STFieldFormatColumnName IN ('ARClearInvoiceInvoiceAmount','ARClearInvoiceInvoicePaintAmount', 'ARClearInvoiceInvoiceRemainAmount','ARClearInvoiceInvoiceAllocationAmount'
,'ARClearInvoiceInvoiceWaitingPayment', 'ARClearInvoiceDocumentAmount', 'ARClearInvoiceDocumentAllocatedAmount', 'ARClearInvoiceDocumentRemainAmount'
,'ARClearInvoiceDocumentAllocationAmount')
AND STFieldFormatModuleName = 'ClearInvoice'

-----Xuất kho bán hàng-----
INSERT INTO dbo.STFieldFormats
VALUES
(   'ShipmentSaleOrder', -- STFieldFormatModuleName - varchar(50)
    'ICShipmentItems', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN3'),  -- STFieldFormatGroupID - int
    'ICShipmentItemProductUnitPrice'  -- STFieldFormatColumnName - varchar(100)
)
GO

INSERT INTO dbo.STFieldFormats
VALUES
(   'ShipmentSaleOrder', -- STFieldFormatModuleName - varchar(50)
    'ICShipmentItems', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN3'),  -- STFieldFormatGroupID - int
    'ICShipmentItemTotalAmount'  -- STFieldFormatColumnName - varchar(100)
)
GO

-----Nhập hàng đổi trả-----
UPDATE dbo.STFieldFormats 
SET STFieldFormatGroupID = (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN3')
WHERE STFieldFormatColumnName IN ('ICReturnShippingItemProductUnitPrice',
'ICReturnShippingItemTaxAmount','ICReturnShippingItemTotalAmount','ICReturnShippingItemDiscountAmount')
AND STFieldFormatModuleName = 'ReturnShipping'

INSERT INTO dbo.STFieldFormats
VALUES
(   'ReturnShipping', -- STFieldFormatModuleName - varchar(50)
    'ICReceiptItems', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN3'),  -- STFieldFormatGroupID - int
    'ICReceiptItemProductUnitPrice'  -- STFieldFormatColumnName - varchar(100)
)
GO

INSERT INTO dbo.STFieldFormats
VALUES
(   'ReturnShipping', -- STFieldFormatModuleName - varchar(50)
    'ICReceiptItems', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN3'),  -- STFieldFormatGroupID - int
    'ICReceiptItemTotalAmount'  -- STFieldFormatColumnName - varchar(100)
)
GO

INSERT INTO dbo.STFieldFormats
VALUES
(   'ReturnShipping', -- STFieldFormatModuleName - varchar(50)
    'ICReceiptItems', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN3'),  -- STFieldFormatGroupID - int
    'ICReceiptItemDiscountAmount'  -- STFieldFormatColumnName - varchar(100)
)
GO

INSERT INTO dbo.STFieldFormats
VALUES
(   'ReturnShipping', -- STFieldFormatModuleName - varchar(50)
    'ICReceiptItems', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN3'),  -- STFieldFormatGroupID - int
    'ICReceiptItemTaxAmount'  -- STFieldFormatColumnName - varchar(100)
)
GO

UPDATE dbo.GECurrencies 
SET GECurrencyDecimalNumber = 3
WHERE AAStatus = 'Alive' 
AND GECurrencyNo <> 'VND'

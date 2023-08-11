
INSERT INTO dbo.ADConfigValues
VALUES
(   'Alive',  -- AAStatus - varchar(10)
    N'CancelPurchaseProposalReasonTypeErrorQty', -- ADConfigKey - nvarchar(100)
    N'ErrorQty', -- ADConfigKeyValue - nvarchar(100)
    N'Sai số lượng', -- ADConfigText - nvarchar(1000)
    N'CancelPurchaseProposalReasonTypeErrorQty', -- ADConfigKeyDesc - nvarchar(500)
    N'CancelPurchaseProposalReasonType', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
)
GO

INSERT INTO dbo.ADConfigValues
VALUES
(   'Alive',  -- AAStatus - varchar(10)
    N'CancelPurchaseProposalReasonTypeErrorPrice', -- ADConfigKey - nvarchar(100)
    N'ErrorPrice', -- ADConfigKeyValue - nvarchar(100)
    N'Sai giá', -- ADConfigText - nvarchar(1000)
    N'CancelPurchaseProposalReasonTypeErrorPrice', -- ADConfigKeyDesc - nvarchar(500)
    N'CancelPurchaseProposalReasonType', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
)
GO

INSERT INTO dbo.ADConfigValues
VALUES
(   'Alive',  -- AAStatus - varchar(10)
    N'CancelPurchaseProposalReasonTypeCustomerCancel', -- ADConfigKey - nvarchar(100)
    N'CustomerCancel', -- ADConfigKeyValue - nvarchar(100)
    N'Khách hủy PO', -- ADConfigText - nvarchar(1000)
    N'CancelPurchaseProposalReasonTypeCustomerCancel', -- ADConfigKeyDesc - nvarchar(500)
    N'CancelPurchaseProposalReasonType', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
)
GO

INSERT INTO dbo.ADConfigValues
VALUES
(   'Alive',  -- AAStatus - varchar(10)
    N'CancelPurchaseProposalReasonTypeOther', -- ADConfigKey - nvarchar(100)
    N'Other', -- ADConfigKeyValue - nvarchar(100)
    N'Khác', -- ADConfigText - nvarchar(1000)
    N'CancelPurchaseProposalReasonTypeOther', -- ADConfigKeyDesc - nvarchar(500)
    N'CancelPurchaseProposalReasonType', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
)
GO
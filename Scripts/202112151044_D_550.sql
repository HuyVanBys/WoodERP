INSERT INTO dbo.ADConfigValues
VALUES
(   'Alive',  -- AAStatus - varchar(10)
    N'ProposalReasonTypeProposalProductCarcass', -- ADConfigKey - nvarchar(100)
    N'ProposalProductCarcass', -- ADConfigKeyValue - nvarchar(100)
    N'Đặt mẫu', -- ADConfigText - nvarchar(1000)
    N'ProposalReasonTypeProposalProductCarcass', -- ADConfigKeyDesc - nvarchar(500)
    N'ProposalReasonType', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
)
GO

INSERT INTO dbo.ADConfigValues
VALUES
(   'Alive',  -- AAStatus - varchar(10)
    N'ProposalReasonTypeProposalForOrderProduction', -- ADConfigKey - nvarchar(100)
    N'ProposalForOrderProduction', -- ADConfigKeyValue - nvarchar(100)
    N'Mua theo đơn hàng sản xuất', -- ADConfigText - nvarchar(1000)
    N'ProposalReasonTypeProposalForOrderProduction', -- ADConfigKeyDesc - nvarchar(500)
    N'ProposalReasonType', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
)
GO

INSERT INTO dbo.ADConfigValues
VALUES
(   'Alive',  -- AAStatus - varchar(10)
    N'ProposalReasonTypeProposalForProductionRequest', -- ADConfigKey - nvarchar(100)
    N'ProposalForProductionRequest', -- ADConfigKeyValue - nvarchar(100)
    N'Mua theo yêu cầu sản xuất', -- ADConfigText - nvarchar(1000)
    N'ProposalReasonTypeProposalForProductionRequest', -- ADConfigKeyDesc - nvarchar(500)
    N'ProposalReasonType', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
)
GO

INSERT INTO dbo.ADConfigValues
VALUES
(   'Alive',  -- AAStatus - varchar(10)
    N'ProposalReasonTypeProposalForStorage', -- ADConfigKey - nvarchar(100)
    N'ProposalForStorage', -- ADConfigKeyValue - nvarchar(100)
    N'Mua dự phòng', -- ADConfigText - nvarchar(1000)
    N'ProposalReasonTypeProposalForStorage', -- ADConfigKeyDesc - nvarchar(500)
    N'ProposalReasonType', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
)
GO

INSERT INTO dbo.ADConfigValues
VALUES
(   'Alive',  -- AAStatus - varchar(10)
    N'ProposalReasonTypeOther', -- ADConfigKey - nvarchar(100)
    N'Other', -- ADConfigKeyValue - nvarchar(100)
    N'Khác', -- ADConfigText - nvarchar(1000)
    N'ProposalReasonTypeOther', -- ADConfigKeyDesc - nvarchar(500)
    N'ProposalReasonType', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
)
GO
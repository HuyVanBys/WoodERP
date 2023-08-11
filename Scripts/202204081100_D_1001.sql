----------Đã chạy DB ERPWood_Test-----
----------Đã chạy DB ERPWood_Test-----
----------Đã chạy DB ERPWood_Test-----
INSERT INTO dbo.STToolbars
VALUES
(   'Alive',   -- AAStatus - varchar(50)
    (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'PaymentProposal'),    -- STModuleID - int
    1,    -- STUserGroupID - int
    N'fld_barbtnPrintProposal',  -- STToolbarName - nvarchar(50)
    N'Phiếu đề nghị thanh toán (tổng tiền)',  -- STToolbarDesc - nvarchar(255)
    'PrintProposal',   -- STToolbarTag - varchar(50)
    'Default',   -- STToolbarStyle - varchar(50)
    N'Phiếu đề nghị thanh toán',  -- STToolbarCaption - nvarchar(50)
    N'Utility',  -- STToolbarGroup - nvarchar(50)
    1,    -- STToolbarOrder - int
    1, -- STToolbarVisible - bit
    N'',  -- STToolbarPrivilege - nvarchar(50)
    (SELECT STToolbarID FROM dbo.STToolbars 
						WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'PaymentProposal')
						AND AAStatus = 'Alive'
						AND STToolbarTag = 'Print'),    -- STToolbarParentID - int
    N''   -- STToolbarImage - nvarchar(50)
)
GO

UPDATE dbo.STToolbarFunctions 
SET STToolbarID = (SELECT STToolbarID FROM dbo.STToolbars 
						WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'PaymentProposal')
						AND AAStatus = 'Alive'
						AND STToolbarTag = 'PrintProposal')
WHERE STToolbarID = (SELECT STToolbarID FROM dbo.STToolbars 
						WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'PaymentProposal')
						AND AAStatus = 'Alive'
						AND STToolbarTag = 'Print')

UPDATE dbo.ADTemplateToolbars
SET FK_STToolbarID = (SELECT STToolbarID FROM dbo.STToolbars 
						WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'PaymentProposal')
						AND AAStatus = 'Alive'
						AND STToolbarTag = 'PrintProposal')
WHERE FK_STToolbarID = (SELECT STToolbarID FROM dbo.STToolbars 
						WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'PaymentProposal')
						AND AAStatus = 'Alive'
						AND STToolbarTag = 'Print')

INSERT INTO dbo.STToolbars
VALUES
(   'Alive',   -- AAStatus - varchar(50)
    (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'PaymentProposal'),    -- STModuleID - int
    1,    -- STUserGroupID - int
    N'fld_barbtnPrintProposalDetail',  -- STToolbarName - nvarchar(50)
    N'Giấy đề nghị thanh toán (chi tiết)',  -- STToolbarDesc - nvarchar(255)
    'PrintProposalDetail',   -- STToolbarTag - varchar(50)
    'Default',   -- STToolbarStyle - varchar(50)
    N'Giấy đề nghị thanh toán',  -- STToolbarCaption - nvarchar(50)
    N'Utility',  -- STToolbarGroup - nvarchar(50)
    2,    -- STToolbarOrder - int
    1, -- STToolbarVisible - bit
    N'',  -- STToolbarPrivilege - nvarchar(50)
    (SELECT STToolbarID FROM dbo.STToolbars 
						WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'PaymentProposal')
						AND AAStatus = 'Alive'
						AND STToolbarTag = 'Print'),    -- STToolbarParentID - int
    N''   -- STToolbarImage - nvarchar(50)
)
GO

INSERT INTO dbo.ADTemplates
VALUES
(   N'RP_PaymentProposalDetail', -- ADTemplateNo - nvarchar(50)
    N'Giấy đề nghị thanh toán', -- ADTemplateName - nvarchar(100)
    N'Giấy đề nghị thanh toán (chi tiết)', -- ADTemplateDesc - nvarchar(512)
    N'RP_PaymentProposalDetail', -- ADTemplateStoreProc - nvarchar(256)
    'Alive',  -- AAStatus - varchar(50)
    N'', -- ADTemplateDataSource - nvarchar(100)
    1 -- ADTemplateAutoLoad - bit
)
GO

INSERT INTO dbo.ADTemplateToolbars
VALUES
(   (SELECT ADTemplateID FROM dbo.ADTemplates WHERE AAStatus = 'Alive' AND ADTemplateNo = 'RP_PaymentProposalDetail'), -- FK_ADTemplateID - int
    (SELECT STToolbarID FROM dbo.STToolbars 
						WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'PaymentProposal')
						AND AAStatus = 'Alive'
						AND STToolbarTag = 'PrintProposalDetail')  -- FK_STToolbarID - int
)
GO

INSERT INTO dbo.STToolbarFunctions
VALUES
(   '', -- STToolbarFunctionIDString - varchar(50)
    (SELECT STToolbarID FROM dbo.STToolbars 
						WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'PaymentProposal')
						AND AAStatus = 'Alive'
						AND STToolbarTag = 'PrintProposalDetail'),  -- STToolbarID - int
    'ActionPrintTemplate', -- STToolbarFunctionName - varchar(250)
    'void ActionPrintTemplate()', -- STToolbarFunctionFullName - varchar(500)
    'BOSERP.Modules.PaymentProposal.PaymentProposalModule', -- STToolbarFunctionClass - varchar(250)
    1   -- STToolbarFunctionSortOrder - int
)
GO
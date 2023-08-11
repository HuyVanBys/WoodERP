--SELECT * FROM dbo.ADConfigValues WHERE ADConfigKeyGroup = 'DocumentAllocationCriteria'

UPDATE ADConfigValues SET IsActive = 0 WHERE ADConfigKeyGroup = 'DocumentAllocationCriteria' AND  ADConfigKey  = 'DocumentAllocationCriteriaQty'
--SELECT * FROM dbo.AAColumnAlias WHERE AATableName = 'ACDocuments'
INSERT INTO dbo.AAColumnAlias
select   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ACDocumentStatus',   -- AAColumnAliasName - varchar(255)
    N'Tình trạng',  -- AAColumnAliasCaption - nvarchar(255)
    'ACDocuments',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    0, -- AAAllowDummy - bit
    1  -- AAColumnAliasIsSaveHistory - bit
    

INSERT INTO dbo.ADConfigValues
SELECT 
   'Alive',  -- AAStatus - varchar(10)
    N'DocumentStatusNew', -- ADConfigKey - nvarchar(100)
    N'New', -- ADConfigKeyValue - nvarchar(100)
    N'Tạo mới', -- ADConfigText - nvarchar(1000)
    N'DocumentStatusNew', -- ADConfigKeyDesc - nvarchar(500)
    N'DocumentStatus', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
    
INSERT INTO dbo.ADConfigValues
SELECT 
   'Alive',  -- AAStatus - varchar(10)
    N'DocumentStatusComplete', -- ADConfigKey - nvarchar(100)
    N'Complete', -- ADConfigKeyValue - nvarchar(100)
    N'Hoàn tất', -- ADConfigText - nvarchar(1000)
    N'DocumentStatusComplete', -- ADConfigKeyDesc - nvarchar(500)
    N'DocumentStatus', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit

	--SELECT * FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'FeePayment')
	--SELECT * FROM dbo.STToolbarFunctions WHERE STToolbarID = 3337
	INSERT INTO dbo.STToolbars
	SELECT   'Alive',   -- AAStatus - varchar(50)
    (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'FeePayment'),    -- STModuleID - int
    1,    -- STUserGroupID - int
    N'fld_barbtnComplete',  -- STToolbarName - nvarchar(50)
    N'Hoàn tất',  -- STToolbarDesc - nvarchar(255)
    'Complete',   -- STToolbarTag - varchar(50)
    'Default',   -- STToolbarStyle - varchar(50)
    N'Hoàn tất (F9)',  -- STToolbarCaption - nvarchar(50)
    N'Action',  -- STToolbarGroup - nvarchar(50)
    8,    -- STToolbarOrder - int
    1, -- STToolbarVisible - bit
    N'',  -- STToolbarPrivilege - nvarchar(50)
    0,    -- STToolbarParentID - int
    N''   -- STToolbarImage - nvarchar(50)

	INSERT INTO dbo.STToolbars
	SELECT   'Alive',   -- AAStatus - varchar(50)
    (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'FeePayment'),    -- STModuleID - int
    1,    -- STUserGroupID - int
    N'fld_barbtnAllotment',  -- STToolbarName - nvarchar(50)
    N'Chạy phân bổ',  -- STToolbarDesc - nvarchar(255)
    'Allotment',   -- STToolbarTag - varchar(50)
    'Default',   -- STToolbarStyle - varchar(50)
    N'Chạy phân bổ',  -- STToolbarCaption - nvarchar(50)
    N'Action',  -- STToolbarGroup - nvarchar(50)
    9,    -- STToolbarOrder - int
    1, -- STToolbarVisible - bit
    N'',  -- STToolbarPrivilege - nvarchar(50)
    0,    -- STToolbarParentID - int
    N''   -- STToolbarImage - nvarchar(50)

INSERT INTO dbo.STToolbarFunctions
	select  '', -- STToolbarFunctionIDString - varchar(50)
	    (SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'FeePayment') AND STToolbarName = 'fld_barbtnAllotment'),  -- STToolbarID - int
	    'ActionAllotment', -- STToolbarFunctionName - varchar(250)
	    'void ActionAllotment()', -- STToolbarFunctionFullName - varchar(500)
	    'BOSERP.Modules.FeePayment.FeePaymentModule', -- STToolbarFunctionClass - varchar(250)
	    1   -- STToolbarFunctionSortOrder - int

--update dbo.AAColumnAlias SET AADisplayedMember  ='ICFeeConfigName,ICFeeType' WHERE AATableName = 'APFeePaymentFeeConfigs' AND AAColumnAliasName = 'FK_ICFeeConfigIwrD'

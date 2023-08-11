update dbo.STFieldColumns SET STFieldColumnCaption = N'Điều khoản thanh toán' WHERE STFieldID = (SELECT STFieldID FROM dbo.STFields WHERE STFieldName = 'fld_lkeFK_GEPaymentTermID' AND STScreenID = (SELECT STScreenID FROM dbo.STScreens WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'Saleorder') AND STScreenNumber = 'DMSO100'))
GO
update dbo.AAColumnAlias SET AAColumnAliasCaption = N'SL còn lại' WHERE AAColumnAliasName = N'ARDeliveryPlanItemRemainedQty'
GO
update dbo.ADReports SET AAStatus = 'Alive' where ADReportNo = 'RP300'
GO
update dbo.ADReports SET AAStatus = 'Alive' where ADReportNo = 'RP124'
GO
INSERT INTO dbo.ADReportPermissions
VALUES
(   'Alive', -- AAStatus - varchar(50)
    (SELECT ADUserGroupID FROM dbo.ADUserGroups WHERE ADUserGroupID = (SELECT ADUserGroupID FROM dbo.ADUsers WHERE ADUserName = 'Admin') AND AAStatus = 'Alive'),  -- FK_ADUserGroupID - int
    (SELECT ADReportID FROM dbo.ADReports where ADReportNo = 'RP300'),  -- FK_ADReportID - int
    0   -- ADReportPermissionType - tinyint
    )
GO
INSERT INTO dbo.ADReportPermissions
VALUES
(   'Alive', -- AAStatus - varchar(50)
    (SELECT ADUserGroupID FROM dbo.ADUserGroups WHERE ADUserGroupID = (SELECT ADUserGroupID FROM dbo.ADUsers WHERE ADUserName = 'Admin') AND AAStatus = 'Alive'),  -- FK_ADUserGroupID - int
    (SELECT ADReportID FROM dbo.ADReports where ADReportNo = 'RP124'),  -- FK_ADReportID - int
    0   -- ADReportPermissionType - tinyint
    )
GO
------


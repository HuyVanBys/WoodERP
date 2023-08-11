INSERT INTO dbo.ADReports
VALUES
(   
    GETDATE(), -- AACreatedDate - datetime
    N'',       -- AACreatedUser - nvarchar(50)
    GETDATE(), -- AAUpdatedDate - datetime
    N'',       -- AAUpdatedUser - nvarchar(50)
    'Alive     ',        -- AAStatus - varchar(50)
    1,         -- FK_GELanguageID - int
    N'RP245',       -- ADReportNo - nvarchar(50)
    N'Tổng hợp xuất theo LSX',       -- ADReportName - nvarchar(50)
    N'Tổng hợp xuất theo LSX',       -- ADReportDesc - nvarchar(512)
    'Inventory',        -- ADReportType - varchar(50)
    N'Kho',       -- ADReportSection - nvarchar(50)
    N'PrintViewer',       -- ADReportViewType - nvarchar(50)
    (SELECT MAX(ADReportSortOrder)+1 FROM ADReports WHERE ADReportType LIKE N'%Inventory%' AND AAStatus = 'alive'),         -- ADReportSortOrder - int
    0          -- ADReportCopies - tinyint
    )
GO
INSERT INTO dbo.ADReportPermissions
VALUES
(   'Alive', -- AAStatus - varchar(50)
    (SELECT ADUserGroupID FROM dbo.ADUserGroups WHERE ADUserGroupName = 'bys' AND AAStatus = 'alive'),  -- FK_ADUserGroupID - int
    (SELECT ADReportID FROM dbo.ADReports WHERE ADReportNo LIKE N'%RP245%' AND AAStatus = 'alive'),  -- FK_ADReportID - int
    1   -- ADReportPermissionType - tinyint
    )
	GO

INSERT INTO dbo.STScreens
VALUES
(   'DMPP101',   -- STScreenNumber - varchar(100)
    N'Tài liệu đính kèm',  -- STScreenText - nvarchar(255)
    'guiPaymentProposalTemplate',   -- STScreenName - varchar(50)
    (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'PaymentProposal'),    -- STModuleID - int
    1,    -- STUserGroupID - int
    -1838594,    -- STScreenBackColor - int
    -16777216,    -- STScreenForeColor - int
    N'Tahoma',  -- STScreenFontName - nvarchar(500)
    8.25,  -- STScreenFontSize - float
    'Regular',   -- STScreenFontStyle - varchar(100)
    'DM',   -- STScreenTag - varchar(50)
    0,    -- STScreenSizeWidth - int
    0,    -- STScreenSizeHeight - int
    0,    -- STScreenLocationX - int
    0,    -- STScreenLocationY - int
    1, -- STScreenShowModal - bit
    1, -- STScreenTopMost - bit
    N'',  -- STScreenMatchCode01 - nvarchar(50)
    0, -- STScreenShowInfoPanel - bit
    0,    -- STScreenSortOrder - int
    N'',  -- STScreenPrivilege - nvarchar(50)
    1  -- STScreenVisible - bit
)
GO


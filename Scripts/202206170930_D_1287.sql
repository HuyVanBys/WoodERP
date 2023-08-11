INSERT INTO dbo.STScreens
VALUES
(   'DMHM122',   -- STScreenNumber - varchar(100)
    N'Danh s�ch xu?t kho b�n h�ng chua l�m h�a don',  -- STScreenText - nvarchar(255)
    'guiHome22',   -- STScreenName - varchar(50)
    (SELECT STModuleID FROM  STmodules WHERE STModuleName = 'Home'),    -- STModuleID - int
    1,    -- STUserGroupID - int
    0,    -- STScreenBackColor - int
    0,    -- STScreenForeColor - int
    N'Tahoma',  -- STScreenFontName - nvarchar(500)
    8.25,  -- STScreenFontSize - float
    'Regular',   -- STScreenFontStyle - varchar(100)
    'DM',   -- STScreenTag - varchar(50)
    0,    -- STScreenSizeWidth - int
    0,    -- STScreenSizeHeight - int
    0,    -- STScreenLocationX - int
    0,    -- STScreenLocationY - int
    0, -- STScreenShowModal - bit
    1, -- STScreenTopMost - bit
    N'',  -- STScreenMatchCode01 - nvarchar(50)
    0, -- STScreenShowInfoPanel - bit
    (SELECT MAX(STScreenSortOrder) + 1 FROM dbo.STScreens WHERE STModuleID = (SELECT STModuleID FROM  STmodules WHERE STModuleName = 'Home')),    -- STScreenSortOrder - int
    N'',  -- STScreenPrivilege - nvarchar(50)
    1  -- STScreenVisible - bit
    )
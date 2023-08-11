INSERT INTO dbo.ACEntryTypes
VALUES
(   'Alive',        -- AAStatus - varchar(50)
    GETDATE(), -- AACreatedDate - datetime
    N'Admin',       -- AACreatedUser - nvarchar(50)
    GETDATE(), -- AAUpdatedDate - datetime
    N'Admin',       -- AAUpdatedUser - nvarchar(50)
    N'ThueXNK',       -- ACEntryTypeName - nvarchar(100)
    N'Thuế Xuất/Nhập khẩu'        -- ACEntryTypeDesc - nvarchar(512)
    )
INSERT INTO dbo.ACEntryTypes
VALUES
(   'Alive',        -- AAStatus - varchar(50)
    GETDATE(), -- AACreatedDate - datetime
    N'Admin',       -- AACreatedUser - nvarchar(50)
    GETDATE(), -- AAUpdatedDate - datetime
    N'Admin',       -- AAUpdatedUser - nvarchar(50)
    N'ThueTieuThu',       -- ACEntryTypeName - nvarchar(100)
    N'Thuế tiêu thụ đặc biệt'        -- ACEntryTypeDesc - nvarchar(512)
    )
INSERT INTO dbo.ACEntryTypes
VALUES
(   'Alive',        -- AAStatus - varchar(50)
    GETDATE(), -- AACreatedDate - datetime
    N'Admin',       -- AACreatedUser - nvarchar(50)
    GETDATE(), -- AAUpdatedDate - datetime
    N'Admin',       -- AAUpdatedUser - nvarchar(50)
    N'ThueBaoVeMoiTruong',       -- ACEntryTypeName - nvarchar(100)
    N'Thuế bảo vệ môi trường'        -- ACEntryTypeDesc - nvarchar(512)
    )

-------------
INSERT INTO dbo.ACDocTypeEntrys
VALUES
(   'Alive', -- AAStatus - varchar(50)
    (SELECT ACDocumentTypeID FROM  dbo.ACDocumentTypes WHERE ACDocumentTypeName = 'NhapKhoMuaHangHoaDon'),  -- FK_ACDocumentTypeID - int
    (SELECT ACEntryTypeID FROM  dbo.ACEntryTypes WHERE ACEntryTypeName = 'ThueXNK'),  -- FK_ACEntryTypeID - int
    4   -- ACDocTypeEntrySortOrder - int
    )
INSERT INTO dbo.ACDocTypeEntrys
VALUES
(   'Alive', -- AAStatus - varchar(50)
    (SELECT ACDocumentTypeID FROM  dbo.ACDocumentTypes WHERE ACDocumentTypeName = 'NhapKhoMuaHangHoaDon'),  -- FK_ACDocumentTypeID - int
    (SELECT ACEntryTypeID FROM  dbo.ACEntryTypes WHERE ACEntryTypeName = 'ThueTieuThu'),  -- FK_ACEntryTypeID - int
    5   -- ACDocTypeEntrySortOrder - int
    )
INSERT INTO dbo.ACDocTypeEntrys
VALUES
(   'Alive', -- AAStatus - varchar(50)
    (SELECT ACDocumentTypeID FROM  dbo.ACDocumentTypes WHERE ACDocumentTypeName = 'NhapKhoMuaHangHoaDon'),  -- FK_ACDocumentTypeID - int
    (SELECT ACEntryTypeID FROM  dbo.ACEntryTypes WHERE ACEntryTypeName = 'ThueBaoVeMoiTruong'),  -- FK_ACEntryTypeID - int
    6   -- ACDocTypeEntrySortOrder - int
    )
--------------------------------------
INSERT INTO dbo.ACDocTypeEntryAccounts
VALUES
(   'Alive',  -- AAStatus - varchar(50)
    (SELECT ACDocTypeEntryID FROM  dbo.ACDocTypeEntrys WHERE FK_ACDocumentTypeID = (SELECT ACDocumentTypeID FROM  dbo.ACDocumentTypes WHERE ACDocumentTypeName = 'NhapKhoMuaHangHoaDon') AND FK_ACEntryTypeID = (SELECT ACEntryTypeID FROM  dbo.ACEntryTypes WHERE ACEntryTypeName = 'ThueXNK')),   -- FK_ACDocTypeEntryID - int
    (SELECT ACAccountID FROM  dbo.ACAccounts WHERE ACAccountNo = '151'),   -- FK_ACAccountID - int
    'Credit',  -- ACPostingType - varchar(50)
    1 -- IsDefault - bit
    )
INSERT INTO dbo.ACDocTypeEntryAccounts
VALUES
(   'Alive',  -- AAStatus - varchar(50)
    (SELECT ACDocTypeEntryID FROM  dbo.ACDocTypeEntrys WHERE FK_ACDocumentTypeID = (SELECT ACDocumentTypeID FROM  dbo.ACDocumentTypes WHERE ACDocumentTypeName = 'NhapKhoMuaHangHoaDon') AND FK_ACEntryTypeID = (SELECT ACEntryTypeID FROM  dbo.ACEntryTypes WHERE ACEntryTypeName = 'ThueXNK')),   -- FK_ACDocTypeEntryID - int
    0,   -- FK_ACAccountID - int
    'Debit',  -- ACPostingType - varchar(50)
    0 -- IsDefault - bit
    )
INSERT INTO dbo.ACDocTypeEntryAccounts
VALUES
(   'Alive',  -- AAStatus - varchar(50)
    (SELECT ACDocTypeEntryID FROM  dbo.ACDocTypeEntrys WHERE FK_ACDocumentTypeID = (SELECT ACDocumentTypeID FROM  dbo.ACDocumentTypes WHERE ACDocumentTypeName = 'NhapKhoMuaHangHoaDon') AND FK_ACEntryTypeID = (SELECT ACEntryTypeID FROM  dbo.ACEntryTypes WHERE ACEntryTypeName = 'ThueTieuThu')),   -- FK_ACDocTypeEntryID - int
    (SELECT ACAccountID FROM  dbo.ACAccounts WHERE ACAccountNo = '151'),   -- FK_ACAccountID - int
    'Credit',  -- ACPostingType - varchar(50)
    1 -- IsDefault - bit
    )
INSERT INTO dbo.ACDocTypeEntryAccounts
VALUES
(   'Alive',  -- AAStatus - varchar(50)
    (SELECT ACDocTypeEntryID FROM  dbo.ACDocTypeEntrys WHERE FK_ACDocumentTypeID = (SELECT ACDocumentTypeID FROM  dbo.ACDocumentTypes WHERE ACDocumentTypeName = 'NhapKhoMuaHangHoaDon') AND FK_ACEntryTypeID = (SELECT ACEntryTypeID FROM  dbo.ACEntryTypes WHERE ACEntryTypeName = 'ThueTieuThu')),   -- FK_ACDocTypeEntryID - int
    0,   -- FK_ACAccountID - int
    'Debit',  -- ACPostingType - varchar(50)
    0 -- IsDefault - bit
    )
INSERT INTO dbo.ACDocTypeEntryAccounts
VALUES
(   'Alive',  -- AAStatus - varchar(50)
    (SELECT ACDocTypeEntryID FROM  dbo.ACDocTypeEntrys WHERE FK_ACDocumentTypeID = (SELECT ACDocumentTypeID FROM  dbo.ACDocumentTypes WHERE ACDocumentTypeName = 'NhapKhoMuaHangHoaDon') AND FK_ACEntryTypeID = (SELECT ACEntryTypeID FROM  dbo.ACEntryTypes WHERE ACEntryTypeName = 'ThueBaoVeMoiTruong')),   -- FK_ACDocTypeEntryID - int
    (SELECT ACAccountID FROM  dbo.ACAccounts WHERE ACAccountNo = '151'),   -- FK_ACAccountID - int
    'Credit',  -- ACPostingType - varchar(50)
    1 -- IsDefault - bit
    )
INSERT INTO dbo.ACDocTypeEntryAccounts
VALUES
(   'Alive',  -- AAStatus - varchar(50)
    (SELECT ACDocTypeEntryID FROM  dbo.ACDocTypeEntrys WHERE FK_ACDocumentTypeID = (SELECT ACDocumentTypeID FROM  dbo.ACDocumentTypes WHERE ACDocumentTypeName = 'NhapKhoMuaHangHoaDon') AND FK_ACEntryTypeID = (SELECT ACEntryTypeID FROM  dbo.ACEntryTypes WHERE ACEntryTypeName = 'ThueBaoVeMoiTruong')),   -- FK_ACDocTypeEntryID - int
    0,   -- FK_ACAccountID - int
    'Debit',  -- ACPostingType - varchar(50)
    0 -- IsDefault - bit
    )

----------------------------------------------
INSERT INTO dbo.ACDocTypeEntryFunctionMappings
VALUES
(   N'Alive', -- AAStatus - nvarchar(50)
    (SELECT STModuleID FROM  STModules WHERE STModuleName = 'PurchaseReceipt'),   -- FK_STModuleID - int
    (SELECT STToolbarID FROM  dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM  STModules WHERE STModuleName = 'PurchaseReceipt') AND STToolbarTag = 'FromInvoice'),   -- FK_STToolbarID - int
    (SELECT ACDocumentTypeID FROM  dbo.ACDocumentTypes WHERE ACDocumentTypeName = 'NhapKhoMuaHangHoaDon'),   -- FK_ACDocumentTypeID - int
    (SELECT ACEntryTypeID FROM  dbo.ACEntryTypes WHERE ACEntryTypeName = 'ThueXNK')    -- FK_ACEntryTypeID - int
    )
INSERT INTO dbo.ACDocTypeEntryFunctionMappings
VALUES
(   N'Alive', -- AAStatus - nvarchar(50)
    (SELECT STModuleID FROM  STModules WHERE STModuleName = 'PurchaseReceipt'),   -- FK_STModuleID - int
    (SELECT STToolbarID FROM  dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM  STModules WHERE STModuleName = 'PurchaseReceipt') AND STToolbarTag = 'FromInvoice'),   -- FK_STToolbarID - int
    (SELECT ACDocumentTypeID FROM  dbo.ACDocumentTypes WHERE ACDocumentTypeName = 'NhapKhoMuaHangHoaDon'),   -- FK_ACDocumentTypeID - int
    (SELECT ACEntryTypeID FROM  dbo.ACEntryTypes WHERE ACEntryTypeName = 'ThueTieuThu')    -- FK_ACEntryTypeID - int
    )
INSERT INTO dbo.ACDocTypeEntryFunctionMappings
VALUES
(   N'Alive', -- AAStatus - nvarchar(50)
    (SELECT STModuleID FROM  STModules WHERE STModuleName = 'PurchaseReceipt'),   -- FK_STModuleID - int
    (SELECT STToolbarID FROM  dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM  STModules WHERE STModuleName = 'PurchaseReceipt') AND STToolbarTag = 'FromInvoice'),   -- FK_STToolbarID - int
    (SELECT ACDocumentTypeID FROM  dbo.ACDocumentTypes WHERE ACDocumentTypeName = 'NhapKhoMuaHangHoaDon'),   -- FK_ACDocumentTypeID - int
    (SELECT ACEntryTypeID FROM  dbo.ACEntryTypes WHERE ACEntryTypeName = 'ThueBaoVeMoiTruong')    -- FK_ACEntryTypeID - int
    )
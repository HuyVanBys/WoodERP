INSERT INTO dbo.ACDocTypeEntrys
VALUES
(   'Alive', -- AAStatus - varchar(50)
    (SELECT ACDocumentTypeID FROM  dbo.ACDocumentTypes WHERE ACDocumentTypeName = 'NhapKhoMuaHang'),  -- FK_ACDocumentTypeID - int
    (SELECT ACEntryTypeID FROM  dbo.ACEntryTypes WHERE ACEntryTypeName = 'ChiPhiMuaHang'),  -- FK_ACEntryTypeID - int
    3   -- ACDocTypeEntrySortOrder - int
    )

INSERT INTO dbo.ACDocTypeEntryAccounts
VALUES
(   'Alive',  -- AAStatus - varchar(50)
    (SELECT ACDocTypeEntryID FROM  dbo.ACDocTypeEntrys WHERE FK_ACDocumentTypeID = (SELECT ACDocumentTypeID FROM  dbo.ACDocumentTypes WHERE ACDocumentTypeName = 'NhapKhoMuaHang') AND FK_ACEntryTypeID = (SELECT ACEntryTypeID FROM  dbo.ACEntryTypes WHERE ACEntryTypeName = 'ChiPhiMuaHang')),   -- FK_ACDocTypeEntryID - int
    (SELECT ACAccountID FROM  dbo.ACAccounts WHERE ACAccountNo = '151'),   -- FK_ACAccountID - int
    'Credit',  -- ACPostingType - varchar(50)
    1 -- IsDefault - bit
    )
INSERT INTO dbo.ACDocTypeEntryAccounts
VALUES
(   'Alive',  -- AAStatus - varchar(50)
    (SELECT ACDocTypeEntryID FROM  dbo.ACDocTypeEntrys WHERE FK_ACDocumentTypeID = (SELECT ACDocumentTypeID FROM  dbo.ACDocumentTypes WHERE ACDocumentTypeName = 'NhapKhoMuaHang') AND FK_ACEntryTypeID = (SELECT ACEntryTypeID FROM  dbo.ACEntryTypes WHERE ACEntryTypeName = 'ChiPhiMuaHang')),   -- FK_ACDocTypeEntryID - int
    0,   -- FK_ACAccountID - int
    'Debit',  -- ACPostingType - varchar(50)
    0 -- IsDefault - bit
    )
INSERT INTO dbo.ACDocTypeEntryFunctionMappings
VALUES
(   N'Alive', -- AAStatus - nvarchar(50)
    (SELECT STModuleID FROM  STModules WHERE STModuleName = 'PurchaseReceipt'),   -- FK_STModuleID - int
    (SELECT STToolbarID FROM  dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM  STModules WHERE STModuleName = 'PurchaseReceipt') AND STToolbarTag = 'FromPurchaseOrder'),   -- FK_STToolbarID - int
    (SELECT ACDocumentTypeID FROM  dbo.ACDocumentTypes WHERE ACDocumentTypeName = 'NhapKhoMuaHang'),   -- FK_ACDocumentTypeID - int
    (SELECT ACEntryTypeID FROM  dbo.ACEntryTypes WHERE ACEntryTypeName = 'ChiPhiMuaHang')    -- FK_ACEntryTypeID - int
    )

----------
INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ACDocumentAllotment',   -- AAColumnAliasName - varchar(255)
    N'Tình trạng phân bổ',  -- AAColumnAliasCaption - nvarchar(255)
    'ACDocuments',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    1  -- AAColumnAliasIsSaveHistory - bit
    )
INSERT INTO dbo.ACDocTypeEntryFunctionMappings
VALUES
(   N'Alive', -- AAStatus - nvarchar(50)
    (SELECT STModuleID FROM  STmodules WHERE STModuleName = 'Transfer'),   -- FK_STModuleID - int
    (SELECT STToolbarID FROM  dbo.STToolbars WHERE STToolbarTag = 'TransferReceipt' AND AAStatus = 'Alive' AND STModuleID = (SELECT STModuleID FROM  STmodules WHERE STModuleName = 'Transfer')),   -- FK_STToolbarID - int
    (SELECT ACDocumentTypeID FROM  dbo.ACDocumentTypes WHERE ACDocumentTypeName = 'ChuyenKho' AND AAStatus = 'Alive'),   -- FK_ACDocumentTypeID - int
    (SELECT ACEntryTypeID FROM  dbo.ACEntryTypes WHERE ACEntryTypeName = 'NhapChuyenKho' AND	 AAStatus = 'Alive')    -- FK_ACEntryTypeID - int
    )

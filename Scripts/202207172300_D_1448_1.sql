INSERT INTO dbo.STModules
VALUES
(   'Alive', -- AAStatus - varchar(50)
    'ElectronicInvoiceBKAV', -- STModuleName - varchar(50)
    'EIBKAV', -- STModuleCode - varchar(20)
    0,  -- STModuleMain - int
    1,  -- IsVisible - int
    N'OnlyERP' -- STModuleViewType - nvarchar(50)
)
GO

INSERT INTO dbo.STModuleDescriptions
VALUES
(   (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'ElectronicInvoiceBKAV'),  -- STModuleID - int
    1,  -- STLanguageID - int
    N'Hóa đơn điện tử BKAV' -- STModuleDescriptionDescription - nvarchar(255)
)
GO

INSERT INTO dbo.STScreens
VALUES
(   'SMEIBKAV100',   -- STScreenNumber - varchar(100)
    N'Tìm kiếm',  -- STScreenText - nvarchar(255)
    'guiElectronicInvoiceBKAVSearch',   -- STScreenName - varchar(50)
    (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'ElectronicInvoiceBKAV'),    -- STModuleID - int
    1,    -- STUserGroupID - int
    0,    -- STScreenBackColor - int
    0,    -- STScreenForeColor - int
    N'Tahoma',  -- STScreenFontName - nvarchar(500)
    8.25,  -- STScreenFontSize - float
    'Regular',   -- STScreenFontStyle - varchar(100)
    'SM',   -- STScreenTag - varchar(50)
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

INSERT INTO dbo.STScreens
VALUES
(   'DMEIBKAV100',   -- STScreenNumber - varchar(100)
    N'Thông tin',  -- STScreenText - nvarchar(255)
    'guiElectronicInvoiceBKAV',   -- STScreenName - varchar(50)
    (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'ElectronicInvoiceBKAV'),    -- STModuleID - int
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
    1, -- STScreenShowModal - bit
    1, -- STScreenTopMost - bit
    N'',  -- STScreenMatchCode01 - nvarchar(50)
    0, -- STScreenShowInfoPanel - bit
    1,    -- STScreenSortOrder - int
    N'',  -- STScreenPrivilege - nvarchar(50)
    1  -- STScreenVisible - bit
)
GO

INSERT INTO dbo.STScreens
VALUES
(   'DMEIBKAV101',   -- STScreenNumber - varchar(100)
    N'Tài liệu đính kèm',  -- STScreenText - nvarchar(255)
    'guiElectronicInvoiceBKAV1',   -- STScreenName - varchar(50)
    (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'ElectronicInvoiceBKAV'),    -- STModuleID - int
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
    1, -- STScreenShowModal - bit
    1, -- STScreenTopMost - bit
    N'',  -- STScreenMatchCode01 - nvarchar(50)
    0, -- STScreenShowInfoPanel - bit
    2,    -- STScreenSortOrder - int
    N'',  -- STScreenPrivilege - nvarchar(50)
    1  -- STScreenVisible - bit
)
GO

INSERT INTO STToolbars       VALUES(N'Alive',(SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'ElectronicInvoiceBKAV'), 1,N'fld_barbtnNew',N'Tạo mới (F4)',N'New',N'Default',N'Tạo mới (F4)',N'Action',0,1,N'',ISNULL((SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'ElectronicInvoiceBKAV') AND STToolbarTag = ''),0),N'')
INSERT INTO STToolbars       VALUES(N'Alive',(SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'ElectronicInvoiceBKAV'), 1,N'fld_barbtnEdit',N'Sửa (F5)',N'Edit',N'Default',N'Sửa (F5)',N'Action',1,1,N'',ISNULL((SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'ElectronicInvoiceBKAV') AND STToolbarTag = ''),0),N'')
INSERT INTO STToolbars       VALUES(N'Alive',(SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'ElectronicInvoiceBKAV'), 1,N'fld_barbtnCancel',N'Hủy (F7)',N'Cancel',N'Default',N'Hủy (F7)',N'Action',2,1,N'',ISNULL((SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'ElectronicInvoiceBKAV') AND STToolbarTag = ''),0),N'')
INSERT INTO STToolbars       VALUES(N'Alive',(SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'ElectronicInvoiceBKAV'), 1,N'fld_barbtnSave',N'Lưu (F8)',N'Save',N'Default',N'Lưu (F8)',N'Action',3,1,N'',ISNULL((SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'ElectronicInvoiceBKAV') AND STToolbarTag = ''),0),N'')
INSERT INTO STToolbars       VALUES(N'Alive',(SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'ElectronicInvoiceBKAV'), 1,N'fld_barbtnManual',N'Thông thường',N'Manual',N'Default',N'Thông thường',N'Action',1,1,N'',ISNULL((SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'ElectronicInvoiceBKAV') AND STToolbarTag = 'New'),0),N'')
INSERT INTO STToolbars       VALUES(N'Alive',(SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'ElectronicInvoiceBKAV'), 1,N'fld_barbtnDuplicate',N'Tạo bản thay thế/ điều chỉnh',N'Duplicate',N'Default',N'Tạo bản thay thế/ điều chỉnh',N'Action',2,1,N'Duplicate',ISNULL((SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'ElectronicInvoiceBKAV') AND STToolbarTag = 'New'),0),N'')
INSERT INTO STToolbars       VALUES(N'Alive',(SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'ElectronicInvoiceBKAV'), 1,N'fld_barbtnImportInv_Bkav',N'Đẩy dữ liệu hóa đơn',N'ImportInv_Bkav',N'Default',N'Đẩy dữ liệu hóa đơn',N'Action',4,1,N'',ISNULL((SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'ElectronicInvoiceBKAV') AND STToolbarTag = ''),0),N'')
INSERT INTO STToolbars       VALUES(N'Alive',(SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'ElectronicInvoiceBKAV'), 1,N'fld_barbtnEditInv_Bkav',N'Điều chỉnh',N'EditInv_Bkav',N'Default',N'Điều chỉnh',N'Action',5,1,N'',ISNULL((SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'ElectronicInvoiceBKAV') AND STToolbarTag = ''),0),N'')
INSERT INTO STToolbars       VALUES(N'Alive',(SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'ElectronicInvoiceBKAV'), 1,N'fld_barbtnNewReplace_Bkav',N'Thay thế',N'NewReplace_Bkav',N'Default',N'Thay thế',N'Action',6,1,N'',ISNULL((SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'ElectronicInvoiceBKAV') AND STToolbarTag = ''),0),N'')
INSERT INTO STToolbars       VALUES(N'Alive',(SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'ElectronicInvoiceBKAV'), 1,N'fld_barbtnGetStatusInv_Bkav',N'Lấy trạng thái hóa đơn',N'GetStatusInv_Bkav',N'Default',N'Lấy trạng thái hóa đơn',N'Action',7,1,N'',ISNULL((SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'ElectronicInvoiceBKAV') AND STToolbarTag = ''),0),N'')
INSERT INTO STToolbars       VALUES(N'Alive',(SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'ElectronicInvoiceBKAV'), 1,N'fld_barbtnDeleteInv',N'Xóa hóa đơn',N'DeleteInv_Bkav',N'Default',N'Xóa hóa đơn',N'Action',8,1,N'',ISNULL((SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'ElectronicInvoiceBKAV') AND STToolbarTag = ''),0),N'')
INSERT INTO STToolbars       VALUES(N'Alive',(SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'ElectronicInvoiceBKAV'), 1,N'fld_barbtnCancelInv_Bkav',N'Hủy hóa đơn',N'CancelInv_Bkav',N'Default',N'Hủy hóa đơn',N'Action',9,1,N'',ISNULL((SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'ElectronicInvoiceBKAV') AND STToolbarTag = ''),0),N'')
INSERT INTO STToolbars       VALUES(N'Alive',(SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'ElectronicInvoiceBKAV'), 1,N'fld_barbtnReplaceEInvoiceWaitingForSigning',N'Cập nhật hóa đơn chờ ký',N'ReplaceEInvoiceWaitingForSigning',N'Default',N'Cập nhật hóa đơn chờ ký',N'Action',10,1,N'',ISNULL((SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'ElectronicInvoiceBKAV') AND STToolbarTag = ''),0),N'')

INSERT INTO dbo.STToolbarFunctions   VALUES   ( '0',(SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'ElectronicInvoiceBKAV') AND STToolbarTag = 'Manual'),'ActionNew','Void ActionNew()','BOSERP.Modules.ElectronicInvoiceBKAV.ElectronicInvoiceBKAVModule',1)
INSERT INTO dbo.STToolbarFunctions   VALUES   ( '0',(SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'ElectronicInvoiceBKAV') AND STToolbarTag = 'Duplicate'),'ActionDuplicate','Void ActionDuplicate()','BOSERP.Modules.ElectronicInvoiceBKAV.ElectronicInvoiceBKAVModule',1)
INSERT INTO dbo.STToolbarFunctions   VALUES   ( '0',(SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'ElectronicInvoiceBKAV') AND STToolbarTag = 'ImportInv_Bkav'),'ActionImportInv_BKAV','Void ActionImportInv_BKAV()','BOSERP.Modules.ElectronicInvoiceBKAV.ElectronicInvoiceBKAVModule',1)
INSERT INTO dbo.STToolbarFunctions   VALUES   ( '0',(SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'ElectronicInvoiceBKAV') AND STToolbarTag = 'EditInv_Bkav'),'ActionEditInv_BKAV','Void ActionEditInv_BKAV()','BOSERP.Modules.ElectronicInvoiceBKAV.ElectronicInvoiceBKAVModule',1)
INSERT INTO dbo.STToolbarFunctions   VALUES   ( '0',(SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'ElectronicInvoiceBKAV') AND STToolbarTag = 'NewReplace_Bkav'),'NewEInvoiceReplace_BKAV','Void NewEInvoiceReplace_BKAV()','BOSERP.Modules.ElectronicInvoiceBKAV.ElectronicInvoiceBKAVModule',1)
INSERT INTO dbo.STToolbarFunctions   VALUES   ( '0',(SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'ElectronicInvoiceBKAV') AND STToolbarTag = 'GetStatusInv_Bkav'),'ActionGetStatusInv_BKAV','Void ActionGetStatusInv_BKAV()','BOSERP.Modules.ElectronicInvoiceBKAV.ElectronicInvoiceBKAVModule',1)
INSERT INTO dbo.STToolbarFunctions   VALUES   ( '0',(SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'ElectronicInvoiceBKAV') AND STToolbarTag = 'DeleteInv_Bkav'),'ActionDeleteInv_BKAV','Void ActionDeleteInv_BKAV()','BOSERP.Modules.ElectronicInvoiceBKAV.ElectronicInvoiceBKAVModule',1)
INSERT INTO dbo.STToolbarFunctions   VALUES   ( '0',(SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'ElectronicInvoiceBKAV') AND STToolbarTag = 'CancelInv_Bkav'),'ActionCancelInv_BKAV','Void ActionCancelInv_BKAV()','BOSERP.Modules.ElectronicInvoiceBKAV.ElectronicInvoiceBKAVModule',1)
INSERT INTO dbo.STToolbarFunctions   VALUES   ( '0',(SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'ElectronicInvoiceBKAV') AND STToolbarTag = 'ReplaceEInvoiceWaitingForSigning'),'ReplaceEInvoiceWaitingForSigning','Void ReplaceEInvoiceWaitingForSigning()','BOSERP.Modules.ElectronicInvoiceBKAV.ElectronicInvoiceBKAVModule',1)
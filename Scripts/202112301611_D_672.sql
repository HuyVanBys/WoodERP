Update STScreens
Set STScreenText = N'Tìm kiếm'
Where STScreenNumber = 'SMPO100' and STModuleID = (select STModuleID from STModules Where STModuleName = 'PurchaseOrder')
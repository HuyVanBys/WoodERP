INSERT INTO ADTemplates (ADTemplateNo,ADTemplateName,ADTemplateDesc,ADTemplateStoreProc,AAStatus,ADTemplateDataSource,ADTemplateAutoLoad) SELECT N'RP_PrintProductionPlanning_ND',N'Đơn hàng SX nội địa',N'Đơn hàng SX nội địa',N'RP_PrintProductionPlanning_ND',N'Alive',N'',1
INSERT INTO STToolbars (AAStatus,STModuleID,STUserGroupID,STToolbarName,STToolbarDesc,STToolbarTag,STToolbarStyle,STToolbarCaption,STToolbarGroup,STToolbarOrder,STToolbarVisible,STToolbarPrivilege,STToolbarParentID,STToolbarImage) 
SELECT 
	N'Alive'
	,(Select STModuleID from STModules Where STModuleName = 'ProductionPlanning')
	,1
	,N'fld_barbtnPrintProductionPlanningND'
	,N'Đơn hàng SX nội địa'
	,N'PrintProductionPlanningND'
	,N'Default'
	,N'Đơn hàng SX nội địa'
	,N'Utility'
	,2
	,1
	,N''
	,(Select STToolbarID from STToolbars Where AAStatus = 'Alive' and STModuleID = (Select STModuleID from STModules Where STModuleName = 'ProductionPlanning') and STToolbarName = 'fld_barbtnPrint')
	,N''
INSERT INTO ADTemplateToolbars (FK_ADTemplateID,FK_STToolbarID) 
SELECT 
(Select ADTemplateID From ADTemplates Where ADTemplateNo = 'RP_PrintProductionPlanning_ND'),
(select STToolbarID From STToolbars Where AAStatus = 'Alive' and STModuleID = (Select STModuleID from STModules Where STModuleName = 'ProductionPlanning') and STToolbarName = 'fld_barbtnPrintProductionPlanningND')
INSERT INTO STToolbarFunctions (STToolbarFunctionIDString,STToolbarID,STToolbarFunctionName,STToolbarFunctionFullName,STToolbarFunctionClass,STToolbarFunctionSortOrder) 
SELECT 
	N'0'
	,(select STToolbarID From STToolbars Where AAStatus = 'Alive' and STModuleID = (Select STModuleID from STModules Where STModuleName = 'ProductionPlanning') and STToolbarName = 'fld_barbtnPrintProductionPlanningND')
	,N'ActionPrintTemplate'
	,N'Void ActionPrintTemplate()'
	,N'BOSERP.Modules.ProductionPlanning.ProductionPlanningModule'
	,1
--
INSERT INTO ADTemplates (ADTemplateNo,ADTemplateName,ADTemplateDesc,ADTemplateStoreProc,AAStatus,ADTemplateDataSource,ADTemplateAutoLoad) SELECT N'RP_PrintProductionPlanning_DNLM',N'Giấy đề nghị làm mẫu',N'Giấy đề nghị làm mẫu',N'RP_PrintProductionPlanning_DNLM',N'Alive',N'',1
INSERT INTO STToolbars (AAStatus,STModuleID,STUserGroupID,STToolbarName,STToolbarDesc,STToolbarTag,STToolbarStyle,STToolbarCaption,STToolbarGroup,STToolbarOrder,STToolbarVisible,STToolbarPrivilege,STToolbarParentID,STToolbarImage) 
SELECT 
	N'Alive'
	,(Select STModuleID from STModules Where STModuleName = 'ProductionPlanning')
	,1
	,N'fld_barbtnPrintProductionPlanningDNLM'
	,N'Giấy đề nghị làm mẫu'
	,N'PrintProductionPlanningDNLM'
	,N'Default'
	,N'Giấy đề nghị làm mẫu'
	,N'Utility'
	,2
	,1
	,N''
	,(Select STToolbarID from STToolbars Where AAStatus = 'Alive' and STModuleID = (Select STModuleID from STModules Where STModuleName = 'ProductionPlanning') and STToolbarName = 'fld_barbtnPrint')
	,N''
INSERT INTO ADTemplateToolbars (FK_ADTemplateID,FK_STToolbarID) 
SELECT 
(Select ADTemplateID From ADTemplates Where ADTemplateNo = 'RP_PrintProductionPlanning_DNLM'),
(select STToolbarID From STToolbars Where AAStatus = 'Alive' and STModuleID = (Select STModuleID from STModules Where STModuleName = 'ProductionPlanning') and STToolbarName = 'fld_barbtnPrintProductionPlanningDNLM')
INSERT INTO STToolbarFunctions (STToolbarFunctionIDString,STToolbarID,STToolbarFunctionName,STToolbarFunctionFullName,STToolbarFunctionClass,STToolbarFunctionSortOrder) 
SELECT 
	N'0'
	,(select STToolbarID From STToolbars Where AAStatus = 'Alive' and STModuleID = (Select STModuleID from STModules Where STModuleName = 'ProductionPlanning') and STToolbarName = 'fld_barbtnPrintProductionPlanningDNLM')
	,N'ActionPrintTemplate'
	,N'Void ActionPrintTemplate()'
	,N'BOSERP.Modules.ProductionPlanning.ProductionPlanningModule'
	,1

----

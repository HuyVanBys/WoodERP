--ONLY DUCTHANH
Insert into ADTemplates
Values (
	'RP_PrintARProposalLabel',
	N'Nh�n b�o gi�',
	N'Nh�n b�o gi�',
	'RP_PrintProposalLabel',
	'Alive',
	'',
	0
	)

Insert into STToolbars
Values(
	'Alive',
	(select STModuleID from STModules Where STModuleName = 'Proposal'),
	1,
	'fld_barbtnPrintPriceLabel',
	N'Nh�n b�o gi�',
	'PrintPriceLabel',
	'Default',
	N'Nh�n b�o gi�',
	'Utility',
	(Select Max(STToolbarOrder) + 1 from STToolbars Where STModuleID = (select STModuleID from STModules Where STModuleName = 'Proposal') and STToolbarGroup = 'Utility'),
	1,
	'',
	(Select STToolbarID from STToolbars Where AAStatus = 'Alive' and STModuleID = (select STModuleID from STModules Where STModuleName = 'Proposal') and STToolbarName = 'fld_barbtnPrint'),
	''
	)
Insert into STToolbarFunctions
Values(
	'',
	(Select STToolbarID from STToolbars Where AAStatus = 'Alive' and STModuleID = (select STModuleID from STModules Where STModuleName = 'Proposal') and STToolbarName = 'fld_barbtnPrintPriceLabel'),
	'ActionPrintTemplate',
	'Void ActionPrintTemplate()',
	'BOSERP.Modules.Proposal.ProposalModule',
	1
	)
Insert into ADTemplateToolbars
Values (
	(Select ADTemplateID from ADTemplates WHere ADTemplateNo = 'RP_PrintARProposalLabel'),
	(Select STToolbarID from STToolbars Where AAStatus = 'Alive' and STToolbarName = 'fld_barbtnPrintPriceLabel' and STModuleID = (select STModuleID from STModules Where STModuleName = 'Proposal'))
	)
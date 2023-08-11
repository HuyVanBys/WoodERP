UPDATE dbo.STToolbars
SET STToolbarCaption =N'Duyệt'
WHERE AAStatus = 'Alive'
AND STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'PaymentProposal')
AND STToolbarTag = 'Approve'

UPDATE dbo.ADConfigValues 
SET ADConfigText = N'Đã duyệt'
WHERE AAStatus = 'Alive' 
AND ADConfigKeyGroup = 'PaymentProposalStatus'
AND ADConfigKeyValue = 'Approved'

UPDATE dbo.ADConfigValues
SET ADConfigText = N'Đã duyệt'
WHERE ADConfigKeyGroup = 'PaymentProposalItemApproveStatus'
AND ADConfigKeyValue = 'Approved'


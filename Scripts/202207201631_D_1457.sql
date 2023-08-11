UPDATE dbo.ADConfigValues
SET AAStatus = 'Delete'
WHERE ADConfigKeyGroup = 'CalculatorProductionNormCostStatus' AND ADConfigKeyValue = 'ApprovedProposal'
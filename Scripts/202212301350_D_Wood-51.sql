Update AAColumnAlias
Set AAStatus = 'Delete'
Where AATableName = 'ACCostBudgetDetails'
and AAColumnAliasName not in ('ACCostBudgetDetailFromDate', 'ACCostBudgetDetailToDate', 'FK_ACSegmentID', 'ACCostBudgetDetailAmount')
UPDATE dbo.GELookupTables
SET GELookupTableDisplayColumn = 'STModuleDescription'
,	GELookupTableLookupColumns = 'STModuleDescription'
WHERE GELookupTableName = 'STModules'

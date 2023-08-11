	UPDATE g
	SET g.GENumberingDesc = 	s.STModuleDescriptionDescription
	FROM GENumbering g 
	INNER JOIN dbo.STModules m (NOLOCK) ON m.AAStatus = 'Alive' AND m.STModuleName = g.GENumberingName
	INNER JOIN dbo.STModuleDescriptions s (NOLOCK) ON s.STModuleID = m.STModuleID
	WHERE	g.AAStatus ='Alive'
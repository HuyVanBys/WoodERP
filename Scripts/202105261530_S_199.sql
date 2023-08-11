SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO
ALTER PROCEDURE [dbo].[ICProductGroups_GetRootGroupByGroup]
    @FK_ICDepartmentID INT ,
	@ICProductGroupID INT 
AS
BEGIN
	set nocount on;
	
	--DECLARE @FK_ICDepartmentID INT = 1,
	--@ICProductGroupID INT = 362
	--@ICProductGroupID INT = 360
	--@ICProductGroupID INT = 356
	CREATE TABLE #TableDate (
		ID INT,
		ParentID int
	)
	INSERT INTO #TableDate
	SELECT 
		DISTINCT
		pni.ICProductGroupID
		, pni.ICProductGroupParentID
	FROM ICProductGroups pni
	WHERE pni.FK_ICDepartmentID = @FK_ICDepartmentID AND AAStatus = 'Alive'

	;WITH CTETable(ID, ParentID, Depth, TreePath) as 
	(
		SELECT S.ID, S.ParentID, 1 AS Depth, convert(varchar(100), S.ID) AS path
		FROM #TableDate as S
		UNION ALL
		SELECT S2.ID, p.ParentID, p.Depth + 1 AS Depth, convert(varchar(100), (RTRIM(p.TreePath) +'->'+ convert(varchar(100), S2.ID)))
		FROM CTETable AS p JOIN #TableDate as S2 on S2.ParentID = p.ID
		WHERE p.ParentID is not null
	)
	SELECT 
			po.ICProductGroupID
		,	(SELECT STUFF((
            SELECT '' + RIGHT(p.ICProductGroupNo, p.ICProductGroupConfigGroupNoLength)
            FROM CTETable tb 
			LEFT JOIN ICProductGroups p ON p.ICProductGroupID = tb.ParentID
			AND tb.ParentID > 0
			AND tb.ID = @ICProductGroupID
			WHERE p.AAStatus = 'Alive'
				AND tb.ParentID > 0
			GROUP BY p.ICProductGroupNo
			, p.ICProductGroupConfigGroupNoLength
			,p.ICProductGroupID
            FOR XML PATH('')
            ), 2, 0, '')) AS ICProductGroupNo
		,	po.ICProductGroupName
	
	FROM ICProductGroups po
	WHERE 
		po.AAStatus = 'Alive'
	AND po.ICProductGroupID = @ICProductGroupID
	DROP TABLE #TableDate
	
END

GO


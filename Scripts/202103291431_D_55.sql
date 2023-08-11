UPDATE pg
SET pg.AAStatus = 'Delete'
FROM dbo.ICProductGroups pg INNER JOIN dbo.ICDepartments d ON d.ICDepartmentID = pg.FK_ICDepartmentID
WHERE d.ICDepartmentName LIKE N'Bỏ%'

UPDATE dbo.ICDepartments
SET AAStatus = 'Delete'
WHERE ICDepartmentName LIKE N'Bỏ%'
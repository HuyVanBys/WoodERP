SELECT ACAccountID
INTO #AC
FROM dbo.ACAccounts 
WHERE AAStatus = 'Delete'

UPDATE a
SET AAStatus = 'Delete'
FROM dbo.ACAccounts a
INNER JOIN #AC b ON b.ACAccountID = a.ACAccountParentID
WHERE a.ACAccountID > 0
AND a.ACAccountParentID > 0


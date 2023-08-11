UPDATE dbo.ADReports 
SET AAStatus = 'Alive'
WHERE ADReportType = 'Staff' 
OR ADReportSection = N'Nhân viên'


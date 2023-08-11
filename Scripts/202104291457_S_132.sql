ALTER TABLE dbo.ARCustomers
ADD FK_HREmployeeManagementID INT

ALTER TABLE dbo.ARCustomers
ADD CONSTRAINT FK_ARCustomers_HREmployees FOREIGN KEY (FK_HREmployeeManagementID) REFERENCES HREmployees(HREmployeeID)

ALTER TABLE dbo.ARCustomers
CHECK CONSTRAINT FK_ARCustomers_HREmployees
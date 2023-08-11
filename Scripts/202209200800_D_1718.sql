INSERT INTO dbo.ADConfigValues
VALUES
(   'Alive',  -- AAStatus - varchar(10)
    N'ProductionPlanningTypeReserveOrders', -- ADConfigKey - nvarchar(100)
    N'ReserveOrders', -- ADConfigKeyValue - nvarchar(100)
    N'Đơn hàng dự trữ', -- ADConfigText - nvarchar(1000)
    N'Đơn hàng dự trữ', -- ADConfigKeyDesc - nvarchar(500)
    N'ProductionPlanningType', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
    )
GO
update dbo.AAColumnAlias SET AAColumnAliasName = 'ARCustomerContactAddressLine1' WHERE AATableName = 'ARCustomers' AND AAColumnAliasName = 'ARCustomerContactAddressLine3'
GO
--SELECT ARCustomerContactAddressLine3,ARCustomerContactAddressLine1,* FROM dbo.ARCustomers WHERE ARCustomerContactAddressLine3 <> '' AND ARCustomerContactAddressLine3 <> ARCustomerContactAddressLine1
update dbo.ARCustomers SET ARCustomerContactAddressLine3 = ARCustomerContactAddressLine1 WHERE ARCustomerID > 0

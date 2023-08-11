SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO

-- =============================================
-- Author:		Thao Nguyen
-- Create date: 12/12/2018
-- Description:	ACTransactions_ARInvoicePosting
-- =============================================
ALTER PROCEDURE [dbo].[ACTransactions_PostedPOSShipments]
	@ModuleName			nvarchar(512),
	@ShipmentID			int,
	@IsPosted			bit,
	@DocTypeName		nvarchar(512)
AS
BEGIN
	
	SET NOCOUNT ON;

	declare
	@DocumentTypeID		int,
	@countID			int

	set @countID = 0	
	
	-- select Invoice info
	declare 
		@ObjectID						int,
		@ObjectType						varchar(50),
		@ShipmentNo						nvarchar(50),
		@ShipmentDate					datetime,
		@FK_EmployeeID					int,
		@FK_BRBranchID					int,
		@FK_CSCompanyBankID				int,
		@FK_GECurrencyID				int,
		@ShipmentExchangeRate			decimal(18,5),
		@ShipmentTaxAmount				decimal(18,5),
		@ShipmentDiscountAmount			decimal(18,5),
		@ShipmentDesc					nvarchar(1024), 
		@ShipmentSOContactName			nvarchar(512),
		@ShipmentType					varchar(50),
		@FK_MMWorkShopID				int,
		@FK_MMLineID					int,
		@FK_HRDepartmentID				int,
		@FK_HRDepartmentRoomID			int,
		@FK_HRDepartmentRoomGroupItemID int,
		@ShipmentShippingFees			decimal(18,5),
		@ShipmentItemTotalCost			decimal(18,5),
		@ToolbarTagName					varchar(256),
		@FK_PMProjectID					INT


	select	@ShipmentNo							= i.ARInvoiceNo
			, @ShipmentDate						= i.ARInvoiceDate
			, @FK_BRBranchID					= i.FK_BRBranchID
			, @FK_CSCompanyBankID				= 0
			, @FK_GECurrencyID					= i.FK_GECurrencyID
			, @ShipmentExchangeRate				= i.ARInvoiceExchangeRate
			, @ShipmentTaxAmount				= i.ARInvoiceTaxAmount
			, @ShipmentDiscountAmount			= i.ARInvoiceDiscountFix
			, @ObjectID							= i.FK_ACObjectID
			, @ObjectType						= i.ARObjectType
			, @ShipmentDesc						= i.ARInvoiceDesc
			, @ShipmentType						= i.ARInvoiceTypeCombo
			, @FK_MMWorkShopID					= 0
			, @FK_MMLineID						= 0
			, @FK_HRDepartmentID				= 0
			, @FK_HRDepartmentRoomID			= 0
			, @FK_HRDepartmentRoomGroupItemID	= 0
			, @ShipmentShippingFees				= i.ARInvoiceShippingFees
			, @ToolbarTagName					= i.STToolbarActionName	
			, @FK_PMProjectID					= i.FK_PMProjectID
	from	ARInvoices (NOLOCK)i
	where	i.AAStatus						= 'Alive'
			and i.ARInvoiceID				= @ShipmentID
			
	
	-- select ShipmentItems
	declare @ShipmentItemTable table
	(
		FK_ICProductID						int,
		FK_ACAccountID						int,
		FK_ACOffsetAccountID				int,
		ShipmentItemUnitCost				DECIMAL(18, 5),
		ShipmentItemExchangeUnitCost		DECIMAL(18, 5),
		ShipmentItemProductQty				decimal(18, 5),
		ShipmentItemTotalAmount				decimal(18, 5),
		ShipmentItemTaxAmount				decimal(18, 5),
		ShipmentItemDiscountAmount			decimal(18, 5),
		FK_ARSaleOrderID					int,
		FK_MMBatchProductID					int,
		FK_MMOperationID					int,
		FK_HRDepartmentRoomGroupItemID		int,
		FK_HRDepartmentRoomGroupID			int,
		FK_MMLineID							int,
		FK_MMWorkShopID						int,
		FK_ACUnfinishedConstructionCostID	int,
		FK_ACCostObjectID					int,
		ARInvoiceItemCode01Combo			nvarchar(256),
		ARInvoiceItemCode02Combo			nvarchar(256),
		ARInvoiceItemCode03Combo			nvarchar(256),
		ARInvoiceItemCode04Combo			nvarchar(256),
		ARInvoiceItemCode05Combo			nvarchar(256),
		ARInvoiceItemCode06Combo			nvarchar(256),
		ARInvoiceItemCode07Combo			nvarchar(256),
		ARInvoiceItemCode08Combo			nvarchar(256),
		ARInvoiceItemCode09Combo			nvarchar(256),
		ARInvoiceItemCode10Combo			nvarchar(256)
	)
	insert into @ShipmentItemTable
		select ii.FK_ICProductID
			, p.FK_ACAccountCostPriceID as FK_ACOffsetAccountID
			, (CASE WHEN ISNULL(s.FK_ACAccountID,0) > 0
						THEN s.FK_ACAccountID
					WHEN ISNULL(p.FK_ACAccountID,0) <> 0
						THEN p.FK_ACAccountID
					ELSE 0
				END)
			, CASE WHEN @ShipmentExchangeRate > 1 THEN
						ROUND(ii.ARInvoiceItemExchangeUnitCost / @ShipmentExchangeRate,5)
					ELSE ii.ARInvoiceItemProductUnitCost END
			, ii.ARInvoiceItemExchangeUnitCost
			, ii.ARInvoiceItemProductQty 
			, CASE WHEN @ShipmentExchangeRate > 1 THEN
						ROUND(ii.ARInvoiceItemExchangeUnitCost / @ShipmentExchangeRate,5)
					ELSE ii.ARInvoiceItemProductUnitCost END
			, ii.ARInvoiceItemTaxAmount
			, ii.ARInvoiceItemDiscountAmount
			, ii.FK_ARSaleOrderID
			, 0
			, 0
			, 0
			, 0
			, 0					
			, 0
			, 0 as FK_ACUnfinishedConstructionCostID
			, 0
			, '' as ARInvoiceItemCode01Combo
			, '' as ARInvoiceItemCode02Combo
			, '' as ARInvoiceItemCode03Combo
			, '' as ARInvoiceItemCode04Combo
			, '' as ARInvoiceItemCode05Combo
			, '' as ARInvoiceItemCode06Combo
			, '' as ARInvoiceItemCode07Combo
			, '' as ARInvoiceItemCode08Combo
			, '' as ARInvoiceItemCode09Combo
			, '' as ARInvoiceItemCode10Combo			
		from	ARInvoiceItems (NOLOCK) ii
				inner join ICProducts (NOLOCK) p on ii.FK_ICProductID = p.ICProductID
				LEFT join ICStocks (NOLOCK) s on s.ICStockID = ii.FK_ICStockID
		where	ii.AAStatus			= 'Alive'
				and FK_ARInvoiceID	= @ShipmentID	
				AND p.HasComponent = 0
	
	insert into @ShipmentItemTable
	select cop.FK_ICProductID
			, p.FK_ACAccountCostPriceID as FK_ACOffsetAccountID
			, (CASE WHEN ISNULL(s.FK_ACAccountID,0) > 0
						THEN s.FK_ACAccountID
					WHEN ISNULL(p.FK_ACAccountID,0) <> 0
						THEN p.FK_ACAccountID
					ELSE 0
				END)
			, CASE WHEN @ShipmentExchangeRate > 1 THEN
						ROUND(cost.ICTransactionExchangeUnitCost / @ShipmentExchangeRate,5)
					ELSE cost.ICTransactionExchangeUnitCost END
			, cost.ICTransactionExchangeUnitCost
			, cop.ARInvoiceItemComponentQty AS ARInvoiceItemProductQty 
			, CASE WHEN @ShipmentExchangeRate > 1 THEN
						ROUND(cost.ICTransactionExchangeUnitCost / @ShipmentExchangeRate,5)
					ELSE cost.ICTransactionExchangeUnitCost END
			, ii.ARInvoiceItemTaxAmount
			, ii.ARInvoiceItemDiscountAmount
			, ii.FK_ARSaleOrderID
			, 0
			, 0
			, 0
			, 0
			, 0					
			, 0
			, 0 as FK_ACUnfinishedConstructionCostID
			, 0
			, '' as ARInvoiceItemCode01Combo
			, '' as ARInvoiceItemCode02Combo
			, '' as ARInvoiceItemCode03Combo
			, '' as ARInvoiceItemCode04Combo
			, '' as ARInvoiceItemCode05Combo
			, '' as ARInvoiceItemCode06Combo
			, '' as ARInvoiceItemCode07Combo
			, '' as ARInvoiceItemCode08Combo
			, '' as ARInvoiceItemCode09Combo
			, '' as ARInvoiceItemCode10Combo			
		from	ARInvoiceItems (NOLOCK) ii
				INNER JOIN [ARInvoiceItemComponents] cop ON cop.FK_ARInvoiceItemID = ii.ARInvoiceItemID
				inner join ICProducts (NOLOCK) p on cop.FK_ICProductID = p.ICProductID
				LEFT join ICStocks (NOLOCK) s on s.ICStockID = cop.FK_ICStockID
				INNER JOIN dbo.ICProductSeries se ON se.ICProductSerieID = cop.FK_ICProductSerieID
				OUTER APPLY (
					SELECT TOP 1 t.ICTransactionExchangeUnitCost 
					FROM dbo.ICTransactions t 
					WHERE t.ICTransactionReceiptSerialNo = se.ICProductSerieNo
					AND t.FK_ICProductID = cop.FK_ICProductID
					AND t.ICTransactionType = 1
					AND t.AAStatus ='Alive'
				) cost
		where	ii.AAStatus			= 'Alive'
				and FK_ARInvoiceID	= @ShipmentID	

	-- Kiểm tra khóa số liệu và ngày đầu kỳ nhập liệu
	declare @IsValidDocuentDate bit
	set @IsValidDocuentDate	= dbo.ACTransactions_IsValidDocumentTransactionDate(@ShipmentDate)
		
	if(@IsValidDocuentDate = 0)
		return;
	
	-- Xóa post cũ
	--exec ACTransactions_DeleteByDocumentTranNo @ShipmentNo
	
	if(@IsPosted = 0)
		return;
		
	-- Get document entry function mapping
	declare @DocTypeEntryMappingTable as table
	(
		RowID int,
		FK_ACDocuemntTypeID int,
		FK_ACEntryTypeID int,
		DocumentTypeName nvarchar(256),
		EntryTypeName	nvarchar(256),
		ACEntryTypeDesc nvarchar(512),
		ACDocumentTypeDesc nvarchar(512)
	)
	insert into @DocTypeEntryMappingTable
	exec ACDocTypeEntryFunctionMappings_GetByModuleNameAndToolbarTagName @ModuleName, @ToolbarTagName
	
	-- declare DocumentType and account variables
	declare @EntryTypeName			nvarchar(256), 
			@EntryTypeDesc			nvarchar(512), 
			@DocumenttypeName		nvarchar(256),
			@DefaultDebitAccount	int, 
			@DefaultCreditAcount	int
	
	-- create ACTransaction table structure	
	 declare @ShipmentItemsToPostTable table
	 (
		FK_ACAccountID						int,
		FK_ACOffsetAccountID				int,
		ACDocumentTranDebitAmount			decimal(18, 5),
		ACDocumentTranDebitExchangeAmount	decimal(18, 5),
		ACDocumentTranCreditAmount			decimal(18, 5),
		ACDocumentTranCreditExchangeAmount	decimal(18, 5),
		ACTransactionExchangeRate			decimal(18, 5),
		EntryTypeName						nvarchar(256),
		EntryTypeDesc						nvarchar(512),
		EntryGroup							int,
		FK_ARSaleOrderID					int,
		FK_MMBatchProductID					int,
		FK_MMOperationID					int,
		FK_HRDepartmentRoomGroupItemID		int,
		FK_HRDepartmentRoomGroupID			int,
		FK_MMLineID							int,
		FK_MMWorkShopID						int,
		FK_ACUnfinishedConstructionCostID	int,
		K_ACCostObjectID					int,
		ARInvoiceItemCode01Combo			nvarchar(256),
		ARInvoiceItemCode02Combo			nvarchar(256),
		ARInvoiceItemCode03Combo			nvarchar(256),
		ARInvoiceItemCode04Combo			nvarchar(256),
		ARInvoiceItemCode05Combo			nvarchar(256),
		ARInvoiceItemCode06Combo			nvarchar(256),
		ARInvoiceItemCode07Combo			nvarchar(256),
		ARInvoiceItemCode08Combo			nvarchar(256),
		ARInvoiceItemCode09Combo			nvarchar(256),
		ARInvoiceItemCode10Combo			nvarchar(256)
	 )
	--Get document type entry accounts
	declare @DocTypeEntryAccountTable DocTypeEntryAccountTable
	delete @DocTypeEntryMappingTable where DocumentTypeName <> @DocTypeName
	----------------------------------------------------------------------
		if(isnull(@DocumentTypeID, 0) <> isnull((select FK_ACDocuemntTypeID from @DocTypeEntryMappingTable where DocumentTypeName=@DocTypeName), 0))
		begin
			
			set @DocumentTypeID = isnull((select FK_ACDocuemntTypeID from @DocTypeEntryMappingTable where DocumentTypeName=@DocTypeName), 0)
			set @DocumentTypeName = isnull((select DocumentTypeName from @DocTypeEntryMappingTable where DocumentTypeName=@DocTypeName), '')
			
			delete from @DocTypeEntryAccountTable
			insert into @DocTypeEntryAccountTable
			exec ACDocTypeEntryAccounts_GetAllDataByDocumentTypeIDAndEntryTypeID @DocumentTypeID, null		
		end
		
		if(@DocTypeName = @DocumenttypeName)
		begin
			set @EntryTypeName			= (select EntryTypeName from @DocTypeEntryMappingTable WHERE DocumentTypeName=@DocTypeName)
			set	@DefaultDebitAccount	= dbo.DocTypeEntryAccountTable_GetDebitAccountByEntryTypeName(@DocTypeEntryAccountTable, @EntryTypeName)		
			set @DefaultCreditAcount	= dbo.DocTypeEntryAccountTable_GetCreditAccountByEntryTypeName(@DocTypeEntryAccountTable, @EntryTypeName)
			set @EntryTypeDesc			= dbo.DocTypeEntryAccountTable_GetEntryTypeDescByEntryTypeName(@DocTypeEntryAccountTable, @EntryTypeName)
			
			insert into @ShipmentItemsToPostTable
			 select (case when ISNULL(ii.FK_ACAccountID,0) = 0
						then @DefaultDebitAccount
					else ii.FK_ACAccountID
					end)
				, (case when ii.FK_ACOffsetAccountID <> 0
						then ii.FK_ACOffsetAccountID
					else @DefaultCreditAcount
					end)
				, sum(ii.ShipmentItemProductQty * ii.ShipmentItemUnitCost)
				, sum(ii.ShipmentItemProductQty * ii.ShipmentItemExchangeUnitCost)
				, 0
				, 0
				, @ShipmentExchangeRate
				, @EntryTypeName
				, @EntryTypeDesc
				, (@countID / 2) + ROW_NUMBER() OVER ( ORDER BY ( SELECT 1 ) )
				, ii.FK_ARSaleOrderID
				, ii.FK_MMBatchProductID -- BatchProductID
				, ii.FK_MMOperationID
				, ii.FK_HRDepartmentRoomGroupItemID	
				, ii.FK_HRDepartmentRoomGroupID		
				, ii.FK_MMLineID						
				, ii.FK_MMWorkShopID					
				, 0 as FK_ACUnfinishedConstructionCostID
				, ii.FK_ACCostObjectID		
				, ii.ARInvoiceItemCode01Combo
				, ii.ARInvoiceItemCode02Combo
				, ii.ARInvoiceItemCode03Combo
				, ii.ARInvoiceItemCode04Combo
				, ii.ARInvoiceItemCode05Combo
				, ii.ARInvoiceItemCode06Combo
				, ii.ARInvoiceItemCode07Combo
				, ii.ARInvoiceItemCode08Combo
				, ii.ARInvoiceItemCode09Combo
				, ii.ARInvoiceItemCode10Combo			
			 from @ShipmentItemTable ii
			 group by  
				 ii.FK_ACAccountID
				, ii.FK_ACOffsetAccountID
				, ii.FK_ARSaleOrderID
				, ii.FK_MMBatchProductID -- BatchProductID
				, ii.FK_MMOperationID
				, ii.FK_HRDepartmentRoomGroupItemID	
				, ii.FK_HRDepartmentRoomGroupID		
				, ii.FK_MMLineID						
				, ii.FK_MMWorkShopID					
				, FK_ACUnfinishedConstructionCostID
				, ii.FK_ACCostObjectID		
				, ii.ARInvoiceItemCode01Combo
				, ii.ARInvoiceItemCode02Combo
				, ii.ARInvoiceItemCode03Combo
				, ii.ARInvoiceItemCode04Combo
				, ii.ARInvoiceItemCode05Combo
				, ii.ARInvoiceItemCode06Combo
				, ii.ARInvoiceItemCode07Combo
				, ii.ARInvoiceItemCode08Combo
				, ii.ARInvoiceItemCode09Combo
				, ii.ARInvoiceItemCode10Combo				
			 order by  ii.FK_ACAccountID
				, ii.FK_ACOffsetAccountID
				, ii.FK_ARSaleOrderID
				, ii.FK_MMBatchProductID -- BatchProductID
				, ii.FK_MMOperationID
				, ii.FK_HRDepartmentRoomGroupItemID	
				, ii.FK_HRDepartmentRoomGroupID		
				, ii.FK_MMLineID						
				, ii.FK_MMWorkShopID					
				, FK_ACUnfinishedConstructionCostID
				, ii.FK_ACCostObjectID		
				, ii.ARInvoiceItemCode01Combo
				, ii.ARInvoiceItemCode02Combo
				, ii.ARInvoiceItemCode03Combo
				, ii.ARInvoiceItemCode04Combo
				, ii.ARInvoiceItemCode05Combo
				, ii.ARInvoiceItemCode06Combo
				, ii.ARInvoiceItemCode07Combo
				, ii.ARInvoiceItemCode08Combo
				, ii.ARInvoiceItemCode09Combo
				, ii.ARInvoiceItemCode10Combo		

			insert into @ShipmentItemsToPostTable
		 select (case when ii.FK_ACOffsetAccountID <> 0
					then ii.FK_ACOffsetAccountID
				else @DefaultCreditAcount
				end)
			, (case when ISNULL(ii.FK_ACAccountID,0) = 0
					then @DefaultDebitAccount
				else ii.FK_ACAccountID
				end)		
			, 0
			, 0
			, sum(ii.ShipmentItemProductQty * ii.ShipmentItemUnitCost)
			, sum(ii.ShipmentItemProductQty * ii.ShipmentItemExchangeUnitCost)		
			, @ShipmentExchangeRate
			, @EntryTypeName
			, @EntryTypeDesc
			, (@countID / 2) + ROW_NUMBER() OVER ( ORDER BY ( SELECT 1 ) )
			, ii.FK_ARSaleOrderID
			, ii.FK_MMBatchProductID -- BatchProductID
			, ii.FK_MMOperationID
			, ii.FK_HRDepartmentRoomGroupItemID	
			, ii.FK_HRDepartmentRoomGroupID		
			, ii.FK_MMLineID						
			, ii.FK_MMWorkShopID					
			, 0 as FK_ACUnfinishedConstructionCostID
			, ii.FK_ACCostObjectID		
			, ii.ARInvoiceItemCode01Combo
			, ii.ARInvoiceItemCode02Combo
			, ii.ARInvoiceItemCode03Combo
			, ii.ARInvoiceItemCode04Combo
			, ii.ARInvoiceItemCode05Combo
			, ii.ARInvoiceItemCode06Combo
			, ii.ARInvoiceItemCode07Combo
			, ii.ARInvoiceItemCode08Combo
			, ii.ARInvoiceItemCode09Combo
			, ii.ARInvoiceItemCode10Combo			
		 from @ShipmentItemTable ii
		 group by  
			 ii.FK_ACAccountID
			, ii.FK_ACOffsetAccountID
			, ii.FK_ARSaleOrderID
			, ii.FK_MMBatchProductID -- BatchProductID
			, ii.FK_MMOperationID
			, ii.FK_HRDepartmentRoomGroupItemID	
			, ii.FK_HRDepartmentRoomGroupID		
			, ii.FK_MMLineID						
			, ii.FK_MMWorkShopID					
			, FK_ACUnfinishedConstructionCostID
			, ii.FK_ACCostObjectID		
			, ii.ARInvoiceItemCode01Combo
			, ii.ARInvoiceItemCode02Combo
			, ii.ARInvoiceItemCode03Combo
			, ii.ARInvoiceItemCode04Combo
			, ii.ARInvoiceItemCode05Combo
			, ii.ARInvoiceItemCode06Combo
			, ii.ARInvoiceItemCode07Combo
			, ii.ARInvoiceItemCode08Combo
			, ii.ARInvoiceItemCode09Combo
			, ii.ARInvoiceItemCode10Combo				
		 order by  ii.FK_ACAccountID
			, ii.FK_ACOffsetAccountID
			, ii.FK_ARSaleOrderID
			, ii.FK_MMBatchProductID -- BatchProductID
			, ii.FK_MMOperationID
			, ii.FK_HRDepartmentRoomGroupItemID	
			, ii.FK_HRDepartmentRoomGroupID		
			, ii.FK_MMLineID						
			, ii.FK_MMWorkShopID					
			, FK_ACUnfinishedConstructionCostID
			, ii.FK_ACCostObjectID		
			, ii.ARInvoiceItemCode01Combo
			, ii.ARInvoiceItemCode02Combo
			, ii.ARInvoiceItemCode03Combo
			, ii.ARInvoiceItemCode04Combo
			, ii.ARInvoiceItemCode05Combo
			, ii.ARInvoiceItemCode06Combo
			, ii.ARInvoiceItemCode07Combo
			, ii.ARInvoiceItemCode08Combo
			, ii.ARInvoiceItemCode09Combo
			, ii.ARInvoiceItemCode10Combo			
		end
	---------- GECurrencyDecimalNumber round -------------------------------------------------------
	declare @RoundNo		decimal(18,5)
	select @RoundNo = ISNULL(GECurrencyDecimalNumber,0) From GECurrencies WHERE GECurrencyID = @FK_GECurrencyID
	---------------------------------
	-- insert into ACTransactions
	insert into ACTransactions
	select  'Alive'
			, GETDATE()
			, ''
			, GETDATE()
			, ''
			, @ShipmentID
			, @ShipmentNo
			, @ModuleName
			, ''
			, @ShipmentNo
			, EntryTypeDesc
			, @ShipmentDate
			, @ShipmentNo
			, @ShipmentDate
			, EntryGroup
			, 'Post'			
			, isnull(@FK_EmployeeID, 0)
			, @FK_BRBranchID
			, @FK_CSCompanyBankID
			, @ObjectID
			, @ObjectType
			, @ShipmentSOContactName
			, @ShipmentDesc
			, EntryTypeDesc
			, @FK_GECurrencyID	
			, ACTransactionExchangeRate			
			, FK_ACAccountID						
		   , FK_ACOffsetAccountID				
		   , ROUND(ACDocumentTranDebitAmount,@RoundNo)			
		   , ROUND(ACDocumentTranDebitExchangeAmount,0)	
		   , ROUND(ACDocumentTranCreditAmount,@RoundNo)			
		   , ROUND(ACDocumentTranCreditExchangeAmount,0)
		   , 1		   
		   --, EntryTypeName						
		   , 0
		   , '' --ACTransactionShipmentLotNo
		   , 0	--FK_ACCostCenterID
		   , 0	--FK_ACSegmentID	   
		   , FK_MMBatchProductID	 --FK_MMBatchProductID				
		   , 0		 --FK_ARSaleOrderID			
		   , @FK_HRDepartmentID --FK_HRDepartmentID	
		   , @FK_HRDepartmentRoomID --FK_HRDepartmentRoomID
		   , FK_MMWorkShopID --FK_MMWorkShopID
		   , FK_MMOperationID --FK_MMOperationID
		   , FK_MMLineID --FK_MMLineID
		   , FK_HRDepartmentRoomGroupItemID --FK_HRDepartmentRoomGroupItemID
		   , @FK_PMProjectID --FK_PMProjectID
		   , 0 --FK_ACAssetID
		   , 0 --FK_ICProductEquipmentID	
		   , 0 --FK_ACCostObjectID
		   , FK_ACUnfinishedConstructionCostID --FK_ACUnfinishedConstructionCostID
		   , 0  --FK_ACLoanShipmentID
		   , ''	--ACTransactionCode01Combo
		   , ''				
		   , ''				
		   , ''				
		   , ''				
		   , ''				
		   , ''				
		   , ''				
		   , ''				
		   , ''				
	from @ShipmentItemsToPostTable 

END



GO


SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO
-- =============================================
-- Author:		Thao Nguyen
-- Create date: 12/12/2018
-- Description:	ACTransactions_ICReceiptPosting
-- =============================================
ALTER PROCEDURE [dbo].[ACTransactions_ICReceiptPosting]
	@ModuleName			NVARCHAR(512),
	@ReceiptID			INT,
	@IsPosted			BIT
AS
BEGIN
	
	SET NOCOUNT ON;

	DECLARE
	@DocumentTypeID		INT,
	@countID			INT

	SET @countID = 0
	
	-- select Invoice info
	DECLARE 
		@ObjectID					INT,
		@ObjectType					VARCHAR(50),
		@ReceiptNo					NVARCHAR(50),
		@ReceiptDate				DATETIME,
		@FK_EmployeeID				INT,
		@FK_BRBranchID				INT,
		@FK_CSCompanyBankID			INT,
		@FK_GECurrencyID			INT,
		@ReceiptExchangeRate		DECIMAL(18,5),
		@ReceiptTaxAmount			DECIMAL(18,5),
		@ReceiptDiscountAmount		DECIMAL(18,5),
		@ReceiptDesc				NVARCHAR(1024), 
		@ReceiptSOContactName		NVARCHAR(512),
		@ReceiptType				VARCHAR(50),
		@ReceiptChannel				NVARCHAR(50),
		@FK_ACAccountPurchaseID		INT,
		@FK_MMWorkShopID			INT,
		@FK_MMLineID				INT,
		@FK_HRDepartmentID			INT,
		@FK_HRDepartmentRoomID		INT,
		@FK_HRDepartmentRoomGroupItemID INT,
		@FK_ACSegmentID				INT,
		@FK_APPurchaseOrderID		INT,
		@ReceiptShippingFees		DECIMAL(18,5),
		@ReceiptContTotalFees		DECIMAL(18,5),
		@ReceiptItemTotalCost		DECIMAL(18,5),
		@ReceiptSubTotalCost		DECIMAL(18,5),
		@ReceiptProportion			DECIMAL(18,5), --Tỷ trọng
		@ReceiptRemainProportion	DECIMAL(18,5), --Tỷ trọng còn lại
		@ToolbarTagName				VARCHAR(256)

	SELECT	@ReceiptNo						= i.ICReceiptNo
			, @ReceiptDate					= i.ICReceiptDate
			, @FK_BRBranchID				= i.FK_BRBranchID
			, @FK_CSCompanyBankID			= 0
			, @FK_GECurrencyID				= i.FK_GECurrencyID
			, @ReceiptExchangeRate			= i.ICReceiptExchangeRate
			, @ReceiptTaxAmount				= i.ICReceiptTaxAmount
			, @ReceiptDiscountAmount		= i.ICReceiptDiscountFix
			, @ObjectID						= case when i.FK_ACObjectID = 0 or @ModuleName ='PurchaseReceipt' then i.FK_ACAssObjectID  else i.FK_ACObjectID end
			, @ObjectType					= case when i.FK_ACObjectID = 0 or @ModuleName ='PurchaseReceipt' then i.ICAssObjectType else  i.ICObjectType end
			, @ReceiptDesc					= i.ICReceiptDesc
			, @ReceiptType					= i.ICReceiptTypeCombo
			, @ReceiptChannel				= i.ICReceiptCreateFrom
			, @FK_ACAccountPurchaseID		= i.FK_ACAccountPurchaseID
			, @FK_MMWorkShopID				= 0
			, @FK_MMLineID					= 0
			, @FK_ACSegmentID				= i.FK_ACSegmentID
			, @FK_HRDepartmentID			= i.FK_HRDepartmentID
			, @FK_HRDepartmentRoomID		= i.FK_HRDepartmentRoomID
			, @FK_HRDepartmentRoomGroupItemID = i.FK_HRDepartmentRoomGroupItemID
			, @FK_APPurchaseOrderID			= i.FK_APPurchaseOrderID
			, @ReceiptShippingFees			= i.ICReceiptShippingFees
			, @ReceiptSubTotalCost			= i.ICReceiptSubTotalCost
			, @ToolbarTagName				= i.STToolbarActionName
			, @ReceiptProportion			= i.ICReceiptProportion
			, @ReceiptRemainProportion		= 100.000 - ISNULL(Proportion.value, 0.000)
			, @ReceiptContTotalFees			= (SELECT SUM(ISNULL(ICReceiptItemContTotalAmount, 0.000))
												FROM dbo.ICReceiptItemConts
												WHERE AAStatus = 'Alive'
												AND FK_ICReceiptID = @ReceiptID)
	FROM 	ICReceipts (NOLOCK) i
		OUTER APPLY (SELECT ISNULL(SUM(r2.ICReceiptProportion) , 0.000) AS value
								FROM dbo.ICReceipts r2
								WHERE r2.AAStatus = 'Alive'
									AND r2.ICReceiptDate < @ReceiptDate
									AND r2.FK_APPurchaseOrderID = i.FK_APPurchaseOrderID) AS Proportion
	WHERE	i.AAStatus						= 'Alive'
			and i.ICReceiptID				= @ReceiptID
	
	SELECT 
		rs.ICReceiptNo
	INTO #SamePurchaseOrder
	FROM dbo.ICReceipts (NOLOCK) rs
	WHERE rs.AAStatus = 'Alive'
		AND rs.FK_APPurchaseOrderID = @FK_APPurchaseOrderID
		AND DATEDIFF(DD, rs.ICReceiptDate, @ReceiptDate) >= 0
		AND rs.ICReceiptID <> @ReceiptID
	
	DECLARE @ReceiptItemShipmentTotalReceiptCost DECIMAL(18,5) = (SELECT ISNULL(SUM(t.ACTransactionDebitAmount), 0.000)
																	FROM dbo.ACTransactions (NOLOCK) t
																		INNER JOIN #SamePurchaseOrder p ON p.ICReceiptNo = t.ACTransactionNo
																	WHERE t.AAStatus = 'Alive'
																		AND t.ACTransactionCode01Combo = 'OutSourcing')
			
	-- select ReceiptItems
	DECLARE @ReceiptItemTable table
	(
		ReceiptItemID						INT,
		FK_ICProductID						int,
		FK_ACAccountID						int,
		ReceiptItemProductUnitCost			decimal(18,5),
		ReceiptItemProductQty				decimal(18,5),
		ReceiptItemShippingFees				decimal(18,5),
		ReceiptItemTaxAmount				decimal(18,5),
		ReceiptItemDiscountAmount			decimal(18,5),
		ReceiptDiscountAmount				decimal(18,5),
		ReceiptItemShipmentTotalCost		DECIMAL(18,5), --Tổng giá vốn xuất kho
		ReceiptItemShipmentTotalReceiptCost	DECIMAL(18,5), --Tổng giá vốn đã nhập kho
		ReceiptItemImportTaxAmount			DECIMAL(18,5),	-- Thuế xuất/nhập khẩu
		ReceiptItemConsumptionTaxAmount		DECIMAL(18,5),	-- Thuế tiêu dùng đặc biệt
		ReceiptItemEnvironmentTaxAmount		DECIMAL(18,5),	-- Thuế bảo vệ môi trường
		ReceiptOutSourcingCost				DECIMAL(18,5),
		ReceiptItemContFees					DECIMAL(18,5),
		FK_APPurchaseOrderID				int,
		FK_APInvoiceInID					int,
		FK_MMBatchProductID					int,
		FK_MMOperationID					int,
		FK_HRDepartmentRoomGroupItemID		int,
		FK_HRDepartmentRoomGroupID			INT,
		FK_MMLineID							int,
		FK_MMWorkShopID						int,
		FK_ACUnfinishedConstructionCostID	int,
		FK_ACOffsetAccountID				int,
		FK_ACAccountDebitInvoiceInID		int,
		FK_ACCostObjectID					int,
		FK_APBillOfLadingItemID				INT,
		FK_ACImportTaxAccountID				INT,	-- Tài khoản thuế xuất/nhập khảu
		FK_ACConsumptionTaxAccountID		INT,	-- Tài khoản thuế tiêu dùng đặc biệt
		FK_ACEnvironmentTaxAccountID		INT,	-- Tài khoản thuế bảo vệ môi trường
		ICReceiptItemCode01Combo			nvarchar(256),
		ICReceiptItemCode02Combo			nvarchar(256),
		ICReceiptItemCode03Combo			nvarchar(256),
		ICReceiptItemCode04Combo			nvarchar(256),
		ICReceiptItemCode05Combo			nvarchar(256),
		ICReceiptItemCode06Combo			nvarchar(256),
		ICReceiptItemCode07Combo			nvarchar(256),
		ICReceiptItemCode08Combo			nvarchar(256),
		ICReceiptItemCode09Combo			nvarchar(256),
		ICReceiptItemCode10Combo			nvarchar(256)
	)
	insert into @ReceiptItemTable
		select ii.ICReceiptItemID
			, ii.FK_ICProductID
			, (	CASE WHEN s.FK_ACAccountID <> 0
						THEN s.FK_ACAccountID
					WHEN p.FK_ACAccountID > 0
						THEN p.FK_ACAccountID
					ELSE ii.FK_ACAccountID
				END) as FK_ACAccountID
			, ii.ICReceiptItemProductUnitCost
			, ii.ICReceiptItemProductQty
			, (ii.ICReceiptItemTotalCost / CASE WHEN @ReceiptSubTotalCost = 0 THEN 1 ELSE @ReceiptSubTotalCost END) * @ReceiptShippingFees
			, ii.ICReceiptItemTaxAmount
			, (ii.ICReceiptItemProductDiscount /100) * (ii.ICReceiptItemProductUnitCost * ii.ICReceiptItemProductQty)
			, (ii.ICReceiptItemTotalCost / CASE WHEN @ReceiptSubTotalCost = 0 THEN 1 ELSE @ReceiptSubTotalCost END) * @ReceiptDiscountAmount
			, ii.ICReceiptItemQty3
			, ISNULL(@ReceiptItemShipmentTotalReceiptCost, 0.000)
			, ISNULL(bol.APBillOfLadingItemImportTaxAmount, 0.000)
			, ISNULL(bol.APBillOfLadingItemConsumptionTaxAmount, 0.000)
			, ISNULL(bol.APBillOfLadingItemEnviromentTaxAmount, 0.000)
			, 0.000
			, ISNULL((ii.ICReceiptItemTotalCost / CASE WHEN @ReceiptSubTotalCost = 0 THEN 1 ELSE @ReceiptSubTotalCost END) * @ReceiptContTotalFees, 0)
			, ii.FK_APPurchaseOrderID
			, ii.FK_APInvoiceInID
			, ii.FK_MMBatchProductID -- BatchProductID
			, ii.FK_MMOperationID
			, ii.FK_HRDepartmentRoomGroupItemID	
			, ii.FK_HRDepartmentRoomGroupID		
			, ii.FK_MMLineID						
			, ii.FK_MMWorkShopID					
			, 0 as FK_ACUnfinishedConstructionCostID
			, ISNULL((case when ii.FK_ACOffsetAccountID <> 0
					then ii.FK_ACOffsetAccountID 
				else ier.FK_ACAcountID
				end
				),0) as FK_ACOffsetAccountID 
			, ISNULL(iv.FK_ACAccountID, 0)
			, ii.FK_ACCostObjectID
			, ii.FK_APBillOfLadingItemID
			,(
							SELECT t.FK_ACAccountID FROM  dbo.APBillOfLadings bl
								INNER JOIN dbo.ACTransactions t ON t.ACTransactionReferenceID = bl.APBillOfLadingID AND t.ACTransactionModuleName = 'BillOfLading'
							WHERE bl.AAStatus = 'Alive'
							AND bl.APBillOfLadingID = ii.FK_APBillOfLadingID
							AND t.ACTransactionDebitAmount > 0
							AND t.ACTransactionDetailDesc = N'Thuế xuất/ nhập khẩu'
							)
			,(
							SELECT t.FK_ACAccountID FROM  dbo.APBillOfLadings bl
								INNER JOIN dbo.ACTransactions t ON t.ACTransactionReferenceID = bl.APBillOfLadingID AND t.ACTransactionModuleName = 'BillOfLading'
							WHERE bl.AAStatus = 'Alive'
							AND bl.APBillOfLadingID = ii.FK_APBillOfLadingID
							AND t.ACTransactionDebitAmount > 0
							AND t.ACTransactionDetailDesc = N'Thuế tiêu thụ đặc biệt'
							)
			,(
							SELECT t.FK_ACAccountID FROM  dbo.APBillOfLadings bl
								INNER JOIN dbo.ACTransactions t ON t.ACTransactionReferenceID = bl.APBillOfLadingID AND t.ACTransactionModuleName = 'BillOfLading'
							WHERE bl.AAStatus = 'Alive'
							AND bl.APBillOfLadingID = ii.FK_APBillOfLadingID
							AND t.ACTransactionDebitAmount > 0
							AND t.ACTransactionDetailDesc = N'Thuế BVMT'
							)
			, ii.ICReceiptItemCode01Combo
			, ii.ICReceiptItemCode02Combo
			, ii.ICReceiptItemCode03Combo
			, ii.ICReceiptItemCode04Combo
			, ii.ICReceiptItemCode05Combo
			, ii.ICReceiptItemCode06Combo
			, ii.ICReceiptItemCode07Combo
			, ii.ICReceiptItemCode08Combo
			, ii.ICReceiptItemCode09Combo
			, ii.ICReceiptItemCode10Combo			
		from	ICReceiptItems (NOLOCK)ii
			LEFT JOIN ICProducts (NOLOCK)p on ii.FK_ICProductID = p.ICProductID
			LEFT JOIN ICStocks (NOLOCK)s on s.ICStockID = ii.FK_ICStockID
			LEFT JOIN ICImportAndExportReasons (NOLOCK) ier on ier.ICImportAndExportReasonID = ii.FK_ICImportAndExportReasonID and ier.AAStatus = 'Alive'
			OUTER APPLY (SELECT TOP 1 a.FK_ACAccountID
							FROM dbo.ACTransactions a
							WHERE a.AAStatus = 'Alive'
								AND a.ACTransactionNo = (SELECT APInvoiceInNo FROM dbo.APInvoiceIns WHERE APInvoiceInID = ii.FK_APInvoiceInID)
								AND a.ACTransactionDebitAmount > 0
								AND a.ACTransactionPostingGroup = 1) AS iv
			OUTER APPLY	(
							SELECT bi.* FROM dbo.APBillOfLadingItems bi
							WHERE bi.AAStatus = 'Alive'
							AND bi.APBillOfLadingItemID = ii.FK_APBillOfLadingItemID
							) AS bol
		where	ii.AAStatus			= 'Alive'
				and FK_ICReceiptID	= @ReceiptID	
					
		DECLARE  @TotalQty  decimal(18,5)
		SET  @TotalQty = (SELECT ISNULL(SUM(ReceiptItemProductQty), 0.000) FROM @ReceiptItemTable)
		
		DECLARE @ReceiptOutSourcingTotalCost DECIMAL(18,5) = (SELECT TOP 1 ISNULL((@ReceiptProportion / @ReceiptRemainProportion) * (ReceiptItemShipmentTotalCost - ReceiptItemShipmentTotalReceiptCost), 0.000)
																FROM @ReceiptItemTable)

		UPDATE @ReceiptItemTable
		SET ReceiptOutSourcingCost = ISNULL(((@ReceiptProportion / @ReceiptRemainProportion) * (ReceiptItemProductQty / @TotalQty) * (ReceiptItemShipmentTotalCost - ReceiptItemShipmentTotalReceiptCost)), 0.000)

		DECLARE @ChenhLech DECIMAL(18,5) = @ReceiptOutSourcingTotalCost - (SELECT SUM(ReceiptOutSourcingCost) FROM @ReceiptItemTable)
		IF (ISNULL(@ChenhLech,0) <> 0)
		BEGIN
			UPDATE @ReceiptItemTable
			SET ReceiptOutSourcingCost = ReceiptOutSourcingCost + @ChenhLech
			WHERE ReceiptItemID = (SELECT MAX(ReceiptItemID) FROM @ReceiptItemTable)
		END
		
		--Update Chênh lệch chiết khấu--
		SET  @ChenhLech = @ReceiptDiscountAmount - (SELECT SUM(ReceiptDiscountAmount) FROM @ReceiptItemTable )		
		IF (ISNULL(@ChenhLech,0) <> 0)
		BEGIN 
			UPDATE r
			SET r.ReceiptDiscountAmount = r.ReceiptDiscountAmount + @ChenhLech
			FROM @ReceiptItemTable r
			WHERE ReceiptItemID = (SELECT MAX(ReceiptItemID) FROM @ReceiptItemTable)
		END	

		--Update Chênh lệch chi phí cont--
		SET  @ChenhLech = @ReceiptContTotalFees - (SELECT SUM(ReceiptItemContFees) FROM @ReceiptItemTable )		
		IF (ISNULL(@ChenhLech,0) <> 0)
		BEGIN 
			UPDATE r
			SET r.ReceiptItemContFees = r.ReceiptItemContFees + @ChenhLech
			FROM @ReceiptItemTable r
			WHERE ReceiptItemID = (SELECT MAX(ReceiptItemID) FROM @ReceiptItemTable)
		END	

		--Update Chênh lệch chi phí vận chuyển--
		SET  @ChenhLech = @ReceiptShippingFees - (SELECT SUM(ReceiptItemShippingFees) FROM @ReceiptItemTable )		
		IF (ISNULL(@ChenhLech,0) <> 0)
		BEGIN 
			UPDATE r
			SET r.ReceiptItemShippingFees = r.ReceiptItemShippingFees + @ChenhLech
			FROM @ReceiptItemTable r
			WHERE ReceiptItemID = (SELECT MAX(ReceiptItemID) FROM @ReceiptItemTable)
		END	

		--get object Purchase account id
		declare @FK_ACObjAccountPurchaseID int
		set @FK_ACObjAccountPurchaseID = dbo.ACObjects_GetObjectPurchaseAccountIDByIDAndType(@ObjectID, @ObjectType)

		-- Kiểm tra khóa số liệu và ngày đầu kỳ nhập liệu
		declare @IsValidDocuentDate bit
		set @IsValidDocuentDate	= dbo.ACTransactions_IsValidDocumentTransactionDate(@ReceiptDate)
			
		if(@IsValidDocuentDate = 0)
			return;
		
		-- Xóa post cũ
		exec ACTransactions_DeleteByDocumentTranNo @ReceiptNo
		
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
		 declare @ReceiptItemsToPostTable table
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
			FK_APPurchaseOrderID				int,
			FK_APInvoiceInID					int,
			FK_MMBatchProductID					int,
			FK_MMOperationID					int,
			FK_HRDepartmentRoomGroupItemID		int,
			FK_HRDepartmentRoomGroupID			int,
			FK_MMLineID							int,
			FK_MMWorkShopID						int,
			FK_ACUnfinishedConstructionCostID	int,
			K_ACCostObjectID					int,
			ICReceiptItemCode01Combo			nvarchar(256),
			ICReceiptItemCode02Combo			nvarchar(256),
			ICReceiptItemCode03Combo			nvarchar(256),
			ICReceiptItemCode04Combo			nvarchar(256),
			ICReceiptItemCode05Combo			nvarchar(256),
			ICReceiptItemCode06Combo			nvarchar(256),
			ICReceiptItemCode07Combo			nvarchar(256),
			ICReceiptItemCode08Combo			nvarchar(256),
			ICReceiptItemCode09Combo			nvarchar(256),
			ICReceiptItemCode10Combo			nvarchar(256)
		 )
		
	declare @RowCount int, @LoopID int
	
	--Get document type entry accounts
	declare @DocTypeEntryAccountTable DocTypeEntryAccountTable
		
	select @RowCount = COUNT(*) from @DocTypeEntryMappingTable
	set @LoopID =  1	
	
	while (@LoopID <= @RowCount)
	begin	
		if(isnull(@DocumentTypeID, 0) <> isnull((select FK_ACDocuemntTypeID from @DocTypeEntryMappingTable where RowID = @LoopID), 0))
		begin
			
			set @DocumentTypeID = isnull((select FK_ACDocuemntTypeID from @DocTypeEntryMappingTable where RowID = @LoopID), 0)
			set @DocumentTypeName = isnull((select DocumentTypeName from @DocTypeEntryMappingTable where RowID = @LoopID), '')
			
			delete from @DocTypeEntryAccountTable
			insert into @DocTypeEntryAccountTable
			exec ACDocTypeEntryAccounts_GetAllDataByDocumentTypeIDAndEntryTypeID @DocumentTypeID, null
		
		end
		
		set @EntryTypeName = (select EntryTypeName from @DocTypeEntryMappingTable where RowID = @LoopID)
		set	@DefaultDebitAccount	= dbo.DocTypeEntryAccountTable_GetDebitAccountByEntryTypeName(@DocTypeEntryAccountTable, @EntryTypeName)		
		set @DefaultCreditAcount	= dbo.DocTypeEntryAccountTable_GetCreditAccountByEntryTypeName(@DocTypeEntryAccountTable, @EntryTypeName)
		set @EntryTypeDesc			= dbo.DocTypeEntryAccountTable_GetEntryTypeDescByEntryTypeName(@DocTypeEntryAccountTable, @EntryTypeName)
		
		IF(@DocumenttypeName = 'NhapKhoMuaHang' or @DocumenttypeName = 'NhapKhoMuaHangHoaDon')
		BEGIN
			IF(@EntryTypeName = 'NhapKhoGiaCong')
			BEGIN
				IF(ISNULL(@ReceiptOutSourcingTotalCost, 0) > 0)
				BEGIN
				insert into @ReceiptItemsToPostTable
				 select (case when ii.FK_ACAccountID = 0
							then @DefaultDebitAccount
						else ii.FK_ACAccountID
						end)
					, (CASE WHEN ii.FK_ACOffsetAccountID = 0
							THEN @DefaultCreditAcount
							ELSE ii.FK_ACOffsetAccountID
						END)
					, SUM(ii.ReceiptOutSourcingCost) / @ReceiptExchangeRate
					, SUM(ii.ReceiptOutSourcingCost)
					, 0
					, 0
					, @ReceiptExchangeRate
					, @EntryTypeName
					, @EntryTypeDesc
					, (@countID / 2) + ROW_NUMBER() OVER ( ORDER BY ( SELECT 1 ) )
					, ii.FK_APPurchaseOrderID
					, ii.FK_APInvoiceInID
					, ii.FK_MMBatchProductID -- BatchProductID
					, ii.FK_MMOperationID
					, ii.FK_HRDepartmentRoomGroupItemID	
					, ii.FK_HRDepartmentRoomGroupID		
					, ii.FK_MMLineID						
					, ii.FK_MMWorkShopID					
					, 0 as FK_ACUnfinishedConstructionCostID
					, ii.FK_ACCostObjectID		
					, 'OutSourcing'
					, ii.ICReceiptItemCode02Combo
					, ii.ICReceiptItemCode03Combo
					, ii.ICReceiptItemCode04Combo
					, ii.ICReceiptItemCode05Combo
					, ii.ICReceiptItemCode06Combo
					, ii.ICReceiptItemCode07Combo
					, ii.ICReceiptItemCode08Combo
					, ii.ICReceiptItemCode09Combo
					, ii.ICReceiptItemCode10Combo			
				 from @ReceiptItemTable ii
				 group by  ii.FK_ACAccountID
					, ii.FK_ACOffsetAccountID
					, ii.FK_APPurchaseOrderID
					, ii.FK_APInvoiceInID
					, ii.FK_MMBatchProductID -- BatchProductID
					, ii.FK_MMOperationID
					, ii.FK_HRDepartmentRoomGroupItemID	
					, ii.FK_HRDepartmentRoomGroupID		
					, ii.FK_MMLineID						
					, ii.FK_MMWorkShopID					
					, FK_ACUnfinishedConstructionCostID
					, ii.FK_ACCostObjectID	
					, ii.ICReceiptItemCode02Combo
					, ii.ICReceiptItemCode03Combo
					, ii.ICReceiptItemCode04Combo
					, ii.ICReceiptItemCode05Combo
					, ii.ICReceiptItemCode06Combo
					, ii.ICReceiptItemCode07Combo
					, ii.ICReceiptItemCode08Combo
					, ii.ICReceiptItemCode09Combo
					, ii.ICReceiptItemCode10Combo				
				 order by  ii.FK_ACAccountID
					, ii.FK_ACOffsetAccountID
					, ii.FK_APPurchaseOrderID
					, ii.FK_APInvoiceInID
					, ii.FK_MMBatchProductID -- BatchProductID
					, ii.FK_MMOperationID
					, ii.FK_HRDepartmentRoomGroupItemID	
					, ii.FK_HRDepartmentRoomGroupID		
					, ii.FK_MMLineID						
					, ii.FK_MMWorkShopID					
					, FK_ACUnfinishedConstructionCostID
					, ii.FK_ACCostObjectID
					, ii.ICReceiptItemCode02Combo
					, ii.ICReceiptItemCode03Combo
					, ii.ICReceiptItemCode04Combo
					, ii.ICReceiptItemCode05Combo
					, ii.ICReceiptItemCode06Combo
					, ii.ICReceiptItemCode07Combo
					, ii.ICReceiptItemCode08Combo
					, ii.ICReceiptItemCode09Combo
					, ii.ICReceiptItemCode10Combo		

				insert into @ReceiptItemsToPostTable
				 select 
					(CASE WHEN ii.FK_ACOffsetAccountID = 0
							THEN @DefaultCreditAcount
							ELSE ii.FK_ACOffsetAccountID
						END)
					, (case when ii.FK_ACAccountID = 0
							then @DefaultDebitAccount
						else ii.FK_ACAccountID
						end)				
					, 0
					, 0				
					, SUM(ii.ReceiptOutSourcingCost) / @ReceiptExchangeRate
					, SUM(ii.ReceiptOutSourcingCost)
					, @ReceiptExchangeRate
					, @EntryTypeName
					, @EntryTypeDesc
					, (@countID / 2) + ROW_NUMBER() OVER ( ORDER BY ( SELECT 1 ) )
					, ii.FK_APPurchaseOrderID
					, ii.FK_APInvoiceInID
					, ii.FK_MMBatchProductID -- BatchProductID
					, ii.FK_MMOperationID
					, ii.FK_HRDepartmentRoomGroupItemID	
					, ii.FK_HRDepartmentRoomGroupID		
					, ii.FK_MMLineID						
					, ii.FK_MMWorkShopID					
					, 0 as FK_ACUnfinishedConstructionCostID
					, ii.FK_ACCostObjectID		
					, 'OutSourcing'
					, ii.ICReceiptItemCode02Combo
					, ii.ICReceiptItemCode03Combo
					, ii.ICReceiptItemCode04Combo
					, ii.ICReceiptItemCode05Combo
					, ii.ICReceiptItemCode06Combo
					, ii.ICReceiptItemCode07Combo
					, ii.ICReceiptItemCode08Combo
					, ii.ICReceiptItemCode09Combo
					, ii.ICReceiptItemCode10Combo			
				 from @ReceiptItemTable ii
				 group by  ii.FK_ACAccountID
					, ii.FK_ACOffsetAccountID
					, ii.FK_APPurchaseOrderID
					, ii.FK_APInvoiceInID
					, ii.FK_MMBatchProductID -- BatchProductID
					, ii.FK_MMOperationID
					, ii.FK_HRDepartmentRoomGroupItemID	
					, ii.FK_HRDepartmentRoomGroupID		
					, ii.FK_MMLineID						
					, ii.FK_MMWorkShopID					
					, FK_ACUnfinishedConstructionCostID
					, ii.FK_ACCostObjectID	
					, ii.ICReceiptItemCode02Combo
					, ii.ICReceiptItemCode03Combo
					, ii.ICReceiptItemCode04Combo
					, ii.ICReceiptItemCode05Combo
					, ii.ICReceiptItemCode06Combo
					, ii.ICReceiptItemCode07Combo
					, ii.ICReceiptItemCode08Combo
					, ii.ICReceiptItemCode09Combo
					, ii.ICReceiptItemCode10Combo				
				 order by  ii.FK_ACAccountID
					, ii.FK_ACOffsetAccountID
					, ii.FK_APPurchaseOrderID
					, ii.FK_APInvoiceInID
					, ii.FK_MMBatchProductID -- BatchProductID
					, ii.FK_MMOperationID
					, ii.FK_HRDepartmentRoomGroupItemID	
					, ii.FK_HRDepartmentRoomGroupID		
					, ii.FK_MMLineID						
					, ii.FK_MMWorkShopID					
					, FK_ACUnfinishedConstructionCostID
					, ii.FK_ACCostObjectID	
					, ii.ICReceiptItemCode02Combo
					, ii.ICReceiptItemCode03Combo
					, ii.ICReceiptItemCode04Combo
					, ii.ICReceiptItemCode05Combo
					, ii.ICReceiptItemCode06Combo
					, ii.ICReceiptItemCode07Combo
					, ii.ICReceiptItemCode08Combo
					, ii.ICReceiptItemCode09Combo
					, ii.ICReceiptItemCode10Combo
				END
			END
			ELSE IF(@EntryTypeName = 'ChiPhiMuaHangNhapKhau')
			BEGIN
				insert into @ReceiptItemsToPostTable
				 select (case when ii.FK_ACAccountID = 0
							then @DefaultDebitAccount
						else ii.FK_ACAccountID
						end)
					, (case when ii.FK_ACAccountDebitInvoiceInID = 0
							then @DefaultCreditAcount
						else ii.FK_ACAccountDebitInvoiceInID
						end)
					, SUM(ii.ReceiptItemContFees) / @ReceiptExchangeRate
					, sum(ii.ReceiptItemContFees)
					, 0
					, 0
					, @ReceiptExchangeRate
					, @EntryTypeName
					, @EntryTypeDesc
					, (@countID / 2) + ROW_NUMBER() OVER ( ORDER BY ( SELECT 1 ) )
					, ii.FK_APPurchaseOrderID
					, ii.FK_APInvoiceInID
					, ii.FK_MMBatchProductID -- BatchProductID
					, ii.FK_MMOperationID
					, ii.FK_HRDepartmentRoomGroupItemID	
					, ii.FK_HRDepartmentRoomGroupID		
					, ii.FK_MMLineID						
					, ii.FK_MMWorkShopID					
					, 0 as FK_ACUnfinishedConstructionCostID
					, ii.FK_ACCostObjectID		
					, ii.ICReceiptItemCode01Combo
					, ii.ICReceiptItemCode02Combo
					, ii.ICReceiptItemCode03Combo
					, ii.ICReceiptItemCode04Combo
					, ii.ICReceiptItemCode05Combo
					, ii.ICReceiptItemCode06Combo
					, ii.ICReceiptItemCode07Combo
					, ii.ICReceiptItemCode08Combo
					, ii.ICReceiptItemCode09Combo
					, ii.ICReceiptItemCode10Combo			
				 from @ReceiptItemTable ii
				 WHERE ii.ReceiptItemContFees > 0
				 group by  
					 ii.FK_ACAccountID
					, ii.FK_APPurchaseOrderID
					, ii.FK_APInvoiceInID
					, ii.FK_MMBatchProductID -- BatchProductID
					, ii.FK_MMOperationID
					, ii.FK_HRDepartmentRoomGroupItemID	
					, ii.FK_HRDepartmentRoomGroupID		
					, ii.FK_MMLineID						
					, ii.FK_MMWorkShopID					
					, FK_ACUnfinishedConstructionCostID
					, ii.FK_ACCostObjectID	
					, ii.FK_ACAccountDebitInvoiceInID
					, ii.ICReceiptItemCode01Combo
					, ii.ICReceiptItemCode02Combo
					, ii.ICReceiptItemCode03Combo
					, ii.ICReceiptItemCode04Combo
					, ii.ICReceiptItemCode05Combo
					, ii.ICReceiptItemCode06Combo
					, ii.ICReceiptItemCode07Combo
					, ii.ICReceiptItemCode08Combo
					, ii.ICReceiptItemCode09Combo
					, ii.ICReceiptItemCode10Combo				
				 order by  ii.FK_ACAccountID
					, ii.FK_APPurchaseOrderID
					, ii.FK_APInvoiceInID
					, ii.FK_MMBatchProductID -- BatchProductID
					, ii.FK_MMOperationID
					, ii.FK_HRDepartmentRoomGroupItemID	
					, ii.FK_HRDepartmentRoomGroupID		
					, ii.FK_MMLineID						
					, ii.FK_MMWorkShopID					
					, FK_ACUnfinishedConstructionCostID
					, ii.FK_ACCostObjectID		
					, ii.FK_ACAccountDebitInvoiceInID
					, ii.ICReceiptItemCode01Combo
					, ii.ICReceiptItemCode02Combo
					, ii.ICReceiptItemCode03Combo
					, ii.ICReceiptItemCode04Combo
					, ii.ICReceiptItemCode05Combo
					, ii.ICReceiptItemCode06Combo
					, ii.ICReceiptItemCode07Combo
					, ii.ICReceiptItemCode08Combo
					, ii.ICReceiptItemCode09Combo
					, ii.ICReceiptItemCode10Combo		

				insert into @ReceiptItemsToPostTable
				 select  (case when ii.FK_ACAccountDebitInvoiceInID = 0
							then @DefaultCreditAcount
						else ii.FK_ACAccountDebitInvoiceInID
						end)
					, (case when ii.FK_ACAccountID = 0
							then @DefaultDebitAccount
						else ii.FK_ACAccountID
						end)				
					, 0
					, 0				
					, SUM(ii.ReceiptItemContFees) / @ReceiptExchangeRate
					, sum(ii.ReceiptItemContFees)
					, @ReceiptExchangeRate
					, @EntryTypeName
					, @EntryTypeDesc
					, (@countID / 2) + ROW_NUMBER() OVER ( ORDER BY ( SELECT 1 ) )
					, ii.FK_APPurchaseOrderID
					, ii.FK_APInvoiceInID
					, ii.FK_MMBatchProductID -- BatchProductID
					, ii.FK_MMOperationID
					, ii.FK_HRDepartmentRoomGroupItemID	
					, ii.FK_HRDepartmentRoomGroupID		
					, ii.FK_MMLineID						
					, ii.FK_MMWorkShopID					
					, 0 as FK_ACUnfinishedConstructionCostID
					, ii.FK_ACCostObjectID		
					, ii.ICReceiptItemCode01Combo
					, ii.ICReceiptItemCode02Combo
					, ii.ICReceiptItemCode03Combo
					, ii.ICReceiptItemCode04Combo
					, ii.ICReceiptItemCode05Combo
					, ii.ICReceiptItemCode06Combo
					, ii.ICReceiptItemCode07Combo
					, ii.ICReceiptItemCode08Combo
					, ii.ICReceiptItemCode09Combo
					, ii.ICReceiptItemCode10Combo			
				 from @ReceiptItemTable ii
				 WHERE ii.ReceiptItemContFees > 0
				 group by  
					 ii.FK_ACAccountID
					, ii.FK_APPurchaseOrderID
					, ii.FK_APInvoiceInID
					, ii.FK_MMBatchProductID -- BatchProductID
					, ii.FK_MMOperationID
					, ii.FK_HRDepartmentRoomGroupItemID	
					, ii.FK_HRDepartmentRoomGroupID		
					, ii.FK_MMLineID						
					, ii.FK_MMWorkShopID					
					, FK_ACUnfinishedConstructionCostID
					, ii.FK_ACCostObjectID		
					, ii.FK_ACAccountDebitInvoiceInID
					, ii.ICReceiptItemCode01Combo
					, ii.ICReceiptItemCode02Combo
					, ii.ICReceiptItemCode03Combo
					, ii.ICReceiptItemCode04Combo
					, ii.ICReceiptItemCode05Combo
					, ii.ICReceiptItemCode06Combo
					, ii.ICReceiptItemCode07Combo
					, ii.ICReceiptItemCode08Combo
					, ii.ICReceiptItemCode09Combo
					, ii.ICReceiptItemCode10Combo				
				 order by  ii.FK_ACAccountID
					, ii.FK_APPurchaseOrderID
					, ii.FK_APInvoiceInID
					, ii.FK_MMBatchProductID -- BatchProductID
					, ii.FK_MMOperationID
					, ii.FK_HRDepartmentRoomGroupItemID	
					, ii.FK_HRDepartmentRoomGroupID		
					, ii.FK_MMLineID						
					, ii.FK_MMWorkShopID					
					, FK_ACUnfinishedConstructionCostID
					, ii.FK_ACCostObjectID		
					, ii.FK_ACAccountDebitInvoiceInID
					, ii.ICReceiptItemCode01Combo
					, ii.ICReceiptItemCode02Combo
					, ii.ICReceiptItemCode03Combo
					, ii.ICReceiptItemCode04Combo
					, ii.ICReceiptItemCode05Combo
					, ii.ICReceiptItemCode06Combo
					, ii.ICReceiptItemCode07Combo
					, ii.ICReceiptItemCode08Combo
					, ii.ICReceiptItemCode09Combo
					, ii.ICReceiptItemCode10Combo
			END
			ELSE IF (@EntryTypeName LIKE N'Thue%')
			BEGIN
				insert into @ReceiptItemsToPostTable
				 select (case when ii.FK_ACAccountID = 0
							then @DefaultDebitAccount
						else ii.FK_ACAccountID
						end)
					, (case when @EntryTypeName = 'ThueXNK'
							then ii.FK_ACImportTaxAccountID
						WHEN @EntryTypeName = 'ThueTieuThu'
							THEN ii.FK_ACConsumptionTaxAccountID
						WHEN @EntryTypeName = 'ThueBaoVeMoiTruong'
							THEN ii.FK_ACEnvironmentTaxAccountID
						else @DefaultCreditAcount
						end)
					, sum(case when @EntryTypeName = 'ThueXNK'
							then ii.ReceiptItemImportTaxAmount
						WHEN @EntryTypeName = 'ThueTieuThu'
							THEN ii.ReceiptItemConsumptionTaxAmount
						WHEN @EntryTypeName = 'ThueBaoVeMoiTruong'
							THEN ii.ReceiptItemEnvironmentTaxAmount
						end) / @ReceiptExchangeRate
					, sum(case when @EntryTypeName = 'ThueXNK'
							then ii.ReceiptItemImportTaxAmount
						WHEN @EntryTypeName = 'ThueTieuThu'
							THEN ii.ReceiptItemConsumptionTaxAmount
						WHEN @EntryTypeName = 'ThueBaoVeMoiTruong'
							THEN ii.ReceiptItemEnvironmentTaxAmount
						end)
					, 0
					, 0
					, @ReceiptExchangeRate
					, @EntryTypeName
					, @EntryTypeDesc
					, (@countID / 2) + ROW_NUMBER() OVER ( ORDER BY ( SELECT 1 ) )
					, ii.FK_APPurchaseOrderID
					, ii.FK_APInvoiceInID
					, ii.FK_MMBatchProductID -- BatchProductID
					, ii.FK_MMOperationID
					, ii.FK_HRDepartmentRoomGroupItemID	
					, ii.FK_HRDepartmentRoomGroupID		
					, ii.FK_MMLineID						
					, ii.FK_MMWorkShopID					
					, 0 as FK_ACUnfinishedConstructionCostID
					, ii.FK_ACCostObjectID		
					, ii.ICReceiptItemCode01Combo
					, ii.ICReceiptItemCode02Combo
					, ii.ICReceiptItemCode03Combo
					, ii.ICReceiptItemCode04Combo
					, ii.ICReceiptItemCode05Combo
					, ii.ICReceiptItemCode06Combo
					, ii.ICReceiptItemCode07Combo
					, ii.ICReceiptItemCode08Combo
					, ii.ICReceiptItemCode09Combo
					, ii.ICReceiptItemCode10Combo			
				 from @ReceiptItemTable ii
				 WHERE ii.ReceiptItemImportTaxAmount > 0 OR ii.ReceiptItemConsumptionTaxAmount > 0 OR ii.ReceiptItemEnvironmentTaxAmount > 0
				 AND ii.FK_APBillOfLadingItemID > 0
				 group by  
					 ii.FK_ACAccountID
					, ii.FK_APPurchaseOrderID
					, ii.FK_APInvoiceInID
					, ii.FK_MMBatchProductID -- BatchProductID
					, ii.FK_MMOperationID
					, ii.FK_HRDepartmentRoomGroupItemID	
					, ii.FK_HRDepartmentRoomGroupID		
					, ii.FK_MMLineID						
					, ii.FK_MMWorkShopID					
					, FK_ACUnfinishedConstructionCostID
					, ii.FK_ACCostObjectID	
					, ii.FK_ACAccountDebitInvoiceInID
					, ii.ICReceiptItemCode01Combo
					, ii.ICReceiptItemCode02Combo
					, ii.ICReceiptItemCode03Combo
					, ii.ICReceiptItemCode04Combo
					, ii.ICReceiptItemCode05Combo
					, ii.ICReceiptItemCode06Combo
					, ii.ICReceiptItemCode07Combo
					, ii.ICReceiptItemCode08Combo
					, ii.ICReceiptItemCode09Combo
					, ii.ICReceiptItemCode10Combo		
					, ii.FK_ACImportTaxAccountID
					, ii.FK_ACConsumptionTaxAccountID
					, ii.FK_ACEnvironmentTaxAccountID
				 order by  ii.FK_ACAccountID
					, ii.FK_APPurchaseOrderID
					, ii.FK_APInvoiceInID
					, ii.FK_MMBatchProductID -- BatchProductID
					, ii.FK_MMOperationID
					, ii.FK_HRDepartmentRoomGroupItemID	
					, ii.FK_HRDepartmentRoomGroupID		
					, ii.FK_MMLineID						
					, ii.FK_MMWorkShopID					
					, FK_ACUnfinishedConstructionCostID
					, ii.FK_ACCostObjectID		
					, ii.FK_ACAccountDebitInvoiceInID
					, ii.ICReceiptItemCode01Combo
					, ii.ICReceiptItemCode02Combo
					, ii.ICReceiptItemCode03Combo
					, ii.ICReceiptItemCode04Combo
					, ii.ICReceiptItemCode05Combo
					, ii.ICReceiptItemCode06Combo
					, ii.ICReceiptItemCode07Combo
					, ii.ICReceiptItemCode08Combo
					, ii.ICReceiptItemCode09Combo
					, ii.ICReceiptItemCode10Combo
					, ii.FK_ACImportTaxAccountID
					, ii.FK_ACConsumptionTaxAccountID
					, ii.FK_ACEnvironmentTaxAccountID		

				insert into @ReceiptItemsToPostTable
				 select  (case when @EntryTypeName = 'ThueXNK'
							then ii.FK_ACImportTaxAccountID
						WHEN @EntryTypeName = 'ThueTieuThu'
							THEN ii.FK_ACConsumptionTaxAccountID
						WHEN @EntryTypeName = 'ThueBaoVeMoiTruong'
							THEN ii.FK_ACEnvironmentTaxAccountID
						else @DefaultCreditAcount
						end)
					, (case when ii.FK_ACAccountID = 0
							then @DefaultDebitAccount
						else ii.FK_ACAccountID
						end)				
					, 0
					, 0				
					, sum(case when @EntryTypeName = 'ThueXNK'
							then ii.ReceiptItemImportTaxAmount
						WHEN @EntryTypeName = 'ThueTieuThu'
							THEN ii.ReceiptItemConsumptionTaxAmount
						WHEN @EntryTypeName = 'ThueBaoVeMoiTruong'
							THEN ii.ReceiptItemEnvironmentTaxAmount
						end) / @ReceiptExchangeRate
					, sum(case when @EntryTypeName = 'ThueXNK'
							then ii.ReceiptItemImportTaxAmount
						WHEN @EntryTypeName = 'ThueTieuThu'
							THEN ii.ReceiptItemConsumptionTaxAmount
						WHEN @EntryTypeName = 'ThueBaoVeMoiTruong'
							THEN ii.ReceiptItemEnvironmentTaxAmount
						end)
					, @ReceiptExchangeRate
					, @EntryTypeName
					, @EntryTypeDesc
					, (@countID / 2) + ROW_NUMBER() OVER ( ORDER BY ( SELECT 1 ) )
					, ii.FK_APPurchaseOrderID
					, ii.FK_APInvoiceInID
					, ii.FK_MMBatchProductID -- BatchProductID
					, ii.FK_MMOperationID
					, ii.FK_HRDepartmentRoomGroupItemID	
					, ii.FK_HRDepartmentRoomGroupID		
					, ii.FK_MMLineID						
					, ii.FK_MMWorkShopID					
					, 0 as FK_ACUnfinishedConstructionCostID
					, ii.FK_ACCostObjectID		
					, ii.ICReceiptItemCode01Combo
					, ii.ICReceiptItemCode02Combo
					, ii.ICReceiptItemCode03Combo
					, ii.ICReceiptItemCode04Combo
					, ii.ICReceiptItemCode05Combo
					, ii.ICReceiptItemCode06Combo
					, ii.ICReceiptItemCode07Combo
					, ii.ICReceiptItemCode08Combo
					, ii.ICReceiptItemCode09Combo
					, ii.ICReceiptItemCode10Combo		
				 from @ReceiptItemTable ii
				 WHERE ii.ReceiptItemImportTaxAmount > 0 OR ii.ReceiptItemConsumptionTaxAmount > 0 OR ii.ReceiptItemEnvironmentTaxAmount > 0
				 AND ii.FK_APBillOfLadingItemID > 0
				 group by  
					 ii.FK_ACAccountID
					, ii.FK_APPurchaseOrderID
					, ii.FK_APInvoiceInID
					, ii.FK_MMBatchProductID -- BatchProductID
					, ii.FK_MMOperationID
					, ii.FK_HRDepartmentRoomGroupItemID	
					, ii.FK_HRDepartmentRoomGroupID		
					, ii.FK_MMLineID						
					, ii.FK_MMWorkShopID					
					, FK_ACUnfinishedConstructionCostID
					, ii.FK_ACCostObjectID		
					, ii.FK_ACAccountDebitInvoiceInID
					, ii.ICReceiptItemCode01Combo
					, ii.ICReceiptItemCode02Combo
					, ii.ICReceiptItemCode03Combo
					, ii.ICReceiptItemCode04Combo
					, ii.ICReceiptItemCode05Combo
					, ii.ICReceiptItemCode06Combo
					, ii.ICReceiptItemCode07Combo
					, ii.ICReceiptItemCode08Combo
					, ii.ICReceiptItemCode09Combo
					, ii.ICReceiptItemCode10Combo
					, ii.FK_ACImportTaxAccountID
					, ii.FK_ACConsumptionTaxAccountID
					, ii.FK_ACEnvironmentTaxAccountID				
				 order by  ii.FK_ACAccountID
					, ii.FK_APPurchaseOrderID
					, ii.FK_APInvoiceInID
					, ii.FK_MMBatchProductID -- BatchProductID
					, ii.FK_MMOperationID
					, ii.FK_HRDepartmentRoomGroupItemID	
					, ii.FK_HRDepartmentRoomGroupID		
					, ii.FK_MMLineID						
					, ii.FK_MMWorkShopID					
					, FK_ACUnfinishedConstructionCostID
					, ii.FK_ACCostObjectID		
					, ii.FK_ACAccountDebitInvoiceInID
					, ii.ICReceiptItemCode01Combo
					, ii.ICReceiptItemCode02Combo
					, ii.ICReceiptItemCode03Combo
					, ii.ICReceiptItemCode04Combo
					, ii.ICReceiptItemCode05Combo
					, ii.ICReceiptItemCode06Combo
					, ii.ICReceiptItemCode07Combo
					, ii.ICReceiptItemCode08Combo
					, ii.ICReceiptItemCode09Combo
					, ii.ICReceiptItemCode10Combo
					, ii.FK_ACImportTaxAccountID
					, ii.FK_ACConsumptionTaxAccountID
					, ii.FK_ACEnvironmentTaxAccountID
			END
			ELSE
			BEGIN
				insert into @ReceiptItemsToPostTable
				 select (case when ii.FK_ACAccountID = 0
							then @DefaultDebitAccount
						else ii.FK_ACAccountID
						end)
					, @DefaultCreditAcount
					, SUM((ii.ReceiptItemProductQty * ii.ReceiptItemProductUnitCost) - ii.ReceiptItemDiscountAmount - ii.ReceiptDiscountAmount + ii.ReceiptItemShippingFees)
					, SUM((ii.ReceiptItemProductQty * ii.ReceiptItemProductUnitCost) - ii.ReceiptItemDiscountAmount - ii.ReceiptDiscountAmount + ii.ReceiptItemShippingFees) * @ReceiptExchangeRate
					, 0
					, 0
					, @ReceiptExchangeRate
					, @EntryTypeName
					, @EntryTypeDesc
					, (@countID / 2) + ROW_NUMBER() OVER ( ORDER BY ( SELECT 1 ) )
					, ii.FK_APPurchaseOrderID
					, ii.FK_APInvoiceInID
					, ii.FK_MMBatchProductID -- BatchProductID
					, ii.FK_MMOperationID
					, ii.FK_HRDepartmentRoomGroupItemID	
					, ii.FK_HRDepartmentRoomGroupID		
					, ii.FK_MMLineID						
					, ii.FK_MMWorkShopID					
					, 0 as FK_ACUnfinishedConstructionCostID
					, ii.FK_ACCostObjectID		
					, ii.ICReceiptItemCode01Combo
					, ii.ICReceiptItemCode02Combo
					, ii.ICReceiptItemCode03Combo
					, ii.ICReceiptItemCode04Combo
					, ii.ICReceiptItemCode05Combo
					, ii.ICReceiptItemCode06Combo
					, ii.ICReceiptItemCode07Combo
					, ii.ICReceiptItemCode08Combo
					, ii.ICReceiptItemCode09Combo
					, ii.ICReceiptItemCode10Combo			
				 from @ReceiptItemTable ii
				 group by  
					 ii.FK_ACAccountID
					, ii.FK_APPurchaseOrderID
					, ii.FK_APInvoiceInID
					, ii.FK_MMBatchProductID -- BatchProductID
					, ii.FK_MMOperationID
					, ii.FK_HRDepartmentRoomGroupItemID	
					, ii.FK_HRDepartmentRoomGroupID		
					, ii.FK_MMLineID						
					, ii.FK_MMWorkShopID					
					, FK_ACUnfinishedConstructionCostID
					, ii.FK_ACCostObjectID		
					, ii.ICReceiptItemCode01Combo
					, ii.ICReceiptItemCode02Combo
					, ii.ICReceiptItemCode03Combo
					, ii.ICReceiptItemCode04Combo
					, ii.ICReceiptItemCode05Combo
					, ii.ICReceiptItemCode06Combo
					, ii.ICReceiptItemCode07Combo
					, ii.ICReceiptItemCode08Combo
					, ii.ICReceiptItemCode09Combo
					, ii.ICReceiptItemCode10Combo				
				 order by  ii.FK_ACAccountID
					, ii.FK_APPurchaseOrderID
					, ii.FK_APInvoiceInID
					, ii.FK_MMBatchProductID -- BatchProductID
					, ii.FK_MMOperationID
					, ii.FK_HRDepartmentRoomGroupItemID	
					, ii.FK_HRDepartmentRoomGroupID		
					, ii.FK_MMLineID						
					, ii.FK_MMWorkShopID					
					, FK_ACUnfinishedConstructionCostID
					, ii.FK_ACCostObjectID		
					, ii.ICReceiptItemCode01Combo
					, ii.ICReceiptItemCode02Combo
					, ii.ICReceiptItemCode03Combo
					, ii.ICReceiptItemCode04Combo
					, ii.ICReceiptItemCode05Combo
					, ii.ICReceiptItemCode06Combo
					, ii.ICReceiptItemCode07Combo
					, ii.ICReceiptItemCode08Combo
					, ii.ICReceiptItemCode09Combo
					, ii.ICReceiptItemCode10Combo		

				insert into @ReceiptItemsToPostTable
				 select 
					@DefaultCreditAcount
					, (case when ii.FK_ACAccountID = 0
							then @DefaultDebitAccount
						else ii.FK_ACAccountID
						end)				
					, 0
					, 0				
					, SUM((ii.ReceiptItemProductQty * ii.ReceiptItemProductUnitCost) - ii.ReceiptItemDiscountAmount - ii.ReceiptDiscountAmount + ii.ReceiptItemShippingFees)
					, SUM((ii.ReceiptItemProductQty * ii.ReceiptItemProductUnitCost) - ii.ReceiptItemDiscountAmount - ii.ReceiptDiscountAmount + ii.ReceiptItemShippingFees) * @ReceiptExchangeRate
					, @ReceiptExchangeRate
					, @EntryTypeName
					, @EntryTypeDesc
					, (@countID / 2) + ROW_NUMBER() OVER ( ORDER BY ( SELECT 1 ) )
					, ii.FK_APPurchaseOrderID
					, ii.FK_APInvoiceInID
					, ii.FK_MMBatchProductID -- BatchProductID
					, ii.FK_MMOperationID
					, ii.FK_HRDepartmentRoomGroupItemID	
					, ii.FK_HRDepartmentRoomGroupID		
					, ii.FK_MMLineID						
					, ii.FK_MMWorkShopID					
					, 0 as FK_ACUnfinishedConstructionCostID
					, ii.FK_ACCostObjectID		
					, ii.ICReceiptItemCode01Combo
					, ii.ICReceiptItemCode02Combo
					, ii.ICReceiptItemCode03Combo
					, ii.ICReceiptItemCode04Combo
					, ii.ICReceiptItemCode05Combo
					, ii.ICReceiptItemCode06Combo
					, ii.ICReceiptItemCode07Combo
					, ii.ICReceiptItemCode08Combo
					, ii.ICReceiptItemCode09Combo
					, ii.ICReceiptItemCode10Combo			
				 from @ReceiptItemTable ii
				 group by  
					 ii.FK_ACAccountID
					, ii.FK_APPurchaseOrderID
					, ii.FK_APInvoiceInID
					, ii.FK_MMBatchProductID -- BatchProductID
					, ii.FK_MMOperationID
					, ii.FK_HRDepartmentRoomGroupItemID	
					, ii.FK_HRDepartmentRoomGroupID		
					, ii.FK_MMLineID						
					, ii.FK_MMWorkShopID					
					, FK_ACUnfinishedConstructionCostID
					, ii.FK_ACCostObjectID		
					, ii.ICReceiptItemCode01Combo
					, ii.ICReceiptItemCode02Combo
					, ii.ICReceiptItemCode03Combo
					, ii.ICReceiptItemCode04Combo
					, ii.ICReceiptItemCode05Combo
					, ii.ICReceiptItemCode06Combo
					, ii.ICReceiptItemCode07Combo
					, ii.ICReceiptItemCode08Combo
					, ii.ICReceiptItemCode09Combo
					, ii.ICReceiptItemCode10Combo				
				 order by  ii.FK_ACAccountID
					, ii.FK_APPurchaseOrderID
					, ii.FK_APInvoiceInID
					, ii.FK_MMBatchProductID -- BatchProductID
					, ii.FK_MMOperationID
					, ii.FK_HRDepartmentRoomGroupItemID	
					, ii.FK_HRDepartmentRoomGroupID		
					, ii.FK_MMLineID						
					, ii.FK_MMWorkShopID					
					, FK_ACUnfinishedConstructionCostID
					, ii.FK_ACCostObjectID		
					, ii.ICReceiptItemCode01Combo
					, ii.ICReceiptItemCode02Combo
					, ii.ICReceiptItemCode03Combo
					, ii.ICReceiptItemCode04Combo
					, ii.ICReceiptItemCode05Combo
					, ii.ICReceiptItemCode06Combo
					, ii.ICReceiptItemCode07Combo
					, ii.ICReceiptItemCode08Combo
					, ii.ICReceiptItemCode09Combo
					, ii.ICReceiptItemCode10Combo
			END			
		END
		ELSE 
		BEGIN
			insert into @ReceiptItemsToPostTable
			 select (case when ii.FK_ACAccountID = 0
						then @DefaultDebitAccount
					else ii.FK_ACAccountID
					end)
				, (case when ii.FK_ACOffsetAccountID = 0
						then @DefaultCreditAcount						
					else ii.FK_ACOffsetAccountID
					end)
				, (sum((ii.ReceiptItemProductQty * ii.ReceiptItemProductUnitCost ) - ii.ReceiptItemDiscountAmount - ii.ReceiptDiscountAmount))
				, (sum((ii.ReceiptItemProductQty * ii.ReceiptItemProductUnitCost ) - ii.ReceiptItemDiscountAmount - ii.ReceiptDiscountAmount)) * @ReceiptExchangeRate
				, 0
				, 0
				, @ReceiptExchangeRate
				, @EntryTypeName
				, @EntryTypeDesc
				, (@countID / 2) + ROW_NUMBER() OVER ( ORDER BY ( SELECT 1 ) )
				, ii.FK_APPurchaseOrderID
				, ii.FK_APInvoiceInID
				, ii.FK_MMBatchProductID -- BatchProductID
				, ii.FK_MMOperationID
				, ii.FK_HRDepartmentRoomGroupItemID	
				, ii.FK_HRDepartmentRoomGroupID		
				, ii.FK_MMLineID						
				, ii.FK_MMWorkShopID					
				, 0 as FK_ACUnfinishedConstructionCostID
				, ii.FK_ACCostObjectID		
				, ii.ICReceiptItemCode01Combo
				, ii.ICReceiptItemCode02Combo
				, ii.ICReceiptItemCode03Combo
				, ii.ICReceiptItemCode04Combo
				, ii.ICReceiptItemCode05Combo
				, ii.ICReceiptItemCode06Combo
				, ii.ICReceiptItemCode07Combo
				, ii.ICReceiptItemCode08Combo
				, ii.ICReceiptItemCode09Combo
				, ii.ICReceiptItemCode10Combo			
			 from @ReceiptItemTable ii
			 group by  
				 ii.FK_ACAccountID
				, ii.FK_ACOffsetAccountID
				, ii.FK_APPurchaseOrderID
				, ii.FK_APInvoiceInID
				, ii.FK_MMBatchProductID -- BatchProductID
				, ii.FK_MMOperationID
				, ii.FK_HRDepartmentRoomGroupItemID	
				, ii.FK_HRDepartmentRoomGroupID		
				, ii.FK_MMLineID						
				, ii.FK_MMWorkShopID					
				, FK_ACUnfinishedConstructionCostID
				, ii.FK_ACCostObjectID		
				, ii.ICReceiptItemCode01Combo
				, ii.ICReceiptItemCode02Combo
				, ii.ICReceiptItemCode03Combo
				, ii.ICReceiptItemCode04Combo
				, ii.ICReceiptItemCode05Combo
				, ii.ICReceiptItemCode06Combo
				, ii.ICReceiptItemCode07Combo
				, ii.ICReceiptItemCode08Combo
				, ii.ICReceiptItemCode09Combo
				, ii.ICReceiptItemCode10Combo				
			 order by  ii.FK_ACAccountID
				, ii.FK_ACOffsetAccountID
				, ii.FK_APPurchaseOrderID
				, ii.FK_APInvoiceInID
				, ii.FK_MMBatchProductID -- BatchProductID
				, ii.FK_MMOperationID
				, ii.FK_HRDepartmentRoomGroupItemID	
				, ii.FK_HRDepartmentRoomGroupID		
				, ii.FK_MMLineID						
				, ii.FK_MMWorkShopID					
				, FK_ACUnfinishedConstructionCostID
				, ii.FK_ACCostObjectID		
				, ii.ICReceiptItemCode01Combo
				, ii.ICReceiptItemCode02Combo
				, ii.ICReceiptItemCode03Combo
				, ii.ICReceiptItemCode04Combo
				, ii.ICReceiptItemCode05Combo
				, ii.ICReceiptItemCode06Combo
				, ii.ICReceiptItemCode07Combo
				, ii.ICReceiptItemCode08Combo
				, ii.ICReceiptItemCode09Combo
				, ii.ICReceiptItemCode10Combo		

			insert into @ReceiptItemsToPostTable
			 select 
				(case when ii.FK_ACOffsetAccountID = 0
						then @DefaultCreditAcount						
					else ii.FK_ACOffsetAccountID
					end)
				, (case when ii.FK_ACAccountID = 0
						then @DefaultDebitAccount
					else ii.FK_ACAccountID
					end)				
				, 0
				, 0
				, (sum((ii.ReceiptItemProductQty * ii.ReceiptItemProductUnitCost ) - ii.ReceiptItemDiscountAmount - ii.ReceiptDiscountAmount))
				, (sum((ii.ReceiptItemProductQty * ii.ReceiptItemProductUnitCost ) - ii.ReceiptItemDiscountAmount - ii.ReceiptDiscountAmount)) * @ReceiptExchangeRate
				, @ReceiptExchangeRate
				, @EntryTypeName
				, @EntryTypeDesc
				, (@countID / 2) + ROW_NUMBER() OVER ( ORDER BY ( SELECT 1 ) )
				, ii.FK_APPurchaseOrderID
				, ii.FK_APInvoiceInID
				, ii.FK_MMBatchProductID -- BatchProductID
				, ii.FK_MMOperationID
				, ii.FK_HRDepartmentRoomGroupItemID	
				, ii.FK_HRDepartmentRoomGroupID		
				, ii.FK_MMLineID						
				, ii.FK_MMWorkShopID					
				, 0 as FK_ACUnfinishedConstructionCostID
				, ii.FK_ACCostObjectID		
				, ii.ICReceiptItemCode01Combo
				, ii.ICReceiptItemCode02Combo
				, ii.ICReceiptItemCode03Combo
				, ii.ICReceiptItemCode04Combo
				, ii.ICReceiptItemCode05Combo
				, ii.ICReceiptItemCode06Combo
				, ii.ICReceiptItemCode07Combo
				, ii.ICReceiptItemCode08Combo
				, ii.ICReceiptItemCode09Combo
				, ii.ICReceiptItemCode10Combo			
			 from @ReceiptItemTable ii
			 group by  
				 ii.FK_ACAccountID
				, ii.FK_ACOffsetAccountID
				, ii.FK_APPurchaseOrderID
				, ii.FK_APInvoiceInID
				, ii.FK_MMBatchProductID -- BatchProductID
				, ii.FK_MMOperationID
				, ii.FK_HRDepartmentRoomGroupItemID	
				, ii.FK_HRDepartmentRoomGroupID		
				, ii.FK_MMLineID						
				, ii.FK_MMWorkShopID					
				, FK_ACUnfinishedConstructionCostID
				, ii.FK_ACCostObjectID		
				, ii.ICReceiptItemCode01Combo
				, ii.ICReceiptItemCode02Combo
				, ii.ICReceiptItemCode03Combo
				, ii.ICReceiptItemCode04Combo
				, ii.ICReceiptItemCode05Combo
				, ii.ICReceiptItemCode06Combo
				, ii.ICReceiptItemCode07Combo
				, ii.ICReceiptItemCode08Combo
				, ii.ICReceiptItemCode09Combo
				, ii.ICReceiptItemCode10Combo				
			 order by  ii.FK_ACAccountID
				, ii.FK_ACOffsetAccountID
				, ii.FK_APPurchaseOrderID
				, ii.FK_APInvoiceInID
				, ii.FK_MMBatchProductID -- BatchProductID
				, ii.FK_MMOperationID
				, ii.FK_HRDepartmentRoomGroupItemID	
				, ii.FK_HRDepartmentRoomGroupID		
				, ii.FK_MMLineID						
				, ii.FK_MMWorkShopID					
				, FK_ACUnfinishedConstructionCostID
				, ii.FK_ACCostObjectID		
				, ii.ICReceiptItemCode01Combo
				, ii.ICReceiptItemCode02Combo
				, ii.ICReceiptItemCode03Combo
				, ii.ICReceiptItemCode04Combo
				, ii.ICReceiptItemCode05Combo
				, ii.ICReceiptItemCode06Combo
				, ii.ICReceiptItemCode07Combo
				, ii.ICReceiptItemCode08Combo
				, ii.ICReceiptItemCode09Combo
				, ii.ICReceiptItemCode10Combo
		END
		
		select @countID = COUNT(*) from @ReceiptItemsToPostTable
		set @LoopID = @LoopID + 1
	end
	---------- GECurrencyDecimalNumber round -------------------------------------------------------
	declare @RoundNo		decimal(18,5)
	select @RoundNo = ISNULL(GECurrencyDecimalNumber,0) From GECurrencies WHERE GECurrencyID = @FK_GECurrencyID
	---------------------------------
	
	INSERT INTO ACTransactions
	SELECT  'Alive'
			, GETDATE()
			, ''
			, GETDATE()
			, ''
			, @ReceiptID
			, @ReceiptNo
			, @ModuleName
			, ''
			, @ReceiptNo
			, EntryTypeDesc
			, @ReceiptDate
			, @ReceiptNo
			, @ReceiptDate
			, EntryGroup
			, 'Post'			
			, isnull(@FK_EmployeeID, 0)
			, @FK_BRBranchID
			, @FK_CSCompanyBankID
			, @ObjectID
			, @ObjectType
			, isnull(@ReceiptSOContactName,'')
			, isnull(@ReceiptDesc,'')
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
		   , '' --ACTransactionReceiptLotNo
		   , 0	--FK_ACCostCenterID
		   , @FK_ACSegmentID	--FK_ACSegmentID	   
		   , FK_MMBatchProductID	 --FK_MMBatchProductID				
		   , 0		 --FK_ARSaleOrderID			
		   , @FK_HRDepartmentID --FK_HRDepartmentID	
		   , @FK_HRDepartmentRoomID --FK_HRDepartmentRoomID
		   , FK_MMWorkShopID --FK_MMWorkShopID
		   , FK_MMOperationID --FK_MMOperationID
		   , FK_MMLineID --FK_MMLineID
		   , FK_HRDepartmentRoomGroupItemID --FK_HRDepartmentRoomGroupItemID
		   , 0 --FK_PMProjectID
		   , 0 --FK_ACAssetID
		   , 0 --FK_ICProductEquipmentID	
		   , 0 --FK_ACCostObjectID
		   , FK_ACUnfinishedConstructionCostID --FK_ACUnfinishedConstructionCostID
		   , 0  --FK_ACLoanReceiptID
		   , ICReceiptItemCode01Combo	--ACTransactionCode01Combo
		   , ''				
		   , ''				
		   , ''				
		   , ''				
		   , ''				
		   , ''				
		   , ''				
		   , ''				
		   , ''				
	from @ReceiptItemsToPostTable 
	
END




GO


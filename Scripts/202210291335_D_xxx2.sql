SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO

ALTER PROCEDURE [dbo].[ARInvoiceTransactions_GetClearingInfoByInvoiceID]
	@InvoiceID INT = NULL,
	@InvoiceNo NVARCHAR(128),
	@ObjectID	INT,
	@ObjectType	NVARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT *
    FROM dbo.ARInvoiceTransactions d (NOLOCK)
    WHERE d.AAStatus ='Alive'
		AND d.FK_ARInvoiceID = ISNULL(@InvoiceID, 0)
		AND d.ARInvoiceNo = @InvoiceNo
		AND d.FK_ACObjectID = @ObjectID
		AND d.ARObjectType = @ObjectType
		AND d.ARInvoicePaymentAmount > 0
		--AND d.ARInvoiceTransactionMethod IN ('AutoClearing', 'Clearing')
END

GO


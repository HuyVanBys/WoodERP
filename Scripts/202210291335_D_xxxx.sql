SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO

ALTER PROCEDURE [dbo].[ARInvoiceTransactions_GetInvoiceInfoByInvoiceID]
	@InvoiceID	INT = NULL,
	@InvoiceNo	NVARCHAR(128),
	@ObjectID	INT,
	@ObjectType	NVARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;

   SELECT 
			ISNULL(SUM(d.ARInvoiceAmount),0) AS ARInvoiceAmount
		,	ISNULL(SUM(d.ARInvoicePaymentAmount),0) AS ARInvoicePaymentAmount
		,	ISNULL(SUM(d.ARInvoiceAmountExchange),0) AS ARInvoiceAmountExchange -- c
		,	ISNULL(SUM(d.ARInvoicePaymentAmountExchange),0)  AS ARInvoicePaymentAmountExchange
    FROM dbo.ARInvoiceTransactions d (NOLOCK)
    WHERE d.AAStatus ='Alive'
    AND d.FK_ARInvoiceID = ISNULL(@InvoiceID, 0)
	AND d.ARInvoiceNo = @InvoiceNo
	AND d.FK_ACObjectID = @ObjectID
	AND d.ARObjectType = @ObjectType
    AND d.ARInvoiceTransactionType in ('Invoice') 
END
GO


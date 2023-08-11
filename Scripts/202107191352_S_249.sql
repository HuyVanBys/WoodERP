SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO

CREATE PROCEDURE [dbo].[APFeePaymentReceipts_GetFeePaymentByReceipt]
	@ReceiptID INT
AS
BEGIN
	set nocount on;
	SELECT DISTINCT d.ACDocumentNo
	FROM  dbo.APFeePaymentReceipts soi
	INNER JOIN ACDocuments d ON d.ACDocumentID = soi.FK_ACDocumentID
	WHERE soi.FK_ICReceiptID = @ReceiptID
	AND soi.AAStatus = 'Alive'
	AND d.AAStatus = 'Alive'
    AND d.ACDocumentFollowPosted = 1 -- đã phát sinh phân bổ chi phí mua hàng

END


GO

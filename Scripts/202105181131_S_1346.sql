SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO


-- =============================================
-- Author:		<Binh Nguyen>
-- Create date: <05/03/2019>
-- Description:	<Update BOM Status>
-- =============================================
ALTER PROCEDURE [dbo].[MMProductionNorms_GetSignatureProductionNormByID]
		@ProductionNormID int
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @UserApproveName NVARCHAR(100) = ''
	DECLARE @HREmployeeWoodApproveID INT = 0
	DECLARE @HREmployeeHardwareApproveID INT = 0
	DECLARE @HREmployeePackingMaterialApproveID INT = 0
	DECLARE @HREmployeePaintApproveID INT = 0
	DECLARE @HREmployeeGeneralMaterialApproveID INT = 0
	DECLARE @UserUpdate NVARCHAR(100) = ''

	SELECT  
		@HREmployeeWoodApproveID = pn.FK_HREmployeeWoodApprove
	,	@HREmployeeHardwareApproveID = pn.FK_HREmployeeHardwareApprove
	,	@HREmployeePackingMaterialApproveID = pn.FK_HREmployeePackingMaterialApprove
	,	@HREmployeePaintApproveID = pn.FK_HREmployeePaintApprove
	,	@HREmployeeGeneralMaterialApproveID = pn.FK_HREmployeeGeneralMaterialApproved
	,	@UserUpdate = pn.AAUpdatedUser
	FROM dbo.MMProductionNorms pn
	WHERE pn.AAStatus = 'Alive'
		AND pn.MMProductionNormID = @ProductionNormID

	IF(@HREmployeeWoodApproveID <> 0
		OR @HREmployeeHardwareApproveID <> 0
		OR @HREmployeePackingMaterialApproveID <> 0
		OR @HREmployeePaintApproveID <> 0
		or @HREmployeeGeneralMaterialApproveID <> 0)
		BEGIN
			SET @UserApproveName = @UserUpdate
        END
        
	
	SELECT 
		 createEmployee.MMProductionNormCreateUserName
	,	approveEmployee.MMProductionNormApproveUserName
	FROM dbo.MMProductionNorms pn
	OUTER APPLY
	(
		SELECT TOP 1 em.HREmployeeName AS MMProductionNormCreateUserName
		FROM dbo.HREmployees em
			INNER JOIN dbo.ADUsers u ON u.FK_HREmployeeID = em.HREmployeeID
		WHERE em.AAStatus = 'Alive'
			AND u.AAStatus = 'Alive'
			AND u.ADUserName = pn.AACreatedUser
	) createEmployee
	OUTER APPLY
	(
		SELECT TOP 1 em.HREmployeeName AS MMProductionNormApproveUserName
		FROM dbo.HREmployees em
			INNER JOIN dbo.ADUsers u ON u.FK_HREmployeeID = em.HREmployeeID
		WHERE em.AAStatus = 'Alive'
			AND u.AAStatus = 'Alive'
			AND u.ADUserName = @UserApproveName
	) approveEmployee
	WHERE pn.AAStatus = 'Alive'
		AND pn.MMProductionNormID = @ProductionNormID
    
END

GO


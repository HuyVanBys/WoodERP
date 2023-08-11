SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO

ALTER function [dbo].[ThongTinCty](@CompanyID int)
returns table
as
return
	select 
		cpn.CSCompanyDesc as Ten_Cong_Ty,
		cpn.CSCompanyAddressLine1 as Dia_Chi,
		cpn.CSCompanyAddressLine3 AS Dia_Chi_Giao_Hang,
		cpn.CSCompanyEmail as Mail,
		cpn.CSCompanyFax as So_Fax,
		cpn.CSCompanyWebsite as Website,
		cpn.CSCompanyPhone as SDT,
		cpn.CSCompanyTaxNumber as Ma_So_Thue
	from
		CSCompanys cpn
	where cpn.CSCompanyID=@CompanyID;



GO


USE [MSK]
GO
/****** Object:  StoredProcedure [dbo].[usp_GetAllOrdersByCompany]    Script Date: 5/19/2021 5:09:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER   PROCEDURE [dbo].[usp_GetAllOrdersByCompany]
	@id_company BIGINT
AS
BEGIN

SELECT
	header.id AS ID,
	header.datetime AS DATETIME,
	c.name as CUSTOMER,
	c.CUIT as CUSTOMERCUIT,
	c.id_system as CUSTOMERINTERNALID,
	c.id_company as IDCOMPANY,
	discount as DISCOUNT,
	observations as OBSERVATIONS
FROM order_header header
	LEFT JOIN customer c
		ON c.id = header.id_customer
WHERE 
	c.id_company = @id_company
	AND header.transmited = 0
ORDER BY DATETIME desc

END

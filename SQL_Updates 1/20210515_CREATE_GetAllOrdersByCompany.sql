USE [MSK]
GO
/****** Object:  StoredProcedure [dbo].[usp_GetAllOrdersByCompany]    Script Date: 17/5/2021 18:46:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[usp_GetAllOrdersByCompany]
	@id_company BIGINT
AS
BEGIN

SELECT
	header.id AS ID,
	header.datetime AS DATETIME,
	c.name as CUSTOMER,
	c.CUIT as CUSTOMERCUIT,
	c.id_system as CUSTOMERINTERNALID,
	c.id_company as IDCOMPANY
FROM order_header header
	LEFT JOIN customer c
		ON c.id = header.id_customer
WHERE 
	c.id_company = @id_company
	AND header.transmited = 0
ORDER BY DATETIME desc

END

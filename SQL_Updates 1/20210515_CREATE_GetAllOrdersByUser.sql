USE [MSK]
GO
/****** Object:  StoredProcedure [dbo].[usp_GetAllOrdersByUser]    Script Date: 17/5/2021 18:39:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[usp_GetAllOrdersByUser]
	@id_user BIGINT
AS
BEGIN

SELECT
	header.id AS ID,
	header.datetime AS DATETIME,
	c.name as CUSTOMER,
	c.CUIT as CUSTOMERCUIT,
	c.id_system as CUSTOMERINTERNALID
FROM order_header header
	LEFT JOIN customer c
		ON c.id = header.id_customer
WHERE 
	header.id_user = @id_user
	AND header.transmited = 0
ORDER BY DATETIME desc

END

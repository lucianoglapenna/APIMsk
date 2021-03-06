BEGIN TRANSACTION;

USE [MSK]
GO
/****** Object:  StoredProcedure [dbo].[usp_GetOrders]    Script Date: 14/5/2021 15:20:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER   PROCEDURE [dbo].[usp_GetOrders]
@id_user bigint
as
begin

SELECT
	header.id AS ID,
	header.datetime AS DATETIME,
	c.name as CUSTOMER,
	c.CUIT as CUSTOMERCUIT,
	c.id_system as CUSTOMERINTERNALID
FROM order_header header
	INNER JOIN customer c
		ON c.id = header.id_customer
WHERE 
	header.id_user = @id_user
	AND header.transmited = 0
ORDER BY DATETIME desc


end

ROLLBACK;
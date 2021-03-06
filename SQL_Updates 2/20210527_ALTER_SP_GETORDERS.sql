
ALTER   PROCEDURE [dbo].[usp_GetOrders]
@id_user bigint
as
begin

SELECT
	header.id AS ID,
	header.datetime AS DATETIME,
	header.observations as OBSERVATIONS,
	header.discount as DISCOUNT,
	c.name as CUSTOMER,
	c.CUIT as CUSTOMERCUIT,
	c.id_system as CUSTOMERINTERNALID,
	discount as DISCOUNT,
	observations as OBSERVATIONS,
	receipt_type as RECEIPTTYPE

FROM order_header header
	LEFT JOIN customer c
		ON c.id = header.id_customer
WHERE 
	header.id_user = @id_user
	AND header.transmited = 0
ORDER BY DATETIME desc


end
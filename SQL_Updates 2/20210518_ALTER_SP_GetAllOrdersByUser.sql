ALTER   PROCEDURE [dbo].[usp_GetAllOrdersByUser]
	@id_user BIGINT
AS
BEGIN

SELECT
	header.id AS ID,
	header.datetime AS DATETIME,
	c.name as CUSTOMER,
	c.CUIT as CUSTOMERCUIT,
	c.id_system as CUSTOMERINTERNALID,
	discount as DISCOUNT,
	observations as OBSERVATIONS
FROM order_header header
	LEFT JOIN customer c
		ON c.id = header.id_customer
WHERE 
	header.id_user = @id_user
	AND header.transmited = 0
ORDER BY DATETIME desc

END

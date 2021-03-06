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
	header.id_company as IDCOMPANY,
	discount as DISCOUNT,
	observations as OBSERVATIONS,
	receipt_type as RECEIPTTYPE
FROM order_header header
	INNER JOIN customer c
		ON c.id = header.id_customer
WHERE 
	header.id_company =  @id_company
	AND header.transmited = 0
ORDER BY DATETIME desc

END



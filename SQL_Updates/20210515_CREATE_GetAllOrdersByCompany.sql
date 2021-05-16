BEGIN TRANSACTION;

GO
CREATE PROCEDURE usp_GetAllOrdersByCompany
	@id_company BIGINT
AS
BEGIN

SELECT
	header.id AS ID,
	header.datetime AS DATETIME,
	c.name as CUSTOMER,
	c.CUIT as CUSTOMERCUIT,
	c.id_system as CUSTOMERINTERNALID,
	id_company as IDCOMPANY
FROM order_header header
	LEFT JOIN customer c
		ON c.id = header.id_customer
WHERE 
	c.id_company = @id_company
	AND header.transmited = 0
ORDER BY DATETIME desc

END
GO

ROLLBACK;


ALTER PROCEDURE [dbo].[ups_InsertOrderHeader]
@id_user bigint,
@id_customer bigint,
@id_company bigint,
@observations varchar(max),
@discount decimal(18,2),
@receipt_type bigint

as
begin

INSERT INTO order_header (id_user, id_customer, [datetime], transmited, id_company, discount, observations, receipt_type)
VALUES (@id_user, @id_customer, GETDATE(), 0, @id_company, @discount, @observations, @receipt_type)

SELECT TOP 1 id
FROM order_header
WHERE id_user = @id_user
ORDER BY id DESC

end

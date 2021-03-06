BEGIN TRANSACTION;


ALTER PROCEDURE [dbo].[ups_InsertOrderHeader]
@id_user bigint,
@id_customer bigint,
@id_company bigint
as
begin

INSERT INTO order_header (id_user, id_customer, [datetime], transmited, id_Company,)
VALUES (@id_user, @id_customer, GETDATE(), 0)

SELECT TOP 1 id
FROM order_header
WHERE id_user = @id_user
ORDER BY id DESC

end

ROLLBACK;

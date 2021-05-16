BEGIN TRANSACTION;

USE [MSK]
GO
/****** Object:  StoredProcedure [dbo].[ups_InsertOrderHeader]    Script Date: 14/5/2021 19:08:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[ups_InsertOrderHeader]
@id_user bigint,
@id_customer bigint
as
begin

INSERT INTO order_header (id_user, id_customer, [datetime], transmited)
VALUES (@id_user, @id_customer, GETDATE(), 0)

SELECT TOP 1 id
FROM order_header
WHERE id_user = @id_user
ORDER BY id DESC

end

ROLLBACK;

USE [MSK]
GO
/****** Object:  StoredProcedure [dbo].[usp_GetSingleOrder]    Script Date: 5/19/2021 5:16:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[usp_GetSingleOrder]
@id_company bigint,
@id_order bigint
as
begin
SELECT	id  as ID, datetime as DATETIME, discount as DISCOUNT, observations as OBSERVATIONS,
		(select customer.name from customer where customer.id=order_header.id_customer) as CUSTOMER,
		(select customer.id from customer where customer.id=order_header.id_customer) as CUSTOMERID,
		(select customer.CUIT from customer where customer.id=order_header.id_customer) as CUSTOMERCUIT
from order_header where id_company = @id_company and id=@id_order order by datetime desc
end

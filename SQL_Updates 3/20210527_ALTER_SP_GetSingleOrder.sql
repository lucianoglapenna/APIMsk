
ALTER PROCEDURE [dbo].[usp_GetSingleOrder]
@id_company bigint,
@id_order bigint
as
begin
SELECT	id  as ID, datetime as DATETIME, discount as DISCOUNT, observations as OBSERVATIONS, receipt_type as RECEIPTTYPE,
		(select customer.name from customer where customer.id=order_header.id_customer) as CUSTOMER,
		(select customer.id from customer where customer.id=order_header.id_customer) as CUSTOMERID,
		(select customer.CUIT from customer where customer.id=order_header.id_customer) as CUSTOMERCUIT
from order_header where id_company = @id_company and id=@id_order order by datetime desc
end

USE [MSK]
GO
/****** Object:  StoredProcedure [dbo].[usp_insertLogin]    Script Date: 5/17/2021 8:08:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[usp_insertLogin]
@login varchar(50),
@id_company bigint,
@email varchar(50),
@password varchar(max),
@phone varchar(100),
@idCustomer bigint,
@seller bigint
as
begin
	declare @loginexists bigint = (Select login.login from login where login=@login and id_company=@id_company)
	if (COUNT(@loginexists)=0)
	begin
		Insert into login(
		login.login,
		id_company,
		email,
		confirmed_email,
		password,
		phone,
		acces_failed_count,
		locked,
		suspended,
		Customer, 
		seller)
		values(
		@login,
		@id_company,
		@email,
		1,
		@password,
		@phone,
		0,
		0,
		0,
		@idCustomer,
		@seller
		)
		Select top 1 Id from login where id_company=@id_company order by id desc
	end
	else
	begin
		Select -1
	end
end

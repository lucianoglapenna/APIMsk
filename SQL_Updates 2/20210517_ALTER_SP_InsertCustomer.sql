USE [MSK_produccion]
GO
/****** Object:  StoredProcedure [dbo].[usp_InsertCustomer]    Script Date: 5/17/2021 8:19:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[usp_InsertCustomer]
@id_system bigint,
@id_company bigint,
@name varchar(100),
@address varchar(100) NULL,
@zipcode varchar(100) NULL,
@city varchar(100) NULL,
@iva varchar(100) NULL,
@cuit varchar(100),
@phone varchar(100),
@seller varchar(100) NULL,
@zone varchar(100) NULL,
@route varchar(100) NULL,
@custommerType varchar(100) NULL,
@activity varchar(100) NULL,
@branch varchar(100) NULL,
@balance decimal(18,2),
@idSeller bigint
as
begin

	declare @i_idExistentCustommer bigint
	declare @i_zipcode bigint
	declare @i_city bigint
	declare @i_iva bigint
	declare @i_seller bigint
	declare @i_zone bigint
	declare @i_route bigint
	declare @i_custommerType bigint
	declare @i_activity bigint 
	declare @i_branch bigint

	set @i_idExistentCustommer = (Select id from customer where id_system = @id_system)

		

	if (@zipcode is not null)
	begin
		set @i_zipcode = (select id from zipcode where zipcode.zipcode=@zipcode and id_company=@id_company)
		if (Count(@i_zipcode)=0) 
		begin
			insert into zipcode(id_company,zipcode) values (@id_company,@zipcode)
			set @i_zipcode = (select top 1 id from zipcode order by id desc)
		end
	end 
	else set @i_zipcode=0
	
	if (@city is not null)
	begin
		set @i_city = (select id from city where city.name=@city and id_company=@id_company)
		if (Count(@i_city)=0) 
		begin
			insert into city(id_company,name) values (@id_company,@city)
			set @i_city = (select top 1 id from city order by id desc)
		end
	end
	else set @i_city=0

	if (@iva is not null)
	begin
		set @i_iva  = (select id from iva where iva.name=@iva and id_company=@id_company)
		if (Count(@i_iva)=0) 
		begin
			insert into iva(id_company,name) values (@id_company,@iva)
			set @i_iva = (select top 1 id from iva order by id desc)
		end
	end else set @i_iva=0


	if (@seller is not null)
	begin
		set @i_seller = (select id from seller where seller.name=@seller and id_company=@id_company)
		if (Count(@i_seller)=0) 
		begin
			insert into seller(id_company,name, internal_code) values (@id_company,@seller, @idSeller)
			set @i_seller = (select top 1 id from seller order by id desc)
		end
	end else 
		begin
			update seller set internal_code=@idSeller where id = @i_seller
		end

	if (@zone is not null)
	begin
		set @i_zone = (select id from zone where zone.zone=@zone and id_company=@id_company)
		if (Count(@i_zone)=0) 
		begin
			insert into zone(id_company,zone) values (@id_company,@zone)
			set @i_zone = (select top 1 id from zone order by id desc)
		end
	end else set @i_zone=0

	if (@route is not null)
	begin
		set @i_route = (select id from route where route.name=@route and id_company=@id_company)
		if (Count(@i_route)=0) 
		begin
			insert into route(id_company,name) values (@id_company,@route)
			set @i_route = (select top 1 id from route order by id desc)
		end
	end else set @i_route=0


	if (@custommerType is not null)
		begin
		set @i_custommerType = (select id from custommer_type where custommer_type.name=@custommerType and id_company=@id_company)
		if (Count(@i_custommerType)=0) 
		begin
			insert into custommer_type(id_company,name) values (@id_company,@custommerType)
			set @i_custommerType = (select top 1 id from custommer_type order by id desc)
		end
	end else set @i_custommerType=0

	if (@activity is not null)
		begin
		set @i_activity = (select id from activity where activity.name=@activity and id_company=@id_company)
		if (Count(@i_activity)=0) 
		begin
			insert into activity(id_company,name) values (@id_company,@activity)
			set @i_activity = (select top 1 id from activity order by id desc)
		end
	end else set @i_activity=0

	if (@branch is not null)
		begin
		set @i_branch = (select id from branch where branch.name=@branch and id_company=@id_company)
		if (Count(@i_branch)=0) 
		begin
			insert into branch(id_company,name) values (@id_company,@branch)
			set @i_branch = (select top 1 id from branch order by id desc)
		end
	end else set @i_branch=0
	
	if (COUNT(@i_idExistentCustommer)=0)
	begin
		insert into 
		customer(id_system,id_company,name,address,zipcode,city,IVA,CUIT,phone,seller,zone,route,custommer_type,activity,branch, balance)
		values
				(
				@id_system, 
				@id_company, 
				@name, 
				@address,
				@i_zipcode,
				@i_city, 
				@i_iva, 
				@cuit, 
				@phone, 
				@i_seller, 
				@i_zone, 
				@i_route, 
				@i_custommerType,
				@i_activity,
				@i_branch,
				@balance)
	end 
	else 
	begin
		update customer set 
		name=@name, 
		address=@address,
		zipcode=@i_zipcode,
		city=@i_city, 
		iva=@i_iva, 
		cuit=@cuit, 
		phone=@phone, 
		seller=@i_seller, 
		zone=@i_zone, 
		route=@i_route, 
		custommer_type=@i_custommerType,
		activity=@i_activity,
		balance=@balance,
		branch=@i_branch where id=@i_idExistentCustommer AND id_company=@id_company
	end
end
		
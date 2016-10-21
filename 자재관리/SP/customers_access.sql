

-- 그냥 저장용임 실제론 이걸로 작동하는 게 아닙니다.
CREATE PROCEDURE [dbo].[customers_update](
@customer_id int,
@customer_company nvarchar(25),
@customer_name nvarchar(10),
@customer_phonenum nvarchar(25),
@memo nvarchar(max)
)

AS
begin
	UPDATE customers
	set
	customer_company = @customer_company,
	customer_name = @customer_name,
	customer_phonenum = @customer_phonenum
	
	where customer_id = @customer_id
	

end

go

create procedure [dbo].[customers_insert](
@customer_company nvarchar(25),
@customer_name nvarchar(10),
@customer_phonenum nvarchar(25),
@memo nvarchar(max)
)
as
	begin
	insert into customers
	(customer_company,
	customer_name,
	customer_phonenum,
	memo)
	values
	(
	@customer_company,
	@customer_name,
	@customer_phonenum,
	@memo
	)
end
go



CREATE PROCEDURE [dbo].[customers_delete](
@customer_company nvarchar(25),
@customer_name nvarchar(10),
@customer_phonenum nvarchar(25)
)

AS
begin
	DELETE from customers
	where customer_company = @customer_company and
		  customer_name = @customer_name and
		  customer_phonenum = @customer_phonenum

end


-- 그냥 저장용임 실제론 이걸로 작동하는 게 아닙니다.

create procedure [dbo].[products_insert](
    @product_name     NVARCHAR (20) ,
    @product_company  NVARCHAR (20) ,
    @product_type     NVARCHAR (20) ,
    @product_scale    VARCHAR (10) ,
    @product_price    MONEY         ,
    @product_isdanger BIT
)
as
	begin
	insert into products
	(product_name,
	product_company,
	product_type,
	product_scale,
	product_price,
	product_isdanger
	)
	values
	(@product_name,
	@product_company,
	@product_type,
	@product_scale,
	@product_price,
	@product_isdanger)
end
go



CREATE PROCEDURE [dbo].[products_delete](
@product_id int
)

AS
begin
	DELETE from products
	where product_id = @product_id

end
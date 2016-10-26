CREATE PROCEDURE [dbo].inout_select

AS
begin
	select	inout.inout_id as '일련번호',
		inout.product_id as '제품코드',
		inout_detail.product_name as'제품명',
		inout.inout_date as'입/출고날짜',
		inout.inout_flag as'입/출고여부',
		inout_detail.inout_qty as'수량',
		inout.employee_id as'직원코드',
		inout_detail.check_flag as'검수여부'
from inout left outer join inout_detail
on inout.inout_id = inout_detail.inout_id;


end
go
create procedure [dbo].inout_insert
(@product_id int,
 @inout_date datetime,
 @inout_flag bit,
 @inout_qty int,
 @employee_id nvarchar(20),
 @check_flag bit
)

as
begin
begin transaction tr
   insert into inout (product_id,   inout_date,   inout_flag,   employee_id)
   values		     (@product_id,  @inout_date,  @inout_flag,  @employee_id)

   insert into inout_detail(
   inout_id,
   product_id,
   product_name,
   inout_flag,
   inout_qty,
   check_flag
   )
   values
   (
    (select @@identity from inout),
   @product_id,
   (select products.product_name from products where product_id = @product_id),
   @inout_flag,
   @inout_qty,
   @check_flag
   )
if @@error <> 0 rollback transaction tr
commit transaction
end
go

create procedure [dbo].inout_delete
(@inout_id int)
as
begin
begin transaction
	delete from inout where inout_id = @inout_id
	delete from inout_detail where inout_id = @inout_id
commit transaction
end
go
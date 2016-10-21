

-- 그냥 저장용임 실제론 이걸로 작동하는 게 아닙니다.

go

create procedure [dbo].[employee_insert](
@employee_Name nvarchar(10),
@employee_Phone varchar(20),
@employee_address nvarchar(50),
@employee_extr nvarchar(50)
)
as
	begin
	insert into employee
	(
		employee_Name,
		employee_Phone,
		employee_address,
		employee_extr
	)
	values
	(
		@employee_Name,
		@employee_Phone,
		@employee_address,
		@employee_extr
	)
end
go



CREATE PROCEDURE [dbo].[employee_delete](
@employee_ID int
)

AS
begin
	DELETE from employee
	where employee_ID = @employee_ID

end
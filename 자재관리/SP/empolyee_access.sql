

-- 그냥 저장용임 실제론 이걸로 작동하는 게 아닙니다.

go

create procedure [dbo].[empolyee_insert](
@empolyee_Name nvarchar(10),
@empolyee_Phone varchar(20),
@empolyee_address nvarchar(50),
@empolyee_extr nvarchar(50)
)
as
	begin
	insert into empolyee
	(
		empolyee_Name,
		empolyee_Phone,
		empolyee_address,
		empolyee_extr
	)
	values
	(
		@empolyee_Name,
		@empolyee_Phone,
		@empolyee_address,
		@empolyee_extr
	)
end
go



CREATE PROCEDURE [dbo].[empolyee_delete](
@empolyee_ID int
)

AS
begin
	DELETE from empolyee
	where empolyee_ID = @empolyee_ID

end
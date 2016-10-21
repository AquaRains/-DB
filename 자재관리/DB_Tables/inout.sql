CREATE TABLE [dbo].inout
(
	[inout_id] INT NOT NULL PRIMARY KEY identity(1,1), --입출고 고유번호
	product_id int NOT NULL,          --제품id
	inout_date DATETIME NOT NULL default getdate(), --입출고일자
	inout_flag bit NOT NULL default 0, --0 입고, 1 출고
	employee_id int NOT NULL,  --담당자

	constraint FK_productid
		foreign key (product_id)
		references products (product_id)
		on update cascade
		on delete cascade,

	constraint FK_employee_id
		foreign key (employee_id)
		references employee(employee_ID)
		on update cascade
		on delete no action
		

)

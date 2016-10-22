CREATE TABLE [dbo].inout_detail
(
	[inout_id] int not null Unique clustered, --입출고id
	product_id int,			   --제품id
	product_name nvarchar(20), -- 제품명
	inout_flag bit NOT NULL, --0입고 1추고 ( inout table 외부참조 )
	inout_qty int NOT NULL, --입출고 수량
	check_flag bit, --검수확인여부
	inout_detail_ext nvarchar(50)   --추가기입사항(비고)

	constraint FK_inout_id
		foreign key (inout_id)
		references inout(inout_id)
		on update cascade
		on delete cascade,

	constraint FK_product_id
		foreign key (product_id)
		references products(product_id)
		on update no action
		on delete no action,

		constraint FK_product_name
		foreign key(product_name)
		references products(product_name)
		on update no action
		on delete no action

)

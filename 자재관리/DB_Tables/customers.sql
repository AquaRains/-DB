CREATE TABLE [dbo].[customers] (
    [customer_id]       INT           IDENTITY (1, 1) NOT NULL,
    [customer_company]  NVARCHAR(25)    NOT NULL,
    [customer_name]     NVARCHAR(10)    NULL,
    [customer_phonenum] NVARCHAR (25) NOT NULL,
    [memo] NVARCHAR(MAX) NULL, 
    PRIMARY KEY CLUSTERED ([customer_id] ASC)

	)

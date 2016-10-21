CREATE TABLE [dbo].[products] (
    [product_id]      INT          IDENTITY (1, 1) NOT NULL,
    [product_name]    VARCHAR (20) NOT NULL,
    [product_company] VARCHAR (20) NULL,
    [pruduct_type]    VARCHAR (20) NOT NULL,
    [scale]           VARCHAR (10) NOT NULL,
    PRIMARY KEY CLUSTERED ([product_id] ASC)
);


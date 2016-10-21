CREATE TABLE [dbo].[products] (
    [product_id]       INT           IDENTITY (1, 1) NOT NULL,
    [product_name]     NVARCHAR (20) NOT NULL,
    [product_company]  NVARCHAR (20) NULL,
    [product_type]     NVARCHAR (20) NOT NULL,
    [product_scale]    VARCHAR (10)  NOT NULL,
    [product_price]    MONEY         NULL,
    [product_isdanger] BIT           DEFAULT ((0)) NULL,
    PRIMARY KEY CLUSTERED ([product_id] ASC)
);

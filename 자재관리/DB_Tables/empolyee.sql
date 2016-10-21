
CREATE TABLE [dbo].[employee] (
    [employee_ID]      INT           IDENTITY (1, 1) NOT NULL,
    [employee_Name]    NVARCHAR (10) NOT NULL,
    [employee_Phone]   VARCHAR (20)  NULL,
    [employee_address] NVARCHAR (50) NULL,
    [employee_extr]    NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([employee_ID] ASC)
);


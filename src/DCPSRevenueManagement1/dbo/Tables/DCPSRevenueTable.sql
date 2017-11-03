CREATE TABLE [dbo].[DCPSRevenueTable] (
    [ID]       INT          IDENTITY (1, 1) NOT NULL,
    [Quarter1] VARCHAR (50) NOT NULL,
    [Quarter2] VARCHAR (50) NOT NULL,
    [Quarter3] VARCHAR (50) NOT NULL,
    [Quarter4] VARCHAR (50) NOT NULL,
    [Quarter5] VARCHAR (50) NOT NULL,
    [Quarter6] VARCHAR(50) NULL, 
    CONSTRAINT [PK_DCPSRevenueTable] PRIMARY KEY CLUSTERED ([ID] ASC)
);


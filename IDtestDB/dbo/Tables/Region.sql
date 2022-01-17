CREATE TABLE [dbo].[Region] (
    [id]         INT          IDENTITY (1, 1) NOT NULL,
    [State]      VARCHAR (50) NULL,
    [RegionType] VARCHAR (50) NOT NULL,
    [ASGS_2016]  INT          NOT NULL,
    [Region]     VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_ABSRegion] PRIMARY KEY CLUSTERED ([id] ASC)
);


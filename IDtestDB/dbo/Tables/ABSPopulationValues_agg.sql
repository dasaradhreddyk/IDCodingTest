CREATE TABLE [dbo].[ABSPopulationValues_agg] (
    [id]       INT          IDENTITY (1, 1) NOT NULL,
    [regionid] INT          NOT NULL,
    [sexid]    INT          NOT NULL,
    [age]      VARCHAR (20) NOT NULL,
    [time]     INT          NOT NULL,
    [value]    INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);


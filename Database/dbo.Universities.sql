USE [FinalDatabase]
GO

/****** Object: Table [dbo].[Universities] Script Date: 12/1/2020 7:38:36 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Universities] (
    [Id]      INT            IDENTITY (1, 1) NOT NULL,
    [Name]    NVARCHAR (MAX) NOT NULL,
    [Address] NVARCHAR (MAX) NULL
);



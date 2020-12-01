USE [FinalDatabase]
GO

/****** Object: Table [dbo].[Students] Script Date: 12/1/2020 7:39:58 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Students] (
    [id]        INT            IDENTITY (1, 1) NOT NULL,
    [FirstName] NVARCHAR (MAX) NOT NULL,
    [LastName]  NVARCHAR (MAX) NOT NULL,
    [Address]   NVARCHAR (MAX) NULL,
    [Phone]     NVARCHAR (MAX) NULL
);



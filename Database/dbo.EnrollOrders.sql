USE [FinalDatabase]
GO

/****** Object: Table [dbo].[EnrollOrders] Script Date: 12/1/2020 7:40:15 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[EnrollOrders] (
    [StudentId]    INT NOT NULL,
    [UniversityId] INT NOT NULL
);


GO
CREATE NONCLUSTERED INDEX [IX_EnrollOrders_UniversityId]
    ON [dbo].[EnrollOrders]([UniversityId] ASC);


GO
ALTER TABLE [dbo].[EnrollOrders]
    ADD CONSTRAINT [PK_EnrollOrders] PRIMARY KEY CLUSTERED ([StudentId] ASC, [UniversityId] ASC);


GO
ALTER TABLE [dbo].[EnrollOrders]
    ADD CONSTRAINT [FK_EnrollOrders_Students_StudentId] FOREIGN KEY ([StudentId]) REFERENCES [dbo].[Students] ([id]) ON DELETE CASCADE;


GO
ALTER TABLE [dbo].[EnrollOrders]
    ADD CONSTRAINT [FK_EnrollOrders_Universities_UniversityId] FOREIGN KEY ([UniversityId]) REFERENCES [dbo].[Universities] ([Id]) ON DELETE CASCADE;



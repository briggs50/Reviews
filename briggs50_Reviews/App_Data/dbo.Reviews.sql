CREATE TABLE [dbo].[Reviews] (
    [ID]         INT            IDENTITY (1, 1) NOT NULL,
    [Content]    NVARCHAR (MAX) NULL,
    [MovieID]    INT            NOT NULL,
    [MovieTitle] NVARCHAR (MAX) NULL,
    [Rating]     INT            NOT NULL,
    CONSTRAINT [PK_dbo.Reviews] PRIMARY KEY CLUSTERED ([ID] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IX_MovieID]
    ON [dbo].[Reviews]([MovieID] ASC);


CREATE TABLE [dbo].[Movies] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [Title]        NVARCHAR (MAX) NOT NULL,
    [Year]         INT            NOT NULL,
    [Category]     NVARCHAR (MAX) NOT NULL,
    [LeadingActor] NVARCHAR (MAX) NOT NULL,
    [Director]     NVARCHAR (MAX) NOT NULL,
    [MoviePoster]  NVARCHAR (MAX) NULL,
    [Rating]       INT            NOT NULL,
    CONSTRAINT [PK_dbo.Movies] PRIMARY KEY CLUSTERED ([Id] ASC),
	 CONSTRAINT [FK_dbo.Movies_Rating] FOREIGN KEY ([Rating]) REFERENCES [dbo].[Reviews] ([Rating]) ON DELETE CASCADE
);


CREATE TABLE [dbo].[User] (
	[Id]			INT		IDENTITY (1, 1) NOT NULL,
	[LoginName]		NVARCHAR (40)	NOT NULL,
	[PasswordHash]	BINARY (64)		NOT NULL,
	[Role]			INT				NOT NULL,	/* 1 - User, 2 - Manager, 3 - Admin*/
	PRIMARY KEY CLUSTERED ([Id] ASC)
);
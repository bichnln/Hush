CREATE TABLE [dbo].[Table] (
    [Id]          INT          NOT NULL,
    [Username]    VARCHAR (50) NOT NULL,
    [Password]    NVARCHAR(MAX) NULL,
    [Service]     VARCHAR (50) NULL,
    [Email]       VARCHAR (50) NULL,
    [PhoneNumber] VARCHAR(20)   NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


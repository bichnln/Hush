CREATE TABLE [dbo].[Table] (
    [Id]          INT          NOT NULL,
    [Username]    VARCHAR (MAX) NOT NULL,
    [Password]    VARCHAR(MAX) NOT NULL,
    [Service]     VARCHAR (MAX) NOT NULL,
    [Email]       VARCHAR(MAX) NULL,
    [PhoneNumber] VARCHAR(255)   NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


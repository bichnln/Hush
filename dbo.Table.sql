CREATE TABLE [dbo].[Table] (
    [Id]          INT          NOT NULL,
    [Username]    NVARCHAR(50) NOT NULL,
    [Password]    NVARCHAR(50) NOT NULL,
    [Service]     NVARCHAR(50) NOT NULL,
    [Email]       NVARCHAR(50) NULL,
    [PhoneNumber] NVARCHAR(50)   NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


CREATE TABLE [dbo].[Table] (
    [ID]          INT          NOT NULL,
    [Username]    VARCHAR (50) NOT NULL,
    [Password]    VARCHAR (50) NOT NULL,
    [Service]     VARCHAR (50) NOT NULL,
    [Email]       VARCHAR (50) NULL,
    [PhoneNumber] NCHAR (10)   NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);


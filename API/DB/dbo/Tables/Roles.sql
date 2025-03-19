﻿CREATE TABLE [dbo].[Roles] (
    [IdRol]  UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [nombre] NVARCHAR (50)    NOT NULL,
    PRIMARY KEY CLUSTERED ([IdRol] ASC),
    UNIQUE NONCLUSTERED ([nombre] ASC)
);


CREATE TABLE [dbo].[Recuerdos] (
    [IdRecuerdo]  UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [IdUsuario]   UNIQUEIDENTIFIER NOT NULL,
    [titulo]      NVARCHAR (255)   NOT NULL,
    [descripcion] NVARCHAR (MAX)   NULL,
    [fecha]       DATETIME         DEFAULT (getdate()) NULL,
    [tipo]        NVARCHAR (10)    NOT NULL,
    [archivoUrl]  NVARCHAR (500)   NOT NULL,
    PRIMARY KEY CLUSTERED ([IdRecuerdo] ASC),
    CHECK ([tipo]='video' OR [tipo]='imagen'),
    FOREIGN KEY ([IdUsuario]) REFERENCES [dbo].[Usuarios] ([IdUsuario]) ON DELETE CASCADE
);


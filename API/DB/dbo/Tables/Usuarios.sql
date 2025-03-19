CREATE TABLE [dbo].[Usuarios] (
    [IdUsuario]      UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [nombre]         NVARCHAR (100)   NOT NULL,
    [correo]         NVARCHAR (255)   NOT NULL,
    [contraseñaHash] NVARCHAR (255)   NOT NULL,
    [IdRol]          UNIQUEIDENTIFIER NOT NULL,
    PRIMARY KEY CLUSTERED ([IdUsuario] ASC),
    FOREIGN KEY ([IdRol]) REFERENCES [dbo].[Roles] ([IdRol]),
    UNIQUE NONCLUSTERED ([correo] ASC)
);


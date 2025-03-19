CREATE TABLE [dbo].[Favoritos] (
    [IdFavorito] UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [IdRecuerdo] UNIQUEIDENTIFIER NOT NULL,
    [IdUsuario]  UNIQUEIDENTIFIER NULL,
    [fecha]      DATETIME         DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([IdFavorito] ASC),
    FOREIGN KEY ([IdRecuerdo]) REFERENCES [dbo].[Recuerdos] ([IdRecuerdo]) ON DELETE CASCADE,
    FOREIGN KEY ([IdUsuario]) REFERENCES [dbo].[Usuarios] ([IdUsuario])
);


CREATE TABLE [dbo].[Comentarios] (
    [IdComentario] UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [IdRecuerdo]   UNIQUEIDENTIFIER NOT NULL,
    [IdUsuario]    UNIQUEIDENTIFIER NULL,
    [comentario]   NVARCHAR (MAX)   NOT NULL,
    [fecha]        DATETIME         DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([IdComentario] ASC),
    FOREIGN KEY ([IdRecuerdo]) REFERENCES [dbo].[Recuerdos] ([IdRecuerdo]) ON DELETE CASCADE,
    FOREIGN KEY ([IdUsuario]) REFERENCES [dbo].[Usuarios] ([IdUsuario])
);


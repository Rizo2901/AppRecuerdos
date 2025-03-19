CREATE TABLE [dbo].[Reacciones] (
    [IdReaccion]   UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [IdRecuerdo]   UNIQUEIDENTIFIER NOT NULL,
    [IdUsuario]    UNIQUEIDENTIFIER NULL,
    [tipoReaccion] NVARCHAR (20)    NOT NULL,
    PRIMARY KEY CLUSTERED ([IdReaccion] ASC),
    CHECK ([tipoReaccion]='??' OR [tipoReaccion]='??' OR [tipoReaccion]='??' OR [tipoReaccion]='??' OR [tipoReaccion]='??'),
    FOREIGN KEY ([IdRecuerdo]) REFERENCES [dbo].[Recuerdos] ([IdRecuerdo]) ON DELETE CASCADE,
    FOREIGN KEY ([IdUsuario]) REFERENCES [dbo].[Usuarios] ([IdUsuario])
);


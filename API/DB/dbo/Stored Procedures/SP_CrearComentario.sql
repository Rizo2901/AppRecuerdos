
-- Stored Procedure: SP_CrearComentario
CREATE PROCEDURE SP_CrearComentario
    @IdRecuerdo UNIQUEIDENTIFIER,
    @IdUsuario UNIQUEIDENTIFIER,
    @comentario NVARCHAR(MAX)
AS
BEGIN
    -- Insert new comment
    INSERT INTO Comentarios (IdRecuerdo, IdUsuario, comentario)
    VALUES (@IdRecuerdo, @IdUsuario, @comentario);
END;
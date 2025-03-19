
-- Stored Procedure: SP_CrearFavorito
CREATE PROCEDURE SP_CrearFavorito
    @IdRecuerdo UNIQUEIDENTIFIER,
    @IdUsuario UNIQUEIDENTIFIER
AS
BEGIN
    -- Insert new favorite
    INSERT INTO Favoritos (IdRecuerdo, IdUsuario)
    VALUES (@IdRecuerdo, @IdUsuario);
END;
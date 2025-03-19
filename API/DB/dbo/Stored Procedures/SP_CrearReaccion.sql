
-- Stored Procedure: SP_CrearReaccion
CREATE PROCEDURE SP_CrearReaccion
    @IdRecuerdo UNIQUEIDENTIFIER,
    @IdUsuario UNIQUEIDENTIFIER,
    @tipoReaccion NVARCHAR(20)
AS
BEGIN
    -- Insert new reaction
    INSERT INTO Reacciones (IdRecuerdo, IdUsuario, tipoReaccion)
    VALUES (@IdRecuerdo, @IdUsuario, @tipoReaccion);
END;
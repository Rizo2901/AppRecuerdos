
-- Stored Procedure: SP_CrearRecuerdo
CREATE PROCEDURE SP_CrearRecuerdo
    @IdUsuario UNIQUEIDENTIFIER,
    @titulo NVARCHAR(255),
    @descripcion NVARCHAR(MAX),
    @tipo NVARCHAR(10),
    @archivoUrl NVARCHAR(500)
AS
BEGIN
    -- Insert new memory
    INSERT INTO Recuerdos (IdUsuario, titulo, descripcion, tipo, archivoUrl)
    VALUES (@IdUsuario, @titulo, @descripcion, @tipo, @archivoUrl);
END;
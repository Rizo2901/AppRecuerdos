
-- Stored Procedure: SP_CrearUsuario
CREATE PROCEDURE SP_CrearUsuario
    @nombre NVARCHAR(100),
    @correo NVARCHAR(255),
    @contraseñaHash NVARCHAR(255),
    @IdRol UNIQUEIDENTIFIER
AS
BEGIN
    -- Insert new user
    INSERT INTO Usuarios (nombre, correo, contraseñaHash, IdRol)
    VALUES (@nombre, @correo, @contraseñaHash, @IdRol);
END;
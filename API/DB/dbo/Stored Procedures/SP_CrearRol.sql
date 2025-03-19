
-- Stored Procedure: SP_CrearRol
CREATE PROCEDURE SP_CrearRol
    @nombre NVARCHAR(50)
AS
BEGIN
    -- Insert new role
    INSERT INTO Roles (nombre) 
    VALUES (@nombre);
END;
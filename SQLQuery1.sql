--PROCEDIMIENTO DE ALMACENADO PARA EL PROYECTO
--se usa ALTER para hacer la modificacion
ALTER procedure spConsultarCiudades
as
begin
	select * from Ciudad order by CiudadID asc
end

--en el sistema se usara solo el llamado a un procedimiento

--prueba del procedimiento de almacenado
exec spConsultarCiudades

--script para procedimiento con parametro
create procedure spConsultarCiudadPorCodigo @CodCiudad int
as 
begin
	select * from Ciudad where CiudadID = @CodCiudad
end


--insercion en la tabla con el procedimiento de almacenado
CREATE PROCEDURE spInsertarCiudad @descripcion varchar(50)
AS
BEGIN
	INSERT INTO Ciudad(Descripcion) VALUES(@descripcion)
END

EXEC spInsertarCiudad 'San Antonio'

delete from Ciudad where CiudadID = 5

CREATE PROCEDURE spActualizarCiudad @codigo int, @descripcion varchar(55)
AS
BEGIN
	update Ciudad
		set Descripcion = @descripcion
		where CiudadID = @codigo
END

exec spActualizarCiudad 6, 'Ñemby'

CREATE PROCEDURE spEliminarCiudad @codigo int 
AS
BEGIN
	DELETE FROM Ciudad 
	WHERE CiudadID = @codigo
END

EXEC spEliminarCiudad 6
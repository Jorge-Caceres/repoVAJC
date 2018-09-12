--PROCEDIMIENTO DE ALMACENADO PARA EL PROYECTO
--se usa ALTER para hacer la modificacion
create procedure spConsultarCiudades
as
begin
	select * from Ciudad order by Descripcion
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
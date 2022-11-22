---- PROCEDIMIENTOAS ALMACENADOS EMPLEADOS ----------------
/* procedimiento para mostrar */
CREATE PROCEDURE mostrarEmpleados
as
select * from Empleado
order by tipoDeUsuario asc
go
 execute mostrarEmpleados
 
 /* procedimiento para insertar */
 create procedure insertarEmpleados
 @usuario_id int,
 @apellidoPaterno varchar(30),
 @apellidoMaterno varchar(30),
 @nombres varchar(30),
 @email varchar(50), 
 @tipoDeUsuario int,
 @nick varchar (30),
 @password varchar(30),
 @habilitar varchar(1),
 @foto image,
 @direccion varchar(50),
 @celular char(9),
 @sexo varchar(1),
 @sueldo decimal(6,2),
 @idSucursal varchar(3)
 as
 insert into Empleado values (@usuario_id,@apellidoPaterno,@apellidoMaterno,@nombres,@email,@tipoDeUsuario,
 @nick, @password, @habilitar, @foto, @direccion, @celular, @sexo, @sueldo, @idSucursal)
 go
 
 /* procedimiento para eliminar */
 create procedure eliminarEmpleado
 @usuario_id int 
 as
 delete from Empleado where usuario_id = @usuario_id
 go
 
 /* procedimiento para editar */
 create procedure editarEmpleado
 @usuario_id int,
 @apellidoPaterno varchar(30),
 @apellidoMaterno varchar(30),
 @nombres varchar(30),
 @email varchar(50), 
 @tipoDeUsuario int,
 @nick varchar (30),
 @password varchar(30),
 @habilitar varchar(1),
 @foto image,
 @direccion varchar(50),
 @celular char(9),
 @sexo varchar(1),
 @sueldo decimal(6,2),
 @idSucursal varchar(3)
 as
 update Empleado set
 apellidoPaterno = @apellidoPaterno, apellidoMaterno=@apellidoMaterno,nombres = @nombres,
 email=@email, tipoDeUsuario=@tipoDeUsuario,nick = @nick, password = @password,
 habilitar=@habilitar, foto=@foto, direccion=@direccion,celular=@celular, sexo=@sexo,sueldo=@sueldo,
 idSucursal= @idSucursal
 where usuario_id = @usuario_id
 go
 
  /* procedimiento para insertar tipo de usuario */ 
 create procedure insertarTipoDeUsuario
 @tipoDeUsuario_id int,
 @nombreTipoDeUsuario_id varchar(30)
 as
 
 insert into tipoDeUsuario values ( @tipoDeUsuario_id,@nombreTipoDeUsuario_id)
 go
 
 execute insertarTipoDeUsuario 2, ' Vendedor(a)'
update tipoDeUsuario
set nombreDeTipoDeUsuario = ' Almacenero'
where tipoDeUsuario_id  = 3
 
 
 ---falta insertar empleado
 execute insertarEmpleados 43800247,'Salvador','Rojas','Edgar Roger','3d6ar17@gmail.com',1,'3d6ar',
 '12345','1',' ','los almaos 123','123412342','M','600.00','1'
 go
 execute eliminarEmpleado 43800247
 
 execute mostrarEmpleados
   /* procedimiento para consultar tipo de usuario */
 create procedure consultarTipoDeUsuario
 @tipoDeUsuario_id int
 as
 begin
 select tipoDeUsuario_id, nombreDeTipoDeUsuario
  from tipoDeUsuario
 where tipoDeUsuario_id = @tipoDeUsuario_id
 end
 
 execute consultarTipoDeUsuario 1
   /* procedimiento para recuperar contraseña */
 create procedure recuperarContraseña
 @email varchar(50)
 as
 begin
 select password,foto,apellidoPaterno,email
  from Empleado
 where email = @email
 end
 go
 
 execute recuperarContraseña 'teo@gmail.com'
   /* procedimiento para cambiar contraseña */
 create procedure cambiarContraseña
 @password varchar(30),
 @usuario_id int
 as
 begin
 update Empleado set
 password = @password
 where usuario_id = @usuario_id
 end
 
 execute cambiarContraseña 'fiorela',98765678
 
 execute mostrarEmpleados
   /* procedimiento para consultar dni del empleado */
 create procedure consultarDni
 @dni int
 as
 select usuario_id, password  from Empleado
 where usuario_id= @dni
 go
 
 execute consultarDni 43800247
   /* procedimiento para consultar nick del empleado */
 create procedure consultarNick
 @nick varchar (30)
 as
 begin
 select usuario_id, apellidoPaterno, apellidoMaterno ,nombres,
 email,tipoDeUsuario,nick,password,habilitar,foto,direccion,
 celular,sexo,sueldo,idSucursal from Empleado
 where nick = @nick
 end
   /* procedimiento para consultar usuario */
 create procedure consultarUsuario
 @dni int
 as
 begin
 select usuario_id, apellidoPaterno, apellidoMaterno ,nombres,
 email,tipoDeUsuario,nick,password,habilitar,foto,direccion,
 celular,sexo,sueldo, idSucursal from Empleado
 where usuario_id = @dni
 end
   /* procedimiento para listar empleado */
 create procedure listarEmpleado
 As
 begin
 select usuario_id, apellidoPaterno, apellidoMaterno ,nombres,
 email,tipoDeUsuario,nick,password,habilitar,foto,direccion,
 celular,sexo,sueldo, idSucursal from Empleado
 order by tipoDeUsuario
 end
 go
 
 execute listarEmpleado
 
 /* procedimiento para insertar sucursal*/
 create procedure insertarSucursal
	@idSucursal varchar(3),
	@nombre varchar (50) ,
	@idUbigeo int ,
	@direccion varchar (50),
	@imagen image ,
	@telefono integer
	as
	insert into Sucursal values (@idSucursal,@nombre,@idUbigeo,@direccion,@imagen,@telefono)
	go 
	
	execute insertarSucursal '1','AGRICOLA MILAGROS S.R.L.','1','Av. San Francisco Mz. E-Lt.30',' ',992798953
	execute insertarSucursal '2','AGRICOLA MILAGROS-II S.R.L.','2','Av. San Martin Mz. Z-Lt.10',' ',992798935
	execute insertarSucursal '3','AGRICOLA MILAGROS-III S.R.L.','3','Calle el Sol Mz. H-Lt.02',' ',992798359


	
	/* procedimiento para listar sucursal*/
	create procedure listarSucursal
	as
	begin
	select idSucursal,nombre,idUbigeo,direccion,imagen,telefono from Sucursal
	end
	
	execute listarSucursal
	/* procedimiento para insertar ubigeo*/
 create procedure insertarUbigeo
	
	@departamento varchar (30) ,
	@provincia varchar (30) ,
	@distrito varchar (30)
	
	as
	insert into Ubigeo values (@departamento,@provincia,@distrito)
	go
	  
     execute insertarUbigeo 'LIMA','HUAURA','HUAURA'
     execute insertarUbigeo'LIMA','HUAURA','HUACHO'
     execute insertarUbigeo'LIMA','HUAURA','SAYAN'
           
 execute consultarUsuario 22222222
 
  execute mostrarEmpleados
  
   execute eliminarEmpleado 22222222
   
   execute listarEmpleado
   
   create procedure reporteEmpleado
   as
   select usuario_id ,apellidoPaterno ,apellidoMaterno ,
    nombres  ,email ,Empleado.direccion ,
   celular ,foto ,nombre  from Empleado join Sucursal
   on Empleado.idSucursal = Sucursal.idSucursal
   
   execute reporteEmpleado
   
   /* procedimiento almacenado para buscar empleado por usuario_id */
   
    create procedure buscarEmpleadoporDni
    @dni int
 As
 begin
 select usuario_id, apellidoPaterno, apellidoMaterno ,nombres,
 email,tipoDeUsuario,nick,password,habilitar,foto,direccion,
 celular,sexo,sueldo, idSucursal from Empleado
 where usuario_id = @dni
 order by tipoDeUsuario
 end
 go
 
 execute buscarEmpleadoporDni 43800247
 
 /*procedimiento almacenado para reporte de empleado por usuario_id*/
 create procedure reporteEmpleadoPorDni
 @dni int
   as
   select usuario_id ,apellidoPaterno ,apellidoMaterno ,
    nombres  ,email ,Empleado.direccion ,
   celular ,foto,tipoDeUsuario.nombreDeTipoDeUsuario,habilitar ,nombre  
   from tipoDeUsuario join Empleado 
   on tipoDeUsuario.tipoDeUsuario_id = Empleado.tipoDeUsuario join Sucursal
   on Empleado.idSucursal = Sucursal.idSucursal
   where usuario_id = @dni
   
   execute reporteEmpleadoPorDni 43800247
   
   
   /* procedimiento para insertar clientes 
 create procedure registarClientes
 @idclientes int output,
 @dni char(8),
 @apellidos varchar(50),
 @nombres varchar(50),
 @direccion varchar(100),
 @telefono_celular varchar(12),
 @idubigeo int
 as
 insert into Cliente (DNI,Apellidos,Nombres,Direccion,Telefono_Celular,idUbigeo)
 values (@dni,@apellidos,@nombres,@direccion, @telefono_celular,@idubigeo)
 go*/
 
 /* procedimiento para mostrar clientes*/
CREATE PROCEDURE mostrarClientes
as
select * from Cliente
order by Apellidos asc
go
 execute mostrarClientes
go
  /* procedimiento para registrar clientes
 create procedure registrarCliente
(
@Dni char(8),
@Apellidos Varchar(50),
@Nombres Varchar(50),
@Direccion Varchar(100),
@Telefono Varchar(12),
@idsucursal int,
@Mensaje Varchar(100) Output
)
As Begin
	If(Exists(Select * From Cliente Where DNI=@Dni))
		Set @Mensaje='ADVERTENCIA, Los Datos del CLIENTE ya Existen...!!!'
	Else Begin
		Insert Cliente Values(@Dni,@Apellidos,@Nombres,@Direccion,@Telefono,@idsucursal)
		Set @Mensaje='CLIENTE registrado exitosamente...!!!'
		End
	End */
	
	create procedure registrarCliente
(
@Dni int,
@Apellidos Varchar(50),
@Nombres Varchar(50),
@Direccion Varchar(100),
@Celular Char(9),
@idsucursal Varchar(3)
)
As 
Begin
	Insert Cliente Values(@Dni,@Apellidos,@Nombres,@Direccion,@Celular,@idsucursal)
End
execute registrarCliente 43800247,'Salvador Rojas','Edgar Roger','Av. El carmen Lote Nº4-Huaura','915962705','1'
 /* procedimiento para editar clientes*/
  create procedure editarCliente
(
@Dni int,
@Apellidos Varchar(50),
@Nombres Varchar(50),
@Direccion Varchar(100),
@Celular Char(9),
@idSucursal varchar(3)
)
As Begin
	
		Update Cliente Set Apellidos=@Apellidos,Nombres=@Nombres,Direccion=@Direccion,
		Celular=@Celular, idSucursal = @idSucursal 
		Where DNI=@Dni
		
	End
 

 
 /* procedimiento almacenado para buscar cliente por apellidos o nombres*/
 create procedure buscarDatosClientePorApellidosONombres
@datos Varchar(100)
As Begin
	Select Dni,Apellidos,Nombres,Cliente.Direccion,Celular,Sucursal.nombre 
	From Cliente join Sucursal
	on Cliente.idSucursal = Sucursal.idSucursal
	Where Apellidos+' '+ Nombres like @Datos + '%' or Apellidos like @Datos + '%' or Nombres like @Datos+ '%'
End

execute buscarDatosCliente 'Fiorela Teo'

 /* procedimiento almacenado para buscar cliente por dni*/
 create procedure buscarDatosClientePorDni
@datos int
As Begin
	Select Dni,Apellidos,Nombres,Cliente.Direccion,Celular,Sucursal.idSucursal
	From Cliente join Sucursal
	on Cliente.idSucursal = Sucursal.idSucursal
	Where Dni like @Datos + '%'
End

execute buscarDatosClientePorDni '43800240'


 
 delete Cliente 
 where DNI = '66666666'
 
 ---10,9,7,11,8,12,13
 /*procedimiento para buscar clientes */
 Create Proc FiltrarDatosCliente
@Datos Varchar(80)
As Begin
	Select IdCliente,DNI,Apellidos,Nombres,Direccion,Celular 
	From Cliente Where Apellidos+' '+ Nombres=@Datos or Apellidos=@Datos or Nombres=@Datos
End
Go


/*procedimiento para eliminar clientes */
create procedure eliminarClientes
 @dni int 
 as
 delete from Cliente where Dni = @dni
 
 execute eliminarClientes '43800248'
 go
 
 /*procedimiento para registrar producto*/
 Create Procedure registrarProducto
@idCategoria Int,
@idPresentacion Int,
@marca Varchar(80),
@nombre Varchar(50),
@stock Int,
@precioCompra Decimal(6,2),
@precioVenta Decimal(6,2),
@imagen image

As Begin
	
		Insert Producto Values(@idCategoria,@idPresentacion,@marca,@nombre,
		@stock,@precioCompra,@precioVenta,@imagen)
End
Go

/*procedimiento almacenado para editar producto*/
Create Proc editarProducto
@idProducto int,
@idCategoria Int,
@idPresentacion Int,
@marca Varchar(80),
@nombre Varchar(50),
@stock Int,
@precioCompra Decimal(6,2),
@precioVenta Decimal(6,2),
@imagen image
As Begin
	
		Update Producto Set IdCategoria=@idCategoria,IdPresentacion=@idPresentacion,
		Marca=@marca,Nombre=@nombre,Stock=@stock,
		PrecioCompra=@precioCompra,PrecioVenta=@precioVenta,Imagen=@imagen 
		Where IdProducto=@idProducto
	
End
Go
execute editarProducto 1,2,1,'insecticida','fuego','13.00','15.00',5,''

delete Producto
where IdProducto = 1
/*procedimiento almacenado para eliminar producto*/
create procedure eliminarProducto
@idProducto int
as
delete from Producto
where IdProducto = @idProducto
go

/* procedimiento almacenado para mostrar productos*/
create procedure mostrarProducto
as
select IdProducto,Categoria.IdCategoria,IdPresentacion,Nombre,Marca,
PrecioCompra,PrecioVenta,Stock,Categoria.Descripcion,Imagen 
from Producto inner join Categoria
on.Producto.IdCategoria = Categoria.IdCategoria
order by IdProducto asc
go

/*procedimiento almacenado para registrar presentacion*/

create procedure registraPresentacion
	@nombre varchar (50),
	@descripcion varchar(80) 
	
	as
	insert into Presentacion values (@nombre,@descripcion)
	go
execute registraPresentacion 'dsdsd','dddsdsd'
/*procedimiento almacenado para listar presentacion*/
create procedure mostrarPresentacion
	as
	begin
	select idPresentacion,nombre, descripcion from Presentacion
	end
	go
/*procedimiento almacenado para listar presentacion por nombre*/
create procedure buscarDatosPresentacionxNombre
	@datos varchar(50)
	as
	begin
	select idPresentacion,nombre, descripcion from Presentacion
	where nombre like @datos + '%'
	end
	go
/*procedimiento almacenado para listar presentacion por codigo*/

create Proc buscarDatosPresentacion
@Datos int
as
begin
	select idPresentacion,nombre, descripcion from Presentacion
	where nombre like @Datos + '%'
end
go
/*procedimiento almacenado para editar presentacion*/
Create Proc editarPresentacion
@idPresentacion Int,
@nombre varchar(50),
@descripcion Varchar(80)

As Begin
	
		Update Presentacion Set nombre=@nombre,descripcion=@descripcion
		Where idPresentacion=@idPresentacion
	
End
Go

/*procedimiento almacenado para eliminar presentacion*/
create procedure eliminarPresentacion
@idPresentacion int
as
delete from Presentacion
where idPresentacion = @idPresentacion
go
	
	execute eliminarPresentacion 2
/*procedimiento para registrar categoria*/
 Create Procedure registrarCategoria
@descripcion Varchar(50)
As Begin
	
		Insert Categoria Values(@descripcion)
End
Go

/*procedimiento almacenado para editar categoria*/
Create Proc editarCategoria
@idCategoria Int,
@descripcion Varchar(50)

As Begin
	
		Update Categoria Set Descripcion=@descripcion
		Where IdCategoria=@idCategoria
	
End
Go

/*procedimiento almacenado para eliminar categoria*/
create procedure eliminarCategoria
@idCategoria int
as
delete from Categoria
where IdCategoria = @idCategoria
go

/* procedimiento almacenado para mostrar categorias*/
create procedure mostrarCategorias
as
select * from Categoria
order by IdCategoria asc
go

/*procedimiento almacenado para generar el idProducto*/
Create Proc generarIdProducto
@idProducto Int Output
As Begin
	If(Not Exists(Select IdProducto From Producto))
		Set @idProducto=1
	Else Begin
		Set @idProducto=(Select Max(IdProducto)+1 FROM Producto)
		End
	End
Go
/*procedimiento almacenado para generar el idCategoria*/
Create Proc generarIdCategoria
@idCategoria Int Out
As Begin
	If(Not Exists(Select IdCategoria From Categoria))
		Set @idCategoria=1
	Else Begin
		Set @idCategoria=(Select Max(IdCategoria)+1 FROM Categoria)
		End
	End
Go

execute generarIdCategoria 1
/*procedimiento almacenado para
e Buscar Categorias*/

Create Proc buscarDatosCategorias
@Datos int
As Begin
	Select * From Categoria Where IdCategoria=@Datos
End
Go

/*procedimiento almacenado para Buscar Categorias*/

Create Proc buscarDatosCategoriasxNombre
@Datos varchar(50)
As Begin
	Select * From Categoria Where Descripcion=@Datos
End
Go
execute buscarDatosCategoriasxNombre 'Fertilizantes Horganicos'

/*procedimiento almacenado para reporte de producto*/
create procedure reporteProducto
   as
   
   select IdProducto,  
    Producto.Nombre ,Marca,Categoria.Descripcion ,Presentacion.nombre ,
    PrecioCompra  ,PrecioVenta ,
   Stock ,Imagen from Producto join Presentacion
   on Producto.IdPresentacion = Presentacion.idPresentacion join Categoria
   on Producto.IdCategoria = Categoria.IdCategoria

/*procedimiento almacenado para reporte de producto por codigo*/

create procedure reporteProductoxCategorias
   @codigo varchar(50)
   as 
   
 select IdProducto,  
    Producto.Nombre ,Marca,Categoria.Descripcion ,Presentacion.nombre ,
    PrecioCompra  ,PrecioVenta ,
   Stock ,Imagen from Producto join Presentacion
   on Producto.IdPresentacion = Presentacion.idPresentacion join Categoria
   on Producto.IdCategoria = Categoria.IdCategoria
   where Categoria.Descripcion = @codigo
execute reporteProductoxCodigo Fertilizantes


/* para reporte de empleado por tipo de empleado*/
 create procedure reportePorTipoDeEmpleado
 @tipo varchar(30)
   as
   select nombreDeTipoDeUsuario,usuario_id ,apellidoPaterno ,apellidoMaterno ,
    nombres  ,email ,Empleado.direccion ,
   celular ,foto ,nombre  from Empleado join Sucursal
   on Empleado.idSucursal = Sucursal.idSucursal join tipoDeUsuario
   on Empleado.tipoDeUsuario = tipoDeUsuario.tipoDeUsuario_id
   
   where nombreDeTipoDeUsuario = @tipo
   
   execute reportePorTipoDeEmpleado ' Administrador'
   
 /*para reporte catgorias*/
 create proc reporteCategoria
 
 as
 select * from Categoria
 
 
 execute reporteCategoria 'Semillas'
 
  /*para reporte presentacion*/
 create proc reportePresentacion
 
 as
 select * from Presentacion
 
 
 CREATE PROCEDURE spCargarCorrelativo --1,'0001'
	 @id_tipcom int,
	 @NumSerie nchar(6)
	  as
	   BEGIN
		 DECLARE @correlativo nchar(6)
		 SET @correlativo = (SELECT MAX(Comprobante.NroDocumento) FROM Comprobante
		  WHERE Comprobante.IdComprobante=@id_tipcom AND Comprobante.Serie= @NumSerie)
		 SET @correlativo = RIGHT('00000'+LTRIM(RIGHT(ISNULL(@correlativo,'00000'),6)+1),6)
		 SELECT  @correlativo AS Correlativo
	 END


/* Mostrar Comprobantes */

create proc mostrarComprobante
as 
select Comprobante.IdComprobante,(apellidoPaterno + ' ' + apellidoMaterno + ' ' + Empleado.nombres)as Empleado, 
(Apellidos + ' ' + Cliente.Nombres)as Cliente,Cliente.Celular,Dni,Cliente.Direccion,(convert(varchar(10),FechaVenta,101))As Fecha_Venta,
TipoDocumento,
Serie,NroDocumento as Corelativo,Igv,(Nombre + ' - ' + Marca) as Nombre_Producto,(PrecioVenta)as Precio_Unitario,Cantidad,
(Cantidad*PrecioVenta)as Importe
from Comprobante inner join Empleado 
on Comprobante.IdEmpleado = Empleado.usuario_id inner join Cliente
on Comprobante.DniCliente = Cliente.Dni inner join DetalleComprobante
on Comprobante.IdComprobante =DetalleComprobante.IdComprobante inner join Producto
on DetalleComprobante.IdProducto = Producto.IdProducto

/*eliminar comprobante*/
create proc eliminarComprobante
@idcom int
as
delete Comprobante
where Comprobante.IdComprobante = @idcom

/*buscar comprobantes*/
create proc buscarComprobante
@texto dateTime,
@texto2 dateTime
as 
select Comprobante.IdComprobante,(IdEmpleado)as Empleado, 
(DniCliente)as Cliente, Serie,NroDocumento as Correlativo,TipoDocumento,FechaVenta As Fecha_Venta,
IdFormaPago as Tipo_de_Pago, Total from Comprobante
where FechaVenta >= @texto and FechaVenta <= @texto2
order by Comprobante.IdComprobante desc

where FechaVenta >= '16-11-2019' and FechaVenta <= '21-11-2019'

/*buscar Comprobante por nombrede cliente*/
create proc buscarComprobnatePorCliente
@datos varchar(100)
as
select Comprobante.IdComprobante,Comprobante.IdEmpleado,
Comprobante.DniCliente,Comprobante.Serie,Comprobante.NroDocumento,
Comprobante.TipoDocumento,Comprobante.FechaVenta,Comprobante.IdFormaPago,
Comprobante.total
from Comprobante inner join Cliente
on Comprobante.DniCliente=Cliente.Dni
where Cliente.Apellidos like @datos + '%' or Cliente.Nombres like @datos + '%' or Cliente.Apellidos + ' ' + Cliente.Nombres like @datos + '%'

execute buscarComprobnatePorCliente 'v'

select * from Cliente
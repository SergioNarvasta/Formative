CREATE DATABASE AGRICOLA_MILAGROS
on primary
(
NAME = 'AGRICOLA_MILAGROS', FILENAME = 'D:\Proyecto_DSI\Agricola_Milagros\BAGRICOLA_MILAGROS.mdf',
SIZE = 5120KB,
MAXSIZE = UNLIMITED,
FILEGROWTH = 1024KB
)
LOG ON
(
NAME = N'AGRICOLA_MILAGROS_log', 
FILENAME = 'D:\Proyecto_DSI\Agricola_Milagros\AGRICOLA_MILAGROS_log.ldf',
SIZE = 2000KB,
MAXSIZE = 2048GB,
FILEGROWTH = 10%
)
GO
--ingresamos  a la base de datos
use AGRICOLA_MILAGROS
go
--- creando las tablas de la base de datos
CREATE  TABLE  Ubigeo(
	idUbigeo Int identity Primary key,
	departamento varchar (30) not null,
	provincia varchar (30) not null,
	distrito varchar (30) not null,
	)
go
Create Table  Sucursal(
	idSucursal varchar(3)  Primary key ,
	nombre varchar (50) Not Null,
	idUbigeo int Not Null References Ubigeo,
	direccion varchar (50) Not Null,
	imagen image null,
	telefono integer Not Null
	
	)
 create Table Serie(
idSerie int identity(1,1) primary key ,
idSucursal varchar(3) Not Null ,
numeroSerie Char(5) Not Null,
Id_TipCom_Serie int Not Null
)---esta se agrego
Create Table tipoDeUsuario
(tipoDeUsuario_id Int  Primary Key,
nombreDeTipoDeUsuario Varchar(30) Not Null
)
Go
/*create table Historial(
idHistorial int identity,
idEmpleado int References Empleado,
idTipoDeUsuario int references tipoDeUsuario,
fecha dateTime not null
)
go*/
create table Empleado (
 usuario_id Int  primary key,
 apellidoPaterno varchar(30),
 apellidoMaterno varchar(30),
 nombres varchar(30),
 email varchar(50), 
 tipoDeUsuario int Not Null References tipoDeUsuario,
 nick varchar (30),
 password varchar(30),
 habilitar varchar(1),
 foto image,
 direccion varchar(50),
 celular char(9),
 sexo varchar(1),
 sueldo decimal(6,2),
 idSucursal varchar(3) Not Null References Sucursal
)
go
Create Table Categoria
(IdCategoria Int Identity Primary Key,
Descripcion Varchar(50) Not Null
)
Go
create table Presentacion(
	idPresentacion int identity Primary key,
	nombre varchar (50) not null,
	descripcion varchar(80) not null
	
	)
go
/*create table Marca(
	idMarca int identity Primary key,
	nombre varchar (50) not null 
	
	)
go*/
Create Table Producto
(IdProducto Int Identity Primary Key,
IdCategoria Int Not Null, 
IdPresentacion int Not Null ,
Nombre Varchar(50) Not Null,
Marca Varchar(80) Not Null,
PrecioCompra Decimal(6,2) Not Null,
PrecioVenta Decimal(6,2) Not Null,
Stock Int Not Null,
Imagen image null
)
Go
create table Proveedor(
	idProveedor int identity Primary key,
	razonSocial varchar(150) not null,
	sectorComercial varchar(50) not null,
	numeroDocumento char (7) not null,
	tipoDocumento Varchar(7) Check(TipoDocumento In('Boleta','Factura')),
	direccion varchar (100) null,
	telefono varchar (10) null,
	email varchar (50) null,
	url varchar (100) null
	)
go
create table Horario(
    idHorario int identity Primary key,
    idEmpleado int Not Null References Empleado,
	turno varchar (10) not null,
	horaEntrada varchar (10) not null,
	horaSalida varchar (10) not null 
	
	)
go
Create Table Cliente
(
Dni int primary key,
Apellidos Varchar(50),
Nombres Varchar(50),
Direccion Varchar(100) ,
Celular Char(9),
idSucursal varchar(3) Not Null References Sucursal 
)
go
create table Ingreso(
	idIngreso int identity Primary key,
	DniEmpleado int not null References Empleado,
	idProveedor int not null References Proveedor,
	fechaIngreso date null,
	serie char(5) Not Null,
	nroDocumento char(7) Not Null,
	tipoDocumento varchar(7) Check(TipoDocumento In('Boleta','Factura')),
	estado varchar (10) null,
	total money not null
)
go
create table DetalleIngreso(
	idDetalleIngreso int Identity Primary key,
	idIngreso int not null References Ingreso,
	idProducto int  not null References Producto,
	stock_inicial int not null,
	precioCompra decimal(6,2) not null,
	fecha_produccion date not null,
	fecha_vencimiento date not null,
	igv money not null,
	subtotal money not null
	)
go


ALTER TABLE DetalleIngreso  WITH CHECK ADD  CONSTRAINT [FK_detalle_Ingreso_Ingreso] FOREIGN KEY([idIngreso])
REFERENCES Ingreso ([idIngreso])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE DetalleIngreso  WITH CHECK ADD  CONSTRAINT [FK_detalle_Ingreso_Producto] FOREIGN KEY([idProducto])
REFERENCES Producto ([IdProducto])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

create table FormaDePago(
	IdFormaDePago int identity Primary key,
	nombre varchar(30) not null,
	)
go
create Table Comprobante
(IdComprobante int Identity Primary Key,
IdEmpleado int Not Null References Empleado,
DniCliente int Not Null References Cliente,
Serie char(5) Not Null,
NroDocumento char(7) Not Null,
TipoDocumento varchar(7) Check(TipoDocumento In('Boleta','Factura')),
FechaVenta dateTime Not Null,
IdFormaPago int Not NUll References FormaDePago,
total money Not null,

)
go
create Table DetalleComprobante
(IdDetalleComprobante int Identity Primary Key,
IdProducto int Not Null References Producto,
IdComprobante Int Not Null References Comprobante,
Cantidad int Not Null,
PrecioUnitario decimal(6,2) Not Null,
Igv money Not null,
Subtotal money not null
)
Go


ALTER TABLE DetalleComprobante  WITH CHECK ADD  CONSTRAINT [FK_detalle_Comprobante_Comprobante] FOREIGN KEY([IdComprobante])
REFERENCES Comprobante ([IdComprobante])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE DetalleComprobante  WITH CHECK ADD  CONSTRAINT [FK_detalle_Comprobante_Producto] FOREIGN KEY([IdProducto])
REFERENCES Producto ([IdProducto])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE Comprobante  WITH CHECK ADD  CONSTRAINT [FK_Comprobante_Cliente] FOREIGN KEY([DniCliente])
REFERENCES Cliente ([Dni])
ON UPDATE CASCADE
ON DELETE CASCADE
GO




Insert cliente Values('47660746','Vásquez Ventura','Juan','Urb. Santa Rosa','996687349')
Insert Categoria Values('Bebidas'),('Carnes'),('Verduras')

select* from Comprobante
select * from Cliente

insert Empleado
insert Cliente values (74563312,'Flex Turizo','Andres Lenny','AV. Los Alisos',998956342,1)
insert Cliente values (74563332,'Rafael Tolentino','Cristina paul','AV. Los Alisos',998956342,1)
insert Cliente values (74563552,'Ventocilla Leon','Cinthia Leydi','AV. Los Alisos',998956342,2)
insert Cliente values (74563662,'Perez Cerna','Alex Leonardo','AV. Los Alisos',998956342,2)
insert Cliente values (74563372,'Rufino Romero','Angela Flor','AV. Los Alisos',998956342,2)
insert Cliente values (74563382,'Flores Kanematsu','Arthur Felix','AV. Hualmay',998956342,3)
insert Cliente values (74563392,'Guardales Huertas','Gerardo Vida','AV. Los Torres',998056342,2)
insert Cliente values (74963312,'Espinoza Torres','Jesus Miguel','AV. Angeles',998956342,1)
insert Cliente values (74562322,'Flores Huertas','Jorge Pedro','AV. San Pedrp',998956342,1)




insert into Comprobante values()
Go

--PROCEDIMIENTOS ALMACENADOS EN SQL SERVER 

Create Proc ListarClientes
As Begin
	Select IdCliente,DNI,Apellidos,Nombres,Direccion,Telefono From Cliente 
   End
Go

Create Proc RegistrarCliente
(@DNI char(8),
@Apellidos Varchar(50),
@Nombres Varchar(50),
@Direccion Varchar(100),
@Telefono Varchar(12),
@Mensaje Varchar(50) Output
)
As Begin
	If(Exists(Select * From Cliente Where Dni=@DNI))
		Set @Mensaje='Los Datos del Cliente ya Existen.'
	Else Begin
		Insert Cliente Values(@DNI,@Apellidos,@Nombres,@Direccion,@Telefono)
		Set @Mensaje='Registrado Correctamente.'
		End
	End
Go

Create Proc ActualizarCliente
(@DNI Char(8),
@Apellidos Varchar(50),
@Nombres Varchar(50),
@Direccion Varchar(100),
@Telefono Varchar(12),
@Mensaje Varchar(50) Output
)
As Begin
	If(Not Exists(Select * From Cliente Where Dni=@DNI))
		Set @Mensaje='Los Datos del Cliente no Existen.'
	Else Begin
		Update Cliente Set Apellidos=@Apellidos,Nombres=@Nombres,Direccion=@Direccion,Telefono=@Telefono 
		Where DNI=@DNI
		Set @Mensaje='Registro Actualizado Correctamente.'
		End
	End
Go

Create Proc FiltrarDatosCliente
@Datos Varchar(80)
As Begin
	Select IdCliente,DNI,Apellidos,Nombres,Direccion,Telefono 
	From Cliente Where Apellidos+' '+ Nombres=@Datos or Apellidos=@Datos or Nombres=@Datos
End
Go

Create Proc FiltrarDatosProducto
@Datos Varchar(50)
As Begin
	Select IdProducto,IdCategoria,Nombre,Marca,PrecioCompra,PrecioVenta,Stock,FechaVencimiento 
	From Producto where Nombre=@Datos or Marca=@Datos or Nombre+' '+Marca=@Datos
End
Go
--FiltrarDatosProducto 'G'
Create Proc ListadoProductos
As Begin
	Select IdProducto,IdCategoria,Nombre,Marca,PrecioCompra,PrecioVenta,Stock,FechaVencimiento 
	From Producto
End
go

Create Proc ListarCategoria
As Begin
	Select * From Categoria
End
Go

Insert Producto Values(1,'Gaseosa','Pepsi',5,4.90,5.90,'12/12/2013')
Go

Create proc RegistrarCategoria
@Descripcion Varchar(50),
@Mensaje Varchar(50)  Out
As Begin
	If(Exists(Select * From Categoria Where Descripcion=@Descripcion))
		Set @Mensaje='Categoria ya se encuentra Registrada.'
	Else Begin
		Insert Categoria Values(@Descripcion)
		Set @Mensaje='Registrado Correctamente.'
	End
End
Go

Create proc ActualizarCategoria
@IdC Int,
@Descripcion Varchar(50),
@Mensaje Varchar(50)  Out
As Begin
	If(Not Exists(Select * From Categoria Where IdCategoria=@IdC))
		Set @Mensaje='Categoria no se encuentra Registrada.'
	Else Begin
		Update Categoria Set Descripcion=@Descripcion Where IdCategoria=@IdC
		Set @Mensaje='Se ha Actualizado los Datos Correctamente.'
	End
End
Go

Create Proc BuscarCategoria
@Datos Varchar(50)
As Begin
	Select * From Categoria Where Descripcion=@Datos
End
Go

Create Proc RegistrarProducto
@IdCategoria Int,
@Nombre Varchar(50),
@Marca Varchar(80),
@Stock Int,
@PrecioCompra Decimal(6,2),
@PrecioVenta Decimal(6,2),
@FechaVencimiento Date,
@Mensaje varchar(50) Out
As Begin
	If(Exists(Select * From Producto Where Nombre=@Nombre And Marca=@Marca))
		Set @Mensaje='Este Producto ya ha sido Registrado.'
	Else Begin
		Insert Producto Values(@IdCategoria,@Nombre,@Marca,@Stock,@PrecioCompra,@PrecioVenta,@FechaVencimiento)
		Set @Mensaje='Registrado Correctamente.'
	End
End
Go

Create Proc ActualizarProducto
@IdProducto Int,
@IdCategoria Int,
@Nombre Varchar(50),
@Marca Varchar(80),
@Stock Int,
@PrecioCompra Decimal(6,2),
@PrecioVenta Decimal(6,2),
@FechaVencimiento Date,
@Mensaje varchar(50) Out
As Begin
	If(Not Exists(Select * From Producto Where IdProducto=@IdProducto))
		Set @Mensaje='Este producto no se encuentra Registrado.'
	Else Begin
		Update Producto Set IdCategoria=@IdCategoria,Nombre=@Nombre,Marca=@Marca,Stock=@Stock,
		PrecioCompra=@PrecioCompra,PrecioVenta=@PrecioVenta,FechaVencimiento=@FechaVencimiento 
		Where IdProducto=@IdProducto
	Set @Mensaje='Registro Actualizado Correctamente.'
	End
End
Go


Create Proc ListarCargo
As Begin
	Select * From tipoDeUsuario
	End
Go

Create Proc RegistrarCargo
@nombreDeTipoDeUsuario Varchar(30),
@Mensaje Varchar(50) Out
As Begin
	If(Exists(Select * From tipoDeUsuario Where nombrDeTipoDeUsuario=@nombreDeTipoDeUsuario))
		Set @Mensaje='El Cargo ya se Encuentra Registrado.'
	Else Begin
		Insert tipoDeUsuario values(@nombreDeTipoDeUsuario)
		Set @Mensaje='Registrado Correctamente.'
	End
End
Go

Create Proc ActualizarCargo
@IdCargo Int,
@Descripcion Varchar(30),
@Mensaje Varchar(100) Out
As Begin
	If(Exists(Select * From tipoDeUsuario Where nombrDeTipoDeUsuario=@Descripcion))
		Set @Mensaje='No se ha Podido Actualizar los Datos porque ya Existe el cargo. '+@Descripcion
	Else Begin
		If(Not Exists(Select * From tipoDeUsuario Where tipoDeUsuario=@IdCargo))
			Set @Mensaje='El Cargo no se Encuentra Registrado.'
		Else Begin
		Update tipoDeUsuario Set nombrDeTipoDeUsuario=@Descripcion Where tipoDeUsuario=@IdCargo
			Set @Mensaje='Los datos se han Actualizado Correctamente.'
			End
		End
	End
Go


Create Proc BuscarCargo
@Descripcion varchar(30)
as begin
	Select * From tipoDeUsuario Where nombrDeTipoDeUsuario=@Descripcion
End
Go

Create Proc Serie_Documento
@Serie char(5) out
as begin
Set @Serie='00001'
end
go

Create Procedure Numero_Correlativo
@TipoDocumento Varchar(7),
@NroCorrelativo Char(7)Out
As Begin
	Declare @Cant Int
	If(@TipoDocumento='Factura')
	Begin
	Select @Cant=Count(*)+1 From Venta where TipoDocumento='Factura'
		If @Cant<10
			Set @NroCorrelativo='000000'+Ltrim(Str(@Cant))
		Else
			If @Cant<100
				Set @NroCorrelativo='00000'+Ltrim(Str(@Cant))
			Else
				If @Cant<1000
					Set @NroCorrelativo='0000'+Ltrim(Str(@Cant))
				Else
					If(@Cant<10000)
						Set @NroCorrelativo='000'+LTRIM(STR(@Cant))
					Else
						If(@Cant<100000)
							Set @NroCorrelativo='00'+LTRIM(STR(@Cant))
						Else
							If(@Cant<1000000)
								Set @NroCorrelativo='0'+LTRIM(str(@Cant))
							Else
								If(@Cant<10000000)
									Set @NroCorrelativo=LTRIM(str(@Cant))
	End
	if(@TipoDocumento='Boleta')
	begin
		Select @Cant=Count(*)+1 From Venta where TipoDocumento='Boleta'
		If @Cant<10
			Set @NroCorrelativo='000000'+Ltrim(Str(@Cant))
		Else
			If @Cant<100
				Set @NroCorrelativo='00000'+Ltrim(Str(@Cant))
			Else
				If @Cant<1000
					Set @NroCorrelativo='0000'+Ltrim(Str(@Cant))
				Else
					If(@Cant<10000)
						Set @NroCorrelativo='000'+LTRIM(STR(@Cant))
					Else
						If(@Cant<100000)
							Set @NroCorrelativo='00'+LTRIM(STR(@Cant))
						Else
							If(@Cant<1000000)
								Set @NroCorrelativo='0'+LTRIM(str(@Cant))
							Else
								If(@Cant<10000000)
									Set @NroCorrelativo=LTRIM(STR(@Cant))
			End
	End
Go
 
/*Create Table Usuario
(IdUsuario Int Identity Primary Key,
IdEmpleado Int Not Null References Empleado,
Usuario Varchar(20) Not Null,
Contraseña Varchar(12) Not Null
)
Go

Create Proc RegistrarUsuario
@IdEmpleado Int,
@Usuario Varchar(20),
@Contraseña Varchar(12),
@Mensaje Varchar(50) Out
As Begin
	If(Not Exists(Select * From Empleado Where IdEmpleado=@IdEmpleado))
		Set @Mensaje='Empleado no Registrado Ok.'
	Else Begin
		If(Exists(Select * From Usuario Where IdEmpleado=@IdEmpleado))
			Set @Mensaje='Este Empleado Ya Tiene una Cuenta de Usuario.'
		Else Begin
			If(Exists(Select * From Usuario Where Usuario=@Usuario))
				Set @Mensaje='El Usuario: '+@Usuario+' No está Disponible.'
			Else Begin
				Insert Usuario Values(@IdEmpleado,@Usuario,@Contraseña)
					Set @Mensaje='Usuario Registrado Correctamente.'
				 End
			 End
		 End
   End
Go

Create Proc IniciarSesion
@Usuario Varchar(20),
@Contraseña Varchar(12),
@Mensaje Varchar(50) Out
As Begin
	Declare @Empleado Varchar(50)
	If(Not Exists(Select Usuario From Usuario Where Usuario=@Usuario))
		Set @Mensaje='El Nombre de Usuario no Existe.'
		Else Begin
			If(Not Exists(Select Contraseña From Usuario Where Contraseña=@Contraseña))
				Set @Mensaje='Su Contraseña es Incorrecta.'
				Else Begin
					Set @Empleado=(Select E.Nombres+', '+E.Apellidos From Empleado E Inner Join Usuario U 
								   On E.IdEmpleado=U.IdEmpleado Where U.Usuario=@Usuario)
					    Begin
					Select Usuario,Contraseña From Usuario Where Usuario=@Usuario And Contraseña=@Contraseña
							Set @Mensaje='Bienvenido Sr(a): '+@Empleado+'.'
						End
				  End
		   End
   End
Go

Create Proc DevolverDatosSesion
@Usuario Varchar(20),
@Contraseña Varchar(12)
As Begin
	Select E.IdEmpleado,E.Apellidos+', '+E.Nombres 
	From Empleado E Inner Join Usuario U On E.IdEmpleado=U.IdEmpleado 
	Where U.Usuario=@Usuario And U.Contraseña=@Contraseña
	End
Go*/

Create Proc MantenimientoEmpleados
@Dni Int,
@apellidoPaterno Varchar(30),
@apellidoMaterno Varchar(30),
@nombres varchar(30),
@email varchar(50),
@tipoDeUsuario int,
@nick varchar (30),
@password varchar(30),
@habilitar varchar(1),
@foto image,
@direccion varchar(50),
@celular char(9),
@sexo char(1),
@sueldo decimal(6,2),
@idUbigeo Int,
@Mensaje Varchar(100) Out
As Begin
	If(Not Exists(Select * From Empleado Where Dni=@Dni))
		Begin
		Insert Empleado Values(@Dni,@apellidoPaterno,@apellidoMaterno,@nombres,@email,@tipoDeUsuario,
		@nick,@password,@habilitar,@foto,@direccion,@celular,@sexo,@sueldo,@idUbigeo)
			Set @Mensaje='Registrado Correctamente Ok.'
		End
	Else Begin
	If(Exists(Select * From Empleado Where Dni=@Dni))
		Begin
		Update Empleado Set apellidoPaterno=@apellidoPaterno,apellidoMaterno=@apellidoMaterno,
		nombres=@nombres,email=@email, tipoDeUsuario=@tipoDeUsuario,nick=@nick,password=@password,
		habilitar=@habilitar,foto=@foto,direccion=@direccion,celular=@celular,sexo=@sexo,
		sueldo=@sueldo,idUbigeo=@idUbigeo Where Dni=@Dni
			Set @Mensaje='Se Actualizaron los Datos Correctamente Ok.'
		End
	End
End
Go

Create Proc ListadoEmpleados
As Begin
	Select E.*,C.nombrDeTipoDeUsuario From tipoDeUsuario C Inner Join Empleado E On C.tipoDeUsuario=E.tipoDeUsuario
End
Go

/*Create Proc GenerarIdEmpleado
@IdEmpleado Int Out
As Begin
	Declare @Cant As Int
	If(Not Exists(Select Dni From Empleado))
		Set @IdEmpleado=1
	Else Begin
		Set @IdEmpleado=(Select Max(Dni)+1 FROM Empleado)
		End
	End
Go*/

Create proc Buscar_Empleado(
@Datos Varchar(50)
)
As Begin
		Select E.usuario_id,E.apellidoPaterno, E.apellidoMaterno,E.nombres,
		E.email, E.direccion, E.celular,E.foto,C.nombreDeTipoDeUsuario 
		From tipoDeUsuario C Inner Join Empleado E On C.tipoDeUsuario_id=E.tipoDeUsuario
		where E.nombres like @Datos +'%' or E.apellidoPaterno like @Datos +'%'or E.apellidoMaterno like @Datos + '%'
End
go

Create Proc GenerarIdVenta
@IdVenta Int Out
As Begin
	If(Not Exists(Select IdVenta From Venta))
		Set @IdVenta=1
	Else Begin
		Set @IdVenta=(Select Max(IdVenta)+1 FROM Venta)
		End
	End
Go

Create Proc RegistrarVenta
@IdEmpleado Int,
@IdCliente Int,
@Serie Char(5),
@NroDocumento Char(7),
@TipoDocumento Varchar(7),
@FechaVenta Date,
@Total Money,
@Mensaje Varchar(100) Out
As Begin
	Insert Venta Values(@IdEmpleado,@IdCliente,@Serie,@NroDocumento,@TipoDocumento,@FechaVenta,@Total)
		Set @Mensaje='La Venta se ha Generado Correctamente.'
	End
Go

Create Proc RegistrarDetalleVenta
@IdProducto Int,
@IdVenta Int,
@Cantidad Int,
@PrecioUnitario Decimal(6,2),
@Igv Money,
@SubTotal Money,
@Mensaje Varchar(100) Out
As Begin
	Declare @Stock As Int
	Set @Stock=(Select Stock From Producto Where IdProducto=@IdProducto)
	Begin
		Insert DetalleVenta Values(@IdProducto,@IdVenta,@Cantidad,@PrecioUnitario,@Igv,@SubTotal)
			Set @Mensaje='Registrado Correctamente.'
	End
		Update Producto Set Stock=@Stock-@Cantidad Where IdProducto=@IdProducto
End
Go

/*Insert Cargo Values('Administrador')
Go
Insert Empleado Values(1,'34004387','Silva Terrones','Miguel','M','11/01/1990','Urb. Santa Rosa','S')
Go
Insert Usuario Values(1,'Miguelito','123456')
Go

Select * From Usuario
select * from Empleado
Go*/


alter table Producto with check add constraint Fk_Producto_Categoria foreign key (IdCategoria)
references Categoria(IdCategoria)
on update cascade
on delete cascade
go
alter table Producto check constraint Fk_Producto_Categoria
go

alter table Producto with check add constraint Fk_Producto_Presentacion foreign key (IdPresentacion)
references Presentacion(IdPresentacion)
go
alter table Producto check constraint Fk_Producto_Presentacion
go




------------------------------------------------------
use FinanzasPersonales

Create table Cuentas(CuentaId int identity(1,1),
Descripcion varchar(100),
Balance Float)
go
Create table Categorias(CategoriaId int identity(1,1),
Descripcion varchar(100))
go
create table CuentasxCobrar(

	CxcId int identity(1,1),
	Fecha varchar(20),
	CuentaId int foreign key References Cuentas(CuentaId),
	concepto varchar(100),
	Monto float,
	Balance float,
	primary key(CxcId)

)
go
create table Transferencias(
	TransferenciaId int identity primary key,
    Fecha varchar(20),
    CuentaDeOrigenId int,
    CuentaDeDestinoId int,
    Monto float,
    Observacion varchar (50),
    UsuarioId int
)
go
Create Table CuentasxPagar (
	CxpId int identity (1,1) primary key,
	Fecha varchar (20),
	Concepto varchar (50),
	Monto float,
	Balance float
)
go
create table Salidas(
	SalidaId int identity(1,1),
	CuentaId int,
	Fecha varchar(50),
	Monto float,
	Observacion varchar(50)
)

go

create table Entradas(
EntradaId int primary key identity(1,1),
CuentaId int,
CategoriaId int,
Descripcion varchar(100),
Monto float,
Fecha date)

go

create table Miembros(
MiembroId int primary key identity(1,1),
Nombres varchar(30),
Apellidos varchar(60),
Parentesco varchar(20),
)

go 

create table TiposTelefonos(TipoId int,Descripcion varchar(20)); 
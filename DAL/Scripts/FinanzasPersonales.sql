use FinanzasPersonales

Create table Cuentas(CuentaId int identity(1,1),
Descripcion varchar(100),
Balance Float)
go
Create table Categorias(CategoriaId int identity(1,1),
Descripcion varchar(100))
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

create table Salidas(
	SalidaId int identity(1,1),
	CuentaId int,
	Fecha varchar(50),
	Monto float,
	Observacion varchar(50)
)

go

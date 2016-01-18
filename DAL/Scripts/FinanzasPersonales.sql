create table Transferencias(
	TransferenciaId int identity primary key,
    Fecha varchar(15),
    CuentaDeOrigenId int,
    CuentaDeDestinoId int,
    Monto float,
    Observacion varchar (50),
    UsuarioId int
)
)
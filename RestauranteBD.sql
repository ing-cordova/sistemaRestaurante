Use MASTER;
Go
Create database Restaurante;
Go
Use Restaurante;
Go
Create table Roles(
idRol int identity(1,1) primary key not null,
tipoRol varchar(20)
);
Go

Create table Usuarios(
	idUsuario int identity(1,1) primary key not null,
	nombres varchar(50),
	apellidos varchar(50),
	telefono varchar(15),
	edad int,
	email varchar(60),
	nombredeUsuario varchar(30),
	idRol int not null foreign key references Roles(idRol),
	contraseña varchar(64),
	--rol varchar(20)
);
Go
Create table Ordenes(
	idOrden int identity(1,1) primary key not null,
	Fecha date,
	TotalPagar money,
	idUsuario int
);
Go
Create table ProductosOrden(
	idProductoOrden int identity(1,1) primary key not null,
	idProducto int,
	Cantidad int,
	TotalProducto money,
	idOrden int

);
Go
Create table Categorias(
idCategoria int identity (1,1) primary key not null,
nombreCategoria varchar(50)
);
Go

Create table Productos(
	idProducto int identity(1,1) primary key not null,
	Nombre varchar(25),
	Precio money,
	idCategoria int not null foreign key references Categorias(idCategoria)
);
Go

Create table Proveedores(
	idProveedor int identity(1,1) primary key not null,
	Nombre varchar(50),
	Ubicacion varchar(60),
	Telefono varchar(15),
	Email varchar(30)
);
Go

Create table ComprasdeProductos(
	idCompradeProductos int identity(1,1) primary key not null,
	Nombre varchar(50),
	PrecioUnidad money,
	CantidadCompra int,
	FechadeCompra date,
	TotalaPagar money,
	idProveedor int,
	idUsuario int,
	idAlmacen int
);
Go

Create table Almacen(
idAlmacen int identity(1,1) primary key not null,
Nombre varchar(50),
CantidadDisponible int,
Categoria varchar(20),
tipodeunidad varchar(20)
)

Create table IngredientesparaProductos(
idIngrediente int identity(1,1) primary key not null,
idProducto int,
idAlmacen int,
CantidadNecesaria int,
tipodeunidad varchar(20)
);



-- Relaciones

Alter table Ordenes add Foreign key (idUsuario) references Usuarios(idUsuario);
Go
Alter table ComprasdeProductos add Foreign key (idUsuario) references Usuarios(idUsuario);
Go
Alter table ProductosOrden add foreign key(idOrden) references Ordenes(idOrden);
Go
Alter table ProductosOrden add foreign key(idProducto) references Productos(idProducto);
Go
Alter table ComprasdeProductos add foreign key(idUsuario) references Usuarios(idUsuario);
Go
Alter table ComprasdeProductos add foreign key(idProveedor) references Proveedores(idProveedor);
Go
Alter table ComprasdeProductos add foreign key(idAlmacen) references Almacen(idAlmacen);
Go
Alter table IngredientesparaProductos add foreign key(idAlmacen) references Almacen(idAlmacen);
Go
Alter table IngredientesparaProductos add foreign key(idProducto) references Productos(idProducto);
Go
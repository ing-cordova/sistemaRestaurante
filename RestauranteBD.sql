Use MASTER;
Go
Create database RestauranteBD;
Go
Use RestauranteBD;
Go
Create table Usuarios(
	nombredeUsuario varchar(30) primary key not null,
	nombre varchar(30),
	apellidos varchar(30),
	edad int,
	telefono varchar(15),
	email varchar(50),
	contraseña varchar(64),
	rol varchar(20)
);
Go
Create table Proveedores(
	idProveedor int identity(1,1) primary key not null,
	nombre varchar(50),
	ubicacion varchar(60),
	telefono varchar(15),
	email varchar(30)
);
Go
Create table ProductosVenta(
	idProductoV int identity(1,1) primary key not null,
	nombre varchar(25),
	precio money,
	categoria varchar(20)
);
Go
Create table ProductosCompra(
	idProductoC int identity(1,1) primary key not null,
	nombre varchar(25),
	precio money,
	categoria varchar(20),
	idProveedor int foreign key references Proveedores(idProveedor)
);
Go
Create table Ventas(
	idVenta int identity(1,1) primary key not null,
	fechadeVenta date,
	totalPagar money,
	estado varchar(15),
	nombredeUsuario varchar(30) Foreign key references Usuarios(nombredeUsuario)
);
Go
Create table DetallesVenta(
	idDetallesV int identity(1,1) primary key not null,
	idProductoV int foreign key references ProductosVenta(idProductoV),
	precioCompra float,
	cantidad int,
	totalProducto money,
	idVenta int foreign key references Ventas(idVenta)
);
Go
Create table Compraas(
	idCompra int identity(1,1) primary key not null,
	fechadeCompra date,
	totalaPagar money,
	idProveedor int foreign key references Proveedores(idProveedor),
	nombredeUsuario varchar(30) foreign key references Usuarios(nombredeUsuario)
);
Go
Create table DetallesCompra(
	idDetallesC int identity(1,1) primary key not null,
	idProductoC int foreign key references ProductosCompra(idProductoC),
	precioCompra float,
	cantidad int,
	totalProducto money,
	idCompra int foreign key references Compraas(idCompra)
);
Go
Create table Almacen(
idAlmacen int identity(1,1) primary key not null,
idProductoC int foreign key references ProductosCompra(idProductoC),
cantidadDisponible float,
unidad varchar(20)
);
Go

--------Actualización 23/05/2020--------------------
Alter table ProductosVenta drop column categoria
Alter table ProductosCompra drop column categoria

Create table Categorias(
idCategoria int identity(1,1) primary key not null,
nombreCategoria varchar(50)
);
Go

Alter table ProductosVenta add idCategoria int not null;
Alter table ProductosVenta add foreign key(idCategoria) references Categorias(idCategoria);
Alter table ProductosCompra add idCategoria int not null;
Alter table ProductosCompra add foreign key(idCategoria) references Categorias(idCategoria);

-----------Actualizacion 26/05/2020-------------------
Create table Recetas(
idReceta int identity(1,1) primary key not null,
idProductoV int foreign key references ProductosVenta(idProductoV),
idProductoC int foreign key references ProductosCompra(idProductoC),
cantidadProdIngrediente int
);

-----------Actualizacion 01/06/2020-------------------
/*Solo le cambie el nombre a la tabla Compras a 'Compraas', borren esta base, 
y ejecuten este script*/
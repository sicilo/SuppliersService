CREATE DATABASE SupplierServices
GO

USE SupplierServices
GO

CREATE TABLE Suppliers(
	Id			INT IDENTITY PRIMARY KEY,
	Name		NCHAR(50),
	Email		NCHAR(100),
	Created		DATETIME DEFAULT GETDATE()
);
GO
 
INSERT INTO Suppliers(Name,Email) VALUES
('Importaciones Tekus S.A.','ImportacionesTekus@dominio.com'),
('Exportaciones Tekus S.A.','Exportaciones @dominio.com'),
('Computadoras	Tekus S.A.','Computadoras@dominio.com'),
('Celulares		Tekus S.A.','Celulares@dominio.com'),
('Accesorios	Tekus S.A.','Accesorios@dominio.com'),
('AWS','AWS@dominio.com'),
('Motos VMW','MotosVMW@dominio.com'),
('Autos Masda','AutosMasda@dominio.com'),
('Huawei','Huawei@dominio.com'),
('Lenovo','Lenovo@dominio.com');
GO

CREATE TABLE Services(
	Id				INT IDENTITY PRIMARY KEY,
	IdSupplier		INT FOREIGN KEY REFERENCES Suppliers(Id),
	Name			NCHAR(50),
	ValuePerHour	DECIMAL(18,2),
	Created			DATETIME DEFAULT GETDATE()
);
GO

INSERT INTO Services(IdSupplier,Name,ValuePerHour) VALUES
(1,'Descarga espacial de contenidos',705.16),
(1,'Desaparición forzada de bytes',500.16),
(2,'Servicio de Drones',2400.16),
(2,'Busqueda Satelital',1200.16),
(4,'Mantenimiento SmartPhone',630.16),
(10,'Mantenimiento Equipo',630.16),
(9,'Mantenimiento Equipo',630.16),
(3,'Ensanblado de Equipos',480.16),
(3,'Mantenimiento de Equipos',480.16),
(6,'CodeCommit',480.16),
(5,'Mantenimiento Accesorios',5000.16);
GO

CREATE TABLE CountriesPerService(
	Id				INT IDENTITY PRIMARY KEY,
	IdService		INT FOREIGN KEY REFERENCES Services(Id),
	Name			NCHAR(50)
);
GO

INSERT INTO CountriesPerService(IdService,Name) VALUES 
(1,'Colombia'),
(1,'Perú'),
(1,'México'),
(2,'Estados Unidos'),
(3,'Nicaragua'),
(4,'Alemania'),
(10,'Canada'),
(9,'Argentina'),
(8,'Costa Rica'),
(8,'Panama');
GO
	
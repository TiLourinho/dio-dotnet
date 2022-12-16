CREATE TABLE Enderecos (
	Id int PRIMARY KEY IDENTITY (1, 1) NOT NULL,
	IdCliente int NULL,
	Rua varchar(255) NULL,
	Bairro varchar(255) NULL,
	Cidade varchar(255) NULL,
	Estado char(2) NULL,

	CONSTRAINT FK_Enderecos_Clientes FOREIGN KEY (IdCliente)
	REFERENCES Clientes(Id)
);
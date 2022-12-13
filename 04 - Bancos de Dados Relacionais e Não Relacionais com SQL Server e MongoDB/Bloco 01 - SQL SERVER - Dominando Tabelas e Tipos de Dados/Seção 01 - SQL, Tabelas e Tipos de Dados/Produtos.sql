CREATE TABLE Produtos (
	Id int PRIMARY KEY IDENTITY(1, 1) NOT NULL,
	Nome varchar(255) NOT NULL,
	Cor varchar(50) NULL,
	Preço decimal(13, 2) NOT NULL,
	Tamanho varchar(5) NULL,
	Gênero char(1) NULL
)
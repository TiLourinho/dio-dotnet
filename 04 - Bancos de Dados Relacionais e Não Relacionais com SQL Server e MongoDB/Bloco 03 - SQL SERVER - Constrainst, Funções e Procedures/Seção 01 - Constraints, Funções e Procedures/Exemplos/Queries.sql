SELECT * FROM Produtos;

-- Insere a constraint UNIQUE na coluna Nome
ALTER TABLE Produtos
ADD UNIQUE(Nome);

-- Insere a constraint CHECK, nomeando-a de CHK_Genero, na coluna Genero fazendo com que ela aceite somente as letras M, F e U
ALTER TABLE Produtos
ADD CONSTRAINT CHK_Genero CHECK(Genero = 'M' OR Genero = 'F' OR Genero = 'U');

-- Insere a constraint CHECK, nomeando-a de CHK_Tamanho, na coluna Tamanho fazendo com que ela aceite somente as letras P, M, G, GG e vazio
ALTER TABLE Produtos
ADD CONSTRAINT CHK_Tamanho CHECK(Tamanho = 'P' OR Tamanho = 'M' OR Tamanho = 'G' OR Tamanho = 'GG' OR Tamanho = '');

-- Insere a constraint CHECK, nomeando-a de CHK_Preco, na coluna Preco fazendo com que ela aceite somente números positivos
ALTER TABLE Produtos
ADD CONSTRAINT CHK_Preco CHECK(Preco > 0);

-- Insere a constraint DEFAULT na coluna DataCadastro fazendo com que ela insira, por padrão, GETDATE() em sua criação
ALTER TABLE Produtos
ADD DEFAULT GETDATE() FOR DataCadastro;

-- Insere novos produtos na tabela Produtos, omitindo a coluna DataCadastro
INSERT INTO Produtos (Nome, Cor, Preco, Tamanho, Genero)
VALUES ('Jogging Socks, M', 'Branco', 8.99, 'M', 'U'),
	   ('Jogging Socks, L', 'Branco', 8.99, 'G', 'U');

-- Deleta a constraint CHK_Tamanho
ALTER TABLE Produtos
DROP CONSTRAINT CHK_Tamanho;

-- Criando uma Stored Procedure
CREATE PROCEDURE InserirNovoProduto
@Nome varchar(255),
@Cor varchar(50),
@Preco decimal(13, 2),
@Tamanho varchar(5),
@Genero char(1)

AS

INSERT INTO Produtos (Nome, Cor, Preco, Tamanho, Genero)
VALUES (@Nome, @Cor, @Preco, @Tamanho, @Genero);

-- Executa (EXEC ou EXECUTE) a procedure InserirNovoProduto
EXECUTE InserirNovoProduto
@Nome = 'Skydiving Logo Cap',
@Cor = 'Colorido',
@Preco = 8.99,
@Tamanho = '',
@Genero = 'U'

-- Criando uma procedure para obter produtos pelo tamanho
CREATE PROCEDURE ObterProdutosPeloTamanho
@TamanhoProduto varchar(5)

AS

SELECT * FROM Produtos WHERE Tamanho = @TamanhoProduto;

-- Executa a procedure ObterProdutosPeloTamanho
EXEC ObterProdutosPeloTamanho 'M';

-- Criando uma procedure para listar todos os produtos, sem parâmetros
CREATE PROCEDURE ListaTodosProdutos
AS
SELECT * FROM Produtos;

-- Executa a procedure ListaTodosProdutos
EXEC ListaTodosProdutos

-- Criando uma função para calcular descontos
CREATE FUNCTION CalcularDesconto(@Preco DECIMAL(13, 2), @Porcentagem INT)
RETURNS DECIMAL(13, 2)

BEGIN
	RETURN @Preco - @Preco / 100 * @Porcentagem
END

-- Executa a função CalcularDescontos em uma query
SELECT Nome, Preco, dbo.CalcularDesconto(Preco, 15) AS PrecoComDesconto FROM Produtos
WHERE Tamanho = 'M';
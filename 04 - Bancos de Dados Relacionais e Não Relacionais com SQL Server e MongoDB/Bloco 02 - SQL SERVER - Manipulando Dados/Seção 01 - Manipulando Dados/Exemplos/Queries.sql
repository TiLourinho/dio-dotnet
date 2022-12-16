-- Seleciona todas as linhas da tabela Produtos
SELECT * FROM Produtos;

-- Faz a contagem de todas as linhas da tabela Produtos nomeando a coluna como QuantidadeProdutos
SELECT COUNT(*) AS QuantidadeProdutos FROM Produtos;

-- Faz a contagem de todas as linhas onde o tamanho seja M nomeando a coluna como QuantidadeProdutosM
SELECT COUNT(*) AS QuantidadeProdutosM FROM Produtos
WHERE Tamanho = 'M';

-- Faz a soma de todos os preços da tabela Produtos
SELECT SUM(Preco) AS PrecoTotal FROM Produtos;

-- Faz a soma de todos os preços onde o Gênero seja F
SELECT SUM(Preco) AS PrecoTotalPecasFemininas FROM Produtos
WHERE Genero = 'F';

-- Seleciona o preço máximo da tabela Produtos
SELECT MAX(Preco) AS PrecoMaximo FROM Produtos;

-- Seleciona o preço máximo onde a Cor seja Branco
SELECT MAX(Preco) AS PrecoMaximoProdutosBrancos FROM Produtos
WHERE Cor = 'Branco';

-- Seleciona o preço mínimo da tabela Produtos
SELECT MIN(Preco) AS PrecoMinimo FROM Produtos;

-- Seleciona o preço mínimo onde a Cor seja Preto
SELECT MIN(Preco) AS PrecoMinimoProdutosPretos FROM Produtos
WHERE Cor = 'Preto';

-- Faz a média dos preços da tabela Produtos
SELECT AVG(Preco) AS MediaDosPrecos FROM Produtos;

-- Concatena as colunas Nome e Cor
SELECT Nome + ' - ' + Cor AS NomeECor FROM Produtos;

-- Concatena as colunas Nome e Cor
SELECT 'Produto: ' + Nome + ' - Cor: ' + Cor + ' - Gênero: ' + Genero AS NomeECor FROM Produtos;

-- Seleciona as colunas Nome em caixa alta e Cor em caixa baixa
SELECT UPPER(Nome) AS Nome, LOWER(Cor) AS Cor FROM Produtos;

-- Insere na tabela Produtos uma nova coluna DataCadastro
ALTER TABLE Produtos
ADD DataCadastro DATETIME2;

-- Atualiza DataCadastro com a data atual
UPDATE Produtos
SET DataCadastro = GETDATE();

-- Insere um novo produto na tabela Produtos
INSERT INTO Produtos (Nome, Cor, Preco, Genero, DataCadastro)
VALUES ('Tennis Bracers', 'Preto', 5.50, 'U', GETDATE());

-- Insere um novo produto na tabela Produtos
INSERT INTO Produtos
VALUES ('Tennis Hair Band', 'Branco', 3.50, '', 'U', GETDATE());

-- Formatando datas
SELECT Nome, Cor, Preco, FORMAT(DataCadastro, 'dd-MM-yyyy HH:mm') FROM Produtos;

-- Seleciona a coluna Tamanho, faz a contagem dos produtos nomeando-a como Quantidade, onde tamanho não seja vazio, agrupando por Tamanho em ordem decrescente por Quantidade
SELECT Tamanho, COUNT(*) AS Quantidade FROM Produtos
WHERE Tamanho != ''
GROUP BY Tamanho
ORDER BY Quantidade DESC;

-- Inserindo um novo endereço
INSERT INTO Enderecos
VALUES (1001, 'North Sheffield Avenue', 'Sheffield Neighbors', 'Chicago', 'IL');

-- Inserindo um novo endereço
INSERT INTO Enderecos
VALUES (1002, 'North Sheffield Avenue', 'Sheffield Neighbors', 'Chicago', 'IL');

-- Inserindo um novo endereço
INSERT INTO Enderecos
VALUES (1003, 'North Sheffield Avenue', 'Sheffield Neighbors', 'Chicago', 'IL');

-- Inner Join
SELECT * FROM Clientes
INNER JOIN Enderecos
ON Clientes.Id = Enderecos.IdCliente
WHERE Clientes.Id = 1002;

-- Inner Join com as colunas especificadas
SELECT C.Nome, C.Sobrenome, C.Email, E.Rua, E.Bairro, E.Cidade, E.Estado FROM Clientes AS C
JOIN Enderecos AS E
ON C.Id = E.IdCliente
WHERE C.Id = 1003;
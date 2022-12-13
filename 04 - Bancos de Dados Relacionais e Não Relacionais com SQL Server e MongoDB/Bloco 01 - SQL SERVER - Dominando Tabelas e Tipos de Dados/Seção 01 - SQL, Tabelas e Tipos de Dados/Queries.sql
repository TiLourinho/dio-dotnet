-- Para usar o DB Loja
USE Loja;

-- Seleciona todas as colunas da tabela Clientes ordenadas primeiramente por Nome e depois Sobrenome
SELECT * FROM Clientes
ORDER BY Nome, Sobrenome;

-- Seleciona as colunas Nome, Sobrenome e Email da tabela Clientes ordenadas primeiramente por Nome e depois Sobrenome
SELECT Nome, Sobrenome, Email FROM Clientes
ORDER BY Nome, Sobrenome;

-- Seleciona as colunas Nome, Sobrenome e DataCadastro da tabela Clientes ordenadas primeiramente por Nome e depois Sobrenome
SELECT	Nome, Sobrenome, DataCadastro FROM Clientes
ORDER BY DataCadastro;

-- Seleciona todas as colunas da tabela Clientes, onde Nome seja 'Adam' e Sobrenome seja 'Reynolds', ordenadas primeiramente por Nome e depois Sobrenome
SELECT * FROM Clientes
WHERE Nome = 'Adam' AND Sobrenome = 'Reynolds'
ORDER BY Nome, Sobrenome;

-- Seleciona todas as colunas da tabela Clientes, onde Nome seja 'Susan' ou Sobrenome seja 'French', ordenadas primeiramente por Nome e depois Sobrenome
SELECT * FROM Clientes
WHERE Nome = 'Susan' OR Sobrenome = 'French'
ORDER BY Nome, Sobrenome;

-- Seleciona todas as colunas da tabela Clientes, onde AceitaComunicados seja 1, ordenadas primeiramente por Nome e depois Sobrenome
SELECT * FROM Clientes
WHERE AceitaComunicados = 1
ORDER BY Nome, Sobrenome;

-- Seleciona todas as colunas da tabela Clientes, onde Nome comece com G e AceitaComunicados 1, ordenadas primeiramente por Nome e depois Sobrenome
SELECT * FROM Clientes
WHERE Nome LIKE 'G%' AND AceitaComunicados = 1
ORDER BY Nome, Sobrenome;

-- Seleciona todas as colunas da tabela Clientes, onde Sobrenome tenha C e AceitaComunicados 1, ordenadas primeiramente por Nome e depois Sobrenome
SELECT * FROM Clientes
WHERE Sobrenome LIKE '%C%' AND AceitaComunicados = 1
ORDER BY Nome, Sobrenome;

-- Seleciona todas as colunas da tabela Clientes, onde Nome tenha o terceiro caracter A, ordenadas primeiramente por Nome e depois Sobrenome
SELECT * FROM Clientes
WHERE Nome LIKE '__A%'
ORDER BY Nome, Sobrenome;

-- Insere um novo cliente na tabela Clientes
INSERT INTO Clientes (Nome, Sobrenome, Email, AceitaComunicados, DataCadastro)
VALUES ('Alex', 'Green', 'green.alex@hotmail.com', 1, GETDATE());

-- Insere um novo cliente na tabela Clientes
INSERT INTO Clientes (Nome, Sobrenome, Email, AceitaComunicados, DataCadastro)
VALUES	('Heather', 'Green', 'green.heather@hotmail.com', 0, GETDATE());

-- Insere um novo cliente na tabele Clientes, omitindo as colunas
INSERT INTO Clientes VALUES ('Becky', 'Green', 'beckywow@gmail.com', 1, GETDATE())

-- Seleciona todas as colunas da tabela Clientes, onde Sobrenome seja 'Green', ordenadas primeiramente por Nome e depois Sobrenome
SELECT * FROM Clientes
WHERE Sobrenome = 'Green'
ORDER BY Nome, Sobrenome;

-- Seleciona a tabela Clientes para o update, seta Email para 'green.alex@gmail.com' e AceitaComunicados para 0 onde Id seja 1001
UPDATE Clientes
SET Email = 'green.alex@gmail.com',
	AceitaComunicados = 0
WHERE Id = 1001;

-- Seleciona a tabela Clientes para o update, seta Nome para 'Rebecca' onde Id seja 1003
UPDATE Clientes
SET Nome = 'Rebecca'
WHERE Id = 1003;

-- Seleciona todas as colunas da tabela Clientes onde Nome seja 'Christian' e Sobrenome 'Kleinerman'
SELECT * FROM Clientes
WHERE Nome = 'Christian' AND Sobrenome = 'Kleinerman';

-- Seleciona a tabela para o delete, onde Id seja 767
DELETE Clientes
WHERE Id = 767;
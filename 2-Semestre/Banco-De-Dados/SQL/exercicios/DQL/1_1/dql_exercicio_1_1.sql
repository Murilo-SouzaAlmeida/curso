--ATIVIDADE DQL

--Listar as pessoas em ordem alfabética reversa, mostrando seus telefones, seus emails e suas CNHs

--Script sem usar JOIN

USE Exercicio_1_1;

--Estrutura SELECT
/*
SELECT
	COLUNA1,COLUNA2
FROM
	TABELA1 AS Apelido (muda todo o script),TABELA2
WHERE
	CONDIÇÕES (Com AND ou OR)
ORDER BY
	Coluna que será usada como referencia para ordanar a consulta 
	Se for dados em letrar vai ser por ordem alfabética, se for em números vai ser em ordem de maior
*/

--Conceito orientado a objetos
--Podemos colocar "apelidos" para as colunas e tabelas usando o AS
--Comando para ordenar ORDER

SELECT 
	P.NomePessoa AS Nome,
	Telefone.NumeroTelefone AS Telefone,
	E.EnderecoEmail AS Email,
	P.CnhPessoa AS CNH
FROM 
	Pessoa AS P,
	Telefone,
	Email AS E
WHERE 
	P.IdPessoa = Telefone.IdPessoa 
	AND P.IdPessoa = E.IdPessoa 
ORDER BY 
	Nome DESC
;

--Insert em pessoas
INSERT INTO Pessoa (NomePessoa, CnhPessoa)
VALUES ('Miguel Almeida','3910482957'),('Amanda Tadeu','5328460827'),('Enzo Carvalho','5792461846'),('Leonardo Xavier','3682947164');
SELECT * FROM Pessoa;
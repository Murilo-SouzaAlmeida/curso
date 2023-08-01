INSERT INTO Pessoa (NomePessoa, CnhPessoa) VALUES ('Gabriel Christofolett', '4681083901');

UPDATE Pessoa SET NomePessoa = 'Gabriel Dantas' WHERE IdPessoa = 3;

INSERT INTO Telefone (IdPessoa, NumeroTelefone) VALUES (2, '11957027492'),(2, '11936402479'),(3, '11946294916'),(1, '11956208593');

DELETE FROM Telefone WHERE IdTelefone = 5;

INSERT INTO Email (IdPessoa, EnderecoEmail) 
VALUES (2, 'gabriela@email.com'),(3, 'gcdantas@email.com'),(3, 'gabriel@email.com'),(1, 'murilo.souza@email.com'),(3, 'dantas.gabriel@email.com');

UPDATE Email SET EnderecoEmail = 'gabriela.akiko@emial.com' WHERE IdPessoa = 2;

SELECT * FROM Pessoa;
SELECT * FROM Telefone;
SELECT * FROM Email;
INSERT INTO Pessoa (NomePessoa, CnhPessoa) VALUES ('Murilo Souza', '5682018472'),('Gabriela Akiko', '4682984671'),('Gabriel Dantas', '4682479173'); 

INSERT INTO Telefone (IdPessoa, NumeroTelefone) VALUES (3, '11957027492'),(3, '11936402479'),(4, '11946294916'),(2, '11956208593');

INSERT INTO Email (IdPessoa, EnderecoEmail)
VALUES (3, 'gabriela.akiko@emial.com'),(4, 'gcdantas@email.com'),(4, 'gabriel@email.com'),(2, 'murilo.souza@email.com'),(4, 'dantas.gabriel@email.com');

SELECT * FROM Pessoa;
SELECT * FROM Telefone;
SELECT * FROM Email;
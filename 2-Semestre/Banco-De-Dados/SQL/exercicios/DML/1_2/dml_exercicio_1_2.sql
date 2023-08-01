SELECT * FROM Aluguel;

INSERT INTO Cliente (NomeCliente, CpfCliente) 
VALUES('Murilo Souza', '64829471903'),('Matheus Almeida', '54619384023'),('Gabriela Akiko', '26839856829');

INSERT INTO Locadora (NomeLocadora) VALUES ('AutoAluga+');

INSERT INTO Marca (NomeMarca) VALUES ('GM'),('FORD'),('FIAT');

INSERT INTO Modelo (NomeModelo, AnoModelo, IdMarca) 
VALUES ('Onix', '2012', 1),('Fiesta','2006',2),('Argo','2017',3);

INSERT INTO Veiculo (IdLocadora, IdModelo, PlacaVeiculo)
VALUES (1,1,'ENA6728'),(1,2,'ODJ2356'),(1,3,'SGQ2374')

INSERT INTO Aluguel(IdCliente,IdVeiculo,DataInicioAluguel,DataFinalAluguel,ValorAluguel) 
VALUES (2,3,'17-02-2013 10:20:00 AM','28-02-2013 04:00:00 PM', 1500)
USE ExemploCotacoes
GO

CREATE TABLE dbo.Cotacoes(
	Sigla char(3) NOT NULL,
	NomeMoeda varchar(30) NOT NULL,
	UltimaCotacao datetime NOT NULL,
	Valor numeric(18,4) NOT NULL,
	CONSTRAINT PK_Cotacoes PRIMARY KEY (Sigla)
)
GO

INSERT INTO dbo.Cotacoes
	(Sigla
	,NomeMoeda
	,UltimaCotacao
	,Valor)
VALUES
	('USD'
	,'Dólar norte-americano'
	,'2018-07-10 22:05'
	,3.93)

INSERT INTO dbo.Cotacoes
	(Sigla
	,NomeMoeda
	,UltimaCotacao
	,Valor)
VALUES
	('EUR'
	,'Euro'
	,'2018-07-10 22:05'
	,4.60)

INSERT INTO dbo.Cotacoes
	(Sigla
	,NomeMoeda
	,UltimaCotacao
	,Valor)
VALUES
	('LIB'
	,'Libra esterlina'
	,'2018-07-10 22:05'
	,5.20)
GO



CREATE TABLE [dbo].[funcionarios]
(
    [id] INT NOT NULL PRIMARY KEY,
    [nome] VARCHAR(150) NULL,
    [cpf] VARCHAR(11) NOT NULL,
    [nascimento] datetime,
    [sexo] VARCHAR(1),
    [telefone] VARCHAR(50),
    [usuario] VARCHAR(50),
    [senha] VARCHAR(10),
    [inclusao] datetime NOT NULL,
    [foto] VARCHAR(MAX)
);

CREATE TABLE [dbo].[moradores]
(
    [id] INT NOT NULL PRIMARY KEY,
    [nome] VARCHAR(150) NULL,
    [cpf] VARCHAR(11) NOT NULL,
    [nascimento] datetime,
    [sexo] VARCHAR(1),
    [telefone] VARCHAR(50),
    [usuario] VARCHAR(50),
    [senha] VARCHAR(10),
    [inclusao] datetime NOT NULL,
    [foto] VARCHAR(MAX)
);

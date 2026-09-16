USE CineVista;
GO

-- req 1.
CREATE TABLE [dbo].[Promocao] (
    Id INT IDENTITY,
    IdFilme INT NOT NULL,
    Descricao VARCHAR(300) NOT NULL,
    PercentualDesconto DECIMAL(5,2) NOT NULL,
    DataInicioVigencia DATE NOT NULL,
    DataFimVigencia DATE NOT NULL,
    CONSTRAINT PK_Promocao PRIMARY KEY (Id),
    CONSTRAINT FK_IdFilme_Promocao FOREIGN KEY (IdFilme) REFERENCES [dbo].[Filme] (Id)
);
GO

-- req 2.
ALTER TABLE [dbo].[Cliente]
    ADD Telefone VARCHAR(20) NULL;
GO

-- req 3.
INSERT INTO [dbo].[Promocao] (IdFilme, Descricao, PercentualDesconto, DataInicioVigencia, DataFimVigencia) VALUES
(1, 'Estreia em dobro: 15% de desconto em A Fortaleza de Areia', 15.00, '2026-06-20', '2026-06-30'),
(4, 'Semana da Ficcao Cientifica: 20% de desconto em Estrelas de Ferro', 20.00, '2026-06-25', '2026-07-10'),
(7, 'Pre-venda especial: 10% de desconto em Do Outro Lado do Rio', 10.00, '2026-07-01', '2026-07-15');
GO

-- req 4.
UPDATE [dbo].[Cliente]
    SET Telefone = '11999999999'
    WHERE Id = 1;
GO

-- req 5.
DELETE
    FROM [dbo].[Promocao]
    WHERE Id = 3;
GO

-- req 6.
SELECT  fi.Titulo as Titulo,
        pr.Descricao as Descricao,
        pr.PercentualDesconto as PercentualDesconto
    FROM [dbo].[Promocao] AS pr WITH(NOLOCK)
    INNER JOIN [dbo].[Filme] AS fi WITH(NOLOCK) ON fi.Id = pr.IdFilme;
GO

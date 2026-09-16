USE CineVista;
GO

-- req 1.
SELECT  cl.Nome as NomeCliente,
        fi.Titulo as Titulo,
        se.DataHora as DataHoraSessao
    FROM [dbo].[Ingresso] AS ig WITH(NOLOCK)
        INNER JOIN [dbo].[Cliente] AS cl WITH(NOLOCK)
            ON ig.IdCliente = cl.Id
        INNER JOIN [dbo].[Sessao] AS se WITH(NOLOCK)
            ON ig.IdSessao = se.Id
        INNER JOIN [dbo].[Filme] AS fi WITH(NOLOCK)
            ON se.IdFilme = fi.Id
    ORDER BY cl.Nome ASC;
GO

-- req 2.
SELECT  fi.Titulo as Titulo
    FROM [dbo].[Filme] AS fi WITH(NOLOCK)
        LEFT JOIN [dbo].[Sessao] AS se WITH(NOLOCK)
            ON se.IdFilme = fi.Id
    WHERE se.Id IS NULL
    ORDER BY fi.Titulo ASC;
GO

-- req 3.
SELECT  cl.Nome as NomeCliente
    FROM [dbo].[Cliente] AS cl WITH(NOLOCK)
        LEFT JOIN [dbo].[Ingresso] AS ig WITH(NOLOCK)
            ON ig.IdCliente = cl.Id
    WHERE ig.Id IS NULL;
GO

-- req 4.
SELECT  TOP 5 cl.Nome as NomeCliente,
              ig.ValorPago as ValorPago,
              ig.DataCompra as DataCompra
    FROM [dbo].[Ingresso] AS ig WITH(NOLOCK)
        INNER JOIN [dbo].[Cliente] AS cl WITH(NOLOCK)
            ON ig.IdCliente = cl.Id
    ORDER BY ig.ValorPago DESC;
GO

-- req 5. (extra)
SELECT  cl.Nome as NomeCliente,
        fi.Titulo as Titulo,
        se.DataHora as DataHoraSessao,
        sa.Nome as NomeSala
    FROM [dbo].[Ingresso] AS ig WITH(NOLOCK)
        INNER JOIN [dbo].[Cliente] AS cl WITH(NOLOCK)
            ON ig.IdCliente = cl.Id
        INNER JOIN [dbo].[Sessao] AS se WITH(NOLOCK)
            ON ig.IdSessao = se.Id
        INNER JOIN [dbo].[Filme] AS fi WITH(NOLOCK)
            ON se.IdFilme = fi.Id
        INNER JOIN [dbo].[Sala] AS sa WITH(NOLOCK)
            ON se.IdSala = sa.Id
    ORDER BY cl.Nome ASC;
GO

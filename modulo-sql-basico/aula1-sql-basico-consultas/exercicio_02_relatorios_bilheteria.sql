USE CineVista;
GO

-- req 1.
SELECT  fi.Titulo as Titulo,
        fi.Genero as Genero,
        fi.DuracaoMinutos as DuracaoMinutos
    FROM [dbo].[Filme] AS fi WITH(NOLOCK)
    WHERE Titulo LIKE '%o%' AND  fi.DuracaoMinutos BETWEEN 100 AND 130
    ORDER BY fi.DuracaoMinutos DESC;
GO

-- req 2.
SELECT  TOP 3 se.Id as Id,
              se.DataHora as DataHora,
              se.PrecoIngresso as PrecoIngresso
    FROM [dbo].[Sessao] AS se WITH(NOLOCK)
    ORDER BY se.PrecoIngresso DESC;
GO

-- req 3.
SELECT  fi.Titulo as Titulo,
        COUNT(ig.Id) as QuantidadeIngressos,
        SUM(ig.ValorPago) as FaturamentoTotal
    FROM [dbo].[Ingresso] AS ig WITH(NOLOCK)
        INNER JOIN [dbo].[Sessao] AS se WITH(NOLOCK)
            ON ig.IdSessao = se.Id
        INNER JOIN [dbo].[Filme] AS fi WITH(NOLOCK)
            ON se.IdFilme = fi.Id
    GROUP BY fi.Titulo
    HAVING SUM(ig.ValorPago) >= 150.00;
GO

-- req 4.
SELECT  fi.Genero as Genero,
        COUNT(ig.Id) as QuantidadeIngressos
    FROM [dbo].[Ingresso] AS ig WITH(NOLOCK)
        INNER JOIN [dbo].[Sessao] AS se WITH(NOLOCK)
            ON ig.IdSessao = se.Id
        INNER JOIN [dbo].[Filme] AS fi WITH(NOLOCK)
            ON se.IdFilme = fi.Id
    GROUP BY fi.Genero
    ORDER BY QuantidadeIngressos DESC;
GO

-- req 5.
SELECT  sa.Nome as NomeSala,
        MIN(se.PrecoIngresso) as MenorPrecoIngresso,
        MAX(se.PrecoIngresso) as MaiorPrecoIngresso
    FROM [dbo].[Sessao] AS se WITH(NOLOCK)
        INNER JOIN [dbo].[Sala] AS sa WITH(NOLOCK)
            ON se.IdSala = sa.Id
    GROUP BY sa.Nome
GO

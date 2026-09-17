# Estudos Selecao IFTI <img height="28" src="./assets/ifti-logo.png" alt="Logo IFTI"/>

Repositório pessoal de estudos para o processo seletivo do Instituto Futuro (SMN). Aqui ficam minhas soluções para os exercícios e desafios do material oficial de preparação.

Material original: [ifti-instituto-futuro/material-prova-selecao](https://github.com/ifti-instituto-futuro/material-prova-selecao)

## Estrutura

```
estudos-selecao-ifti/
├── material-prova-selecao/              # cópia do repositório original do IFTI (referência dos enunciados)
│
├── modulo-git-smn/
│   └── aula1-git-essencial/
│
├── modulo-csharp-basico/
│   ├── aula1-logica-e-csharp-basico/
│   │   ├── DesafioDaSemana/
│   │   └── ExercicioN/                   # Exercicio1, Exercicio2, Exercicio3...
│   ├── aula2-entrada-de-dados-e-conversoes/
│   │   └── ExercicioN/
│   ├── aula3-classificacoes-descontos-e-menus/
│   │   └── ExercicioN/
│   ├── aula4-loops-relatorios-e-estatisticas/
│   └── aula5-colecoes-dinamicas-e-consolidacao/
│
├── modulo-sql-basico/
│   └── aula1-sql-basico-consultas/
│       ├── exercicio_01_expandindo_o_banco.sql
│       ├── exercicio_02_relatorios_bilheteria.sql
│       └── exercicio_03_cruzando_dados_rede.sql
│
├── .gitignore
└── README.md
```

Cada `ExercicioN/` do módulo de C# é um projeto console independente (`dotnet run` dentro da pasta). No módulo de SQL, cada exercício é um arquivo `.sql` isolado.

## Progresso

**Módulo Git**
- [ ] Aula 1: Git Essencial e o Fluxo Git SMN

**Módulo C# Básico**
- [x] Aula 1: Lógica de Programação e C# Básico
- [x] Aula 2: Entrada de Dados e Conversões
- [x] Aula 3: Classificações, Descontos e Menus
- [ ] Aula 4: Loops, Relatórios e Estatísticas
- [ ] Aula 5: Coleções Dinâmicas e Consolidação

**Módulo SQL Básico**
- [x] Aula 1: SQL Básico — Consultas

## Padrões seguidos

O código segue os padrões corporativos definidos no material (padrão SMN):

- Branches no formato `feat/<modulo>-aula<N>`
- C#: convenções de nomenclatura padrão (PascalCase para classes/métodos, camelCase para variáveis locais)
- SQL: `WITH(NOLOCK)` em todo `SELECT`, tabelas qualificadas com `[dbo].[Tabela]`, constraints nomeadas (`PK_Tabela`, `FK_IdColuna_Tabela`), aliases de tabela (`AS` + duas letras minúsculas) e de coluna (`as` + PascalCase em todos os campos), palavras-chave em maiúsculas, indentação com tab

# MoneyCoinAPI
## Comandos Uteis

### Habilitado Code-Generator
#### dotnet tool install -g dotnet-aspnet-codegenerator

### Adicionar pacotes
#### dotnet add package NOME_PACOTE
#### dotnet add package Microsoft.EntityFrameworkCore
#### dotnet add package Microsoft.EntityFrameworkCore.Design
#### dotnet add package Microsoft.EntityFrameworkCore.SqlServer
#### dotnet add package MySql.Data.EntityFrameworkCore

### Criação das Áreas
#### dotnet-aspnet-codegenerator area carteira

### Criação dos Controllers
#### dotnet-aspnet-codegenerator controller -dc CarteiraContext -m Operacao -name Carteira -api  -outDir Areas/carteira/Controllers

#### dotnet-aspnet-codegenerator controller -dc CarteiraContext -m Pais -name Pais -api  -outDir Areas/carteira/Controllers


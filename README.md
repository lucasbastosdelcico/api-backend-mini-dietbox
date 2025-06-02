
# 🏥 API de Nutrição - CRUD de Pacientes, Alimentos e Planos Alimentares

Este projeto é uma API desenvolvida em **.NET 8**, utilizando **Entity Framework Core** com **MySQL** como banco de dados. A API realiza operações de CRUD (Create, Read, Update, Delete) para gerenciar pacientes, alimentos e planos alimentares.

## 🚀 Tecnologias Utilizadas

- [.NET 8](https://dotnet.microsoft.com/)
- [Entity Framework Core](https://learn.microsoft.com/en-us/ef/) (`Pomelo.EntityFrameworkCore.MySql`)
- [MySQL](https://www.mysql.com/)
- [Swagger - Swashbuckle](https://swagger.io/) (Documentação da API)

## 📦 Dependências Principais

```xml
<PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="8.0.5" />
<PackageReference Include="Pomelo.EntityFrameworkCore.MySql" Version="8.0.3" />
<PackageReference Include="Swashbuckle.AspNetCore" Version="6.6.2" />
```

## ⚙️ Configuração do Ambiente

### Pré-requisitos

- [.NET SDK 8.0+](https://dotnet.microsoft.com/en-us/download)
- [MySQL](https://dev.mysql.com/downloads/)

### Configuração do Banco de Dados

1. Crie um banco de dados no MySQL:

```sql
CREATE DATABASE dietboxdb;
```

2. Configure sua connection string no arquivo `appsettings.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;DataBase=DietboxDB;Uid=root;Pwd=132456;Port=3306"
  }
}
```

## 🏗️ Execução do Projeto

### Passos para rodar localmente:

1. Restaure os pacotes:

```bash
dotnet restore
```

2. Aplique as migrations (caso tenha migrations configuradas):

```bash
dotnet ef database update
```

3. Execute a aplicação:

```bash
dotnet run
```


## 📜 Funcionalidades

- 🧑‍⚕️ **Pacientes**
  - Cadastrar, listar, atualizar e excluir pacientes.

- 🍎 **Alimentos**
  - Cadastrar, listar, atualizar e excluir alimentos.

- 🥗 **Planos Alimentares**
  - Criar planos alimentares vinculando alimentos aos pacientes.

## 🛠️ Comandos Úteis (EF Core)

Criar uma migration:

```bash
dotnet ef migrations add NomeDaMigration
```

Atualizar o banco de dados:

```bash
dotnet ef database update
```

Remover uma migration (ainda não aplicada no banco):

```bash
dotnet ef migrations remove
```


## 🤝 Contato

- GitHub: [@LucasDelcico](https://github.com/lucasbastosdelcico)

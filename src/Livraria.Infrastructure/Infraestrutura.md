# Infraestrutura


A camada de **Infraestrutura** é responsável por implementar os detalhes técnicos da aplicação, isolando dependências externas e fornecendo implementações concretas para as abstrações definidas nas camadas de domínio e aplicação.


## Responsabilidades
- Tratamento de persistencia de dados
- envio de e-mails
- serviços de cache
-  e autorização
- chamadas de API externas

---

# Instalação de pacotes NuGet
Para utilizar o **Entity Framework Core** com **SQLite**, instale o pacote:

```powershell
Microsoft.EntityFrameworkCore.Sqlite
```

Caso utilize **Migrations**, instale também os seguintes pacotes:

```powershell
Microsoft.EntityFrameworkCore.Design
Microsoft.EntityFrameworkCore.Tools
```
---


# Aplicando Migrations

## Opção 1 – Package Manager Console (Visual Studio)

### Criar uma Migration

```powershell
Add-Migration NomeDaMigration -Context NomeDoContexto
```

### Aplicar a Migration

```powershell
Update-Database
```

> **Observação:** O comando `Update-Database` requer o pacote `Microsoft.EntityFrameworkCore.Tools`.

---

## Opção 2 – .NET CLI

Caso ainda não tenha instalado a ferramenta `dotnet-ef`, execute:

```bash
dotnet tool install --global dotnet-ef
```

### Criar uma Migration

```bash

 para criar o arquivo de migração:
 dotnet ef migrations add Inicial --project Livraria.Infrastructure -s Livraria.Blazor -c ApplicationDbContext
 -- verbose
 ```

### Aplicar a 
```bash
 dotnet ef database update Inicial --project Livraria.Infrastructure -s Livraria.Blazor -c ApplicationDbContext --verbose
  ```

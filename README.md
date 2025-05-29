
TesteBackend - Desafio T�cnico em ASP.NET Core 8

Projeto desenvolvido como parte de um desafio t�cnico. Trata-se de uma API RESTful para gerenciamento de usu�rios.

-----------------------------
Tecnologias Utilizadas:
-----------------------------
- ASP.NET Core 8
- Entity Framework Core (InMemory)
- Swagger (documenta��o autom�tica)
- Inje��o de Depend�ncia
- Estrutura em camadas

-----------------------------
Instru��es para Executar:
-----------------------------
1. Clone o reposit�rio:
   git clone https://github.com/GustavoAEG/TesteBackend.git

2. Acesse o diret�rio do projeto:
   cd TesteBackend

3. Restaure os pacotes NuGet:
   dotnet restore

4. Compile o projeto:
   dotnet build

5. Execute a aplica��o:
   dotnet run --project TesteBackend

-----------------------------
Acessar Documenta��o Swagger:
-----------------------------
- https://localhost:5001/swagger
- ou http://localhost:5000/swagger

-----------------------------
Principais Endpoints da API:
-----------------------------
- GET    /api/users        -> Listar usu�rios
- GET    /api/users/{id}   -> Obter usu�rio por ID
- POST   /api/users        -> Criar novo usu�rio
- PUT    /api/users/{id}   -> Atualizar usu�rio existente
- DELETE /api/users/{id}   -> Remover usu�rio

-----------------------------
Estrutura de Pastas:
-----------------------------
- Controllers/     -> Controladores
- Models/          -> Modelos de dados
- Data/            -> Contexto do EF Core (InMemory)
- Services/        -> L�gica de neg�cio
- ExternalApi/     -> Integra��es externas
- Program.cs       -> Entrada do projeto
- appsettings.json -> Configura��es
- .sln             -> Solu��o

-----------------------------
Autor:
-----------------------------
Gustavo - Desenvolvedor .NET
LinkedIn: https://www.linkedin.com/in/gustavo-gon%C3%A7alves-4989111ba/
Email: gustavoenriccoga@gmail.com


### Scripts e Migrations

- **Scripts de Cria��o**: Se necess�rio, crie a base de dados manualmente no SQL Server com o nome definido na connection string (`TesteBackendDB` ou similar).
- **Migrations**: Para aplicar as migrations, utilize os comandos do Entity Framework Core via terminal:
  ```bash
  dotnet ef migrations add InitialCreate
  dotnet ef database update
  ```
- **Pacotes Necess�rios**:
  - Microsoft.EntityFrameworkCore
  - Microsoft.EntityFrameworkCore.SqlServer
  - Microsoft.EntityFrameworkCore.Tools

- **Observa��o**: Certifique-se de que o SQL Server est� em execu��o e que sua conta de acesso tem permiss�o para criar e alterar bancos.

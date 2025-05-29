
TesteBackend - Desafio Técnico em ASP.NET Core 8

Projeto desenvolvido como parte de um desafio técnico. Trata-se de uma API RESTful para gerenciamento de usuários.

-----------------------------
Tecnologias Utilizadas:
-----------------------------
- ASP.NET Core 8
- Entity Framework Core (InMemory)
- Swagger (documentação automática)
- Injeção de Dependência
- Estrutura em camadas

-----------------------------
Instruções para Executar:
-----------------------------
1. Clone o repositório:
   git clone https://github.com/GustavoAEG/TesteBackend.git

2. Acesse o diretório do projeto:
   cd TesteBackend

3. Restaure os pacotes NuGet:
   dotnet restore

4. Compile o projeto:
   dotnet build

5. Execute a aplicação:
   dotnet run --project TesteBackend

-----------------------------
Acessar Documentação Swagger:
-----------------------------
- https://localhost:5001/swagger
- ou http://localhost:5000/swagger

-----------------------------
Principais Endpoints da API:
-----------------------------
- GET    /api/users        -> Listar usuários
- GET    /api/users/{id}   -> Obter usuário por ID
- POST   /api/users        -> Criar novo usuário
- PUT    /api/users/{id}   -> Atualizar usuário existente
- DELETE /api/users/{id}   -> Remover usuário

-----------------------------
Estrutura de Pastas:
-----------------------------
- Controllers/     -> Controladores
- Models/          -> Modelos de dados
- Data/            -> Contexto do EF Core (InMemory)
- Services/        -> Lógica de negócio
- ExternalApi/     -> Integrações externas
- Program.cs       -> Entrada do projeto
- appsettings.json -> Configurações
- .sln             -> Solução

-----------------------------
Autor:
-----------------------------
Gustavo - Desenvolvedor .NET
LinkedIn: https://www.linkedin.com/in/gustavo-gon%C3%A7alves-4989111ba/
Email: gustavoenriccoga@gmail.com


### Scripts e Migrations

- **Scripts de Criação**: Se necessário, crie a base de dados manualmente no SQL Server com o nome definido na connection string (`TesteBackendDB` ou similar).
- **Migrations**: Para aplicar as migrations, utilize os comandos do Entity Framework Core via terminal:
  ```bash
  dotnet ef migrations add InitialCreate
  dotnet ef database update
  ```
- **Pacotes Necessários**:
  - Microsoft.EntityFrameworkCore
  - Microsoft.EntityFrameworkCore.SqlServer
  - Microsoft.EntityFrameworkCore.Tools

- **Observação**: Certifique-se de que o SQL Server está em execução e que sua conta de acesso tem permissão para criar e alterar bancos.

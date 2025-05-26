✅ TodoList API
Uma API RESTful de gerenciamento de tarefas (ToDo) desenvolvida com ASP.NET Core, MySQL e seguindo os princípios da Clean Architecture. A aplicação permite que usuários se cadastrem, façam login e gerenciem suas tarefas pessoais.

📦 Tecnologias Utilizadas
ASP.NET Core

Entity Framework Core

MySQL

JWT (JSON Web Tokens)

Clean Architecture (API, Application, Domain, Infrastructure)

Repository + Unit of Work Pattern

📁 Estrutura do Projeto
API/: Camada de apresentação (Controllers).

Application/: Camada de lógica de negócio (Services, DTOs, Interfaces).

Domain/: Entidades e interfaces principais.

Infrastructure/: Acesso a dados (EF Core), repositórios e serviços externos.

🔐 Autenticação
A autenticação é feita por meio de JWT Tokens e suporta:

Registro de usuário (/api/auth/register)

Login (/api/auth/login)

Refresh token (/api/auth/refresh)

Revogação de refresh token (/api/auth/revoke)

📌 Endpoints Principais
🧑‍💼 Usuários
GET /api/user/{id} – Buscar usuário por ID

PUT /api/user – Atualizar e-mail do usuário

DELETE /api/user/{id} – Deletar usuário

✅ Tarefas
GET /api/task?taskId={id} – Buscar tarefa por ID

POST /api/task – Adicionar nova tarefa

PUT /api/task – Atualizar tarefa existente

DELETE /api/task/{id} – Deletar tarefa

GET /api/task/user/{userId} – Listar tarefas por usuário

🔄 Fluxo de Autenticação com JWT
O usuário se registra com e-mail e senha.

Após login, é gerado um Access Token (válido por 30 minutos) e um Refresh Token (válido por 7 dias).

Com o Refresh Token, é possível renovar o Access Token sem refazer o login.

O Refresh Token pode ser revogado pelo endpoint /api/auth/revoke.

# CleanArchitecture-Streamer

✨ **Bem-vindo ao repositório CleanArchitecture-Streamer!** Este projeto busca explorar e implementar os princípios da Clean Architecture, organizando o código em camadas bem definidas para garantir alta manutenibilidade, escalabilidade e separação de responsabilidades. ✨

## Estrutura do Projeto

⚡ **A estrutura do projeto está organizada em quatro camadas principais:** ⚡

- **CleanArchitecture.API**: Camada de entrada da aplicação, onde os endpoints são definidos e configurados.
- **CleanArchitecture.Application**: Contém os casos de uso e serviços que orquestram a lógica de negócio.
- **CleanArchitecture.Infrastructure**: Implementação de repositórios e contexto de banco de dados.
- **CleanArchitecture.Domain**: Define as entidades e interfaces centrais da aplicação.

## Bibliotecas e Tecnologias Utilizadas

💡 **Este projeto utiliza as seguintes bibliotecas e tecnologias:** 💡

- **.NET Core**: Framework principal para a construção da aplicação.
- **Entity Framework Core**: Para gerenciamento de dados e comunicação com o banco.
- **AutoMapper**: Simplifica a conversão entre objetos de diferentes camadas.
- **FluentValidation**: Para validação de dados na camada de aplicação.
- **MediatR**: Implementa o padrão CQRS (Command Query Responsibility Segregation) para desacoplamento de lógica.
- **Swashbuckle (Swagger)**: Geração de documentação e testes interativos de endpoints.

## Como Executar o Projeto

🌟 **Siga os passos abaixo para executar o projeto:** 🌟(Cabe ressaltar que estou usando o meu banco local)

1. **Clone o repositório:**

   ```bash
   git clone https://github.com/ArthurZimm/CleanArchitecture-Streamer.git
   ```

2. **Navegue até o diretório do projeto:**

   ```bash
   cd CleanArchitecture-Streamer
   ```

3. **Restaure as dependências:**

   ```bash
   dotnet restore
   ```

4. **Compile o projeto:**

   ```bash
   dotnet build
   ```

5. **Execute a aplicação:**

   ```bash
   dotnet run --project CleanArchitecture.API
   ```

6. **Acesse o Swagger:**

   🚀 A aplicação gerará uma documentação interativa no endpoint `/swagger` (exemplo: `http://localhost:5000/swagger`). 🚀


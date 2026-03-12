# 3DPrinterCalculator

Uma API leve e eficiente desenvolvida em C# com **.NET 8** destinada a calcular os custos envolvidos em impressões 3D. A calculadora considera valor do material gasto, margem de desperdício/peso da peça, consumo de energia e a porcentagem de lucro desejada.

## 🚀 Funcionalidades

A API possui um endpoint central responsável pelo cálculo dos custos detalhados da impressão: 

- **`POST /calculate`**: Recebe os parâmetros descritivos do processo no corpo da requisição e retorna tanto o cenário do custo base detalhado, quanto o cenário final aplicando a porcentagem de lucro indicada na regra de negócio.

## ✨ Práticas, Padrões e Recursos Utilizados

O desenvolvimento deste código destaca o uso das seguintes práticas e recursos modernos do ecossistema .NET e C#, com grande foco em organização, legibilidade e manutenibilidade estrutural:

### 1. Minimal APIs
As rotas da aplicação são mapeadas utilizando **Minimal APIs**. Isso retira a verbosidade comum dos `Controllers` tradicionais e fornece uma API REST de alta performance e rápida configuração.

### 2. Extension Methods (Métodos de Extensão)
Para manter o arquivo principal da aplicação (`Program.cs`) mais enxuto e responsável exclusivamente pelo bootstrap/início da API, foi criado o `MapEndpointsExtensions.cs`. Trata-se de um método de extensão injetado diretamente em `this WebApplication app`, onde encapsulamos as validações e mapeamento interno das requisições (como o endpoint `/calculate`).

### 3. Global Usings
Foi introduzido o recurso de *global using* (`global using`) centralizado num único arquivo (`Using.cs`). Essa prática ajuda a diminuir e padronizar as dependências em vários arquivos `.cs` ao mesmo tempo, deixando as classes limpas de diversos `using System...` ou de referências a pacotes internos.

### 4. DTO Pattern (Data Transfer Objects)
Trabalho estrito de separação de responsabilidades. O formato das requisições foi envelopado na classe `PrintCostRequest` dentro do diretório `DTO`. Isso isola os dados transitórios das implementações da própria entidade de negócio em si (`PrintCost` que reside na camada `Models`). 

### 5. Configuração Explicita de CORS
A aplicação injeta durante os serviços a configuração de *Cross-Origin Resource Sharing* (`CORS`) definindo a flexibilidade da política de acessibilidade `AllowAll`. Isso garante que ferramentas de interface front-end separadas ou testadores de conectividade interajam com a engine sem impedimentos prévios de rotas.

### 6. Swagger OpenAPI 
A API explora nativamente os dados contidos nos endpoints via **Swagger**. É documentada sem grande intervenção graças as chamadas ativadas (`app.UseSwagger()`) sempre que em ambiente de desenvolvimento (`Environment.IsDevelopment()`).

### 7. Conteinerização com Docker
A base já contém um diretório pronto no formato `Dockerfile`, configurando de antemão todo fluxo, compilação de repositório e hospedagem virtual portável caso aloque em ambiente Linux.


## 💻 Como Rodar o Projeto

Para visualizar a API e operá-la de forma local em seu espaço de desenvolvimento:

1. Garanta ter o **SDK do .NET 8** previamente instalado na máquina.
2. Acesse a raiz do repositório onde reside o arquivo `3DPrinterCalculator.csproj`.
3. Para compilar e subir o servidor, utilize o terminal de sua preferência:
   ```bash
   dotnet run
   ```
4. Navegue localmente pela rota `/swagger/`(conforme a porta providenciada pelos logs do terminal) no seu navegador, lá você poderá testar o payload completo da aplicação.

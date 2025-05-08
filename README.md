# ApiSuperHerois

Este projeto foi desenvolvido com fins de estudo e aprendizagem. O objetivo principal é integrar o GraphQL a uma API REST. Apesar de ser um projeto simples, ele explora o potencial do GraphQL em conjunto com uma API REST.

## Tecnologias Utilizadas
- GraphQL
- REST API
- .NET 8.0

## Objetivo
Demonstrar como combinar as funcionalidades de uma API REST com as capacidades do GraphQL, criando uma aplicação funcional e didática.

## Como Rodar o Projeto

Certifique-se de que você tenha o .NET SDK instalado em sua máquina. Para rodar o projeto, siga os passos abaixo:

1. Abra o terminal e navegue até o diretório raiz do projeto.
2. Execute o comando:
   ```bash
   dotnet run
   ```
3. O servidor será iniciado, e você poderá acessar o GraphQL Playground em `http://localhost:5194/graphql`.

## Testando o GraphQL
Para testar o GraphQL, acesse `http://localhost:5194/graphql`. Isso abrirá o **GraphQL Playground** (também conhecido como Nitro), que é uma interface gráfica interativa para testar e explorar APIs GraphQL.

### O que é o Nitro?
O Nitro é uma ferramenta que permite executar consultas GraphQL diretamente no navegador. Ele fornece uma interface amigável para testar queries, mutations e subscriptions, além de exibir os resultados em tempo real.

## Exemplos de Consultas

### Consulta básica
```graphql
query {
    superHerois {
        nome
    }
}
```
**Retorno:**
```json
{
  "data": {
    "superHerois": [
      { "nome": "Batman" },
      { "nome": "Viúva Negra" },
      { "nome": "Luke Skywalker" }
    ]
  }
}
```

### Consulta com descrição
```graphql
query {
    superHerois {
        nome
        descricao
    }
}
```
**Retorno:**
```json
{
  "data": {
    "superHerois": [
      {
        "nome": "Batman",
        "descricao": "Batman foi originalmente apresentado como um vigilante implacável..."
      },
      {
        "nome": "Viúva Negra",
        "descricao": "Viúva Negra, cujo nome verdadeiro é Natasha Romanoff..."
      },
      {
        "nome": "Luke Skywalker",
        "descricao": "Luke Skywalker era um fazendeiro de Tatooine..."
      }
    ]
  }
}
```

### Consulta com superpoderes
```graphql
query {
    superHerois {
        nome
        descricao
        superPoderes {
            super_Poder
        }
    }
}
```
**Retorno:**
```json
{
  "data": {
    "superHerois": [
      {
        "nome": "Batman",
        "descricao": "Batman foi originalmente apresentado como um vigilante implacável...",
        "superPoderes": [
          { "super_Poder": "Fortuna" },
          { "super_Poder": "Luta" },
          { "super_Poder": "Inteligência" }
        ]
      },
      {
        "nome": "Viúva Negra",
        "descricao": "Viúva Negra, cujo nome verdadeiro é Natasha Romanoff...",
        "superPoderes": [
          { "super_Poder": "Infiltração" },
          { "super_Poder": "Subterfúgio" },
          { "super_Poder": "Espionagem" }
        ]
      },
      {
        "nome": "Luke Skywalker",
        "descricao": "Luke Skywalker era um fazendeiro de Tatooine...",
        "superPoderes": [
          { "super_Poder": "Desvia o poder do blaster." }
        ]
      }
    ]
  }
}
```

### Consulta com ordenação
```graphql
query {
    superHerois {
        nome
        descricao
        superPoderes(order: { super_Poder: ASC }) {
            super_Poder
        }
    }
}
```

### Consulta com filtro
```graphql
query {
    superHerois(where: { nome: { eq: "Batman" } }) {
        nome
        descricao
        filmes {
            titulo
        }
    }
}
```
**Retorno:**
```json
{
  "data": {
    "superHerois": [
      {
        "nome": "Batman",
        "descricao": "Batman foi originalmente apresentado como um vigilante implacável...",
        "filmes": [
          { "titulo": "O Cavaleiro das Trevas" },
          { "titulo": "O Cavaleiro das Trevas - Ressurreição" },
          { "titulo": "Batman Begins" }
        ]
      }
    ]
  }
}
```

## Conclusão
Este projeto demonstra como o GraphQL pode ser integrado a uma API REST para criar uma aplicação robusta e flexível. Explore as consultas acima para entender melhor as possibilidades oferecidas pelo GraphQL.


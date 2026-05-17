# Sistema de Controle de Solicitações

Sistema full-stack para gerenciamento de solicitações

## Tecnologias

- **Back-end:** C# / ASP.NET Core 8
- **Front-end:** HTML + JavaScript puro
- **Containerização:** Docker + Docker Compose

## Pré-requisitos

Escolha uma das opções abaixo:

**Opção 1 — Rodar com Docker**
- [Docker Desktop](https://www.docker.com/products/docker-desktop/)

**Opção 2 — Rodar localmente sem Docker**
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Qualquer navegador moderno

## Como rodar com Docker

```bash
# 1. Clone o repositório
git clone https://github.com/andreiabtiveron/sistema-solicitacoes.git
cd sistema-solicitacoes

# 2. Suba os containers
docker compose up --build
```

Acesse:
- **Front-end** → http://localhost:8080
- **API** → http://localhost:5000/solicitacoes

Para parar:
```bash
docker compose down
```

## Como rodar localmente sem Docker

```bash
# 1. Clone o repositório
git clone https://github.com/andreiabtiveron/sistema-solicitacoes.git
cd sistema-solicitacoes

# 2. Rode o back-end
dotnet run

# 3. Abra o front-end
# Abra o arquivo frontend/index.html no navegador
```

## Endpoints da API

| Método | Rota | Descrição |
|--------|------|-----------|
| GET | `/solicitacoes` | Lista todas as solicitações |
| POST | `/solicitacoes` | Cria uma nova solicitação |
| PUT | `/solicitacoes/{id}` | Atualiza o status de uma solicitação |

## Funcionalidades

- Cadastrar solicitações com título, solicitante e status
- Listar todas as solicitações em tabela
- Filtrar por status
- Atualizar status de uma solicitação
- Resumo dinâmico com total, pendentes e concluídas
- Validação de campos obrigatórios no front e no back

## Referências

- [Documentação C# — Microsoft](https://learn.microsoft.com/pt-br/dotnet/csharp/)
- [Documentação ASP.NET Core — Microsoft](https://learn.microsoft.com/pt-br/aspnet/core/)
- [Documentação JavaScript — MDN Web Docs](https://developer.mozilla.org/pt-BR/docs/Web/JavaScript)
- [SmartFitApp — inspiração para o front-end](https://github.com/andreiabtiveron/SmartFitApp)
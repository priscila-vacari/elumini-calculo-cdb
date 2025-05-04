# Projeto - Cálculo de Investimento em CDB

## 📋 Descrição
Projeto desenvolvido para calcular o rendimento bruto e líquido de um investimento em CDB, respeitando os princípios de SOLID, testes unitários e performance.


## 🔹 Tecnologias Utilizadas
- Frontend: Angular CLI

- Backend: ASP.NET Web API (.NET Core 8)

- Banco de Dados: Não aplicável

- Testes Unitários: XUnit para backend (Cobertura mínima de 90%)


## 📌 Arquitetura
A aplicação segue um padrão de divisão em camadas:

- API: Camada de apresentação (Controllers, Middlewares)

- Application: Regras de negócio e cálculos.

- Domain/Infra: N/A


## 🚀 Instalação e Execução

**🏗 Configurar e Rodar a Web API**

Clone este repositório:
```
bash
git clone https://github.com/priscila-vacari/elumini-calculo-cdb.git
cd elumini-calculo-cdb
```

Abra a solução no Visual Studio.

Compile e execute o projeto API.
```
bash
dotnet build
dotnet run
```

**🌐 Configurar e Rodar o Frontend (Angular)**
Navegue até a pasta do frontend:
```
bash
cd frontend
```

Instale as dependências:
```
bash
npm install
```

Execute o projeto:
```
bash
ng serve --open
```

## ✅ Testes

## Backend - Testes Unitários (XUnit)
Para rodar os testes unitários no backend:

Abra o projeto no Visual Studio.

Vá até o Test Explorer e execute os testes.
```
bash
dotnet build
dotnet test --collect:"XPlat Code Coverage"
reportgenerator "-reports:TestResults\**\*.cobertura.xml" "-targetdir:coveragereport" "-reporttypes:Html"
```

## Frontend - Testes Unitários (Stretch Goal)
Se aplicável, use o comando abaixo para executar os testes do Angular:
```
bash
ng test
```

## 🔎 Boas Práticas e Requisitos


✅ Código segue os princípios SOLID. 

✅ Cobertura de testes acima de 90% na camada lógica. 

✅ Código livre de alertas do Visual Studio e SonarLint.

✅ Logs estruturados e disponíveis em  `/logs/`.

✅ Entradas do usuário validadas com FluentValidation.

# 💰 CashFlow

O **CashFlow** é uma aplicação voltada para o gerenciamento inteligente e controle de fluxos de caixa, permitindo o registro e monitoramento detalhado de entradas (receitas) e saídas (despesas). O projeto foi estruturado seguindo padrões de arquitetura modernos para garantir segurança, consistência e alta performance no tratamento de dados financeiros.

---

## 🎓 Origem do Projeto

Este projeto foi desenvolvido e estruturado a partir dos conhecimentos adquiridos e consolidados durante os estudos da **Formação C# da Rocketseat**. A formação foca em guiar o desenvolvedor na criação de APIs REST robustas, aplicando conceitos do ecossistema .NET com foco em código limpo, boas práticas de mercado e padrões arquiteturais escaláveis.

---

## 🚀 Principais Funcionalidades

- **Controle de Entradas e Saídas:** Registro completo de receitas e despesas com categorização e tratamento rigoroso de dados.
- **Validação de Dados robusta:** Implementação de regras de negócio para garantir que apenas transações financeiras válidas sejam processadas.
- **Arquitetura em Camadas:** Separação clara de responsabilidades, facilitando testes automatizados e manutenibilidade do código.
- **Pronto para Expansão (Modular):** Estrutura idealizada para receber novos recursos, como dashboards visuais e conciliações avançadas.

---

## 🛠️ Tecnologias e Conceitos Aplicados

O projeto utiliza o estado da arte do desenvolvimento com C#:

- **Back-end / Core:** C# com .NET.
- **Padrões de Projeto (Design Patterns) & Princípios:** 
  - Orientação a Objetos (POO) avançada.
  - Princípios do SOLID para um código desacoplado.
  - Injeção de Dependência (Dependency Injection).
  - Domain-Driven Design (DDD) básico / Separação por camadas.
- **Validações:** Uso de bibliotecas de validação fluida para blindar a camada de domínio contra dados corrompidos.

---

## 🏗️ Rodando o Projeto Localmente

### Pré-requisitos
Antes de começar, você precisará ter instalado em sua máquina:
* **.NET SDK** (Versão atual aplicável)
* Um IDE de sua preferência (VS Code, Visual Studio ou JetBrains Rider)

### Passo a Passo

1. **Clonar o repositório:**
   ```bash
   git clone [https://github.com/leandromarqueti/CashFlow.git](https://github.com/leandromarqueti/CashFlow.git)
Acessar a pasta do projeto:

Bash
cd CashFlow
Restaurar as dependências do .NET:

Bash
dotnet restore
Executar a aplicação:

Bash
dotnet run
🗺️ Roadmap / Próximos Passos
O projeto serve como uma base sólida para extensões futuras. Algumas evoluções planejadas incluem:

[ ] Implementação de testes unitários e de integração para cobertura das regras de negócio.

[ ] Módulo de conciliação automática via importação de arquivos bancários estruturados.

[ ] Módulo fiscal modular adaptável para cálculos de tributações locais.

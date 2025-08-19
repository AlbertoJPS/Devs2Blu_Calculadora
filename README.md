# Calculadora de Console em C# (Devs2Blu)

![Language](https://img.shields.io/badge/Linguagem-C%23-blueviolet)
![Framework](https://img.shields.io/badge/Framework-.NET-blue)
![Status](https://img.shields.io/badge/Status-Concluido-brightgreen)

Projeto de uma calculadora de console desenvolvida em C# como atividade em grupo para o programa Devs2Blu. A aplicação segue os princípios da Programação Orientada a Objetos, utilizando interfaces para desacoplamento e testes unitários para garantir a qualidade do código.

---

## 📋 Tabela de Conteúdos

* [Sobre o Projeto](#-sobre-o-projeto)
* [🛠️ Tecnologias Utilizadas](#️-tecnologias-utilizadas)
* [🚀 Como Executar o Projeto](#-como-executar-o-projeto)
* [📂 Estrutura do Projeto](#-estrutura-do-projeto)
* [📝 Requisitos do Sistema](#-requisitos-do-sistema)
* [👥 Equipe e Colaboradores](#-equipe-e-colaboradores)
* [📄 Licença](#-licença)

---

## 📖 Sobre o Projeto

O objetivo deste projeto é criar uma calculadora funcional que opera via linha de comando. A aplicação oferece dois modos:

* **Calculadora Normal:** Com as quatro operações aritméticas básicas.
* **Calculadora Científica:** Inclui todas as operações da calculadora normal, além de funções de potenciação, trigonometria e logaritmo.

O desenvolvimento foi guiado por uma arquitetura modular, com responsabilidades separadas em diferentes projetos e uma suíte de testes unitários para validar a lógica de negócio.

---

## 🛠️ Tecnologias Utilizadas

* [**C#**](https://docs.microsoft.com/pt-br/dotnet/csharp/): Linguagem de programação principal.
* [**.NET**](https://dotnet.microsoft.com/): Framework de desenvolvimento.
* [**xUnit**](https://xunit.net/): Framework para a criação dos testes unitários.

---

## 🚀 Como Executar o Projeto

Siga os passos abaixo para executar a aplicação localmente.

### Pré-requisitos

* É necessário ter o **SDK do .NET** instalado na sua máquina. Você pode baixá-lo [aqui](https://dotnet.microsoft.com/download).

### Instalação e Execução

1.  Clone o repositório para a sua máquina local:
    ```sh
    git clone [https://github.com/SEU_USUARIO/Devs2Blu_Calculadora.git](https://github.com/SEU_USUARIO/Devs2Blu_Calculadora.git](https://github.com/AlbertoJPS/Devs2Blu_Calculadora.git)
    ```
2.  Navegue até a pasta do projeto principal que contém a interface do console:
    ```sh
    cd Devs2Blu_Calculadora/Calculadora_Team3
    ```
3.  Execute o projeto com o comando `dotnet run`:
    ```sh
    dotnet run
    ```
A aplicação será iniciada no seu terminal.

---

## 📂 Estrutura do Projeto

O código-fonte está organizado em uma solução com múltiplos projetos para garantir a separação de responsabilidades:

* **`Calculadora_Team3`**: Projeto principal do tipo *Console Application*, responsável pela interface com o usuário (menu, entrada e saída de dados).
* **`CalculadoraNormal`**: Projeto do tipo *Class Library* contendo a lógica de negócio para as operações aritméticas básicas.
* **`CalculadoraCientifica`**: Projeto do tipo *Class Library* com a lógica para as operações científicas.
* **`Calculadora_Team3.Tests`**: Projeto de testes (usando xUnit) para validar as classes de negócio.

---

## 📝 Requisitos do Sistema

<details>
<summary><strong>Clique para expandir/recolher os Requisitos Funcionais (RF)</strong></summary>

### Requisitos Funcionais (RF)
*Os Requisitos Funcionais descrevem **o que o sistema deve fazer**. São as funcionalidades e comportamentos específicos que o usuário espera da aplicação.*

#### RF - Núcleo do Sistema e Navegação
- **RF01:** O sistema deve exibir um menu principal para que o usuário possa escolher entre "Calculadora Normal" e "Calculadora Científica".
- **RF02:** O sistema deve permitir que o usuário encerre a aplicação de forma controlada através de uma opção no menu (ex: 'S' para Sair).
- **RF03:** O sistema deve manter o menu ativo, retornando a ele após a conclusão de uma operação, até que o usuário escolha sair.

#### RF - Funcionalidades da Calculadora Normal
- **RF04:** O sistema deve ser capaz de somar dois números de ponto flutuante.
- **RF05:** O sistema deve ser capaz de subtrair dois números de ponto flutuante.
- **RF06:** O sistema deve ser capaz de multiplicar dois números de ponto flutuante.
- **RF07:** O sistema deve ser capaz de dividir dois números de ponto flutuante.
- **RF08:** O sistema deve tratar especificamente a divisão por zero, exibindo uma mensagem de erro clara ao usuário e impedindo que a operação cause uma falha no programa.

#### RF - Funcionalidades da Calculadora Científica
- **RF09:** A Calculadora Científica deve possuir todas as funcionalidades da Calculadora Normal.
- **RF10:** O sistema deve ser capaz de calcular a potência de um número base elevado a um expoente.
- **RF11:** O sistema deve ser capaz de calcular o seno de um ângulo.
- **RF12:** O sistema deve ser capaz de calcular o cosseno de um ângulo.
- **RF13:** O sistema deve ser capaz de calcular a tangente de um ângulo.
- **RF14:** O sistema deve ser capaz de calcular o logaritmo na base 10 de um número.

#### RF - Interação e Validação de Dados
- **RF15:** O sistema deve solicitar ao usuário os números necessários para cada operação.
- **RF16:** O sistema deve exibir o resultado de cada operação de forma clara para o usuário.
- **RF17:** O sistema deve validar as entradas numéricas do usuário, exibindo uma mensagem de erro caso o valor digitado não seja um número válido (ex: digitar "abc").

</details>

<details>
<summary><strong>Clique para expandir/recolher os Requisitos Não-Funcionais (RNF)</strong></summary>

### Requisitos Não-Funcionais (RNF)
*Os Requisitos Não-Funcionais descrevem **como o sistema deve ser**. Eles definem as qualidades, restrições e características gerais do sistema, como desempenho, usabilidade e tecnologia.*

#### RNF - Tecnologia e Plataforma
- **RNF01:** O sistema deve ser desenvolvido utilizando a linguagem C# e o ecossistema .NET.
- **RNF02:** A aplicação deve ser executada em uma interface de linha de comando (console).

#### RNF - Arquitetura e Qualidade de Código
- **RNF03:** O código deve seguir os princípios da Programação Orientada a Objetos (OOP).
- **RNF04:** A arquitetura deve prever o uso de interfaces para desacoplar a implementação das operações, facilitando a manutenção e a extensibilidade.
- **RNF05:** O código-fonte deve ser organizado em projetos distintos para separar responsabilidades.
- **RNF06 (Manutenibilidade):** O código deve ser legível, bem comentado e seguir as convenções de nomenclatura do C#, facilitando futuras modificações.

#### RNF - Testabilidade
- **RNF07:** A lógica de negócio (os cálculos) deve ser coberta por testes unitários automatizados.
- **RNF08:** A estrutura do código deve ser projetada para ser facilmente testável, com baixo acoplamento entre as classes.

#### RNF - Usabilidade e Experiência do Usuário
- **RNF09:** As instruções no menu e as solicitações de dados devem ser claras e intuitivas para o usuário.
- **RNF10:** As mensagens de erro devem ser amigáveis e informativas.

#### RNF - Confiabilidade e Desempenho
- **RNF11 (Precisão):** Os cálculos devem utilizar tipos de dados de ponto flutuante com precisão dupla (`double`).
- **RNF12 (Robustez):** A aplicação não deve encerrar de forma inesperada ("crashar") devido a entradas inválidas do usuário.
- **RNF13 (Desempenho):** O tempo de resposta para qualquer cálculo deve ser percebido pelo usuário como instantâneo.

#### RNF - Portabilidade
- **RNF14:** A aplicação deve ser compatível e executável em qualquer sistema operacional que suporte o runtime do .NET.

</details>

---

## 👥 Equipe e Colaboradores

### Equipe de Desenvolvimento
* Alberto Santos
* Kaue Endler
* Karen Ferreira
* Julio Cesar

### Professor
* Marcos Angelo

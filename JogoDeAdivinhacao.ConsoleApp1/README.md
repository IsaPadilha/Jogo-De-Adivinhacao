# Jogo De Adivinhação

## Projeto 

Desenvolvido durante o curso Back-End da [Academia do Programador](https://www.academiadoprogramador.net) 2026

## Introdução

No início do jogo, é gerado um número entre 1 e 20 aleatoriamente. Os jogadores devem tentar adivinhar o número. A cada resposta errada, dicas são fornecidas ao usuário para ajudar na próxima tentativa.

## Entrada

Os jogadores interagem com o jogo por meio do console, digitando números e recebendo um retorno sobre suas escolhas (resposta certa ou dicas sobre a próxima jogada). O jogo acaba quando o usuário acerta o número secreto.

## Funcionalidades

- **Geração do Número Secreto:** No início de cada jogo, um número aleatório é gerado entre 1 e 20.
- **Feedback Instantâneo:** Após cada tentativa, o jogo fornece um feedback indicando se o número escolhido pelo jogador é maior ou menor do que o secreto.

## Como utilizar o programa

1. Clone o repositório ou baixe o arquivo do repositório.
2. Abra o emulador de terminal e navegue até a pasta raiz.
3. Utilize o comando abaixo para restaurar as dependências do projeto.

    ```
    dotnet restore
    ```

4. Em seguida compile e execute o projeto com o comando:

    ```
    dotnet run --projevt JogoDeAdivinhacao.ConsoleApp1
    ```

## Requisitos

- .NET SDK 10.0
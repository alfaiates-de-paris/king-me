# King Game!

## 👑 Sobre o Projeto

King é um jogo de cartas multiplayer local (ou que simula um ambiente multiplayer através de uma DLL) para desktop, desenvolvido em C# com Windows Forms. Os jogadores interagem com a interface gráfica para criar ou entrar em partidas, gerenciar seus personagens e competir entre si. O objetivo é ser o último jogador restante ou alcançar uma condição de vitória específica do jogo de cartas "King".

Este projeto foi desenvolvido como uma aplicação desktop para o **Projeto Integrador de Ciência da Computação no SENAC**.

## ⚙️ Como Funciona

O jogo é uma aplicação Windows Forms que utiliza uma biblioteca de lógica de jogo (`KingMeServer.dll`):

*   **Interface do Usuário (Cliente):** Construída com C# e Windows Forms, a interface permite aos jogadores interagir com o jogo, visualizar o tabuleiro, suas cartas, e realizar ações.
*   **Lógica do Jogo (Servidor/DLL):** A `KingMeServer.dll` encapsula as regras do jogo, gerenciamento de estado da partida, turnos, validação de jogadas e interações entre os "jogadores" (que podem ser controlados pelo mesmo usuário ou simulados).

**Fluxo Básico:**
1.  O jogador executa a aplicação.
2.  A tela inicial (Home) permite iniciar uma nova sessão de jogo.
3.  O jogador navega para a tela de Lobby para criar uma nova partida ou listar partidas existentes (simuladas pela DLL).
4.  Ao entrar ou criar uma partida, o jogador interage com a tela principal do jogo.
5.  A aplicação WinForms chama funções da `KingMeServer.dll` para processar ações como:
    - [x] Iniciar partida.
    - [x] Listar cartas.
    - [x] Posicionar personagens.
    - [x] Promover personagens.
    - [x] Votar.
    - [x] Verificar a vez e o estado do tabuleiro.
6.  A interface é atualizada com base nos retornos da DLL, mostrando o progresso do jogo, cartas, tabuleiro e placar.

## ✨ Funcionalidades Principais

*   Criação e gerenciamento de partidas (via DLL).
*   Interface gráfica para interação com o jogo de cartas King.
*   Visualização do tabuleiro e movimentação de personagens.
*   Sistema de turnos e rodadas.
*   Lógica de votação.
*   Acompanhamento de placar.
*   Seleção de personagens favoritos.

## 🛠️ Tecnologias Utilizadas

*   **Linguagem:** C#
*   **Framework:** .NET Framework 4.8
*   **Interface Gráfica:** Windows Forms (WinForms)
*   **Regras do Jogo:** Biblioteca `KingMeServer.dll` (externa)
*   **IDE:** Visual Studio

## 📸 Screenshots

### Lobby
<p align="center">
  <img src="https://github.com/user-attachments/assets/535b5290-19cb-4a65-af1b-283709d77dba" >
  <em>Tela de Lobby: Criação e listagem de partidas</em>
</p>

### Jogo
<p align="center">
  <img src="https://github.com/user-attachments/assets/67aeca37-afc3-42a5-8645-cf1ff05aa439">
  <em>Tela Principal do Jogo: Tabuleiro, cartas e interações</em>
</p>

---

## 🚀 Como Rodar o Projeto

1.  **Pré-requisitos:**
    *   Visual Studio (versão compatível com .NET Framework 4.8, ex: VS 2019, VS 2022).
    *   .NET Framework 4.8 Developer Pack (geralmente incluído com o Visual Studio).
2.  **Clone o repositório:**
3.  **Abra a Solução no Visual Studio:**
    *   Localize e abra o arquivo de solução `.sln` (ex: `king-me.sln`) no Visual Studio.
4.  **Verifique a Referência da DLL:**
    *   No Gerenciador de Soluções do Visual Studio, expanda o projeto `king-me`.
    *   Verifique se a referência à `KingMeServer.dll` (localizada na pasta `KingMeServer` dentro do projeto) está correta. Se houver problemas, pode ser necessário remover e adicionar a referência novamente, apontando para o arquivo `KingMeServer.dll` na pasta `KingMeServer` do seu projeto.
5.  **Compile o Projeto:**
    *   No menu do Visual Studio, selecione `Build` > `Build Solution` (ou pressione `Ctrl+Shift+B`).
6.  **Execute o Projeto:**
    *   No menu do Visual Studio, selecione `Debug` > `Start Debugging` (ou pressione `F5`).



using king_me.Interfaces;
using System.Collections.Generic;
using king_me.Models;
using KingMeServer;

namespace king_me.Services
{
    public class JogadorService : IJogadorService
    {
        public JogadorDTO GetJogadorDaVez(int idPartida)
        {
            string jogadoresString = Jogo.ListarJogadores(idPartida);
            string[] totalJogadores = jogadoresString.Split(new[] { "\r\n" }, System.StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, JogadorDTO> jogadoresDict = new Dictionary<string, JogadorDTO>();

            foreach (string jogador in totalJogadores)
            {
                string[] jogadorArray = jogador.Split(',');

                if (jogadorArray.Length >= 3)
                {
                    string id = jogadorArray[0].Trim();
                    string nome = jogadorArray[1].Trim();
                    string senha = jogadorArray[2].Trim();

                    if (!jogadoresDict.ContainsKey(id))
                    {
                        jogadoresDict.Add(id, new JogadorDTO
                        {
                            IdJogador = id,
                            NomeJogador = nome,
                            SenhaJogador = senha
                        });
                    }
                }
                else
                {
                    System.Console.WriteLine($"Linha mal formatada ignorada: '{jogador}'");
                }
            }

            string infoJogador = Jogo.VerificarVez(idPartida);
            string idJogador = infoJogador.Split(',')[0].Trim();

            if (jogadoresDict.TryGetValue(idJogador, out JogadorDTO jogadorDaVez))
            {
                return jogadorDaVez;
            }

            return new JogadorDTO
            {
                IdJogador = idJogador,
                NomeJogador = "Desconhecido",
                SenhaJogador = null
            };
        }

        public JogadorDTO Entrar(int idPartida, string jogador, string senha)
        {
            string infoJogador = Jogo.Entrar(idPartida, jogador, senha);
            string[] jogadorInfo = infoJogador.Split(',');

            return new JogadorDTO
            {
                IdJogador = jogadorInfo[0],
                SenhaJogador = jogadorInfo[1]
            };
        }

        public string ListarJogadores(int idPartida)
        {
            return Jogo.ListarJogadores(idPartida);
        }
    }
}
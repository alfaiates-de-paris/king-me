using king_me.Interfaces;
using System.Collections.Generic;
using king_me.Models;
using KingMeServer;

namespace king_me.Services
{
    public class JogadorService : IJogadorService
    {
        private Dictionary<string, string> _jogadoresDict = new Dictionary<string, string>();

        private Dictionary<string, string> PreencherDicionarioJogadores(int idPartida)
        {
            string jogadoresString = Jogo.ListarJogadores(idPartida);
            string[] totalJogadores = jogadoresString.Split(new[] { "\r\n" }, System.StringSplitOptions.RemoveEmptyEntries);

            foreach (string jogador in totalJogadores)
            {
                string[] jogadorArray = jogador.Split(',');

                if (jogadorArray.Length >= 2)
                {
                    string id = jogadorArray[0].Trim();
                    string nome = jogadorArray[1].Trim();

                    if (!_jogadoresDict.ContainsKey(id))
                    {
                        _jogadoresDict.Add(id, nome);
                    }
                }
                else
                {
                    System.Console.WriteLine($"Linha mal formatada ignorada: '{jogador}'");
                }
            }

            foreach (KeyValuePair<string, string> jogador in _jogadoresDict)
            {
                System.Console.WriteLine(jogador.Key + " " + jogador.Value);
            }

            return _jogadoresDict;
        }

        public JogadorDTO GetJogadorDaVez(int idPartida)
        {
            PreencherDicionarioJogadores(idPartida);
            string infoJogador = KingMeServer.Jogo.VerificarVez(idPartida);
            string idJogador = infoJogador.Split(',')[0].Trim(); // Pega só o ID

            System.Console.WriteLine("ID jogador da vez: " + idJogador);

            foreach (KeyValuePair<string, string> item in _jogadoresDict)
            {
                System.Console.WriteLine("ID jogador dict: " + item.Key + " nome:" + item.Value);
            }

            // Busca segura usando TryGetValue
            if (_jogadoresDict.TryGetValue(idJogador, out string nomeJogador))
            {
                return new JogadorDTO { IdJogador = idJogador, NomeJogador = nomeJogador };
            }
            else
            {
                System.Console.WriteLine($"ID '{idJogador}' não encontrado no dicionário de jogadores.");
                return new JogadorDTO { NomeJogador = "Erro: jogador não encontrado" };
            }
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

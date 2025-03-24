using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace king_me
{
    class Jogador
    {
        // Dicionário com o id e nome dos jogadores
        private Dictionary<string, string> jogadoresDict = new Dictionary<string, string>();

        private Dictionary<string, string> PreencherDicionarioJogadores(int idPartida)
        {
            string jogadoresString = KingMeServer.Jogo.ListarJogadores(idPartida);
            string[] totalJogadores = jogadoresString.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string jogador in totalJogadores)
            {
                string[] jogadorArray = jogador.Split(',');

                // Evita erro de índice fora dos limites
                if (jogadorArray.Length >= 2)
                {
                    string id = jogadorArray[0].Trim();
                    string nome = jogadorArray[1].Trim();

                    // Evita entradas duplicadas
                    if (!jogadoresDict.ContainsKey(id))
                    {
                        jogadoresDict.Add(id, nome);
                    }
                }
                else
                {
                    Console.WriteLine($"Linha mal formatada ignorada: '{jogador}'");
                }
            }

            foreach (KeyValuePair<string, string> jogador in jogadoresDict)
            {
                Console.WriteLine(jogador.Key + " " + jogador.Value);
            }

            return jogadoresDict;
        }

        public string GetJogadorDaVez(int idPartida)
        {
            string infoJogador = KingMeServer.Jogo.VerificarVez(idPartida);
            string idJogador = infoJogador.Split(',')[0].Trim(); // Pega só o ID

            Console.WriteLine("ID jogador da vez: " + idJogador);

            foreach (KeyValuePair<string, string> item in jogadoresDict)
            {
                Console.WriteLine("ID jogador dict: " + item.Key + " nome:" + item.Value);
            }

            // Busca segura usando TryGetValue
            if (jogadoresDict.TryGetValue(idJogador, out string nomeJogador))
            {
                return nomeJogador;
            }
            else
            {
                Console.WriteLine($"ID '{idJogador}' não encontrado no dicionário de jogadores.");
                return "Erro: jogador não encontrado";
            }
        }

        public Jogador(int idPartida)
        {
            PreencherDicionarioJogadores(idPartida);
        }
    }
}

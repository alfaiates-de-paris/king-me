using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace king_me
{
    class Jogador
    {
        //dict com o id e nome dos jogadores
        private Dictionary<string, string> jogadoresDict = new Dictionary<string, string>();

        private Dictionary<string, string> PreencherDicionarioJogadores(int idPartida)
        {
            string jogadoresString = KingMeServer.Jogo.ListarJogadores(idPartida);
            string[] totalJogadores = jogadoresString.Split(';');
            foreach (string jogador in totalJogadores)
            {
                string[] jogadorArray = jogador.Split(',');
                jogadoresDict.Add(jogadorArray[0], jogadorArray[1]);
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
            string idJogador = infoJogador.Split(',')[0]; //pega so id (primeira posição do array split)

            foreach (KeyValuePair<string, string> jogador in jogadoresDict)
            {
                if (jogador.Key == idJogador)
                {
                    return jogador.Value;
                }
            }

            return "Erro: jogador não encontrado";
        }

        public Jogador(int idPartida)
        {
            PreencherDicionarioJogadores(idPartida);
        }

    }
}

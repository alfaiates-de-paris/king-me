using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace king_me
{
    class Jogador
    {
        public Jogador() { }
        
        private Dictionary<string,string> CriarDicionarioJogadores(int idPartida)
        {
            Dictionary<string, string> jogadoresDict = new Dictionary<string, string>();
            string jogadoresString = KingMeServer.Jogo.ListarJogadores(idPartida);
            string[] totalJogadores = jogadoresString.Split(';');
            foreach (string jogador in totalJogadores)
            {
                string[] jogadorArray = jogador.Split(',');
                jogadoresDict.Add(jogadorArray[0], jogadorArray[1]);
            }

            return jogadoresDict;
        }
        public static Dictionary<string, string> GetJogadorDaVez(int idPartida, int TKey) 
        { 
            
        }
        
        
    }
}

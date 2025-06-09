using KingMeServer;
using king_me.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace king_me.Services
{
    public class VotoService : IVotoService
    {
        private Dictionary<int, List<string>> historicoVotos = new Dictionary<int, List<string>>();
        public string Votar(int idJogador, string senhaJogador, string _)
        {
            if (!historicoVotos.ContainsKey(idJogador))
                historicoVotos[idJogador] = new List<string>();

            var votos = historicoVotos[idJogador];
            const int LIMITE_VOTOS = 3;

            string voto;

         
            if (votos.Count >= LIMITE_VOTOS)
            {
                voto = "S";
            }
            else if (votos.Count == 0 || votos.Count == 1)
            {
                voto = "N";
            }
            else
            {
                voto = "S";
            }

            string retorno = Jogo.Votar(idJogador, senhaJogador, voto);

            if (!retorno.StartsWith("ERRO") && voto == "N")
            {
                votos.Add("N"); 
            }

            return retorno;
        }

        public int GetVotosRestantes(int idJogador)
        {
            if (!historicoVotos.ContainsKey(idJogador))
                return 3;


            return 3 - historicoVotos[idJogador].Count(v => v == "N");
        }

        public void ResetarVotosJogadores(int idPartida)
        {
            var jogadores = historicoVotos.Keys.ToList();
            foreach (var jogador in jogadores)
            {
                historicoVotos[jogador] = new List<string>();
            }
        }


    }
}


using KingMeServer;
using king_me.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace king_me.Services
{

    public class VotoService : IVotoService
    {
        private Dictionary<int, int> votosPorJogador = new Dictionary<int, int>();

        public string Votar(int idJogador, string senhaJogador, string voto)
        {
            voto = voto.ToUpper();

            if (voto.Length > 1)
                return "ERRO:Voto com excesso de caracteres";

            if (voto != "S" && voto != "N")
                return "ERRO:Voto com caracter inválido (S/N)";

            // Inicializa contador local se não existir
            if (!votosPorJogador.ContainsKey(idJogador))
                votosPorJogador[idJogador] = 3;

            if (votosPorJogador[idJogador] <= 0)
                voto = "S"; //caso não haja mais votos, o sim é obrigatório

            string retorno = Jogo.Votar(idJogador, senhaJogador, voto);

            if (!retorno.StartsWith("ERRO"))
            {
                votosPorJogador[idJogador]--;
            }

            return retorno;
        }

        public int GetVotosRestantes(int jogador)
        {
            if (votosPorJogador.ContainsKey(jogador))
                return votosPorJogador[jogador];

            return 3;
        }

        public void ResetarVotosJogadores(int idPartida)
        {
            var jogadores = votosPorJogador.Keys.ToList(); 
            foreach (var jogador in jogadores)
            {
                votosPorJogador[jogador] = 3; 
            }
        }
    }
}


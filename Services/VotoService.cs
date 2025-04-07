using KingMeServer;
using king_me.Interfaces;
using System.Collections.Generic;

namespace king_me.Services
{
    public class VotoService : IVotoService
    {
        private Dictionary<int, int> votosRestantes = new Dictionary<int, int>();

        public string Votar(int idJogador, string senha, string voto)
        {
            if (!votosRestantes.ContainsKey(idJogador))
                votosRestantes[idJogador] = 3;

            if (votosRestantes[idJogador] <= 0)
                return "ERRO: Você não tem mais votos disponíveis.";

            string resultado = Jogo.Votar(idJogador, senha, voto);

            if (!resultado.StartsWith("ERRO"))
            {
                votosRestantes[idJogador]--;
            }

            return resultado;
        }

        public int GetVotosRestantes(int idJogador)
        {
            if (!votosRestantes.ContainsKey(idJogador))
                return 3;

            return votosRestantes[idJogador];
        }
    }
}

using KingMeServer;
using king_me.Interfaces;

namespace king_me.Services
{
    public class VotoService : IVotoService
    {
        public string Votar(int idJogador, string senha, string voto)
        {
            return Jogo.Votar(idJogador, senha, voto);
        }
    }
}

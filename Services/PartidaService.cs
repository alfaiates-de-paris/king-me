using king_me.Interfaces;
using KingMeServer;

namespace king_me.Services
{
    public class PartidaService : IPartidaService
    {
        public string ListarPartidas(string status)
        {
            return Jogo.ListarPartidas(status);
        }

        public string CriarPartida(string nome, string senha, string grupo)
        {
            return Jogo.CriarPartida(nome, senha, grupo);
        }

        public void Iniciar(int idJogador, string senhaJogador)
        {
            Jogo.Iniciar(idJogador, senhaJogador);
        }
    }
}

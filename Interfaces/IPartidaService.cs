using king_me.Models;
using king_me.Services;

namespace king_me.Interfaces
{
    public interface IPartidaService
    {
        string ListarPartidas(string status);
        string CriarPartida(string nome, string senha, string grupo);
        void Iniciar(int idJogador, string senhaJogador, int idPartida);
        ResultadoVotoDTO VerificarVez(IJogadorService jogadorService, IVotoService votoService);
    }
}

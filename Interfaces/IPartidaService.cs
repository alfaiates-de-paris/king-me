using System.Windows.Forms;

namespace king_me.Interfaces
{
    public interface IPartidaService
    {
        string ListarPartidas(string status);
        string CriarPartida(string nome, string senha, string grupo);
        void Iniciar(int idJogador, string senhaJogador);
        string AtualizarPlacar(IJogadorService _jogadorService, string idPartida);
        string GetGanhador(TextBox placar);
    }
}

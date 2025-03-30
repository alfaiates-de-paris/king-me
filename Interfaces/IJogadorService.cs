using king_me.Models;

namespace king_me.Interfaces
{
    public interface IJogadorService
    {
        JogadorDTO Entrar(int idPartida, string jogador, string senha);
        string ListarJogadores(int idPartida);
        JogadorDTO GetJogadorDaVez(int idPartida);
    }
}

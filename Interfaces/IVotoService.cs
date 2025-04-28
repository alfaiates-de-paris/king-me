
namespace king_me.Interfaces
{
    public interface IVotoService
    {
        string Votar(int idJogador, string senha, string voto);
        int GetVotosRestantes(int idJogador);

        void ResetarVotosJogadores(int idPartida);
    }
}

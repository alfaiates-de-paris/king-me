namespace king_me.Interfaces
{
    public interface ICartaService
    {
        string ListarCartas(int idJogador, string senhaJogador);
        string ColocarPersonagem(int idJogador, string senhaJogador, int setor, string personagem);
        string Promover(int jogador, string senha, string personagem);
    }
}

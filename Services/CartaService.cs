using System.Collections.Generic;
using king_me.Interfaces;
using KingMeServer;

namespace king_me.Services
{
    public class CartaService : ICartaService
    {
        public string ListarCartas(int idJogador, string senhaJogador)
        {
            return Jogo.ListarCartas(idJogador, senhaJogador);
        }

        public string ColocarPersonagem(int idJogador, string senhaJogador, int setor, string personagem)
        {
            return Jogo.ColocarPersonagem(idJogador, senhaJogador, setor, personagem);
        }
        public string Promover(int idJogador, string senhaJogador,string personagem)
        {
            return Jogo.Promover(idJogador, senhaJogador, personagem);
        }
    }
}

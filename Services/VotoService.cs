using KingMeServer;
using king_me.Interfaces;
using System.Collections.Generic;

namespace king_me.Services
{

        public class VotoService : IVotoService
        {
            private Dictionary<int, int> votosPorJogador = new Dictionary<int, int>();

            public string Votar(int jogador, string senha, string voto)
            {
                voto = voto.ToUpper();

                if (voto.Length > 1)
                    return "ERRO:Voto com excesso de caracteres";

                if (voto != "S" && voto != "N")
                    return "ERRO:Voto com caracter inválido (S/N)";

                if (!votosPorJogador.ContainsKey(jogador))
                    votosPorJogador[jogador] = 3;

                if (votosPorJogador[jogador] <= 0)
                    return "ERRO:Você não tem mais votos disponíveis";

                votosPorJogador[jogador]--;

                return Jogo.Votar(jogador, senha, voto);
            }

            public int GetVotosRestantes(int jogador)
            {
                if (votosPorJogador.ContainsKey(jogador))
                    return votosPorJogador[jogador];

                return 3; 
            }
        }
    }


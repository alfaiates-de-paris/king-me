using KingMeServer;
using king_me.Interfaces;
using System.Collections.Generic;

namespace king_me.Services
{

        public class VotoService : IVotoService
        {
            private Dictionary<int, int> votosPorJogador = new Dictionary<int, int>();

            public string Votar(int idJogador, string senhaJogador, string voto)
            {
                voto = voto.ToUpper();

                if (voto.Length > 1)
                    return "ERRO:Voto com excesso de caracteres";

                if (voto != "S" && voto != "N")
                    return "ERRO:Voto com caracter inválido (S/N)";

                // Inicializa contador local se não existir
                if (!votosPorJogador.ContainsKey(idJogador))
                    votosPorJogador[idJogador] = 3;

                if (votosPorJogador[idJogador] <= 0)
                    return "ERRO:Você não tem mais votos disponíveis";

                string retorno = Jogo.Votar(idJogador, senhaJogador, voto);

                if (!retorno.StartsWith("ERRO"))
                {
                    votosPorJogador[idJogador]--; // ✅ Só decrementa se for sucesso
                }

                return retorno;
            }


        public int GetVotosRestantes(int jogador)
            {
                if (votosPorJogador.ContainsKey(jogador))
                    return votosPorJogador[jogador];

                return 3; 
            }
        }
    }


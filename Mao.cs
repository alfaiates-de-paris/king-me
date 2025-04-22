using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace king_me
{
    public class Mao
    {
        public Dictionary<char, string> personagens = new Dictionary<char, string>();

        public void CriarCartas()
        {
            personagens.Add('A', "Adilson Konrad");
            personagens.Add('B', "Beatriz Paiva");
            personagens.Add('C', "Claro");
            personagens.Add('D', "Douglas Baquiao");
            personagens.Add('E', "Eduardo Takeo");
            personagens.Add('G', "Guilherme Rey");
            personagens.Add('H', "Heredia");
            personagens.Add('K', "Karin");
            personagens.Add('L', "Leonardo Takuno");
            personagens.Add('M', "Mario Toledo");
            personagens.Add('Q', "Quintas");
            personagens.Add('R', "Ranulfo");
            personagens.Add('T', "Toshio");
        }
        public string ExibirPersonagem(char chave)
        {
            return personagens[chave];
        }
        public char ObterChavePorPosicao(int posicao)
        {
            if (posicao < 0 || posicao >= personagens.Count)
                throw new ArgumentOutOfRangeException(nameof(posicao), "A posição está fora do intervalo válido.");

            return personagens.ElementAt(posicao).Key;
        }


    }
}

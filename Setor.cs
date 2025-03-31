using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace king_me
{
    public class Setor
    {
        public int NumSetor { get; }
        public int PosX { get; }
        public int PosY { get; }
        public int QtdPersonagensAtual { get; set; }

        public Setor(int setor, int posX, int posY, int qtdPersonagensAtual)
        {
            NumSetor = setor;
            PosX = posX;
            PosY = posY;
            QtdPersonagensAtual = qtdPersonagensAtual;
        }
    }
}

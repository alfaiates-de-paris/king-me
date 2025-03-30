using System;
using System.Drawing;

namespace king_me
{
    public static class Tabuleiro
    {
        public static Image JuntarImagensVerticalmente(string caminhoImagemCima, string caminhoImagemBaixo)
        {
            Image cima = Image.FromFile(caminhoImagemCima);
            Image baixo = Image.FromFile(caminhoImagemBaixo);

            int largura = Math.Max(cima.Width, baixo.Width);
            int altura = cima.Height + baixo.Height;

            Bitmap imagemFinal = new Bitmap(largura, altura);
            using (Graphics g = Graphics.FromImage(imagemFinal))
            {
                g.DrawImage(cima, 0, 0);
                g.DrawImage(baixo, 0, cima.Height);
            }

            return imagemFinal;
        }
    }
}

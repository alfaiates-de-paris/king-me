using king_me.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace king_me.Services
{
    class TabuleiroService : ITabuleiroService
    {
        List<Setor> setores = new List<Setor>();

        public TabuleiroService()
        {
            setores.Add(new Setor(0, 53, 578, 0));
            setores.Add(new Setor(1, 53, 514, 0));
            setores.Add(new Setor(2, 49, 427, 0));
            setores.Add(new Setor(3, 52, 344, 0));
            setores.Add(new Setor(4, 53, 262, 0));
            setores.Add(new Setor(5, 61, 183, 0));
            setores.Add(new Setor(10, 99, 91, 0));
        }

        public void MoverPersonagem(Panel pnl, string personagem, int setor, int index)
        {
            int x = setores[setor].PosX;
            int y = setores[setor].PosY;
            x = x + 40 * setores[setor].QtdPersonagensAtual;
            y = y - 40 * setores[setor].QtdPersonagensAtual;

            if (index >= 0 && index < pnl.Controls.Count && pnl.Controls[index] is PictureBox)
            {
                PictureBox pictureBox = (PictureBox)pnl.Controls[index];
                pictureBox.Image = System.Drawing.Image.FromFile($"../Properties/images/cartas/carta_{personagem}.png");
                pictureBox.Location = new System.Drawing.Point(x, y);
            }
            else
            {
                PictureBox pictureBox = new PictureBox(); 
                pictureBox.Name = "pic" + personagem.ToUpper();
                pictureBox.Image = System.Drawing.Image.FromFile($"../Properties/images/cartas/carta_{personagem}.png");
                pictureBox.Location = new System.Drawing.Point(x, y);
                pictureBox.Size = new System.Drawing.Size(40, 40);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.BackColor = System.Drawing.Color.Transparent;
                pnl.Controls.Add(pictureBox);
                setores[setor].QtdPersonagensAtual++;
            }
        }
    }

   
}

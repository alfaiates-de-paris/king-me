using king_me.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
        Dictionary<string, int> JogadorSetor { get; } = new Dictionary<string, int>();

        public TabuleiroService()
        {
            setores.Add(new Setor(0, 53, 558, 0)); // 578 - 20
            setores.Add(new Setor(1, 53, 494, 0)); // 514 - 20
            setores.Add(new Setor(2, 49, 407, 0)); // 427 - 20
            setores.Add(new Setor(3, 52, 324, 0)); // 344 - 20
            setores.Add(new Setor(4, 53, 242, 0)); // 262 - 20
            setores.Add(new Setor(5, 61, 163, 0)); // 183 - 20
            setores.Add(new Setor(10, 99, 71, 0)); // 91 - 20
        }

        public void MoverPersonagem(Panel pnl, string personagem, int setor)
        {
            int index = -1;

            for (int i = 0; i < JogadorSetor.Count; i++)
            {
                if (JogadorSetor.ElementAt(i).Key == personagem.ToUpper())
                {
                    setores[JogadorSetor.ElementAt(i).Value].QtdPersonagensAtual--;
                    index = i;
                    break;
                }
            }

            int x = setores[setor].PosX;
            int y = setores[setor].PosY;
            x = x + 35 * setores[setor].QtdPersonagensAtual;
            string caminhoAbsoluto = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Properties", "images", "cartas", $"carta_{personagem}.png");


            if (index >= 0 && index < pnl.Controls.Count && pnl.Controls[index] is PictureBox)
            {

                PictureBox pictureBox = (PictureBox)pnl.Controls[index];
                pictureBox.Image = System.Drawing.Image.FromFile(caminhoAbsoluto);
                pictureBox.Location = new System.Drawing.Point(x, y);
                JogadorSetor[personagem] = setor;
            }
            else
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Name = "pic" + personagem.ToUpper();
                pictureBox.Image = System.Drawing.Image.FromFile(caminhoAbsoluto); 
                pictureBox.Location = new System.Drawing.Point(x, y);
                pictureBox.Size = new System.Drawing.Size(30, 40);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.BackColor = System.Drawing.Color.Transparent;

                pnl.Controls.Add(pictureBox);
                setores[setor].QtdPersonagensAtual++;
                JogadorSetor.Add(personagem.ToUpper(), setor);

            }
        }

        public int ObterSetorAtual(string personagem)
        {
            if (JogadorSetor.TryGetValue(personagem.ToUpper(), out int setor))
            {
                return setor;
            }
            throw new ArgumentException("Personagem não encontrado.");
        }
    }
}

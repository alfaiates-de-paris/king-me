﻿using king_me.Interfaces;
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
        {//lista de setores e o número, coordenadas e qtd de personagens em cada
            setores.Add(new Setor(0, 53, 558, 0)); 
            setores.Add(new Setor(1, 53, 494, 0)); 
            setores.Add(new Setor(2, 49, 407, 0)); 
            setores.Add(new Setor(3, 52, 324, 0)); 
            setores.Add(new Setor(4, 53, 242, 0)); 
            setores.Add(new Setor(5, 61, 163, 0)); 
            setores.Add(new Setor(10, 120, 71, 0)); 
        }

        public void MoverPersonagem(Panel pnl, string personagem, int setor)
        {
            int index = -1; //posição do elemento dentro do panel, por padrão eu seto como -1 para caso seja um personagem novo

            for (int i = 0; i < JogadorSetor.Count; i++) //faz a busca para caso o elemento exista, ele ache o indice dele
            {
                if (JogadorSetor.ElementAt(i).Key == personagem.ToUpper())
                {
                    setores[JogadorSetor.ElementAt(i).Value].QtdPersonagensAtual--;//decrementa a quantidade de personagens do setor atual, porque ele vai ser movido
                    index = i;
                    break;
                }
            }

            if (setor == 10)
                setor = 6; //setor 10 é o mesmo que 6, só para facilitar a leitura do código
            int x = setores[setor].PosX;
            int y = setores[setor].PosY;
            x = x + 35 * setores[setor].QtdPersonagensAtual; //joga a carta para o lado caso ja exista uma carta naquele setor, para não haver sobreposição
            string caminhoAbsoluto = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Properties", "images", "cartas", $"carta_{personagem}.png");


            if (index >= 0 && index < pnl.Controls.Count && pnl.Controls[index] is PictureBox)
            {
                //ele entra nesse if caso ele vá mover um personagem que já existe
                PictureBox pictureBox = (PictureBox)pnl.Controls[index];
                pictureBox.Image = System.Drawing.Image.FromFile(caminhoAbsoluto);
                pictureBox.Location = new System.Drawing.Point(x, y);
                JogadorSetor[personagem] = setor;
            }
            else
            { //para colocar um personagem novo no tabuleiro ele entra nesse else
                PictureBox pictureBox = new PictureBox();
                pictureBox.Name = "pic" + personagem.ToUpper();
                pictureBox.Image = System.Drawing.Image.FromFile(caminhoAbsoluto); 
                pictureBox.Location = new System.Drawing.Point(x, y);
                pictureBox.Size = new System.Drawing.Size(30, 40);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.BackColor = System.Drawing.Color.Transparent;
                //adicionando o personagem ao painel
                pnl.Controls.Add(pictureBox);
                setores[setor].QtdPersonagensAtual++;
                JogadorSetor.Add(personagem.ToUpper(), setor);

            }
        }

        public int? ObterSetorAtual(string personagem)
        {
            if (JogadorSetor.TryGetValue(personagem.ToUpper(), out int setor))
            {
                return setor;
            }
            return null;
        }
        public void LimparTabuleiro(Panel pnl)
        {
            pnl.Controls.Clear();
            foreach (var setor in setores)
            {
                setor.QtdPersonagensAtual = 0;
            }
            JogadorSetor.Clear();
        }

        public void AtualizarTabuleiro(Panel pnl, string statusTabuleiro)
        {
            this.LimparTabuleiro(pnl);
            string[] posicoes = statusTabuleiro.Split(new string[] { "\r\n" }, StringSplitOptions.None);//separa cada linha do retorno fornecido pela dll
            foreach (string carta in posicoes) //por padrão, o retorno da dll é separado por \r\n, cada linha é uma carta
            {
                if (string.IsNullOrWhiteSpace(carta)) //passa pro proximo item caso a linha seja vazia
                    continue;

                string[] partes = carta.Split(','); //o que separa o setor e a carta é uma virgula, vem no padrão SETOR,CARTA
                if (partes.Length >= 2) //evita que dê o erro IndexOutOfRange
                {
                    this.MoverPersonagem(pnl, partes[1], Convert.ToInt32(partes[0]));
                }
            }
        }

        public void RemoverPersonagem(Panel pnl, string personagem)
        {
            if (JogadorSetor.TryGetValue(personagem.ToUpper(), out int setor))
            {
                setores[setor].QtdPersonagensAtual--;
                JogadorSetor.Remove(personagem.ToUpper());
                PictureBox pictureBox = (PictureBox)pnl.Controls["pic" + personagem.ToUpper()];
                if (pictureBox != null)
                {
                    pnl.Controls.Remove(pictureBox);
                    pictureBox.Dispose();
                }
            }
        }

        public void LimparSetor10(Panel pnl)
        {
            int setor = 6; // setor 10 é equivalente ao setor 6, pois estã na 6a posição da lista de setores
            // remove o único personagem do setor 10, se existir  
            if (setores[setor].QtdPersonagensAtual > 0)
            {
                var personagem = JogadorSetor.FirstOrDefault(j => j.Value == setor).Key; //busca o primeiro personagem que tem como setor o 6°, vulgo o unico
                if (!string.IsNullOrEmpty(personagem))
                {
                    RemoverPersonagem(pnl, personagem);
                }
            }
        }

        public List<int> ObterSetoresNaoCheios(int idPartida) //método pra fase de setup
        {
            List<int> setoresDisponiveis = new List<int>();
            for (int i = 1; i <= 4; i++)
            {
                if (!IsSetorCheio(i, idPartida))
                {
                    setoresDisponiveis.Add(i);
                }
            }
            return setoresDisponiveis;
        }

        public bool IsSetorCheio(int setor, int idPartida) //método na promoção
        {
            string tabuleiro = KingMeServer.Jogo.VerificarVez(idPartida);
            if (string.IsNullOrEmpty(tabuleiro))
                return false;

            string[] linhas = tabuleiro.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            int contadorPersonagens = 0;
            foreach (string linha in linhas)
            {
                if (linha.StartsWith($"{setor},"))
                {
                    contadorPersonagens++;
                }
            }

            return contadorPersonagens >= 4; 
        }
    }
}

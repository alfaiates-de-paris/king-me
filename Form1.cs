using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KingMeServer;

namespace king_me
{
    public partial class KingMe : Form
    {
        public KingMe()
        {
            InitializeComponent();

            filtroStatus.SelectedIndex = 0;
            filtroStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            listarPartidas_Click(null, null);
        }

        private void listarPartidas_Click(object sender, EventArgs e)
        {
            string status = filtroStatus.Text.Substring(0, 1);
            string partidas = string.Empty;

            partidas = KingMeServer.Jogo.ListarPartidas(status);

            if (partidas == string.Empty) { MessageBox.Show("Nenhuma partida encontrada."); return; }

            partidasBox.Text = partidas;
        }

        private void entrarPartida_Click(object sender, EventArgs e)
        {
            string id = idPartidaBox.Text;
            string jogador = nomeJogador.Text;
            string senha = senhaPartida.Text;

            if (id == string.Empty) { MessageBox.Show("Informe o ID da partida."); return; }
            if (jogador == string.Empty) { MessageBox.Show("Informe o nome do jogador."); return; }
            if (senha == string.Empty) { MessageBox.Show("Informe a senha da partida."); return; }

            string infoJogador = KingMeServer.Jogo.Entrar(int.Parse(id), jogador, senha);

            string idJogador = infoJogador.Split(',')[0];
            string senhaJogador = infoJogador.Split(',')[1];

            idJogadorBox.Text = idJogador;
            idJogadorLabel.Text = $"ID: {idJogador}";
            senhaJogadorBox.Text = senhaJogador;
            senhaJogadorLabel.Text = $"Senha: {senhaJogador}";

            listarJogadores_Click(null, null);
        }

        private void criarPartida_Click(object sender, EventArgs e)
        {
            string nome = nomePartida.Text;
            string senha = senhaPartida.Text;
            string grupo = nomeGrupo.Text;

            if (nome == string.Empty) { MessageBox.Show("Informe o nome da partida."); return; }
            if (senha == string.Empty) { MessageBox.Show("Informe a senha da partida."); return; }
            if (grupo == string.Empty) { MessageBox.Show("Informe o grupo da partida."); return; }

            string id = KingMeServer.Jogo.CriarPartida(nome, senha, grupo);

            idPartidaBox.Text = id;
            idPartidaLabel.Text = id;
        }

        private void listarJogadores_Click(object sender, EventArgs e)
        {
            string id = idPartidaBox.Text;
            if (id == string.Empty) { MessageBox.Show("Informe o ID da partida."); return; }

            JogadoresBox.Text = KingMeServer.Jogo.ListarJogadores(int.Parse(id));
        }
    }
}

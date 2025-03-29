﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KingMeServer;
using king_me.Interfaces;

namespace king_me
{
    public partial class KingMe : Form
    {
        private readonly IPartidaService _partidaService;
        private readonly IJogadorService _jogadorService;
        private readonly ICartaService _cartaService;
        private bool SucessoIniciarPartida = false;

        public KingMe(IPartidaService partidaService, IJogadorService jogadorService, ICartaService cartaService)
        {
            InitializeComponent();
            _partidaService = partidaService ?? throw new ArgumentNullException(nameof(partidaService));
            _jogadorService = jogadorService ?? throw new ArgumentNullException(nameof(jogadorService));
            _cartaService = cartaService ?? throw new ArgumentNullException(nameof(cartaService));

            cboStatus.SelectedIndex = 0;
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            btnListarPartidas_Click(null, null);
            CarregarPersonagens();
            CarregarSetor();
        }

        private void btnListarPartidas_Click(object sender, EventArgs e)
        {
            string status = cboStatus.Text.Substring(0, 1);
            string partidas = _partidaService.ListarPartidas(status);

            if (partidas == string.Empty)
            {
                MessageBox.Show("Nenhuma partida encontrada.");
                return;
            }

            txtPartidas.Text = partidas;
        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            string id = txtIdPartida.Text;
            string jogador = txtNomeJogador.Text;
            string senha = txtSenhaPartida.Text;

            if (id == string.Empty) { MessageBox.Show("Informe o ID da partida."); return; }
            if (jogador == string.Empty) { MessageBox.Show("Informe o nome do jogador."); return; }
            if (senha == string.Empty) { MessageBox.Show("Informe a senha da partida."); return; }

            var infoJogador = _jogadorService.Entrar(int.Parse(id), jogador, senha);

            txtIdJogador.Text = infoJogador.IdJogador;
            lblIdJogador.Text = $"ID: {infoJogador.IdJogador}";
            txtSenhaJogador.Text = infoJogador.SenhaJogador;
            lblSenhaJogador.Text = $"Senha: {infoJogador.SenhaJogador}";

            btnListarJogadores_Click(null, null);
        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            string nome = txtNomePartida.Text;
            string senha = txtSenhaPartida.Text;
            string grupo = txtNomeGrupo.Text;

            if (nome == string.Empty) { MessageBox.Show("Informe o nome da partida."); return; }
            if (senha == string.Empty) { MessageBox.Show("Informe a senha da partida."); return; }
            if (grupo == string.Empty) { MessageBox.Show("Informe o grupo da partida."); return; }

            string id = _partidaService.CriarPartida(nome, senha, grupo);

            txtIdPartida.Text = id;
            lblIdPartida.Text = id;
        }

        private void btnListarJogadores_Click(object sender, EventArgs e)
        {
            string id = txtIdPartida.Text;
            if (id == string.Empty)
            {
                MessageBox.Show("Informe o ID da partida.");
                return;
            }

            txtJogadores.Text = _jogadorService.ListarJogadores(int.Parse(id));
        }

        public void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            SucessoIniciarPartida = true;
            int idJogador = Int32.Parse(txtIdJogador.Text);
            string senhaJogador = txtSenhaJogador.Text;
            int id = int.Parse(txtIdPartida.Text);

            _partidaService.Iniciar(idJogador, senhaJogador);
        }

        private void btnExibirCartas_Click(object sender, EventArgs e)
        {
            txtPersonagensFavoritos.Clear();
            Mao mao = new Mao();
            mao.CriarCartas();
            int idJogador = int.Parse(txtIdJogador.Text);
            string senhaJogador = txtSenhaJogador.Text;

            string temp = _cartaService.ListarCartas(idJogador, senhaJogador);
            temp = temp.Substring(0, temp.Length - 2);

            foreach (char caractere in temp)
            {
                txtPersonagensFavoritos.Text += mao.ExibirPersonagem(caractere) + "\r\n";
            }
        }

        private void CarregarPersonagens()
        {
            List<string> personagensFixos = new List<string>
            {
                "Adilson Konrad",
                "Beatriz Paiva",
                "Claro",
                "Douglas Baquiao",
                "Eduardo Takeo",
                "Guilherme Rey",
                "Heredia",
                "Karin",
                "Leonardo Takuno",
                "Mario Toledo",
                "Quintas",
                "Ranulfo",
                "Toshio"
            };

            txtPersonagensExistentes.Items.Clear();

            foreach (string personagem in personagensFixos)
            {
                txtPersonagensExistentes.Items.Add(personagem);
            }
        }

        private void CarregarSetor()
        {
            List<string> setores = new List<string>
            {
                "10.Rei",
                "5.Nobres",
                "4.Dignatários",
                "3.Oficiais",
                "2.Mercadores",
                "1.Artesãos",
                "0.Plebeus"
            };

            txtSetoresExistentes.Items.Clear();

            foreach (string setor in setores)
            {
                txtSetoresExistentes.Items.Add(setor);
            }
        }

        private void btnVerificarVez_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtIdJogador.Text) || string.IsNullOrEmpty(txtSenhaJogador.Text))
                {
                    MessageBox.Show("Por favor, inicie a partida antes de verificar a vez.", "Atenção", MessageBoxButtons.OK);
                    return;
                }

                if (!SucessoIniciarPartida)
                {
                    MessageBox.Show("Por favor, inicie a partida antes de verificar a vez.", "Atenção", MessageBoxButtons.OK);
                    return;
                }

                int idPartida = int.Parse(txtIdPartida.Text);
                var jogador = _jogadorService.GetJogadorDaVez(idPartida);

                string jogadores = _jogadorService.ListarJogadores(idPartida);

                if (string.IsNullOrEmpty(jogadores))
                {
                    MessageBox.Show("Nenhuma informação encontrada sobre a vez do jogador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string[] listaJogadores = jogadores.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                if (listaJogadores.Length == 0)
                {
                    MessageBox.Show("Não foi possível determinar a vez do jogador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                lblVezIdJogador.Text = $"ID do Jogador: {jogador.IdJogador.Substring(0, Math.Min(4, jogador.IdJogador.Length))}";

                lblVezNomeJogador.Text = $"Nome: {jogador.NomeJogador}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar a vez do jogador: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMoverPersonagem_Click(object sender, EventArgs e)
        {
            int idJogador = int.Parse(txtIdJogador.Text);
            string senhaJogador = txtSenhaJogador.Text;
            string personagem = txtPersonagem.Text.Substring(0, 1);
            int setor = int.Parse(txtSetor.Text);

            string retorno = _cartaService.ColocarPersonagem(idJogador, senhaJogador, setor, personagem);
            txtTabuleiroAtual.Text = retorno;
        }

        private void label2_Click(object sender, EventArgs e) { }

        private void txtPersonagens_TextChanged(object sender, EventArgs e) { }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void KingMe_Load(object sender, EventArgs e) { }
    }
}

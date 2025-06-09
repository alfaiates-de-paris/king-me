using king_me.Interfaces;
using king_me.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using king_me.Forms;
using king_me;

namespace king_me.Forms
{
    public partial class Lobby: Form
    {
        private readonly IPartidaService _partidaService;
        private readonly IJogadorService _jogadorService;
        private bool SucessoIniciarPartida = false;

        public Lobby(IPartidaService partidaService, IJogadorService jogadorService)
        {
            InitializeComponent();
            _partidaService = partidaService ?? throw new ArgumentNullException(nameof(partidaService));
            _jogadorService = jogadorService ?? throw new ArgumentNullException(nameof(jogadorService));

            cboStatus.SelectedIndex = 0;
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            btnListarPartidas_Click(null, null);
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
        }

        private void btnVoltarLobby_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnEntrarLobby_Click(object sender, EventArgs e)
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

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            string id = txtIdPartida.Text;
            string jogador = txtNomeJogador.Text;
            string senhaPartida = txtSenhaPartida.Text;
            string idJogador = txtIdJogador.Text;
            string senha = txtSenhaJogador.Text;
            string nomeJogador = txtNomeJogador.Text;

            var cartaService = new Services.CartaService();
            var tabuleiroService = new Services.TabuleiroService();
            var votoService = new VotoService();

            if (id == string.Empty) { MessageBox.Show("Informe o ID da partida."); return; }
            if (jogador == string.Empty) { MessageBox.Show("Informe o nome do jogador."); return; }
            if (senha == string.Empty) { MessageBox.Show("Informe a senha da partida."); return; }


             _partidaService.Iniciar(int.Parse(id), senhaPartida);
             SucessoIniciarPartida = true;
             KingMe partidaForm = new KingMe(_partidaService, _jogadorService, cartaService, votoService, tabuleiroService, id, idJogador, senha, senhaPartida, nomeJogador);
             partidaForm.ShowDialog();
            
        }

        private void Lobby_Load(object sender, EventArgs e)
        {

        }
    }
}

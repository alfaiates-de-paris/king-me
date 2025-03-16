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
        // Variável para verificar se a partida foi iniciada
        private bool SucessoIniciarPartida = false;
        public KingMe()
        {
            InitializeComponent();

            cboStatus.SelectedIndex = 0;
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            btnListarPartidas_Click(null, null);
            CarregarPersonagens();
            CarregarSetor();
        }

        private void btnListarPartidas_Click(object sender, EventArgs e)
        {
            string status = cboStatus.Text.Substring(0, 1);
            string partidas = string.Empty;

            partidas = KingMeServer.Jogo.ListarPartidas(status);

            if (partidas == string.Empty) { MessageBox.Show("Nenhuma partida encontrada."); return; }

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

            string infoJogador = KingMeServer.Jogo.Entrar(int.Parse(id), jogador, senha);

            string idJogador = infoJogador.Split(',')[0];
            string senhaJogador = infoJogador.Split(',')[1];

            txtIdJogador.Text = idJogador;
            lblIdJogador.Text = $"ID: {idJogador}";
            txtSenhaJogador.Text = senhaJogador;
            lblSenhaJogador.Text = $"Senha: {senhaJogador}";

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

            string id = KingMeServer.Jogo.CriarPartida(nome, senha, grupo);

            txtIdPartida.Text = id;
            lblIdPartida.Text = id;
        }

        private void btnListarJogadores_Click(object sender, EventArgs e)
        {
            string id = txtIdPartida.Text;
            if (id == string.Empty) { MessageBox.Show("Informe o ID da partida."); return; }

            txtJogadores.Text = KingMeServer.Jogo.ListarJogadores(int.Parse(id));
        }

        public void btnIniciarPartida_Click(object sender, EventArgs e)
        {

            SucessoIniciarPartida = true; // Atribui true para a variável que verifica se a partida foi iniciada com sucesso
            int idJogador = Int32.Parse(txtIdJogador.Text);
            string senhaJogador = txtSenhaJogador.Text;
            int id = int.Parse(txtIdPartida.Text);

            KingMeServer.Jogo.Iniciar(idJogador, senhaJogador);

       
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPersonagens_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            int idJogador = int.Parse(txtIdJogador.Text);
            string senhaJogador = txtSenhaJogador.Text;
            int id = int.Parse(txtIdPartida.Text);
            string senha = txtSenhaPartida.Text;

            lblPersonagensFav.Text = KingMeServer.Jogo.ListarCartas(idJogador, senhaJogador);
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

            listBox1.Items.Clear();

            foreach (string personagem in personagensFixos)
            {
                listBox1.Items.Add(personagem);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (string.IsNullOrEmpty(txtIdJogador.Text) || string.IsNullOrEmpty(txtSenhaJogador.Text))
                {
                    MessageBox.Show("Por favor, inicie a partida antes de verificar a vez.", "Atenção", MessageBoxButtons.OK);
                    return;
                }

                
                if(!SucessoIniciarPartida)
                {
                    MessageBox.Show("Por favor, inicie a partida antes de verificar a vez.", "Atenção", MessageBoxButtons.OK);
                    return;
                }

                int idPartida = int.Parse(txtIdPartida.Text);

                
                string jogadores = KingMeServer.Jogo.ListarJogadores(idPartida);

                if (string.IsNullOrEmpty(jogadores))
                {
                    MessageBox.Show("Nenhuma informação encontrada sobre a vez do jogador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string[] listaJogadores = jogadores.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                if (listaJogadores.Length > 0)
                {
                    
                    string jogadorDaVez = listaJogadores[0];

                   
                    string[] dadosJogador = jogadorDaVez.Split(',');

                    if (dadosJogador.Length >= 2) 
                    {
                        string idJogador = dadosJogador[0].Trim();  
                        string nomeJogador = dadosJogador[1].Trim();

                       
                        label7.Text = $"ID do Jogador: {idJogador}";
                        label6.Text = $"Nome: {nomeJogador}";
                    }
                    else
                    {
                        MessageBox.Show("Formato inesperado do servidor. Não foi possível extrair o ID e Nome do jogador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Não foi possível determinar a vez do jogador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar a vez do jogador: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void label3_Click(object sender, EventArgs e)
        {

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

            listBox2.Items.Clear();

            foreach (string setor in setores)
            {
                listBox2.Items.Add(setor);
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPersonagensFav_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void KingMe_Load(object sender, EventArgs e)
        {

        }

     
    }
}

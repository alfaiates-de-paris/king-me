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
using king_me.Interfaces;
using king_me.Services;
using king_me.Models;

namespace king_me
{
    public partial class KingMe : Form
    {
        private readonly IPartidaService _partidaService;
        private readonly IJogadorService _jogadorService;
        private readonly ICartaService _cartaService;
        private readonly ITabuleiroService _tabuleiroService;
        private bool SucessoIniciarPartida = false;
        private Mao mao = new Mao();
        private readonly IVotoService _votoService;

        public KingMe(IPartidaService partidaService, IJogadorService jogadorService, ICartaService cartaService, IVotoService votoService, ITabuleiroService tabuleiroService)

        {
            InitializeComponent();
            _partidaService = partidaService ?? throw new ArgumentNullException(nameof(partidaService));
            _jogadorService = jogadorService ?? throw new ArgumentNullException(nameof(jogadorService));
            _cartaService = cartaService ?? throw new ArgumentNullException(nameof(cartaService));
            _tabuleiroService = tabuleiroService ?? throw new ArgumentNullException(nameof(tabuleiroService));
            _votoService = votoService ?? throw new ArgumentNullException(nameof(votoService));

            mao.CriarCartas();

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
            btnVerificarVez.Visible = false;
            btnMoverPersonagem.Visible = false;
            txtSetor.Visible = false;
            txtPersonagem.Visible = false;
            lblSetor.Visible = false;
            lblPersonagem.Visible = false;

            // Ativa o timer automático
            tmrVerificarVez.Start();

            _partidaService.Iniciar(idJogador, senhaJogador);
        }

        private void btnExibirCartas_Click(object sender, EventArgs e)
        {
            txtPersonagensFavoritos.Clear();

            int idJogador = int.Parse(txtIdJogador.Text);
            string senhaJogador = txtSenhaJogador.Text;

            string temp = _cartaService.ListarCartas(idJogador, senhaJogador);
            temp = temp.Substring(0, temp.Length - 2);

            foreach (char caractere in temp)
            {
                if (mao.personagens.ContainsKey(caractere))
                {
                    txtPersonagensFavoritos.Text += mao.ExibirPersonagem(caractere) + "\r\n";
                }
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


                AtualizarVotosRestantes(int.Parse(jogador.IdJogador));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar a vez do jogador: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool VerificarVez()
        {
            try
            {
                if (string.IsNullOrEmpty(txtIdJogador.Text) || string.IsNullOrEmpty(txtSenhaJogador.Text))
                {
                    MessageBox.Show("Por favor, inicie a partida antes de verificar a vez.", "Atenção", MessageBoxButtons.OK);
                    return false;
                }

                if (!SucessoIniciarPartida)
                {
                    MessageBox.Show("Por favor, inicie a partida antes de verificar a vez.", "Atenção", MessageBoxButtons.OK);
                    return false;
                }

                int idPartida = int.Parse(txtIdPartida.Text);
                var jogadorDaVez = _jogadorService.GetJogadorDaVez(idPartida);

                if (jogadorDaVez == null)
                {
                    MessageBox.Show("Jogador da vez não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Exibe dados do jogador da vez
                lblVezIdJogador.Visible = true;
                lblVezNomeJogador.Visible = true;
                lblVezIdJogador.Text = $"ID do Jogador: {jogadorDaVez.IdJogador.Substring(0, Math.Min(4, jogadorDaVez.IdJogador.Length))}";
                lblVezNomeJogador.Text = $"Nome: {jogadorDaVez.NomeJogador}";

                // Atualiza votos do jogador logado
                if (int.TryParse(txtIdJogador.Text, out int idJogadorLogado))
                {
                    AtualizarVotosRestantes(idJogadorLogado);
                }

                // Atualiza votos do jogador da vez também (opcional, mas útil para debug/visibilidade)
                if (int.TryParse(jogadorDaVez.IdJogador, out int idJogadorDaVez))
                {
                    AtualizarVotosRestantes(idJogadorDaVez);
                }

                // Se personagem chegou no setor 10, e for a vez do jogador logado, vota automaticamente
                string tabuleiro = txtTabuleiroAtual.Text;
                if (tabuleiro.Contains("10"))
                {
                    if (txtIdJogador.Text == jogadorDaVez.IdJogador)
                    {
                        int idJogador = int.Parse(txtIdJogador.Text);
                        string senhaJogador = txtSenhaJogador.Text;

                        if (_votoService.GetVotosRestantes(idJogador) > 0)
                        {
                            string votoAuto = new Random().Next(2) == 0 ? "S" : "N";
                            string retorno = _votoService.Votar(idJogador, senhaJogador, votoAuto);

                            if (!retorno.StartsWith("ERRO"))
                            {
                                txtVoto.Text = votoAuto;
                                MessageBox.Show($"Voto automático enviado: {votoAuto}", "Votação automática", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                AtualizarVotosRestantes(idJogador);

                                lblVotosRestantes.Text = string.Empty;
                            }
                            else
                            {
                                MessageBox.Show(retorno, "Erro ao votar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("É a vez de outro jogador. Troque o ID e a senha para votar.", "Aguardando troca de jogador", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar a vez do jogador: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            //Solução temporária pro problema, tem que separar esse método em dois métodos diferentes, um pra votar e um pra verificar vez
            int idDaPartida = int.Parse(txtIdPartida.Text);
            var jogadorVez = _jogadorService.GetJogadorDaVez(idDaPartida);
            if (txtIdJogador.Text == jogadorVez.IdJogador) return true;
            else
            {
                MessageBox.Show("É a vez de outro jogador. Troque o ID e a senha para jogar.", "Aguardando troca de jogador", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }
        private void PosicionarPersonagem()
        {
            string retornoVerificarVez = KingMeServer.Jogo.VerificarVez(int.Parse(txtIdPartida.Text));
            string faseDoJogo = retornoVerificarVez.Split(',')[3];
            faseDoJogo = faseDoJogo.Substring(0, 1);
            
            if(faseDoJogo == "S") //Se o jogo está na fase de Setup
            {
                int idJogador = int.Parse(txtIdJogador.Text);

                string senhaJogador = txtSenhaJogador.Text;

                int posicao = 0;
                int? retornoSetorPersonagem = 0;
                char inicialPersonagem = '\0';

                //while para achar um personagem não posicionado
                while (retornoSetorPersonagem != null && posicao < 13) //tem 13 personagens por isso a restrição de posição
                {
                    inicialPersonagem = mao.ObterChavePorPosicao(posicao);
                    retornoSetorPersonagem = _tabuleiroService.ObterSetorAtual(inicialPersonagem.ToString());
                    posicao++;
                }

                int setor = _tabuleiroService.ObterSetorNãoCheio();
                if (setor == -1)
                {
                    MessageBox.Show("Não há setores disponíveis para posicionar o personagem.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                string retornoDLL = _cartaService.ColocarPersonagem(idJogador, senhaJogador, setor, inicialPersonagem.ToString());

                if (retornoDLL.StartsWith("ERRO"))
                {
                    MessageBox.Show(retornoDLL, "Erro ao adicionar personagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Atualiza o tabuleiro visual
                _tabuleiroService.AtualizarTabuleiro(pnlTabuleiro, retornoDLL);
                txtTabuleiroAtual.Text = retornoDLL;

                txtPersonagem.Clear();
                txtPersonagem.Focus();
            } 
        }


        private void tmrVerificarVez_Tick(object sender, EventArgs e)
        {
            tmrVerificarVez.Enabled = false;
            bool minhaVez = VerificarVez();
            if (minhaVez)
                PosicionarPersonagem();
            tmrVerificarVez.Enabled = true;
        }

        private void btnMoverPersonagem_Click(object sender, EventArgs e)
        {
            int idJogador = int.Parse(txtIdJogador.Text);
            string senhaJogador = txtSenhaJogador.Text;
            string personagemLetra = txtPersonagem.Text.Substring(0, 1).ToUpper();

            // Verifica se o campo de setor foi preenchido corretamente
            if (!int.TryParse(txtSetor.Text, out int setor))
            {
                MessageBox.Show("Informe um setor válido antes de mover o personagem.", "Setor não informado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            char personagem = personagemLetra[0];

            string retorno = _cartaService.ColocarPersonagem(idJogador, senhaJogador, setor, personagemLetra);

            if (retorno.StartsWith("ERRO"))
            {
                MessageBox.Show(retorno, "Erro ao adicionar personagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Atualiza o tabuleiro visual
            _tabuleiroService.AtualizarTabuleiro(pnlTabuleiro, retorno);
            txtTabuleiroAtual.Text = retorno;

            txtPersonagem.Clear();
            txtPersonagem.Focus();
        }


        private void label2_Click(object sender, EventArgs e) { }

        private void txtPersonagens_TextChanged(object sender, EventArgs e) { }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void KingMe_Load(object sender, EventArgs e) { }

        private void btnPromover_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdJogador.Text, out int idJogador))
            {
                MessageBox.Show("ID do jogador inválido.");
                return;
            }

            string senhaJogador = txtSenhaJogador.Text;
            string personagemInput = txtPersonagem.Text.Trim();

            if (string.IsNullOrEmpty(personagemInput))
            {
                MessageBox.Show("Informe o personagem que deseja promover.");
                return;
            }

            string personagemLetra = personagemInput.Substring(0, 1).ToUpper();


            string retorno = _cartaService.Promover(idJogador, senhaJogador, personagemLetra);

            if (retorno.StartsWith("ERRO"))
            {
                MessageBox.Show(retorno, "Erro ao promover personagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _tabuleiroService.AtualizarTabuleiro(pnlTabuleiro, retorno);
            txtTabuleiroAtual.Text = retorno;
            txtPersonagem.Clear();
            txtPersonagem.Focus();
        }

        private void btnVotar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdJogador.Text, out int idJogador))
            {
                MessageBox.Show("ID do jogador inválido.");
                return;
            }

            string senhaJogador = txtSenhaJogador.Text;
            string voto = txtVoto.Text.Trim().ToUpper();

            if (string.IsNullOrEmpty(voto))
            {
                MessageBox.Show("Digite S para aceitar ou N para rejeitar.");
                return;
            }

            string retorno = _votoService.Votar(idJogador, senhaJogador, voto);


            if (retorno.StartsWith("ERRO"))
            {
                MessageBox.Show(retorno, "Erro ao votar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Voto registrado com sucesso!");
            if (txtVoto.Text == "N") { 
                _tabuleiroService.LimparSetor10(pnlTabuleiro);
            }
            txtVoto.Clear();
            txtVoto.Focus();

            AtualizarVotosRestantes(idJogador);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblVotosRestantes_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIdJogador.Text, out int idJogador))
            {
                AtualizarVotosRestantes(idJogador);
            }
        }
        private void AtualizarVotosRestantes(int idJogador)
        {
            int votosRestantes = _votoService.GetVotosRestantes(idJogador);
            lblVotosRestantes.Text = $"Votos restantes: {votosRestantes}";

        }


        private void lblVezIdJogador_Click(object sender, EventArgs e)
        {

        }

        private void lblVezNomeJogador_Click(object sender, EventArgs e)
        {

        }

    }
}
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
        int rodadaAtual = 1;
        string statusPartida;
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
            lblRodadaAtual.Text = "Rodada atual: " + rodadaAtual;
            // Ativa o timer automático
            tmrVerificarVez.Start();

            _partidaService.Iniciar(idJogador, senhaJogador);

            txtPersonagensFavoritos.Clear();

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

                // Atualiza votos do jogador da vez (opcional para debug)
                if (int.TryParse(jogadorDaVez.IdJogador, out int idJogadorDaVez))
                {
                    AtualizarVotosRestantes(idJogadorDaVez);
                }

                // Verifica tabuleiro e realiza voto automático
                string tabuleiro = KingMeServer.Jogo.VerificarVez(idPartida);
                string[] linhasTabuleiro = tabuleiro.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                tabuleiro = string.Join("\r\n", linhasTabuleiro.Skip(1));

                RealizarVotoAutomatico(tabuleiro, jogadorDaVez);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar a vez do jogador: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Retorna se é a vez do jogador logado
            int idDaPartida = int.Parse(txtIdPartida.Text);
            var jogadorVez = _jogadorService.GetJogadorDaVez(idDaPartida);
            return txtIdJogador.Text == jogadorVez.IdJogador;
        }

        private void RealizarVotoAutomatico(string tabuleiro, JogadorDTO jogadorDaVez)

        {
            if (!tabuleiro.Contains("10")) return;

            if (txtIdJogador.Text != jogadorDaVez.IdJogador) return;

            int idJogador = int.Parse(txtIdJogador.Text);
            string senhaJogador = txtSenhaJogador.Text;

            if (_votoService.GetVotosRestantes(idJogador) <= 0) return;

            string votoAuto = new Random().Next(2) == 0 ? "S" : "N";
            string retorno = _votoService.Votar(idJogador, senhaJogador, votoAuto);

            if (!retorno.StartsWith("ERRO"))
            {
                txtVoto.Text = votoAuto;
                MessageBox.Show($"Voto automático enviado: {votoAuto}", "Votação automática", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarVotosRestantes(idJogador);
                
            }
            else
            {
                MessageBox.Show("Erro ao enviar voto automático: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PosicionarPersonagem()
        {
            int idJogador = int.Parse(txtIdJogador.Text);
            string senhaJogador = txtSenhaJogador.Text;

            // Cria lista de personagens não posicionados  
            List<char> personagensDisponiveis = new List<char>();
            for (int i = 0; i < 13; i++) // 13 personagens disponíveis  
            {
                char personagem = mao.ObterChavePorPosicao(i);
                int? setorAtual = _tabuleiroService.ObterSetorAtual(personagem.ToString());
                if (setorAtual == null)
                {
                    personagensDisponiveis.Add(personagem);
                }
            }

            // Se não houver personagens disponíveis  
            if (personagensDisponiveis.Count == 0)
            {
                MessageBox.Show("Não há personagens disponíveis para posicionar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string cartasFavoritas = _cartaService.ListarCartas(idJogador, senhaJogador);
            cartasFavoritas = cartasFavoritas.Substring(0, cartasFavoritas.Length - 2);

            // filtra personagens favoritos disponíveis  
            List<char> personagensFavoritosDisponiveis = personagensDisponiveis.Where(personagem => cartasFavoritas.Contains(personagem)).ToList();

            char personagemSelecionado;

            if (personagensFavoritosDisponiveis.Count > 0)
            {
                personagemSelecionado = personagensFavoritosDisponiveis[0]; // seleciona o primeiro favorito disponível
                personagensFavoritosDisponiveis.Remove(personagemSelecionado); // remove o personagem selecionado da lista de favoritos
            }
            else
            {
                Random random = new Random();
                personagemSelecionado = personagensDisponiveis[random.Next(personagensDisponiveis.Count)]; // seleciona aleatoriamente  
            }

            // tenta posicionar no setor preferencialmente do 4 ao 1  
            List<int> setoresPreferenciais = new List<int> { 4, 3, 2, 1 };
            int setorSelecionado = -1;

            foreach (int setor in setoresPreferenciais)
            {
                if (!_tabuleiroService.IsSetorCheio(setor, int.Parse(txtIdPartida.Text)))
                {
                    setorSelecionado = setor;
                    break;
                }
            }

            if (setorSelecionado == -1)
            {
                MessageBox.Show("Não há setores disponíveis para posicionar o personagem.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string retornoDLL = _cartaService.ColocarPersonagem(idJogador, senhaJogador, setorSelecionado, personagemSelecionado.ToString());

            if (retornoDLL.StartsWith("ERRO"))
            {
                MessageBox.Show(retornoDLL, "Erro ao adicionar personagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _tabuleiroService.AtualizarTabuleiro(pnlTabuleiro, retornoDLL);

            txtPersonagem.Clear();
            txtPersonagem.Focus();
        }

        private void VerificarTabuleiro()
        {
            string retornoDLL = KingMeServer.Jogo.VerificarVez(int.Parse(txtIdPartida.Text));
            string[] retorno = retornoDLL.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            _tabuleiroService.AtualizarTabuleiro(pnlTabuleiro, string.Join("\r\n", retorno.Skip(1))); //ignora o primeiro elemento
        }

        private void tmrVerificarVez_Tick(object sender, EventArgs e)
        {
            tmrVerificarVez.Enabled = false;


            //verificação se a rodada foi alterada
            string retornoDLL = KingMeServer.Jogo.VerificarVez(int.Parse(txtIdPartida.Text));
            string[] partes = retornoDLL.Split(',');
            statusPartida = partes[1].Trim();
            lblStatusPartida.Text = "Status partida: " + statusPartida;

            if (statusPartida == "E")
            {
                MessageBox.Show("Partida Encerrada.");
                tmrVerificarVez.Stop();
                return;
            }

            int rodada = int.Parse(partes[2].Trim());
            string[] linhasTabuleiro = retornoDLL.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            retornoDLL = string.Join("\r\n", linhasTabuleiro.Skip(1));

            if (rodada != rodadaAtual)
            {
                lblRodadaAtual.Text = "Rodada atual: " + rodada;
                rodadaAtual = rodada;

                _votoService.ResetarVotosJogadores(int.Parse(txtIdPartida.Text));
            }

            bool minhaVez = VerificarVez();
            VerificarTabuleiro();

            string retornoVerificarVez = KingMeServer.Jogo.VerificarVez(int.Parse(txtIdPartida.Text));
            string faseDoJogo = retornoVerificarVez.Split(',')[3];
            faseDoJogo = faseDoJogo.Substring(0, 1);

            if (minhaVez)
            {
                if (faseDoJogo == "S")
                {
                    PosicionarPersonagem();
                }
                else if (faseDoJogo == "P")
                {
                    PromoverAutomaticamente();
                }
            }

            tmrVerificarVez.Enabled = true;
        }

        private void PromoverAutomaticamente()
        {
            try
            {
                int idJogador = int.Parse(txtIdJogador.Text);
                string senhaJogador = txtSenhaJogador.Text;

                string tabuleiro = KingMeServer.Jogo.VerificarVez(int.Parse(txtIdPartida.Text));
                string[] linhasTabuleiro = tabuleiro.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                tabuleiro = string.Join("\r\n", linhasTabuleiro.Skip(1));

                if (string.IsNullOrEmpty(tabuleiro))
                    return;

                string[] linhas = tabuleiro.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                List<string> personagensPromoviveis = new List<string>();

                foreach (string linha in linhas)
                {
                    string[] partes = linha.Split(',');
                    if (partes.Length >= 2 && int.TryParse(partes[0], out int setor))
                    {
                        if (setor >= 0 && setor <= 5 && !_tabuleiroService.IsSetorCheio(setor + 1, int.Parse(txtIdPartida.Text)))
                        {
                            personagensPromoviveis.Add(partes[1]);
                        }
                    }
                }

                if (personagensPromoviveis.Count > 0)
                {
                    string personagemParaPromover = personagensPromoviveis[0];

                    string retorno = _cartaService.Promover(idJogador, senhaJogador, personagemParaPromover);

                    if (!retorno.StartsWith("ERRO"))
                    {
                        _tabuleiroService.AtualizarTabuleiro(pnlTabuleiro, retorno);
                    }
                    else
                    {
                        throw new InvalidOperationException("Não foi possível promover o personagem automaticamente.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na promoção automática: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

            txtPersonagem.Clear();
            txtPersonagem.Focus();
        }

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
            if (txtVoto.Text == "N")
            {
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
    }
}
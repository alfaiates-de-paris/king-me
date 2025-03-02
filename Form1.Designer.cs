namespace king_me
{
    partial class KingMe
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.infoGame = new System.Windows.Forms.Label();
            this.nomePartida = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.senhaPartida = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nomeGrupo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.idPartidaBox = new System.Windows.Forms.TextBox();
            this.listarPartidas = new System.Windows.Forms.Button();
            this.filtroStatus = new System.Windows.Forms.ComboBox();
            this.partidasBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nomeJogador = new System.Windows.Forms.TextBox();
            this.entrarPartida = new System.Windows.Forms.Button();
            this.JogadoresBox = new System.Windows.Forms.RichTextBox();
            this.listarJogadores = new System.Windows.Forms.Button();
            this.idJogadorLabel = new System.Windows.Forms.Label();
            this.senhaJogadorLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.idJogadorBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.senhaJogadorBox = new System.Windows.Forms.TextBox();
            this.criarPartida = new System.Windows.Forms.Button();
            this.idPartidaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // infoGame
            // 
            this.infoGame.AutoSize = true;
            this.infoGame.Location = new System.Drawing.Point(727, 547);
            this.infoGame.Name = "infoGame";
            this.infoGame.Size = new System.Drawing.Size(112, 13);
            this.infoGame.TabIndex = 0;
            this.infoGame.Text = "Alfaiates de Paris - 1.0";
            // 
            // nomePartida
            // 
            this.nomePartida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomePartida.Location = new System.Drawing.Point(12, 25);
            this.nomePartida.Name = "nomePartida";
            this.nomePartida.Size = new System.Drawing.Size(100, 20);
            this.nomePartida.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome da Partida";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Senha";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // senhaPartida
            // 
            this.senhaPartida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.senhaPartida.Location = new System.Drawing.Point(12, 68);
            this.senhaPartida.Name = "senhaPartida";
            this.senhaPartida.Size = new System.Drawing.Size(100, 20);
            this.senhaPartida.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nome do grupo";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nomeGrupo
            // 
            this.nomeGrupo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomeGrupo.Location = new System.Drawing.Point(12, 112);
            this.nomeGrupo.Name = "nomeGrupo";
            this.nomeGrupo.ReadOnly = true;
            this.nomeGrupo.Size = new System.Drawing.Size(100, 20);
            this.nomeGrupo.TabIndex = 6;
            this.nomeGrupo.Text = "Alfaiates de Paris";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "id da partida";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // idPartidaBox
            // 
            this.idPartidaBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idPartidaBox.Location = new System.Drawing.Point(12, 160);
            this.idPartidaBox.Name = "idPartidaBox";
            this.idPartidaBox.Size = new System.Drawing.Size(100, 20);
            this.idPartidaBox.TabIndex = 8;
            // 
            // listarPartidas
            // 
            this.listarPartidas.Location = new System.Drawing.Point(139, 214);
            this.listarPartidas.Name = "listarPartidas";
            this.listarPartidas.Size = new System.Drawing.Size(100, 23);
            this.listarPartidas.TabIndex = 11;
            this.listarPartidas.Text = "Listar Partidas";
            this.listarPartidas.UseVisualStyleBackColor = true;
            this.listarPartidas.Click += new System.EventHandler(this.listarPartidas_Click);
            // 
            // filtroStatus
            // 
            this.filtroStatus.AutoCompleteCustomSource.AddRange(new string[] {
            "Todas",
            "Aberta",
            "Jogando",
            "Encerrada"});
            this.filtroStatus.FormattingEnabled = true;
            this.filtroStatus.Items.AddRange(new object[] {
            "Todas",
            "Aberta",
            "Jogando",
            "Encerrada"});
            this.filtroStatus.Location = new System.Drawing.Point(12, 214);
            this.filtroStatus.Name = "filtroStatus";
            this.filtroStatus.Size = new System.Drawing.Size(121, 21);
            this.filtroStatus.TabIndex = 12;
            this.filtroStatus.Tag = "";
            // 
            // partidasBox
            // 
            this.partidasBox.Location = new System.Drawing.Point(12, 243);
            this.partidasBox.Name = "partidasBox";
            this.partidasBox.Size = new System.Drawing.Size(227, 96);
            this.partidasBox.TabIndex = 13;
            this.partidasBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nome do Jogador";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nomeJogador
            // 
            this.nomeJogador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomeJogador.Location = new System.Drawing.Point(15, 367);
            this.nomeJogador.Name = "nomeJogador";
            this.nomeJogador.Size = new System.Drawing.Size(100, 20);
            this.nomeJogador.TabIndex = 16;
            // 
            // entrarPartida
            // 
            this.entrarPartida.Location = new System.Drawing.Point(139, 364);
            this.entrarPartida.Name = "entrarPartida";
            this.entrarPartida.Size = new System.Drawing.Size(100, 23);
            this.entrarPartida.TabIndex = 17;
            this.entrarPartida.Text = "Entrar na Partida";
            this.entrarPartida.UseVisualStyleBackColor = true;
            this.entrarPartida.Click += new System.EventHandler(this.entrarPartida_Click);
            // 
            // JogadoresBox
            // 
            this.JogadoresBox.Location = new System.Drawing.Point(15, 435);
            this.JogadoresBox.Name = "JogadoresBox";
            this.JogadoresBox.Size = new System.Drawing.Size(227, 96);
            this.JogadoresBox.TabIndex = 18;
            this.JogadoresBox.Text = "";
            // 
            // listarJogadores
            // 
            this.listarJogadores.Location = new System.Drawing.Point(78, 537);
            this.listarJogadores.Name = "listarJogadores";
            this.listarJogadores.Size = new System.Drawing.Size(100, 23);
            this.listarJogadores.TabIndex = 19;
            this.listarJogadores.Text = "Listar Jogadores";
            this.listarJogadores.UseVisualStyleBackColor = true;
            this.listarJogadores.Click += new System.EventHandler(this.listarJogadores_Click);
            // 
            // idJogadorLabel
            // 
            this.idJogadorLabel.AutoSize = true;
            this.idJogadorLabel.Location = new System.Drawing.Point(35, 390);
            this.idJogadorLabel.Name = "idJogadorLabel";
            this.idJogadorLabel.Size = new System.Drawing.Size(57, 13);
            this.idJogadorLabel.TabIndex = 20;
            this.idJogadorLabel.Text = "Id Jogador";
            this.idJogadorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // senhaJogadorLabel
            // 
            this.senhaJogadorLabel.AutoSize = true;
            this.senhaJogadorLabel.Location = new System.Drawing.Point(24, 403);
            this.senhaJogadorLabel.Name = "senhaJogadorLabel";
            this.senhaJogadorLabel.Size = new System.Drawing.Size(79, 13);
            this.senhaJogadorLabel.TabIndex = 21;
            this.senhaJogadorLabel.Text = "Senha Jogador";
            this.senhaJogadorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Id Jogador";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // idJogadorBox
            // 
            this.idJogadorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idJogadorBox.Location = new System.Drawing.Point(304, 25);
            this.idJogadorBox.Name = "idJogadorBox";
            this.idJogadorBox.Size = new System.Drawing.Size(100, 20);
            this.idJogadorBox.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(301, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Senha Jogador";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // senhaJogadorBox
            // 
            this.senhaJogadorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.senhaJogadorBox.Location = new System.Drawing.Point(304, 68);
            this.senhaJogadorBox.Name = "senhaJogadorBox";
            this.senhaJogadorBox.Size = new System.Drawing.Size(100, 20);
            this.senhaJogadorBox.TabIndex = 24;
            // 
            // criarPartida
            // 
            this.criarPartida.Location = new System.Drawing.Point(139, 25);
            this.criarPartida.Name = "criarPartida";
            this.criarPartida.Size = new System.Drawing.Size(100, 23);
            this.criarPartida.TabIndex = 26;
            this.criarPartida.Text = "Criar Partida";
            this.criarPartida.UseVisualStyleBackColor = true;
            this.criarPartida.Click += new System.EventHandler(this.criarPartida_Click);
            // 
            // idPartidaLabel
            // 
            this.idPartidaLabel.AutoSize = true;
            this.idPartidaLabel.Location = new System.Drawing.Point(180, 51);
            this.idPartidaLabel.Name = "idPartidaLabel";
            this.idPartidaLabel.Size = new System.Drawing.Size(15, 13);
            this.idPartidaLabel.TabIndex = 27;
            this.idPartidaLabel.Text = "id";
            this.idPartidaLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // KingMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 569);
            this.Controls.Add(this.idPartidaLabel);
            this.Controls.Add(this.criarPartida);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.senhaJogadorBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.idJogadorBox);
            this.Controls.Add(this.senhaJogadorLabel);
            this.Controls.Add(this.idJogadorLabel);
            this.Controls.Add(this.listarJogadores);
            this.Controls.Add(this.JogadoresBox);
            this.Controls.Add(this.entrarPartida);
            this.Controls.Add(this.nomeJogador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.partidasBox);
            this.Controls.Add(this.filtroStatus);
            this.Controls.Add(this.listarPartidas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idPartidaBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nomeGrupo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.senhaPartida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nomePartida);
            this.Controls.Add(this.infoGame);
            this.Name = "KingMe";
            this.Text = "Alfaiates de Paris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoGame;
        private System.Windows.Forms.TextBox nomePartida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox senhaPartida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nomeGrupo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idPartidaBox;
        private System.Windows.Forms.Button listarPartidas;
        private System.Windows.Forms.ComboBox filtroStatus;
        private System.Windows.Forms.RichTextBox partidasBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomeJogador;
        private System.Windows.Forms.Button entrarPartida;
        private System.Windows.Forms.RichTextBox JogadoresBox;
        private System.Windows.Forms.Button listarJogadores;
        private System.Windows.Forms.Label idJogadorLabel;
        private System.Windows.Forms.Label senhaJogadorLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox idJogadorBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox senhaJogadorBox;
        private System.Windows.Forms.Button criarPartida;
        private System.Windows.Forms.Label idPartidaLabel;
    }
}


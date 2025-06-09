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
            this.components = new System.ComponentModel.Container();
            this.txtSenhaPartida = new System.Windows.Forms.TextBox();
            this.txtIdPartida = new System.Windows.Forms.TextBox();
            this.txtIdJogador = new System.Windows.Forms.TextBox();
            this.txtSenhaJogador = new System.Windows.Forms.TextBox();
            this.lblPersonagensFav = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.lblPersonagensExistentes = new System.Windows.Forms.Label();
            this.txtPersonagensExistentes = new System.Windows.Forms.ListBox();
            this.txtSetoresExistentes = new System.Windows.Forms.ListBox();
            this.lblSetoresExistentes = new System.Windows.Forms.Label();
            this.lblVezNomeJogador = new System.Windows.Forms.Label();
            this.lblVezIdJogador = new System.Windows.Forms.Label();
            this.txtPersonagensFavoritos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVotar = new System.Windows.Forms.Button();
            this.txtVoto = new System.Windows.Forms.TextBox();
            this.pnlTabuleiro = new System.Windows.Forms.Panel();
            this.lblVotosRestantes = new System.Windows.Forms.Label();
            this.tmrVerificarVez = new System.Windows.Forms.Timer(this.components);
            this.lblRodadaAtual = new System.Windows.Forms.Label();
            this.lblStatusPartida = new System.Windows.Forms.Label();
            this.btnPartidaVoltar = new System.Windows.Forms.Button();
            this.lblPlacar = new System.Windows.Forms.Label();
            this.txtPlacar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSenhaPartida
            // 
            this.txtSenhaPartida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenhaPartida.Location = new System.Drawing.Point(353, 627);
            this.txtSenhaPartida.Name = "txtSenhaPartida";
            this.txtSenhaPartida.Size = new System.Drawing.Size(16, 20);
            this.txtSenhaPartida.TabIndex = 4;
            // 
            // txtIdPartida
            // 
            this.txtIdPartida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdPartida.Location = new System.Drawing.Point(332, 619);
            this.txtIdPartida.Name = "txtIdPartida";
            this.txtIdPartida.Size = new System.Drawing.Size(12, 20);
            this.txtIdPartida.TabIndex = 8;
            // 
            // txtIdJogador
            // 
            this.txtIdJogador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdJogador.Location = new System.Drawing.Point(332, 644);
            this.txtIdJogador.Name = "txtIdJogador";
            this.txtIdJogador.Size = new System.Drawing.Size(16, 20);
            this.txtIdJogador.TabIndex = 22;
            // 
            // txtSenhaJogador
            // 
            this.txtSenhaJogador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenhaJogador.Location = new System.Drawing.Point(353, 652);
            this.txtSenhaJogador.Name = "txtSenhaJogador";
            this.txtSenhaJogador.Size = new System.Drawing.Size(12, 20);
            this.txtSenhaJogador.TabIndex = 24;
            // 
            // lblPersonagensFav
            // 
            this.lblPersonagensFav.AutoSize = true;
            this.lblPersonagensFav.BackColor = System.Drawing.Color.Transparent;
            this.lblPersonagensFav.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblPersonagensFav.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPersonagensFav.Location = new System.Drawing.Point(326, 279);
            this.lblPersonagensFav.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPersonagensFav.Name = "lblPersonagensFav";
            this.lblPersonagensFav.Size = new System.Drawing.Size(141, 20);
            this.lblPersonagensFav.TabIndex = 30;
            this.lblPersonagensFav.Text = "Cartas Favoritas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 31;
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.BackColor = System.Drawing.Color.LimeGreen;
            this.btnIniciarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarPartida.Location = new System.Drawing.Point(73, 284);
            this.btnIniciarPartida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(125, 65);
            this.btnIniciarPartida.TabIndex = 32;
            this.btnIniciarPartida.Text = "Iniciar Partida 👑";
            this.btnIniciarPartida.UseVisualStyleBackColor = false;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            // 
            // lblPersonagensExistentes
            // 
            this.lblPersonagensExistentes.AutoSize = true;
            this.lblPersonagensExistentes.BackColor = System.Drawing.Color.Transparent;
            this.lblPersonagensExistentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblPersonagensExistentes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPersonagensExistentes.Location = new System.Drawing.Point(69, 573);
            this.lblPersonagensExistentes.Name = "lblPersonagensExistentes";
            this.lblPersonagensExistentes.Size = new System.Drawing.Size(203, 20);
            this.lblPersonagensExistentes.TabIndex = 34;
            this.lblPersonagensExistentes.Text = "Personagens Existentes";
            // 
            // txtPersonagensExistentes
            // 
            this.txtPersonagensExistentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPersonagensExistentes.FormattingEnabled = true;
            this.txtPersonagensExistentes.ItemHeight = 20;
            this.txtPersonagensExistentes.Location = new System.Drawing.Point(73, 596);
            this.txtPersonagensExistentes.Name = "txtPersonagensExistentes";
            this.txtPersonagensExistentes.Size = new System.Drawing.Size(181, 164);
            this.txtPersonagensExistentes.TabIndex = 35;
            this.txtPersonagensExistentes.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtSetoresExistentes
            // 
            this.txtSetoresExistentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSetoresExistentes.FormattingEnabled = true;
            this.txtSetoresExistentes.ItemHeight = 20;
            this.txtSetoresExistentes.Location = new System.Drawing.Point(531, 302);
            this.txtSetoresExistentes.Name = "txtSetoresExistentes";
            this.txtSetoresExistentes.Size = new System.Drawing.Size(113, 164);
            this.txtSetoresExistentes.TabIndex = 38;
            // 
            // lblSetoresExistentes
            // 
            this.lblSetoresExistentes.AutoSize = true;
            this.lblSetoresExistentes.BackColor = System.Drawing.Color.Transparent;
            this.lblSetoresExistentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblSetoresExistentes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSetoresExistentes.Location = new System.Drawing.Point(527, 279);
            this.lblSetoresExistentes.Name = "lblSetoresExistentes";
            this.lblSetoresExistentes.Size = new System.Drawing.Size(72, 20);
            this.lblSetoresExistentes.TabIndex = 37;
            this.lblSetoresExistentes.Text = "Setores";
            // 
            // lblVezNomeJogador
            // 
            this.lblVezNomeJogador.AutoSize = true;
            this.lblVezNomeJogador.BackColor = System.Drawing.Color.Transparent;
            this.lblVezNomeJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblVezNomeJogador.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblVezNomeJogador.Location = new System.Drawing.Point(70, 483);
            this.lblVezNomeJogador.Name = "lblVezNomeJogador";
            this.lblVezNomeJogador.Size = new System.Drawing.Size(125, 20);
            this.lblVezNomeJogador.TabIndex = 43;
            this.lblVezNomeJogador.Text = "Nome Jogador";
            // 
            // lblVezIdJogador
            // 
            this.lblVezIdJogador.AutoSize = true;
            this.lblVezIdJogador.BackColor = System.Drawing.Color.Transparent;
            this.lblVezIdJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblVezIdJogador.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblVezIdJogador.Location = new System.Drawing.Point(70, 461);
            this.lblVezIdJogador.Name = "lblVezIdJogador";
            this.lblVezIdJogador.Size = new System.Drawing.Size(95, 20);
            this.lblVezIdJogador.TabIndex = 44;
            this.lblVezIdJogador.Text = "Id Jogador";
            // 
            // txtPersonagensFavoritos
            // 
            this.txtPersonagensFavoritos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonagensFavoritos.Location = new System.Drawing.Point(328, 304);
            this.txtPersonagensFavoritos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPersonagensFavoritos.Multiline = true;
            this.txtPersonagensFavoritos.Name = "txtPersonagensFavoritos";
            this.txtPersonagensFavoritos.Size = new System.Drawing.Size(134, 196);
            this.txtPersonagensFavoritos.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 229);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 49;
            // 
            // btnVotar
            // 
            this.btnVotar.Location = new System.Drawing.Point(339, 545);
            this.btnVotar.Name = "btnVotar";
            this.btnVotar.Size = new System.Drawing.Size(86, 23);
            this.btnVotar.TabIndex = 51;
            this.btnVotar.Text = "Votar";
            this.btnVotar.UseVisualStyleBackColor = true;
            this.btnVotar.Click += new System.EventHandler(this.btnVotar_Click);
            // 
            // txtVoto
            // 
            this.txtVoto.Location = new System.Drawing.Point(339, 521);
            this.txtVoto.Name = "txtVoto";
            this.txtVoto.Size = new System.Drawing.Size(87, 20);
            this.txtVoto.TabIndex = 52;
            this.txtVoto.TextChanged += new System.EventHandler(this.txtVoto_TextChanged);
            // 
            // pnlTabuleiro
            // 
            this.pnlTabuleiro.BackgroundImage = global::king_me.Properties.Resources.tabuleiro_completo;
            this.pnlTabuleiro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTabuleiro.Location = new System.Drawing.Point(688, 160);
            this.pnlTabuleiro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlTabuleiro.Name = "pnlTabuleiro";
            this.pnlTabuleiro.Size = new System.Drawing.Size(264, 616);
            this.pnlTabuleiro.TabIndex = 53;
            // 
            // lblVotosRestantes
            // 
            this.lblVotosRestantes.AutoSize = true;
            this.lblVotosRestantes.BackColor = System.Drawing.Color.Transparent;
            this.lblVotosRestantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblVotosRestantes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblVotosRestantes.Location = new System.Drawing.Point(337, 576);
            this.lblVotosRestantes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVotosRestantes.Name = "lblVotosRestantes";
            this.lblVotosRestantes.Size = new System.Drawing.Size(56, 20);
            this.lblVotosRestantes.TabIndex = 54;
            this.lblVotosRestantes.Text = "Votos";
            this.lblVotosRestantes.Click += new System.EventHandler(this.lblVotosRestantes_Click);
            // 
            // tmrVerificarVez
            // 
            this.tmrVerificarVez.Interval = 1500;
            this.tmrVerificarVez.Tick += new System.EventHandler(this.tmrVerificarVez_Tick);
            // 
            // lblRodadaAtual
            // 
            this.lblRodadaAtual.AutoSize = true;
            this.lblRodadaAtual.BackColor = System.Drawing.Color.Transparent;
            this.lblRodadaAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblRodadaAtual.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRodadaAtual.Location = new System.Drawing.Point(69, 409);
            this.lblRodadaAtual.Name = "lblRodadaAtual";
            this.lblRodadaAtual.Size = new System.Drawing.Size(122, 20);
            this.lblRodadaAtual.TabIndex = 55;
            this.lblRodadaAtual.Text = "Rodada atual:";
            // 
            // lblStatusPartida
            // 
            this.lblStatusPartida.AutoSize = true;
            this.lblStatusPartida.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblStatusPartida.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStatusPartida.Location = new System.Drawing.Point(69, 375);
            this.lblStatusPartida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatusPartida.Name = "lblStatusPartida";
            this.lblStatusPartida.Size = new System.Drawing.Size(133, 20);
            this.lblStatusPartida.TabIndex = 56;
            this.lblStatusPartida.Text = "Status partida: ";
            // 
            // btnPartidaVoltar
            // 
            this.btnPartidaVoltar.BackColor = System.Drawing.Color.Red;
            this.btnPartidaVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnPartidaVoltar.Location = new System.Drawing.Point(548, 734);
            this.btnPartidaVoltar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPartidaVoltar.Name = "btnPartidaVoltar";
            this.btnPartidaVoltar.Size = new System.Drawing.Size(80, 42);
            this.btnPartidaVoltar.TabIndex = 57;
            this.btnPartidaVoltar.Text = "Voltar ao Lobby";
            this.btnPartidaVoltar.UseVisualStyleBackColor = false;
            this.btnPartidaVoltar.Click += new System.EventHandler(this.btnPartidaVoltar_Click);
            // 
            // lblPlacar
            // 
            this.lblPlacar.AutoSize = true;
            this.lblPlacar.BackColor = System.Drawing.Color.Transparent;
            this.lblPlacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblPlacar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPlacar.Location = new System.Drawing.Point(527, 560);
            this.lblPlacar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlacar.Name = "lblPlacar";
            this.lblPlacar.Size = new System.Drawing.Size(59, 20);
            this.lblPlacar.TabIndex = 58;
            this.lblPlacar.Text = "Placar";
            // 
            // txtPlacar
            // 
            this.txtPlacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPlacar.Location = new System.Drawing.Point(531, 583);
            this.txtPlacar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPlacar.Multiline = true;
            this.txtPlacar.Name = "txtPlacar";
            this.txtPlacar.Size = new System.Drawing.Size(113, 132);
            this.txtPlacar.TabIndex = 59;
            // 
            // KingMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(233)))));
            this.BackgroundImage = global::king_me.Properties.Resources.bg_partida;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(969, 795);
            this.Controls.Add(this.txtPlacar);
            this.Controls.Add(this.lblPlacar);
            this.Controls.Add(this.btnPartidaVoltar);
            this.Controls.Add(this.lblStatusPartida);
            this.Controls.Add(this.lblRodadaAtual);
            this.Controls.Add(this.pnlTabuleiro);
            this.Controls.Add(this.txtVoto);
            this.Controls.Add(this.btnVotar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPersonagensFavoritos);
            this.Controls.Add(this.lblVezIdJogador);
            this.Controls.Add(this.lblVezNomeJogador);
            this.Controls.Add(this.txtSetoresExistentes);
            this.Controls.Add(this.lblSetoresExistentes);
            this.Controls.Add(this.txtPersonagensExistentes);
            this.Controls.Add(this.lblPersonagensExistentes);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPersonagensFav);
            this.Controls.Add(this.txtSenhaJogador);
            this.Controls.Add(this.txtIdJogador);
            this.Controls.Add(this.txtIdPartida);
            this.Controls.Add(this.txtSenhaPartida);
            this.Controls.Add(this.lblVotosRestantes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "KingMe";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "King Me! | Alfaiates de Paris";
            this.Load += new System.EventHandler(this.KingMe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSenhaPartida;
        private System.Windows.Forms.TextBox txtIdPartida;
        private System.Windows.Forms.TextBox txtIdJogador;
        private System.Windows.Forms.TextBox txtSenhaJogador;
        private System.Windows.Forms.Label lblPersonagensFav;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIniciarPartida;
        private System.Windows.Forms.Label lblPersonagensExistentes;
        private System.Windows.Forms.ListBox txtPersonagensExistentes;
        private System.Windows.Forms.ListBox txtSetoresExistentes;
        private System.Windows.Forms.Label lblSetoresExistentes;
        private System.Windows.Forms.Label lblVezNomeJogador;
        private System.Windows.Forms.Label lblVezIdJogador;
        private System.Windows.Forms.TextBox txtPersonagensFavoritos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVotar;
        private System.Windows.Forms.TextBox txtVoto;
        private System.Windows.Forms.Panel pnlTabuleiro;
        private System.Windows.Forms.Label lblVotosRestantes;
        private System.Windows.Forms.Timer tmrVerificarVez;
        private System.Windows.Forms.Label lblRodadaAtual;
        private System.Windows.Forms.Label lblStatusPartida;
        private System.Windows.Forms.Button btnPartidaVoltar;
        private System.Windows.Forms.Label lblPlacar;
        private System.Windows.Forms.TextBox txtPlacar;
    }
}
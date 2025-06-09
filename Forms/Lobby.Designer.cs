namespace king_me.Forms
{
    partial class Lobby
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.lblNomePartida = new System.Windows.Forms.Label();
            this.txtNomePartida = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenhaPartida = new System.Windows.Forms.TextBox();
            this.btnVoltarLobby = new System.Windows.Forms.Button();
            this.lblInputIdPartida = new System.Windows.Forms.Label();
            this.txtIdPartida = new System.Windows.Forms.TextBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.btnListarPartidas = new System.Windows.Forms.Button();
            this.txtPartidas = new System.Windows.Forms.RichTextBox();
            this.lblNomeJogador = new System.Windows.Forms.Label();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.btnEntrarLobby = new System.Windows.Forms.Button();
            this.lblIdJogador = new System.Windows.Forms.Label();
            this.lblSenhaJogador = new System.Windows.Forms.Label();
            this.txtJogadores = new System.Windows.Forms.RichTextBox();
            this.btnListarJogadores = new System.Windows.Forms.Button();
            this.txtIdJogador = new System.Windows.Forms.TextBox();
            this.txtSenhaJogador = new System.Windows.Forms.TextBox();
            this.lblNomeGrupo = new System.Windows.Forms.Label();
            this.txtNomeGrupo = new System.Windows.Forms.TextBox();
            this.btnEntrarPartida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.Location = new System.Drawing.Point(171, 272);
            this.btnCriarPartida.Margin = new System.Windows.Forms.Padding(4);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(110, 31);
            this.btnCriarPartida.TabIndex = 27;
            this.btnCriarPartida.Text = "Criar Partida";
            this.btnCriarPartida.UseVisualStyleBackColor = true;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // lblNomePartida
            // 
            this.lblNomePartida.AutoSize = true;
            this.lblNomePartida.BackColor = System.Drawing.Color.Transparent;
            this.lblNomePartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePartida.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNomePartida.Location = new System.Drawing.Point(24, 198);
            this.lblNomePartida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomePartida.Name = "lblNomePartida";
            this.lblNomePartida.Size = new System.Drawing.Size(124, 16);
            this.lblNomePartida.TabIndex = 28;
            this.lblNomePartida.Text = "Nome da Partida";
            this.lblNomePartida.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNomePartida
            // 
            this.txtNomePartida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomePartida.Location = new System.Drawing.Point(27, 221);
            this.txtNomePartida.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomePartida.Name = "txtNomePartida";
            this.txtNomePartida.Size = new System.Drawing.Size(121, 22);
            this.txtNomePartida.TabIndex = 29;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblSenha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSenha.Location = new System.Drawing.Point(168, 201);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(51, 16);
            this.lblSenha.TabIndex = 30;
            this.lblSenha.Text = "Senha";
            this.lblSenha.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSenhaPartida
            // 
            this.txtSenhaPartida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenhaPartida.Location = new System.Drawing.Point(171, 221);
            this.txtSenhaPartida.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenhaPartida.Name = "txtSenhaPartida";
            this.txtSenhaPartida.Size = new System.Drawing.Size(110, 22);
            this.txtSenhaPartida.TabIndex = 31;
            // 
            // btnVoltarLobby
            // 
            this.btnVoltarLobby.BackColor = System.Drawing.Color.Red;
            this.btnVoltarLobby.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnVoltarLobby.Location = new System.Drawing.Point(939, 600);
            this.btnVoltarLobby.Name = "btnVoltarLobby";
            this.btnVoltarLobby.Size = new System.Drawing.Size(79, 41);
            this.btnVoltarLobby.TabIndex = 32;
            this.btnVoltarLobby.Text = "Voltar";
            this.btnVoltarLobby.UseVisualStyleBackColor = false;
            this.btnVoltarLobby.Click += new System.EventHandler(this.btnVoltarLobby_Click);
            // 
            // lblInputIdPartida
            // 
            this.lblInputIdPartida.AutoSize = true;
            this.lblInputIdPartida.BackColor = System.Drawing.Color.Transparent;
            this.lblInputIdPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblInputIdPartida.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblInputIdPartida.Location = new System.Drawing.Point(24, 261);
            this.lblInputIdPartida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInputIdPartida.Name = "lblInputIdPartida";
            this.lblInputIdPartida.Size = new System.Drawing.Size(97, 16);
            this.lblInputIdPartida.TabIndex = 33;
            this.lblInputIdPartida.Text = "ID da partida";
            this.lblInputIdPartida.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtIdPartida
            // 
            this.txtIdPartida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdPartida.Location = new System.Drawing.Point(27, 281);
            this.txtIdPartida.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdPartida.Name = "txtIdPartida";
            this.txtIdPartida.Size = new System.Drawing.Size(121, 22);
            this.txtIdPartida.TabIndex = 34;
            // 
            // cboStatus
            // 
            this.cboStatus.AutoCompleteCustomSource.AddRange(new string[] {
            "Todas",
            "Aberta",
            "Jogando",
            "Encerrada"});
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Todas",
            "Aberta",
            "Jogando",
            "Encerrada"});
            this.cboStatus.Location = new System.Drawing.Point(27, 398);
            this.cboStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(160, 24);
            this.cboStatus.TabIndex = 36;
            this.cboStatus.Tag = "";
            // 
            // btnListarPartidas
            // 
            this.btnListarPartidas.Location = new System.Drawing.Point(195, 398);
            this.btnListarPartidas.Margin = new System.Windows.Forms.Padding(4);
            this.btnListarPartidas.Name = "btnListarPartidas";
            this.btnListarPartidas.Size = new System.Drawing.Size(110, 28);
            this.btnListarPartidas.TabIndex = 37;
            this.btnListarPartidas.Text = "Listar Partidas";
            this.btnListarPartidas.UseVisualStyleBackColor = true;
            this.btnListarPartidas.Click += new System.EventHandler(this.btnListarPartidas_Click);
            // 
            // txtPartidas
            // 
            this.txtPartidas.Location = new System.Drawing.Point(27, 434);
            this.txtPartidas.Margin = new System.Windows.Forms.Padding(4);
            this.txtPartidas.Name = "txtPartidas";
            this.txtPartidas.Size = new System.Drawing.Size(278, 117);
            this.txtPartidas.TabIndex = 38;
            this.txtPartidas.Text = "";
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.AutoSize = true;
            this.lblNomeJogador.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblNomeJogador.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNomeJogador.Location = new System.Drawing.Point(363, 223);
            this.lblNomeJogador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(132, 16);
            this.lblNomeJogador.TabIndex = 39;
            this.lblNomeJogador.Text = "Nome do Jogador";
            this.lblNomeJogador.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeJogador.Location = new System.Drawing.Point(366, 245);
            this.txtNomeJogador.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(133, 22);
            this.txtNomeJogador.TabIndex = 40;
            // 
            // btnEntrarLobby
            // 
            this.btnEntrarLobby.Location = new System.Drawing.Point(518, 225);
            this.btnEntrarLobby.Margin = new System.Windows.Forms.Padding(4);
            this.btnEntrarLobby.Name = "btnEntrarLobby";
            this.btnEntrarLobby.Size = new System.Drawing.Size(99, 42);
            this.btnEntrarLobby.TabIndex = 41;
            this.btnEntrarLobby.Text = "Entrar no Lobby";
            this.btnEntrarLobby.UseVisualStyleBackColor = true;
            this.btnEntrarLobby.Click += new System.EventHandler(this.btnEntrarLobby_Click);
            // 
            // lblIdJogador
            // 
            this.lblIdJogador.AutoSize = true;
            this.lblIdJogador.BackColor = System.Drawing.Color.Transparent;
            this.lblIdJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblIdJogador.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIdJogador.Location = new System.Drawing.Point(363, 297);
            this.lblIdJogador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdJogador.Name = "lblIdJogador";
            this.lblIdJogador.Size = new System.Drawing.Size(82, 16);
            this.lblIdJogador.TabIndex = 42;
            this.lblIdJogador.Text = "Id Jogador";
            this.lblIdJogador.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSenhaJogador
            // 
            this.lblSenhaJogador.AutoSize = true;
            this.lblSenhaJogador.BackColor = System.Drawing.Color.Transparent;
            this.lblSenhaJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblSenhaJogador.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSenhaJogador.Location = new System.Drawing.Point(363, 368);
            this.lblSenhaJogador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenhaJogador.Name = "lblSenhaJogador";
            this.lblSenhaJogador.Size = new System.Drawing.Size(113, 16);
            this.lblSenhaJogador.TabIndex = 43;
            this.lblSenhaJogador.Text = "Senha Jogador";
            this.lblSenhaJogador.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtJogadores
            // 
            this.txtJogadores.Location = new System.Drawing.Point(366, 431);
            this.txtJogadores.Margin = new System.Windows.Forms.Padding(4);
            this.txtJogadores.Name = "txtJogadores";
            this.txtJogadores.Size = new System.Drawing.Size(251, 117);
            this.txtJogadores.TabIndex = 44;
            this.txtJogadores.Text = "";
            // 
            // btnListarJogadores
            // 
            this.btnListarJogadores.Location = new System.Drawing.Point(366, 556);
            this.btnListarJogadores.Margin = new System.Windows.Forms.Padding(4);
            this.btnListarJogadores.Name = "btnListarJogadores";
            this.btnListarJogadores.Size = new System.Drawing.Size(133, 28);
            this.btnListarJogadores.TabIndex = 45;
            this.btnListarJogadores.Text = "Listar Jogadores";
            this.btnListarJogadores.UseVisualStyleBackColor = true;
            this.btnListarJogadores.Click += new System.EventHandler(this.btnListarJogadores_Click);
            // 
            // txtIdJogador
            // 
            this.txtIdJogador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdJogador.Location = new System.Drawing.Point(366, 328);
            this.txtIdJogador.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdJogador.Name = "txtIdJogador";
            this.txtIdJogador.Size = new System.Drawing.Size(133, 22);
            this.txtIdJogador.TabIndex = 46;
            // 
            // txtSenhaJogador
            // 
            this.txtSenhaJogador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenhaJogador.Location = new System.Drawing.Point(366, 388);
            this.txtSenhaJogador.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenhaJogador.Name = "txtSenhaJogador";
            this.txtSenhaJogador.Size = new System.Drawing.Size(133, 22);
            this.txtSenhaJogador.TabIndex = 47;
            // 
            // lblNomeGrupo
            // 
            this.lblNomeGrupo.AutoSize = true;
            this.lblNomeGrupo.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblNomeGrupo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNomeGrupo.Location = new System.Drawing.Point(24, 328);
            this.lblNomeGrupo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeGrupo.Name = "lblNomeGrupo";
            this.lblNomeGrupo.Size = new System.Drawing.Size(114, 16);
            this.lblNomeGrupo.TabIndex = 48;
            this.lblNomeGrupo.Text = "Nome do grupo";
            this.lblNomeGrupo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNomeGrupo
            // 
            this.txtNomeGrupo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeGrupo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNomeGrupo.Location = new System.Drawing.Point(27, 348);
            this.txtNomeGrupo.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeGrupo.Name = "txtNomeGrupo";
            this.txtNomeGrupo.ReadOnly = true;
            this.txtNomeGrupo.Size = new System.Drawing.Size(133, 22);
            this.txtNomeGrupo.TabIndex = 49;
            this.txtNomeGrupo.Text = "Alfaiates de Paris";
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.Location = new System.Drawing.Point(715, 456);
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.Size = new System.Drawing.Size(115, 59);
            this.btnEntrarPartida.TabIndex = 50;
            this.btnEntrarPartida.Text = "Entrar na partida!!";
            this.btnEntrarPartida.UseVisualStyleBackColor = true;
            this.btnEntrarPartida.Click += new System.EventHandler(this.btnEntrarPartida_Click);
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::king_me.Properties.Resources.lobby_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1030, 653);
            this.Controls.Add(this.btnEntrarPartida);
            this.Controls.Add(this.txtNomeGrupo);
            this.Controls.Add(this.lblNomeGrupo);
            this.Controls.Add(this.txtSenhaJogador);
            this.Controls.Add(this.txtIdJogador);
            this.Controls.Add(this.btnListarJogadores);
            this.Controls.Add(this.txtJogadores);
            this.Controls.Add(this.lblSenhaJogador);
            this.Controls.Add(this.lblIdJogador);
            this.Controls.Add(this.btnEntrarLobby);
            this.Controls.Add(this.txtNomeJogador);
            this.Controls.Add(this.lblNomeJogador);
            this.Controls.Add(this.txtPartidas);
            this.Controls.Add(this.btnListarPartidas);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.txtIdPartida);
            this.Controls.Add(this.lblInputIdPartida);
            this.Controls.Add(this.btnVoltarLobby);
            this.Controls.Add(this.txtSenhaPartida);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtNomePartida);
            this.Controls.Add(this.lblNomePartida);
            this.Controls.Add(this.btnCriarPartida);
            this.MaximizeBox = false;
            this.Name = "Lobby";
            this.Text = "King Me | Lobby | Alfaiates de Paris";
            this.Load += new System.EventHandler(this.Lobby_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.Label lblNomePartida;
        private System.Windows.Forms.TextBox txtNomePartida;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenhaPartida;
        private System.Windows.Forms.Button btnVoltarLobby;
        private System.Windows.Forms.Label lblInputIdPartida;
        private System.Windows.Forms.TextBox txtIdPartida;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Button btnListarPartidas;
        private System.Windows.Forms.RichTextBox txtPartidas;
        private System.Windows.Forms.Label lblNomeJogador;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.Button btnEntrarLobby;
        private System.Windows.Forms.Label lblIdJogador;
        private System.Windows.Forms.Label lblSenhaJogador;
        private System.Windows.Forms.RichTextBox txtJogadores;
        private System.Windows.Forms.Button btnListarJogadores;
        private System.Windows.Forms.TextBox txtIdJogador;
        private System.Windows.Forms.TextBox txtSenhaJogador;
        private System.Windows.Forms.Label lblNomeGrupo;
        private System.Windows.Forms.TextBox txtNomeGrupo;
        private System.Windows.Forms.Button btnEntrarPartida;
    }
}
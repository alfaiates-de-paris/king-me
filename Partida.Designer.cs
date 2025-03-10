namespace king_me
{
    partial class Partida
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
            this.bntVoltarAoMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntVoltarAoMenu
            // 
            this.bntVoltarAoMenu.Location = new System.Drawing.Point(670, 404);
            this.bntVoltarAoMenu.Name = "bntVoltarAoMenu";
            this.bntVoltarAoMenu.Size = new System.Drawing.Size(118, 34);
            this.bntVoltarAoMenu.TabIndex = 0;
            this.bntVoltarAoMenu.Text = "Voltar ao menu";
            this.bntVoltarAoMenu.UseVisualStyleBackColor = true;
            this.bntVoltarAoMenu.Click += new System.EventHandler(this.bntVoltarAoMenu_Click);
            // 
            // Partida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntVoltarAoMenu);
            this.Name = "Partida";
            this.Text = "Partida";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntVoltarAoMenu;
    }
}
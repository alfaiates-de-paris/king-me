namespace king_me
{
    partial class HomeForm
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
            this.btnHomeJogar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHomeJogar
            // 
            this.btnHomeJogar.BackColor = System.Drawing.Color.Transparent;
            this.btnHomeJogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHomeJogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeJogar.Location = new System.Drawing.Point(342, 418);
            this.btnHomeJogar.Name = "btnHomeJogar";
            this.btnHomeJogar.Size = new System.Drawing.Size(100, 42);
            this.btnHomeJogar.TabIndex = 0;
            this.btnHomeJogar.Text = "Jogar!";
            this.btnHomeJogar.UseVisualStyleBackColor = false;
            this.btnHomeJogar.Click += new System.EventHandler(this.btnHomeJogar_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::king_me.Properties.Resources.king_me_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.btnHomeJogar);
            this.MaximizeBox = false;
            this.Name = "HomeForm";
            this.Text = "Bem vindo a King Me!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHomeJogar;
    }
}
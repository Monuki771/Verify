namespace Verify.Views
{
    partial class frmArtista
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbrGeneroMusica = new System.Windows.Forms.GroupBox();
            this.gbrBiografia = new System.Windows.Forms.GroupBox();
            this.btnCadastrarArtista = new System.Windows.Forms.Button();
            this.btnLimparArtista = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome Artistico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data de Nascimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Começo de carreira";
            // 
            // gbrGeneroMusica
            // 
            this.gbrGeneroMusica.Location = new System.Drawing.Point(572, 25);
            this.gbrGeneroMusica.Name = "gbrGeneroMusica";
            this.gbrGeneroMusica.Size = new System.Drawing.Size(200, 166);
            this.gbrGeneroMusica.TabIndex = 4;
            this.gbrGeneroMusica.TabStop = false;
            this.gbrGeneroMusica.Text = "Generos Musicas";
            // 
            // gbrBiografia
            // 
            this.gbrBiografia.Location = new System.Drawing.Point(26, 255);
            this.gbrBiografia.Name = "gbrBiografia";
            this.gbrBiografia.Size = new System.Drawing.Size(352, 151);
            this.gbrBiografia.TabIndex = 5;
            this.gbrBiografia.TabStop = false;
            this.gbrBiografia.Text = "Biografia do Artista";
            // 
            // btnCadastrarArtista
            // 
            this.btnCadastrarArtista.Location = new System.Drawing.Point(483, 383);
            this.btnCadastrarArtista.Name = "btnCadastrarArtista";
            this.btnCadastrarArtista.Size = new System.Drawing.Size(122, 23);
            this.btnCadastrarArtista.TabIndex = 6;
            this.btnCadastrarArtista.Text = "Cadastrar";
            this.btnCadastrarArtista.UseVisualStyleBackColor = true;
            // 
            // btnLimparArtista
            // 
            this.btnLimparArtista.Location = new System.Drawing.Point(650, 383);
            this.btnLimparArtista.Name = "btnLimparArtista";
            this.btnLimparArtista.Size = new System.Drawing.Size(122, 23);
            this.btnLimparArtista.TabIndex = 7;
            this.btnLimparArtista.Text = "Limpar";
            this.btnLimparArtista.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(346, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(26, 141);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(180, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(346, 141);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(140, 20);
            this.textBox4.TabIndex = 11;
            // 
            // frmArtista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnLimparArtista);
            this.Controls.Add(this.btnCadastrarArtista);
            this.Controls.Add(this.gbrBiografia);
            this.Controls.Add(this.gbrGeneroMusica);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmArtista";
            this.Text = "frmArtista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbrGeneroMusica;
        private System.Windows.Forms.GroupBox gbrBiografia;
        private System.Windows.Forms.Button btnCadastrarArtista;
        private System.Windows.Forms.Button btnLimparArtista;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}
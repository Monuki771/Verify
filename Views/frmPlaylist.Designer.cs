namespace Verify.Views
{
    partial class frmPlaylist
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnPublico = new System.Windows.Forms.Button();
            this.btnPrivado = new System.Windows.Forms.Button();
            this.btnCadastrarPlaylist = new System.Windows.Forms.Button();
            this.btnLimparPlaylist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(642, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Playlist";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(642, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(660, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Atualização";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(660, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data Criação";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(578, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(578, 121);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(197, 103);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(663, 306);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(663, 396);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            // 
            // btnPublico
            // 
            this.btnPublico.Location = new System.Drawing.Point(12, 90);
            this.btnPublico.Name = "btnPublico";
            this.btnPublico.Size = new System.Drawing.Size(104, 42);
            this.btnPublico.TabIndex = 8;
            this.btnPublico.Text = "Publico";
            this.btnPublico.UseVisualStyleBackColor = true;
            // 
            // btnPrivado
            // 
            this.btnPrivado.Location = new System.Drawing.Point(139, 91);
            this.btnPrivado.Name = "btnPrivado";
            this.btnPrivado.Size = new System.Drawing.Size(101, 41);
            this.btnPrivado.TabIndex = 9;
            this.btnPrivado.Text = "Privado";
            this.btnPrivado.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarPlaylist
            // 
            this.btnCadastrarPlaylist.Location = new System.Drawing.Point(12, 306);
            this.btnCadastrarPlaylist.Name = "btnCadastrarPlaylist";
            this.btnCadastrarPlaylist.Size = new System.Drawing.Size(106, 41);
            this.btnCadastrarPlaylist.TabIndex = 10;
            this.btnCadastrarPlaylist.Text = "Cadastrar";
            this.btnCadastrarPlaylist.UseVisualStyleBackColor = true;
            // 
            // btnLimparPlaylist
            // 
            this.btnLimparPlaylist.Location = new System.Drawing.Point(139, 306);
            this.btnLimparPlaylist.Name = "btnLimparPlaylist";
            this.btnLimparPlaylist.Size = new System.Drawing.Size(101, 41);
            this.btnLimparPlaylist.TabIndex = 11;
            this.btnLimparPlaylist.Text = "Limpar";
            this.btnLimparPlaylist.UseVisualStyleBackColor = true;
            // 
            // frmPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimparPlaylist);
            this.Controls.Add(this.btnCadastrarPlaylist);
            this.Controls.Add(this.btnPrivado);
            this.Controls.Add(this.btnPublico);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPlaylist";
            this.Text = "frmPlaylist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnPublico;
        private System.Windows.Forms.Button btnPrivado;
        private System.Windows.Forms.Button btnCadastrarPlaylist;
        private System.Windows.Forms.Button btnLimparPlaylist;
    }
}
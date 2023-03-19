namespace TesteEventos
{
    partial class Form1
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
            this.LblNome = new System.Windows.Forms.Label();
            this.LblEndereco = new System.Windows.Forms.Label();
            this.LblCelular = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblCpf = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtCpf = new System.Windows.Forms.TextBox();
            this.TxtEndereco = new System.Windows.Forms.TextBox();
            this.TxtCelualr = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.BtnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(22, 74);
            this.LblNome.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(62, 24);
            this.LblNome.TabIndex = 0;
            this.LblNome.Text = "Nome";
            this.LblNome.Click += new System.EventHandler(this.LblNome_Click);
            // 
            // LblEndereco
            // 
            this.LblEndereco.AutoSize = true;
            this.LblEndereco.Location = new System.Drawing.Point(22, 159);
            this.LblEndereco.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblEndereco.Name = "LblEndereco";
            this.LblEndereco.Size = new System.Drawing.Size(94, 24);
            this.LblEndereco.TabIndex = 1;
            this.LblEndereco.Text = "Endereço";
            this.LblEndereco.Click += new System.EventHandler(this.label2_Click);
            // 
            // LblCelular
            // 
            this.LblCelular.AutoSize = true;
            this.LblCelular.Location = new System.Drawing.Point(22, 244);
            this.LblCelular.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblCelular.Name = "LblCelular";
            this.LblCelular.Size = new System.Drawing.Size(69, 24);
            this.LblCelular.TabIndex = 2;
            this.LblCelular.Text = "Celular";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(22, 329);
            this.LblEmail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(63, 24);
            this.LblEmail.TabIndex = 3;
            this.LblEmail.Text = "E-mail";
            // 
            // LblCpf
            // 
            this.LblCpf.AutoSize = true;
            this.LblCpf.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LblCpf.Location = new System.Drawing.Point(22, 414);
            this.LblCpf.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblCpf.Name = "LblCpf";
            this.LblCpf.Size = new System.Drawing.Size(47, 24);
            this.LblCpf.TabIndex = 4;
            this.LblCpf.Text = "CPF";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(133, 71);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(281, 29);
            this.TxtNome.TabIndex = 5;
            this.TxtNome.TextChanged += new System.EventHandler(this.TxtNome_TextChanged);
            // 
            // TxtCpf
            // 
            this.TxtCpf.Location = new System.Drawing.Point(133, 411);
            this.TxtCpf.Name = "TxtCpf";
            this.TxtCpf.Size = new System.Drawing.Size(281, 29);
            this.TxtCpf.TabIndex = 6;
            this.TxtCpf.TextChanged += new System.EventHandler(this.TxtCpf_TextChanged);
            // 
            // TxtEndereco
            // 
            this.TxtEndereco.Location = new System.Drawing.Point(133, 156);
            this.TxtEndereco.Name = "TxtEndereco";
            this.TxtEndereco.Size = new System.Drawing.Size(281, 29);
            this.TxtEndereco.TabIndex = 7;
            // 
            // TxtCelualr
            // 
            this.TxtCelualr.Location = new System.Drawing.Point(133, 241);
            this.TxtCelualr.Name = "TxtCelualr";
            this.TxtCelualr.Size = new System.Drawing.Size(281, 29);
            this.TxtCelualr.TabIndex = 8;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(133, 326);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(281, 29);
            this.TxtEmail.TabIndex = 9;
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(562, 214);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(173, 84);
            this.BtnOk.TabIndex = 0;
            this.BtnOk.Text = "OK";
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 749);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtCelualr);
            this.Controls.Add(this.TxtEndereco);
            this.Controls.Add(this.TxtCpf);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.LblCpf);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblCelular);
            this.Controls.Add(this.LblEndereco);
            this.Controls.Add(this.LblNome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Cadastro de Aluno";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label LblEndereco;
        private System.Windows.Forms.Label LblCelular;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblCpf;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtCpf;
        private System.Windows.Forms.TextBox TxtEndereco;
        private System.Windows.Forms.TextBox TxtCelualr;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Button BtnOk;
    }
}


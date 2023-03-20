namespace PTesteEventos
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.btnTestar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(149, 6);
            this.txtNome.Margin = new System.Windows.Forms.Padding(6);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(338, 29);
            this.txtNome.TabIndex = 0;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(15, 9);
            this.lblNome.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(67, 24);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(15, 84);
            this.lblEndereco.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(99, 24);
            this.lblEndereco.TabIndex = 2;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(15, 159);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(63, 24);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "E-mail";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(15, 234);
            this.lblCelular.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(74, 24);
            this.lblCelular.TabIndex = 4;
            this.lblCelular.Text = "Celular:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(15, 309);
            this.lblCpf.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(57, 24);
            this.lblCpf.TabIndex = 5;
            this.lblCpf.Text = "CPF: ";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(149, 81);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(6);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(338, 29);
            this.txtEndereco.TabIndex = 6;
            this.txtEndereco.Validated += new System.EventHandler(this.txtEndereco_Validated);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(149, 156);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(338, 29);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(149, 231);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(6);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(338, 29);
            this.txtCelular.TabIndex = 8;
            this.txtCelular.Leave += new System.EventHandler(this.txtCelular_Leave);
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(149, 306);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(6);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(338, 29);
            this.txtCpf.TabIndex = 9;
            this.txtCpf.Enter += new System.EventHandler(this.txtCpf_Enter);
            // 
            // btnTestar
            // 
            this.btnTestar.Location = new System.Drawing.Point(197, 375);
            this.btnTestar.Name = "btnTestar";
            this.btnTestar.Size = new System.Drawing.Size(132, 66);
            this.btnTestar.TabIndex = 10;
            this.btnTestar.Text = "Testar";
            this.btnTestar.UseVisualStyleBackColor = true;
            this.btnTestar.Click += new System.EventHandler(this.btnTestar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 749);
            this.Controls.Add(this.btnTestar);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Cadastro de Aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Button btnTestar;
    }
}


namespace PMenu
{
    partial class frmExercicio2
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
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.btnSaoIguais = new System.Windows.Forms.Button();
            this.lblPalavra1 = new System.Windows.Forms.Label();
            this.lblPalavra2 = new System.Windows.Forms.Label();
            this.btnInserirMeio = new System.Windows.Forms.Button();
            this.btnAsterisco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Location = new System.Drawing.Point(98, 26);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(100, 20);
            this.txtPalavra1.TabIndex = 0;
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Location = new System.Drawing.Point(98, 63);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(100, 20);
            this.txtPalavra2.TabIndex = 1;
            // 
            // btnSaoIguais
            // 
            this.btnSaoIguais.Location = new System.Drawing.Point(98, 239);
            this.btnSaoIguais.Name = "btnSaoIguais";
            this.btnSaoIguais.Size = new System.Drawing.Size(75, 23);
            this.btnSaoIguais.TabIndex = 2;
            this.btnSaoIguais.Text = "São Iguais";
            this.btnSaoIguais.UseVisualStyleBackColor = true;
            this.btnSaoIguais.Click += new System.EventHandler(this.btnSaoIguais_Click);
            // 
            // lblPalavra1
            // 
            this.lblPalavra1.AutoSize = true;
            this.lblPalavra1.Location = new System.Drawing.Point(13, 32);
            this.lblPalavra1.Name = "lblPalavra1";
            this.lblPalavra1.Size = new System.Drawing.Size(49, 13);
            this.lblPalavra1.TabIndex = 3;
            this.lblPalavra1.Text = "Palavra1";
            // 
            // lblPalavra2
            // 
            this.lblPalavra2.AutoSize = true;
            this.lblPalavra2.Location = new System.Drawing.Point(13, 66);
            this.lblPalavra2.Name = "lblPalavra2";
            this.lblPalavra2.Size = new System.Drawing.Size(49, 13);
            this.lblPalavra2.TabIndex = 4;
            this.lblPalavra2.Text = "Palavra2";
            // 
            // btnInserirMeio
            // 
            this.btnInserirMeio.Location = new System.Drawing.Point(204, 209);
            this.btnInserirMeio.Name = "btnInserirMeio";
            this.btnInserirMeio.Size = new System.Drawing.Size(95, 83);
            this.btnInserirMeio.TabIndex = 5;
            this.btnInserirMeio.Text = "Inserir a palavra 1 no meio da 2";
            this.btnInserirMeio.UseVisualStyleBackColor = true;
            this.btnInserirMeio.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAsterisco
            // 
            this.btnAsterisco.Location = new System.Drawing.Point(321, 239);
            this.btnAsterisco.Name = "btnAsterisco";
            this.btnAsterisco.Size = new System.Drawing.Size(75, 23);
            this.btnAsterisco.TabIndex = 6;
            this.btnAsterisco.Text = "button3";
            this.btnAsterisco.UseVisualStyleBackColor = true;
            this.btnAsterisco.Click += new System.EventHandler(this.btnAsterisco_Click);
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAsterisco);
            this.Controls.Add(this.btnInserirMeio);
            this.Controls.Add(this.lblPalavra2);
            this.Controls.Add(this.lblPalavra1);
            this.Controls.Add(this.btnSaoIguais);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.txtPalavra1);
            this.Name = "frmExercicio2";
            this.Text = "frmExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPalavra1;
        private System.Windows.Forms.TextBox txtPalavra2;
        private System.Windows.Forms.Button btnSaoIguais;
        private System.Windows.Forms.Label lblPalavra1;
        private System.Windows.Forms.Label lblPalavra2;
        private System.Windows.Forms.Button btnInserirMeio;
        private System.Windows.Forms.Button btnAsterisco;
    }
}
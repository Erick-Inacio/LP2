namespace Extra
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
            this.lblRaio = new System.Windows.Forms.Label();
            this.txtRaio = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lblVolume = new System.Windows.Forms.Label();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRaio
            // 
            this.lblRaio.AutoSize = true;
            this.lblRaio.Location = new System.Drawing.Point(13, 15);
            this.lblRaio.Name = "lblRaio";
            this.lblRaio.Size = new System.Drawing.Size(32, 13);
            this.lblRaio.TabIndex = 0;
            this.lblRaio.Text = "Raio:";
            // 
            // txtRaio
            // 
            this.txtRaio.Location = new System.Drawing.Point(63, 12);
            this.txtRaio.Name = "txtRaio";
            this.txtRaio.Size = new System.Drawing.Size(155, 20);
            this.txtRaio.TabIndex = 1;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(13, 56);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(37, 13);
            this.lblAltura.TabIndex = 2;
            this.lblAltura.Text = "Altura:";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(63, 53);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(155, 20);
            this.txtAltura.TabIndex = 3;
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(13, 97);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(45, 13);
            this.lblVolume.TabIndex = 4;
            this.lblVolume.Text = "Volume:";
            // 
            // txtVolume
            // 
            this.txtVolume.Location = new System.Drawing.Point(63, 94);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(155, 20);
            this.txtVolume.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(16, 120);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(92, 40);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(126, 120);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(92, 40);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 177);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.txtRaio);
            this.Controls.Add(this.lblRaio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRaio;
        private System.Windows.Forms.TextBox txtRaio;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnFechar;
    }
}


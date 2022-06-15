namespace prjLoteria
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
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnCartela = new System.Windows.Forms.Panel();
            this.rbMegaSena = new System.Windows.Forms.RadioButton();
            this.brLotoMania = new System.Windows.Forms.RadioButton();
            this.rbLotoFacil = new System.Windows.Forms.RadioButton();
            this.rbQuina = new System.Windows.Forms.RadioButton();
            this.btnJogar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnCartela
            // 
            this.pnCartela.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnCartela.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCartela.Location = new System.Drawing.Point(0, 0);
            this.pnCartela.Name = "pnCartela";
            this.pnCartela.Size = new System.Drawing.Size(811, 409);
            this.pnCartela.TabIndex = 0;
            // 
            // rbMegaSena
            // 
            this.rbMegaSena.AutoSize = true;
            this.rbMegaSena.Checked = true;
            this.rbMegaSena.Location = new System.Drawing.Point(25, 424);
            this.rbMegaSena.Name = "rbMegaSena";
            this.rbMegaSena.Size = new System.Drawing.Size(85, 17);
            this.rbMegaSena.TabIndex = 1;
            this.rbMegaSena.TabStop = true;
            this.rbMegaSena.Text = "MEGASENA";
            this.rbMegaSena.UseVisualStyleBackColor = true;
            // 
            // brLotoMania
            // 
            this.brLotoMania.AutoSize = true;
            this.brLotoMania.Location = new System.Drawing.Point(25, 482);
            this.brLotoMania.Name = "brLotoMania";
            this.brLotoMania.Size = new System.Drawing.Size(88, 17);
            this.brLotoMania.TabIndex = 1;
            this.brLotoMania.Text = "LOTOMANIA";
            this.brLotoMania.UseVisualStyleBackColor = true;
            // 
            // rbLotoFacil
            // 
            this.rbLotoFacil.AutoSize = true;
            this.rbLotoFacil.Location = new System.Drawing.Point(151, 482);
            this.rbLotoFacil.Name = "rbLotoFacil";
            this.rbLotoFacil.Size = new System.Drawing.Size(83, 17);
            this.rbLotoFacil.TabIndex = 1;
            this.rbLotoFacil.Text = "LOTOFACIL";
            this.rbLotoFacil.UseVisualStyleBackColor = true;
            // 
            // rbQuina
            // 
            this.rbQuina.AutoSize = true;
            this.rbQuina.Location = new System.Drawing.Point(151, 424);
            this.rbQuina.Name = "rbQuina";
            this.rbQuina.Size = new System.Drawing.Size(59, 17);
            this.rbQuina.TabIndex = 1;
            this.rbQuina.Text = "QUINA";
            this.rbQuina.UseVisualStyleBackColor = true;
            // 
            // btnJogar
            // 
            this.btnJogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogar.Location = new System.Drawing.Point(304, 424);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(460, 75);
            this.btnJogar.TabIndex = 2;
            this.btnJogar.Text = "GERAR CARTELA";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(811, 524);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.rbQuina);
            this.Controls.Add(this.rbLotoFacil);
            this.Controls.Add(this.brLotoMania);
            this.Controls.Add(this.rbMegaSena);
            this.Controls.Add(this.pnCartela);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de Cartelas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnCartela;
        private System.Windows.Forms.RadioButton rbMegaSena;
        private System.Windows.Forms.RadioButton brLotoMania;
        private System.Windows.Forms.RadioButton rbLotoFacil;
        private System.Windows.Forms.RadioButton rbQuina;
        private System.Windows.Forms.Button btnJogar;
    }
}


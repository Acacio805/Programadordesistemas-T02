namespace TabuadaComLoop
{
    partial class frmTabuadaLoop
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
            this.panelFundo = new System.Windows.Forms.Panel();
            this.panelEsquerda = new System.Windows.Forms.Panel();
            this.panelDireita = new System.Windows.Forms.Panel();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnExecutarTabuada = new System.Windows.Forms.Button();
            this.lstTabuada = new System.Windows.Forms.ListBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.panelFundo.SuspendLayout();
            this.panelEsquerda.SuspendLayout();
            this.panelDireita.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFundo
            // 
            this.panelFundo.BackColor = System.Drawing.Color.Cyan;
            this.panelFundo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFundo.Controls.Add(this.panelDireita);
            this.panelFundo.Controls.Add(this.panelEsquerda);
            this.panelFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFundo.Location = new System.Drawing.Point(0, 0);
            this.panelFundo.Name = "panelFundo";
            this.panelFundo.Size = new System.Drawing.Size(800, 450);
            this.panelFundo.TabIndex = 0;
            // 
            // panelEsquerda
            // 
            this.panelEsquerda.BackColor = System.Drawing.Color.PeachPuff;
            this.panelEsquerda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelEsquerda.Controls.Add(this.lstTabuada);
            this.panelEsquerda.Location = new System.Drawing.Point(23, 29);
            this.panelEsquerda.Name = "panelEsquerda";
            this.panelEsquerda.Size = new System.Drawing.Size(353, 382);
            this.panelEsquerda.TabIndex = 0;
            // 
            // panelDireita
            // 
            this.panelDireita.BackColor = System.Drawing.Color.PeachPuff;
            this.panelDireita.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDireita.Controls.Add(this.btnLimpar);
            this.panelDireita.Controls.Add(this.btnExecutarTabuada);
            this.panelDireita.Controls.Add(this.txtNumero);
            this.panelDireita.Controls.Add(this.lblNumero);
            this.panelDireita.Location = new System.Drawing.Point(415, 29);
            this.panelDireita.Name = "panelDireita";
            this.panelDireita.Size = new System.Drawing.Size(351, 382);
            this.panelDireita.TabIndex = 1;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(18, 19);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(315, 39);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Insira Um Número";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(34, 76);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(282, 62);
            this.txtNumero.TabIndex = 1;
            this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnExecutarTabuada
            // 
            this.btnExecutarTabuada.BackColor = System.Drawing.Color.Cyan;
            this.btnExecutarTabuada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExecutarTabuada.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecutarTabuada.ForeColor = System.Drawing.Color.Black;
            this.btnExecutarTabuada.Location = new System.Drawing.Point(34, 245);
            this.btnExecutarTabuada.Name = "btnExecutarTabuada";
            this.btnExecutarTabuada.Size = new System.Drawing.Size(282, 103);
            this.btnExecutarTabuada.TabIndex = 2;
            this.btnExecutarTabuada.Text = "Executar Tabuada";
            this.btnExecutarTabuada.UseVisualStyleBackColor = false;
            this.btnExecutarTabuada.Click += new System.EventHandler(this.btnExecutarTabuada_Click);
            // 
            // lstTabuada
            // 
            this.lstTabuada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTabuada.FormattingEnabled = true;
            this.lstTabuada.ItemHeight = 25;
            this.lstTabuada.Location = new System.Drawing.Point(20, 19);
            this.lstTabuada.Name = "lstTabuada";
            this.lstTabuada.Size = new System.Drawing.Size(311, 329);
            this.lstTabuada.TabIndex = 0;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Cyan;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.Location = new System.Drawing.Point(34, 154);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(282, 75);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmTabuadaLoop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelFundo);
            this.Name = "frmTabuadaLoop";
            this.Text = "Tabuada com Loop";
            this.panelFundo.ResumeLayout(false);
            this.panelEsquerda.ResumeLayout(false);
            this.panelDireita.ResumeLayout(false);
            this.panelDireita.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFundo;
        private System.Windows.Forms.Panel panelEsquerda;
        private System.Windows.Forms.Panel panelDireita;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnExecutarTabuada;
        private System.Windows.Forms.ListBox lstTabuada;
        private System.Windows.Forms.Button btnLimpar;
    }
}


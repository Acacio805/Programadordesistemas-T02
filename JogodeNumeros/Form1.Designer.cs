namespace JogodeNumeros
{
    partial class frmJogoNumeros
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
            this.panelTopo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.txtNumeroInserido = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnTentativa = new System.Windows.Forms.Button();
            this.lblAbaixoButao = new System.Windows.Forms.Label();
            this.lblNumeroTentativas = new System.Windows.Forms.Label();
            this.panelTopo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopo
            // 
            this.panelTopo.BackColor = System.Drawing.Color.Red;
            this.panelTopo.Controls.Add(this.lblTitulo);
            this.panelTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopo.Location = new System.Drawing.Point(0, 0);
            this.panelTopo.Name = "panelTopo";
            this.panelTopo.Size = new System.Drawing.Size(800, 100);
            this.panelTopo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(187, 35);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(415, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Boas vindas ao meu jogo de números";
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo.ForeColor = System.Drawing.Color.Red;
            this.lblSubTitulo.Location = new System.Drawing.Point(191, 122);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(411, 22);
            this.lblSubTitulo.TabIndex = 1;
            this.lblSubTitulo.Text = "10 tentativas! insira um número de 1 até 100";
            // 
            // txtNumeroInserido
            // 
            this.txtNumeroInserido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroInserido.ForeColor = System.Drawing.Color.Red;
            this.txtNumeroInserido.Location = new System.Drawing.Point(294, 157);
            this.txtNumeroInserido.Name = "txtNumeroInserido";
            this.txtNumeroInserido.Size = new System.Drawing.Size(182, 31);
            this.txtNumeroInserido.TabIndex = 2;
            this.txtNumeroInserido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.ForeColor = System.Drawing.Color.Red;
            this.txtResultado.Location = new System.Drawing.Point(12, 407);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(776, 31);
            this.txtResultado.TabIndex = 3;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTentativa
            // 
            this.btnTentativa.BackColor = System.Drawing.Color.Red;
            this.btnTentativa.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTentativa.ForeColor = System.Drawing.Color.White;
            this.btnTentativa.Location = new System.Drawing.Point(257, 235);
            this.btnTentativa.Name = "btnTentativa";
            this.btnTentativa.Size = new System.Drawing.Size(242, 90);
            this.btnTentativa.TabIndex = 4;
            this.btnTentativa.Text = "Tentar";
            this.btnTentativa.UseVisualStyleBackColor = false;
            this.btnTentativa.Click += new System.EventHandler(this.btnTentativa_Click);
            // 
            // lblAbaixoButao
            // 
            this.lblAbaixoButao.AutoSize = true;
            this.lblAbaixoButao.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbaixoButao.Location = new System.Drawing.Point(206, 356);
            this.lblAbaixoButao.Name = "lblAbaixoButao";
            this.lblAbaixoButao.Size = new System.Drawing.Size(316, 40);
            this.lblAbaixoButao.TabIndex = 5;
            this.lblAbaixoButao.Text = "Veja quanta tentativas restam:";
            // 
            // lblNumeroTentativas
            // 
            this.lblNumeroTentativas.AutoSize = true;
            this.lblNumeroTentativas.Font = new System.Drawing.Font("Dubai", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroTentativas.Location = new System.Drawing.Point(514, 350);
            this.lblNumeroTentativas.Name = "lblNumeroTentativas";
            this.lblNumeroTentativas.Size = new System.Drawing.Size(57, 54);
            this.lblNumeroTentativas.TabIndex = 6;
            this.lblNumeroTentativas.Text = "10";
            // 
            // frmJogoNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNumeroTentativas);
            this.Controls.Add(this.lblAbaixoButao);
            this.Controls.Add(this.btnTentativa);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtNumeroInserido);
            this.Controls.Add(this.lblSubTitulo);
            this.Controls.Add(this.panelTopo);
            this.Name = "frmJogoNumeros";
            this.Text = "Jogo de Números";
            this.Load += new System.EventHandler(this.frmJogoNumeros_Load);
            this.panelTopo.ResumeLayout(false);
            this.panelTopo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTopo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.TextBox txtNumeroInserido;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnTentativa;
        private System.Windows.Forms.Label lblAbaixoButao;
        private System.Windows.Forms.Label lblNumeroTentativas;
    }
}


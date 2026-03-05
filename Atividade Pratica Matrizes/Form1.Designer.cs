namespace Atividade_Pratica_Matrizes
{
    partial class frmCadastro
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
            this.lstCadastro = new System.Windows.Forms.ListBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.lblOcupacao = new System.Windows.Forms.Label();
            this.txtOcupacao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstCadastro
            // 
            this.lstCadastro.BackColor = System.Drawing.Color.Navy;
            this.lstCadastro.CausesValidation = false;
            this.lstCadastro.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCadastro.ForeColor = System.Drawing.Color.White;
            this.lstCadastro.FormattingEnabled = true;
            this.lstCadastro.ItemHeight = 19;
            this.lstCadastro.Location = new System.Drawing.Point(12, 12);
            this.lstCadastro.Name = "lstCadastro";
            this.lstCadastro.Size = new System.Drawing.Size(345, 422);
            this.lstCadastro.TabIndex = 0;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(367, 34);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(399, 27);
            this.txtNome.TabIndex = 1;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Location = new System.Drawing.Point(510, 333);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(125, 79);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(363, 12);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 19);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade.Location = new System.Drawing.Point(363, 64);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(48, 19);
            this.lblIdade.TabIndex = 5;
            this.lblIdade.Text = "Idade";
            // 
            // txtIdade
            // 
            this.txtIdade.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdade.Location = new System.Drawing.Point(367, 89);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(399, 27);
            this.txtIdade.TabIndex = 4;
            // 
            // lblOcupacao
            // 
            this.lblOcupacao.AutoSize = true;
            this.lblOcupacao.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcupacao.Location = new System.Drawing.Point(363, 119);
            this.lblOcupacao.Name = "lblOcupacao";
            this.lblOcupacao.Size = new System.Drawing.Size(81, 19);
            this.lblOcupacao.TabIndex = 7;
            this.lblOcupacao.Text = "Ocupação";
            // 
            // txtOcupacao
            // 
            this.txtOcupacao.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOcupacao.Location = new System.Drawing.Point(367, 141);
            this.txtOcupacao.Name = "txtOcupacao";
            this.txtOcupacao.Size = new System.Drawing.Size(399, 27);
            this.txtOcupacao.TabIndex = 6;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOcupacao);
            this.Controls.Add(this.txtOcupacao);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lstCadastro);
            this.Name = "frmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Pessoas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCadastro;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label lblOcupacao;
        private System.Windows.Forms.TextBox txtOcupacao;
    }
}


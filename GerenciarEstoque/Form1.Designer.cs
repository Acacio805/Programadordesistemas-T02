namespace GerenciarEstoque
{
    partial class frmGerenciamentoEstoque
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
            this.lblMensagem = new System.Windows.Forms.Label();
            this.lblDigiteEstoque = new System.Windows.Forms.Label();
            this.btnCheckEstoque = new System.Windows.Forms.Button();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(12, 9);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(158, 35);
            this.lblMensagem.TabIndex = 0;
            this.lblMensagem.Text = "Mensagem";
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMensagem.UseMnemonic = false;
            // 
            // lblDigiteEstoque
            // 
            this.lblDigiteEstoque.AutoSize = true;
            this.lblDigiteEstoque.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigiteEstoque.Location = new System.Drawing.Point(154, 193);
            this.lblDigiteEstoque.Name = "lblDigiteEstoque";
            this.lblDigiteEstoque.Size = new System.Drawing.Size(369, 42);
            this.lblDigiteEstoque.TabIndex = 1;
            this.lblDigiteEstoque.Text = "Digite estoque do produto :";
            this.lblDigiteEstoque.UseCompatibleTextRendering = true;
            // 
            // btnCheckEstoque
            // 
            this.btnCheckEstoque.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckEstoque.Location = new System.Drawing.Point(260, 329);
            this.btnCheckEstoque.Name = "btnCheckEstoque";
            this.btnCheckEstoque.Size = new System.Drawing.Size(242, 37);
            this.btnCheckEstoque.TabIndex = 3;
            this.btnCheckEstoque.Text = "Verificar Estoque";
            this.btnCheckEstoque.UseVisualStyleBackColor = true;
            this.btnCheckEstoque.Click += new System.EventHandler(this.btnCheckEstoque_Click);
            // 
            // txtEstoque
            // 
            this.txtEstoque.Font = new System.Drawing.Font("Roboto", 21.75F);
            this.txtEstoque.Location = new System.Drawing.Point(517, 193);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(100, 42);
            this.txtEstoque.TabIndex = 4;
            // 
            // frmGerenciamentoEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.btnCheckEstoque);
            this.Controls.Add(this.lblDigiteEstoque);
            this.Controls.Add(this.lblMensagem);
            this.Name = "frmGerenciamentoEstoque";
            this.Text = "Gerenciamento de Estoque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label lblDigiteEstoque;
        private System.Windows.Forms.Button btnCheckEstoque;
        private System.Windows.Forms.TextBox txtEstoque;
    }
}


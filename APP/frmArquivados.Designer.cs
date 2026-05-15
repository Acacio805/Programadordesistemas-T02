namespace APP
{
    partial class frmArquivados
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
            lstPedidosArquivados = new ListView();
            txtPesquisa = new TextBox();
            btnPesquisar = new PictureBox();
            btnDel = new RoundedButton();
            btnVoltar = new RoundedButton();
            ((System.ComponentModel.ISupportInitialize)btnPesquisar).BeginInit();
            SuspendLayout();
            // 
            // lstPedidosArquivados
            // 
            lstPedidosArquivados.Location = new Point(12, 57);
            lstPedidosArquivados.Name = "lstPedidosArquivados";
            lstPedidosArquivados.Size = new Size(1248, 532);
            lstPedidosArquivados.TabIndex = 0;
            lstPedidosArquivados.UseCompatibleStateImageBehavior = false;
            lstPedidosArquivados.ItemSelectionChanged += lstPedidosArquivados_ItemSelectionChanged;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPesquisa.Location = new Point(611, 8);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(586, 43);
            txtPesquisa.TabIndex = 1;
            txtPesquisa.KeyDown += txtPesquisa_KeyDown;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.Transparent;
            btnPesquisar.Cursor = Cursors.Hand;
            btnPesquisar.Image = Properties.Resources.search_64dp_FFFFFF_FILL0_wght400_GRAD0_opsz48;
            btnPesquisar.ImeMode = ImeMode.NoControl;
            btnPesquisar.Location = new Point(1203, 7);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(44, 44);
            btnPesquisar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnPesquisar.TabIndex = 15;
            btnPesquisar.TabStop = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.Red;
            btnDel.BorderRadius = 10;
            btnDel.FlatAppearance.BorderSize = 0;
            btnDel.FlatStyle = FlatStyle.Flat;
            btnDel.Image = Properties.Resources.delete_32dp_FFFFFF_FILL0_wght400_GRAD0_opsz40;
            btnDel.Location = new Point(1180, 595);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(67, 52);
            btnDel.TabIndex = 17;
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Visible = false;
            btnDel.Click += btnDel_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Gold;
            btnVoltar.BorderRadius = 10;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Image = Properties.Resources.arrow_back_32dp_FFFFFF_FILL0_wght400_GRAD0_opsz40;
            btnVoltar.Location = new Point(1107, 595);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(67, 52);
            btnVoltar.TabIndex = 18;
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Visible = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // frmArquivados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1272, 659);
            Controls.Add(btnVoltar);
            Controls.Add(btnDel);
            Controls.Add(btnPesquisar);
            Controls.Add(txtPesquisa);
            Controls.Add(lstPedidosArquivados);
            Name = "frmArquivados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pedidos Arquivados";
            ((System.ComponentModel.ISupportInitialize)btnPesquisar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lstPedidosArquivados;
        private TextBox txtPesquisa;
        private PictureBox btnPesquisar;
        private RoundedButton btnDel;
        private RoundedButton btnVoltar;
    }
}
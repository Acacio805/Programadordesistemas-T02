namespace APP
{
    partial class frmInfo
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
            label6 = new Label();
            dtpDataEntrega = new DateTimePicker();
            label5 = new Label();
            cbTipodeModelo = new ComboBox();
            label4 = new Label();
            txtEmail = new TextBox();
            txtDescricao = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtNome = new TextBox();
            btnAtualizar = new Button();
            cbModeloJogo = new ComboBox();
            panelTop = new GPanel.GradientPanel();
            label7 = new Label();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.WindowText;
            label6.Location = new Point(19, 411);
            label6.Name = "label6";
            label6.Size = new Size(203, 30);
            label6.TabIndex = 23;
            label6.Text = "Modelo é para Jogo:";
            // 
            // dtpDataEntrega
            // 
            dtpDataEntrega.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDataEntrega.Location = new Point(219, 354);
            dtpDataEntrega.Name = "dtpDataEntrega";
            dtpDataEntrega.Size = new Size(391, 35);
            dtpDataEntrega.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.WindowText;
            label5.Location = new Point(19, 358);
            label5.Name = "label5";
            label5.Size = new Size(174, 30);
            label5.TabIndex = 21;
            label5.Text = "Data de Entrega :";
            // 
            // cbTipodeModelo
            // 
            cbTipodeModelo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbTipodeModelo.FormattingEnabled = true;
            cbTipodeModelo.Items.AddRange(new object[] { "Personagem", "Roupas", "Pacote de Vegetação", "Pacote de Modelos Variados" });
            cbTipodeModelo.Location = new Point(219, 300);
            cbTipodeModelo.Name = "cbTipodeModelo";
            cbTipodeModelo.Size = new Size(336, 38);
            cbTipodeModelo.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.WindowText;
            label4.Location = new Point(19, 303);
            label4.Name = "label4";
            label4.Size = new Size(169, 30);
            label4.TabIndex = 19;
            label4.Text = "Tipo de modelo :";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(219, 190);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(746, 35);
            txtEmail.TabIndex = 18;
            // 
            // txtDescricao
            // 
            txtDescricao.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescricao.Location = new Point(219, 245);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(746, 35);
            txtDescricao.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.WindowText;
            label3.Location = new Point(19, 193);
            label3.Name = "label3";
            label3.Size = new Size(74, 30);
            label3.TabIndex = 16;
            label3.Text = "Email :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.WindowText;
            label2.Location = new Point(19, 248);
            label2.Name = "label2";
            label2.Size = new Size(171, 30);
            label2.TabIndex = 15;
            label2.Text = "Descrição Breve :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.WindowText;
            label1.Location = new Point(19, 136);
            label1.Name = "label1";
            label1.Size = new Size(81, 30);
            label1.TabIndex = 14;
            label1.Text = "Nome :";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(219, 136);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(746, 35);
            txtNome.TabIndex = 13;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.White;
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtualizar.ForeColor = SystemColors.InfoText;
            btnAtualizar.Location = new Point(764, 471);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(201, 58);
            btnAtualizar.TabIndex = 25;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // cbModeloJogo
            // 
            cbModeloJogo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbModeloJogo.FormattingEnabled = true;
            cbModeloJogo.Items.AddRange(new object[] { "Sim", "Não" });
            cbModeloJogo.Location = new Point(219, 408);
            cbModeloJogo.Name = "cbModeloJogo";
            cbModeloJogo.Size = new Size(121, 38);
            cbModeloJogo.TabIndex = 26;
            // 
            // panelTop
            // 
            panelTop._cornerRadius = 0;
            panelTop.Angle = 45F;
            panelTop.BackColor = Color.White;
            panelTop.BottomColor = Color.Black;
            panelTop.Controls.Add(label7);
            panelTop.CornerRadius = 0;
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(989, 110);
            panelTop.TabIndex = 27;
            panelTop.TopColor = Color.Gray;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(423, 32);
            label7.Name = "label7";
            label7.Size = new Size(149, 45);
            label7.TabIndex = 28;
            label7.Text = "Detalhes";
            // 
            // frmInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 617);
            Controls.Add(panelTop);
            Controls.Add(cbModeloJogo);
            Controls.Add(btnAtualizar);
            Controls.Add(label6);
            Controls.Add(dtpDataEntrega);
            Controls.Add(label5);
            Controls.Add(cbTipodeModelo);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(txtDescricao);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Name = "frmInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Informação do Pedido";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private DateTimePicker dtpDataEntrega;
        private Label label5;
        private ComboBox cbTipodeModelo;
        private Label label4;
        private TextBox txtEmail;
        private TextBox txtDescricao;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtNome;
        private Button btnAtualizar;
        private ComboBox cbModeloJogo;
        private GPanel.GradientPanel panelTop;
        private Label label7;
    }
}
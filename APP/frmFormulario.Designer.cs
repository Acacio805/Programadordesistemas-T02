namespace APP
{
    partial class frmFormulario
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
            txtNome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtDescricao = new TextBox();
            txtEmail = new TextBox();
            label4 = new Label();
            btnAdicionarPedido = new Button();
            cbTipodeModelo = new ComboBox();
            label5 = new Label();
            dtpDataEntrega = new DateTimePicker();
            label6 = new Label();
            rbtnModeloJogo = new RadioButton();
            panelBackground = new GPanel.GradientPanel();
            gradientPanel1 = new GPanel.GradientPanel();
            label7 = new Label();
            panelBackground.SuspendLayout();
            gradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(212, 169);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(746, 35);
            txtNome.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.WindowText;
            label1.Location = new Point(12, 169);
            label1.Name = "label1";
            label1.Size = new Size(81, 30);
            label1.TabIndex = 1;
            label1.Text = "Nome :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.WindowText;
            label2.Location = new Point(12, 281);
            label2.Name = "label2";
            label2.Size = new Size(171, 30);
            label2.TabIndex = 2;
            label2.Text = "Descrição Breve :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.WindowText;
            label3.Location = new Point(12, 226);
            label3.Name = "label3";
            label3.Size = new Size(74, 30);
            label3.TabIndex = 3;
            label3.Text = "Email :";
            // 
            // txtDescricao
            // 
            txtDescricao.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescricao.Location = new Point(212, 278);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(746, 35);
            txtDescricao.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(212, 223);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(746, 35);
            txtEmail.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.WindowText;
            label4.Location = new Point(12, 336);
            label4.Name = "label4";
            label4.Size = new Size(169, 30);
            label4.TabIndex = 6;
            label4.Text = "Tipo de modelo :";
            // 
            // btnAdicionarPedido
            // 
            btnAdicionarPedido.BackColor = Color.White;
            btnAdicionarPedido.FlatStyle = FlatStyle.Flat;
            btnAdicionarPedido.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionarPedido.ForeColor = SystemColors.InfoText;
            btnAdicionarPedido.Location = new Point(723, 659);
            btnAdicionarPedido.Name = "btnAdicionarPedido";
            btnAdicionarPedido.Size = new Size(235, 76);
            btnAdicionarPedido.TabIndex = 7;
            btnAdicionarPedido.Text = "Adicionar Pedido";
            btnAdicionarPedido.UseVisualStyleBackColor = false;
            btnAdicionarPedido.Click += btnAdicionarPedido_Click;
            // 
            // cbTipodeModelo
            // 
            cbTipodeModelo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbTipodeModelo.FormattingEnabled = true;
            cbTipodeModelo.Items.AddRange(new object[] { "Personagem", "Roupas", "Pacote de Vegetação", "Pacote de Modelos Variados" });
            cbTipodeModelo.Location = new Point(212, 333);
            cbTipodeModelo.Name = "cbTipodeModelo";
            cbTipodeModelo.Size = new Size(336, 38);
            cbTipodeModelo.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.WindowText;
            label5.Location = new Point(12, 391);
            label5.Name = "label5";
            label5.Size = new Size(174, 30);
            label5.TabIndex = 9;
            label5.Text = "Data de Entrega :";
            // 
            // dtpDataEntrega
            // 
            dtpDataEntrega.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDataEntrega.Location = new Point(212, 387);
            dtpDataEntrega.Name = "dtpDataEntrega";
            dtpDataEntrega.Size = new Size(391, 35);
            dtpDataEntrega.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.WindowText;
            label6.Location = new Point(12, 444);
            label6.Name = "label6";
            label6.Size = new Size(181, 30);
            label6.TabIndex = 11;
            label6.Text = "Modelo para Jogo";
            // 
            // rbtnModeloJogo
            // 
            rbtnModeloJogo.AutoSize = true;
            rbtnModeloJogo.BackColor = Color.Transparent;
            rbtnModeloJogo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbtnModeloJogo.Location = new Point(212, 444);
            rbtnModeloJogo.Name = "rbtnModeloJogo";
            rbtnModeloJogo.Size = new Size(37, 34);
            rbtnModeloJogo.TabIndex = 12;
            rbtnModeloJogo.TabStop = true;
            rbtnModeloJogo.Text = " ";
            rbtnModeloJogo.UseVisualStyleBackColor = false;
            // 
            // panelBackground
            // 
            panelBackground._cornerRadius = 0;
            panelBackground.Angle = 45F;
            panelBackground.BackColor = Color.White;
            panelBackground.BottomColor = SystemColors.AppWorkspace;
            panelBackground.Controls.Add(gradientPanel1);
            panelBackground.Controls.Add(rbtnModeloJogo);
            panelBackground.Controls.Add(label6);
            panelBackground.Controls.Add(dtpDataEntrega);
            panelBackground.Controls.Add(label5);
            panelBackground.Controls.Add(cbTipodeModelo);
            panelBackground.Controls.Add(btnAdicionarPedido);
            panelBackground.Controls.Add(label4);
            panelBackground.Controls.Add(txtEmail);
            panelBackground.Controls.Add(txtDescricao);
            panelBackground.Controls.Add(label3);
            panelBackground.Controls.Add(label2);
            panelBackground.Controls.Add(label1);
            panelBackground.Controls.Add(txtNome);
            panelBackground.CornerRadius = 0;
            panelBackground.Dock = DockStyle.Fill;
            panelBackground.Location = new Point(0, 0);
            panelBackground.Name = "panelBackground";
            panelBackground.Size = new Size(984, 761);
            panelBackground.TabIndex = 1;
            panelBackground.TopColor = SystemColors.ControlLight;
            // 
            // gradientPanel1
            // 
            gradientPanel1._cornerRadius = 0;
            gradientPanel1.Angle = 0F;
            gradientPanel1.BackColor = Color.White;
            gradientPanel1.BottomColor = SystemColors.ActiveCaptionText;
            gradientPanel1.Controls.Add(label7);
            gradientPanel1.CornerRadius = 0;
            gradientPanel1.Dock = DockStyle.Top;
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(984, 101);
            gradientPanel1.TabIndex = 13;
            gradientPanel1.TopColor = SystemColors.AppWorkspace;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(358, 29);
            label7.Name = "label7";
            label7.Size = new Size(257, 40);
            label7.TabIndex = 0;
            label7.Text = "Registrar Pedidos";
            // 
            // frmFormulario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 761);
            Controls.Add(panelBackground);
            Name = "frmFormulario";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulário";
            panelBackground.ResumeLayout(false);
            panelBackground.PerformLayout();
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNome;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtDescricao;
        private TextBox txtEmail;
        private Label label4;
        private Button btnAdicionarPedido;
        private ComboBox cbTipodeModelo;
        private Label label5;
        private DateTimePicker dtpDataEntrega;
        private Label label6;
        private RadioButton rbtnModeloJogo;
        private GPanel.GradientPanel panelBackground;
        private GPanel.GradientPanel gradientPanel1;
        private Label label7;
    }
}
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
            lblDescricao = new Label();
            lblContato = new Label();
            txtDescricao = new TextBox();
            txtEmail = new TextBox();
            lblTipoModelo = new Label();
            btnAdicionarPedido = new Button();
            cbTipodeModelo = new ComboBox();
            lblDeadline = new Label();
            dtpDataEntrega = new DateTimePicker();
            lblJogo = new Label();
            panelBackground = new GPanel.GradientPanel();
            roundedPanel3 = new RPanel.RoundedPanel();
            roundedPanel2 = new RPanel.RoundedPanel();
            roundedPanel1 = new RPanel.RoundedPanel();
            cbModeloJogo = new ComboBox();
            gradientPanel1 = new GPanel.GradientPanel();
            label7 = new Label();
            panelBackground.SuspendLayout();
            roundedPanel3.SuspendLayout();
            roundedPanel2.SuspendLayout();
            roundedPanel1.SuspendLayout();
            gradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(13, 9);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(1123, 28);
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
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.BackColor = Color.Transparent;
            lblDescricao.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescricao.ForeColor = SystemColors.WindowText;
            lblDescricao.Location = new Point(10, 288);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(171, 30);
            lblDescricao.TabIndex = 2;
            lblDescricao.Text = "Descrição Breve :";
            // 
            // lblContato
            // 
            lblContato.AutoSize = true;
            lblContato.BackColor = Color.Transparent;
            lblContato.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContato.ForeColor = SystemColors.WindowText;
            lblContato.Location = new Point(12, 228);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(98, 30);
            lblContato.TabIndex = 3;
            lblContato.Text = "Contato :";
            // 
            // txtDescricao
            // 
            txtDescricao.BorderStyle = BorderStyle.None;
            txtDescricao.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescricao.Location = new Point(13, 9);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(1123, 28);
            txtDescricao.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(13, 9);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(1123, 28);
            txtEmail.TabIndex = 5;
            // 
            // lblTipoModelo
            // 
            lblTipoModelo.AutoSize = true;
            lblTipoModelo.BackColor = Color.Transparent;
            lblTipoModelo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipoModelo.ForeColor = SystemColors.WindowText;
            lblTipoModelo.Location = new Point(12, 353);
            lblTipoModelo.Name = "lblTipoModelo";
            lblTipoModelo.Size = new Size(169, 30);
            lblTipoModelo.TabIndex = 6;
            lblTipoModelo.Text = "Tipo de modelo :";
            // 
            // btnAdicionarPedido
            // 
            btnAdicionarPedido.BackColor = Color.White;
            btnAdicionarPedido.FlatStyle = FlatStyle.Flat;
            btnAdicionarPedido.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionarPedido.ForeColor = SystemColors.InfoText;
            btnAdicionarPedido.Location = new Point(1116, 669);
            btnAdicionarPedido.Name = "btnAdicionarPedido";
            btnAdicionarPedido.Size = new Size(235, 76);
            btnAdicionarPedido.TabIndex = 7;
            btnAdicionarPedido.Text = "Adicionar Pedido";
            btnAdicionarPedido.UseVisualStyleBackColor = false;
            btnAdicionarPedido.Click += btnAdicionarPedido_Click;
            // 
            // cbTipodeModelo
            // 
            cbTipodeModelo.FlatStyle = FlatStyle.System;
            cbTipodeModelo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbTipodeModelo.FormattingEnabled = true;
            cbTipodeModelo.Items.AddRange(new object[] { "Personagem", "Roupas", "Pacote de Vegetação", "Pacote de Modelos Variados" });
            cbTipodeModelo.Location = new Point(229, 350);
            cbTipodeModelo.Name = "cbTipodeModelo";
            cbTipodeModelo.Size = new Size(336, 38);
            cbTipodeModelo.TabIndex = 8;
            // 
            // lblDeadline
            // 
            lblDeadline.AutoSize = true;
            lblDeadline.BackColor = Color.Transparent;
            lblDeadline.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDeadline.ForeColor = SystemColors.WindowText;
            lblDeadline.Location = new Point(12, 421);
            lblDeadline.Name = "lblDeadline";
            lblDeadline.Size = new Size(174, 30);
            lblDeadline.TabIndex = 9;
            lblDeadline.Text = "Data de Entrega :";
            // 
            // dtpDataEntrega
            // 
            dtpDataEntrega.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDataEntrega.Location = new Point(229, 417);
            dtpDataEntrega.Name = "dtpDataEntrega";
            dtpDataEntrega.Size = new Size(403, 35);
            dtpDataEntrega.TabIndex = 10;
            // 
            // lblJogo
            // 
            lblJogo.AutoSize = true;
            lblJogo.BackColor = Color.Transparent;
            lblJogo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJogo.ForeColor = SystemColors.WindowText;
            lblJogo.Location = new Point(604, 356);
            lblJogo.Name = "lblJogo";
            lblJogo.Size = new Size(203, 30);
            lblJogo.TabIndex = 11;
            lblJogo.Text = "Modelo é para Jogo:";
            // 
            // panelBackground
            // 
            panelBackground._cornerRadius = 0;
            panelBackground.Angle = 45F;
            panelBackground.BackColor = Color.White;
            panelBackground.BottomColor = SystemColors.AppWorkspace;
            panelBackground.Controls.Add(roundedPanel3);
            panelBackground.Controls.Add(roundedPanel2);
            panelBackground.Controls.Add(roundedPanel1);
            panelBackground.Controls.Add(cbModeloJogo);
            panelBackground.Controls.Add(gradientPanel1);
            panelBackground.Controls.Add(lblJogo);
            panelBackground.Controls.Add(dtpDataEntrega);
            panelBackground.Controls.Add(lblDeadline);
            panelBackground.Controls.Add(cbTipodeModelo);
            panelBackground.Controls.Add(btnAdicionarPedido);
            panelBackground.Controls.Add(lblTipoModelo);
            panelBackground.Controls.Add(lblContato);
            panelBackground.Controls.Add(lblDescricao);
            panelBackground.Controls.Add(label1);
            panelBackground.CornerRadius = 0;
            panelBackground.Dock = DockStyle.Fill;
            panelBackground.Location = new Point(0, 0);
            panelBackground.Name = "panelBackground";
            panelBackground.Size = new Size(1367, 761);
            panelBackground.TabIndex = 1;
            panelBackground.TopColor = SystemColors.ControlLight;
            // 
            // roundedPanel3
            // 
            roundedPanel3.Controls.Add(txtDescricao);
            roundedPanel3.CornerRadius = 20;
            roundedPanel3.Location = new Point(199, 281);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(1147, 44);
            roundedPanel3.TabIndex = 30;
            // 
            // roundedPanel2
            // 
            roundedPanel2.Controls.Add(txtEmail);
            roundedPanel2.CornerRadius = 20;
            roundedPanel2.Location = new Point(199, 222);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(1147, 44);
            roundedPanel2.TabIndex = 29;
            // 
            // roundedPanel1
            // 
            roundedPanel1.Controls.Add(txtNome);
            roundedPanel1.CornerRadius = 20;
            roundedPanel1.Location = new Point(199, 162);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(1147, 44);
            roundedPanel1.TabIndex = 28;
            // 
            // cbModeloJogo
            // 
            cbModeloJogo.FlatStyle = FlatStyle.System;
            cbModeloJogo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbModeloJogo.FormattingEnabled = true;
            cbModeloJogo.Items.AddRange(new object[] { "Sim", "Não" });
            cbModeloJogo.Location = new Point(821, 353);
            cbModeloJogo.Name = "cbModeloJogo";
            cbModeloJogo.Size = new Size(149, 38);
            cbModeloJogo.TabIndex = 27;
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
            gradientPanel1.Size = new Size(1367, 101);
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
            ClientSize = new Size(1367, 761);
            Controls.Add(panelBackground);
            Name = "frmFormulario";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulário";
            panelBackground.ResumeLayout(false);
            panelBackground.PerformLayout();
            roundedPanel3.ResumeLayout(false);
            roundedPanel3.PerformLayout();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNome;
        private Label label1;
        private Label lblDescricao;
        private Label lblContato;
        private TextBox txtDescricao;
        private TextBox txtEmail;
        private Label lblTipoModelo;
        private Button btnAdicionarPedido;
        private ComboBox cbTipodeModelo;
        private Label lblDeadline;
        private DateTimePicker dtpDataEntrega;
        private Label lblJogo;
        private GPanel.GradientPanel panelBackground;
        private GPanel.GradientPanel gradientPanel1;
        private Label label7;
        private ComboBox cbModeloJogo;
        private RPanel.RoundedPanel roundedPanel3;
        private RPanel.RoundedPanel roundedPanel2;
        private RPanel.RoundedPanel roundedPanel1;
    }
}
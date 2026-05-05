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
            cbModeloJogo = new ComboBox();
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
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.BackColor = Color.Transparent;
            lblDescricao.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescricao.ForeColor = SystemColors.WindowText;
            lblDescricao.Location = new Point(12, 281);
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
            lblContato.Location = new Point(12, 226);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(98, 30);
            lblContato.TabIndex = 3;
            lblContato.Text = "Contato :";
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
            // lblTipoModelo
            // 
            lblTipoModelo.AutoSize = true;
            lblTipoModelo.BackColor = Color.Transparent;
            lblTipoModelo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipoModelo.ForeColor = SystemColors.WindowText;
            lblTipoModelo.Location = new Point(12, 336);
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
            // lblDeadline
            // 
            lblDeadline.AutoSize = true;
            lblDeadline.BackColor = Color.Transparent;
            lblDeadline.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDeadline.ForeColor = SystemColors.WindowText;
            lblDeadline.Location = new Point(12, 391);
            lblDeadline.Name = "lblDeadline";
            lblDeadline.Size = new Size(174, 30);
            lblDeadline.TabIndex = 9;
            lblDeadline.Text = "Data de Entrega :";
            // 
            // dtpDataEntrega
            // 
            dtpDataEntrega.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDataEntrega.Location = new Point(212, 387);
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
            lblJogo.Location = new Point(12, 444);
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
            panelBackground.Controls.Add(cbModeloJogo);
            panelBackground.Controls.Add(gradientPanel1);
            panelBackground.Controls.Add(lblJogo);
            panelBackground.Controls.Add(dtpDataEntrega);
            panelBackground.Controls.Add(lblDeadline);
            panelBackground.Controls.Add(cbTipodeModelo);
            panelBackground.Controls.Add(btnAdicionarPedido);
            panelBackground.Controls.Add(lblTipoModelo);
            panelBackground.Controls.Add(txtEmail);
            panelBackground.Controls.Add(txtDescricao);
            panelBackground.Controls.Add(lblContato);
            panelBackground.Controls.Add(lblDescricao);
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
            // cbModeloJogo
            // 
            cbModeloJogo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbModeloJogo.FormattingEnabled = true;
            cbModeloJogo.Items.AddRange(new object[] { "Sim", "Não" });
            cbModeloJogo.Location = new Point(212, 441);
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
    }
}
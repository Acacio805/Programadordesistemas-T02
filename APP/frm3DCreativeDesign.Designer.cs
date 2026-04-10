namespace APP
{
    partial class frm3DCreativeDesign
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm3DCreativeDesign));
            panelPedido = new Panel();
            txtNome = new TextBox();
            txtTipo = new TextBox();
            btnDetalhes = new Button();
            labelPedidos = new Label();
            flpanelPedidosNovos = new FlowLayoutPanel();
            butaoTeste = new PictureBox();
            panelLeft = new GPanel.GradientPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnTrash = new PictureBox();
            btnSettings = new PictureBox();
            btnAdd = new PictureBox();
            panelLeftWhite = new Panel();
            pictureBox2 = new PictureBox();
            panelBackground = new GPanel.GradientPanel();
            flpanelPedidosConcluidos = new FlowLayoutPanel();
            label1 = new Label();
            gradientPanel1 = new GPanel.GradientPanel();
            button1 = new Button();
            button2 = new Button();
            panelPedido.SuspendLayout();
            flpanelPedidosNovos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)butaoTeste).BeginInit();
            panelLeft.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnTrash).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSettings).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelBackground.SuspendLayout();
            flpanelPedidosConcluidos.SuspendLayout();
            SuspendLayout();
            // 
            // panelPedido
            // 
            resources.ApplyResources(panelPedido, "panelPedido");
            panelPedido.BackColor = Color.White;
            panelPedido.Controls.Add(button2);
            panelPedido.Controls.Add(button1);
            panelPedido.Controls.Add(txtNome);
            panelPedido.Controls.Add(txtTipo);
            panelPedido.Controls.Add(btnDetalhes);
            panelPedido.Name = "panelPedido";
            // 
            // txtNome
            // 
            resources.ApplyResources(txtNome, "txtNome");
            txtNome.Name = "txtNome";
            txtNome.ReadOnly = true;
            // 
            // txtTipo
            // 
            resources.ApplyResources(txtTipo, "txtTipo");
            txtTipo.Name = "txtTipo";
            txtTipo.ReadOnly = true;
            // 
            // btnDetalhes
            // 
            resources.ApplyResources(btnDetalhes, "btnDetalhes");
            btnDetalhes.BackColor = Color.LightGray;
            btnDetalhes.Cursor = Cursors.Hand;
            btnDetalhes.ForeColor = SystemColors.ButtonShadow;
            btnDetalhes.Image = Properties.Resources.more_horiz_24dp_FFFFFF_FILL0_wght400_GRAD0_opsz24;
            btnDetalhes.Name = "btnDetalhes";
            btnDetalhes.UseVisualStyleBackColor = false;
            btnDetalhes.Click += btnDetalhes_Click;
            // 
            // labelPedidos
            // 
            resources.ApplyResources(labelPedidos, "labelPedidos");
            labelPedidos.Name = "labelPedidos";
            // 
            // flpanelPedidosNovos
            // 
            resources.ApplyResources(flpanelPedidosNovos, "flpanelPedidosNovos");
            flpanelPedidosNovos.BackColor = Color.LightGray;
            flpanelPedidosNovos.Controls.Add(labelPedidos);
            flpanelPedidosNovos.Controls.Add(panelPedido);
            flpanelPedidosNovos.Controls.Add(butaoTeste);
            flpanelPedidosNovos.Name = "flpanelPedidosNovos";
            // 
            // butaoTeste
            // 
            resources.ApplyResources(butaoTeste, "butaoTeste");
            butaoTeste.BackColor = Color.Transparent;
            butaoTeste.Cursor = Cursors.Hand;
            butaoTeste.ErrorImage = Properties.Resources.add_64dp_FFFFFF_FILL0_wght400_GRAD0_opsz48;
            butaoTeste.Image = Properties.Resources.add_64dp_FFFFFF_FILL0_wght400_GRAD0_opsz48;
            butaoTeste.InitialImage = Properties.Resources.settings_64dp_FFFFFF_FILL0_wght400_GRAD0_opsz48;
            butaoTeste.Name = "butaoTeste";
            butaoTeste.TabStop = false;
            butaoTeste.Click += butaoTeste_Click;
            // 
            // panelLeft
            // 
            panelLeft._cornerRadius = 0;
            resources.ApplyResources(panelLeft, "panelLeft");
            panelLeft.Angle = 90F;
            panelLeft.BackColor = Color.White;
            panelLeft.BottomColor = Color.Purple;
            panelLeft.Controls.Add(flowLayoutPanel1);
            panelLeft.Controls.Add(panelLeftWhite);
            panelLeft.Controls.Add(pictureBox2);
            panelLeft.CornerRadius = 0;
            panelLeft.Name = "panelLeft";
            panelLeft.TopColor = Color.DarkBlue;
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(flowLayoutPanel1, "flowLayoutPanel1");
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Controls.Add(btnTrash);
            flowLayoutPanel1.Controls.Add(btnSettings);
            flowLayoutPanel1.Controls.Add(btnAdd);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // btnTrash
            // 
            resources.ApplyResources(btnTrash, "btnTrash");
            btnTrash.BackColor = Color.Transparent;
            btnTrash.Cursor = Cursors.Hand;
            btnTrash.ErrorImage = Properties.Resources.add_64dp_FFFFFF_FILL0_wght400_GRAD0_opsz48;
            btnTrash.Image = Properties.Resources.delete_64dp_FFFFFF_FILL0_wght400_GRAD0_opsz48;
            btnTrash.InitialImage = Properties.Resources.settings_64dp_FFFFFF_FILL0_wght400_GRAD0_opsz48;
            btnTrash.Name = "btnTrash";
            btnTrash.TabStop = false;
            btnTrash.MouseHover += btnTrash_MouseHover;
            // 
            // btnSettings
            // 
            resources.ApplyResources(btnSettings, "btnSettings");
            btnSettings.BackColor = Color.Transparent;
            btnSettings.Cursor = Cursors.Hand;
            btnSettings.ErrorImage = Properties.Resources.add_64dp_FFFFFF_FILL0_wght400_GRAD0_opsz48;
            btnSettings.Image = Properties.Resources.settings_64dp_FFFFFF_FILL0_wght400_GRAD0_opsz48;
            btnSettings.InitialImage = Properties.Resources.settings_64dp_FFFFFF_FILL0_wght400_GRAD0_opsz48;
            btnSettings.Name = "btnSettings";
            btnSettings.TabStop = false;
            // 
            // btnAdd
            // 
            resources.ApplyResources(btnAdd, "btnAdd");
            btnAdd.BackColor = Color.Transparent;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.ErrorImage = Properties.Resources.add_64dp_FFFFFF_FILL0_wght400_GRAD0_opsz48;
            btnAdd.Image = Properties.Resources.add_64dp_FFFFFF_FILL0_wght400_GRAD0_opsz48;
            btnAdd.InitialImage = Properties.Resources.settings_64dp_FFFFFF_FILL0_wght400_GRAD0_opsz48;
            btnAdd.Name = "btnAdd";
            btnAdd.TabStop = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // panelLeftWhite
            // 
            resources.ApplyResources(panelLeftWhite, "panelLeftWhite");
            panelLeftWhite.Name = "panelLeftWhite";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.logo;
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // panelBackground
            // 
            panelBackground._cornerRadius = 20;
            resources.ApplyResources(panelBackground, "panelBackground");
            panelBackground.Angle = 45F;
            panelBackground.BackColor = Color.White;
            panelBackground.BottomColor = Color.Purple;
            panelBackground.Controls.Add(flpanelPedidosConcluidos);
            panelBackground.Controls.Add(gradientPanel1);
            panelBackground.Controls.Add(flpanelPedidosNovos);
            panelBackground.CornerRadius = 20;
            panelBackground.Name = "panelBackground";
            panelBackground.TopColor = Color.Aqua;
            // 
            // flpanelPedidosConcluidos
            // 
            resources.ApplyResources(flpanelPedidosConcluidos, "flpanelPedidosConcluidos");
            flpanelPedidosConcluidos.BackColor = Color.LightGray;
            flpanelPedidosConcluidos.Controls.Add(label1);
            flpanelPedidosConcluidos.Name = "flpanelPedidosConcluidos";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // gradientPanel1
            // 
            gradientPanel1._cornerRadius = 0;
            resources.ApplyResources(gradientPanel1, "gradientPanel1");
            gradientPanel1.Angle = 0F;
            gradientPanel1.BackColor = Color.White;
            gradientPanel1.BottomColor = Color.Purple;
            gradientPanel1.CornerRadius = 0;
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.TopColor = Color.Navy;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.BackColor = Color.DarkGreen;
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = SystemColors.ButtonShadow;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.BackColor = Color.Maroon;
            button2.Cursor = Cursors.Hand;
            button2.ForeColor = SystemColors.ButtonShadow;
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = false;
            // 
            // frm3DCreativeDesign
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelBackground);
            Controls.Add(panelLeft);
            Name = "frm3DCreativeDesign";
            WindowState = FormWindowState.Maximized;
            panelPedido.ResumeLayout(false);
            panelPedido.PerformLayout();
            flpanelPedidosNovos.ResumeLayout(false);
            flpanelPedidosNovos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)butaoTeste).EndInit();
            panelLeft.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnTrash).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSettings).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelBackground.ResumeLayout(false);
            flpanelPedidosConcluidos.ResumeLayout(false);
            flpanelPedidosConcluidos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelPedido;
        private TextBox txtNome;
        private TextBox txtTipo;
        private Label labelPedidos;
        private FlowLayoutPanel flpanelPedidosNovos;
        private GPanel.GradientPanel panelLeft;
        private PictureBox btnAdd;
        private PictureBox btnTrash;
        private PictureBox btnSettings;
        private GPanel.GradientPanel panelBackground;
        private GPanel.GradientPanel gradientPanel1;
        private PictureBox pictureBox2;
        private Panel panelLeftWhite;
        private FlowLayoutPanel flpanelPedidosConcluidos;
        private Label label1;
        private Button btnDetalhes;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox butaoTeste;
        private Button button2;
        private Button button1;
    }
}

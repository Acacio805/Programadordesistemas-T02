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
            panelP = new Panel();
            label2 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            txtNome = new TextBox();
            txtTipo = new TextBox();
            btn = new Button();
            labelPedidos = new Label();
            butaoRecarregar = new PictureBox();
            panelLeft = new GPanel.GradientPanel();
            btnTrash = new PictureBox();
            btnSettings = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnAdd = new PictureBox();
            panelLeftWhite = new Panel();
            pictureBox2 = new PictureBox();
            panelBackground = new GPanel.GradientPanel();
            flpanelPedidosNovos = new Rflp.RoundedFlowLayoutPanel();
            flpanelPedidosAndamento = new Rflp.RoundedFlowLayoutPanel();
            labelPedidosAndamento = new Label();
            gradientPanel1 = new GPanel.GradientPanel();
            btnPesquisar = new PictureBox();
            txtPesquisar = new Rtxt.RoundedTextBox();
            flpanelPedidosConcluidos = new Rflp.RoundedFlowLayoutPanel();
            label1 = new Label();
            flpanelPedidosAtrasados = new Rflp.RoundedFlowLayoutPanel();
            label3 = new Label();
            panelP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)butaoRecarregar).BeginInit();
            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnTrash).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSettings).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelBackground.SuspendLayout();
            flpanelPedidosNovos.SuspendLayout();
            flpanelPedidosAndamento.SuspendLayout();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnPesquisar).BeginInit();
            flpanelPedidosConcluidos.SuspendLayout();
            flpanelPedidosAtrasados.SuspendLayout();
            SuspendLayout();
            // 
            // panelP
            // 
            resources.ApplyResources(panelP, "panelP");
            panelP.BackColor = Color.White;
            panelP.Controls.Add(label2);
            panelP.Controls.Add(textBox1);
            panelP.Controls.Add(button2);
            panelP.Controls.Add(button1);
            panelP.Controls.Add(txtNome);
            panelP.Controls.Add(txtTipo);
            panelP.Controls.Add(btn);
            panelP.Name = "panelP";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.DarkRed;
            label2.Name = "label2";
            label2.UseMnemonic = false;
            // 
            // textBox1
            // 
            resources.ApplyResources(textBox1, "textBox1");
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.ForeColor = Color.DimGray;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.BackColor = Color.Maroon;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 0);
            button2.ForeColor = SystemColors.ButtonShadow;
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.BackColor = Color.DarkGreen;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.ForeColor = SystemColors.MenuHighlight;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // txtNome
            // 
            resources.ApplyResources(txtNome, "txtNome");
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Name = "txtNome";
            txtNome.ReadOnly = true;
            // 
            // txtTipo
            // 
            resources.ApplyResources(txtTipo, "txtTipo");
            txtTipo.BorderStyle = BorderStyle.None;
            txtTipo.Name = "txtTipo";
            txtTipo.ReadOnly = true;
            // 
            // btn
            // 
            resources.ApplyResources(btn, "btn");
            btn.BackColor = Color.LightGray;
            btn.Cursor = Cursors.Hand;
            btn.FlatAppearance.BorderSize = 0;
            btn.ForeColor = SystemColors.MenuHighlight;
            btn.Image = Properties.Resources.more_horiz_24dp_FFFFFF_FILL0_wght400_GRAD0_opsz24;
            btn.Name = "btn";
            btn.UseVisualStyleBackColor = false;
            // 
            // labelPedidos
            // 
            resources.ApplyResources(labelPedidos, "labelPedidos");
            labelPedidos.Name = "labelPedidos";
            // 
            // butaoRecarregar
            // 
            resources.ApplyResources(butaoRecarregar, "butaoRecarregar");
            butaoRecarregar.BackColor = Color.Transparent;
            butaoRecarregar.Cursor = Cursors.Hand;
            butaoRecarregar.ErrorImage = Properties.Resources.add_64dp_FFFFFF_FILL0_wght400_GRAD0_opsz48;
            butaoRecarregar.Image = Properties.Resources.refresh_64dp_FFFFFF_FILL0_wght400_GRAD0_opsz48;
            butaoRecarregar.InitialImage = Properties.Resources.settings_64dp_FFFFFF_FILL0_wght400_GRAD0_opsz48;
            butaoRecarregar.Name = "butaoRecarregar";
            butaoRecarregar.TabStop = false;
            butaoRecarregar.Click += butaoRecarregar_Click;
            // 
            // panelLeft
            // 
            panelLeft._cornerRadius = 0;
            resources.ApplyResources(panelLeft, "panelLeft");
            panelLeft.Angle = 90F;
            panelLeft.BackColor = Color.White;
            panelLeft.BottomColor = Color.Purple;
            panelLeft.Controls.Add(btnTrash);
            panelLeft.Controls.Add(btnSettings);
            panelLeft.Controls.Add(flowLayoutPanel1);
            panelLeft.Controls.Add(panelLeftWhite);
            panelLeft.Controls.Add(pictureBox2);
            panelLeft.CornerRadius = 0;
            panelLeft.Name = "panelLeft";
            panelLeft.TopColor = Color.DarkBlue;
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
            // flowLayoutPanel1
            // 
            resources.ApplyResources(flowLayoutPanel1, "flowLayoutPanel1");
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Controls.Add(butaoRecarregar);
            flowLayoutPanel1.Controls.Add(btnAdd);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
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
            panelBackground.Controls.Add(flpanelPedidosAtrasados);
            panelBackground.Controls.Add(flpanelPedidosNovos);
            panelBackground.Controls.Add(flpanelPedidosAndamento);
            panelBackground.Controls.Add(panelP);
            panelBackground.Controls.Add(gradientPanel1);
            panelBackground.Controls.Add(flpanelPedidosConcluidos);
            panelBackground.CornerRadius = 20;
            panelBackground.Name = "panelBackground";
            panelBackground.TopColor = Color.Aqua;
            // 
            // flpanelPedidosNovos
            // 
            resources.ApplyResources(flpanelPedidosNovos, "flpanelPedidosNovos");
            flpanelPedidosNovos.BackColor = SystemColors.Control;
            flpanelPedidosNovos.BorderRadius = 20;
            flpanelPedidosNovos.Controls.Add(labelPedidos);
            flpanelPedidosNovos.Name = "flpanelPedidosNovos";
            // 
            // flpanelPedidosAndamento
            // 
            resources.ApplyResources(flpanelPedidosAndamento, "flpanelPedidosAndamento");
            flpanelPedidosAndamento.BackColor = SystemColors.Control;
            flpanelPedidosAndamento.BorderRadius = 20;
            flpanelPedidosAndamento.Controls.Add(labelPedidosAndamento);
            flpanelPedidosAndamento.Name = "flpanelPedidosAndamento";
            // 
            // labelPedidosAndamento
            // 
            resources.ApplyResources(labelPedidosAndamento, "labelPedidosAndamento");
            labelPedidosAndamento.Name = "labelPedidosAndamento";
            // 
            // gradientPanel1
            // 
            gradientPanel1._cornerRadius = 0;
            resources.ApplyResources(gradientPanel1, "gradientPanel1");
            gradientPanel1.Angle = 0F;
            gradientPanel1.BackColor = Color.White;
            gradientPanel1.BottomColor = Color.Purple;
            gradientPanel1.Controls.Add(btnPesquisar);
            gradientPanel1.Controls.Add(txtPesquisar);
            gradientPanel1.CornerRadius = 0;
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.TopColor = Color.Navy;
            // 
            // btnPesquisar
            // 
            resources.ApplyResources(btnPesquisar, "btnPesquisar");
            btnPesquisar.BackColor = Color.Transparent;
            btnPesquisar.Cursor = Cursors.Hand;
            btnPesquisar.Image = Properties.Resources.search_64dp_FFFFFF_FILL0_wght400_GRAD0_opsz48;
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.TabStop = false;
            // 
            // txtPesquisar
            // 
            resources.ApplyResources(txtPesquisar, "txtPesquisar");
            txtPesquisar.BackColor = Color.White;
            txtPesquisar.Name = "txtPesquisar";
            // 
            // flpanelPedidosConcluidos
            // 
            resources.ApplyResources(flpanelPedidosConcluidos, "flpanelPedidosConcluidos");
            flpanelPedidosConcluidos.BackColor = SystemColors.Control;
            flpanelPedidosConcluidos.BorderRadius = 20;
            flpanelPedidosConcluidos.Controls.Add(label1);
            flpanelPedidosConcluidos.Name = "flpanelPedidosConcluidos";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // flpanelPedidosAtrasados
            // 
            resources.ApplyResources(flpanelPedidosAtrasados, "flpanelPedidosAtrasados");
            flpanelPedidosAtrasados.BackColor = SystemColors.Control;
            flpanelPedidosAtrasados.BorderRadius = 20;
            flpanelPedidosAtrasados.Controls.Add(label3);
            flpanelPedidosAtrasados.Name = "flpanelPedidosAtrasados";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // frm3DCreativeDesign
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelBackground);
            Controls.Add(panelLeft);
            Name = "frm3DCreativeDesign";
            WindowState = FormWindowState.Maximized;
            panelP.ResumeLayout(false);
            panelP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)butaoRecarregar).EndInit();
            panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnTrash).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSettings).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelBackground.ResumeLayout(false);
            flpanelPedidosNovos.ResumeLayout(false);
            flpanelPedidosNovos.PerformLayout();
            flpanelPedidosAndamento.ResumeLayout(false);
            flpanelPedidosAndamento.PerformLayout();
            gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnPesquisar).EndInit();
            flpanelPedidosConcluidos.ResumeLayout(false);
            flpanelPedidosConcluidos.PerformLayout();
            flpanelPedidosAtrasados.ResumeLayout(false);
            flpanelPedidosAtrasados.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelP;
        private TextBox txtNome;
        private TextBox txtTipo;
        private Label labelPedidos;
        private GPanel.GradientPanel panelLeft;
        private PictureBox btnAdd;
        private PictureBox btnTrash;
        private PictureBox btnSettings;
        private GPanel.GradientPanel panelBackground;
        private GPanel.GradientPanel gradientPanel1;
        private PictureBox pictureBox2;
        private Panel panelLeftWhite;
        private Label label1;
        private Button btn;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox butaoRecarregar;
        private Button button2;
        private Button button1;
        private Rtxt.RoundedTextBox roundedTextBox1;
        private Rtxt.RoundedTextBox txtPesquisar;
        private PictureBox btnPesquisar;
        private Rflp.RoundedFlowLayoutPanel flpanelPedidosNovos;
        private Rflp.RoundedFlowLayoutPanel flpanelPedidosConcluidos;
        private TextBox textBox1;
        private Rflp.RoundedFlowLayoutPanel flpanelPedidosAndamento;
        private Label labelPedidosAndamento;
        private Label label2;
        private Rflp.RoundedFlowLayoutPanel flpanelPedidosAtrasados;
        private Label label3;
    }
}

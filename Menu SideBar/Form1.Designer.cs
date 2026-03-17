namespace Menu_SideBar
{
    partial class frmSidebar
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.panelHome = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConfig = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSobre = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.sidebar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.panelHome.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panelHome);
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.ForeColor = System.Drawing.Color.White;
            this.sidebar.Location = new System.Drawing.Point(1, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(283, 0);
            this.sidebar.MinimumSize = new System.Drawing.Size(74, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(283, 695);
            this.sidebar.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.menuButton);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 117);
            this.panel2.TabIndex = 0;
            // 
            // menuButton
            // 
            this.menuButton.Image = global::Menu_SideBar.Properties.Resources.menu_64dp_FFFFFF_FILL0_wght400_GRAD0_opsz48;
            this.menuButton.Location = new System.Drawing.Point(3, 20);
            this.menuButton.MaximumSize = new System.Drawing.Size(64, 64);
            this.menuButton.MinimumSize = new System.Drawing.Size(32, 32);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(64, 64);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.menuButton.TabIndex = 0;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // panelHome
            // 
            this.panelHome.Controls.Add(this.btnHome);
            this.panelHome.Location = new System.Drawing.Point(3, 126);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(274, 54);
            this.panelHome.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Image = global::Menu_SideBar.Properties.Resources.home_32dp_FFFFFF_FILL0_wght400_GRAD0_opsz40;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(-18, -14);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(311, 84);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "                    Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnConfig);
            this.panel1.Location = new System.Drawing.Point(3, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 54);
            this.panel1.TabIndex = 3;
            // 
            // btnConfig
            // 
            this.btnConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfig.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.Image = global::Menu_SideBar.Properties.Resources.settings_32dp_FFFFFF_FILL0_wght400_GRAD0_opsz40;
            this.btnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.Location = new System.Drawing.Point(-18, -14);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnConfig.Size = new System.Drawing.Size(311, 84);
            this.btnConfig.TabIndex = 2;
            this.btnConfig.Text = "                    Configurações";
            this.btnConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAjuda);
            this.panel3.Location = new System.Drawing.Point(3, 246);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(274, 54);
            this.panel3.TabIndex = 4;
            // 
            // btnAjuda
            // 
            this.btnAjuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjuda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjuda.Image = global::Menu_SideBar.Properties.Resources.help_center_32dp_FFFFFF_FILL0_wght400_GRAD0_opsz40;
            this.btnAjuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjuda.Location = new System.Drawing.Point(-18, -14);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnAjuda.Size = new System.Drawing.Size(311, 84);
            this.btnAjuda.TabIndex = 2;
            this.btnAjuda.Text = "                    Ajuda";
            this.btnAjuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjuda.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSobre);
            this.panel4.Location = new System.Drawing.Point(3, 306);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(274, 54);
            this.panel4.TabIndex = 5;
            // 
            // btnSobre
            // 
            this.btnSobre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSobre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobre.Image = global::Menu_SideBar.Properties.Resources.info_32dp_FFFFFF_FILL0_wght400_GRAD0_opsz40;
            this.btnSobre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSobre.Location = new System.Drawing.Point(-18, -14);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnSobre.Size = new System.Drawing.Size(311, 84);
            this.btnSobre.TabIndex = 2;
            this.btnSobre.Text = "                    Sobre";
            this.btnSobre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSobre.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button1);
            this.panel5.Location = new System.Drawing.Point(3, 366);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(274, 54);
            this.panel5.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Menu_SideBar.Properties.Resources.forms_add_on_32dp_FFFFFF_FILL0_wght400_GRAD0_opsz40;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-18, -14);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(311, 84);
            this.button1.TabIndex = 2;
            this.button1.Text = "                    Formulario";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 5;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // frmSidebar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 695);
            this.Controls.Add(this.sidebar);
            this.Name = "frmSidebar";
            this.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.Text = "SideBar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.sidebar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.panelHome.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSobre;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button1;
    }
}


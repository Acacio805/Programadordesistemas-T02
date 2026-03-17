namespace testando_showhide
{
    partial class frmShowHide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowHide));
            this.pbLogotipo = new System.Windows.Forms.PictureBox();
            this.btnMostrarLogo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogotipo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogotipo
            // 
            this.pbLogotipo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogotipo.Image")));
            this.pbLogotipo.Location = new System.Drawing.Point(816, 181);
            this.pbLogotipo.Name = "pbLogotipo";
            this.pbLogotipo.Size = new System.Drawing.Size(344, 243);
            this.pbLogotipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogotipo.TabIndex = 0;
            this.pbLogotipo.TabStop = false;
            this.pbLogotipo.Click += new System.EventHandler(this.pbLogotipo_Click);
            // 
            // btnMostrarLogo
            // 
            this.btnMostrarLogo.BackColor = System.Drawing.Color.DarkBlue;
            this.btnMostrarLogo.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarLogo.ForeColor = System.Drawing.Color.LightCoral;
            this.btnMostrarLogo.Location = new System.Drawing.Point(900, 521);
            this.btnMostrarLogo.Name = "btnMostrarLogo";
            this.btnMostrarLogo.Size = new System.Drawing.Size(177, 81);
            this.btnMostrarLogo.TabIndex = 1;
            this.btnMostrarLogo.Text = "Clique";
            this.btnMostrarLogo.UseVisualStyleBackColor = false;
            this.btnMostrarLogo.Click += new System.EventHandler(this.btnMostrarLogo_Click);
            // 
            // frmShowHide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1904, 1061);
            this.Controls.Add(this.btnMostrarLogo);
            this.Controls.Add(this.pbLogotipo);
            this.Name = "frmShowHide";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show e Hide Control";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pbLogotipo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogotipo;
        private System.Windows.Forms.Button btnMostrarLogo;
    }
}


namespace arrayunidirecional_vetor
{
    partial class frmVetor
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
            panelTopo = new Panel();
            lblTopo = new Label();
            panelBase = new Panel();
            lblBase = new Label();
            btnTestar = new Button();
            panelTopo.SuspendLayout();
            panelBase.SuspendLayout();
            SuspendLayout();
            // 
            // panelTopo
            // 
            panelTopo.BackColor = Color.Navy;
            panelTopo.Controls.Add(lblTopo);
            panelTopo.Dock = DockStyle.Top;
            panelTopo.Location = new Point(0, 0);
            panelTopo.Name = "panelTopo";
            panelTopo.Size = new Size(800, 104);
            panelTopo.TabIndex = 0;
            // 
            // lblTopo
            // 
            lblTopo.AutoSize = true;
            lblTopo.Font = new Font("Nirmala Text", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTopo.ForeColor = Color.White;
            lblTopo.Location = new Point(142, 33);
            lblTopo.Name = "lblTopo";
            lblTopo.Size = new Size(477, 37);
            lblTopo.TabIndex = 0;
            lblTopo.Text = "Para testar o array unidirecional - vetor";
            // 
            // panelBase
            // 
            panelBase.BackColor = Color.Navy;
            panelBase.Controls.Add(lblBase);
            panelBase.Dock = DockStyle.Bottom;
            panelBase.Location = new Point(0, 352);
            panelBase.Name = "panelBase";
            panelBase.Size = new Size(800, 98);
            panelBase.TabIndex = 1;
            // 
            // lblBase
            // 
            lblBase.AutoSize = true;
            lblBase.Font = new Font("Nirmala Text", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBase.ForeColor = Color.White;
            lblBase.Location = new Point(253, 26);
            lblBase.Name = "lblBase";
            lblBase.Size = new Size(286, 37);
            lblBase.TabIndex = 1;
            lblBase.Text = "Clique no botão acima";
            // 
            // btnTestar
            // 
            btnTestar.BackColor = Color.RoyalBlue;
            btnTestar.Font = new Font("Roboto", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTestar.ForeColor = Color.White;
            btnTestar.Location = new Point(218, 154);
            btnTestar.Name = "btnTestar";
            btnTestar.Size = new Size(336, 134);
            btnTestar.TabIndex = 2;
            btnTestar.Text = "OK";
            btnTestar.UseVisualStyleBackColor = false;
            btnTestar.Click += btnTestar_Click;
            // 
            // frmVetor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTestar);
            Controls.Add(panelBase);
            Controls.Add(panelTopo);
            Name = "frmVetor";
            Text = "Vetor";
            panelTopo.ResumeLayout(false);
            panelTopo.PerformLayout();
            panelBase.ResumeLayout(false);
            panelBase.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTopo;
        private Panel panelBase;
        private Button btnTestar;
        private Label lblTopo;
        private Label lblBase;
    }
}

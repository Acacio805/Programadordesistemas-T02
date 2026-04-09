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
            panelBackground = new GPanel.GradientPanel();
            label2 = new Label();
            label1 = new Label();
            txtNome = new TextBox();
            panelBackground.SuspendLayout();
            SuspendLayout();
            // 
            // panelBackground
            // 
            panelBackground.Angle = 45F;
            panelBackground.BottomColor = Color.FromArgb(0, 192, 0);
            panelBackground.Controls.Add(label2);
            panelBackground.Controls.Add(label1);
            panelBackground.Controls.Add(txtNome);
            panelBackground.Dock = DockStyle.Fill;
            panelBackground.Location = new Point(0, 0);
            panelBackground.Name = "panelBackground";
            panelBackground.Size = new Size(984, 761);
            panelBackground.TabIndex = 1;
            panelBackground.TopColor = Color.Cyan;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(12, 106);
            label2.Name = "label2";
            label2.Size = new Size(81, 30);
            label2.TabIndex = 2;
            label2.Text = "Nome :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(81, 30);
            label1.TabIndex = 1;
            label1.Text = "Nome :";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(212, 42);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(708, 35);
            txtNome.TabIndex = 0;
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
            ResumeLayout(false);
        }

        #endregion
        private GPanel.GradientPanel panelBackground;
        private TextBox txtNome;
        private Label label1;
        private Label label2;
    }
}
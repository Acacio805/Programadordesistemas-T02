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
            panelTop = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panelPedidos = new Panel();
            panelPedido = new Panel();
            txtNome = new TextBox();
            cbComecar = new CheckBox();
            txtTipo = new TextBox();
            labelPedidos = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelPedido.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            resources.ApplyResources(panelTop, "panelTop");
            panelTop.BackColor = Color.Navy;
            panelTop.Controls.Add(pictureBox2);
            panelTop.Controls.Add(pictureBox1);
            panelTop.Name = "panelTop";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Image = Properties.Resources.Logotipo;
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // panelPedidos
            // 
            resources.ApplyResources(panelPedidos, "panelPedidos");
            panelPedidos.BackColor = Color.DarkMagenta;
            panelPedidos.Name = "panelPedidos";
            // 
            // panelPedido
            // 
            resources.ApplyResources(panelPedido, "panelPedido");
            panelPedido.BackColor = Color.White;
            panelPedido.Controls.Add(txtNome);
            panelPedido.Controls.Add(cbComecar);
            panelPedido.Controls.Add(txtTipo);
            panelPedido.Name = "panelPedido";
            // 
            // txtNome
            // 
            resources.ApplyResources(txtNome, "txtNome");
            txtNome.Name = "txtNome";
            txtNome.ReadOnly = true;
            // 
            // cbComecar
            // 
            resources.ApplyResources(cbComecar, "cbComecar");
            cbComecar.ForeColor = Color.Black;
            cbComecar.Name = "cbComecar";
            cbComecar.UseVisualStyleBackColor = true;
            // 
            // txtTipo
            // 
            resources.ApplyResources(txtTipo, "txtTipo");
            txtTipo.Name = "txtTipo";
            txtTipo.ReadOnly = true;
            // 
            // labelPedidos
            // 
            resources.ApplyResources(labelPedidos, "labelPedidos");
            labelPedidos.Name = "labelPedidos";
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(flowLayoutPanel1, "flowLayoutPanel1");
            flowLayoutPanel1.BackColor = Color.LightGray;
            flowLayoutPanel1.Controls.Add(labelPedidos);
            flowLayoutPanel1.Controls.Add(panelPedido);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // frm3DCreativeDesign
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panelPedidos);
            Controls.Add(panelTop);
            Name = "frm3DCreativeDesign";
            FormClosed += frm3DCreativeDesign_FormClosed;
            panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelPedido.ResumeLayout(false);
            panelPedido.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelTop;
        private Panel panelPedidos;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel panelPedido;
        private TextBox txtNome;
        private CheckBox cbComecar;
        private TextBox txtTipo;
        private Label labelPedidos;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}

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
            cbComecar = new CheckBox();
            txtTipo = new TextBox();
            btnCriarPedido = new Button();
            panelTop = new Panel();
            panelPedidos = new Panel();
            panelPedido.SuspendLayout();
            panelPedidos.SuspendLayout();
            SuspendLayout();
            // 
            // panelPedido
            // 
            resources.ApplyResources(panelPedido, "panelPedido");
            panelPedido.BackColor = Color.Navy;
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
            cbComecar.ForeColor = Color.White;
            cbComecar.Name = "cbComecar";
            cbComecar.UseVisualStyleBackColor = true;
            cbComecar.CheckedChanged += cbComecar_CheckedChanged;
            // 
            // txtTipo
            // 
            resources.ApplyResources(txtTipo, "txtTipo");
            txtTipo.Name = "txtTipo";
            txtTipo.ReadOnly = true;
            // 
            // btnCriarPedido
            // 
            resources.ApplyResources(btnCriarPedido, "btnCriarPedido");
            btnCriarPedido.BackColor = Color.Navy;
            btnCriarPedido.Cursor = Cursors.Hand;
            btnCriarPedido.ForeColor = Color.White;
            btnCriarPedido.Name = "btnCriarPedido";
            btnCriarPedido.UseVisualStyleBackColor = false;
            // 
            // panelTop
            // 
            resources.ApplyResources(panelTop, "panelTop");
            panelTop.BackColor = Color.Navy;
            panelTop.Name = "panelTop";
            // 
            // panelPedidos
            // 
            resources.ApplyResources(panelPedidos, "panelPedidos");
            panelPedidos.BackColor = Color.DarkMagenta;
            panelPedidos.Controls.Add(btnCriarPedido);
            panelPedidos.Name = "panelPedidos";
            // 
            // frm3DCreativeDesign
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelPedido);
            Controls.Add(panelPedidos);
            Controls.Add(panelTop);
            Name = "frm3DCreativeDesign";
            FormClosed += frm3DCreativeDesign_FormClosed;
            panelPedido.ResumeLayout(false);
            panelPedido.PerformLayout();
            panelPedidos.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelPedido;
        private TextBox txtNome;
        private CheckBox cbComecar;
        private TextBox txtTipo;
        private Button btnCriarPedido;
        private Panel panelTop;
        private Panel panelPedidos;
    }
}

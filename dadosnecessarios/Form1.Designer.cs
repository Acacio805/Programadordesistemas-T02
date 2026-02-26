namespace dadosnecessarios
{
    partial class frmFormularioSimples
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
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblCidade = new System.Windows.Forms.Label();
            this.comboBoxCidade = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNaoBinario = new System.Windows.Forms.RadioButton();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtNumeroCadastrado = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtNomeCompleto.Font = new System.Drawing.Font("Roboto", 18F);
            this.txtNomeCompleto.Location = new System.Drawing.Point(23, 69);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(414, 36);
            this.txtNomeCompleto.TabIndex = 0;
            this.txtNomeCompleto.Text = "Insira seu nome completo";
            this.txtNomeCompleto.UseWaitCursor = true;
            this.txtNomeCompleto.Click += new System.EventHandler(this.txtNomeCompleto_Click);
            this.txtNomeCompleto.TextChanged += new System.EventHandler(this.txtNomeCompleto_Click);
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Font = new System.Drawing.Font("Roboto", 12F);
            this.lblDataNasc.Location = new System.Drawing.Point(19, 128);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(153, 19);
            this.lblDataNasc.TabIndex = 1;
            this.lblDataNasc.Text = "Data de Nascimento";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Roboto", 12F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(178, 124);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(113, 27);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(19, 180);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(58, 19);
            this.lblCidade.TabIndex = 3;
            this.lblCidade.Text = "Cidade";
            // 
            // comboBoxCidade
            // 
            this.comboBoxCidade.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCidade.FormattingEnabled = true;
            this.comboBoxCidade.Items.AddRange(new object[] {
            "São Paulo",
            "Rio de Janeiro",
            "Salvador",
            "Manaus",
            "Brasília"});
            this.comboBoxCidade.Location = new System.Drawing.Point(83, 177);
            this.comboBoxCidade.Name = "comboBoxCidade";
            this.comboBoxCidade.Size = new System.Drawing.Size(196, 27);
            this.comboBoxCidade.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNaoBinario);
            this.groupBox1.Controls.Add(this.rbFeminino);
            this.groupBox1.Controls.Add(this.rbMasculino);
            this.groupBox1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 64);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gênero";
            // 
            // rbNaoBinario
            // 
            this.rbNaoBinario.AutoSize = true;
            this.rbNaoBinario.Font = new System.Drawing.Font("Roboto", 15F);
            this.rbNaoBinario.Location = new System.Drawing.Point(248, 25);
            this.rbNaoBinario.Name = "rbNaoBinario";
            this.rbNaoBinario.Size = new System.Drawing.Size(131, 28);
            this.rbNaoBinario.TabIndex = 2;
            this.rbNaoBinario.TabStop = true;
            this.rbNaoBinario.Text = "Não Binário";
            this.rbNaoBinario.UseVisualStyleBackColor = true;
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Font = new System.Drawing.Font("Roboto", 15F);
            this.rbFeminino.Location = new System.Drawing.Point(131, 25);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(111, 28);
            this.rbFeminino.TabIndex = 1;
            this.rbFeminino.TabStop = true;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Font = new System.Drawing.Font("Roboto", 15F);
            this.rbMasculino.Location = new System.Drawing.Point(6, 26);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(119, 28);
            this.rbMasculino.TabIndex = 0;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(23, 363);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(223, 54);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.TabStop = false;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtNumeroCadastrado
            // 
            this.txtNumeroCadastrado.Font = new System.Drawing.Font("Roboto", 18F);
            this.txtNumeroCadastrado.Location = new System.Drawing.Point(23, 17);
            this.txtNumeroCadastrado.Name = "txtNumeroCadastrado";
            this.txtNumeroCadastrado.Size = new System.Drawing.Size(414, 36);
            this.txtNumeroCadastrado.TabIndex = 7;
            this.txtNumeroCadastrado.Text = "Número Cadastrado";
            this.txtNumeroCadastrado.UseWaitCursor = true;
            this.txtNumeroCadastrado.Click += new System.EventHandler(this.txtNumeroCadastrado_Click);
            this.txtNumeroCadastrado.TextChanged += new System.EventHandler(this.txtNumeroCadastrado_Click);
            // 
            // frmFormularioSimples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNumeroCadastrado);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxCidade);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDataNasc);
            this.Controls.Add(this.txtNomeCompleto);
            this.Name = "frmFormularioSimples";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Simples";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeCompleto;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.ComboBox comboBoxCidade;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFeminino;
        private System.Windows.Forms.RadioButton rbNaoBinario;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtNumeroCadastrado;
    }
}


namespace Dia_da_Semana_Switch
{
    partial class frmDiadaSemana
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblDigiteNumero = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtDiadaSemana = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(238, 6);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 42);
            this.txtNumero.TabIndex = 0;
            // 
            // lblDigiteNumero
            // 
            this.lblDigiteNumero.AutoSize = true;
            this.lblDigiteNumero.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigiteNumero.Location = new System.Drawing.Point(12, 9);
            this.lblDigiteNumero.Name = "lblDigiteNumero";
            this.lblDigiteNumero.Size = new System.Drawing.Size(220, 35);
            this.lblDigiteNumero.TabIndex = 1;
            this.lblDigiteNumero.Text = "Digite Número : ";
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Roboto", 21.75F);
            this.btnEnter.Location = new System.Drawing.Point(344, 6);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(103, 42);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtDiadaSemana
            // 
            this.txtDiadaSemana.AutoSize = true;
            this.txtDiadaSemana.Font = new System.Drawing.Font("Roboto", 21.75F);
            this.txtDiadaSemana.Location = new System.Drawing.Point(130, 158);
            this.txtDiadaSemana.Name = "txtDiadaSemana";
            this.txtDiadaSemana.Size = new System.Drawing.Size(194, 35);
            this.txtDiadaSemana.TabIndex = 3;
            this.txtDiadaSemana.Text = "DiadaSemana";
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.Location = new System.Drawing.Point(6, 158);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(118, 35);
            this.lblDia.TabIndex = 4;
            this.lblDia.Text = "Hoje é : ";
            // 
            // frmDiadaSemana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.txtDiadaSemana);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblDigiteNumero);
            this.Controls.Add(this.txtNumero);
            this.Name = "frmDiadaSemana";
            this.Text = "t";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblDigiteNumero;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label txtDiadaSemana;
        private System.Windows.Forms.Label lblDia;
    }
}


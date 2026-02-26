using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CalcularIdeade
{
    public partial class frmCalcularIdade : Form
    {
        public frmCalcularIdade()
        {
            InitializeComponent();
        }

        int AnoNasc, AnoAtual, Idade;
        
        private void CalcularIdade() // Metodo para calcular idade
        {
            Idade = AnoAtual - AnoNasc;
            lblIdade.Text = Idade.ToString();
        }
        
        private void txtAnoAtual_KeyPress(object sender, KeyPressEventArgs e)
        {
            // verifica se a tecla pressionada é Enter
            if (e.KeyChar == (char)Keys.Enter) 
            {
                // Evita o "bip" do sistema ao pressionar Enter
                e.Handled = true;

                // Tenta converter os valores digitados
                if (int.TryParse(txtAnoNasc.Text, out AnoNasc))
                {
                }
                else 
                { 
                    MessageBox.Show("Digite ano de nascimento valido."); 
                }
                if (int.TryParse(txtAnoAtual.Text, out AnoAtual)) 
                { 
                    CalcularIdade(); 
                }
                else
                {
                    MessageBox.Show("Digite um ano atual valido.");
                }
            }
        }
    }
}

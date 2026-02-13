using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadorasimples
{
    public partial class frmCalculadoraSimples : Form
    {
        public frmCalculadoraSimples()
        {
            InitializeComponent();
        }

        private bool TryGetInputs(out float a, out float b)
        {
            a = 0;
            b = 0;

            if (!float.TryParse(txtPrimeiroNumero.Text, out a))
            {
                MessageBox.Show("Informe um número válido no primeiro campo.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrimeiroNumero.Focus();
                return false;
            }

            if (!float.TryParse(txtSegundoNumero.Text, out b))
            {
                MessageBox.Show("Informe um número válido no segundo campo.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSegundoNumero.Focus();
                return false;
            }

            return true;
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            if (!TryGetInputs(out var a, out var b)) return;
            lblProdutoCalculo.Text = (a + b).ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            if (!TryGetInputs(out var a, out var b)) return;
            lblProdutoCalculo.Text = (a - b).ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (!TryGetInputs(out var a, out var b)) return;
            lblProdutoCalculo.Text = (a * b).ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (!TryGetInputs(out var a, out var b)) return;

            if (Math.Abs(b) < float.Epsilon)
            {
                MessageBox.Show("Divisão por zero não é permitida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblProdutoCalculo.Text = "Erro (divisão por zero)";
                txtSegundoNumero.Focus();
                return;
            }

            lblProdutoCalculo.Text = (a / b).ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPrimeiroNumero.Clear();
            txtSegundoNumero.Clear();
            lblProdutoCalculo.Text = "0";
            txtPrimeiroNumero.Focus();
        }
    }
}

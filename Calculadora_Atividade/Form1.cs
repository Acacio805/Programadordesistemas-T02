using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Atividade
{
    public partial class frmCalculadora : Form
    {

        public decimal Resultado { get; set; }
        public decimal Valor { get; set; }
        public int turno { get; set; } = 0;

        private Operacao OperacaoSelecionada { get; set; }

        enum Operacao { Adicao, Subtracao, Multiplicacao, Divisao }

        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {              
            if (!txtResultado.Text.Contains(","))
            {
                txtResultado.Text += ",";
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperação.Text = "Dividir";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperação.Text = "Multiplicar";
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperação.Text = "Subtrair";
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperação.Text = "Adicionar";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            lblOperação.Text = "Resultado";
            switch (OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    Resultado = Valor + Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.Subtracao:
                    Resultado = Valor - Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.Divisao:
                    if (Convert.ToDecimal(txtResultado.Text) == 0)
                    {
                        Resultado = 0;
                        lblOperação.Text = "Impossível dividir por zero";
                        break;
                    }
                    else
                    {
                        Resultado = Valor / Convert.ToDecimal(txtResultado.Text);
                        break;
                    }
                default:
                    break;
            }
            txtResultado.Text = Resultado.ToString();
        }
        private void btnClear_Click(object sender, EventArgs e) 
        { 
            txtResultado.Text = "";
            lblOperação.Text = "";
        }
    }
}

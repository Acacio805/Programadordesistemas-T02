using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogodeNumeros
{
    public partial class frmJogoNumeros : Form
    {
        int randomNumber;
        int numeroTentativas = 10;
        int palpitedoJogador;
        bool jogoGanho = false;
        string dica;
        
        public frmJogoNumeros()
        {
            InitializeComponent();
        }

        private void frmJogoNumeros_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            randomNumber = random.Next(1, 101); //número aleatório entre 1 e 100
        }

        private void btnTentativa_Click(object sender, EventArgs e)
        {
            //Verifica se o jogo já foi ganho
            if (jogoGanho)
            {
                txtResultado.Text = "Você já acertou o número!";
                return;
            }

            //Verifica se o número de tentativas chegou a 0
            if (numeroTentativas <= 0)
            {
                txtResultado.Text = "Você não tem mais tentativas. O jogo acabou.";
                btnTentativa.Enabled = false;
                txtNumeroInserido.Enabled = false;
                return;
            }

            //Validação do valor de palpite (entre 1 e 100)
            if (!int.TryParse(txtNumeroInserido.Text, out palpitedoJogador) || palpitedoJogador < 1 || palpitedoJogador > 100)
            {
                txtResultado.Text = "Por favor, insira um número entre 1 e 100";
                return;
            }

            numeroTentativas--;
            lblNumeroTentativas.Text = numeroTentativas.ToString();

            if (palpitedoJogador == randomNumber)
            {
                jogoGanho = true;
                dica = "Parabéns, você acertou!";
            }
            else if (palpitedoJogador < randomNumber)
            {
                dica = "o número que você digitou é menor, digite um número maior";
            }
            else
            {
                dica = "o número que você digitou é maior, digite um número menor";
            }

            txtResultado.Text = dica;
        }
    }
}

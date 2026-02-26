using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dadosnecessarios
{
    public partial class frmFormularioSimples : Form
    {
        public frmFormularioSimples()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int numeroCadastro;
            string nomeUsuario;
            DateTime dataNascimento;
            String cidade;
            bool generoF;  // F = Feminino 
            bool generoM;  // M = Masculino
            bool generoNB; // NB = Não Binário

            //Validação de campos obrigatórios

            if (string.IsNullOrWhiteSpace(txtNumeroCadastrado.Text))
            {
                MessageBox.Show("Por favor, preencha o número de cadastro.");
                return; //Interrompe a execução do método se o campo estiver vazio
            }

            if (string.IsNullOrWhiteSpace(txtNomeCompleto.Text))
            {
                MessageBox.Show("Por favor, preencha o nome Completo.");
                return; //Interrompe a execução do método se o campo estiver vazio
            }

            if (comboBoxCidade.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione a cidade.");
                return; //Interrompe a execução do método se o campo estiver vazio
            }

            if (!rbFeminino.Checked && !rbMasculino.Checked && !rbNaoBinario.Checked)
            {
                MessageBox.Show("Por favor, selecione o gênero.");
                return; //Interrompe a execução do método se o campo estiver vazio
            }

            // Agora. caso todos os campos estejam preenchidos, podemos prosseguir com a captura dos dados
            numeroCadastro = Convert.ToInt32(txtNumeroCadastrado.Text);
            nomeUsuario = txtNomeCompleto.Text;
            dataNascimento = dateTimePicker1.Value;
            cidade = comboBoxCidade.Text;
            generoF = rbFeminino.Checked;
            generoM = rbMasculino.Checked;
            generoNB = rbNaoBinario.Checked;

            //Determinar o gênero selecionado
            string generoSelecionado = "Não informado"; //Caso nehum gênero seja selecionado

            if (generoF)
                generoSelecionado = "Feminino";
            else if (generoM)
                generoSelecionado = "Masculino";
            else if (generoNB)
                generoSelecionado = "Não Binário";

                // Formatar a data para exibir apenas a data (sem a hora)
                string dataFormatada = dataNascimento.ToString("dd/MM/yyyy");

            // Exibir as informações em MessageBox
            MessageBox.Show("Número cadastrado: " + numeroCadastro +
                            "\nNome: " + nomeUsuario +
                            "\nGênero: " + generoSelecionado +
                            "\nData de Nascimento: " + dataFormatada +
                            "\nCidade: " + cidade);
        }

        private void txtNumeroCadastrado_Click(object sender, EventArgs e)
        {
            txtNumeroCadastrado.Clear();
        }

        private void txtNomeCompleto_Click(object sender, EventArgs e)
        {
            txtNomeCompleto.Clear();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_Pratica_Matrizes
{
    public partial class frmCadastro : Form
    {
        
        // Lista inicial
        public string[,] matriz = {
            {"Carlos", "20", "Motoboy" },
            {"Gabriela", "24", "Professora" },
        };
        
        public frmCadastro()
        {
            InitializeComponent();
            // Percorre as linhas da matriz
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                // Percorre as colunas da linhaSelecionada
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    lstCadastro.Items.Add(matriz[i, j] + "");
                }
            }
        }
        
        public void btnCadastrar_Click(object sender, EventArgs e)
        {
          
            // Limpa a lista antiga
            lstCadastro.Items.Clear();

            // Ler e armazena nova linha a adicionar
            string[] novaLinha = { txtNome.Text, txtIdade.Text, txtOcupacao.Text + "\n" };

            // 1. Obter o número atual de linhas (1ª dimensão)
            int linhasAtuais = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);

            // 2. Criar uma nova matriz maior
            string[,] novaMatriz = new string[linhasAtuais + 1, colunas];

            // 3. Copiar dados antigos
            Array.Copy(matriz, novaMatriz, matriz.Length);

            // 4. Adicionar a nova linha na última posição
            for (int i = 0; i < colunas; i++)
            {
                novaMatriz[linhasAtuais, i] = novaLinha[i];
            }

            matriz = novaMatriz; // Atualizar a referência

            // Percorre as linhas da matriz
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                // Percorre as colunas da linhaSelecionada
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    lstCadastro.Items.Add(matriz[i, j] + "");
                }
            }

            // Limpa os textboxes para novo cadastro
            txtNome.Clear();
            txtIdade.Clear();
            txtOcupacao.Clear();

            MessageBox.Show("Dados cadastrados com sucesso");
        }
    }
}

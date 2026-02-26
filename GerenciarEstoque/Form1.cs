using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciarEstoque
{
    public partial class frmGerenciamentoEstoque : Form
    {
        public frmGerenciamentoEstoque()
        {
            InitializeComponent();
            lblMensagem.Text = "";
        }

        public void Mensagem()
        {
            
            int.TryParse(txtEstoque.Text, out int EstoqueProduto);
            if (EstoqueProduto < 5)
            {
                lblMensagem.Text = "Alerta: Baixo estoque. Por favor, reabasteça este produto.";
                lblMensagem.BackColor = Color.Red;
            }
            else
            {
                lblMensagem.Text = "Estoque suficiente.";
                lblMensagem.BackColor = Color.Green;
            }
        }

        private void btnCheckEstoque_Click(object sender, EventArgs e)
        {
            Mensagem();
        }

        private void lblEstoqueQuantidade_Click(object sender, EventArgs e)
        {

        }
    }
}

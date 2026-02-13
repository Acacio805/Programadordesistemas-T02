using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alertas
{
    public partial class Alertas : Form
    {
        public Alertas()
        {
            InitializeComponent();
        }

        private void btnAlertaSimples_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este é um alerta simples!", "Com um título");
        }

        private void btnAlertaRobusto_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Vamos programar um sistema?", 
                                                    "Titulo aqui",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                MessageBox.Show("Respondeu que sim!", "Resposta Positiva");
            }
            else
            {
                MessageBox.Show("Respondeu que não!", "Resposta Negativa");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dia_da_Semana_Switch
{
    public partial class frmDiadaSemana : Form
    {
        public frmDiadaSemana()
        {
            InitializeComponent();
            txtDiadaSemana.Text = string.Empty;
        }        
        
        private void btnEnter_Click(object sender, EventArgs e)
        {
            switch (txtNumero.Text)
            {
                case "1":
                    txtDiadaSemana.Text = "Domingo";
                    break;
                case "2":
                    txtDiadaSemana.Text = "Segunda-Feira";
                    break;
                case "3":
                    txtDiadaSemana.Text = "Terça-Feira";
                    break;
                case "4":
                    txtDiadaSemana.Text = "Quarta-Feira";
                    break;
                case "5":
                    txtDiadaSemana.Text = "Quinta-Feira";
                    break;
                case "6":
                    txtDiadaSemana.Text = "Sexta-Feira";
                    break;
                case "7":
                    txtDiadaSemana.Text = "Sábado";
                    break;
                default:
                    break;
            }
        }
    }
}

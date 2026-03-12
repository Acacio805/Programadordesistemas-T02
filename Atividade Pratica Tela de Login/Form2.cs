using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_Pratica_Tela_de_Login
{
    public partial class frmBemVindo : Form
    {
        public frmBemVindo()
        {
            InitializeComponent();
        }

        public void frmBemVindo_Load(object sender, EventArgs e)
        {
            lstNomes.Items.Add("Acacio"); lstNomes.Items.Add("Ana"); lstNomes.Items.Add("Paulo");
        }

        bool logado = true;

        public void deslogar()
        {

        }
        
        public void btnSair_Click(object sender, EventArgs e)
        {
            logado = false;
        }
    }
}

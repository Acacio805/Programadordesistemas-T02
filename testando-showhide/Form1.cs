using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testando_showhide
{
    public partial class frmShowHide : Form
    {
        public frmShowHide()
        {
            InitializeComponent();
            pbLogotipo.Visible = false;
        }

        private void btnMostrarLogo_Click(object sender, EventArgs e)
        {
            if (pbLogotipo.Visible)
            {
                pbLogotipo.Hide();
                btnMostrarLogo.Text = "Mostrar Logo";
            }
            else 
            { 
                pbLogotipo.Show();
                btnMostrarLogo.Text = "Esconder Logo";
            }
        }

        private void pbLogotipo_Click(object sender, EventArgs e)
        {
            frmHome form = new frmHome();
            form.Show();
            this.Hide();
        }
    }
}

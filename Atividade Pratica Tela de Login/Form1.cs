using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Atividade_Pratica_Tela_de_Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            lblTentativas.Text = "";
        }

        string Usuario = "usuario";
        string senha = "senha123";

        bool logado = false;
        bool bloqueado = false;
        int counter = 3;

        public void loginCheck()
        {
            while (!logado && !bloqueado)
            {              
                if (txtUsuario.Text == Usuario && txtSenha.Text == senha)
                {
                    logado = true;
                    lblTentativas.Text = "Login Feito com Sucesso.";      
                    MessageBox.Show("Login bem-sucedido!");
                    frmBemVindo frm = new frmBemVindo();
                    frm.Show();
                    this.Visible = false;
                }
                else 
                {
                    counter--;
                    lblTentativas.Text = "Usuario ou senha inválidos, tente novamente. Você tem " + counter + " tentativas restando.";
                }
                if (counter < 1)
                {
                    bloqueado = true;
                    lblDigiteseuLogin.Text = "Sistema Bloqueado, entre em contato com \no administrador para mais informações";
                    lblDigiteseuLogin.ForeColor = Color.Red;
                    lblTentativas.Text = string.Empty;
                    btnEntrar.Enabled = false;
                    txtUsuario.Text = string.Empty; txtSenha.Text = string.Empty;
                    txtUsuario.ReadOnly = true; txtSenha.ReadOnly = true;
                    txtUsuario.Enabled = false; txtSenha.Enabled = false;
                    MessageBox.Show("Sistema foi bloqueado por muitas tentativas sem sucesso.");
                }
                return;
            }
        }        
        
        public void btnEntrar_Click(object sender, EventArgs e)
        {
            loginCheck();
        }
    }
}

using Microsoft.Office.Interop.Excel;
// Acessando o pacote do mysql
using MySql.Data.MySqlClient;
using Mysqlx.Resultset;
using RPanel;
using System.Data;
using System.Drawing.Text;

namespace APP
{
    public partial class frm3DCreativeDesign : Form
    {
        
        
        //Conexão com o banco de dados MySQL
        MySqlConnection Conexao;
        string data_source = "datasource=localhost;username=root;password=;database=acacio3d";

        public frm3DCreativeDesign()
        {
            InitializeComponent();

            panelLeftWhite.Size = new System.Drawing.Size(2, 691);

            this.DoubleBuffered = true;

            regarregarPedidos();

        }


        
        
        class Pedido
        {
            public int Id { get; set; }
            public int Id_Cliente { get; set; }
            public string Email { get; set; }
            public string Tipo { get; set; }
            public string descricao { get; set; }
        }

        public void regarregarPedidos()
        {
            flpanelPedidosNovos.Controls.Clear();

            List<Pedido> Comissao = new List<Pedido>();

            using (MySqlConnection conexao = new MySqlConnection(data_source))
            {

                string sql = "SELECT id_comissao, id_cliente, contato, descricao FROM formulario";
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                conexao.Open();
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Pedido p = new Pedido();
                    p.Id = reader.GetInt32(0);
                    p.Id_Cliente = reader.GetInt32(1);
                    p.Email = reader.GetString(2);
                    p.descricao = reader.GetString(3);

                    Comissao.Add(p);
                }

                foreach (Pedido p in Comissao)
                {
                    int id = p.Id;
                    RoundedPanel pedidoPanel = new RoundedPanel()
                    {
                        Size = new Size(361, 111),
                        BackColor = Color.White,
                        BorderStyle = BorderStyle.None
                    };

                    System.Windows.Forms.TextBox txtPedido1 = new System.Windows.Forms.TextBox()
                    {
                        BackColor = SystemColors.Control,
                        Size = new Size(353, 23),
                        Location = new System.Drawing.Point(3, 12),
                        ReadOnly = true,
                    };

                    System.Windows.Forms.TextBox txtPedido2 = new System.Windows.Forms.TextBox()
                    {
                        BackColor = SystemColors.Control,
                        Size = new Size(353, 23),
                        Location = new System.Drawing.Point(3, 41),
                        ReadOnly = true,
                        Text = Convert.ToString(p.Email)
                    };

                    System.Windows.Forms.Button btnAceitar = new System.Windows.Forms.Button()
                    {
                        
                        BackColor = Color.DarkGreen,
                        Size = new Size(75, 27),
                        Location = new System.Drawing.Point(119, 73),
                    };

                    System.Windows.Forms.Button btnRejeitar = new System.Windows.Forms.Button()
                    {
                        BackColor = Color.DarkRed,
                        Size = new Size(75, 27),
                        Location = new System.Drawing.Point(281, 73),
                    };

                    System.Windows.Forms.Button btnInfo = new System.Windows.Forms.Button()
                    {
                        BackColor = SystemColors.ControlDark,
                        Size = new Size(75, 27),
                        Location = new System.Drawing.Point(200, 73),
                    };

                    pedidoPanel.Controls.Add(txtPedido1);
                    pedidoPanel.Controls.Add(txtPedido2);
                    pedidoPanel.Controls.Add(btnAceitar);
                    pedidoPanel.Controls.Add(btnRejeitar);
                    pedidoPanel.Controls.Add(btnInfo);
                    flpanelPedidosNovos.Controls.Add(pedidoPanel);
                }

            }
        }        

        private void MyForm_Resize(object sender, EventArgs e)
        {
            // Force the form to redraw its background
            this.Invalidate();
        }

        
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmFormulario f2 = new frmFormulario(this); // 'this' é a referência do Form1
            f2.Show();
        }


        private void btnTrash_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnDetalhes_Click(object sender, EventArgs e)
        {
            frmPedido novoForm = new frmPedido();
            novoForm.Show();
        }

        private void butaoTeste_Click(object sender, EventArgs e)
        {
            regarregarPedidos();
        }

        private void panelPedido_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

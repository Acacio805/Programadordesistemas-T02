using Microsoft.Office.Interop.Excel;
// Acessando o pacote do mysql
using MySql.Data.MySqlClient;
using Mysqlx.Resultset;
using RPanel;
using System.Data;
using System.Drawing.Text;
using System.Runtime.InteropServices.Marshalling;
using System.Text.RegularExpressions;

namespace APP
{
    public partial class frm3DCreativeDesign : Form {

        public int Id_Pedido;

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

            System.Windows.Forms.Label lblPedidosNovos = new System.Windows.Forms.Label()
            {
                Text = "Pedidos Novos",
            };

            flpanelPedidosNovos.Controls.Add(lblPedidosNovos);

            List<Pedido> Comissao = new List<Pedido>();

            using (MySqlConnection conexao = new MySqlConnection(data_source))
            {

                try
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
                }
                catch (MySqlException ex)
                {
                    //Trata erros relacionados ao MySQL
                    MessageBox.Show("Erro " + ex.Number + " Ocorreu: " + ex.Message,
                                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    //Trata outros tipos de erro
                    MessageBox.Show("Ocorreu: " + ex.Message,
                                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    //Garante que a conexão com o banco será fechada, mesmo se ocorrer erro
                    if (conexao != null && conexao.State == ConnectionState.Open)
                    {
                        conexao.Close();
                    }
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
                    pedidoPanel.Tag = id;

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
                    btnAceitar.Click += new EventHandler(btnAceitar_Click);

                    System.Windows.Forms.Button btnDeletar = new System.Windows.Forms.Button()
                    {
                        BackColor = Color.DarkRed,
                        Size = new Size(75, 27),
                        Location = new System.Drawing.Point(281, 73),
                    };
                    btnDeletar.Tag = id;
                    
                    btnDeletar.Click += new EventHandler(btnDeletar_Click);

                    System.Windows.Forms.Button btnInfo = new System.Windows.Forms.Button()
                    {
                        BackColor = SystemColors.ControlDark,
                        Size = new Size(75, 27),
                        Location = new System.Drawing.Point(200, 73),                        
                    };
                    btnInfo.Tag = id;

                    btnInfo.Click += new EventHandler(btnInfo_Click);

                    pedidoPanel.Controls.Add(txtPedido1);
                    pedidoPanel.Controls.Add(txtPedido2);
                    pedidoPanel.Controls.Add(btnAceitar);
                    pedidoPanel.Controls.Add(btnDeletar);
                    pedidoPanel.Controls.Add(btnInfo);
                    flpanelPedidosNovos.Controls.Add(pedidoPanel);
                }
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Control controle = (Control)sender;
            string btnDeletar = controle.Name;
            string btnDeletar_n = Regex.Replace(btnDeletar, @"\D", "");
            int id = int.Parse(btnDeletar_n);

            DialogResult resposta = MessageBox.Show(
            "Tem certeza que deseja excluir esse pedido?",
            "Confirmar Exclusão",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
            );

            if (resposta == DialogResult.Yes)
            {
                using (MySqlConnection conexao = new MySqlConnection(data_source))
                {
                   
                    conexao.Open();

                    using (MySqlTransaction transacao = conexao.BeginTransaction())
                    {
                        try
                        {
                            MySqlCommand cmd1 = new MySqlCommand(
                                "DELETE FROM formulario WHERE id_cliente = @id",
                                conexao, transacao
                            );

                            MySqlCommand cmd2 = new MySqlCommand(
                                "DELETE FROM cliente WHERE id_cliente = @id",
                                conexao, transacao
                            );

                            cmd1.Parameters.AddWithValue("@id", id);
                            cmd2.Parameters.AddWithValue("@id", id);

                            cmd1.ExecuteNonQuery();
                            cmd2.ExecuteNonQuery();

                            transacao.Commit(); // confirma tudo
                        }
                        catch (MySqlException ex)
                        {
                            //Trata erros relacionados ao MySQL
                            MessageBox.Show("Erro " + ex.Number + " Ocorreu: " + ex.Message,
                                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            //Trata outros tipos de erro
                            MessageBox.Show("Ocorreu: " + ex.Message,
                                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            //Garante que a conexão com o banco será fechada, mesmo se ocorrer erro
                            if (conexao != null && conexao.State == ConnectionState.Open)
                            {
                                conexao.Close();
                            }
                            regarregarPedidos();
                        }
                    }
                    }


            }
        }
        private void btnAceitar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("pedido aceito");
        }

        
        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (sender is not System.Windows.Forms.Button botao || botao.Tag == null)
                return;

            int id = (int)botao.Tag;
            Id_Pedido = id;

            frmInfo f3 = new frmInfo(this); // 'this' é a referência do Form1
            f3.Show();  
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

        private void panelPedido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void butaoRecarregar_Click(object sender, EventArgs e)
        {
            regarregarPedidos();
        }
    }
}

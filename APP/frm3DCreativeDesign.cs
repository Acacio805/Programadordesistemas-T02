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
            public string nome { get; set; }
            public int status { get; set; }
        }

        public void regarregarPedidos()
        {
            
            flpanelPedidosNovos.Controls.Clear();
            flpanelPedidosAndamento.Controls.Clear();
            flpanelPedidosConcluidos.Controls.Clear();

            System.Windows.Forms.Label lblPedidosNovos = new System.Windows.Forms.Label()
            {
                Text = "Pedidos Novos",
                Font = new Font("Segoe UI", 15),
                Padding = new System.Windows.Forms.Padding(0, 0, 0, 0),
                Size = new Size(282, 30)
            };
            System.Windows.Forms.Label lblPedidosAndamento = new System.Windows.Forms.Label()
            {
                Text = "Pedidos em Andamento",
                Font = new Font("Segoe UI", 15),
                Padding = new System.Windows.Forms.Padding(0, 0, 0, 0),
                Size = new Size(282, 30)
            };

            System.Windows.Forms.Label lblPedidosConcluidos = new System.Windows.Forms.Label()
            {
                Text = "Pedidos Concluidos",
                Font = new Font("Segoe UI", 15),
                Padding = new System.Windows.Forms.Padding(0, 0, 0, 0),
                Size = new Size(282, 30)
            };

            flpanelPedidosNovos.Controls.Add(lblPedidosNovos);
            flpanelPedidosAndamento.Controls.Add(lblPedidosAndamento);
            flpanelPedidosConcluidos.Controls.Add(lblPedidosConcluidos);

            flpanelPedidosNovos.Size = new Size(386, 46);
            flpanelPedidosAndamento.Size = new Size(386, 46);
            flpanelPedidosConcluidos.Size = new Size(386, 46);

            List<Pedido> listaPedidos = new List<Pedido>();

            using (MySqlConnection conexao = new MySqlConnection(data_source))
            {

                try
                {
                    string sql = "SELECT formulario.id_comissao, formulario.id_cliente, formulario.contato, formulario.descricao, cliente.nome_cliente , formulario.status " +
                                 "FROM formulario " +
                                 "INNER JOIN cliente " +
                                 "ON formulario.id_comissao = cliente.id_cliente";

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
                        p.nome = reader.GetString(4);
                        p.status = reader.GetInt32(5);
                        listaPedidos.Add(p);
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

                foreach (Pedido p in listaPedidos)
                {
                    int id = p.Id;
                    if (p.status == 0)
                    {
                        RoundedPanel pedidoPanel = new RoundedPanel()
                        {
                            Size = new Size(361, 138),
                            BackColor = Color.White,
                            BorderStyle = BorderStyle.None
                        };
                        pedidoPanel.Tag = id;

                        System.Windows.Forms.TextBox txtNome = new System.Windows.Forms.TextBox()
                        {
                            BackColor = SystemColors.Control,
                            Size = new Size(353, 23),
                            Location = new System.Drawing.Point(3, 12),
                            ReadOnly = true,
                            Text = Convert.ToString(p.nome)
                        };

                        System.Windows.Forms.TextBox txtEmail = new System.Windows.Forms.TextBox()
                        {
                            BackColor = SystemColors.Control,
                            Size = new Size(353, 23),
                            Location = new System.Drawing.Point(3, 41),
                            ReadOnly = true,
                            Text = Convert.ToString(p.Email)
                        };
                        System.Windows.Forms.TextBox txtDesc = new System.Windows.Forms.TextBox()
                        {
                            BackColor = SystemColors.Control,
                            Size = new Size(353, 23),
                            Location = new System.Drawing.Point(3, 70),
                            ReadOnly = true,
                            Text = Convert.ToString(p.descricao)
                        };

                        System.Windows.Forms.Button btnAceitar = new System.Windows.Forms.Button()
                        {
                            BackColor = Color.DarkGreen,
                            Size = new Size(75, 27),
                            Location = new System.Drawing.Point(119, 104),
                        };

                        System.Windows.Forms.Button btnInfo = new System.Windows.Forms.Button()
                        {
                            BackColor = SystemColors.ControlDark,
                            Size = new Size(75, 27),
                            Location = new System.Drawing.Point(200, 104),
                        };                       

                        System.Windows.Forms.Button btnDeletar = new System.Windows.Forms.Button()
                        {
                            BackColor = Color.DarkRed,
                            Size = new Size(75, 27),
                            Location = new System.Drawing.Point(281, 104),
                        };

                        btnAceitar.Tag = id;
                        btnAceitar.Click += new EventHandler(btnAceitar_Click);

                        btnDeletar.Click += new EventHandler(btnDeletar_Click);
                        btnDeletar.Tag = id;

                        btnInfo.Click += new EventHandler(btnInfo_Click);
                        btnInfo.Tag = id;

                        pedidoPanel.Controls.Add(txtNome);
                        pedidoPanel.Controls.Add(txtEmail);
                        pedidoPanel.Controls.Add(txtDesc);
                        pedidoPanel.Controls.Add(btnAceitar);
                        pedidoPanel.Controls.Add(btnDeletar);
                        pedidoPanel.Controls.Add(btnInfo);
                        flpanelPedidosNovos.Controls.Add(pedidoPanel);

                        flpanelPedidosNovos.Size = new Size(flpanelPedidosNovos.Width, flpanelPedidosNovos.Height + 138);
                    }

                    if (p.status == 1)
                    {
                        RoundedPanel pedidoPanel = new RoundedPanel()
                        {
                            Size = new Size(361, 138),
                            BackColor = Color.White,
                            BorderStyle = BorderStyle.None
                        };
                        pedidoPanel.Tag = id;

                        System.Windows.Forms.TextBox txtNome = new System.Windows.Forms.TextBox()
                        {
                            BackColor = SystemColors.Control,
                            Size = new Size(353, 23),
                            Location = new System.Drawing.Point(3, 12),
                            ReadOnly = true,
                            Text = Convert.ToString(p.nome)
                        };

                        System.Windows.Forms.TextBox txtEmail = new System.Windows.Forms.TextBox()
                        {
                            BackColor = SystemColors.Control,
                            Size = new Size(353, 23),
                            Location = new System.Drawing.Point(3, 41),
                            ReadOnly = true,
                            Text = Convert.ToString(p.Email)
                        };
                        System.Windows.Forms.TextBox txtDesc = new System.Windows.Forms.TextBox()
                        {
                            BackColor = SystemColors.Control,
                            Size = new Size(353, 23),
                            Location = new System.Drawing.Point(3, 70),
                            ReadOnly = true,
                            Text = Convert.ToString(p.descricao)
                        };

                        System.Windows.Forms.Button btnConcluido = new System.Windows.Forms.Button()
                        {
                            BackColor = Color.DarkGreen,
                            Size = new Size(75, 27),
                            Location = new System.Drawing.Point(119, 104),
                        };                                               

                        System.Windows.Forms.Button btnInfo = new System.Windows.Forms.Button()
                        {
                            BackColor = SystemColors.ControlDark,
                            Size = new Size(75, 27),
                            Location = new System.Drawing.Point(200, 104),
                        };

                        System.Windows.Forms.Button btnDeletar = new System.Windows.Forms.Button()
                        {
                            BackColor = Color.DarkRed,
                            Size = new Size(75, 27),
                            Location = new System.Drawing.Point(281, 104),
                        };

                        btnConcluido.Tag = id;
                        btnConcluido.Click += new EventHandler(btnConcluido_Click);

                        btnDeletar.Tag = id;
                        btnDeletar.Click += new EventHandler(btnDeletar_Click);

                        btnInfo.Tag = id;
                        btnInfo.Click += new EventHandler(btnInfo_Click);

                        pedidoPanel.Controls.Add(txtNome);
                        pedidoPanel.Controls.Add(txtEmail);
                        pedidoPanel.Controls.Add(txtDesc);
                        pedidoPanel.Controls.Add(btnConcluido);
                        pedidoPanel.Controls.Add(btnDeletar);
                        pedidoPanel.Controls.Add(btnInfo);
                        flpanelPedidosAndamento.Controls.Add(pedidoPanel);

                        flpanelPedidosAndamento.Size = new Size(flpanelPedidosAndamento.Width, flpanelPedidosAndamento.Height + 138);
                    }

                    if (p.status == 2)
                    {
                        RoundedPanel pedidoPanel = new RoundedPanel()
                        {
                            Size = new Size(361, 138),
                            BackColor = Color.White,
                            BorderStyle = BorderStyle.None
                        };
                        pedidoPanel.Tag = id;

                        System.Windows.Forms.TextBox txtNome = new System.Windows.Forms.TextBox()
                        {
                            BackColor = SystemColors.Control,
                            Size = new Size(353, 23),
                            Location = new System.Drawing.Point(3, 12),
                            ReadOnly = true,
                            Text = Convert.ToString(p.nome)
                        };

                        System.Windows.Forms.TextBox txtEmail = new System.Windows.Forms.TextBox()
                        {
                            BackColor = SystemColors.Control,
                            Size = new Size(353, 23),
                            Location = new System.Drawing.Point(3, 41),
                            ReadOnly = true,
                            Text = Convert.ToString(p.Email)
                        };
                        System.Windows.Forms.TextBox txtDesc = new System.Windows.Forms.TextBox()
                        {
                            BackColor = SystemColors.Control,
                            Size = new Size(353, 23),
                            Location = new System.Drawing.Point(3, 70),
                            ReadOnly = true,
                            Text = Convert.ToString(p.descricao)
                        };

                        System.Windows.Forms.Button btnAceitar = new System.Windows.Forms.Button()
                        {
                            BackColor = Color.DarkGreen,
                            Size = new Size(75, 27),
                            Location = new System.Drawing.Point(119, 104),
                        };

                        System.Windows.Forms.Button btnInfo = new System.Windows.Forms.Button()
                        {
                            BackColor = SystemColors.ControlDark,
                            Size = new Size(75, 27),
                            Location = new System.Drawing.Point(200, 104),
                        };

                        System.Windows.Forms.Button btnDeletar = new System.Windows.Forms.Button()
                        {
                            BackColor = Color.DarkRed,
                            Size = new Size(75, 27),
                            Location = new System.Drawing.Point(281, 104),
                        };

                        btnAceitar.Tag = id;
                        btnAceitar.Click += new EventHandler(btnAceitar_Click);

                        btnDeletar.Tag = id;
                        btnDeletar.Click += new EventHandler(btnDeletar_Click);

                        btnInfo.Tag = id;
                        btnInfo.Click += new EventHandler(btnInfo_Click);

                        pedidoPanel.Controls.Add(txtNome);
                        pedidoPanel.Controls.Add(txtEmail);
                        pedidoPanel.Controls.Add(txtDesc);
                        //pedidoPanel.Controls.Add(btnAceitar);
                        pedidoPanel.Controls.Add(btnDeletar);
                        //pedidoPanel.Controls.Add(btnInfo);
                        flpanelPedidosConcluidos.Controls.Add(pedidoPanel);

                        flpanelPedidosConcluidos.Size = new Size(flpanelPedidosConcluidos.Width, flpanelPedidosConcluidos.Height + 138);
                    }
                }
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            
            if (sender is not System.Windows.Forms.Button botao || botao.Tag == null)
                return;

            int id = (int)botao.Tag;

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

            if (sender is not System.Windows.Forms.Button botao || botao.Tag == null)
                return;

            int id = (int)botao.Tag;

            MessageBox.Show("pedido aceito");

            using (MySqlConnection conexao = new MySqlConnection(data_source))
            {
                conexao.Open();

                try
                {
                    string sql = $"UPDATE formulario " +
                                 $"SET formulario.status = 1 " +
                                 $"WHERE formulario.id_comissao = @id";

                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("id", id);

                    cmd.ExecuteNonQuery();
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
   
        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (sender is not System.Windows.Forms.Button botao || botao.Tag == null)
                return;

            int id = (int)botao.Tag;
            Id_Pedido = id;

            frmInfo f3 = new frmInfo(this); // 'this' é a referência do Form1
            f3.Show();  
        }

        private void btnConcluido_Click(object sender, EventArgs e)
        {
            if (sender is not System.Windows.Forms.Button botao || botao.Tag == null)
                return;

            int id = (int)botao.Tag;

            using (MySqlConnection conexao = new MySqlConnection(data_source))
            {
                conexao.Open();

                try
                {
                    string sql = $"UPDATE formulario " +
                                 $"SET formulario.status = 2 " +
                                 $"WHERE formulario.id_comissao = @id";

                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("id", id);

                    cmd.ExecuteNonQuery();
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

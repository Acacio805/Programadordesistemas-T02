// Acessando o pacote do mysql
using MySql.Data.MySqlClient;
using Mysqlx.Resultset;
using RPanel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.InteropServices.Marshalling;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace APP
{
    public partial class frm3DCreativeDesign : Form
    {
        public int Id_Pedido;

        //Conexão com o banco de dados MySQL
        MySqlConnection Conexao;
        string data_source = "datasource=localhost;username=root;password=;database=acacio3d";

        public frm3DCreativeDesign()
        {

            InitializeComponent();

            panelLeftWhite.Size = new System.Drawing.Size(2, 691);

            this.Font = new Font("Segoe UI", 14, FontStyle.Regular);

            Graphics graphics = this.CreateGraphics();
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            this.DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            recarregarPedidos();

            ConfigurarFlowPanels();
        }

        class Pedido
        {
            public int Id { get; set; }
            public int Id_Cliente { get; set; }
            public string contato { get; set; }
            public string Tipo { get; set; }
            public string descricao { get; set; }
            public string nome { get; set; }
            public int status { get; set; }
            public DateTime deadline { get; set; }
        }

        private void ConfigurarFlowPanels()
        {
            ConfigurarPainel(flpanelPedidosNovos);
            ConfigurarPainel(flpanelPedidosAndamento);
            ConfigurarPainel(flpanelPedidosConcluidos);
            ConfigurarPainel(flpanelPedidosAtrasados);
        }

        private void ConfigurarPainel(FlowLayoutPanel panel)
        {
            panel.AutoSize = true;
            panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel.FlowDirection = FlowDirection.TopDown;
            panel.WrapContents = false;
            panel.MaximumSize = new System.Drawing.Size(400, 900);
            panel.MinimumSize = new System.Drawing.Size(355, 46);
            panel.AutoScrollMargin = new Size(38, 38);
            panel.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
        }

        public async Task LimparFlowPanels()
        {
            flpanelPedidosNovos.SuspendLayout();
            flpanelPedidosAndamento.SuspendLayout();
            flpanelPedidosConcluidos.SuspendLayout();
            flpanelPedidosAtrasados.SuspendLayout();

            while (flpanelPedidosNovos.Controls.Count > 0)
            {
                // Calling Dispose() automatically removes the control from the Controls collection
                flpanelPedidosNovos.Controls[0].Dispose();
            }

            while (flpanelPedidosAndamento.Controls.Count > 0)
            {
                // Calling Dispose() automatically removes the control from the Controls collection
                flpanelPedidosAndamento.Controls[0].Dispose();
            }

            while (flpanelPedidosConcluidos.Controls.Count > 0)
            {
                // Calling Dispose() automatically removes the control from the Controls collection
                flpanelPedidosConcluidos.Controls[0].Dispose();
            }

            while (flpanelPedidosAtrasados.Controls.Count > 0)
            {
                flpanelPedidosAtrasados.Controls[0].Dispose();
            }

            flpanelPedidosNovos.ResumeLayout();
            flpanelPedidosAndamento.ResumeLayout();
            flpanelPedidosConcluidos.ResumeLayout();
            flpanelPedidosAtrasados.ResumeLayout();

            System.Windows.Forms.Label lblPedidosNovos = new System.Windows.Forms.Label()
            {
                Text = "Pedidos Novos",
                Font = new Font("Segoe UI Semibold", 15),
                Padding = new System.Windows.Forms.Padding(0, 0, 0, 0),
                Size = new Size(282, 30)
            };

            System.Windows.Forms.Label lblPedidosAndamento = new System.Windows.Forms.Label()
            {
                Text = "Pedidos em Andamento",
                Font = new Font("Segoe UI Semibold", 15),
                Padding = new System.Windows.Forms.Padding(0, 0, 0, 0),
                Size = new Size(282, 30)
            };

            System.Windows.Forms.Label lblPedidosConcluidos = new System.Windows.Forms.Label()
            {
                Text = "Pedidos Concluidos",
                Font = new Font("Segoe UI Semibold", 15),
                Padding = new System.Windows.Forms.Padding(0, 0, 0, 0),
                Size = new Size(282, 30)
            };

            System.Windows.Forms.Label lblPedidosAtrasados = new System.Windows.Forms.Label()
            {
                Text = "Pedidos Atrasados",
                Font = new Font("Segoe UI Semibold", 15),
                Padding = new System.Windows.Forms.Padding(0, 0, 0, 0),
                Size = new Size(282, 30)
            };

            flpanelPedidosNovos.Controls.Add(lblPedidosNovos);
            flpanelPedidosAndamento.Controls.Add(lblPedidosAndamento);
            flpanelPedidosConcluidos.Controls.Add(lblPedidosConcluidos);
            flpanelPedidosAtrasados.Controls.Add(lblPedidosAtrasados);

            flpanelPedidosAtrasados.Visible = false;
        }

        public async Task recarregarPedidos()
        {
            txtPesquisa.Clear();

            await LimparFlowPanels();

            await filtrarPedidos();
        }

        public async Task filtrarPedidos()
        {
            List<Pedido> listaPedidos = new List<Pedido>();

            await using (MySqlConnection conexao = new MySqlConnection(data_source))
            {
                try
                {
                    conexao.Open();

                    string query = "SELECT formulario.id_comissao, formulario.id_cliente, formulario.contato, formulario.descricao, cliente.nome_cliente , formulario.status , formulario.deadline " +
                                   "FROM formulario " +
                                   "INNER JOIN cliente " +
                                   "ON formulario.id_comissao = cliente.id_cliente" +
                                   " AND (" +
                                   "cliente.nome_cliente LIKE @q OR " +
                                   "formulario.descricao LIKE @q OR " +
                                   "formulario.contato LIKE @q) "
                                   ;

                    MySqlCommand comando = new MySqlCommand(query, conexao);

                    string busca = txtPesquisa.Text.ToString();

                    if (query.Contains("@q"))
                    {
                        comando.Parameters.AddWithValue("@q", "%" + busca + "%");
                    }

                    MySqlDataReader reader = comando.ExecuteReader();

                    LimparFlowPanels();

                    while (reader.Read())
                    {
                        Pedido p = new Pedido();
                        p.Id = reader.GetInt32(0);
                        p.Id_Cliente = reader.GetInt32(1);
                        p.contato = reader.GetString(2);
                        p.descricao = reader.GetString(3);
                        p.nome = reader.GetString(4);
                        p.status = reader.GetInt32(5);
                        p.deadline = reader.GetDateTime(6);

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
            }

            await recarregarListas(listaPedidos);
        }

        private async Task recarregarListas(List<Pedido> listaPedidos)
        {
            foreach (Pedido p in listaPedidos)
            {
                int id = p.Id;

                RoundedPanel pedidoPanel = new RoundedPanel()
                {
                    Size = new Size(361, 138),
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.None,
                    CornerRadius = 10,
                    Padding = new Padding(8, 8, 8, 8),
                };
                pedidoPanel.Tag = p;

                System.Windows.Forms.TextBox txtNome = new System.Windows.Forms.TextBox()
                {
                    BackColor = Color.White,
                    Size = new Size(341, 26),
                    Location = new System.Drawing.Point(11, 12),
                    ReadOnly = true,
                    Text = Convert.ToString(p.nome),
                    BorderStyle = BorderStyle.None
                };

                System.Windows.Forms.TextBox txtEmail = new System.Windows.Forms.TextBox()
                {
                    BackColor = Color.White,
                    Size = new Size(341, 26),
                    Location = new System.Drawing.Point(11, 41),
                    ReadOnly = true,
                    Text = Convert.ToString(p.contato),
                    BorderStyle = BorderStyle.None
                };
                System.Windows.Forms.TextBox txtDesc = new System.Windows.Forms.TextBox()
                {
                    BackColor = Color.White,
                    Size = new Size(341, 26),
                    Location = new System.Drawing.Point(11, 70),
                    ReadOnly = true,
                    Text = Convert.ToString(p.descricao),
                    BorderStyle = BorderStyle.None
                };

                RoundedButton btnAceitar = new RoundedButton()
                {
                    BackColor = Color.DarkGreen,
                    Size = new Size(51, 27),
                    Location = new System.Drawing.Point(187, 104),
                    FlatStyle = FlatStyle.Flat,
                };
                btnAceitar.FlatStyle = FlatStyle.Flat;
                btnAceitar.FlatAppearance.BorderSize = 0;
                var bmpAceitar = new Bitmap(APP.Properties.Resources.check_32dp_FFFFFF_FILL0_wght400_GRAD0_opsz40);
                btnAceitar.Image = bmpAceitar;

                RoundedButton btnInfo = new RoundedButton()
                {
                    BackColor = SystemColors.ControlDark,
                    Size = new Size(51, 27),
                    Location = new System.Drawing.Point(244, 104),
                    FlatStyle = FlatStyle.Flat,
                };
                btnInfo.FlatStyle = FlatStyle.Flat;
                btnInfo.FlatAppearance.BorderSize = 0;
                var bmpInfo = new Bitmap(APP.Properties.Resources.edit_32dp_FFFFFF_FILL0_wght400_GRAD0_opsz40);
                btnInfo.Image = bmpInfo;

                RoundedButton btnDeletar = new RoundedButton()
                {
                    BackColor = Color.DarkRed,
                    Size = new Size(51, 27),
                    Location = new System.Drawing.Point(301, 104),
                    FlatStyle = FlatStyle.Flat,
                };
                btnDeletar.FlatStyle = FlatStyle.Flat;
                btnDeletar.FlatAppearance.BorderSize = 0;
                var bmpDel = new Bitmap(APP.Properties.Resources.delete_32dp_FFFFFF_FILL0_wght400_GRAD0_opsz40);
                btnDeletar.Image = bmpDel;

                btnAceitar.Click += new EventHandler(btnAceitar_Click);
                btnAceitar.Tag = id;

                btnDeletar.Click += new EventHandler(btnDeletar_Click);
                btnDeletar.Tag = id;

                btnInfo.Click += new EventHandler(btnInfo_Click);
                btnInfo.Tag = id;

                pedidoPanel.Controls.Add(txtNome);
                pedidoPanel.Controls.Add(txtEmail);
                pedidoPanel.Controls.Add(txtDesc);

                this.SuspendLayout();

                if (p.status == 0)
                {
                    pedidoPanel.Controls.Add(btnAceitar);
                    pedidoPanel.Controls.Add(btnDeletar);
                    pedidoPanel.Controls.Add(btnInfo);

                    flpanelPedidosNovos.Controls.Add(pedidoPanel);
                }

                if (p.status == 1)
                {
                    RoundedButton btnConcluido = new RoundedButton()
                    {
                        BackColor = Color.DarkGreen,
                        Size = new Size(51, 27),
                        Location = new System.Drawing.Point(187, 104),
                        FlatStyle = FlatStyle.Flat,
                    };
                    btnConcluido.FlatStyle = FlatStyle.Flat;
                    btnConcluido.FlatAppearance.BorderSize = 0;
                    btnConcluido.Image = bmpAceitar;

                    btnConcluido.Click += new EventHandler(btnConcluido_Click);
                    btnConcluido.Tag = id;

                    RoundedButton btnVoltarNovo = new RoundedButton()
                    {
                        BackColor = Color.Gold,
                        Size = new Size(51, 27),
                        Location = new System.Drawing.Point(130, 104),
                        FlatStyle = FlatStyle.Flat,
                    };
                    btnVoltarNovo.FlatStyle = FlatStyle.Flat;
                    btnVoltarNovo.FlatAppearance.BorderSize = 0;
                    var bmpVoltar = new Bitmap(APP.Properties.Resources.arrow_back_32dp_FFFFFF_FILL0_wght400_GRAD0_opsz40);
                    btnVoltarNovo.Image = bmpVoltar;

                    btnVoltarNovo.Click += new EventHandler(btnVoltarNovo_Click);
                    btnVoltarNovo.Tag = id;

                    pedidoPanel.Controls.Add(btnConcluido);
                    pedidoPanel.Controls.Add(btnDeletar);
                    pedidoPanel.Controls.Add(btnInfo);
                    pedidoPanel.Controls.Add(btnVoltarNovo);

                    flpanelPedidosAndamento.Controls.Add(pedidoPanel);
                }

                if (p.status == 2)
                {
                    RoundedButton btnVoltarAndamento = new RoundedButton()
                    {
                        BackColor = Color.Gold,
                        Size = new Size(51, 27),
                        Location = new System.Drawing.Point(244, 104),
                        FlatStyle = FlatStyle.Flat,
                    };
                    btnVoltarAndamento.FlatStyle = FlatStyle.Flat;
                    btnVoltarAndamento.FlatAppearance.BorderSize = 0;
                    var bmpVoltar = new Bitmap(APP.Properties.Resources.arrow_back_32dp_FFFFFF_FILL0_wght400_GRAD0_opsz40);
                    btnVoltarAndamento.Image = bmpVoltar;

                    btnVoltarAndamento.Click += new EventHandler(btnVoltarAndamento_Click);
                    btnVoltarAndamento.Tag = id;

                    pedidoPanel.Controls.Add(btnVoltarAndamento);
                    pedidoPanel.Controls.Add(btnDeletar);

                    flpanelPedidosConcluidos.Controls.Add(pedidoPanel);
                }

                DateTime data = DateTime.Now;
                if (data > p.deadline && p.status == 1)
                {
                    string deadlinestring = p.deadline.ToString("dd-MM");
                    System.Windows.Forms.Label lblpedidoAtrasado = new System.Windows.Forms.Label()
                    {
                        Text = deadlinestring,
                        ForeColor = Color.Red,
                        Location = new Point(11, 106),
                        Font = new Font("Segoe UI Semibold", 14),
                    };
                    pedidoPanel.Controls.Add(lblpedidoAtrasado);

                    flpanelPedidosAtrasados.Controls.Add(pedidoPanel);

                    flpanelPedidosAtrasados.Visible = true;
                }

                this.ResumeLayout();
            }
        }

        private async void btnDeletar_Click(object sender, EventArgs e)
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
                await using (MySqlConnection conexao = new MySqlConnection(data_source))
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

                        recarregarPedidos();
                    }
                }
            }
        }

        private async void btnAceitar_Click(object sender, EventArgs e)
        {

            if (sender is not System.Windows.Forms.Button botao || botao.Tag == null)
                return;

            int id = (int)botao.Tag;

            await using (MySqlConnection conexao = new MySqlConnection(data_source))
            {
                try
                {
                    conexao.Open();

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

                recarregarPedidos();
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

        private async void btnConcluido_Click(object sender, EventArgs e)
        {
            if (sender is not System.Windows.Forms.Button botao || botao.Tag == null)
                return;

            int id = (int)botao.Tag;

            DialogResult resposta = MessageBox.Show("Marca Pedido como concluido?",
                                                    "Confirmar",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Information);

            if (resposta == DialogResult.Yes)
            {
                await using (MySqlConnection conexao = new MySqlConnection(data_source))
                {
                    try
                    {
                        conexao.Open();

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

                    recarregarPedidos();
                }
            }
        }

        private async void btnVoltarAndamento_Click(object sender, EventArgs e)
        {
            if (sender is not System.Windows.Forms.Button botao || botao.Tag == null)
                return;

            int id = (int)botao.Tag;

            DialogResult resposta = MessageBox.Show("Marca Pedido como em andamento?",
                                                    "Confirmar",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Information);

            if (resposta == DialogResult.Yes)
            {
                await using (MySqlConnection conexao = new MySqlConnection(data_source))
                {
                    try
                    {
                        conexao.Open();

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

                    recarregarPedidos();
                }
            }
        }

        private void btnVoltarNovo_Click(object sender, EventArgs e)
        {
            if (sender is not System.Windows.Forms.Button botao || botao.Tag == null)
                return;

            int id = (int)botao.Tag;

            DialogResult resposta = MessageBox.Show("Marca Pedido como novo?",
                                                    "Confirmar",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Information);

            if (resposta == DialogResult.Yes)
            {
                using (MySqlConnection conexao = new MySqlConnection(data_source))
                {
                    try
                    {
                        conexao.Open();

                        string sql = $"UPDATE formulario " +
                                     $"SET formulario.status = 0 " +
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

                    recarregarPedidos();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmFormulario f2 = new frmFormulario(this); // 'this' é a referência do Form1
            f2.Show();
        }

        private void butaoRecarregar_Click(object sender, EventArgs e)
        {
            recarregarPedidos();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            filtrarPedidos();
        }

        private async void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await filtrarPedidos();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm");
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void frm3DCreativeDesign_Load(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm");
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
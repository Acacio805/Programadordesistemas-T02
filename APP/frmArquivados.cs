using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP
{

    public partial class frmArquivados : Form
    {
        int id_selecionado;

        private frm3DCreativeDesign _form1;

        MySqlConnection Conexao;
        string data_source = "datasource=localhost;username=root;password=;database=acacio3d";
        public frmArquivados(frm3DCreativeDesign f3)
        {
            InitializeComponent();
            _form1 = f3;

            //Configuração inicial do ListView para exibição dos dados dos clientes
            lstPedidosArquivados.View = View.Details; //Define a visualização em "detalhes"
            lstPedidosArquivados.LabelEdit = true; //Pèrmite editar os titúlos das colunas
            lstPedidosArquivados.AllowColumnReorder = true; //Permite reordenar as colunas
            lstPedidosArquivados.FullRowSelect = true; //Seleciona a linha inteira ao clicar
            lstPedidosArquivados.GridLines = true; //Exibe as linhas de grade no ListView

            //Definindo as colunas do ListView
            lstPedidosArquivados.Columns.Add("ID", 40, HorizontalAlignment.Left);
            lstPedidosArquivados.Columns.Add("Nome", 200, HorizontalAlignment.Left);
            lstPedidosArquivados.Columns.Add("Contato", 200, HorizontalAlignment.Left);
            lstPedidosArquivados.Columns.Add("Descrição", 350, HorizontalAlignment.Left);
            lstPedidosArquivados.Columns.Add("Tipo de Modelo", 200, HorizontalAlignment.Left);
            lstPedidosArquivados.Columns.Add("Modelo para Jogo", 120, HorizontalAlignment.Left);
            lstPedidosArquivados.Columns.Add("Deadline", 120, HorizontalAlignment.Left);

            carregarLista();
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
            public bool modelo_jogo { get; set; }
        }

        private void carregarLista()
        {
            lstPedidosArquivados.Items.Clear();

            List<Pedido> listaPedidos = new List<Pedido>();

            using (MySqlConnection conexao = new MySqlConnection(data_source))
            {
                try
                {
                    conexao.Open();

                    string query = "SELECT formulario.id_comissao, formulario.id_cliente, formulario.contato, formulario.descricao, cliente.nome_cliente , formulario.status , formulario.deadline , formulario.tipo_modelo , formulario.modelo_jogo " +
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
                        p.Tipo = reader.GetString(7);
                        p.modelo_jogo = reader.GetBoolean(8);

                        listaPedidos.Add(p);
                    }

                    foreach (Pedido p in listaPedidos)
                    {
                        if (p.status == 4)
                        {
                            ListViewItem item = new ListViewItem(p.Id.ToString());

                            item.SubItems.Add(p.nome);
                            item.SubItems.Add(p.contato);
                            item.SubItems.Add(p.descricao);
                            item.SubItems.Add(p.Tipo);
                            if (p.modelo_jogo == true)
                            {
                                item.SubItems.Add("Sim");
                            }
                            else
                            {
                                item.SubItems.Add("Não");
                            }
                            item.SubItems.Add(p.deadline.ToString("dd/MM/yyyy"));

                            lstPedidosArquivados.Items.Add(item);
                        }
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
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            carregarLista();
        }



        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                carregarLista();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void lstPedidosArquivados_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListView.SelectedListViewItemCollection pedidoSelecao = lstPedidosArquivados.SelectedItems;

            // Percorre todos os itens selecionados (mesmo que normalmente só tenha um item selecionado)
            foreach (ListViewItem item in pedidoSelecao)
            {
                id_selecionado = Convert.ToInt32(item.SubItems[0].Text);
            }

            btnVoltar.Visible = true;
            btnDel.Visible = true;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int id = id_selecionado;

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

                        carregarLista();
                    }
                }
            }
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            int id = id_selecionado;

            DialogResult resposta = MessageBox.Show("Marca Pedido como em andamento?",
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

                    carregarLista();
                    _form1.recarregarPedidos();
                }
            }
        }
    }
}

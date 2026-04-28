using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP
{
    public partial class frmInfo : Form
    {
        //Conexão com o banco de dados MySQL
        MySqlConnection Conexao;
        string data_source = "datasource=localhost;username=root;password=;database=acacio3d";

        private frm3DCreativeDesign _form1; // Variável para guardar a referência

        public int id;

        public frmInfo(frm3DCreativeDesign f1)
        {
            InitializeComponent();
            _form1 = f1;
            id = _form1.Id_Pedido;
            CarregarPedido(id);
        }

        private void CarregarPedido(int id)
        {
            using (MySqlConnection conexao = new MySqlConnection(data_source))
            {
                try
                {
                    string sql = $"SELECT formulario.contato, formulario.descricao, cliente.nome_cliente, formulario.tipo_modelo, formulario.deadline, formulario.modelo_jogo " +
                                 $"FROM formulario " +
                                 $"INNER JOIN cliente ON formulario.id_comissao = cliente.id_cliente " +
                                 $"WHERE formulario.id_comissao = @id";

                    MySqlCommand comando = new MySqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("id", id);

                    conexao.Open();
                    MySqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        txtEmail.Text = reader.GetString(0);
                        txtDescricao.Text = reader.GetString(1);
                        txtNome.Text = reader.GetString(2);
                        switch (reader.GetString(3))
                        {
                            case "Roupas":
                                cbTipodeModelo.Text = "roupas";
                                break;
                            case "Personagem":
                                cbTipodeModelo.Text = "Personagem";
                                break;
                            case "Pacote de Vegetação":
                                cbTipodeModelo.Text = "Pacote de Vegetação";
                                break;
                            case "Pacote de Modelos Variados":
                                cbTipodeModelo.Text = "Pacote de Modelos Variados";
                                break;
                            default:
                                break;
                        }

                        DateTime data = reader.GetDateTime(4);
                        dtpDataEntrega.Value = data;

                        byte modelo_jogo = reader.GetByte(5);
                        if (modelo_jogo == 1)
                        {
                            cbModeloJogo.Text = "Sim";
                        }
                        else
                        {
                            cbModeloJogo.Text = "Não";
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
                finally
                {
                    //Garante que a conexão com o banco será fechada, mesmo se ocorrer erro
                    if (conexao != null && conexao.State == ConnectionState.Open)
                    {
                        conexao.Close();
                    }
                }
            }

        }

        private void AtualizarPedido()
        {
            using (MySqlConnection conexao = new MySqlConnection(data_source))
            {
                conexao.Open();
                try
                {
                    string sql = $"UPDATE formulario " +
                                 $"INNER JOIN cliente " +
                                 $" ON formulario.id_comissao = cliente.id_cliente " +
                                 $"SET " +
                                 $"formulario.contato = @contato, " +
                                 $"formulario.descricao = @descricao, " +
                                 $"cliente.nome_cliente = @nome, " +
                                 $"formulario.tipo_modelo = @tipo_modelo, " +
                                 $"formulario.deadline = @deadline, " +
                                 $"formulario.modelo_jogo = @modelo_jogo " +    
                                 $"WHERE formulario.id_comissao = @id";

                    MySqlCommand comando = new MySqlCommand(sql, conexao);
                    
                    comando.Parameters.AddWithValue("id", id);
                    
                    comando.Parameters.AddWithValue("contato", txtEmail.Text.Trim());
                    comando.Parameters.AddWithValue("nome", txtNome.Text.Trim());
                    comando.Parameters.AddWithValue("descricao", txtDescricao.Text.Trim());

                    comando.Parameters.AddWithValue("tipo_modelo", cbTipodeModelo.Text.Trim());

                    byte modeloJogo = cbModeloJogo.Text.Trim().Equals("Sim")
                        ? (byte)1
                        : (byte)0;
                    comando.Parameters.AddWithValue("modelo_jogo", modeloJogo);

                    DateTime data = dtpDataEntrega.Value;
                    comando.Parameters.AddWithValue("deadline", data);

                    comando.ExecuteNonQuery();

                    // Mensagem de sucesso
                    MessageBox.Show($"Os dados do pedido foram alterados com Sucesso.",
                                    "Sucesso",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    _form1.regarregarPedidos();
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
            }

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarPedido();
        }
    }
}       
        
 


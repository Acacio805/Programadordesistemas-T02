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
    public partial class frmInfo : Form
    {
        //Conexão com o banco de dados MySQL
        MySqlConnection Conexao;
        string data_source = "datasource=localhost;username=root;password=;database=acacio3d";

        private frm3DCreativeDesign _form1; // Variável para guardar a referência

        public frmInfo(frm3DCreativeDesign f1)
        {
            InitializeComponent();
            _form1 = f1;
            int Id_pedido = _form1.Id_Pedido ;
            CarregarPedido(Id_pedido);
        }


        private void CarregarPedido(int id)
        {
            using (MySqlConnection conexao = new MySqlConnection(data_source))
            {
                try
                {
                    string sql = $"SELECT formulario.contato, formulario.descricao, cliente.nome_cliente, formulario.tipo_modelo, formulario.deadline  " +
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
                        string dataTexto = reader.GetString(4);
                        
                       // DateTime data = DateTime.ParseExact(dataTexto, "dd/MM/YYYY");
                       // dtpDataEntrega.Value = data;

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
    }
}       
        
 


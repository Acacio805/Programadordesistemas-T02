using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Acessando o pacote do mysql
using MySql.Data.MySqlClient;


namespace crud
{
    public partial class frmCadastrodeClientes : Form
    {
        //Conexão com o banco de dados MySQL
        MySqlConnection Conexao;
        string data_source = "datasource=localhost; username=root; password=; database=db_cadastro";
        
        public frmCadastrodeClientes()
        {
            InitializeComponent();

            //Configuração inicial do ListView para exibição dos dados dos clientes
            lstCliente.View = View.Details; //Define a visualização em "detalhes"
            lstCliente.LabelEdit = true; //Pèrmite editar os titúlos das colunas
            lstCliente.AllowColumnReorder = true; //Permite reordenar as colunas
            lstCliente.FullRowSelect = true; //Seleciona a linha inteira ao clicar
            lstCliente.GridLines = true; //Exibe as linhas de grade no ListView

            //Definindo as colunas do ListView
            lstCliente.Columns.Add("Codigo", 80, HorizontalAlignment.Left); // Coluna de código
            lstCliente.Columns.Add("Nome Completo", 200, HorizontalAlignment.Left); // Coluna de Nome Completo
            lstCliente.Columns.Add("Nome Social", 200, HorizontalAlignment.Left); // Coluna do Nome Social
            lstCliente.Columns.Add("E-Mail", 200, HorizontalAlignment.Left); // Coluna do E-Mail
            lstCliente.Columns.Add("CPF", 200 , HorizontalAlignment.Left); // Coluna do CPF

            // Carrega os dados dos clientes na interface
            carregar_Clientes();
        } 

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //Validade campos obrigatorios
                if (string.IsNullOrEmpty(txtNomeCompleto.Text.Trim()) ||
                    string.IsNullOrEmpty(txtEmail.Text.Trim()) ||
                    string.IsNullOrEmpty(txtCPF.Text.Trim())
                    ) 
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos.", "Validação",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return; // Impede o prosseguimento se algum campo estiver vazio
                }

                //Validação do CPF
                string cpf = txtCPF.Text.Trim();
                
                if (!IsValidCPFLength(cpf)) 
                {
                    MessageBox.Show("CPF inválido. Certifique-se de que o CPF tenha 11 digitos", "Validação do CPF",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    return; // Impede o prosseguimento se o CPF for inválido
                }

                // Cria a conexão com o banco de dados
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                // Comando SQL para inserir um novo cliente no banco de dados
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Conexao,
                };

                cmd.Prepare();
                cmd.CommandText = "INSERT INTO dadosdocliente(nomecompleto, nomesocial, email, cpf) " + 
                    "Values(@nomecompleto, @nomesocial, @email, @cpf)";

                //Adiciona os parâmetros para os dados do formulário
                cmd.Parameters.AddWithValue("@nomecompleto", txtNomeCompleto.Text.Trim());
                cmd.Parameters.AddWithValue("@nomesocial", txtNomeSocial.Text.Trim());
                cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@cpf", txtCPF.Text.Trim());
            
                // Executa o comando de inserção no banco
                cmd.ExecuteNonQuery();

                // Mensagem de sucesso
                MessageBox.Show("Contato inserido com Sucesso: ", 
                                "Sucesso", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Information);

                // Limpa os campos após o sucesso
                txtNomeCompleto.Text = String.Empty;
                txtNomeSocial.Text = String.Empty;
                txtEmail.Text = String.Empty;
                txtCPF.Text = String.Empty;

                // Recarregar os clientes na ListVIew
                carregar_Clientes();

                // Muda para a ba de consulta
                tabControl1.SelectedIndex = 1;

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
                MessageBox.Show("Ocorreu: " + ex.Message ,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally 
            {
                //Garante que a conexão com o banco será fechada, mesmo se ocorrer erro
                if (Conexao != null && Conexao.State == ConnectionState.Open)
                {
                    Conexao.Close();
                }
            }
        }

        // Função para validar o comprimento e formato do CPF
        private bool IsValidCPFLength(string cpf)
        {
            // Remove todos os caracteres não numéricos
            cpf = new string(cpf.Where(char.IsDigit).ToArray());

            // verifica se o cpf tem exatamente 11 dígitos
            return cpf.Length == 11;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM dadosdocliente WHERE nomecompleto LIKE @q OR nomesocial LIKE @q ORDER BY codigo desc";
            carregar_Clientes_com_query(query);
        }

        private void carregar_Clientes_com_query(string query)
        {
            try 
            {
                // Cria a conexão com o banco de dados
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                // Executa a consulta SQL fornecida
                MySqlCommand cmd = new MySqlCommand(query, Conexao);

                //Se a consulta contém o parâmetro @q, adiciona o valor da caixa de pesquisa
                if (query.Contains("@q"))
                {
                    cmd.Parameters.AddWithValue("@q", "%" + txtBuscar.Text + "%");
                }

                // Executa o comando e obtém os resultados
                MySqlDataReader reader = cmd.ExecuteReader();

                // Limpa os items existentes no ListView antes de adicionar novos
                lstCliente.Items.Clear();

                // Preenche o ListView com os dados dos clientes
                while (reader.Read())
                {
                    // Cria uma linha para cada cliente com os dados retornados da consulta
                    string[] row =
                    {
                        Convert.ToString(reader.GetInt32(0)),   //Codigo
                        reader.GetString(1),                    //Nome Completo
                        reader.GetString(2),                    //Nome Social
                        reader.GetString(3),                    //E-mail
                        reader.GetString(4),                    //CPF
                    };
                
                    // Adiciona a linha ao ListView
                    lstCliente.Items.Add(new ListViewItem(row));
                }
            }
            catch (MySqlException ex)
            {
                // Trata erros relacionados ao MySQL
                MessageBox.Show("Erro " + ex.Number + " Ocorreu: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Trata outros tipos de erro
                MessageBox.Show("Ocorreu: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Garante que a conexão com o banco será fechada, mesmo se ocorrer erro
                if (Conexao != null && Conexao.State == ConnectionState.Open)
                {
                    Conexao.Close();
                }
            }
        }
        private void carregar_Clientes()
        {
            string query = "SELECT * FROM dadosdocliente ORDER BY codigo DESC";
            carregar_Clientes_com_query(query);

        }
    }
}

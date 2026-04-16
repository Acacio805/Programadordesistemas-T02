using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APP;

namespace APP
{
    public partial class frmFormulario : Form
    {        
        private frm3DCreativeDesign _form1; // Variável para guardar a referência
        
        string data_source =
            "datasource=localhost;username=root;password=;database=acacio3d";
        
        // Modifique o construtor para receber o Form1
        public frmFormulario(frm3DCreativeDesign f1)
        {
            InitializeComponent();
            _form1 = f1;
        }

        private void btnAdicionarPedido_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexao = new MySqlConnection(data_source))
            {
                conexao.Open();

                using (MySqlTransaction transacao = conexao.BeginTransaction())
                {
                    try
                    {
                        //Validade campos obrigatorios
                        if (string.IsNullOrEmpty(txtNome.Text.Trim()))
                        {
                            MessageBox.Show("Nome não pode estar vazio.", "Validação",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Warning);
                            return; // Impede o prosseguimento se algum campo estiver vazio
                        }
                        if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
                        {
                            MessageBox.Show("Email não pode estar vazio.", "Validação",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Warning);
                            return; // Impede o prosseguimento se algum campo estiver vazio
                        }
                        if (string.IsNullOrEmpty(cbTipodeModelo.Text.Trim()))
                        {
                            MessageBox.Show("Tipo de Modelo não pode estar vazio.", "Validação",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Warning);
                            return; // Impede o prosseguimento se algum campo estiver vazio
                        }


                        MySqlCommand cmd = new MySqlCommand();
                        cmd.Connection = conexao;
                        cmd.Transaction = transacao;

                        // Inserir cliente e pegar id
                        cmd.CommandText = @"
                            INSERT INTO cliente (nome_cliente)
                            VALUES (@nome_cliente);
                            SELECT LAST_INSERT_ID();
                        ";

                        cmd.Parameters.AddWithValue(
                            "@nome_cliente", txtNome.Text.Trim()
                        );

                        long id_cliente =
                            Convert.ToInt64(cmd.ExecuteScalar());

                        // Inserir formulario
                        cmd.Parameters.Clear();

                        cmd.CommandText = @"
                            INSERT INTO formulario
                            (contato, deadline, descricao, modelo_jogo, tipo_modelo, id_cliente)
                            VALUES
                            (@contato, @deadline, @descricao, @modelo_jogo, @tipo_modelo, @id_cliente)
                        ";

                        cmd.Parameters.AddWithValue(
                            "@contato", txtEmail.Text.Trim()
                        );

                        cmd.Parameters.AddWithValue(
                            "@deadline", dtpDataEntrega.Value
                        );

                        cmd.Parameters.AddWithValue(
                            "@descricao", txtDescricao.Text.Trim()
                        );

                        byte modeloJogo = rbtnModeloJogo.Checked
                            ? (byte)1
                            : (byte)0;

                        cmd.Parameters.AddWithValue(
                            "@modelo_jogo", modeloJogo
                        );

                        cmd.Parameters.AddWithValue(
                            "@tipo_modelo", cbTipodeModelo.Text.Trim()
                        );

                        cmd.Parameters.AddWithValue(
                            "@id_cliente", id_cliente
                        );

                        cmd.ExecuteNonQuery();

                        transacao.Commit();

                        MessageBox.Show(
                            "Cliente e formulário inseridos com sucesso.",
                            "Sucesso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        _form1.regarregarPedidos();

                    }
                    catch (Exception ex)
                    {
                        transacao.Rollback();
                        MessageBox.Show(
                            "Erro: " + ex.Message,
                            "Erro",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                    finally
                    {
                        // Garante que a conexão com o banco será fechada, mesmo que ocorra erros
                        if (conexao != null && conexao.State == ConnectionState.Open)
                        {
                            conexao.Close();
                        }
                    }

                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Importa o pacote para trabalhar com o SQL Server;

namespace menu_clientes
{
    public partial class FormCadastroCliente : Form

    {
        // String de conexão com o SQL Server;
        private string connectionString = "Server=localhost;Database=projetoMenuClientes;Integrated Security=True;";
        public FormCadastroCliente()
        {
            InitializeComponent();
        }

        private void FormCadastroCliente_KeyDown(object sender, KeyEventArgs e)
        {
            //Pega o evento quando o ENTER é pressionado e o interpreta como TAB;
            if (e.KeyCode == Keys.Return) {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void salvarClienteSQL()
        {
            //Conexão com o DB;
            //USING Garante o fechamento do banco após a execução;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "INSERT INTO clientes (nome, documento, genero, rg, estado_civil, dt_nascimento, cep, endereco, numero, bairro, cidade, estado, celular, email, observacoes, situacao) " +
              "VALUES(@nome, @documento, @genero, @rg, @estado_civil, @dt_nascimento, @cep, @endereco, @numero, @bairro, @cidade, @estado, @celular, @email, @observacoes, @situacao);";

                        cmd.Parameters.AddWithValue("@nome", nomeCliente.Text);
                        cmd.Parameters.AddWithValue("@documento", documento.Text);
                        cmd.Parameters.AddWithValue("@genero", "GENERO"); // Substituir por variável correta
                        cmd.Parameters.AddWithValue("@rg", rg.Text);
                        cmd.Parameters.AddWithValue("@estado_civil", estado_civil.Text);
                        cmd.Parameters.AddWithValue("@dt_nascimento", dtNasc.Text);
                        cmd.Parameters.AddWithValue("@cep", cep.Text);
                        cmd.Parameters.AddWithValue("@endereco", endereco.Text);
                        cmd.Parameters.AddWithValue("@numero", num_casa.Text);
                        cmd.Parameters.AddWithValue("@bairro", bairro.Text);
                        cmd.Parameters.AddWithValue("@cidade", cidade.Text);
                        cmd.Parameters.AddWithValue("@estado", estado.Text);
                        cmd.Parameters.AddWithValue("@celular", numCelular.Text);
                        cmd.Parameters.AddWithValue("@email", email.Text);
                        cmd.Parameters.AddWithValue("@observacoes", observacoes.Text);
                        cmd.Parameters.AddWithValue("@situacao", "SITUAÇÃO");

                        cmd.ExecuteNonQuery();

                    }

                    MessageBox.Show("Cadastrado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            salvarClienteSQL();
        }
    }
}

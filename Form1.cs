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
            if (e.KeyCode == Keys.Return) {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
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
                        cmd.CommandText = "INSERT INTO clientes (nome, documento) VALUES(@nome, @documento);";
                        cmd.Parameters.AddWithValue("@nome", textBox2.Text);
                        cmd.Parameters.AddWithValue("@documento", maskedTextBox1.Text);
                        cmd.ExecuteNonQuery();
                    }

                        MessageBox.Show("Conectado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography; // Importa o pacote para trabalhar com o SQL Server;

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

                        if (masculino.Checked == true)
                        {
                            cmd.Parameters.AddWithValue("@genero", "Masculino");
                        }
                        else if (feminino.Checked == true)
                        {
                            cmd.Parameters.AddWithValue("@genero", "Feminino");
                        }
                        else if (outroGenero.Checked == true) 
                        {
                            cmd.Parameters.AddWithValue("@genero", "Outros");
                        }

                        cmd.Parameters.AddWithValue("@rg", rg.Text);
                        cmd.Parameters.AddWithValue("@estado_civil", estado_civil.Text);
                        
                        if (dtNasc.Text == "  /  /")
                            cmd.Parameters.AddWithValue("@dt_nascimento", DBNull.Value); // Salvando nulo
                        else
                            cmd.Parameters.AddWithValue("@dt_nascimento", Convert.ToDateTime(dtNasc.Text));


                        cmd.Parameters.AddWithValue("@cep", cep.Text);
                        cmd.Parameters.AddWithValue("@endereco", endereco.Text);
                        cmd.Parameters.AddWithValue("@numero", num_casa.Text);
                        cmd.Parameters.AddWithValue("@bairro", bairro.Text);
                        cmd.Parameters.AddWithValue("@cidade", cidade.Text);
                        cmd.Parameters.AddWithValue("@estado", estado.Text);
                        cmd.Parameters.AddWithValue("@celular", numCelular.Text);
                        cmd.Parameters.AddWithValue("@email", email.Text);
                        cmd.Parameters.AddWithValue("@observacoes", observacoes.Text);

                        if (situacao.Checked)
                        {
                            cmd.Parameters.AddWithValue("@situacao", "Ativo");
                        }
                        else 
                        {
                            cmd.Parameters.AddWithValue("@situacao", "Inativo");
                        }


                        cmd.ExecuteNonQuery();

                        cmd.CommandText = "SELECT @@IDENTITY";
                        id.Text = cmd.ExecuteScalar().ToString();

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

            if (validacoes() == true)
                return;

            salvarClienteSQL();
        }

        private bool validacoes()
        {
            if (nomeCliente.Text == "")
            {
                MessageBox.Show("Campo nome é obrigatório");
                nomeCliente.Focus();
                return true;
            }

            if (!cpf.Checked && !cnpj.Checked)
            {
                MessageBox.Show("Selecione o tipo do documento:\rCPF ou CNPJ.");
                return true;
            }

            if (documento.Text == "")
            {
                if (cpf.Checked == true)
                {
                    MessageBox.Show("Informe o CPF!");
                }
                else
                {
                    MessageBox.Show("Informe o CNPJ!");
                }

                documento.Focus();
                return true;
            }

            if (!masculino.Checked && !feminino.Checked && !outroGenero.Checked)
            {
                MessageBox.Show("Selecione o genero");
                return true;
            }

            if (dtNasc.Text != "  /  /")
            {
                try
                {
                    Convert.ToDateTime(dtNasc.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Digite uma data de nascimento válida!");
                    return true;
                }
            }



            return false;
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja limpar todos os campos?", "ATENÇÃO", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            id.Text = "";
            nomeCliente.Text = "";
            cpf.Checked = false;
            cnpj.Checked = false;
            documento.Text = "";
            masculino.Checked = false;  
            feminino.Checked = false;   
            outroGenero.Checked = false;
            rg.Text = "";
            estado_civil.Text = "";
            dtNasc.Text = "";
            cep.Text = "";
            endereco.Text = "";
            num_casa.Text = "";
            bairro.Text = "";
            cidade.Text = "";
            estado.Text = "";
            numCelular.Text = "";
            email.Text = "";
            observacoes.Text = "";
            situacao.Checked = true;

        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

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
using System.Drawing;
using System.IO;

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
                Funcoes.msgAlerta("Campo nome é obrigatório");
                nomeCliente.Focus();
                return true;
            }

            if (!cpf.Checked && !cnpj.Checked)
            {
                Funcoes.msgAlerta("Selecione o tipo do documento:\rCPF ou CNPJ.");
                return true;
            }

            if (documento.Text == "")
            {
                if (cpf.Checked == true)
                {
                    Funcoes.msgAlerta("Informe o CPF!");
                }
                else
                {
                    Funcoes.msgAlerta("Informe o CNPJ!");
                }

                documento.Focus();
                return true;
            }

            if (!masculino.Checked && !feminino.Checked && !outroGenero.Checked)
            {
                Funcoes.msgAlerta("Selecione o genero");
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
                    Funcoes.msgErro("Digite uma data de nascimento válida!");
                    return true;
                }
            }



            return false;
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            if (Funcoes.msgConfirmar("Deseja limpar todos os campos?") == false )
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

        private void cpf_CheckedChanged(object sender, EventArgs e)
        {
            if (cpf.Checked)
                documento.Mask = "000,000,000-00";
                documento.Focus();
            
        }

        private void cnpj_CheckedChanged(object sender, EventArgs e)
        {
            if (cnpj.Checked)
                documento.Mask = "00,000,000/0000-00";
                documento.Focus();
        }

        private void masculino_CheckedChanged(object sender, EventArgs e)
        {
            rg.Focus();
        }

        private void feminino_CheckedChanged(object sender, EventArgs e)
        {
            rg.Focus();
        }
       
        private void outroGenero_CheckedChanged(object sender, EventArgs e)
        {
            rg.Focus();
        }
        private void dtNasc_Validating(object sender, CancelEventArgs e)
        {
            if (dtNasc.Text == "  /  /")
                return;

            try
            {
                dtNasc.Text = Convert.ToDateTime(dtNasc.Text).ToString();
            }
            catch (Exception)
            {
                Funcoes.msgErro("Data inválida");
                e.Cancel = true;
            }
        }

        private void estado_civil_Validating(object sender, CancelEventArgs e)
        {
            if (estado_civil.Text == "")
                return;

            if (estado_civil.SelectedIndex == -1)
            {
                Funcoes.msgAlerta("Selecione um estado civil válido");
                e.Cancel = true;
            }
        }

        private void estado_Validating(object sender, CancelEventArgs e)
        {
            if (estado.Text == "")
                return;

            if (estado.SelectedIndex == -1)
            {
                Funcoes.msgAlerta("Selecione um estado válido");
                e.Cancel = true;
            }
        }

        private void cep_Validating(object sender, CancelEventArgs e)
        {
            if (cep.Text.Length == 0)
                return;
            if (cep.Text.Length < 8)
            {
                Funcoes.msgErro("Formato de CEP inválido");
                e.Cancel = true;
            }
        }

        private void documento_Validating(object sender, CancelEventArgs e)
        {
            if (documento.Text == "") return;

            if (cpf.Checked && documento.Text.Replace(" ", "").Length < 11)
            {
                Funcoes.msgErro("CPF Incompleto ou inválido");
                e.Cancel = true;
            }

            if (cnpj.Checked && documento.Text.Replace(" ", "").Length < 14)
            {
                Funcoes.msgErro("CNPJ Incompleto ou inválido.");
                e.Cancel = true;
            }
        }

        private void nomeCliente_TextChanged(object sender, EventArgs e)
        {
            Funcoes.priMaiuscula(nomeCliente);
        }

        private void endereco_TextChanged(object sender, EventArgs e)
        {
            Funcoes.priMaiuscula(endereco);
        }

        private void bairro_TextChanged(object sender, EventArgs e)
        {
            Funcoes.priMaiuscula(bairro);
        }

        private void cidade_TextChanged(object sender, EventArgs e)
        {
            Funcoes.priMaiuscula(cidade);
        }

        private void btAddFoto_Click(object sender, EventArgs e)
        {
            if (id.Text == "")
            {
                Funcoes.msgAlerta("É necessário salvar o cadastro antes.");
                return;
            }

            OpenFileDialog box = new OpenFileDialog();

            box.Filter = "Arquivos de imagem | *.jpg; *.jpeg; *.png; *.gif; *.bmp";

            if (box.ShowDialog() == DialogResult.OK)
            {
                fotoCliente.Image = Image.FromFile(box.FileName);

                File.Copy(box.FileName, AppDomain.CurrentDomain.BaseDirectory + "/fotos_clientes/" + id.Text + ".jpg");
            }
        }

        private void btRemoveFoto_Click(object sender, EventArgs e)
        {
            if (id.Text == "")
            {
                Funcoes.msgErro("Não há foto para ser removida");
                return;
            }

            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "/fotos_clientes/" + id.Text + ".jpg") == false)
            {
                Funcoes.msgErro("Não há foto para ser removida");
                return;
            }

            if (Funcoes.msgConfirmar("Deseja remover a foto ?") == false) return;

            fotoCliente.Image = Properties.Resources.avatar;

            File.Delete(AppDomain.CurrentDomain.BaseDirectory + "/fotos_clientes/" + id.Text + ".jpg");
        }

        private void FormCadastroCliente_Load(object sender, EventArgs e)
        {
            using(SqlConnection conexao = new SqlConnection("Server=localhost;Database=projetoMenuClientes;Integrated Security=True;"))
            { 
                
            }
        }
    }
}
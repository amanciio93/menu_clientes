using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace menu_clientes
{
    public partial class FormMenuClientes : Form
    {

        private string fotos_clientes = AppDomain.CurrentDomain.BaseDirectory + "/fotos_clientes/";

        public FormMenuClientes()
        {
            InitializeComponent();
        }

        private void btAddCliente_Click(object sender, EventArgs e)
        {
            FormCadastroCliente fcc = new FormCadastroCliente();

            fcc.ShowDialog();

            buscarClientes();
        }

        private void FormMenuClientes_Load(object sender, EventArgs e)
        {
            buscarClientes();
            //this.reportFicha.RefreshReport();
        }

        private void dgLista_Sorted(object sender, EventArgs e)
        {
            reorganizar();
        }

        private void reorganizar() {

            dgLista.ClearSelection();
            btEditarCliente.Enabled = false;

            foreach (DataGridViewRow linha in dgLista.Rows)
            {
                if (linha.Cells["situacao"].Value.ToString() == "Inativo")
                {
                    linha.DefaultCellStyle.ForeColor = Color.Red;
                }
                if (File.Exists(fotos_clientes + linha.Cells["id"].Value.ToString() + ".jpg"))
                    //linha.Cells["foto"].Value = Image.FromFile(fotos_clientes + linha.Cells["id"].Value.ToString() + ".jpg");
                    using (FileStream temp = new FileStream(fotos_clientes + linha.Cells["id"].Value.ToString() + ".jpg", FileMode.Open, FileAccess.Read))
                    {
                        Image img = Image.FromStream(temp);
                        linha.Cells["foto"].Value = img;
                    }
                else
                    linha.Cells["Foto"].Value = Properties.Resources.avatar;
            }
        }

        private void dgLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btEditarCliente.Enabled = true;
        }

        private void btEditarCliente_Click(object sender, EventArgs e)
        {
            FormCadastroCliente frm = new FormCadastroCliente();

            frm.id.Text = dgLista.CurrentRow.Cells["id"].Value.ToString();

            frm.ShowDialog();

            buscarClientes();

        }

        private void buscarClientes()
        {
            dgLista.DataSource = Funcoes.buscaSQL("SELECT * FROM clientes WHERE 1 = 1" + gerarCriterios());
            if ((dgLista.RowCount * 30) + 55 > 530)
                dgLista.Height = 530;
            else
                dgLista.Height = (dgLista.RowCount * 30) + 55;

            reorganizar();

            rodape();

            if (dgLista.RowCount == 0)
                nadaEncontrado.Visible = true;
            else
                nadaEncontrado.Visible = false;
        }

        private void searchId_TextChanged(object sender, EventArgs e)
        {
            buscarClientes();
        }

        private string gerarCriterios()
        {

            string c = "";

            if (searchId.Text != string.Empty)
            {
                c += " AND id = " + searchId.Text;
            }

            if (searchNome.Text != string.Empty)
            {
                c += $" AND (nome LIKE '%{searchNome.Text}%' OR documento LIKE '%{searchNome.Text}%')";
            }

            if (searchGenero.Text != string.Empty)
            {
                c += $" AND genero = '{searchGenero.Text}'";
            }

            if (searchEstadoCivil.Text != string.Empty)
            {
                c += $" AND estado_civil = '{searchEstadoCivil.Text}'";
            }

            if (searchEndereco.Text != string.Empty)
            {
                c += $" AND (endereco LIKE '%{searchEndereco.Text}%' OR numero LIKE '%{searchEndereco.Text}%' OR bairro LIKE '%{searchEndereco.Text}%' OR cidade LIKE '%{searchEndereco.Text}%' OR cep LIKE '%{searchEndereco.Text}%' OR estado LIKE '%{searchEndereco.Text}%')";
            }

            try
            {
                DateTime dtNasc = Convert.ToDateTime(searchNasc.Text);
                c += $" AND dt_nascimento = '{dtNasc.ToString("yyyy-MM-dd")}'";
            }
            catch (Exception)
            {

            }

            if (searchAtivo.Checked == true)
            {
                c += " AND situacao = 'Ativo'";
            }
            else if (searchInativos.Checked == true)
            {
                c += " AND situacao = 'Inativo'";
            }

            return c;
        }

        private void searchNome_TextChanged(object sender, EventArgs e)
        {
            buscarClientes();
        }

        private void searchAll_CheckedChanged(object sender, EventArgs e)
        {
            if (searchAll.Checked == true)
                buscarClientes();
        }

        private void searchAtivo_CheckedChanged(object sender, EventArgs e)
        {
            if (searchAtivo.Checked == true)
                buscarClientes();
        }

        private void searchInativos_CheckedChanged(object sender, EventArgs e)
        {
            if (searchInativos.Checked == true)
                buscarClientes();
        }

        private void rodape()
        {
            totalLocalizado.Text = "Total localizado: " + dgLista.RowCount;

            int cont = 0;

            foreach (DataGridViewRow linha in dgLista.Rows)
            {
                if (linha.Cells["situacao"].Value.ToString() == "Inativo")
                    cont++;
            }

            totalInativos.Text = "Inativos: " + cont.ToString();
            totalAtivos.Text = "Ativos: " + (dgLista.RowCount -  cont).ToString();

        }

        private void dgLista_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            dgLista.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.DarkSlateGray;
        }

        private void dgLista_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            //Usando condição ternária;
            dgLista.Rows[e.RowIndex].DefaultCellStyle.BackColor = 
                (e.RowIndex % 2 == 0 ? Color.White : Color.Silver);
        }

        private void btGerarPDF_Click(object sender, EventArgs e)
        {
            Funcoes.ImprimirPDF(reportFicha, "FichaCadastral");
        }
    }
}
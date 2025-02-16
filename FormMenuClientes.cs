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
        }

        private void FormMenuClientes_Load(object sender, EventArgs e)
        {
            dgLista.DataSource = Funcoes.buscaSQL("SELECT * FROM clientes;");

            foreach (DataGridViewRow linha in dgLista.Rows)
            {
                if (linha.Cells["situacao"].Value.ToString() == "Inativo")
                { 
                    linha.DefaultCellStyle.ForeColor = Color.Red;
                }
                if (File.Exists(fotos_clientes + linha.Cells["id"].Value.ToString() + ".jpg"))
                    linha.Cells["foto"].Value = Image.FromFile(fotos_clientes + linha.Cells["id"].Value.ToString() + ".jpg");
                else
                    linha.Cells["Foto"].Value = Properties.Resources.avatar;
            }
        }        
    }
}

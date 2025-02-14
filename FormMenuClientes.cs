using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu_clientes
{
    public partial class FormMenuClientes : Form
    {
        public FormMenuClientes()
        {
            InitializeComponent();
        }

        private void btAddCliente_Click(object sender, EventArgs e)
        {
            FormCadastroCliente fcc = new FormCadastroCliente();
            fcc.ShowDialog();
        }
    }
}

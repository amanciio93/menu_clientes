using System.Globalization;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Reporting.WinForms;
using System.IO;
using System;

namespace menu_clientes
{
    internal class Funcoes
    {

        public static void msgErro(string Msg)
        {
            MessageBox.Show(Msg, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void msgAlerta(string Msg)
        {
            MessageBox.Show(Msg, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void msgOkay(string Msg)
        {
            MessageBox.Show(Msg, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool msgConfirmar(string Msg)
        {
            if (MessageBox.Show(Msg, "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                return true;
            else
                return false;
        }

        public static void priMaiuscula(Control ctr)
        {
            TextInfo textInfo = new CultureInfo("pt-BR", false).TextInfo;

            string t = ctr.Text;

            t = textInfo.ToTitleCase(t);

            t = t.Replace(" Das ", " da ")
                 .Replace(" Da ", " da ")
                 .Replace(" Dos ", " do ")
                 .Replace(" Do ", " do ")
                 .Replace(" De ", " de")
                 .Replace(" Os ", " os ");

            ctr.Text = t;

            if (ctr is TextBox txt)
                txt.SelectionStart = txt.Text.Length;

            if (ctr is ComboBox cb)
                cb.SelectionStart = cb.Text.Length;
        }

        public static DataTable buscaSQL(string sqlCommand)
        {

            DataTable dt = new DataTable();

            using (SqlConnection conexao = new SqlConnection("Server=localhost;Database=projetoMenuClientes;Integrated Security=True;"))
            {
                conexao.Open();

                using (SqlCommand cmd = conexao.CreateCommand())
                {

                    cmd.CommandText = sqlCommand;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt;
        }

        public static void carregarDados(ComboBox cb, string tabela, string campo)
        {
            cb.DataSource = Funcoes.buscaSQL("SELECT DISTINCT " + campo + " FROM " + tabela + " WHERE " + campo + " <> '';");
            cb.SelectedIndex = -1;
        }

        public static void ImprimirPDF(ReportViewer report, string nomeArquivo, ReportParameterCollection p = null)
        {
            if (p != null)
                report.LocalReport.SetParameters(p);

            report.Refresh();
            report.RefreshReport();

            try
            {
                Warning[] warnings;
                string[] streamids;
                string mimeType;
                string encoding;
                string filenameExtension;

                byte[] bytes = report.LocalReport.Render(
                "PDF", null, out mimeType, out encoding, out filenameExtension,
                out streamids, out warnings);
                using (FileStream fs = new FileStream(nomeArquivo + ".pdf", FileMode.Create))
                {
                    fs.Write(bytes, 0, bytes.Length);
                }

                System.Diagnostics.Process.Start(nomeArquivo + ".pdf");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "C# Cadastro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}

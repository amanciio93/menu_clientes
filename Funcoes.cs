using System.Globalization;
using System.Windows.Forms;

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
                 .Replace(" De ", " de");

            ctr.Text = t;

            if(ctr is TextBox txt)
                txt.SelectionStart = txt.Text.Length;

            if (ctr is ComboBox cb)
                cb.SelectionStart = cb.Text.Length;
        }
    }
}

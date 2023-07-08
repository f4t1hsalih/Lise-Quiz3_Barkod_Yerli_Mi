using System.Windows.Forms;

namespace Quiz3_Barkod_Yerli_Mi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string b,c;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                b = textBox1.Text;

                if (textBox1.Text.Length == 13)
                {
                    c = b.Substring(0, 3);
                    if (c == "868" || c == "869") pictureBox1.Image = Properties.Resources.Yerli;
                    else pictureBox1.Image = Properties.Resources.YerliDegil;
                }
                else MessageBox.Show("Barkod'da Yetersiz Karakter Var");
            }
        }
    }
}

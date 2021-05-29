using System;
using System.Windows.Forms;

namespace B1Rec
{
    public partial class Hyrje : Form
    {
        public Hyrje()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Llogaritja f = new Llogaritja();
            f.lblPuntori.Text = lblPunto.Text;
            f.lblMoney.Text = txtParat.Text;
            f.Show();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime.Now.GetDateTimeFormats();
        }

        private void Hyrje_Load(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString();
        }

        private void txtParat_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (chr == 46 && txtParat.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(chr) && chr != 8 && chr != 46)
            {
                e.Handled = true;
                MessageBox.Show("Ju lutem shtypni vetem numra ");
            }
        }
    }
}

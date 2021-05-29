using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace B1Rec
{

    public partial class Llogaritja : Form
    {
        Billing bill = new Billing();
        Blerjet model = new Blerjet();
        string Bakeri;
        string Mesing;
        string Alumin;
        string Lemenka, Plumi, Akumlator, Shishe, Rosfaj, Heker, Kese, Shitesi;
        string vleraLemenka, vleraPlumi, vleraAkumlator,
            vleraShishe, vleraRosfaj, vleraHeker, vleraKese, vleraBakeri, vleraMesing, vleraAlumin;

        private void txtShitesi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Ju lutem Shtypni vetem shkronja ");
            }
        }

        private void txtMesing_KeyPress(object sender, KeyPressEventArgs e)
        {
           
                Char chr = e.KeyChar;
                if (chr == 46 &&  this.Text.IndexOf('.') != -1)
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

        private void dgvBlerjet_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBlerjet.CurrentRow.Index != -1)
            {
                model.id = Convert.ToInt32(dgvBlerjet.CurrentRow.Cells["id"].Value);
                using (RecycleEntities rec = new RecycleEntities())
                {
                    model = rec.Blerjets.Where(x => x.id == model.id).FirstOrDefault();
                }
            }
            var result = MessageBox.Show("A jeni te sigurt se doni te fshini shitesin ? ", "Fshirja e Shitesit", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                MessageBox.Show("Ju refuzuat fshirjen !", "Refuzimi", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Shitesi eshte fshire !", "Pranimi", MessageBoxButtons.OK);
                using (RecycleEntities Rec = new RecycleEntities())
                {
                    var entry = Rec.Entry(model);
                    if (entry.State == EntityState.Detached)
                        Rec.Blerjets.Attach(model);
                    Rec.Blerjets.Remove(model);
                    Rec.SaveChanges();
                    PopulateDataGridView();
                }

            }
        }
        pazariDitor model2 = new pazariDitor();
        private void Delete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("deshironi te perfundoni orarin e punes ? ", "Perfundimi", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var data = DateTime.Now.ToString();
                decimal blerja = Math.Round(Convert.ToDecimal(lblSum.Text), 2);
                decimal hyrja = Math.Round(Convert.ToDecimal(lblMoney.Text),2);
                decimal mbetja = Math.Round(hyrja, 2) - Math.Round(blerja, 2);
                perfundimiOrarit po = new perfundimiOrarit();
                model2.Blerja = Math.Round(blerja, 2);
                model2.Hyrja = Math.Round(hyrja, 2);
                model2.Data = Convert.ToDateTime(data);
                model2.Mbetja = Math.Round(mbetja, 2);
                this.Close();
                po.ShowDialog();
                using (RecycleEntities Rec = new RecycleEntities())
                {
                    Rec.pazariDitors.Add(model2);
                    Rec.SaveChanges();
                    PopulateDataGridView();
                }

            }
            else if (result == DialogResult.No)
            {
                result = DialogResult.Abort;
            }
        }

        private void Llogaritja_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        double alu, baku, mesi, lemi, lumi, tori, rosi, heki, ishj, qese, totali;
        public Llogaritja()
        {
            InitializeComponent();
        }
        public void rezultati()
        {
            Bakeri = this.txtBaker.Text.ToString();
            Mesing = this.txtMesing.Text.ToString();
            Alumin = this.txtAlumin.Text.ToString();
            Lemenka = this.txtLemenka.Text.ToString();
            Plumi = this.txtPlumi.Text.ToString();
            Akumlator = this.txtAkumlator.Text.ToString();
            Shishe = this.txtShishe.Text.ToString();
            Rosfaj = this.txtRosfaj.Text.ToString();
            Heker = this.txtHeker.Text.ToString();
            Kese = this.txtKese.Text.ToString();
            Shitesi = this.txtShitesi.Text.ToString();


            vleraBakeri = Bakeri;
            vleraMesing = Mesing;
            vleraAlumin = Alumin;
            vleraLemenka = Lemenka;
            vleraPlumi = Plumi;
            vleraAkumlator = Akumlator;
            vleraShishe = Shishe;
            vleraRosfaj = Rosfaj;
            vleraHeker = Heker;
            vleraKese = Kese;

        }
        public void unaza()
        {
            for (int i = 0; i <= 9; i++)
            {
                if (string.IsNullOrEmpty(Bakeri))
                {
                    Bakeri = "0";
                }
                else if (string.IsNullOrEmpty(Mesing))
                {
                    Mesing = "0";
                }
                else if (string.IsNullOrEmpty(Alumin))
                {
                    Alumin = "0";
                }
                else if (string.IsNullOrEmpty(Lemenka))
                {
                    Lemenka = "0";
                }
                else if (string.IsNullOrEmpty(Plumi))
                {
                    Plumi = "0";
                }
                else if (string.IsNullOrEmpty(Akumlator))
                {
                    Akumlator = "0";
                }
                else if (string.IsNullOrEmpty(Rosfaj))
                {
                    Rosfaj = "0";
                }
                else if (string.IsNullOrEmpty(Heker))
                {
                    Heker = "0";
                }
                else if (string.IsNullOrEmpty(Shishe))
                {
                    Shishe = "0";
                }
                else if (string.IsNullOrEmpty(Kese))
                {
                    Kese = "0";
                }
            }
        }
        public void mbledhja()
        {
            mesi = Convert.ToDouble(Mesing) * 2;
            baku = Convert.ToDouble(Bakeri) * 3.5;
            alu = Convert.ToDouble(Alumin) * 0.7;
            lemi = Convert.ToDouble(Lemenka) * 0.5;
            lumi = Convert.ToDouble(Plumi) * 0.8;
            tori = Convert.ToDouble(Akumlator) * 0.45;
            rosi = Convert.ToDouble(Rosfaj) * 0.55;
            heki = Convert.ToDouble(Heker) * 0.12;
            ishj = Convert.ToDouble(Shishe) * 0.14;
            qese = Convert.ToDouble(Kese) * 0.10;

            totali = mesi + baku + alu + lemi + lumi + tori + rosi + heki + ishj + qese;

        }
        public void rikthimi()
        {
            Lemenka = Convert.ToString(lemi);
            Plumi = Convert.ToString(lumi);
            Akumlator = Convert.ToString(tori);
            Shishe = Convert.ToString(ishj);
            Rosfaj = Convert.ToString(rosi);
            Heker = Convert.ToString(heki);
            Kese = Convert.ToString(qese);
            Mesing = Convert.ToString(mesi);
            Bakeri = Convert.ToString(baku);
            Alumin = Convert.ToString(alu);
        }
        public void pasimi()
        {
            txtBaker.Text = "0";
            txtMesing.Text = "0";
            txtAlumin.Text = "0";
            txtLemenka.Text = "0";
            txtPlumi.Text = "0";
            txtAkumlator.Text = "0";
            txtShishe.Text = "0";
            txtRosfaj.Text = "0";
            txtHeker.Text = "0";
            txtKese.Text = "0";
            txtShitesi.Text = null;
        }
        
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            rezultati();
            unaza();
            mbledhja();

            if (string.IsNullOrEmpty(txtBaker.Text))
                txtBaker.Text = "0";
            if (string.IsNullOrEmpty(txtAkumlator.Text))
                txtAkumlator.Text = "0";
            if (string.IsNullOrEmpty(txtMesing.Text))
                txtMesing.Text = "0";
            if (string.IsNullOrEmpty(txtRosfaj.Text))
                txtRosfaj.Text = "0";
            if (string.IsNullOrEmpty(txtHeker.Text))
                txtHeker.Text = "0";
            if (string.IsNullOrEmpty(txtLemenka.Text))
                txtLemenka.Text = "0";
            if (string.IsNullOrEmpty(txtPlumi.Text))
                txtPlumi.Text = "0";
            if (string.IsNullOrEmpty(txtKese.Text))
                txtKese.Text = "0";
            if (string.IsNullOrEmpty(txtShishe.Text))
                txtShishe.Text = "0";
            if (string.IsNullOrEmpty(txtAlumin.Text))
                txtAlumin.Text = "0";
            bill.baker = double.Parse(txtBaker.Text);
            bill.akumulator = double.Parse(txtAkumlator.Text);
            bill.mesing = double.Parse(txtMesing.Text);
            bill.rosfaj = double.Parse(txtRosfaj.Text);
            bill.hekur = double.Parse(txtHeker.Text);
            bill.kanaqe = double.Parse(txtLemenka.Text);
            bill.plumb = double.Parse(txtPlumi.Text);
            bill.qese = double.Parse(txtKese.Text);
            bill.shishe = double.Parse(txtShishe.Text);
            bill.alumin = double.Parse(txtAlumin.Text);
            bill.shitesi = txtShitesi.Text;
            bill.data = DateTime.Now;
            bill.totali_i_fatures = totali;

            rikthimi();
            var data = DateTime.Now.ToString();
            var treta = "\n baker >>  " + vleraBakeri + " * 3.5 = " + Bakeri +
                "\n mesing >>  " + vleraMesing + " * 2 = " + Mesing +
                "\n alumin >>  " + vleraAlumin + " * 0.70 = " + Alumin +
                "\n akumlator >>  " + vleraAkumlator + " * 0.45 = " + Akumlator +
                "\n rosfaj >>  " + vleraRosfaj + " * 0.55 = " + Rosfaj +
                "\n Plum >>  " + vleraPlumi + " * 0.80 = " + Plumi +
                "\n Lemenka >>  " + vleraLemenka + " * 0.50 = " + Lemenka +
                "\n Hekra >>  " + vleraHeker + " * 0.12 = " + Heker +
                "\n Shishe >>  " + vleraShishe + " * 0.14 = " + Shishe +
                "\n Kese >>  " + vleraKese + " * 0.10 = " + Kese +
                "\n TOTALI = " + totali + " €";
            var katerta = " Sigurohni që vlerat jane korrekte " + treta;
            var result = MessageBox.Show(katerta, "konfirmimi", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                result = MessageBox.Show("ju refuzuat", "refuzimi");
            }
            else if (result == DialogResult.Yes)
            {
                Llogaria f = new Llogaria();
                f.lblBaker.Text = Bakeri + " €";
                f.lblMesing.Text = Mesing + " €";
                f.lblAlumin.Text = Alumin + " €";
                f.lblemenka.Text = Lemenka + " €";
                f.lblPlum.Text = Plumi + " €";
                f.lblAkumlator.Text = Akumlator + " €";
                f.lblHeker.Text = Heker + " €";
                f.lblShishe.Text = Shishe + " €";
                f.lblQese.Text = Kese + " €";
                f.lblRosfaj.Text = Rosfaj + " €";
                f.lblShitesi.Text = Shitesi;
                f.lblDate.Text = data;
                f.lbltotal.Text = Convert.ToString(totali + " €");
                //Perfundimi = arr.Sum();

                pasimi();
                f.ShowDialog();
                model.Blersi = lblPuntori.Text.ToString();
                model.Shuma = Convert.ToDecimal(totali);
                model.Data = Convert.ToDateTime(data);
                model.Shitesi = Shitesi;
                using (RecycleEntities Rec = new RecycleEntities())
                {
                    Rec.Billings.Add(bill);
                    Rec.Blerjets.Add(model);
                    Rec.SaveChanges();
                    var CGP = (from Blerjet in Rec.Blerjets
                               select Blerjet).ToList();
                    var query = CGP.Sum(x => x.Shuma);
                    //var dateNow = Rec.Blerjets.SqlQuery("select * from Blerjet where Data = convert(date,getdate();").ToList();
                    //model.Data = Convert.ToDateTime(dateNow);
                    lblSum.Text = Math.Round(Convert.ToDecimal(query), 2).ToString();
                }
                PopulateDataGridView();
            }
        }
        /// <summary>
        // datetime today = datetime.now.date;
        // string todayy = datime.now.date.toString("dd.mm.yy");
        /// </summary>
        void PopulateDataGridView()
        {
            using (RecycleEntities Rec = new RecycleEntities())
            {
                dgvBlerjet.DataSource = Rec.Blerjets.ToList<Blerjet>();
            }
        }

    }
}

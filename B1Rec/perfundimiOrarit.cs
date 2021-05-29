using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace B1Rec
{
    public partial class perfundimiOrarit : Form
    {
        public perfundimiOrarit()
        {
            InitializeComponent();
        }
        pazariDitor model = new pazariDitor();
        Blerjet model2 = new Blerjet();
        private void perfundimiOrarit_Load(object sender, EventArgs e)
        {
            using (RecycleEntities Rec = new RecycleEntities())
            {
                var entry = Rec.Entry(model);
                if (entry.State == EntityState.Detached)
                    Rec.pazariDitors.Attach(model);

                PopulateDataGridView();
            }
        }
        void PopulateDataGridView()
        {
            using (RecycleEntities Rec = new RecycleEntities())
            {
                dgvPazari.DataSource = Rec.pazariDitors.ToList<pazariDitor>();
                
            }
        }


        private void dgvPazari_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPazari.CurrentRow.Index != -1)
            {
                model.id = Convert.ToInt32(dgvPazari.CurrentRow.Cells["id"].Value);
                using (RecycleEntities rec = new RecycleEntities())
                {
                    model = rec.pazariDitors.Where(x => x.id == model.id).FirstOrDefault();
                }
            }
            var result = MessageBox.Show("A jeni te sigurt se doni te fshini shitesin ? ", "Fshirja e Shitesit", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                MessageBox.Show("Ju refuzuat fshirjen !", "Refuzimi", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Pazari eshte fshire !", "Pranimi", MessageBoxButtons.OK);
                using (RecycleEntities Rec = new RecycleEntities())
                {
                    var entry = Rec.Entry(model);
                    if (entry.State == EntityState.Detached)
                        Rec.pazariDitors.Attach(model);
                    Rec.pazariDitors.Remove(model);
                    Rec.SaveChanges();
                    PopulateDataGridView();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            using (RecycleEntities Rec = new RecycleEntities())
            {
                Rec.Database.ExecuteSqlCommand("TRUNCATE TABLE [Blerjet]");
                Rec.SaveChanges();
            }
            Application.Exit();
        }
    }
}

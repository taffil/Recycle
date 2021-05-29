using System;
using System.Linq;
using System.Windows.Forms;

namespace B1Rec
{
    public partial class Llogaria : Form
    {
        public Llogaria()
        {
            InitializeComponent();
        }

        private void btnShtyp_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show("deshironi te perfundoni llogarine ? ", "Pranimi", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else if (result == DialogResult.No)
            {
                result = DialogResult.Abort;
            }
        }
        
        private void btnEnd_Click(object sender, EventArgs e)
        {
            

        }

        void PopulateDataGridView()
        {
            using (RecycleEntities Rec = new RecycleEntities())
            {
                perfundimiOrarit po = new perfundimiOrarit();
                po.dgvPazari.DataSource = Rec.pazariDitors.ToList<pazariDitor>();
            }
        }

        private void Llogaria_Load(object sender, EventArgs e)
        {

        }
    }
}

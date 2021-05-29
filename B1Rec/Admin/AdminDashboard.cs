using official_pro.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Configuration;
using System.Data.SqlClient;

namespace official_pro
{
    public partial class frmAdminDashboard : Form
    {
        User person = new User();
        UserModel personModel = new UserModel();
        Billing bill = new Billing();
        public frmAdminDashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void SystemManagement_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabUsers_Click(object sender, EventArgs e)
        {

        }

        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateDvg();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PersonData();

            using (RecycleEntities3 db = new RecycleEntities3())
            {
                db.Users.Add(person);
                db.SaveChanges();
            }
            Clear();
            PopulateDvg();
            MessageBox.Show("Added successfully", "CRUD Operation");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            PersonData();
            using (RecycleEntities3 db = new RecycleEntities3())
            {
                db.Entry(person).State = EntityState.Modified;
                db.SaveChanges();
            }
            PopulateDvg();
            Clear();
            MessageBox.Show("Updated successfully", "CRUD Operation");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure ?", "CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (RecycleEntities3 db = new RecycleEntities3())
                {
                    var entry = db.Entry(person);
                    if (entry.State == EntityState.Detached)
                        db.Users.Attach(person);
                    db.Users.Remove(person);
                    db.SaveChanges();
                    PopulateDvg();
                    Clear();
                    MessageBox.Show("Deleted Successfully", "CRUD Operation");
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Clear();
            PopulateDvg();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvUsers_DoubleClick(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow.Index != -1)
            {
                person.id = Convert.ToInt32(dgvUsers.CurrentRow.Cells["UserID"].Value);
                using (RecycleEntities3 db = new RecycleEntities3())
                {
                    person = db.Users.Where(x => x.id == person.id).FirstOrDefault();
                    txtFirstName.Text = person.first_name;
                    txtLastName.Text = person.last_name;
                    txtUsername.Text = person.username;
                    txtEmail.Text = person.email;
                    txtPassword.Text = person.password;
                    cmbUserType.Text = person.user_type;
                }
            }
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            Inventory i = new Inventory();
            i.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tabBillings_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        #region Functions

        private void PersonData()
        {
            person.first_name = txtFirstName.Text.Trim();
            person.last_name = txtLastName.Text.Trim();
            person.username = txtUsername.Text.Trim();
            person.password = txtPassword.Text.Trim();
            person.email = txtEmail.Text.Trim();
            person.user_type = cmbUserType.Text.Trim();
        }

        void PopulateDvg()
        {

            using (RecycleEntities3 db = new RecycleEntities3())
            {
                dgvUsers.DataSource = db.Users.ToList<User>();
            }
        }

        void Clear()
        {
            txtEmail.Text = txtFirstName.Text = txtLastName.Text = txtPassword.Text = cmbUserType.Text = txtUsername.Text = "";
            btnAdd.Enabled = true;
        }

        #endregion

     
    }


}

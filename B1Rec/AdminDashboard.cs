using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace B1Rec
{
    public partial class frmAdminDashboard : Form
    {
        User person = new User();
        UserModel personModel = new UserModel();
        Billing bill = new Billing();

        string admin = "Administrator";
        string user = "User";

        public frmAdminDashboard()
        {
            InitializeComponent();
        }

        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateDvg();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnDelete1.Enabled = false;
            lblAdminLoged.Text = Form1.adminLoged;
        }

        #region UserEvents

        private void dgvUsers_DoubleClick(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnAdd.Enabled = false;
            if (dgvUsers.CurrentRow.Index != -1)
            {
                person.id = Convert.ToInt32(dgvUsers.CurrentRow.Cells["UserID"].Value);
                using (RecycleEntities db = new RecycleEntities())
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            PersonData();
            CreatePerson();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            PersonData();
            UpdatePerson();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeletePerson();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Clear();
            PopulateDvg();
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnAdd.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Exit();
        }
        #endregion

        #region BillingEvents
        private void tabBillings_Click(object sender, EventArgs e)
        {
            Clear();
            btnDelete1.Enabled = false;
        }

        private void dgvBillings_DoubleClick(object sender, EventArgs e)
        {
            btnDelete1.Enabled = true;
            if (dgvBillings.CurrentRow.Index != -1)
            {
                bill.numri_i_fatures = Convert.ToInt32(dgvBillings.CurrentRow.Cells["BillId"].Value);
                using (RecycleEntities db = new RecycleEntities())
                {
                    bill = db.Billings.Where(x => x.numri_i_fatures == bill.numri_i_fatures).FirstOrDefault();
                    txtAlumin.Text = Convert.ToString(bill.alumin);
                    txtRosfaj.Text = Convert.ToString(bill.rosfaj);
                    txtBaker.Text = Convert.ToString(bill.baker);
                    txtMesing.Text = Convert.ToString(bill.mesing);
                    txtPlumb.Text = Convert.ToString(bill.plumb);
                    txtQese.Text = Convert.ToString(bill.qese);
                    txtShishe.Text = Convert.ToString(bill.shishe);
                    txtHekur.Text = Convert.ToString(bill.hekur);
                    txtKanaqe.Text = Convert.ToString(bill.kanaqe);
                    txtAkumulator.Text = Convert.ToString(bill.kanaqe);
                    txtShitesi.Text = bill.shitesi;
                    txtData.Text = Convert.ToString(bill.data);
                    txtTotali.Text = Convert.ToString(bill.totali_i_fatures);
                }
            }
        }

        private void btnDelete1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure ?", "CRUD Operation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (RecycleEntities db = new RecycleEntities())
                {
                    var entry = db.Entry(bill);
                    if (entry.State == EntityState.Detached)
                        db.Billings.Attach(bill);
                    db.Billings.Remove(bill);
                    db.SaveChanges();
                }
                MessageBox.Show("Deleted Successfully", "CRUD Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnDelete1.Enabled = false;
                PopulateDvg();
                Clear();
            }
            else
            {
                MessageBox.Show("Deletion Failed", "CRUD Operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefreshBill_Click(object sender, EventArgs e)
        {
            Clear();
            PopulateDvg();
            btnDelete1.Enabled = false;
        }

        private void btnExitBill_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvBillings.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = ".pdf";
                bool ErrorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Unable to wride data in disk" + ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(dgvBillings.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn col in dgvBillings.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }
                            foreach (DataGridViewRow viewRow in dgvBillings.Rows)
                            {
                                foreach (DataGridViewCell dcell in viewRow.Cells)
                                {
                                    pTable.AddCell(dcell.Value.ToString());
                                }
                            }
                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();
                                document.Add(pTable);
                                document.Close();
                                fileStream.Close();
                            }
                            MessageBox.Show("Data Export Successfully", "Export Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error while exporting Data" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record Found", "Info");
            }
        }
        #endregion

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

        private void CreatePerson()
        {
            var usernameModel = new UserModel();
            var emailModel = new UserModel();

            string username = txtUsername.Text;
            string email = txtEmail.Text;

            var usernameResult = usernameModel.AddUsername(username);
            var emailResult = emailModel.AddEmail(email);

            if (string.IsNullOrEmpty(txtFirstName.Text))
                MessageBox.Show("Fill in First Name", "Invalid First Name", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (string.IsNullOrEmpty(txtLastName.Text))
                MessageBox.Show("Fill in Last Name", "Invalid Last Name", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (string.IsNullOrEmpty(txtUsername.Text))
                MessageBox.Show("Fill in Username", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (usernameResult != null)
                MessageBox.Show("Username Already Exists!", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (string.IsNullOrEmpty(txtEmail.Text))
                MessageBox.Show("Fill in Email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (!this.txtEmail.Text.Contains('@') || !this.txtEmail.Text.Contains('.'))
                MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (emailResult != null)
                MessageBox.Show("Email Already Exists!", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (string.IsNullOrEmpty(txtPassword.Text))
                MessageBox.Show("Fill in Password", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (string.IsNullOrEmpty(cmbUserType.Text))
                MessageBox.Show("Fill in User Type", "Invalid User Type", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (!(cmbUserType.Text == admin || cmbUserType.Text == user))
                MessageBox.Show("Please Enter a Valid User Type", "Invalid User Type", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                using (RecycleEntities db = new RecycleEntities())
                {
                    db.Users.Add(person);
                    db.SaveChanges();
                }
                Clear();
                PopulateDvg();
                MessageBox.Show("Added successfully", "CRUD Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
            }
        }
        void UpdatePerson()
        {
            var usernameModel = new UserModel();
            var emailModel = new UserModel();

            string username = txtUsername.Text;
            string email = txtEmail.Text;

            var usernameResult = usernameModel.AddUsername(username);
            var emailResult = emailModel.AddEmail(email);

            if (string.IsNullOrEmpty(txtFirstName.Text))
                MessageBox.Show("Fill in First Name", "Invalid First Name", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (string.IsNullOrEmpty(txtLastName.Text))
                MessageBox.Show("Fill in Last Name", "Invalid Last Name", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (string.IsNullOrEmpty(txtUsername.Text))
                MessageBox.Show("Fill in Username", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (string.IsNullOrEmpty(txtEmail.Text))
                MessageBox.Show("Fill in Email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (!this.txtEmail.Text.Contains('@') || !this.txtEmail.Text.Contains('.'))
                MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (string.IsNullOrEmpty(txtPassword.Text))
                MessageBox.Show("Fill in Password", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (string.IsNullOrEmpty(cmbUserType.Text))
                MessageBox.Show("Fill in User Type", "Invalid User Type", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (!(cmbUserType.Text == admin || cmbUserType.Text == user))
                MessageBox.Show("Please Enter a Valid User Type", "Invalid User Type", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                using (RecycleEntities db = new RecycleEntities())
                {
                    db.Entry(person).State = EntityState.Modified;
                    db.SaveChanges();
                }
                Clear();
                PopulateDvg();
                MessageBox.Show("Updated successfully", "CRUD Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                btnAdd.Enabled = true;
            }
        }
        void DeletePerson()
        {
            if (MessageBox.Show("Are you sure?", "CRUD Operation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (RecycleEntities db = new RecycleEntities())
                {
                    var entry = db.Entry(person);
                    if (entry.State == EntityState.Detached)
                        db.Users.Attach(person);
                    db.Users.Remove(person);
                    db.SaveChanges();
                    PopulateDvg();
                    Clear();
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnAdd.Enabled = true;
                }
                MessageBox.Show("Deleted Successfully", "CRUD Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Deletion Failed", "CRUD Operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void PopulateDvg()
        {

            using (RecycleEntities db = new RecycleEntities())
            {
                dgvUsers.DataSource = db.Users.ToList<User>();
                dgvBillings.DataSource = db.Billings.ToList<Billing>();
            }
        }

        void Clear()
        {
            txtEmail.Text = txtFirstName.Text = txtLastName.Text = txtPassword.Text = cmbUserType.Text = txtUsername.Text = "";
            txtRosfaj.Text = txtAlumin.Text = txtBaker.Text = txtMesing.Text = txtAkumulator.Text = txtPlumb.Text = txtQese.Text = txtShishe.Text = txtKanaqe.Text = txtHekur.Text = txtShitesi.Text = txtTotali.Text = txtData.Text = "";
        }

        void Exit()
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                Form1 form1 = new Form1();
                form1.Show();
            }
        }

        #endregion
    }
}

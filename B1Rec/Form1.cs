using System;
using System.Windows.Forms;

namespace B1Rec
{
    public partial class Form1 : Form
    {
        public static string adminLoged;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var usersModel = new UserModel();

            string email = txtUsername.Text;
            string password = txtPassword.Text;

            var userResult = usersModel.Login(email, password);

            if (userResult == null)
                MessageBox.Show("Emaili ose passwordi jane gabim!");
            else
            {
                if(userResult.user_type == "Administrator")
                {
                    adminLoged = txtUsername.Text;
                    this.Hide();
                    new frmAdminDashboard().Show();
                } else
                {
                    this.Hide();
                    Hyrje hr = new Hyrje();
                    hr.lblPunto.Text = txtUsername.Text;
                    hr.Show();
                    
                }
            }

        }

        private void Dil_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

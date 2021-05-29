
namespace official_pro
{
    partial class frmAdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminDashboard));
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblAdminLoged = new System.Windows.Forms.Label();
            this.lblSystemManagement = new System.Windows.Forms.Label();
            this.panSystemManagement = new System.Windows.Forms.Panel();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbUserType = new System.Windows.Forms.ComboBox();
            this.lblUserType = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabAdmin = new System.Windows.Forms.TabControl();
            this.tabBillings = new System.Windows.Forms.TabPage();
            this.btnExitBill = new System.Windows.Forms.Button();
            this.btnRefreshBill = new System.Windows.Forms.Button();
            this.lblPrint = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.lblTotali = new System.Windows.Forms.Label();
            this.lblShitesi = new System.Windows.Forms.Label();
            this.lblShitesi1 = new System.Windows.Forms.Label();
            this.lblData1 = new System.Windows.Forms.Label();
            this.lblTotali1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Totali = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblQese = new System.Windows.Forms.Label();
            this.lblAkumulator = new System.Windows.Forms.Label();
            this.lblHekur = new System.Windows.Forms.Label();
            this.lblPlumb = new System.Windows.Forms.Label();
            this.lblRosfaj = new System.Windows.Forms.Label();
            this.lblMesing = new System.Windows.Forms.Label();
            this.lblAlumin = new System.Windows.Forms.Label();
            this.lblShishe = new System.Windows.Forms.Label();
            this.lblKanaqe = new System.Windows.Forms.Label();
            this.lblBaker = new System.Windows.Forms.Label();
            this.lblQese1 = new System.Windows.Forms.Label();
            this.lblAkumulator1 = new System.Windows.Forms.Label();
            this.lblHekur1 = new System.Windows.Forms.Label();
            this.lblPlumb1 = new System.Windows.Forms.Label();
            this.lblRosfaj1 = new System.Windows.Forms.Label();
            this.lblMesing1 = new System.Windows.Forms.Label();
            this.lblAlumin1 = new System.Windows.Forms.Label();
            this.lblShishe1 = new System.Windows.Forms.Label();
            this.lblKanaqe1 = new System.Windows.Forms.Label();
            this.lblBaker1 = new System.Windows.Forms.Label();
            this.panSystemManagement.SuspendLayout();
            this.tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.tabAdmin.SuspendLayout();
            this.tabBillings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Location = new System.Drawing.Point(761, 16);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(39, 13);
            this.lblAdmin.TabIndex = 1;
            this.lblAdmin.Text = "Admin:";
            this.lblAdmin.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblAdminLoged
            // 
            this.lblAdminLoged.AutoSize = true;
            this.lblAdminLoged.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminLoged.ForeColor = System.Drawing.Color.Green;
            this.lblAdminLoged.Location = new System.Drawing.Point(795, 15);
            this.lblAdminLoged.Name = "lblAdminLoged";
            this.lblAdminLoged.Size = new System.Drawing.Size(75, 15);
            this.lblAdminLoged.TabIndex = 2;
            this.lblAdminLoged.Text = "Tafil Osmani";
            // 
            // lblSystemManagement
            // 
            this.lblSystemManagement.AutoSize = true;
            this.lblSystemManagement.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemManagement.ForeColor = System.Drawing.Color.Teal;
            this.lblSystemManagement.Location = new System.Drawing.Point(3, 3);
            this.lblSystemManagement.Name = "lblSystemManagement";
            this.lblSystemManagement.Size = new System.Drawing.Size(219, 30);
            this.lblSystemManagement.TabIndex = 3;
            this.lblSystemManagement.Text = "System Management";
            this.lblSystemManagement.Click += new System.EventHandler(this.SystemManagement_Click);
            // 
            // panSystemManagement
            // 
            this.panSystemManagement.BackColor = System.Drawing.Color.LightGray;
            this.panSystemManagement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panSystemManagement.Controls.Add(this.lblSystemManagement);
            this.panSystemManagement.Controls.Add(this.lblAdminLoged);
            this.panSystemManagement.Controls.Add(this.lblAdmin);
            this.panSystemManagement.Location = new System.Drawing.Point(1, 280);
            this.panSystemManagement.Name = "panSystemManagement";
            this.panSystemManagement.Size = new System.Drawing.Size(882, 42);
            this.panSystemManagement.TabIndex = 5;
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.btnSearch);
            this.tabUsers.Controls.Add(this.btnRefresh);
            this.tabUsers.Controls.Add(this.txtSearch);
            this.tabUsers.Controls.Add(this.txtPassword);
            this.tabUsers.Controls.Add(this.txtEmail);
            this.tabUsers.Controls.Add(this.txtUsername);
            this.tabUsers.Controls.Add(this.txtLastName);
            this.tabUsers.Controls.Add(this.txtFirstName);
            this.tabUsers.Controls.Add(this.lblSearch);
            this.tabUsers.Controls.Add(this.btnExit);
            this.tabUsers.Controls.Add(this.btnAdd);
            this.tabUsers.Controls.Add(this.btnUpdate);
            this.tabUsers.Controls.Add(this.btnDelete);
            this.tabUsers.Controls.Add(this.cmbUserType);
            this.tabUsers.Controls.Add(this.lblUserType);
            this.tabUsers.Controls.Add(this.lblPassword);
            this.tabUsers.Controls.Add(this.lblEmail);
            this.tabUsers.Controls.Add(this.lblUsername);
            this.tabUsers.Controls.Add(this.lblLastName);
            this.tabUsers.Controls.Add(this.lblFirstName);
            this.tabUsers.Controls.Add(this.dgvUsers);
            this.tabUsers.Location = new System.Drawing.Point(4, 22);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsers.Size = new System.Drawing.Size(878, 254);
            this.tabUsers.TabIndex = 0;
            this.tabUsers.Text = "Users";
            this.tabUsers.UseVisualStyleBackColor = true;
            this.tabUsers.Click += new System.EventHandler(this.tabUsers_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(792, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(266, 162);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 22;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(399, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(387, 22);
            this.txtSearch.TabIndex = 21;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(85, 173);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(121, 22);
            this.txtPassword.TabIndex = 17;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(85, 135);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(121, 22);
            this.txtEmail.TabIndex = 16;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(85, 97);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(121, 22);
            this.txtUsername.TabIndex = 15;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(85, 59);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(121, 22);
            this.txtLastName.TabIndex = 14;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(85, 21);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(121, 22);
            this.txtFirstName.TabIndex = 13;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(355, 8);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 20;
            this.lblSearch.Text = "Search";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(266, 206);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(266, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add >>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(266, 74);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(266, 118);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbUserType
            // 
            this.cmbUserType.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmbUserType.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUserType.FormattingEnabled = true;
            this.cmbUserType.Items.AddRange(new object[] {
            "Administrator",
            "User"});
            this.cmbUserType.Location = new System.Drawing.Point(85, 211);
            this.cmbUserType.Name = "cmbUserType";
            this.cmbUserType.Size = new System.Drawing.Size(121, 21);
            this.cmbUserType.TabIndex = 18;
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserType.Location = new System.Drawing.Point(18, 214);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(56, 13);
            this.lblUserType.TabIndex = 12;
            this.lblUserType.Text = "User Type";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(18, 176);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Password";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(40, 138);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(34, 13);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(16, 100);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 9;
            this.lblUsername.Text = "Username";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(15, 62);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(59, 13);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(13, 24);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(3);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(61, 13);
            this.lblFirstName.TabIndex = 7;
            this.lblFirstName.Text = "First Name";
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.first_name,
            this.last_name,
            this.username,
            this.email,
            this.password,
            this.user_type});
            this.dgvUsers.Location = new System.Drawing.Point(358, 30);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.Size = new System.Drawing.Size(520, 224);
            this.dgvUsers.TabIndex = 6;
            this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentClick);
            this.dgvUsers.DoubleClick += new System.EventHandler(this.dgvUsers_DoubleClick);
            // 
            // UserID
            // 
            this.UserID.DataPropertyName = "id";
            this.UserID.HeaderText = "ID";
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            this.UserID.Width = 30;
            // 
            // first_name
            // 
            this.first_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.first_name.DataPropertyName = "first_name";
            this.first_name.FillWeight = 107.8173F;
            this.first_name.HeaderText = "First Name";
            this.first_name.Name = "first_name";
            this.first_name.ReadOnly = true;
            // 
            // last_name
            // 
            this.last_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.last_name.DataPropertyName = "last_name";
            this.last_name.FillWeight = 107.8173F;
            this.last_name.HeaderText = "Last Name";
            this.last_name.Name = "last_name";
            this.last_name.ReadOnly = true;
            // 
            // username
            // 
            this.username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.username.DataPropertyName = "username";
            this.username.FillWeight = 107.8173F;
            this.username.HeaderText = "Username";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.email.DataPropertyName = "email";
            this.email.FillWeight = 107.8173F;
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // password
            // 
            this.password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "Password";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.Visible = false;
            // 
            // user_type
            // 
            this.user_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.user_type.DataPropertyName = "user_type";
            this.user_type.FillWeight = 107.8173F;
            this.user_type.HeaderText = "User Type";
            this.user_type.Name = "user_type";
            this.user_type.ReadOnly = true;
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.tabUsers);
            this.tabAdmin.Controls.Add(this.tabBillings);
            this.tabAdmin.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAdmin.Location = new System.Drawing.Point(1, 1);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(886, 280);
            this.tabAdmin.TabIndex = 4;
            // 
            // tabBillings
            // 
            this.tabBillings.Controls.Add(this.btnExitBill);
            this.tabBillings.Controls.Add(this.btnRefreshBill);
            this.tabBillings.Controls.Add(this.lblPrint);
            this.tabBillings.Controls.Add(this.btnInventory);
            this.tabBillings.Controls.Add(this.dtp);
            this.tabBillings.Controls.Add(this.lblTotali);
            this.tabBillings.Controls.Add(this.lblShitesi);
            this.tabBillings.Controls.Add(this.lblShitesi1);
            this.tabBillings.Controls.Add(this.lblData1);
            this.tabBillings.Controls.Add(this.lblTotali1);
            this.tabBillings.Controls.Add(this.dataGridView1);
            this.tabBillings.Controls.Add(this.lblQese);
            this.tabBillings.Controls.Add(this.lblAkumulator);
            this.tabBillings.Controls.Add(this.lblHekur);
            this.tabBillings.Controls.Add(this.lblPlumb);
            this.tabBillings.Controls.Add(this.lblRosfaj);
            this.tabBillings.Controls.Add(this.lblMesing);
            this.tabBillings.Controls.Add(this.lblAlumin);
            this.tabBillings.Controls.Add(this.lblShishe);
            this.tabBillings.Controls.Add(this.lblKanaqe);
            this.tabBillings.Controls.Add(this.lblBaker);
            this.tabBillings.Controls.Add(this.lblQese1);
            this.tabBillings.Controls.Add(this.lblAkumulator1);
            this.tabBillings.Controls.Add(this.lblHekur1);
            this.tabBillings.Controls.Add(this.lblPlumb1);
            this.tabBillings.Controls.Add(this.lblRosfaj1);
            this.tabBillings.Controls.Add(this.lblMesing1);
            this.tabBillings.Controls.Add(this.lblAlumin1);
            this.tabBillings.Controls.Add(this.lblShishe1);
            this.tabBillings.Controls.Add(this.lblKanaqe1);
            this.tabBillings.Controls.Add(this.lblBaker1);
            this.tabBillings.Location = new System.Drawing.Point(4, 22);
            this.tabBillings.Name = "tabBillings";
            this.tabBillings.Padding = new System.Windows.Forms.Padding(3);
            this.tabBillings.Size = new System.Drawing.Size(878, 254);
            this.tabBillings.TabIndex = 2;
            this.tabBillings.Text = "Billings";
            this.tabBillings.UseVisualStyleBackColor = true;
            this.tabBillings.Click += new System.EventHandler(this.tabBillings_Click);
            // 
            // btnExitBill
            // 
            this.btnExitBill.Location = new System.Drawing.Point(268, 140);
            this.btnExitBill.Name = "btnExitBill";
            this.btnExitBill.Size = new System.Drawing.Size(75, 23);
            this.btnExitBill.TabIndex = 109;
            this.btnExitBill.Text = "Exit";
            this.btnExitBill.UseVisualStyleBackColor = true;
            // 
            // btnRefreshBill
            // 
            this.btnRefreshBill.Location = new System.Drawing.Point(268, 8);
            this.btnRefreshBill.Name = "btnRefreshBill";
            this.btnRefreshBill.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshBill.TabIndex = 108;
            this.btnRefreshBill.Text = "Refresh";
            this.btnRefreshBill.UseVisualStyleBackColor = true;
            // 
            // lblPrint
            // 
            this.lblPrint.Location = new System.Drawing.Point(268, 96);
            this.lblPrint.Name = "lblPrint";
            this.lblPrint.Size = new System.Drawing.Size(75, 23);
            this.lblPrint.TabIndex = 107;
            this.lblPrint.Text = "Print";
            this.lblPrint.UseVisualStyleBackColor = true;
            // 
            // btnInventory
            // 
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnInventory.Location = new System.Drawing.Point(268, 52);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(75, 23);
            this.btnInventory.TabIndex = 106;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // dtp
            // 
            this.dtp.CalendarMonthBackground = System.Drawing.Color.Gainsboro;
            this.dtp.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtp.CalendarTitleForeColor = System.Drawing.Color.Green;
            this.dtp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp.Location = new System.Drawing.Point(68, 216);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(94, 25);
            this.dtp.TabIndex = 105;
            // 
            // lblTotali
            // 
            this.lblTotali.AutoSize = true;
            this.lblTotali.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.lblTotali.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotali.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotali.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTotali.Location = new System.Drawing.Point(247, 196);
            this.lblTotali.Name = "lblTotali";
            this.lblTotali.Size = new System.Drawing.Size(24, 19);
            this.lblTotali.TabIndex = 104;
            this.lblTotali.Text = "34";
            // 
            // lblShitesi
            // 
            this.lblShitesi.AutoSize = true;
            this.lblShitesi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.lblShitesi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShitesi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShitesi.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblShitesi.Location = new System.Drawing.Point(68, 181);
            this.lblShitesi.Name = "lblShitesi";
            this.lblShitesi.Size = new System.Drawing.Size(89, 19);
            this.lblShitesi.TabIndex = 4;
            this.lblShitesi.Text = "Tafil Osmani";
            // 
            // lblShitesi1
            // 
            this.lblShitesi1.AutoSize = true;
            this.lblShitesi1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShitesi1.Location = new System.Drawing.Point(19, 181);
            this.lblShitesi1.Name = "lblShitesi1";
            this.lblShitesi1.Size = new System.Drawing.Size(45, 17);
            this.lblShitesi1.TabIndex = 103;
            this.lblShitesi1.Text = "Shitesi";
            // 
            // lblData1
            // 
            this.lblData1.AutoSize = true;
            this.lblData1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData1.Location = new System.Drawing.Point(29, 220);
            this.lblData1.Name = "lblData1";
            this.lblData1.Size = new System.Drawing.Size(35, 17);
            this.lblData1.TabIndex = 102;
            this.lblData1.Text = "Data";
            // 
            // lblTotali1
            // 
            this.lblTotali1.AutoSize = true;
            this.lblTotali1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotali1.Location = new System.Drawing.Point(206, 196);
            this.lblTotali1.Name = "lblTotali1";
            this.lblTotali1.Size = new System.Drawing.Size(40, 17);
            this.lblTotali1.TabIndex = 101;
            this.lblTotali1.Text = "Totali";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Data,
            this.Totali});
            this.dataGridView1.Location = new System.Drawing.Point(358, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(520, 254);
            this.dataGridView1.TabIndex = 100;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.DataPropertyName = "numri_i_fatures";
            this.Id.HeaderText = "Numri i Fatures";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Data.DataPropertyName = "data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Totali
            // 
            this.Totali.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Totali.DataPropertyName = "totali_i_fatures";
            this.Totali.HeaderText = "Totali i Fatures";
            this.Totali.Name = "Totali";
            this.Totali.ReadOnly = true;
            // 
            // lblQese
            // 
            this.lblQese.AutoSize = true;
            this.lblQese.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.lblQese.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQese.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQese.Location = new System.Drawing.Point(209, 145);
            this.lblQese.Name = "lblQese";
            this.lblQese.Size = new System.Drawing.Size(25, 15);
            this.lblQese.TabIndex = 89;
            this.lblQese.Text = " kg";
            // 
            // lblAkumulator
            // 
            this.lblAkumulator.AutoSize = true;
            this.lblAkumulator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.lblAkumulator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAkumulator.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAkumulator.Location = new System.Drawing.Point(209, 79);
            this.lblAkumulator.Name = "lblAkumulator";
            this.lblAkumulator.Size = new System.Drawing.Size(25, 15);
            this.lblAkumulator.TabIndex = 98;
            this.lblAkumulator.Text = " kg";
            // 
            // lblHekur
            // 
            this.lblHekur.AutoSize = true;
            this.lblHekur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.lblHekur.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHekur.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHekur.Location = new System.Drawing.Point(209, 46);
            this.lblHekur.Name = "lblHekur";
            this.lblHekur.Size = new System.Drawing.Size(25, 15);
            this.lblHekur.TabIndex = 97;
            this.lblHekur.Text = " kg";
            // 
            // lblPlumb
            // 
            this.lblPlumb.AutoSize = true;
            this.lblPlumb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.lblPlumb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlumb.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlumb.Location = new System.Drawing.Point(68, 112);
            this.lblPlumb.Name = "lblPlumb";
            this.lblPlumb.Size = new System.Drawing.Size(25, 15);
            this.lblPlumb.TabIndex = 96;
            this.lblPlumb.Text = " kg";
            // 
            // lblRosfaj
            // 
            this.lblRosfaj.AutoSize = true;
            this.lblRosfaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.lblRosfaj.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRosfaj.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRosfaj.Location = new System.Drawing.Point(209, 13);
            this.lblRosfaj.Name = "lblRosfaj";
            this.lblRosfaj.Size = new System.Drawing.Size(25, 15);
            this.lblRosfaj.TabIndex = 95;
            this.lblRosfaj.Text = " kg";
            // 
            // lblMesing
            // 
            this.lblMesing.AutoSize = true;
            this.lblMesing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.lblMesing.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMesing.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesing.Location = new System.Drawing.Point(68, 46);
            this.lblMesing.Name = "lblMesing";
            this.lblMesing.Size = new System.Drawing.Size(25, 15);
            this.lblMesing.TabIndex = 94;
            this.lblMesing.Text = " kg";
            // 
            // lblAlumin
            // 
            this.lblAlumin.AutoSize = true;
            this.lblAlumin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.lblAlumin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAlumin.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumin.Location = new System.Drawing.Point(68, 79);
            this.lblAlumin.Name = "lblAlumin";
            this.lblAlumin.Size = new System.Drawing.Size(25, 15);
            this.lblAlumin.TabIndex = 93;
            this.lblAlumin.Text = " kg";
            // 
            // lblShishe
            // 
            this.lblShishe.AutoSize = true;
            this.lblShishe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.lblShishe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShishe.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShishe.Location = new System.Drawing.Point(209, 112);
            this.lblShishe.Name = "lblShishe";
            this.lblShishe.Size = new System.Drawing.Size(25, 15);
            this.lblShishe.TabIndex = 92;
            this.lblShishe.Text = " kg";
            // 
            // lblKanaqe
            // 
            this.lblKanaqe.AutoSize = true;
            this.lblKanaqe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.lblKanaqe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblKanaqe.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKanaqe.Location = new System.Drawing.Point(68, 145);
            this.lblKanaqe.Name = "lblKanaqe";
            this.lblKanaqe.Size = new System.Drawing.Size(25, 15);
            this.lblKanaqe.TabIndex = 91;
            this.lblKanaqe.Text = " kg";
            // 
            // lblBaker
            // 
            this.lblBaker.AutoSize = true;
            this.lblBaker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.lblBaker.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBaker.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaker.Location = new System.Drawing.Point(68, 13);
            this.lblBaker.Name = "lblBaker";
            this.lblBaker.Size = new System.Drawing.Size(25, 15);
            this.lblBaker.TabIndex = 90;
            this.lblBaker.Text = " kg";
            // 
            // lblQese1
            // 
            this.lblQese1.AutoSize = true;
            this.lblQese1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQese1.Location = new System.Drawing.Point(157, 145);
            this.lblQese1.Name = "lblQese1";
            this.lblQese1.Size = new System.Drawing.Size(33, 13);
            this.lblQese1.TabIndex = 79;
            this.lblQese1.Text = "Qese";
            // 
            // lblAkumulator1
            // 
            this.lblAkumulator1.AutoSize = true;
            this.lblAkumulator1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAkumulator1.Location = new System.Drawing.Point(123, 79);
            this.lblAkumulator1.Name = "lblAkumulator1";
            this.lblAkumulator1.Size = new System.Drawing.Size(67, 13);
            this.lblAkumulator1.TabIndex = 88;
            this.lblAkumulator1.Text = "Akumulator";
            // 
            // lblHekur1
            // 
            this.lblHekur1.AutoSize = true;
            this.lblHekur1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHekur1.Location = new System.Drawing.Point(152, 46);
            this.lblHekur1.Name = "lblHekur1";
            this.lblHekur1.Size = new System.Drawing.Size(38, 13);
            this.lblHekur1.TabIndex = 87;
            this.lblHekur1.Text = "Hekur";
            // 
            // lblPlumb1
            // 
            this.lblPlumb1.AutoSize = true;
            this.lblPlumb1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlumb1.Location = new System.Drawing.Point(16, 112);
            this.lblPlumb1.Name = "lblPlumb1";
            this.lblPlumb1.Size = new System.Drawing.Size(39, 13);
            this.lblPlumb1.TabIndex = 86;
            this.lblPlumb1.Text = "Plumb";
            // 
            // lblRosfaj1
            // 
            this.lblRosfaj1.AutoSize = true;
            this.lblRosfaj1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRosfaj1.Location = new System.Drawing.Point(151, 13);
            this.lblRosfaj1.Name = "lblRosfaj1";
            this.lblRosfaj1.Size = new System.Drawing.Size(39, 13);
            this.lblRosfaj1.TabIndex = 85;
            this.lblRosfaj1.Text = "Rosfaj";
            // 
            // lblMesing1
            // 
            this.lblMesing1.AutoSize = true;
            this.lblMesing1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesing1.Location = new System.Drawing.Point(10, 46);
            this.lblMesing1.Name = "lblMesing1";
            this.lblMesing1.Size = new System.Drawing.Size(45, 13);
            this.lblMesing1.TabIndex = 84;
            this.lblMesing1.Text = "Mesing";
            // 
            // lblAlumin1
            // 
            this.lblAlumin1.AutoSize = true;
            this.lblAlumin1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumin1.Location = new System.Drawing.Point(12, 79);
            this.lblAlumin1.Name = "lblAlumin1";
            this.lblAlumin1.Size = new System.Drawing.Size(43, 13);
            this.lblAlumin1.TabIndex = 83;
            this.lblAlumin1.Text = "Alumin";
            // 
            // lblShishe1
            // 
            this.lblShishe1.AutoSize = true;
            this.lblShishe1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShishe1.Location = new System.Drawing.Point(149, 112);
            this.lblShishe1.Name = "lblShishe1";
            this.lblShishe1.Size = new System.Drawing.Size(41, 13);
            this.lblShishe1.TabIndex = 82;
            this.lblShishe1.Text = "Shishe";
            // 
            // lblKanaqe1
            // 
            this.lblKanaqe1.AutoSize = true;
            this.lblKanaqe1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKanaqe1.Location = new System.Drawing.Point(10, 145);
            this.lblKanaqe1.Name = "lblKanaqe1";
            this.lblKanaqe1.Size = new System.Drawing.Size(45, 13);
            this.lblKanaqe1.TabIndex = 81;
            this.lblKanaqe1.Text = "Kanaqe";
            // 
            // lblBaker1
            // 
            this.lblBaker1.AutoSize = true;
            this.lblBaker1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaker1.Location = new System.Drawing.Point(19, 13);
            this.lblBaker1.Name = "lblBaker1";
            this.lblBaker1.Size = new System.Drawing.Size(36, 13);
            this.lblBaker1.TabIndex = 80;
            this.lblBaker1.Text = "Bakër";
            // 
            // frmAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 322);
            this.Controls.Add(this.panSystemManagement);
            this.Controls.Add(this.tabAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAdminDashboard";
            this.Text = "Admin Dashboard";
            this.Load += new System.EventHandler(this.frmAdminDashboard_Load);
            this.panSystemManagement.ResumeLayout(false);
            this.panSystemManagement.PerformLayout();
            this.tabUsers.ResumeLayout(false);
            this.tabUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.tabAdmin.ResumeLayout(false);
            this.tabBillings.ResumeLayout(false);
            this.tabBillings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblAdminLoged;
        private System.Windows.Forms.Label lblSystemManagement;
        private System.Windows.Forms.Panel panSystemManagement;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbUserType;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.TabControl tabAdmin;
        private System.Windows.Forms.TabPage tabBillings;
        private System.Windows.Forms.Label lblQese;
        private System.Windows.Forms.Label lblAkumulator;
        private System.Windows.Forms.Label lblHekur;
        private System.Windows.Forms.Label lblPlumb;
        private System.Windows.Forms.Label lblRosfaj;
        private System.Windows.Forms.Label lblMesing;
        private System.Windows.Forms.Label lblAlumin;
        private System.Windows.Forms.Label lblShishe;
        private System.Windows.Forms.Label lblKanaqe;
        private System.Windows.Forms.Label lblBaker;
        private System.Windows.Forms.Label lblQese1;
        private System.Windows.Forms.Label lblAkumulator1;
        private System.Windows.Forms.Label lblHekur1;
        private System.Windows.Forms.Label lblPlumb1;
        private System.Windows.Forms.Label lblRosfaj1;
        private System.Windows.Forms.Label lblMesing1;
        private System.Windows.Forms.Label lblAlumin1;
        private System.Windows.Forms.Label lblShishe1;
        private System.Windows.Forms.Label lblKanaqe1;
        private System.Windows.Forms.Label lblBaker1;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label lblTotali;
        private System.Windows.Forms.Label lblShitesi;
        private System.Windows.Forms.Label lblShitesi1;
        private System.Windows.Forms.Label lblData1;
        private System.Windows.Forms.Label lblTotali1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnExitBill;
        private System.Windows.Forms.Button btnRefreshBill;
        private System.Windows.Forms.Button lblPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Totali;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_type;
        private System.Windows.Forms.Button btnSearch;
    }
}

namespace B1Rec
{
    partial class perfundimiOrarit
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
            this.dgvPazari = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Blerja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hyrja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mbetja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPazari)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPazari
            // 
            this.dgvPazari.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.dgvPazari.AllowDrop = true;
            this.dgvPazari.AllowUserToOrderColumns = true;
            this.dgvPazari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPazari.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dgvPazari.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPazari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPazari.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Blerja,
            this.Hyrja,
            this.Data,
            this.Mbetja});
            this.dgvPazari.Location = new System.Drawing.Point(22, 51);
            this.dgvPazari.Name = "dgvPazari";
            this.dgvPazari.ReadOnly = true;
            this.dgvPazari.Size = new System.Drawing.Size(460, 402);
            this.dgvPazari.TabIndex = 0;
            this.dgvPazari.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPazari_CellDoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Blerja
            // 
            this.Blerja.DataPropertyName = "Blerja";
            this.Blerja.HeaderText = "Blerja";
            this.Blerja.Name = "Blerja";
            this.Blerja.ReadOnly = true;
            this.Blerja.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Hyrja
            // 
            this.Hyrja.DataPropertyName = "Hyrja";
            this.Hyrja.HeaderText = "Hyrja";
            this.Hyrja.Name = "Hyrja";
            this.Hyrja.ReadOnly = true;
            this.Hyrja.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Mbetja
            // 
            this.Mbetja.DataPropertyName = "Mbetja";
            this.Mbetja.HeaderText = "Mbetja";
            this.Mbetja.Name = "Mbetja";
            this.Mbetja.ReadOnly = true;
            this.Mbetja.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(174, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pastro Blerjet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // perfundimiOrarit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(511, 526);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvPazari);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "perfundimiOrarit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "perfundimiOrarit";
            this.Load += new System.EventHandler(this.perfundimiOrarit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPazari)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Blerja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hyrja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mbetja;
        public System.Windows.Forms.DataGridView dgvPazari;
        private System.Windows.Forms.Button button1;
    }
}
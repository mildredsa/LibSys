namespace LibSys
{
    partial class ManageUsers
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
            this.components = new System.ComponentModel.Container();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Operations = new System.Windows.Forms.GroupBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAct = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCpass = new System.Windows.Forms.TextBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dBSDataSet5 = new LibSys.DBSDataSet5();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new LibSys.DBSDataSet5TableAdapters.UsersTableAdapter();
            this.Operations.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "First Name";
            // 
            // txtLname
            // 
            this.txtLname.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLname.Location = new System.Drawing.Point(27, 181);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(231, 29);
            this.txtLname.TabIndex = 24;
            // 
            // txtFname
            // 
            this.txtFname.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFname.Location = new System.Drawing.Point(27, 119);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(231, 29);
            this.txtFname.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Username";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(27, 58);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(231, 29);
            this.txtUser.TabIndex = 16;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Verdana", 11F);
            this.btnCreate.Location = new System.Drawing.Point(6, 76);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(237, 61);
            this.btnCreate.TabIndex = 28;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Verdana", 11F);
            this.btnUpdate.Location = new System.Drawing.Point(6, 260);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(237, 63);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 11F);
            this.btnDelete.Location = new System.Drawing.Point(6, 354);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(237, 63);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Operations
            // 
            this.Operations.Controls.Add(this.btnDone);
            this.Operations.Controls.Add(this.btnDelete);
            this.Operations.Controls.Add(this.btnCancel);
            this.Operations.Controls.Add(this.btnUpdate);
            this.Operations.Controls.Add(this.btnAct);
            this.Operations.Controls.Add(this.btnCreate);
            this.Operations.Location = new System.Drawing.Point(689, 23);
            this.Operations.Name = "Operations";
            this.Operations.Size = new System.Drawing.Size(249, 617);
            this.Operations.TabIndex = 43;
            this.Operations.TabStop = false;
            this.Operations.Text = "Operations";
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Verdana", 11F);
            this.btnDone.Location = new System.Drawing.Point(6, 538);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(237, 61);
            this.btnDone.TabIndex = 41;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Verdana", 11F);
            this.btnCancel.Location = new System.Drawing.Point(6, 451);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(237, 61);
            this.btnCancel.TabIndex = 40;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAct
            // 
            this.btnAct.Font = new System.Drawing.Font("Verdana", 11F);
            this.btnAct.Location = new System.Drawing.Point(6, 162);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(237, 63);
            this.btnAct.TabIndex = 34;
            this.btnAct.Text = "Activate";
            this.btnAct.UseVisualStyleBackColor = true;
            this.btnAct.Click += new System.EventHandler(this.btnAct_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbGender);
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCpass);
            this.groupBox1.Controls.Add(this.grid);
            this.groupBox1.Controls.Add(this.picSearch);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.txtLname);
            this.groupBox1.Controls.Add(this.txtFname);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(37, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 617);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manage Users";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(316, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 82;
            this.label6.Text = "Gender";
            // 
            // cmbGender
            // 
            this.cmbGender.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(319, 179);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(230, 30);
            this.cmbGender.TabIndex = 81;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(318, 58);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(231, 29);
            this.txtPass.TabIndex = 40;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "Confirm Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Password";
            // 
            // txtCpass
            // 
            this.txtCpass.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpass.Location = new System.Drawing.Point(318, 119);
            this.txtCpass.Name = "txtCpass";
            this.txtCpass.Size = new System.Drawing.Size(231, 29);
            this.txtCpass.TabIndex = 42;
            this.txtCpass.UseSystemPasswordChar = true;
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(27, 283);
            this.grid.Name = "grid";
            this.grid.RowHeadersWidth = 51;
            this.grid.RowTemplate.Height = 24;
            this.grid.Size = new System.Drawing.Size(566, 316);
            this.grid.TabIndex = 37;
            // 
            // picSearch
            // 
            this.picSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSearch.Image = global::LibSys.Properties.Resources.search;
            this.picSearch.Location = new System.Drawing.Point(560, 245);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(33, 29);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSearch.TabIndex = 39;
            this.picSearch.TabStop = false;
            this.picSearch.Click += new System.EventHandler(this.picSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(27, 245);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(522, 29);
            this.txtSearch.TabIndex = 38;
            // 
            // dBSDataSet5
            // 
            this.dBSDataSet5.DataSetName = "DBSDataSet5";
            this.dBSDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.dBSDataSet5;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(974, 663);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Operations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageUsers";
            this.Text = "Form1";
            this.Operations.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.GroupBox Operations;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCpass;
        private DBSDataSet5 dBSDataSet5;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DBSDataSet5TableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbGender;
    }
}
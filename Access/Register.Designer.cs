namespace LibSys
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.txtCpass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = global::LibSys.Properties.Resources.background;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(561, 645);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmbGender);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtLname);
            this.panel1.Controls.Add(this.txtFname);
            this.panel1.Controls.Add(this.btnReg);
            this.panel1.Controls.Add(this.txtCpass);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(561, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 645);
            this.panel1.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(61, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 40);
            this.label3.TabIndex = 78;
            this.label3.Text = "Sign Up";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(99)))), ((int)(((byte)(108)))));
            this.label6.Location = new System.Drawing.Point(63, 440);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 25);
            this.label6.TabIndex = 77;
            this.label6.Text = "Confirm Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(99)))), ((int)(((byte)(108)))));
            this.label5.Location = new System.Drawing.Point(209, 198);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 25);
            this.label5.TabIndex = 76;
            this.label5.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(99)))), ((int)(((byte)(108)))));
            this.label4.Location = new System.Drawing.Point(62, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 75;
            this.label4.Text = "First Name";
            // 
            // txtLname
            // 
            this.txtLname.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtLname.Location = new System.Drawing.Point(214, 229);
            this.txtLname.Margin = new System.Windows.Forms.Padding(6);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(129, 32);
            this.txtLname.TabIndex = 74;
            // 
            // txtFname
            // 
            this.txtFname.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtFname.Location = new System.Drawing.Point(64, 229);
            this.txtFname.Margin = new System.Windows.Forms.Padding(6);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(129, 32);
            this.txtFname.TabIndex = 73;
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.btnReg.Font = new System.Drawing.Font("Verdana", 11F);
            this.btnReg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReg.Location = new System.Drawing.Point(64, 525);
            this.btnReg.Margin = new System.Windows.Forms.Padding(6);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(279, 63);
            this.btnReg.TabIndex = 72;
            this.btnReg.Text = "Register";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // txtCpass
            // 
            this.txtCpass.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtCpass.Location = new System.Drawing.Point(64, 471);
            this.txtCpass.Margin = new System.Windows.Forms.Padding(6);
            this.txtCpass.Name = "txtCpass";
            this.txtCpass.Size = new System.Drawing.Size(279, 32);
            this.txtCpass.TabIndex = 71;
            this.txtCpass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(99)))), ((int)(((byte)(108)))));
            this.label2.Location = new System.Drawing.Point(63, 359);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 70;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(99)))), ((int)(((byte)(108)))));
            this.label1.Location = new System.Drawing.Point(63, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 69;
            this.label1.Text = "Username";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtPass.Location = new System.Drawing.Point(64, 390);
            this.txtPass.Margin = new System.Windows.Forms.Padding(6);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(279, 32);
            this.txtPass.TabIndex = 68;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtUser.Location = new System.Drawing.Point(64, 150);
            this.txtUser.Margin = new System.Windows.Forms.Padding(6);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(279, 32);
            this.txtUser.TabIndex = 67;
            // 
            // cmbGender
            // 
            this.cmbGender.Font = new System.Drawing.Font("Verdana", 12F);
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(64, 303);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(279, 33);
            this.cmbGender.TabIndex = 80;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(99)))), ((int)(((byte)(108)))));
            this.label7.Location = new System.Drawing.Point(63, 275);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 25);
            this.label7.TabIndex = 81;
            this.label7.Text = "Gender";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(965, 645);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.TextBox txtCpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbGender;
    }
}
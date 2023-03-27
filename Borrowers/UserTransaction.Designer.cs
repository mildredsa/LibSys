namespace LibSys.Borrowers
{
    partial class UserTransaction
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.picLogout = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnBorrow);
            this.groupBox1.Controls.Add(this.btnReturn);
            this.groupBox1.Location = new System.Drawing.Point(663, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 396);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transactions";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Verdana", 11F);
            this.btnClear.Location = new System.Drawing.Point(22, 301);
            this.btnClear.Margin = new System.Windows.Forms.Padding(6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(228, 63);
            this.btnClear.TabIndex = 51;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBorrow
            // 
            this.btnBorrow.Font = new System.Drawing.Font("Verdana", 11F);
            this.btnBorrow.Location = new System.Drawing.Point(22, 82);
            this.btnBorrow.Margin = new System.Windows.Forms.Padding(6);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(228, 63);
            this.btnBorrow.TabIndex = 50;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Verdana", 11F);
            this.btnReturn.Location = new System.Drawing.Point(22, 191);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(6);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(228, 63);
            this.btnReturn.TabIndex = 49;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(26, 272);
            this.grid.Margin = new System.Windows.Forms.Padding(6);
            this.grid.Name = "grid";
            this.grid.RowHeadersWidth = 51;
            this.grid.RowTemplate.Height = 24;
            this.grid.Size = new System.Drawing.Size(546, 304);
            this.grid.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F);
            this.label2.Location = new System.Drawing.Point(21, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 56;
            this.label2.Text = "Username";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtUser.Location = new System.Drawing.Point(26, 82);
            this.txtUser.Margin = new System.Windows.Forms.Padding(6);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(297, 32);
            this.txtUser.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F);
            this.label1.Location = new System.Drawing.Point(21, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 54;
            this.label1.Text = "Accession Number";
            // 
            // txtNo
            // 
            this.txtNo.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtNo.Location = new System.Drawing.Point(26, 151);
            this.txtNo.Margin = new System.Windows.Forms.Padding(6);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(297, 32);
            this.txtNo.TabIndex = 53;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picSearch);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtUser);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.grid);
            this.groupBox2.Controls.Add(this.txtNo);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F);
            this.groupBox2.Location = new System.Drawing.Point(32, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(596, 598);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // picSearch
            // 
            this.picSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSearch.Image = global::LibSys.Properties.Resources.search;
            this.picSearch.Location = new System.Drawing.Point(533, 231);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(39, 32);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSearch.TabIndex = 62;
            this.picSearch.TabStop = false;
            this.picSearch.Click += new System.EventHandler(this.picSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtSearch.Location = new System.Drawing.Point(26, 231);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(501, 32);
            this.txtSearch.TabIndex = 61;
            // 
            // picLogout
            // 
            this.picLogout.Image = global::LibSys.Properties.Resources.exit;
            this.picLogout.Location = new System.Drawing.Point(751, 85);
            this.picLogout.Name = "picLogout";
            this.picLogout.Size = new System.Drawing.Size(92, 94);
            this.picLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogout.TabIndex = 60;
            this.picLogout.TabStop = false;
            this.picLogout.Click += new System.EventHandler(this.picLogout_Click);
            // 
            // UserTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(971, 668);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picLogout);
            this.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UserTransaction";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Button btnClear;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picLogout;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}
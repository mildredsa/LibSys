namespace LibSys.Admin
{
    partial class Reports
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
            this.grid = new System.Windows.Forms.DataGridView();
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnBorrowers = new System.Windows.Forms.Button();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.borrowedTableAdapter1 = new LibSys.DBSDataSet1TableAdapters.BorrowedTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(12, 118);
            this.grid.Name = "grid";
            this.grid.RowHeadersWidth = 51;
            this.grid.RowTemplate.Height = 24;
            this.grid.Size = new System.Drawing.Size(874, 354);
            this.grid.TabIndex = 25;
            // 
            // btnBooks
            // 
            this.btnBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btnBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBooks.Font = new System.Drawing.Font("Verdana", 15F);
            this.btnBooks.Image = global::LibSys.Properties.Resources.books__1_;
            this.btnBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBooks.Location = new System.Drawing.Point(305, 3);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Padding = new System.Windows.Forms.Padding(10, 3, 55, 3);
            this.btnBooks.Size = new System.Drawing.Size(281, 106);
            this.btnBooks.TabIndex = 23;
            this.btnBooks.Text = "Books";
            this.btnBooks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBooks.UseVisualStyleBackColor = false;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // btnBorrowers
            // 
            this.btnBorrowers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btnBorrowers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBorrowers.Font = new System.Drawing.Font("Verdana", 15F);
            this.btnBorrowers.Image = global::LibSys.Properties.Resources.users__1_;
            this.btnBorrowers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrowers.Location = new System.Drawing.Point(592, 3);
            this.btnBorrowers.Name = "btnBorrowers";
            this.btnBorrowers.Padding = new System.Windows.Forms.Padding(10, 3, 30, 3);
            this.btnBorrowers.Size = new System.Drawing.Size(303, 106);
            this.btnBorrowers.TabIndex = 22;
            this.btnBorrowers.Text = "Borrowers";
            this.btnBorrowers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrowers.UseVisualStyleBackColor = false;
            this.btnBorrowers.Click += new System.EventHandler(this.btnBorrowers_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btnTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTransactions.Font = new System.Drawing.Font("Verdana", 15F);
            this.btnTransactions.Image = global::LibSys.Properties.Resources.write__2_;
            this.btnTransactions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransactions.Location = new System.Drawing.Point(3, 3);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Padding = new System.Windows.Forms.Padding(10, 3, 8, 3);
            this.btnTransactions.Size = new System.Drawing.Size(296, 106);
            this.btnTransactions.TabIndex = 21;
            this.btnTransactions.Text = "Transactions";
            this.btnTransactions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTransactions.UseVisualStyleBackColor = false;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // borrowedTableAdapter1
            // 
            this.borrowedTableAdapter1.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.27335F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.72665F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 308F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnTransactions, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBooks, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBorrowers, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(898, 112);
            this.tableLayoutPanel1.TabIndex = 27;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btnClose.Font = new System.Drawing.Font("Verdana", 15F);
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(744, 484);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(142, 51);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 547);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.grid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reports";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.Button btnBorrowers;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.DataGridView grid;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DBSDataSet1TableAdapters.BorrowedTableAdapter borrowedTableAdapter1;
        private System.Windows.Forms.Button btnClose;
    }
}
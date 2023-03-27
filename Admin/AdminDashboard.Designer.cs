namespace LibSys.Admin
{
    partial class AdminDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfBorrowersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.picLogout = new System.Windows.Forms.PictureBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem,
            this.borrowersToolStripMenuItem});
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.manageToolStripMenuItem.Text = "Manage";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.booksToolStripMenuItem.Text = "Books";
            this.booksToolStripMenuItem.Click += new System.EventHandler(this.booksToolStripMenuItem_Click);
            // 
            // borrowersToolStripMenuItem
            // 
            this.borrowersToolStripMenuItem.Name = "borrowersToolStripMenuItem";
            this.borrowersToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.borrowersToolStripMenuItem.Text = "Borrowers";
            this.borrowersToolStripMenuItem.Click += new System.EventHandler(this.borrowersToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrowedToolStripMenuItem,
            this.returnedToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.reportsToolStripMenuItem.Text = "Transactions";
            // 
            // borrowedToolStripMenuItem
            // 
            this.borrowedToolStripMenuItem.Name = "borrowedToolStripMenuItem";
            this.borrowedToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.borrowedToolStripMenuItem.Text = "Borrowed";
            this.borrowedToolStripMenuItem.Click += new System.EventHandler(this.borrowedToolStripMenuItem_Click);
            // 
            // returnedToolStripMenuItem
            // 
            this.returnedToolStripMenuItem.Name = "returnedToolStripMenuItem";
            this.returnedToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.returnedToolStripMenuItem.Text = "Returned";
            this.returnedToolStripMenuItem.Click += new System.EventHandler(this.returnedToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem1
            // 
            this.reportsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transactionHistoryToolStripMenuItem,
            this.listOfBooksToolStripMenuItem,
            this.listOfBorrowersToolStripMenuItem,
            this.testReportsToolStripMenuItem});
            this.reportsToolStripMenuItem1.Name = "reportsToolStripMenuItem1";
            this.reportsToolStripMenuItem1.Size = new System.Drawing.Size(74, 24);
            this.reportsToolStripMenuItem1.Text = "Reports";
            // 
            // transactionHistoryToolStripMenuItem
            // 
            this.transactionHistoryToolStripMenuItem.Name = "transactionHistoryToolStripMenuItem";
            this.transactionHistoryToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.transactionHistoryToolStripMenuItem.Text = "Transaction History";
            this.transactionHistoryToolStripMenuItem.Click += new System.EventHandler(this.transactionHistoryToolStripMenuItem_Click);
            // 
            // testReportsToolStripMenuItem
            // 
            this.testReportsToolStripMenuItem.Name = "testReportsToolStripMenuItem";
            this.testReportsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.testReportsToolStripMenuItem.Text = "Test Reports";
            this.testReportsToolStripMenuItem.Click += new System.EventHandler(this.testReportsToolStripMenuItem_Click);
            // 
            // listOfBooksToolStripMenuItem
            // 
            this.listOfBooksToolStripMenuItem.Name = "listOfBooksToolStripMenuItem";
            this.listOfBooksToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listOfBooksToolStripMenuItem.Text = "List of Books";
            this.listOfBooksToolStripMenuItem.Click += new System.EventHandler(this.listOfBooksToolStripMenuItem_Click);
            // 
            // listOfBorrowersToolStripMenuItem
            // 
            this.listOfBorrowersToolStripMenuItem.Name = "listOfBorrowersToolStripMenuItem";
            this.listOfBorrowersToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listOfBorrowersToolStripMenuItem.Text = "List of Borrowers";
            this.listOfBorrowersToolStripMenuItem.Click += new System.EventHandler(this.listOfBorrowersToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.reportsToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(801, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // picLogout
            // 
            this.picLogout.Image = global::LibSys.Properties.Resources.exit;
            this.picLogout.Location = new System.Drawing.Point(713, 397);
            this.picLogout.Name = "picLogout";
            this.picLogout.Size = new System.Drawing.Size(76, 71);
            this.picLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogout.TabIndex = 1;
            this.picLogout.TabStop = false;
            this.picLogout.Click += new System.EventHandler(this.picLogout_Click);
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(29, 51);
            this.grid.Name = "grid";
            this.grid.RowHeadersWidth = 51;
            this.grid.RowTemplate.Height = 24;
            this.grid.Size = new System.Drawing.Size(406, 322);
            this.grid.TabIndex = 2;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(459, 51);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Gender";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(311, 322);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            title1.Name = "Borrowers";
            this.chart1.Titles.Add(title1);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 480);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.picLogout);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminDashboard";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem transactionHistoryToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listOfBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfBorrowersToolStripMenuItem;
        private System.Windows.Forms.PictureBox picLogout;
        private System.Windows.Forms.ToolStripMenuItem testReportsToolStripMenuItem;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
namespace LibSys.Admin
{
    partial class Borrowed
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.accessionNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBSDataSet2 = new LibSys.DBSDataSet2();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accessionNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateBorrowedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBSDataSet1 = new LibSys.DBSDataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.borrowedTableAdapter = new LibSys.DBSDataSet1TableAdapters.BorrowedTableAdapter();
            this.booksTableAdapter = new LibSys.DBSDataSet2TableAdapters.BooksTableAdapter();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accessionNumberDataGridViewTextBoxColumn1,
            this.titleDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.inventoryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.booksBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(374, 329);
            this.dataGridView1.TabIndex = 0;
            // 
            // accessionNumberDataGridViewTextBoxColumn1
            // 
            this.accessionNumberDataGridViewTextBoxColumn1.DataPropertyName = "AccessionNumber";
            this.accessionNumberDataGridViewTextBoxColumn1.HeaderText = "AccessionNumber";
            this.accessionNumberDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.accessionNumberDataGridViewTextBoxColumn1.Name = "accessionNumberDataGridViewTextBoxColumn1";
            this.accessionNumberDataGridViewTextBoxColumn1.Width = 125;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 125;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // inventoryDataGridViewTextBoxColumn
            // 
            this.inventoryDataGridViewTextBoxColumn.DataPropertyName = "Inventory";
            this.inventoryDataGridViewTextBoxColumn.HeaderText = "Inventory";
            this.inventoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.inventoryDataGridViewTextBoxColumn.Name = "inventoryDataGridViewTextBoxColumn";
            this.inventoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.dBSDataSet2;
            // 
            // dBSDataSet2
            // 
            this.dBSDataSet2.DataSetName = "DBSDataSet2";
            this.dBSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.accessionNumberDataGridViewTextBoxColumn,
            this.dateBorrowedDataGridViewTextBoxColumn,
            this.dueDateDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.borrowedBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(414, 109);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(374, 329);
            this.dataGridView2.TabIndex = 1;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // accessionNumberDataGridViewTextBoxColumn
            // 
            this.accessionNumberDataGridViewTextBoxColumn.DataPropertyName = "AccessionNumber";
            this.accessionNumberDataGridViewTextBoxColumn.HeaderText = "AccessionNumber";
            this.accessionNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.accessionNumberDataGridViewTextBoxColumn.Name = "accessionNumberDataGridViewTextBoxColumn";
            this.accessionNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateBorrowedDataGridViewTextBoxColumn
            // 
            this.dateBorrowedDataGridViewTextBoxColumn.DataPropertyName = "DateBorrowed";
            this.dateBorrowedDataGridViewTextBoxColumn.HeaderText = "DateBorrowed";
            this.dateBorrowedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateBorrowedDataGridViewTextBoxColumn.Name = "dateBorrowedDataGridViewTextBoxColumn";
            this.dateBorrowedDataGridViewTextBoxColumn.Width = 125;
            // 
            // dueDateDataGridViewTextBoxColumn
            // 
            this.dueDateDataGridViewTextBoxColumn.DataPropertyName = "DueDate";
            this.dueDateDataGridViewTextBoxColumn.HeaderText = "DueDate";
            this.dueDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dueDateDataGridViewTextBoxColumn.Name = "dueDateDataGridViewTextBoxColumn";
            this.dueDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // borrowedBindingSource
            // 
            this.borrowedBindingSource.DataMember = "Borrowed";
            this.borrowedBindingSource.DataSource = this.dBSDataSet1;
            // 
            // dBSDataSet1
            // 
            this.dBSDataSet1.DataSetName = "DBSDataSet1";
            this.dBSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Borrowed Books";
            // 
            // borrowedTableAdapter
            // 
            this.borrowedTableAdapter.ClearBeforeFill = true;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(672, 457);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(116, 39);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Borrowed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Borrowed";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private DBSDataSet1 dBSDataSet1;
        private System.Windows.Forms.BindingSource borrowedBindingSource;
        private DBSDataSet1TableAdapters.BorrowedTableAdapter borrowedTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessionNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateBorrowedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private DBSDataSet2 dBSDataSet2;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private DBSDataSet2TableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessionNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryDataGridViewTextBoxColumn;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button btnClose;
    }
}
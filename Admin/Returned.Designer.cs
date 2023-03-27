namespace LibSys.Admin
{
    partial class Returned
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accessionNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateReturnedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBSDataSet4 = new LibSys.DBSDataSet4();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.accessionNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBSDataSet3 = new LibSys.DBSDataSet3();
            this.booksTableAdapter = new LibSys.DBSDataSet3TableAdapters.BooksTableAdapter();
            this.returnedTableAdapter = new LibSys.DBSDataSet4TableAdapters.ReturnedTableAdapter();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "Returned Books";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.accessionNumberDataGridViewTextBoxColumn1,
            this.dateReturnedDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.returnedBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(414, 106);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(374, 329);
            this.dataGridView2.TabIndex = 4;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // accessionNumberDataGridViewTextBoxColumn1
            // 
            this.accessionNumberDataGridViewTextBoxColumn1.DataPropertyName = "AccessionNumber";
            this.accessionNumberDataGridViewTextBoxColumn1.HeaderText = "AccessionNumber";
            this.accessionNumberDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.accessionNumberDataGridViewTextBoxColumn1.Name = "accessionNumberDataGridViewTextBoxColumn1";
            this.accessionNumberDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dateReturnedDataGridViewTextBoxColumn
            // 
            this.dateReturnedDataGridViewTextBoxColumn.DataPropertyName = "DateReturned";
            this.dateReturnedDataGridViewTextBoxColumn.HeaderText = "DateReturned";
            this.dateReturnedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateReturnedDataGridViewTextBoxColumn.Name = "dateReturnedDataGridViewTextBoxColumn";
            this.dateReturnedDataGridViewTextBoxColumn.Width = 125;
            // 
            // returnedBindingSource
            // 
            this.returnedBindingSource.DataMember = "Returned";
            this.returnedBindingSource.DataSource = this.dBSDataSet4;
            // 
            // dBSDataSet4
            // 
            this.dBSDataSet4.DataSetName = "DBSDataSet4";
            this.dBSDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accessionNumberDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.inventoryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.booksBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(374, 329);
            this.dataGridView1.TabIndex = 3;
            // 
            // accessionNumberDataGridViewTextBoxColumn
            // 
            this.accessionNumberDataGridViewTextBoxColumn.DataPropertyName = "AccessionNumber";
            this.accessionNumberDataGridViewTextBoxColumn.HeaderText = "AccessionNumber";
            this.accessionNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.accessionNumberDataGridViewTextBoxColumn.Name = "accessionNumberDataGridViewTextBoxColumn";
            this.accessionNumberDataGridViewTextBoxColumn.Width = 125;
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
            this.booksBindingSource.DataSource = this.dBSDataSet3;
            // 
            // dBSDataSet3
            // 
            this.dBSDataSet3.DataSetName = "DBSDataSet3";
            this.dBSDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // returnedTableAdapter
            // 
            this.returnedTableAdapter.ClearBeforeFill = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(675, 450);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(116, 38);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Returned
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 500);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Returned";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Returned_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DBSDataSet3 dBSDataSet3;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private DBSDataSet3TableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessionNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryDataGridViewTextBoxColumn;
        private DBSDataSet4 dBSDataSet4;
        private System.Windows.Forms.BindingSource returnedBindingSource;
        private DBSDataSet4TableAdapters.ReturnedTableAdapter returnedTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessionNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateReturnedDataGridViewTextBoxColumn;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button btnClose;
    }
}
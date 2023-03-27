namespace LibSys
{
    partial class ManageBooks
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnIssue = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.booksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dBSDataSet6 = new LibSys.DBSDataSet6();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.dBSDataSet = new LibSys.DBSDataSet();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter = new LibSys.DBSDataSetTableAdapters.BooksTableAdapter();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Operations = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.booksTableAdapter1 = new LibSys.DBSDataSet6TableAdapters.BooksTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            this.Operations.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Author";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.Location = new System.Drawing.Point(27, 191);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(231, 29);
            this.txtAuthor.TabIndex = 21;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Verdana", 11F);
            this.btnCreate.Location = new System.Drawing.Point(6, 66);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(237, 61);
            this.btnCreate.TabIndex = 20;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Accession Number";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(27, 130);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(231, 29);
            this.txtTitle.TabIndex = 17;
            // 
            // txtNo
            // 
            this.txtNo.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNo.Location = new System.Drawing.Point(27, 66);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(231, 29);
            this.txtNo.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Title";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 11F);
            this.btnDelete.Location = new System.Drawing.Point(6, 350);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(237, 61);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Verdana", 11F);
            this.btnUpdate.Location = new System.Drawing.Point(6, 256);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(237, 61);
            this.btnUpdate.TabIndex = 35;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnIssue
            // 
            this.btnIssue.Font = new System.Drawing.Font("Verdana", 11F);
            this.btnIssue.Location = new System.Drawing.Point(6, 157);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(237, 63);
            this.btnIssue.TabIndex = 34;
            this.btnIssue.Text = "Issue";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
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
            // booksBindingSource1
            // 
            this.booksBindingSource1.DataMember = "Books";
            this.booksBindingSource1.DataSource = this.dBSDataSet6;
            // 
            // dBSDataSet6
            // 
            this.dBSDataSet6.DataSetName = "DBSDataSet6";
            this.dBSDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(27, 245);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(522, 29);
            this.txtSearch.TabIndex = 38;
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
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Verdana", 11F);
            this.btnCancel.Location = new System.Drawing.Point(6, 445);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(237, 61);
            this.btnCancel.TabIndex = 40;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            // dBSDataSet
            // 
            this.dBSDataSet.DataSetName = "DBSDataSet";
            this.dBSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.dBSDataSet;
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
            // Operations
            // 
            this.Operations.Controls.Add(this.btnUpdate);
            this.Operations.Controls.Add(this.btnDone);
            this.Operations.Controls.Add(this.btnCreate);
            this.Operations.Controls.Add(this.btnCancel);
            this.Operations.Controls.Add(this.btnIssue);
            this.Operations.Controls.Add(this.btnDelete);
            this.Operations.Location = new System.Drawing.Point(684, 23);
            this.Operations.Name = "Operations";
            this.Operations.Size = new System.Drawing.Size(249, 617);
            this.Operations.TabIndex = 42;
            this.Operations.TabStop = false;
            this.Operations.Text = "Operations";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.txtNo);
            this.groupBox1.Controls.Add(this.grid);
            this.groupBox1.Controls.Add(this.picSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAuthor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(38, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 617);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manage Books";
            // 
            // booksTableAdapter1
            // 
            this.booksTableAdapter1.ClearBeforeFill = true;
            // 
            // ManageBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(974, 663);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Operations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageBooks";
            this.ShowIcon = false;
            this.Text = "Manage Books";
            
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            this.Operations.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDone;
        private DBSDataSet dBSDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private DBSDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Operations;
        private DBSDataSet6 dBSDataSet6;
        private System.Windows.Forms.BindingSource booksBindingSource1;
        private DBSDataSet6TableAdapters.BooksTableAdapter booksTableAdapter1;
    }
}
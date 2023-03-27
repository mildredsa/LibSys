using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibSys.Admin
{
    public partial class Borrowed : Form
    {
        public Borrowed()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBSDataSet2.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.dBSDataSet2.Books);
            // TODO: This line of code loads data into the 'dBSDataSet1.Borrowed' table. You can move, or remove it, as needed.
            this.borrowedTableAdapter.Fill(this.dBSDataSet1.Borrowed);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

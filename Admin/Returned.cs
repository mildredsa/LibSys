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
    public partial class Returned : Form
    {
        public Returned()
        {
            InitializeComponent();
        }

        private void Returned_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBSDataSet4.Returned' table. You can move, or remove it, as needed.
            this.returnedTableAdapter.Fill(this.dBSDataSet4.Returned);
            // TODO: This line of code loads data into the 'dBSDataSet3.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.dBSDataSet3.Books);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

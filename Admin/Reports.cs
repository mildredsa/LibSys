using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibSys.Admin
{
    public partial class Reports : Form
    {
        private SqlConnection con;
        String connection = "Data Source=LAPTOP-M3IQH77K\\MSASERVER;Initial Catalog=DBS;Integrated Security=True";
        public Reports()
        {
            InitializeComponent();
            con = new SqlConnection(connection);
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Transactions", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            grid.DataSource = table;
            con.Close();
        }

        private void btnBorrowers_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Borrowers", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            grid.DataSource = table;
            con.Close();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Books", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            grid.DataSource = table;
            con.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

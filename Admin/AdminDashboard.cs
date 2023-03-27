using LibSys.Print;
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
    public partial class AdminDashboard : Form
    {
        String connection = "Data Source=LAPTOP-M3IQH77K\\MSASERVER;Initial Catalog=DBS;Integrated Security=True";
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ManageBooks().Show();
        }

        private void borrowersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ManageUsers().Show();
        }

        private void borrowedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Borrowed().Show();
        }

        private void returnedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Returned().Show();
        }

        private void testReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Reports().Show();
        }

        private void listOfBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PrintBooks().Show();    
        }

        private void listOfBorrowersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PrintBorrowers().Show();    
        }

        private void transactionHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PrintTransactions().Show(); 
        }

        private void picLogout_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("Are you sure you want to log out?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (response == DialogResult.OK)
            {
                new Login().Show();
                this.Hide();
            }

        }

        private void loadDatagrid()
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Gender, COUNT(*) AS Count FROM Users WHERE Gender IS NOT NULL GROUP BY Gender", con);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                grid.DataSource = dt;
                con.Close();
            }
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            loadDatagrid();

            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT Gender, COUNT(*) AS Count FROM Users WHERE Gender IS NOT NULL GROUP BY Gender", con);
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                // Set the data source for the chart
                chart1.Series["Gender"].Points.DataBind(dt.AsEnumerable(), "Gender", "Count", "");

                // Set the label format to show the percentage
                chart1.Series["Gender"].LabelFormat = "{0}%";

                // Close the database connection
                con.Close();
            }
        }
    }
}

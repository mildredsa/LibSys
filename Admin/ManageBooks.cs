using LibSys.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibSys
{
    public partial class ManageBooks : Form
    {
        private SqlConnection con;
        String connection = "Data Source=LAPTOP-M3IQH77K\\MSASERVER;Initial Catalog=DBS;Integrated Security=True";
        public ManageBooks()
        {
            InitializeComponent();
            con = new SqlConnection(connection);
        }

        private void picSearch_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand searchCmd = new SqlCommand("SELECT * FROM books WHERE CONCAT(AccessionNumber, ' ', Title, ' ', Author, ' ', Status) LIKE @searchString", con);
            searchCmd.Parameters.AddWithValue("searchString", "%" + txtSearch.Text + "%");
            searchCmd.ExecuteNonQuery();

            SqlDataAdapter adap = new SqlDataAdapter(searchCmd);
            DataTable dt = new DataTable();

            adap.Fill(dt);
            grid.DataSource = dt;

            con.Close();
        }

        private void loadDatagrid()
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Books ORDER BY AccessionNumber ASC", con);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                grid.DataSource = dt;
                con.Close();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            con.Open();

            if (int.TryParse(txtNo.Text, out int accno))
            {
                SqlCommand chkBook = new SqlCommand("SELECT AccessionNumber FROM Books WHERE AccessionNumber = @AccessionNumber", con);
                chkBook.Parameters.AddWithValue("AccessionNumber", accno);

                if (chkBook.ExecuteScalar() != null)
                {
                    MessageBox.Show("Book is already in inventory.", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    SqlCommand addBook = new SqlCommand("INSERT INTO Books(AccessionNumber, Title, Author) VALUES (@AccessionNumber, @Title, @Author)", con);
                    addBook.Parameters.AddWithValue("AccessionNumber", accno);
                    addBook.Parameters.AddWithValue("Title", txtTitle.Text);
                    addBook.Parameters.AddWithValue("Author", txtAuthor.Text);
                    addBook.ExecuteNonQuery();

                    MessageBox.Show("Book successfully added!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Accession Number must be a valid integer.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            loadDatagrid();
            con.Close();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand chkBook = new SqlCommand("SELECT AccessionNumber FROM Books WHERE AccessionNumber = @AccessionNumber", con);

            if (int.TryParse(txtNo.Text, out int accno))
            {
                chkBook.Parameters.AddWithValue("AccessionNumber", accno);

                if (chkBook.ExecuteScalar() != null)
                {
                    SqlCommand chkInventory = new SqlCommand("SELECT Inventory FROM Books WHERE AccessionNumber = @AccessionNumber", con);
                    chkInventory.Parameters.AddWithValue("AccessionNumber", txtNo.Text);

                    int inventory = (int)chkInventory.ExecuteScalar();

                    if (inventory != 0)
                    {
                        SqlCommand issue = new SqlCommand("UPDATE Books SET Status = 'Available' WHERE AccessionNumber = @AccessionNumber", con);
                        issue.Parameters.AddWithValue("AccessionNumber", txtNo.Text);
                        issue.ExecuteNonQuery();

                        MessageBox.Show("Book has been issued!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Book has been borrowed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Book doesn't exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Accession Number must be a valid integer.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            loadDatagrid();
            con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand chkBook = new SqlCommand("SELECT AccessionNumber FROM Books WHERE AccessionNumber = @AccessionNumber", con);
            chkBook.Parameters.AddWithValue("AccessionNumber", txtNo.Text);

            if (int.TryParse(txtNo.Text, out int accno))
            {
                if (chkBook.ExecuteScalar() != null)
                {
                    SqlCommand updateBooks = new SqlCommand("UPDATE Books SET Title = @Title, Author = @Author WHERE AccessionNumber = @AccessionNumber", con);
                    updateBooks.Parameters.AddWithValue("AccessionNumber", txtNo.Text);
                    updateBooks.Parameters.AddWithValue("Title", txtTitle.Text);
                    updateBooks.Parameters.AddWithValue("Author", txtAuthor.Text);
                    updateBooks.ExecuteNonQuery();

                    MessageBox.Show("Book successfully updated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Book doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Accession Number must be a valid integer.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            loadDatagrid();
            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand chkBook = new SqlCommand("SELECT AccessionNumber FROM Books WHERE AccessionNumber = @AccessionNumber", con);
            chkBook.Parameters.AddWithValue("AccessionNumber", txtNo.Text);

            if (int.TryParse(txtNo.Text, out int accno))
            {
                if (chkBook.ExecuteScalar() != null)
                {
                    SqlCommand deleteBook = new SqlCommand("UPDATE Books SET Status = 'Lost', Inventory = NULL WHERE AccessionNumber = @AccessionNumber", con);
                    deleteBook.Parameters.AddWithValue("AccessionNumber", txtNo.Text);
                    deleteBook.ExecuteNonQuery();

                    MessageBox.Show("Book successfully deleted!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Book doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Accession Number must be a valid integer.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            loadDatagrid();
            con.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtNo.Clear();
            txtTitle.Clear();
            txtAuthor.Clear();
            txtSearch.Clear();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

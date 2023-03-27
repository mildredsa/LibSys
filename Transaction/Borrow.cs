using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibSys
{
    public partial class Borrow : Form
    {
        private SqlConnection con;
        String connection = "Data Source=LAPTOP-M3IQH77K\\MSASERVER;Initial Catalog=DBS;Integrated Security=True";
        public Borrow()
        {
            InitializeComponent();
            con = new SqlConnection(connection);
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            con.Open();

            // check if the book exists in the database
            SqlCommand chkBook = new SqlCommand("SELECT AccessionNumber, Status FROM Books WHERE AccessionNumber = @AccessionNumber", con);
            chkBook.Parameters.AddWithValue("AccessionNumber", txtNo.Text);

            SqlDataReader books = chkBook.ExecuteReader();

            if (books.Read())
            {
                string bookstatus = books.GetString(1);

                if (!string.IsNullOrEmpty(bookstatus))
                {
                    if (bookstatus == "Available")
                    {
                        books.Close(); // close the SqlDataReader

                        // check if the user exists in the database
                        SqlCommand chkUser = new SqlCommand("SELECT Username, Status FROM Users WHERE Username = @Username", con);
                        chkUser.Parameters.AddWithValue("Username", txtUser.Text);

                        SqlDataReader users = chkUser.ExecuteReader();

                        if (users.Read())
                        {
                            string userstatus = users.GetString(1);

                            if (!string.IsNullOrEmpty(userstatus))
                            {
                                if (userstatus == "Active")
                                {
                                    users.Close(); // close the SqlDataReader

                                    // update the Books table to mark the book as borrowed
                                    SqlCommand updateBooks = new SqlCommand("UPDATE Books SET Status = 'Unavailable', Inventory = Inventory - 1 WHERE AccessionNumber = @AccessionNumber", con);
                                    updateBooks.Parameters.AddWithValue("AccessionNumber", txtNo.Text);
                                    updateBooks.ExecuteNonQuery();

                                    // insert a record in the Borrowed table to record the book's loan
                                    SqlCommand borrow = new SqlCommand("INSERT INTO Borrowed(AccessionNumber, Username) VALUES(@AccessionNumber, @Username)", con);
                                    borrow.Parameters.AddWithValue("AccessionNumber", txtNo.Text);
                                    borrow.Parameters.AddWithValue("Username", txtUser.Text);
                                    borrow.ExecuteNonQuery();

                                    MessageBox.Show("Book Borrowed", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("User Account has not been activated. Please inquire.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                }
                            }
                            else
                            {
                                MessageBox.Show("An error has occured. Please inquire.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Hide();
                            }

                            users.Close(); // close the SqlDataReader
                        }
                        else
                        {
                            MessageBox.Show("User does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Book has already been borrowed. Please inquire.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Hide();
                    }
                }
                else
                {
                    MessageBox.Show("An error has occured. Please inquire.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                }

                books.Close(); // close the SqlDataReader
            }
            else
            {
                MessageBox.Show("Book does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();
        }
    }
    
}

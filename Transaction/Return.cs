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
    public partial class Return : Form
    {
        private SqlConnection con;
        String connection = "Data Source=LAPTOP-M3IQH77K\\MSASERVER;Initial Catalog=DBS;Integrated Security=True";
        public Return()
        {
            InitializeComponent();
            con = new SqlConnection(connection);
        }

        private void btnReturn_Click(object sender, EventArgs e)
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
                    if (bookstatus == "Unavailable")
                    {
                        // close the SqlDataReader
                        books.Close();

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

                                    SqlCommand cmd = new SqlCommand("SELECT Username FROM Borrowed WHERE AccessionNumber = @AccessionNumber AND Username = @Username", con);
                                    cmd.Parameters.AddWithValue("AccessionNumber", txtNo.Text);
                                    cmd.Parameters.AddWithValue("Username", txtUser.Text);
                                    SqlDataReader rd = cmd.ExecuteReader();

                                    if (rd.Read())
                                    {
                                        rd.Close(); // close the SqlDataReader

                                        // update the Books table to mark the book as returned
                                        SqlCommand updateBooks = new SqlCommand("UPDATE Books SET Status = 'Available', Inventory = Inventory + 1 WHERE AccessionNumber = @AccessionNumber", con);
                                        updateBooks.Parameters.AddWithValue("AccessionNumber", txtNo.Text);
                                        updateBooks.ExecuteNonQuery();

                                        // insert a record in the Returned table to record the book's return
                                        SqlCommand returnbook = new SqlCommand("INSERT INTO Returned(AccessionNumber, Username) VALUES(@AccessionNumber, @Username)", con);
                                        returnbook.Parameters.AddWithValue("AccessionNumber", txtNo.Text);
                                        returnbook.Parameters.AddWithValue("Username", txtUser.Text);
                                        returnbook.ExecuteNonQuery();

                                        MessageBox.Show("Book Returned", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        rd.Close(); // close the SqlDataReader

                                        MessageBox.Show("The book has not been borrowed by this user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
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
                        MessageBox.Show("Book has not been borrowed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Hide();
                    }
                }
                else
                {
                    MessageBox.Show("An error has occured. Please inquire.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                }
            }
            else
            {
                MessageBox.Show("Book does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();
        }
    }
}

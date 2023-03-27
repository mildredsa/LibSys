using LibSys.Admin;
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

namespace LibSys
{
    public partial class ManageUsers : Form
    {
        private SqlConnection con;
        String connection = "Data Source=LAPTOP-M3IQH77K\\MSASERVER;Initial Catalog=DBS;Integrated Security=True";
        public ManageUsers()
        {
            InitializeComponent();
            con = new SqlConnection(connection);
        }

        public static string encryptPassword(string password)
        {
            string encryptedPassword = "";
            foreach (char c in password)
            {
                int asciiValue = (int)c;
                asciiValue += 2;
                encryptedPassword += (char)asciiValue;
            }
            return encryptedPassword;
        }

        private void loadDatagrid()
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Users ORDER BY Username ASC", con);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                grid.DataSource = dt;
                con.Close();
            }
        }

        private void picSearch_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand searchCmd = new SqlCommand("SELECT * FROM Users WHERE CONCAT(Username, ' ', FirstName, ' ', LastName, ' ', Status, ' ', Gender) LIKE @searchString AND Role <> 'Admin' AND Status <> 'Deleted Account'", con);
            searchCmd.Parameters.AddWithValue("@searchString", "%" + txtSearch.Text + "%");

            SqlDataAdapter adap = new SqlDataAdapter(searchCmd);
            DataTable dt = new DataTable();

            adap.Fill(dt);
            grid.DataSource = dt;

            con.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == txtCpass.Text)
            {
                con.Open();

                SqlCommand chkUser = new SqlCommand("SELECT Username FROM Users WHERE Username = @Username", con);
                chkUser.Parameters.AddWithValue("Username", txtUser.Text);


                if (chkUser.ExecuteScalar() != null)
                {
                    MessageBox.Show("Username already taken!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand registerUser = new SqlCommand("INSERT INTO Users(Username, Password, FirstName, LastName, Gender) VALUES (@Username, @Password, @FirstName, @LastName, @Gender)", con);
                    registerUser.Parameters.AddWithValue("Username", txtUser.Text);
                    registerUser.Parameters.AddWithValue("Password", encryptPassword(txtPass.Text));
                    registerUser.Parameters.AddWithValue("FirstName", txtFname.Text);
                    registerUser.Parameters.AddWithValue("LastName", txtLname.Text);
                    registerUser.Parameters.AddWithValue("Gender", cmbGender.Text);
                    registerUser.ExecuteNonQuery();

                    MessageBox.Show("Account successfully created!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Password does not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loadDatagrid();
            con.Close();
        }

      

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand chkUser = new SqlCommand("SELECT Username FROM Users WHERE Username = @Username", con);
            chkUser.Parameters.AddWithValue("Username", txtUser.Text);

            if (chkUser.ExecuteScalar() != null)
            {
                SqlCommand updateUser = new SqlCommand("UPDATE Users SET FirstName = @FirstName, LastName = @LastName, Gender = @Gender WHERE Username = @Username", con);
                updateUser.Parameters.AddWithValue("Username", txtUser.Text);
                updateUser.Parameters.AddWithValue("FirstName", txtFname.Text);
                updateUser.Parameters.AddWithValue("LastName", txtLname.Text);
                updateUser.Parameters.AddWithValue("Gender", cmbGender.Text);
                updateUser.ExecuteNonQuery();

                MessageBox.Show("Account successfully updated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("User doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loadDatagrid();
            con.Close();

        }



        private void btnAct_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand chkUser = new SqlCommand("SELECT Username FROM Users WHERE Username = @Username", con);
            chkUser.Parameters.AddWithValue("Username", txtUser.Text);

            if (chkUser.ExecuteScalar() != null)
            {

                SqlCommand activate = new SqlCommand("UPDATE Users SET Status = 'Active' WHERE Username = @Username", con);
                activate.Parameters.AddWithValue("Username", txtUser.Text);
                activate.ExecuteNonQuery();

                MessageBox.Show("Account has been activated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("User doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loadDatagrid(); 
            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand chkUser = new SqlCommand("SELECT Username FROM Users WHERE Username = @Username", con);
            chkUser.Parameters.AddWithValue("Username", txtUser.Text);

            if (chkUser.ExecuteScalar() != null)
            {
                SqlCommand deleteUser = new SqlCommand("UPDATE Users SET Status = 'Deleted Account', Gender = NULL WHERE Username = @Username", con);
                deleteUser.Parameters.AddWithValue("Username", txtUser.Text);
                deleteUser.ExecuteNonQuery();

                MessageBox.Show("Account successfully deleted!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("User doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loadDatagrid();
            con.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtFname.Clear();
            txtLname.Clear();
            txtPass.Clear();
            txtCpass.Clear();
            txtSearch.Clear();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
    
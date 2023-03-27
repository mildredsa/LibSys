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
    public partial class Register : Form
    {
        private SqlConnection con;
        String connection = "Data Source=LAPTOP-M3IQH77K\\MSASERVER;Initial Catalog=DBS;Integrated Security=True";
        public Register()
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

        private void btnReg_Click(object sender, EventArgs e)
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

                    DialogResult response = MessageBox.Show("Registration Successful! Proceed to Login?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (response == DialogResult.Yes)
                    {
                        new Login().Show();
                        this.Hide();
                    }
                }


            }
            else
            {
                MessageBox.Show("Password does not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();
        }
    }
}

using LibSys.Admin;
using LibSys.Borrowers;
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
    public partial class Login : Form
    {
        private SqlConnection con;
        String connection = "Data Source=LAPTOP-M3IQH77K\\MSASERVER;Initial Catalog=DBS;Integrated Security=True";
        public Login()
        {
            InitializeComponent();
            con = new SqlConnection(connection);
        }

        public static string decryptPassword(string encryptedPassword)
        {
            string decryptedPassword = "";
            foreach (char c in encryptedPassword)
            {
                int asciiValue = (int)c;
                asciiValue -= 2;
                decryptedPassword += (char)asciiValue;
            }
            return decryptedPassword;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT Username, Password, Role, Status FROM Users WHERE Username = @username", con);
            cmd.Parameters.AddWithValue("Username", txtUser.Text);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string encryptedPassword = reader.GetString(1);
                string decryptedPassword = decryptPassword(encryptedPassword);

                if (decryptedPassword == txtPass.Text)
                {
                    try
                    {
                        string status = reader.GetString(3);

                        if (status == "Active")
                        {
                            string role = reader.GetString(2);

                            if (role == "Admin")
                            {
                                new AdminDashboard().Show();
                                this.Hide();
                            }
                            else if (role == "Student")
                            {
                                new UserTransaction().Show();
                                this.Hide();
                            }
                        }
                        else if (status == "Inactive")
                        {
                            MessageBox.Show("Account not activated. Wait for activation.", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        else
                        {
                            MessageBox.Show("Account may have been deleted.", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    catch (SqlNullValueException)
                    {
                        MessageBox.Show("Account not activated. Wait for activation.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Username and password doesn't match!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                DialogResult response = MessageBox.Show("User Account doesn't exist. Proceed to Register?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (response == DialogResult.Yes)
                {
                    new Register().Show();
                    this.Hide();
                }
            }

            con.Close();
        }
    }
}

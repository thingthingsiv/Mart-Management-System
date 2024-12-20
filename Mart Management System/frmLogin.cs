using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mart_Management_System
{
    public partial class frmLogin : Form
    {
        string connectionString = "Data Source=DESKTOP-6ULAPOO\\SQLEXPRESS;Initial Catalog=MartManagementSystem;Integrated Security=True;";
        public frmLogin()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';// Mask the password input
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Role FROM tbUsers WHERE Username = @Username AND Password = @Password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string role = reader["Role"].ToString();
                    this.Hide();
                    frmMain mainForm = new frmMain(username, role);  // Pass role to main form
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sign_Up frmSignUp = new Sign_Up();
            frmSignUp.ShowDialog();
        }
    }
}

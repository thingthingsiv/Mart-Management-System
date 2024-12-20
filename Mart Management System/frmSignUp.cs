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

namespace Mart_Management_System
{
    public partial class Sign_Up : Form
    {
        string connectionString = "Data Source=DESKTOP-6ULAPOO\\SQLEXPRESS;Initial Catalog=MartManagementSystem;Integrated Security=True;";

        public Sign_Up()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            txtConfirmPassword.PasswordChar = '*';
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string role = cboRole.SelectedItem.ToString();

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO tbUsers (Username, PhoneNumber, Password, Role) VALUES (@Username, @PhoneNumber, @Password, @Role)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Role", role);

                conn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Sign Up Successful! You can now log in.");
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

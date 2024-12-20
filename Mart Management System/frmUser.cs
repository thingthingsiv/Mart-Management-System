using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Mart_Management_System
{
    public partial class frmUser : Form
    {
        private int selectedUserId = -1;
        private readonly string connectionString = "Data Source=DESKTOP-6ULAPOO\\SQLEXPRESS;Initial Catalog=MartManagementSystem;Integrated Security=True;";

        public frmUser()
        {
            InitializeComponent();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }

        // Load users into the DataGridView
        private void LoadUserData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbUsers", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewUsers.DataSource = dt;
            }
        }

        // Add new user
        private void btnAdd_Click(object sender, EventArgs e)
        {
            User newUser = GetUserFromFields();
            AddUser(newUser);
            MessageBox.Show("User added successfully!");
            LoadUserData();
            ClearFields();
        }

        // Retrieve user data from form fields and create a User object
        private User GetUserFromFields()
        {
            return new User
            {
                Username = txtUsername.Text,
                PhoneNumber = txtPhoneNumber.Text,
                Password = txtPassword.Text,
                Role = cboRole.SelectedItem?.ToString()
            };
        }

        // Add a new user to the database
        private void AddUser(User user)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO tbUsers (Username, PhoneNumber, Password, Role) VALUES (@Username, @PhoneNumber, @Password, @Role)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", user.Username);
                    cmd.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Password", user.Password);
                    cmd.Parameters.AddWithValue("@Role", user.Role);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewUsers.Rows[e.RowIndex];

                User user = new User
                {
                    UserId = Convert.ToInt32(selectedRow.Cells[0].Value),
                    Username = selectedRow.Cells[1].Value.ToString(),
                    PhoneNumber = selectedRow.Cells[2].Value.ToString(),
                    Role = selectedRow.Cells[3].Value.ToString(),
                    Password = selectedRow.Cells[4].Value.ToString()
                };

                PopulateFields(user);
            }
        }

        // Populate form fields with user data
        private void PopulateFields(User user)
        {
            txtUsername.Text = user.Username;
            txtPhoneNumber.Text = user.PhoneNumber;
            cboRole.Text = user.Role;
            txtPassword.Text = user.Password;
            selectedUserId = user.UserId;
        }

        // Update selected user
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Please select a user to update.");
                return;
            }

            User updatedUser = GetUserFromFields();
            updatedUser.UserId = selectedUserId;

            if (UpdateUser(updatedUser))
            {
                MessageBox.Show("User updated successfully!");
                LoadUserData();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Update failed. Please try again.");
            }
        }

        // Update user in the database
        private bool UpdateUser(User user)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE tbUsers SET Username = @Username, PhoneNumber = @PhoneNumber, Password = @Password, Role = @Role WHERE UserID = @UserID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", user.Username);
                    cmd.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Password", user.Password);
                    cmd.Parameters.AddWithValue("@Role", user.Role);
                    cmd.Parameters.AddWithValue("@UserID", user.UserId);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Delete selected user
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Please select a user to remove.");
                return;
            }

            if (DeleteUser(selectedUserId))
            {
                MessageBox.Show("User removed successfully!");
                LoadUserData();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Deletion failed. Please try again.");
            }
        }

        // Delete user from the database
        private bool DeleteUser(int userId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM tbUsers WHERE UserID = @UserID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userId);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Clear form fields and reset selectedUserId
        private void ClearFields()
        {
            txtUsername.Clear();
            txtPhoneNumber.Clear();
            txtPassword.Clear();
            cboRole.SelectedIndex = -1;
            selectedUserId = -1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Mart_Management_System
{
    public partial class frmCategories : Form
    {
        private readonly string connectionString = "Data Source=DESKTOP-6ULAPOO\\SQLEXPRESS;Initial Catalog=MartManagementSystem;Integrated Security=True;";
        private int selectedCategoryId = -1; 

        public frmCategories()
        {
            InitializeComponent();
        }

        private void frmCategories_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbCategories", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewCategories.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void AddCategory(Category category)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO tbCategories (category, date) VALUES (@category, @date)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@category", category.CategoryName);
                    cmd.Parameters.AddWithValue("@date", category.Date);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding category: " + ex.Message);
            }
        }

        private void UpdateCategory(Category category)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE tbCategories SET category = @category, date = @date WHERE id = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", category.Id);
                    cmd.Parameters.AddWithValue("@category", category.CategoryName);
                    cmd.Parameters.AddWithValue("@date", category.Date);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating category: " + ex.Message);
            }
        }

        private void RemoveCategory(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM tbCategories WHERE id = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing category: " + ex.Message);
            }
        }

        private void ClearFields()
        {
            txtCategory.Clear();
            selectedCategoryId = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category
            {
                CategoryName = txtCategory.Text,
                Date = DateTime.Now
            };
            AddCategory(category);
            ClearFields();
        }
        private void dataGridViewCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewCategories.Rows[e.RowIndex];
                txtCategory.Text = selectedRow.Cells[1].Value.ToString();
                selectedCategoryId = Convert.ToInt32(selectedRow.Cells[0].Value);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedCategoryId != -1)
            {
                Category category = new Category
                {
                    Id = selectedCategoryId,
                    CategoryName = txtCategory.Text,
                    Date = DateTime.Now
                };
                UpdateCategory(category);
                ClearFields();
            }
            else
            {
                MessageBox.Show("Please select a category to update.");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (selectedCategoryId != -1)
            {
                RemoveCategory(selectedCategoryId);
                ClearFields();
            }
            else
            {
                MessageBox.Show("Please select a category to remove.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

     

        private void frmCategories_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'martManagementSystemDataSet.tbCategories' table.
            this.tbCategoriesTableAdapter.Fill(this.martManagementSystemDataSet.tbCategories);
        }

       
    }
}

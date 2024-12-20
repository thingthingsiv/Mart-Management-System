using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Mart_Management_System
{
    public partial class frmProduct : Form
    {
        private string connectionString = "Data Source=DESKTOP-6ULAPOO\\SQLEXPRESS;Initial Catalog=MartManagementSystem;Integrated Security=True;";

        public frmProduct()
        {
            InitializeComponent();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadCategories();
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbProducts", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewProducts.DataSource = dt;
            }
        }

        private void LoadCategories()
        {
            cboCategory.Items.Clear(); 
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT category FROM tbCategories", conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    
                    string category = reader["category"].ToString();
                    cboCategory.Items.Add(category);
                }
                reader.Close();
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string imagePath = SaveImage();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO tbProducts (prod_id, prod_name, category, price, stock, image_path, status, date_insert) VALUES (@prod_id, @prod_name, @category, @price, @stock, @image_path, @status, @date_insert)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@prod_id", txtProdId.Text);
                cmd.Parameters.AddWithValue("@prod_name", txtProdName.Text);
                cmd.Parameters.AddWithValue("@category", cboCategory.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@price", float.Parse(txtPrice.Text));
                cmd.Parameters.AddWithValue("@stock", int.Parse(txtStock.Text));
                cmd.Parameters.AddWithValue("@image_path", imagePath);
                cmd.Parameters.AddWithValue("@status", cboStatus.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@date_insert", DateTime.Now);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            LoadData();
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewProducts.SelectedRows[0].Cells[0].Value);
                string imagePath = SaveImage();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE tbProducts SET prod_id = @prod_id, prod_name = @prod_name, category = @category, price = @price, stock = @stock, image_path = @image_path, status = @status WHERE id = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@prod_id", txtProdId.Text);
                    cmd.Parameters.AddWithValue("@prod_name", txtProdName.Text);
                    cmd.Parameters.AddWithValue("@category", cboCategory.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@price", float.Parse(txtPrice.Text));
                    cmd.Parameters.AddWithValue("@stock", int.Parse(txtStock.Text));
                    cmd.Parameters.AddWithValue("@image_path", imagePath);
                    cmd.Parameters.AddWithValue("@status", cboStatus.SelectedItem.ToString());

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                LoadData();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Please select a product to update.");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewProducts.SelectedRows[0].Cells[0].Value); 
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM tbProducts WHERE id = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                LoadData();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Please select a product to remove.");
            }
        }

        private string SaveImage()
        {
            if (!string.IsNullOrEmpty(pictureBox.ImageLocation))
            {
                try
                {
                    // Define the destination folder and create it if it doesn't exist
                    string imagesFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");
                    if (!Directory.Exists(imagesFolder))
                    {
                        Directory.CreateDirectory(imagesFolder);
                    }

                    string fileName = Path.GetFileName(pictureBox.ImageLocation);
                    string destinationPath = Path.Combine(imagesFolder, fileName);

                    File.Copy(pictureBox.ImageLocation, destinationPath, true);

                    return Path.Combine("Images", fileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving image: {ex.Message}");
                    return string.Empty;
                }
            }
            return string.Empty;
        }


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox.ImageLocation = ofd.FileName;
                }
            }
        }

        private void ClearFields()
        {
            txtProdId.Clear();
            txtProdName.Clear();
            cboCategory.SelectedIndex = -1;
            txtPrice.Clear();
            txtStock.Clear();
            cboStatus.SelectedIndex = -1;
            pictureBox.ImageLocation = null;
        }

        private void dataGridViewProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewProducts.Rows[e.RowIndex];
                txtProdId.Text = row.Cells[1].Value.ToString();
                txtProdName.Text = row.Cells[2].Value.ToString();
                cboCategory.SelectedItem = row.Cells[3].Value.ToString();
                txtPrice.Text = row.Cells[4].Value.ToString();
                txtStock.Text = row.Cells[5].Value.ToString();
                pictureBox.ImageLocation = row.Cells[6].Value.ToString();
                cboStatus.SelectedItem = row.Cells[7].Value.ToString() ;


            }
        }

        private void frmProduct_Load_1(object sender, EventArgs e)
        {
         
            this.tbCategoriesTableAdapter.Fill(this.martManagementSystemDataSet.tbCategories);
            this.tbProductsTableAdapter.Fill(this.martManagementSystemDataSet1.tbProducts);

        }

        private void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
    }
}

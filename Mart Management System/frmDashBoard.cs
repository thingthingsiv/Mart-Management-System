using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Mart_Management_System
{
    public partial class frmDashBoard : Form
    {
        private string connectionString = "Data Source=DESKTOP-6ULAPOO\\SQLEXPRESS;Initial Catalog=MartManagementSystem;Integrated Security=True;"; 

        public frmDashBoard()
        {
            InitializeComponent();
        }

        private void frmDashBoard_Load(object sender, EventArgs e)
        {
            
            this.tbOrdersTableAdapter.Fill(this.martManagementSystemDataSet2.tbOrders);

            // Load and display dashboard statistics
            DisplayTotalUsers();
            DisplayTotalOrder();
            DisplayTodayIncome();
            LoadOrderHistoryData();
        }

        private void DisplayTotalUsers()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM tbUsers";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    int totalUsers = (int)cmd.ExecuteScalar();

                    lblTotalUser.Text = $"Total Users: {totalUsers}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data: " + ex.Message);
            }
        }

        private void DisplayTotalOrder()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(DISTINCT order_id) FROM tbOrderHistory";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    int totalOrder = (int)cmd.ExecuteScalar();

                    lblOrder.Text = $"Total Order: {totalOrder}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data: " + ex.Message);
            }
        }

        private void DisplayTodayIncome()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT SUM(total_price) FROM tbOrderHistory WHERE CAST(order_date AS DATE) = CAST(GETDATE() AS DATE)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    object result = cmd.ExecuteScalar();

                    double todayIncome = result != DBNull.Value ? Convert.ToDouble(result) : 0;
                    lblTodayIncome.Text = $"Today's Income: ${todayIncome:F2}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data: " + ex.Message);
            }
        }
        private void LoadOrderHistoryData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbOrderHistory", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

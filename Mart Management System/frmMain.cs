using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mart_Management_System
{
    public partial class frmMain : Form
    {
        private Form currentChildForm;
        private string username;

        public frmMain(string username)
        {
            InitializeComponent();
            this.username = username;
            lblUser.Text = $" Welcome, {username}";
            

        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private string role;

        public frmMain(string username, string role)
        {
            InitializeComponent();
            this.username = username;
            this.role = role;

            lblUser.Text = $"Welcome, {username}";
            ConfigureUIBasedOnRole();
        }
        private void ConfigureUIBasedOnRole()
        {
            if (role == "Cashier")
            {
                btnDashboard.Enabled = false;
                btnCategories.Enabled = false;
                btnProduct.Enabled = false;
                btnUser.Enabled = false;

                btnOrder.Enabled = true; // Only Order button is enabled
            }
            else if (role == "Admin")
            {
                btnDashboard.Enabled = true;
                btnCategories.Enabled = true;
                btnProduct.Enabled = true;
                btnUser.Enabled = true;

                btnOrder.Enabled = true; // Admin can access everything
            }
        }


        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDashBoard());

        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCategories());
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmProduct());
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmOrder());
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmUser());
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}

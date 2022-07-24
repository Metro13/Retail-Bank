using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retail_Bank
{
    public partial class Admin : Form
    {
        Administrator admin = new Administrator();
        public Admin()
        {
            InitializeComponent();
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            string userid = TxtUsername.Text;
            string password = TxtPassword.Text;
            

            if(String.IsNullOrEmpty(userid) == false && String.IsNullOrEmpty(password) == false)
            {
                int queryResult = 1; // admin.AUthenticateAdmin(userid, password);
                if(queryResult > 0)
                {
                    //redirecting to dashboard
                   
                    AdminDashboard dashboard = new AdminDashboard();
                    dashboard.Show();

                    //hiding the current form
                    Hide();
                    return;
                }
                else
                {
                    MessageBox.Show("Incorrect username or password");
                    
                }
            }
            else
            {
                MessageBox.Show("Please enter your credentials");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

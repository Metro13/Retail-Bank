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
    public partial class Close_Account : UserControl
    {
        Administrator admin = new Administrator();
        public Close_Account()
        {
            InitializeComponent();
        }

        private void cmdCloseAccount_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TxtAccountName.Text) == false && string.IsNullOrEmpty(TxtAccountPin.Text) == false)
            {
                string accountname = TxtAccountName.Text;
                int accountpin = int.Parse(TxtAccountPin.Text);

                int result = admin.CloseAccount(accountname, accountpin);
                if(result > 0)
                {
                    MessageBox.Show("Account closed successfully");
                }
                else
                {
                    MessageBox.Show("Oppps ran into an err tryn again later");
                }
            }
            else
            {
                MessageBox.Show("Please enter the required details");
            }
        }
    }
}

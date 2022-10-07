using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Daraz_V_Convert.BL;
using Daraz_V_Convert.DL;
namespace Daraz_V_Convert.Forms
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            SellerDL.store_data();
            UserDL.store_data();
            if (checkBox1.Checked)
            {
                txtboxpass1.PasswordChar = '*';
                txtboxpass1.PasswordChar = '*';
            }
            else if (!checkBox1.Checked)
            {
                txtboxpass1.PasswordChar = '\0';
                txtboxpass1.PasswordChar = '\0';
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtboxpass1.PasswordChar = '*';
                txtboxpass2.PasswordChar = '*';
            }
            else if (!checkBox1.Checked)
            {
                txtboxpass1.PasswordChar = '\0';
                txtboxpass2.PasswordChar = '\0';
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(txtboxname.Text=="")
            {
                MessageBox.Show("Please add Username...");
            }
            else if(txtboxpass1.Text!=txtboxpass2.Text)
            {
                MessageBox.Show("Password does not match...");
            }
            else
            {
                User u = new User(txtboxname.Text, txtboxpass1.Text);
                UserDL.add_list(u);
                UserDL.store_data();
                Sign_In.user = u;
                this.Hide();
                UserMenu m = new UserMenu();
                m.Show();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Sign_In a = new Sign_In();
            this.Hide();
            a.Show();
        }
    }
}

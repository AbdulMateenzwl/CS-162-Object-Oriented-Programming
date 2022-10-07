using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Daraz_V_Convert.DL;
namespace Daraz_V_Convert.Forms
{
    public partial class UserChangepassword : Form
    {
        public UserChangepassword()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int chk = Sign_In.user.change_password(txtboxoldpass.Text, txtboxnewpass1.Text, txtboxnewpass2.Text);
            if (chk == 1)
            {
                MessageBox.Show("Wrong Password.");
                txtboxoldpass.Clear();
            }
            else if (chk == 2)
            {
                MessageBox.Show("New Password can not be the Old Password.");
            }
            else if (chk == 3)
            {
                MessageBox.Show("Password has been changed.");
                UserDL.store_data();
                this.Hide();
            }
            else if (chk == 4)
            {
                MessageBox.Show("New Passwords does not match.");
            }
            txtboxnewpass1.Clear();
            txtboxnewpass2.Clear();
            txtboxoldpass.Focus();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void UserChangepassword_Load(object sender, EventArgs e)
        {

        }
    }
}

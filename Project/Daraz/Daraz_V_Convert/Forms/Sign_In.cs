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
using Daraz_V_Convert.BL;
namespace Daraz_V_Convert.Forms
{
    public partial class Sign_In : Form
    {
        public static User user=new User();
        public static Seller seller = new Seller();
        public Sign_In()
        {
            InitializeComponent();
        }
        private void Sign_In_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            string name = txtboxname.Text;
            string pass = txtboxpass.Text;
            Admin chk = AdminDL.get_admin(name, pass);
            seller = SellerDL.get_seller(name, pass);
            user = UserDL.get_user(name, pass);
            if (chk != null)
            {
                AdminMenu a = new AdminMenu();
                this.Hide();
                a.Show();
            }
            else if (seller != null)
            {
                SellerMenu d = new SellerMenu();
                this.Hide();
                d.Show();
            }
            else if (user != null)
            {
                UserMenu u = new UserMenu();
                this.Hide();
                u.Show();
            }
            else
            {
                MessageBox.Show("There is no such User...");
                txtboxname.Clear();
                txtboxpass.Clear();
                txtboxname.Focus();
            }
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            SignUp a = new SignUp();
            this.Hide();
            a.Show();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtboxpass.PasswordChar = '*';
            }
            else if (!checkBox1.Checked)
            {
                txtboxpass.PasswordChar = '\0';
            }
        }
    }
}

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
    public partial class EditSeller : Form
    {
        Seller pre = new Seller();

        public Product Product { get; }

        public EditSeller(Seller s)
        {
            InitializeComponent();
            pre = s;
        }

        public EditSeller(Product product)
        {
            Product = product;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Seller nw = new Seller(txtboxname.Text, txtboxpass.Text, txtboxbuisness.Text, txtboxphone.Text);
            SellerDL.replace(pre, nw);
            AdminDL.Admin.add_history("You edited " + txtboxname.Text + " .");
            //save all to file
            //save
            SellerDL.store_data();
            UserDL.store_data();
            this.Hide();
            AdminGV a = new AdminGV();
            a.Show();
        }

        private void EditSeller_Load(object sender, EventArgs e)
        {
            if (pass_chk.Checked)
            {
                txtboxpass.PasswordChar = '*';
            }
            else if (!pass_chk.Checked)
            {
                txtboxpass.PasswordChar = '\0';
            }
            txtboxname.Text = pre.Name;
            txtboxpass.Text = pre.PhoneNum;
            txtboxbuisness.Text = pre.Buisness;
            txtboxphone.Text = pre.Password;
            txtboxname.Focus();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminGV a = new AdminGV();
            a.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (pass_chk.Checked)
            {
                txtboxpass.PasswordChar = '*';
            }
            else if (!pass_chk.Checked)
            {
                txtboxpass.PasswordChar = '\0';
            }
        }
    }
}

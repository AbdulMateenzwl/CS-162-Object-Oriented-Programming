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
    public partial class SellerAdd : Form
    {

        public SellerAdd()
        {
            InitializeComponent();
        }

        private void SellerAdd_Load(object sender, EventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Seller s = new Seller(txtboxname.Text, txtboxpass.Text, txtboxbuisness.Text, txtboxphonenum.Text);
            SellerDL.add_list(s);
            AdminDL.Admin.add_history("You added "+txtboxname.Text+" to "+txtboxbuisness.Text+" Buisness list.");
            SellerDL.store_data();
            //store to file
            //save file
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
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

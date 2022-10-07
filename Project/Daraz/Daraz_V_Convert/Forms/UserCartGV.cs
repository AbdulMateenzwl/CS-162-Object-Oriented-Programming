using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daraz_V_Convert.Forms
{
    public partial class UserCartGV : Form
    {
        public UserCartGV()
        {
            InitializeComponent();
        }

        private void UserCartGV_Load(object sender, EventArgs e)
        {
            dataBind();
        }
        public void dataBind()
        {
            dataGrid.DataSource = null;
            dataGrid.DataSource = Sign_In.user.get_product_list().Select(c=>new {c.Name,c.Prices}).ToList();
            dataGrid.Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Sign_In.user.Product.Count > 0)
            {
                if (Sign_In.user.Email == "")
                {
                    Userinfo a = new Userinfo();
                    a.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Products has been ordered...");
                }
            }
            else
            {
                MessageBox.Show("PLease Add some products to cart to buy them.");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserMenu a = new UserMenu();
            a.Show();
        }
    }
}

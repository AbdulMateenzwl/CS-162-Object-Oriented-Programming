using Daraz_V_Convert.BL;
using Daraz_V_Convert.DL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Daraz_V_Convert.Forms
{
    public partial class UserGV : Form
    {
        private string seller_name;

        public UserGV()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            seller_name = cmboxseller.Text;
            List<Product> p = SellerDL.get_products(seller_name);
            if (p != null)
            {
                dataBind(p);
            }
            else
            {
                dataGrid.DataSource = null;
                dataGrid.Refresh();
            }
        }

        public void dataBind(List<Product> p)
        {
            dataGrid.DataSource = null;
            dataGrid.DataSource = p;
            dataGrid.Refresh();
        }

        private void UserGV_Load(object sender, EventArgs e)
        {
            cmboxseller.DataSource = SellerDL.Seller;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int rowindex = dataGrid.CurrentCell.RowIndex;
            if (rowindex >= 0)
            {
                Seller s = SellerDL.get_seller(seller_name);
                if (s.decrement(s.Products[rowindex])) 
                {
                    Sign_In.user.add_product(seller_name, rowindex);
                    //store all data
                    //save file
                    SellerDL.store_data();
                    UserDL.store_data();
                    MessageBox.Show("Product has been added to the cart...");
                    dataGrid.Refresh();
                }
                else
                {
                    MessageBox.Show("Product is out of stock...");
                }
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
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
    public partial class EditProduct : Form
    {
        Product pre = new Product();
        public EditProduct(Product p)
        {
            InitializeComponent();
            pre = p;
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {
            txtboxname.Text= pre.Name;
            numprice.Value = pre.Prices;
            numquantity.Value = pre.Quantity;
            txtboxname.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Product nw = new Product(txtboxname.Text, (int)numprice.Value, (int)numquantity.Value);
            Sign_In.seller.replace_product(pre, nw);
            //save all to file
            //save
            SellerDL.store_data();
            UserDL.store_data();
            this.Hide();
            SellerGV d = new SellerGV();
            d.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            SellerGV d = new SellerGV();
            d.Show();
        }
    }
}

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
    public partial class ProductAdd : Form
    {
        public ProductAdd()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int a = (int)numprice.Value;
            Product p = new Product(txtboxname.Text, (int)numprice.Value , (int)numquantity.Value );
            Sign_In.seller.add_product(p);
            SellerDL.store_data();
            this.Hide();
        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {

        }
    }
}

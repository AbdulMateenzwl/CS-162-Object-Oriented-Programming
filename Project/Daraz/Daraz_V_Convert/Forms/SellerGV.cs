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
    public partial class SellerGV : Form
    {
        public SellerGV()
        {
            InitializeComponent();
        }

        private void SellerGV_Load(object sender, EventArgs e)
        {
            dataBind();
        }
        public void dataBind()
        {
            ProductGrid.DataSource = null;
            ProductGrid.DataSource = Sign_In.seller.get_product_list();
            ProductGrid.Refresh();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            SellerMenu a = new SellerMenu();
            a.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Sign_In.seller.Products.Count > 0)
            {
                int rowindex = ProductGrid.CurrentCell.RowIndex;
                EditProduct form = new EditProduct(Sign_In.seller.Products[rowindex]);
                this.Hide();
                form.Show();
                //store all data
                dataBind();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ProductAdd b= new ProductAdd();
            b.ShowDialog();
            SellerGV v = new SellerGV();
            this.Hide();
            v.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (Sign_In.seller.Products.Count > 0)
            {
                int rowindex = ProductGrid.CurrentCell.RowIndex;
                Sign_In.seller.delete_product(rowindex);
                //store all data
                //save file
                SellerDL.store_data();
                dataBind();
            }
        }
    }
}

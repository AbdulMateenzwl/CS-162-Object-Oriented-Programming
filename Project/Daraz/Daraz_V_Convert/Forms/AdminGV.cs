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
    public partial class AdminGV : Form
    {
        public AdminGV()
        {
            InitializeComponent();
        }

        private void AdminGV_Load(object sender, EventArgs e)
        {
            dataBind();
        }
        public void dataBind()
        {
            sellerGrid.DataSource = null;
            sellerGrid.DataSource = SellerDL.get_list();
            sellerGrid.Refresh();
        }


        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if(SellerDL.Seller.Count>0)
            {
                int rowindex = sellerGrid.CurrentCell.RowIndex;
                EditSeller form = new EditSeller(SellerDL.Seller[rowindex]);
                this.Hide();
                form.Show();
                //store all data
                dataBind();
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            SellerAdd a = new SellerAdd();
            a.ShowDialog();
            AdminGV adminGV=new AdminGV();
            this.Hide();
            adminGV.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if(SellerDL.Seller.Count>0)
            {
                int rowindex = sellerGrid.CurrentCell.RowIndex;
                AdminDL.Admin.add_history("You deleted " + SellerDL.Seller[rowindex].Name+" .");
                SellerDL.delete(rowindex);
                //store all data
                //save file
                dataBind();
                SellerDL.store_data();
                UserDL.store_data();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu a = new AdminMenu();
            a.Show();
        }

        private void sellerGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

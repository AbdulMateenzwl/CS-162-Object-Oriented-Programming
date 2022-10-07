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
    public partial class UserMenu : Form
    {
        public UserMenu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UserChangepassword n = new UserChangepassword();
            n.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserGV a = new UserGV();
            a.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sign_In a = new Sign_In();
            a.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            UserCartGV a = new UserCartGV();
            this.Hide();
            a.Show();
        }

        private void UserMenu_Load(object sender, EventArgs e)
        {

        }
    }
}

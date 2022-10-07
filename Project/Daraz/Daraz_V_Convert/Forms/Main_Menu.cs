using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Daraz_V_Convert.Forms;
namespace Daraz_V_Convert
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Sign_In open = new Sign_In();
            this.Hide();
            open.Show();
        }
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void Main_Menu_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Main_Menu_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void Main_Menu_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void Main_Menu_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}

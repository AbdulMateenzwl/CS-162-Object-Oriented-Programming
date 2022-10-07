using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password
{
    public partial class PassTest: UserControl
    {
        public PassTest()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text.Length<4)
            {
                lblchk.Text = "InValid";
            }
            else
            {
                lblchk.Text = "Valid";
            }
        }
    }
}

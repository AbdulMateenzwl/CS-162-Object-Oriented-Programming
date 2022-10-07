using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Challange1
{
    public partial class UserControl1: UserControl
    {
        private List<string> list = new List<string>();
        public List<string> List { get { return list; } set { list = value; } }
        public UserControl1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text=comboBox1.Text;
        }


        private void UserControl1_Load_1(object sender, EventArgs e)
        {
            comboBox1.DataSource = null;
            comboBox1.Refresh();
            list.Add("Mateen");
            list.Add("Saqib");
            list.Add("Khadim");
            comboBox1.DataSource = list;
        }
    }
}

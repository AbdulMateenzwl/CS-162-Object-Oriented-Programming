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
    public partial class AdminHistory : Form
    {
        public AdminHistory()
        {
            InitializeComponent();
        }

        private void AdminHistory_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < AdminDL.Admin.History.Count; i++)
            {
                txtboxhistory.AppendText(AdminDL.Admin.History[i]+Environment.NewLine);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu a = new AdminMenu();
            a.Show();
        }
    }
}

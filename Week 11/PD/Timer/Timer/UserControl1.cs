using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class CustomTimer: UserControl
    {
        private int count=100;
        public event EventHandler OnStop1;
        public int Count { get { return count; } set { count = value; } }
        public CustomTimer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count--;
            if(count>0)
            {
                label1.Text = count.ToString();
            }
            else if(count==0)
            {
                MessageBox.Show("Time Over!");
                OnStop1?.Invoke(this, EventArgs.Empty);
            }
        }

        private void CustomTimer_Load(object sender, EventArgs e)
        {
            timer1.Enabled=true;
        }
        /*public void OnStop()
        {
            MessageBox.Show("END");
        }*/
    }
}

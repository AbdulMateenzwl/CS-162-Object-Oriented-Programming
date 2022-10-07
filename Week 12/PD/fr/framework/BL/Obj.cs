using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace framework.BL
{
    public class Obj
    {
        private PictureBox obj;
        public EventHandler onAdd;

        public PictureBox OBJ { get { return obj; }set { obj = value; } }
        public Obj(Image a)
        {
            obj=new PictureBox();
            obj.Image = a;
            obj.BackColor = Color.Transparent;
            obj.Top = 0;
            obj.Left = 0;
            obj.Size = new Size(100, 100);
            onAdd?.Invoke(obj.Image, EventArgs.Empty);
        }
        public void moveright()
        {
            obj.Left += 20;
        }
        public void moveleft()
        {
            obj.Left -= 20;
        }
        public void moveup()
        {
            obj.Top -= 20;
        }
        public void movedown()
        {
            obj.Top += 20;
        }
    }
}

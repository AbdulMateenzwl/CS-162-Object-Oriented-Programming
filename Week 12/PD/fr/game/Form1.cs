using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using framework.BL;
namespace game
{
    public partial class Form1 : Form
    {
        Obj a = new Obj(game.Properties.Resources.enemyBlue2);
        bool dir;
        bool dir1;
        public Form1()
        {
            InitializeComponent();
            a.onAdd = new EventHandler(OnAdd);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Controls.Add(a.OBJ);
        }
        public void OnAdd(object sender, EventArgs e)
        {
            this.Controls.Add(sender as PictureBox);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Now the user can make any kind of changes and make any movement possible



            //for Vertical Movemnt code will be
            //a.movedown();




            //for Patrol
            /*if(dir)
            {
                if(a.OBJ.Right>this.Width)
                {
                    dir = false;
                }
                else
                {
                    a.moveright();

                }
            }
            else
            {
                if (a.OBJ.Left < 0)
                {
                    dir = true;
                }
                else
                {
                    a.moveleft();

                }
            }*/




            //for ZigZag Movement
            if (dir)
            {
                if (a.OBJ.Right > this.Width)
                {
                    dir = false;
                }
                else
                {
                    a.moveright();

                }
            }
            else
            {
                if (a.OBJ.Left < 0)
                {
                    dir = true;
                }
                else
                {
                    a.moveleft();

                }
            }
            if(dir1)
            {
                if(a.OBJ.Top<0)
                {
                    dir1 = false;
                }
                else
                {
                    a.moveup();

                }
            }
            else
            {
                if (a.OBJ.Bottom > Height)
                {
                    dir1 = true;
                }
                else
                {
                    a.movedown();
                }
            }



            /////////////////////////           You can Create any movemnt with basic functions like this 
            ///if there are still any doubts you can visit this project
            ///             https://github.com/ligeetah/C-Game.git
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POINT.UI;

namespace POINT.BL
{
    class GameObject
    {
        public char[,] shape;
        public point StartingPoint=new point();
        public Boundary Premises= new Boundary();
        public string Direction;
        public bool dir = true;
        public bool dir1 = false;
        public int count = 0;
        public void Erase()
        {
            Ui.erase_shape(shape,StartingPoint);
        }
        public void Draw()
        {
            Ui.draw_shap(shape,StartingPoint);
        }
        public void Move()
        {
            if (Direction == "LeftToRight")
            {
                move_right();
            }
            else if (Direction == "RightToLeft")
            {
                move_left();
            }
            else if (Direction == "Patrol")
            {
                if(dir)
                {
                    move_right();
                }
                else
                {
                    move_left();
                }
            }
            else if (Direction == "Diagonal")
            {
                if (dir)
                {
                    move_right();
                }
                else
                {
                    move_left();
                }
                if (dir1)
                {
                    move_up();
                }
                else
                {
                    move_down();
                }
            }
            else if (Direction == "Projectile")
            {
                if(count<5)
                {
                    move_up();
                    move_right();
                }
                if(count>=5 && count <= 7)
                {
                    move_right();
                }
                if(count > 7 && count <19)
                {
                    move_down();
                    move_right();
                }
                count++;
            }
            
        }
        public void move_right()
        {
            if (StartingPoint.getY() != 30)
            {
                StartingPoint.setY(StartingPoint.getY() + 1);
            }
            if(StartingPoint.getY()==30)
            {
                dir = false;
            }
        }
        public void move_left()
        {
            if (StartingPoint.getY() != 0)
            {
                StartingPoint.setY(StartingPoint.getY() - 1);
            }
            if (StartingPoint.getY() == 0)
            {
                dir = true;
            }
        }
        public void move_down()
        {
            if (StartingPoint.getX() != 30)
            {
                StartingPoint.setX(StartingPoint.getX() + 1);
            }
            if (StartingPoint.getX() == 30)
            {
                dir1 = true;
            }
        }
        public void move_up()
        {
            if (StartingPoint.getX() != 0)
            {
                StartingPoint.setX(StartingPoint.getX() - 1);
            }
            if (StartingPoint.getX() == 0)
            {
                dir1 = false;
            }
        }
        public GameObject()
        {
            shape = new char[2, 3] { {'-', '|','-' },{'-','-','-' } };
            StartingPoint = new point(0,0);
            Direction = "Diagonal";
        }
        public GameObject(char[,] shape, point StartingPoint, Boundary Premises, string Direction)
        {
            this.shape = shape;
            this.StartingPoint = StartingPoint;
            this.Premises = Premises;
            this.Direction = Direction;
        }
        public GameObject(char[,] shape, point StartingPoint)
        {
            this.shape = shape;
            this.StartingPoint = StartingPoint;
            Boundary premises = new Boundary();
            Premises = premises;
            Direction = "LeftToRight";
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.BL;
using ConsoleApp1.DL;
using ConsoleApp1.UI;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char op;
            while(true)
            {
                op = Menu_Ui.menu();
                Console.Clear();
                if(op =='1')
                {
                    Ship output = Ship_Ui.take_input();
                    Crud.add_ship(output);
                }
                else if(op =='2')
                {
                    Ship_Ui.position();
                }
                else if(op=='3')
                {
                    Ship_Ui.serial_num();
                }
                else if(op=='4')
                {
                    Ship_Ui.change_position();
                }
                else if(op=='5')
                {
                    break;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks.BL;
using Tasks.UI;
using Tasks.DL;
namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            { 
                char op = Menu_Ui.menu();
                if(op =='1')
                {
                    Crud.get_line().set_start(Ui.get_point());
                    Crud.get_line().set_end(Ui.get_point());
                }
                else if(op =='2')
                {
                    Crud.get_line().set_start(Ui.get_point());
                }
                else if(op =='3')
                {
                    Crud.get_line().set_end(Ui.get_point());
                }
                else if(op=='4')
                {
                    Ui.display_point(Crud.get_line().get_start());
                }
                else if (op == '5')
                {
                    Ui.display_point(Crud.get_line().get_end());
                }
                else if(op=='6')
                {
                    Ui.display_length();
                }
                else if (op == '7')
                {
                    Ui.display_gradiant();
                }
                else if (op == '8')
                {
                    Ui.distace_start_from_zero();
                }
                else if (op == '9')
                {
                    Ui.distance_end_from_zero();
                }
                else if(op=='0')
                {
                    break;
                }
                Menu_Ui.confirm_option();
            }
        }
        
        
        
    }
}

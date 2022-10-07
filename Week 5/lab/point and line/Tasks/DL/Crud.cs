using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks.BL;
using System.IO;
using Tasks.UI;
namespace Tasks.DL
{
    internal class Crud
    {
        private static line we = new line();
        public static line get_line()
        {
            return we;
        }
    }
}

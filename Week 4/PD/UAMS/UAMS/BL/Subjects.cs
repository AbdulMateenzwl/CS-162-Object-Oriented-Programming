using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS.BL
{
    internal class Subjects
    {
        public string code;
        public int credit_hours;
        public string type;
        public int fee;
        public Subjects() { }
        public Subjects(string code,int credit_hours,string type,int fee)
        {
            this.code = code;
            this.credit_hours = credit_hours;
            this.type = type;
            this.fee = fee;
        }
    }
}

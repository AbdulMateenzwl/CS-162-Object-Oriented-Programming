using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS.BL
{
    internal class Programs
    {
        public string title;
        public float duration;
        public float merit;
        public int seats;
        public List <Subjects> subjects=new List<Subjects>();
        public int cal_credithours()
        {
            int count = 0;
            for (int i = 0; i < subjects.Count; i++)
            {
                count = count + subjects[i].credit_hours;
            }
            return count;
        }
        public bool Add_subject(Subjects s)
        {
            if(cal_credithours() + s.credit_hours <= 20)
            {
                subjects.Add(s);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool isSubject_exists(Subjects s)
        {
            foreach (Subjects subjects in subjects)
            {
                if(s.code == subjects.code)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

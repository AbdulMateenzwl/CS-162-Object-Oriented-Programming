using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks.jk
{
    internal class test
    {
        public int hr;
        public int min;
        public int sec;
        public test()
        {
            hr = 0;
            min = 0;
            sec = 0;
        }
        public test(int h)
        {
            hr = h;
        }
        public test(int h,int m)
        {
            hr = h;
            min = m;
        }
        public test(int h,int m,int s)
        {
            hr = h;
            min = m;
            sec = s;
        }
        public void increment_sec()
        {
            sec++;
        }
        public void increment_min()
        {
            min++;
        }
        public void increment_hours()
        {
            hr++;
        }
        public void print_time()
        {
            Console.WriteLine(hr+" : "+min+" : "+sec);
        }
        public bool is_equal(int h,int m,int s)
        {
            if(hr==h &&min==m&&sec==s)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool is_equal(test ch)
        {
            if (hr == ch.hr && min == ch.min && sec == ch.sec)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void in_sec()
        {
            int secs = hr * 3600 + min * 60 + sec;
            Console.WriteLine("Time in Sec : " + secs);
        }
        public void rem_in_sec()
        {
            int secs = 86400-( hr * 3600 + min * 60 + sec);
            Console.WriteLine("Time Left in Sec : " + secs);
        }
        public void distance(test c1,test c2)
        {
            int c1_sec = c1.hr * 3600 + c1.min * 60 + c1.sec;
            int c2_sec = c2.hr * 3600 + c2.min * 60 + c2.sec;
            int dif=Math.Abs(c1_sec - c2_sec);
            int h, m, s;
            h = dif / 3600;
            m = dif / 60;
            s = dif % 60;
            Console.WriteLine("Time Difference > "+h+" "+m+" "+s);
        }
    }
}

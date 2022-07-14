using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Advanced
{
    internal class Generices
    {
        public void run()
        {
            List<string> list = new List<string>();
            list.Add("123456");
            List<int> list2 = new List<int>();
            list2.Add(2);
            var p = new Point(100, 300);
            string s = func(p, "this is point");
            Sample<Point> sample = new Sample<Point>();
            sample.setItem(new Point(100, 100));

        }
     
        public class Sample<T>
        {

            public void setItem(T item)
            {

            }
        }
        public class printmanger<T>
        {

        }


        public string func<T,Z>(T o,Z y)
        {

            string s = o.ToString() + ""+ y.ToString();
            return s;
        }
    }
}

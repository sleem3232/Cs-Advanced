using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Advanced
{
    //we can pass by ref to func and copy the pointer in the stack
    //it's copy the pointer in stack
    internal class RefVal
    {
        public void run()
        {
            label l = new label();

            int   [] arr = new int[100];
            l.text = "456";
            ChangeLabel(l);
            int a = 10;
            change(ref a);
        }
        public int ChangeLabel(label L)
        {
            L.text = "123";
            return 10;
        }
        public  int change  (ref int a)
        {
            a++;
            return a *a;
        }
    }
}

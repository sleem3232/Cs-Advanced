using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Advanced
{
    // Delegate= signature of function
    public class Delegate
    {
        public delegate int CalcFunc(int a, int b);
        public void run()
        {
            CalcFunc a;
            CalcFunc b;
            CalcFunc c;
            a = calc1;
            b = calc2;
            c = calc3;
            int d = a(5, 5);
            int E = b(5, 5);
            int F = c(5, 5);
            tax(200, calc1);
            tax(200, calc2);
            tax(200, calc3);


        }
        public int tax(int price,CalcFunc func)
        {
            return (func(price, 20));
        }
        public int calc1(int a,int b)
        { return a + b; }
        public int calc2(int a, int b)
        { return a * b; }
        public int calc3(int a, int b)
        { return a - b; }
    }
}

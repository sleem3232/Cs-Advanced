using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Advanced
    //if we get obj in runtime and we don't know wich type is we can us "as-is"
    //is =is return bool
    //as=refernce  type

{
    class aa { }
    class bb { }
    class cc : aa { }
    internal class is_as
    {
        public void run()
        {
            aa a = new aa();
            bb b = new bb();
            cc c = new cc();
        }
        public void Operate(object o)
        {
            bool test = o is aa;  //true
            test =o is bb; //false
            test =o is cc; //true
            test = o is object; //true
            test = o is System.IO.FileStream; //false
            if (o is cc)
            {
                cc c = o as cc;
                c = (cc)o;
                
            }
        }

    }
}

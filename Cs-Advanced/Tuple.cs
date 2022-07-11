using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Advanced
{
    public class Tuple
    {
        //Tuple =Collection of variables
        public void run()
        {
         
            (int id, string fname, string lname) var1;
            var1 = (123, "salim", "sheene");
            Console.WriteLine(var1);
            var newperson=creatperson();
            Console.WriteLine(var1);


        }
        public (int id, string fname ,string lname) creatperson()
        {
            (int id, string fname, string lname) var1=(123,"salim","sheene");
            return var1;
        }
    }
}

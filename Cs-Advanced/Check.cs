using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Advanced
{
    //check if the value have overflow ex

    internal class Check
    {
        public void run()
        {
            try
            {
                checked
                {
                    byte a = 1;
                    a = byte.MaxValue - 2;
                    a++;
                    a++;
                    a++;
                    unchecked
                    {
                        a++;
                    }
                    a++;
                 
                    a = byte.MaxValue - 2;
                    a++;

                }
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            byte c = 1;
            for(int i = 0; i <int.MaxValue; i++)
            {
                c++;
            }    
        }
    }
}

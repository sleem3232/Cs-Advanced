using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Advanced

    //ex=can access to static method but in the static method must use "this"
{
    public class Utilites
    {
        public static int Doscounter(string str)
        {
            return str.Split('.').Count() - 1;
        }
    }
    //static= can't do new for new object 
    //and all the func must to be static
    public static class ExStringMethod
    {
           public static int Doscounter( this string str)
        {
            return str.Split('.').Count() - 1;
        }
    }
   /* public class Mystring : String
    {
        public  int Doscounter(string str)
        {
            return str.Split('.').Count() - 1;
        }

    }*/
    internal class ExtensionMethod 
    {
        public void run()
        { 
             string s = "abcdef.gh.i";
             int a=   s.Doscounter();
             a=Utilites.Doscounter(s);
            Car car = new Car();



        }
        public int Doscounter(string str)
        {
            return str.Split('.').Count()-1;

        }
      /*  public static bool HasMObile(this Car car)
        {
            if (car.GetPrice() > 9000)
            {
                return true;

            }
            else
            {
                return false;
            }
        }*/

    }
   
   public class Car
    {
        public int GetPrice()
        {
            return 100000;
        }
    }
}

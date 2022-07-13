using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Advanced
{
    //class without use function
    // when using interface have to used 
    //התחיבות לממימוש
    public interface Itax
    {
        int Maam(int price);
        int IncouminTax(int price); 

    }
    public class Eilat : Itax
    {
        public int IncouminTax(int price)
        {
            return 0;
        }

        public int Maam(int price)
        {
            return 0;
        }
    }
    public class Reqular : Itax
    {
        public int IncouminTax(int price)
        {
            return price * 2;
        }

        public int Maam(int price)
        {
            return price *2;
        }
    }
    public class ineterfacesample
    {
        public void run()
        {
            Itax [] arr = new Itax[10]; 
            arr[0] = new Reqular();
            arr[0] = new Eilat();
            arr[0].Maam(10);
            arr[0].IncouminTax(10);

        }
    }
}

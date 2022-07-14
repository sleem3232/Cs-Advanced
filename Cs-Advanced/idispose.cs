using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Advanced
{
    //relase resources =שחרור משאבים
    // make IDisposable using interface to gave to realease the memory
    //or can use the using so it have to use the free memory    
    //if write class have to dispose the memory use IDisposable 
    
    internal class idispose
    {
        class makeBigReq :IDisposable
        {
            public void Dispose()
            {
                Relase();
            }

            public void Operate()
            {
               
            }
            public void Relase()
            {

            }
        }
        public void run()
        {
            makeBigReq makeBigReq = new makeBigReq();
            makeBigReq.Relase();
            makeBigReq.Dispose();
            using (makeBigReq makeBigReq1 = new makeBigReq())
            {
                makeBigReq1.Dispose();
            }

        }
    }
}

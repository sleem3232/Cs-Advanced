using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Advanced
{
    internal class Event
    {
        public delegate void TimeOut(int time);
        public event TimeOut TimeOut_hundler;
        public void run()
        {
            if(TimeOut_hundler != null)
            TimeOut_hundler(2000);
        }
    }

    public class opeate
    {
        Event event_a = new Event();
        DB db = new DB();
        UI ui = new UI();
        public void Init() 
        {
           event_a.TimeOut_hundler += db.UPDATEDbAfterTime;
            event_a.TimeOut_hundler += ui.UpdateUi;
           event_a.run();
        }
    }
    public class DB
    {
      public  void UPDATEDbAfterTime(int time)
        {

        }
    }
    public class UI
    {
     public   void UpdateUi(int time)
        {

        }
    }
}

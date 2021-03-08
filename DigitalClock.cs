using System;
namespace classPro{
    class DigitalClock{
    public void Register(Clock c){
          c.OnsecondChange += new Clock.SecondHandle(ShowDC);
    }
    public void ShowDC(object o,TimeEventArgs e){
        DateTime d = DateTime.Now;
        Console.WriteLine("DC : {0}:{1}:{2}:{3}",e.timer.Hour,e.timer.Minute,e.timer.Second,e.timer.Millisecond);
    }
    }
}
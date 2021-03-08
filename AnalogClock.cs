using System;

namespace classPro{
    public class AnalogClock{
        public void Register(Clock c){
            c.OnsecondChange += new Clock.SecondHandle(ShowAC);
        }
        public void ShowAC(object o,TimeEventArgs e){
            DateTime d = DateTime.Now;
            Console.WriteLine("AC : {0}:{1}:{2}:{3}",e.timer.Hour,e.timer.Minute,e.timer.Second,e.timer.Millisecond);

        }
    }
}
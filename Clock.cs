using System;
using System.Threading;
namespace classPro{
    public class Clock{
        public delegate void SecondHandle(object o,TimeEventArgs e);
        public event SecondHandle OnsecondChange;
        public void Run(){
            while(true){
                Thread.Sleep(1000);
                if(OnsecondChange !=null){
                    
                OnsecondChange(this,new TimeEventArgs(DateTime.Now));
                // Hiii Hai Quy
                }

            }
        }
    }
}
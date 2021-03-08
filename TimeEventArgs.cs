using System;
namespace classPro{
    public class TimeEventArgs : EventArgs{
        public DateTime timer{get;set;}
        public TimeEventArgs(DateTime d){
            timer = d;
        }
    }

}
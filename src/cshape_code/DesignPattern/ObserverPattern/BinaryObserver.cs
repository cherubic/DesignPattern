using System;
namespace DesignPattern.ObserverPattern
{
    public class BinaryObserver : Observer
    {
        public BinaryObserver(Subject subject)
        {
            this.Subject = subject;
            this.Subject.Attach(this);
        }

        public override void Update(){
            Console.WriteLine("Binary String: "
                              + Subject.GetState());
        }
    }
}

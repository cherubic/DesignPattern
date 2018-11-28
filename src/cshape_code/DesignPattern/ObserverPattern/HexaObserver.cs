using System;
namespace DesignPattern.ObserverPattern
{
    public class HexaObserver : Observer
    {
        public HexaObserver(Subject subject)
        {
            this.Subject = subject;
            this.Subject.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine("Hex String: "
                              + Subject.GetState());
        }
    }
}

using System;
namespace DesignPattern.ObserverPattern
{
    public class OctalObserver : Observer
    {
        public OctalObserver(Subject subject)
        {
            this.Subject = subject;
            this.Subject.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine("Octal String: " + Subject.GetState());
        }
    }
}

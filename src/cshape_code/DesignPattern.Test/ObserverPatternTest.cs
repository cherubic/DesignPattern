using NUnit.Framework;
using System;
using DesignPattern.ObserverPattern;
namespace DesignPattern.Test
{
    [TestFixture()]
    public class ObserverPatternTest
    {
        [Test()]
        public void ObserverPatternDemo()
        {
            Subject subject = new Subject();

            Observer observer = new HexaObserver(subject);
            observer = new OctalObserver(subject);
            observer = new BinaryObserver(subject);

            Console.WriteLine("First state change: 15");
            subject.SetState(15);
            Console.WriteLine("Second state change: 10");
            subject.SetState(10);
        }
    }
}

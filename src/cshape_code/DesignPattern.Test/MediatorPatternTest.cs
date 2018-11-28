using NUnit.Framework;
using System;
using DesignPattern.MediatorPattern;
namespace DesignPattern.Test
{
    [TestFixture()]
    public class MediatorPatternTest
    {
        [Test()]
        public void MediatorPatternDemo()
        {
            User robert = new User("Robert");
            User john = new User("John");

            robert.SendMessage("Hi! John!");
            john.SendMessage("Hello! Robert!");
        }
    }
}

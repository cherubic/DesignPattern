using NUnit.Framework;
using System;
using DesignPattern.IteratorPattern;

namespace DesignPattern.Test
{
    [TestFixture()]
    public class IteratorPatternTest
    {
        [Test()]
        public void TestCase()
        {
            NameRepository namesRepository = new NameRepository();

            for (Iterator iter = namesRepository.GetIterator(); iter.HasNext();)
            {
                String name = (String)iter.Next();
                Console.WriteLine("Name : " + name);
            }
        }
    }
}

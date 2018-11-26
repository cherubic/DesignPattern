using NUnit.Framework;
using System;
using DesignPattern.ProxyPattern;
namespace DesignPattern.Test
{
    [TestFixture()]
    public class ProxyPatternTest
    {
        [Test()]
        public void ProxyPatternDemo()
        {
            Image image = new ProxyImage("test_10mb.jpg");

            // 图像将从磁盘加载
            image.Display();
            Console.WriteLine("");
            // 图像不需要从磁盘加载
            image.Display();
        }
    }
}

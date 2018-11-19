using System;
using NUnit.Framework;
using DesignPattern.SingletonPattern;
using System.Threading;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;

namespace DesignPattern.Test
{
    [TestFixture()]
    public class SingletonPatternTest
    {
        [Test()]
        public void SingletonLazyLoadTest()
        {
            var aCount = SingletonObjectA.count;
            var bCount = SingletonObjectB.count;
            var cCount = SingletonObjectC.count;
            var dCount = SingletonObjectD.count;
            var eCount = SingletonObjectE.count;

            SingletonObjectA.GetSingletonObjectA();
            SingletonObjectB.GetSingletonObjectB();
            SingletonObjectC.GetSingletonObjectC();
            SingletonObjectD.GetSingletonObjectD();
            SingletonObjectE.GetSingletonObjectE();

            aCount = SingletonObjectA.count;
            bCount = SingletonObjectB.count;
            cCount = SingletonObjectC.count;
            dCount = SingletonObjectD.count;
            eCount = SingletonObjectE.count;

            Assert.IsTrue(true);
        }

        [Test()]
        public void SingletonUseTimeTest()
        {
            var count = 10000000;

            var watchA = Stopwatch.StartNew();
            for (var i = 0; i < count; i++)
            {
                SingletonObjectA.GetSingletonObjectA();
            }
            watchA.Stop();
            var elapsedMsA = watchA.ElapsedMilliseconds;

            var watchB = Stopwatch.StartNew();
            for (var i = 0; i < count; i++)
            {
                SingletonObjectB.GetSingletonObjectB();
            }
            watchB.Stop();
            var elapsedMsB = watchB.ElapsedMilliseconds;

            var watchC = Stopwatch.StartNew();
            for (var i = 0; i < count; i++)
            {
                SingletonObjectC.GetSingletonObjectC();
            }
            watchC.Stop();
            var elapsedMsC = watchC.ElapsedMilliseconds;

            var watchD = Stopwatch.StartNew();
            for (var i = 0; i < count; i++)
            {
                SingletonObjectD.GetSingletonObjectD();
            }
            watchD.Stop();
            var elapsedMsD = watchD.ElapsedMilliseconds;

            var watchE = Stopwatch.StartNew();
            for (var i = 0; i < count; i++)
            {
                SingletonObjectE.GetSingletonObjectE();
            }
            watchE.Stop();
            var elapsedMsE = watchE.ElapsedMilliseconds;

            Assert.IsTrue(true);
        }

        [Test()]
        public void SingletonThreadSafeTest()
        {
            var threadCount = 1000;

            List<SingletonObjectA> aList = new List<SingletonObjectA>();
            for (var i = 0; i < threadCount;i++){
                new Thread(() => { aList.Add(SingletonObjectA.GetSingletonObjectA()); }).Start();
            }

            List<SingletonObjectB> bList = new List<SingletonObjectB>();
            for (var i = 0; i < threadCount; i++)
            {
                new Thread(() => { bList.Add(SingletonObjectB.GetSingletonObjectB()); }).Start();
            }

            List<SingletonObjectC> cList = new List<SingletonObjectC>();
            for (var i = 0; i < threadCount; i++)
            {
                new Thread(() => { cList.Add(SingletonObjectC.GetSingletonObjectC()); }).Start();
            }

            List<SingletonObjectD> dList = new List<SingletonObjectD>();
            for (var i = 0; i < threadCount; i++)
            {
                new Thread(() => { dList.Add(SingletonObjectD.GetSingletonObjectD()); }).Start();
            }

            List<SingletonObjectE> eList = new List<SingletonObjectE>();
            for (var i = 0; i < threadCount; i++)
            {
                new Thread(() => { eList.Add(SingletonObjectE.GetSingletonObjectE()); }).Start();
            }

            var aCount = SingletonObjectA.count;
            var bCount = SingletonObjectB.count;
            var cCount = SingletonObjectC.count;
            var dCount = SingletonObjectD.count;
            var eCount = SingletonObjectE.count;
        }
    }
}

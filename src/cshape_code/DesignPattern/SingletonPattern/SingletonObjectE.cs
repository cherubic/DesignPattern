using System;
using System.Threading;
namespace DesignPattern.SingletonPattern
{
    /// <summary>
    /// Singleton object e.
    /// Lazy: true
    /// Thread safe: true
    /// </summary>
    public class SingletonObjectE
    {
        public static int count;

        private SingletonObjectE()
        {
            Interlocked.Increment(ref count);
        }

        private static class SingletonObjectHolder
        {
            public static SingletonObjectE singletonObjectE = new SingletonObjectE();
        }

        public static SingletonObjectE GetSingletonObjectE()
        {
            return SingletonObjectHolder.singletonObjectE;
        }

        public void ShowMessage()
        {
            Console.WriteLine("Singleton Object B");
        }
    }
}

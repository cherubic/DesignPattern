using System;
using System.Threading;
namespace DesignPattern.SingletonPattern
{
    /// <summary>
    /// Lazy: true
    /// Thread safe: false
    /// </summary>
    public class SingletonObjectB
    {
        public static int count = 0;

        private static SingletonObjectB singletonObjectB;

        private SingletonObjectB()
        {
            Interlocked.Increment(ref count);
        }

        public static SingletonObjectB GetSingletonObjectB()
        {
            if (singletonObjectB == null)
            {
                singletonObjectB = new SingletonObjectB();
            }

            return singletonObjectB;
        }

        public void ShowMessage()
        {
            Console.WriteLine("Singleton Object B");
        }
    }
}

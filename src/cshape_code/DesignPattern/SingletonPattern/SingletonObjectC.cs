using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace DesignPattern.SingletonPattern
{
    /// <summary>
    /// Singleton object c.
    /// Lazy: true
    /// Thread safe: true
    /// </summary>
    public class SingletonObjectC
    {
        public static int count = 0;
        private static SingletonObjectC singletonObjectC;

        private SingletonObjectC()
        {
            Interlocked.Increment(ref count);
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static SingletonObjectC GetSingletonObjectC()
        {
            if (singletonObjectC == null)
            {
                singletonObjectC = new SingletonObjectC();
            }

            return singletonObjectC;
        }

        public void ShowMessage()
        {
            Console.WriteLine("Singleton Object B");
        }
    }
}

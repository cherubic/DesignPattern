using System;
using System.Threading;
namespace DesignPattern.SingletonPattern
{
    /// <summary>
    /// Singleton object d.
    /// Lazy: true
    /// Thread safe: true
    /// </summary>
    public class SingletonObjectD
    {
        public static int count;

        private static volatile SingletonObjectD singletonObjectD;
        private readonly static object synclock = new object();

        private SingletonObjectD()
        {
            Interlocked.Increment(ref count);
        }

        public static SingletonObjectD GetSingletonObjectD()
        {
            if (singletonObjectD == null)
            {
                lock (synclock)
                {
                    if (singletonObjectD == null)
                    {
                        singletonObjectD = new SingletonObjectD();
                    }
                }
            }

            return singletonObjectD;
        }

        public void ShowMessage()
        {
            Console.WriteLine("Singleton Object B");
        }
    }
}

using System;
using System.Threading;
namespace DesignPattern.SingletonPattern
{
    /// <summary>
    /// Singleton object a.
    /// Lazy: false
    /// Thread safe: true
    /// </summary>
    public class SingletonObjectA
    {
        public static int count = 0;

        private static SingletonObjectA singletonObjcetA = new SingletonObjectA();

        private SingletonObjectA()
        {
            Interlocked.Increment(ref count);
        }

        public static SingletonObjectA GetSingletonObjectA()
        {
            return singletonObjcetA;
        }

        public void ShowMessage()
        {
            Console.WriteLine("Singleton Objcet A");
        }
    }
}

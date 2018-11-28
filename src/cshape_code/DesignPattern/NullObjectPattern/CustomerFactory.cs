using System;
namespace DesignPattern.NullObjectPattern
{
    public class CustomerFactory
    {
        public static string[] names = { "Rob", "Joe", "Julie" };

        public static AbstractCustomer GetCustomer(string name)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].ToLower() == name.ToLower())
                {
                    return new RealCustomer(name);
                }
            }

            return new NullCustomer();
        }
    }
}

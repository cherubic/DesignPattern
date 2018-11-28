using System;
namespace DesignPattern.NullObjectPattern
{
    public class RealCustomer : AbstractCustomer
    {
        public RealCustomer(string name)
        {
            this.name = name;
        }

        public override string GetName()
        {
            return this.name;
        }

        public override bool IsNil()
        {
            return false;
        }
    }
}

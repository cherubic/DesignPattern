using System;
namespace DesignPattern.NullObjectPattern
{
    public abstract class AbstractCustomer
    {
        protected string name;
        public abstract bool IsNil();
        public abstract string GetName();
    }
}

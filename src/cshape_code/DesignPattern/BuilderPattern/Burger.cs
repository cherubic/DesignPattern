using System;
namespace DesignPattern.BuilderPattern
{
    public class Burger : Item
    {
        public virtual string Name()
        {
            throw new NotImplementedException();
        }

        public Packing Packing()
        {
            return new Wrapper();
        }

        public virtual float Price()
        {
            throw new NotImplementedException();
        }
    }
}

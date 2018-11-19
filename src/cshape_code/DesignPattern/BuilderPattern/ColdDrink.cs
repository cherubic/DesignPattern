using System;
namespace DesignPattern.BuilderPattern
{
    public class ColdDrink : Item
    {
        public virtual string Name()
        {
            throw new NotImplementedException();
        }

        public Packing Packing(){
            return new Bottle();
        }

        public virtual float Price()
        {
            throw new NotImplementedException();
        }
    }
}

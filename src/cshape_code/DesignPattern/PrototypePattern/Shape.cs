using System;
namespace DesignPattern.PrototypePattern
{
    public abstract class Shape : ICloneable
    {
        protected string type;

        public string Id { get; set; }

        public string Gettype()
        {
            return type;
        }

        public abstract void Draw();

        public object Clone()
        {
            Object clone = null;
            try
            {
                clone = base.MemberwiseClone();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return clone;
        }
    }
}

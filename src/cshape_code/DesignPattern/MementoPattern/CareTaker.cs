using System;
using System.Collections.Generic;
namespace DesignPattern.MementoPattern
{
    public class CareTaker
    {
        private List<Memento> mementos = new List<Memento>();

        public CareTaker()
        {
        }

        public void Add(Memento memento)
        {
            mementos.Add(memento);
        }

        public Memento Get(int index)
        {
            return mementos[index];
        }
    }
}

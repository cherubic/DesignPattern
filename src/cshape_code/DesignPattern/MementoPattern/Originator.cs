using System;
namespace DesignPattern.MementoPattern
{
    public class Originator
    {
        private string state;

        public Originator()
        {
        }

        public void SetState(string state)
        {
            this.state = state;
        }

        public string GetState()
        {
            return this.state;
        }

        public Memento SaveStateToMemento()
        {
            return new Memento(this.state);
        }

        public string GetStateFromMemento(Memento memento)
        {
            return memento.GetState();
        }
    }
}

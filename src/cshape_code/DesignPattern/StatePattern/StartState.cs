using System;
namespace DesignPattern.StatePattern
{
    public class StartState : State
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("Player is in start state");
            context.SetState(this);
        }

        public override string ToString()
        {
            return "Start State";
        }
    }
}

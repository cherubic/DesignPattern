using System;
namespace DesignPattern.StatePattern
{
    public class StopState : State
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("Stop State");
            context.SetState(this);
        }

        public override string ToString()
        {
            return "Stop State";
        }
    }
}

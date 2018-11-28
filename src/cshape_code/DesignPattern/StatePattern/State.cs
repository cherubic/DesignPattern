using System;
namespace DesignPattern.StatePattern
{
    public interface State
    {
        void DoAction(Context context);
    }
}

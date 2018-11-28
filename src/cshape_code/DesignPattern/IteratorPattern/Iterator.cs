using System;
namespace DesignPattern.IteratorPattern
{
    public interface Iterator
    {
        bool HasNext();
        object Next();
    }
}

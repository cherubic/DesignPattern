using System;
namespace DesignPattern.BuilderPattern
{
    public interface Item
    {
        string Name();
        Packing Packing();
        float Price();
    }
}

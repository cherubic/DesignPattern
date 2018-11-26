using System;
namespace DesignPattern.Bridge
{
    public class GreenCircle : IDrawAPI
    {
        public GreenCircle()
        {
        }

        public void DrawCircle(int radius, int x, int y)
        {
            Console.WriteLine("Drawing Circle[ color: green, radius: "
                              + radius + ", x: " + x + ", " + y + "]");
        }
    }
}

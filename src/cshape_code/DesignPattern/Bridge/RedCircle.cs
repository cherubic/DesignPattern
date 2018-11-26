using System;
namespace DesignPattern.Bridge
{
    public class RedCircle : IDrawAPI
    {
        public RedCircle()
        {
        }

        public void DrawCircle(int radius, int x, int y)
        {
            Console.WriteLine("Drawing Circle[ color: red, radius: "
                              + radius + ", x: " + x + ", " + y + "]");
        }
    }
}

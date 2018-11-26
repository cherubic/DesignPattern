using System;
namespace DesignPattern.FlyweightPattern
{
    public class Circle : Shape
    {
        private string color;
        private int x;
        private int y;
        private int radius;

        public Circle(string color)
        {
            this.color = color;
        }

        public void SetX(int x)
        {
            this.x = x;
        }

        public void SetY(int y)
        {
            this.y = y;
        }

        public void SetRadius(int radius)
        {
            this.radius = radius;
        }

        public void Draw()
        {
            Console.WriteLine("Circle: Draw() [Color : " + color
                              + ", x : " + x + ", y :" + y + ", radius :" + radius);
        }
    }
}

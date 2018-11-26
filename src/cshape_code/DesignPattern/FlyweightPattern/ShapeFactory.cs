using System;
using System.Collections.Generic;

namespace DesignPattern.FlyweightPattern
{
    public class ShapeFactory
    {
        private static Dictionary<string, Shape> circleMap = new Dictionary<string, Shape>();

        public ShapeFactory()
        {
        }

        public static Shape GetCircle(string color)
        {
            Shape circle;

            if (circleMap.ContainsKey(color))
            {
                circle = circleMap[color];
            }
            else
            {
                circle = new Circle(color);
                circleMap.Add(color, circle);
                Console.WriteLine("Creating circle of color : " + color);
            }

            return circle;
        }
    }
}

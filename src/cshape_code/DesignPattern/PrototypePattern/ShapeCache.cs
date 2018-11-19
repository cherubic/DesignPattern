using System;
using System.Collections.Generic;
namespace DesignPattern.PrototypePattern
{
    public class ShapeCache
    {
        private static Dictionary<string, Shape> shapeMap = new Dictionary<string, Shape>();
        public static Shape GetShape(string shapeId){
            Shape cachedShape = shapeMap[shapeId];
            return (Shape)cachedShape.Clone();
        }

        public static void LoadShape(){
            Circle circle = new Circle();
            circle.Id = "1";
            shapeMap.Add(circle.Id, circle);

            Square square = new Square();
            square.Id = "2";
            shapeMap.Add(square.Id, square);

            Rectangle rectangle = new Rectangle();
            rectangle.Id = "3";
            shapeMap.Add(rectangle.Id, rectangle);
        }

        public ShapeCache()
        {
        }
    }
}

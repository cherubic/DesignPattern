using System;
namespace DesignPattern.FactoryPattern
{
    public class ShapeFactory
    {
        public ShapeFactory()
        {
        }

        public Shape GetShape(string shapeType){
            if(string.IsNullOrEmpty(shapeType)){
                return null;
            }

            if(shapeType.ToUpper() == "CIRCLE"){
                return new Circle();
            }else if(shapeType.ToUpper() == "RECTANGLE"){
                return new Rectangle();
            }else if(shapeType.ToUpper() == "SQUARE"){
                return new Square();
            }

            return null;
        }
    }
}

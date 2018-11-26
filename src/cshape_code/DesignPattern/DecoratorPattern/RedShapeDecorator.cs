using System;
namespace DesignPattern.DecoratorPattern
{
    public class RedShapeDecorator : ShapeDecorator
    {
        public RedShapeDecorator(Shape decoratedShape) : base(decoratedShape)
        {
        }

        public override void Draw()
        {
            base.Draw();
            setRedBorder();
        }

        private void setRedBorder()
        {
            Console.WriteLine("Border Color: Red");
        }
    }
}

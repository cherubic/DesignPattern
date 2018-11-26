using System;
namespace DesignPattern.Bridge
{
    public class Circle : Shape
    {
        private int x;
        private int y;
        private int radius;

        public Circle(int x, int y, int radius, IDrawAPI drawAPI) : base(drawAPI)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public override void Draw()
        {
            base.drawAPI.DrawCircle(this.radius, this.x, this.y);
        }
    }
}

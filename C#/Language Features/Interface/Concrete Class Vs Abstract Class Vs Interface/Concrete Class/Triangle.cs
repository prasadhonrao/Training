using System;

namespace Training.CSharp
{
    public class Triangle : ConcreteRegularPolygon
    {
        public Triangle(int length) : base(length, 3) { }

        public override double GetArea()
        {
            return SideLength * SideLength * Math.Sqrt(3) / 4;
        }
    }
}

using System;

namespace Training.CSharp
{
    public class Triangle : IRegularPolygon
    {
        public int SideLength { get; private set; }
        public int NumberOfSides { get; private set; }

        public Triangle(int legth)
        {
            this.SideLength = legth;
            this.NumberOfSides = 3;
        }

        public double GetArea()
        {
            return SideLength * SideLength * Math.Sqrt(3) / 4;
        }

        public double GetPerimeter()
        {
            return SideLength * NumberOfSides;
        }
    }
}

using System;

namespace Training.CSharp
{
    public class Triangle : IRegularPolygon
    {
        public int SideLength { get; set; }
        public int NumberOfSides { get; set; }

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

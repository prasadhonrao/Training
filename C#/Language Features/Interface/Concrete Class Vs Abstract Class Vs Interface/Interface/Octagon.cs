using System;

namespace Training.CSharp
{
    public class Octagon : IRegularPolygon
    {
        public int SideLength { get; set; }
        public int NumberOfSides { get; set; }

        public Octagon(int length)
        {
            NumberOfSides = 8;
            SideLength = length;
        }

        public double GetArea()
        {
            return SideLength * SideLength * (2 + 2 * Math.Sqrt(2));
        }

        public double GetPerimeter()
        {
            return SideLength * NumberOfSides;
        }
    }
}

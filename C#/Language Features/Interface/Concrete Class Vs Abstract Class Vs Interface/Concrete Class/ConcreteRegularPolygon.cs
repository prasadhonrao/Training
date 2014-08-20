using System;

namespace Training.CSharp
{
    // A regular polygon is a polygon that is equiangular (all angles are equal in measure) and equilateral (all sides have the same length).

    public class ConcreteRegularPolygon
    {
        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }

        public ConcreteRegularPolygon(int length, int numberOfSides)
        {
            this.SideLength = length;
            this.NumberOfSides = numberOfSides;
        }

        public double GetPerimeter()
        {
            return SideLength * NumberOfSides;
        }

        public virtual double GetArea()
        {
            throw new NotImplementedException();
        }
    }
}

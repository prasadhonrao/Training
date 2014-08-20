namespace Training.CSharp
{
    // A regular polygon is a polygon that is equiangular (all angles are equal in measure) and equilateral (all sides have the same length).

    public abstract class AbstractRegularPolygon
    {
        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }

        public AbstractRegularPolygon(int length, int numberOfSides)
        {
            this.SideLength = length;
            this.NumberOfSides = numberOfSides;
        }

        public double GetPerimeter()
        {
            return SideLength * NumberOfSides;
        }

        public abstract double GetArea();
    }
}

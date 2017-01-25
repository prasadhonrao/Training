namespace Training.CSharp
{
    public class Square : IRegularPolygon
    {
        public int SideLength { get; private set; }
        public int NumberOfSides { get; private set; }

        public Square(int legth)
        {
            this.SideLength = legth;
            this.NumberOfSides = 4;
        }

        public double GetArea()
        {
            return SideLength * NumberOfSides;
        }

        public double GetPerimeter()
        {
            return SideLength * NumberOfSides;
        }
    }
}

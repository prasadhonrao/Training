namespace Training.CSharp
{
    public class Square : IRegularPolygon
    {
        public int SideLength { get; set; }
        public int NumberOfSides { get; set; }

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

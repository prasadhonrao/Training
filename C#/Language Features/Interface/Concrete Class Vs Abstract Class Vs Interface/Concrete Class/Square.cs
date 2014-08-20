namespace Training.CSharp
{
    public class Square : ConcreteRegularPolygon
    {
        public Square(int length) : base(length, 4) {}

        public override double GetArea()
        {
            return SideLength * SideLength;
        }
    }
}

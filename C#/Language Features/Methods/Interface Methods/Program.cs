namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape shape = new Circle();
            shape.Draw();

            IShape sq = new Sqaure();
            sq.Draw();

            System.Console.ReadLine();
        }
    }
}

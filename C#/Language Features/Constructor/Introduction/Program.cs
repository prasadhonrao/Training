using System;

namespace Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            var speaker1 = new Greeter("Prasad");
            speaker1.SayHello("Jon");
            Console.ReadLine();
        }
    }

    class Greeter
    {
        private string speaker;
        public Greeter(string speaker = "")
        {
            this.speaker = speaker;
        }

        public void SayHello(string recipient)
        {
            Console.WriteLine("Hello " + recipient + " From " + speaker);
        }
    }
}

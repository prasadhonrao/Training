using System;

namespace Training.CSharp
{
    class Program
    {
        delegate string StringProcessor(string message);

        static void Main(string[] args)
        {
            #region Delegate chaining with return value always returns the value of last action in invocation list
            var one = new StringProcessor(StaticMethods.PrintOne);
            var two = new StringProcessor(StaticMethods.PrintTwo);
            var three = new StringProcessor(StaticMethods.PrintThree);

            var combine = (StringProcessor)Delegate.Combine(one, two, three);
            var result = combine("Hello");
            Console.WriteLine(result); 
            #endregion

            #region Get invocation list
            var list = combine.GetInvocationList();
            foreach (StringProcessor item in list)
            {
                item("Test");
            } 
            #endregion

            Console.ReadLine();
        }
    }

    public static class StaticMethods
    {
        public static string PrintOne(string message)
        {
            return message + " One";
        }

        public static string PrintTwo(string message)
        {
            return message + " Two";
        }

        public static string PrintThree(string message)
        {
            return message + " Three";
        }
    }
}

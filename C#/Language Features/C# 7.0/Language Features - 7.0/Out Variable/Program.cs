using static System.Console;

namespace Out_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Traditional Way - Before C# 7

            // First declare out variable
            int hour;
            int minutes;
            int seconds;
            GetTime(out hour, out minutes, out seconds);
            WriteLine($"{hour}:{minutes}:{seconds}");

            #endregion

            #region C# 7 way

            GetTime(out int hour2, out int minutes2, out int seconds2);
            WriteLine($"{hour2}:{minutes2}:{seconds2}");

            #endregion

            ReadLine();
        }

        public static void GetTime(out int hour, out int minutes, out int seconds)
        {
            hour = 5;
            minutes = 25;
            seconds = 33;
        }
    }
}

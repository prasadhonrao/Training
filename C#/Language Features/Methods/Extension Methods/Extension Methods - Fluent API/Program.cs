using System;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var someMinuteValue = new TimeSpan(0, 0, 2, 0);
            var someDayValue = new TimeSpan(3, 0, 0, 0);

            var newMinuteValue = 2.Minutes();
            var newDayValue = 2.Days();

            var twoMinsAgoTime = 2.Minutes().Ago();
            Console.WriteLine(twoMinsAgoTime);

            var twoDaysAgo = 2.Days().Ago();
            Console.WriteLine(twoDaysAgo);
        }
    }

    public static class TimeSpanExtension
    {
        public static TimeSpan Minutes(this int value)
        {
            return new TimeSpan(0, 0, value, 0);
        }

        public static TimeSpan Days(this int value)
        {
            return new TimeSpan(value, 0, 0, 0);
        }

        public static DateTime Ago(this TimeSpan value)
        {
            return DateTime.Now - value;
        }
    }
}

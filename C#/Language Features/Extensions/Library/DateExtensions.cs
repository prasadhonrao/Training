using System;

namespace Extensions.Library
{
    public static class DateExtensions
    {
        // Usage: var day = DateTime.Now.OrdinalSuffix(); // Returns 13th
        public static string OrdinalSuffix(this DateTime datetime)
        {
            int day = datetime.Day;

            if (day % 100 >= 11 && day % 100 <= 13)
                return String.Concat(day, "th");

            switch (day % 10)
            {
                case 1:
                    return String.Concat(day, "st");
                case 2:
                    return String.Concat(day, "nd");
                case 3:
                    return String.Concat(day, "rd");
                default:
                    return String.Concat(day, "th");
            }
        }
    }
}

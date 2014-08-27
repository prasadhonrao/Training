using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = 34.99;
            var todaysDate = DateTime.Now;

            var usCultureValue = "en-US";
            var indiaCultureValue = "hi-IN";
            var turkeyCultureValue = "tr-TR";
            var germanCultureValue = "de-CH";

            Console.WriteLine("Setting up US culture");
            var usCulture = CultureInfo.GetCultureInfo(usCultureValue);
            Thread.CurrentThread.CurrentCulture = usCulture;
            Console.WriteLine("Author Age : " + age);
            Console.WriteLine("Today's date : " + todaysDate);

            Console.WriteLine("\nSetting up India culture");
            var indiaCulture = CultureInfo.GetCultureInfo(indiaCultureValue);
            Thread.CurrentThread.CurrentCulture = indiaCulture;
            Console.WriteLine("Author Age : " + age);
            Console.WriteLine("Today's date : " + todaysDate);

            Console.WriteLine("\nSetting up Turkey culture");
            var turkeyCulture = CultureInfo.GetCultureInfo(turkeyCultureValue);
            Thread.CurrentThread.CurrentCulture = turkeyCulture;
            Console.WriteLine("Author Age : " + age);
            Console.WriteLine("Today's date : " + todaysDate);

            Console.WriteLine("\nSetting up German culture");
            var germanCulture = CultureInfo.GetCultureInfo(germanCultureValue);
            Thread.CurrentThread.CurrentCulture = germanCulture;
            Console.WriteLine("Author Age : " + age);
            Console.WriteLine("Today's date : " + todaysDate);

            Console.ReadLine();
        }
    }
}

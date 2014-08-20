using System;
using System.Collections.Generic;
using System.Xml;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region String Extension
            string message = "Hello,World,I,am,feeling,good";
            List<string> list = StringExtensions.ConvertStringToList(message);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("");
            Console.WriteLine("Using extension method now");

            List<string> anotherList = message.SplitUsingComma();
            foreach (var item in anotherList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            #endregion

            #region Date Extension
            var today = DateTime.Now.ToLegacyFormat();
            Console.WriteLine(today);

            var past = new DateTime(1000, 01, 01).ToLegacyFormat();
            Console.WriteLine(past);

            var todayInXmlFormat = DateTime.Now.ToXmlDateTime();
            Console.WriteLine(todayInXmlFormat);

            var todayInLocalXmlFormat = DateTime.Now.ToXmlDateTime(XmlDateTimeSerializationMode.Local);
            Console.WriteLine(todayInLocalXmlFormat);

            Console.WriteLine();
            #endregion

            #region Enum Extension
            Console.WriteLine(Weekdays.Mon.GetName() + " " + Weekdays.Mon.GetDescription());
            Console.WriteLine(Weekdays.Fri.GetName() + " " + Weekdays.Fri.GetDescription());
            #endregion

            Console.ReadLine();
        }
    }

    public enum Weekdays
    {
        [Description("Mondays are boring")]
        Mon,
        Tue,
        Wed,
        Thurs,
        [Description("Exciting fridays")]
        Fri
    }
}

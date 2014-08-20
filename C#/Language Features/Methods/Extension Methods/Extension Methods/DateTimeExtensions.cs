using System;
using System.Xml;

namespace Training.CSharp
{
    public static class DateTimeExtensions
    {
        public static string ToLegacyFormat(this DateTime date)
        {
            return date.Year > 1930 ? date.ToString("1yyyyMMdd") : date.ToString("0yyyyMMdd");
        }

        public static string ToXmlDateTime(this DateTime date)
        {
            return XmlConvert.ToString(date, XmlDateTimeSerializationMode.Utc);
        }

        public static string ToXmlDateTime(this DateTime date, XmlDateTimeSerializationMode mode)
        {
            return XmlConvert.ToString(date, mode);
        }
    }
}

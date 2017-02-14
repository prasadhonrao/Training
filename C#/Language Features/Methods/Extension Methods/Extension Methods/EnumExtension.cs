using System;
using System.ComponentModel;
using System.Linq;

namespace Training.CSharp
{
    public static class EnumExtension
    {
        public static string GetName(this Enum value)
        {
            return Enum.GetName(value.GetType(), value);
        }

        public static string GetDescription(this Enum value)
        {
            var fieldInfo = value.GetType().GetField(value.GetName());
            var descriptionAttribute = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false).FirstOrDefault() as DescriptionAttribute;
            return descriptionAttribute == null ? value.GetName() : descriptionAttribute.Description;

            throw new ArgumentException("Not found.", "description");
        }
    }
}

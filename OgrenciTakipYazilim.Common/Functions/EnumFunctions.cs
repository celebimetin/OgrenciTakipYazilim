using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace OgrenciTakipYazilim.Common.Functions
{
    public static class EnumFunctions
    {
        private static T GetAttribute<T>(this Enum enumValue)
            where T : Attribute
        {
            if (enumValue == null)
            {
                return null;
            }
            MemberInfo[] memberInfo = enumValue.GetType().GetMember(enumValue.ToString());
            object[] attributes = memberInfo[0].GetCustomAttributes(typeof(T), false);
            return (T)attributes[0];
        }

        public static string ToName(this Enum enumValue)
        {
            if (enumValue == null) return null;

            DescriptionAttribute attribute = enumValue.GetAttribute<DescriptionAttribute>();
            return attribute == null
                ? enumValue.ToString()
                : attribute.Description;
        }

        public static ICollection GetEnumDescriptionList<T>()
        {
            return typeof(T).GetMembers()
                .SelectMany(x => x.GetCustomAttributes(typeof(DescriptionAttribute), true).Cast<DescriptionAttribute>())
                .Select(x => x.Description).ToList();
        }

        public static T GetEnum<T>(this string description)
        {
            if (Enum.IsDefined(typeof(T), description))
                return (T) Enum.Parse(typeof(T), description, true);

            var enumNames = Enum.GetNames(typeof(T));
            foreach (var e in enumNames.Select(x => Enum.Parse(typeof(T), x)).Where(y => description == ToName((Enum)y))) return (T)e;
            
            return default(T);
        }
    }
}
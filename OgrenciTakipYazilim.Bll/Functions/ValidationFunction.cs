using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace OgrenciTakipYazilim.Bll.Functions
{
    public static class ValidationFunction
    {
        public static List<PropertyAttribute<TAttribute>> GetPropertyAttributesFromType<TAttribute>(this Type entityType)
            where TAttribute : Attribute
        {
            var list = new List<PropertyAttribute<TAttribute>>();
            var properties = entityType.GetProperties();

            foreach (PropertyInfo property in properties)
            {
                var attributes = property.GetCustomAttributes<TAttribute>(true).ToList();
                if (!attributes.Any())
                {
                    continue;
                }
                list.AddRange(attributes.Select(x => new PropertyAttribute<TAttribute>(property, x)));
            }

            var interfaces = entityType.GetInterfaces();
            foreach (var ifaces in interfaces)
            {
                list.AddRange(ifaces.GetPropertyAttributesFromType<TAttribute>());
            }

            return list;
        }

        public class PropertyAttribute<TAttribute>
        {
            public PropertyInfo Property { get; }
            public TAttribute Attribute { get; }

            public PropertyAttribute(PropertyInfo property, TAttribute attribute)
            {
                Property = property;
                Attribute = attribute;
            }
        }
    }
}

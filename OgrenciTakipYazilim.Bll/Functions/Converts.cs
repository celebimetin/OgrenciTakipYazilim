using OgrenciTakipYazilim.Model.Entities.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace OgrenciTakipYazilim.Bll.Functions
{
    public static class Converts
    {
        public static TTarget EntityConvert<TTarget>(this IBaseEntity source)
        {
            if (source == null)
            {
                return default(TTarget);
            }
            TTarget hedefTaget = Activator.CreateInstance<TTarget>();
            var KaynakProp = source.GetType().GetProperties();
            PropertyInfo[] hedefProp = typeof(TTarget).GetProperties();

            foreach (var item in KaynakProp)
            {
                var value = item.GetValue(source);
                PropertyInfo hedefPropValue = hedefProp.FirstOrDefault(x => x.Name == item.Name);
                if (hedefPropValue != null)
                {
                    hedefPropValue.SetValue(hedefTaget, ReferenceEquals(value, "") ? null : value);
                }
            }
            return hedefTaget;
        }

        public static IEnumerable<TTarget> EntityListConvert<TTarget>(this IEnumerable<IBaseEntity> source)
        {
            return source?.Select(x => x.EntityConvert<TTarget>()).ToList();
        }
    }
}

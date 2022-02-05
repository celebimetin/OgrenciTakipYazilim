using AbcYazilim.Dal.Base;
using AbcYazilim.Dal.Interfaces;
using OgrenciTakipYazilim.Model.Entities.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Reflection;

namespace OgrenciTakipYazilim.Bll.Functions
{
    public static class GeneralFunctionsBll
    {
        public static List<string> DegisenAlanlarıGetir<T>(this T oldEntity, T currentEntity)
        {
            List<string> alanlar = new List<string>();

            foreach (PropertyInfo item in currentEntity.GetType().GetProperties())
            {
                if (item.PropertyType.Namespace == "System.Collections.Generic")
                {
                    continue;
                }
                object oldValue = item.GetValue(oldEntity) ?? string.Empty;
                object currentValue = item.GetValue(currentEntity) ?? string.Empty;

                if (item.PropertyType == typeof(byte[]))
                {
                    if (string.IsNullOrEmpty(oldValue.ToString()))
                    {
                        oldValue = new byte[] { 0 };
                    }
                    if (string.IsNullOrEmpty(currentValue.ToString()))
                    {
                        currentValue = new byte[] { 0 };
                    }

                    if (((byte[])oldValue).Length != ((byte[])currentValue).Length)
                    {
                        alanlar.Add(item.Name);
                    }
                }
                else if (!currentValue.Equals(oldValue))
                {
                    alanlar.Add(item.Name);
                }
            }
            return alanlar;
        }

        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["OgrenciTakipContext"].ConnectionString;
        }

        private static TContext CreateContext<TContext>()
            where TContext : DbContext
        {
            return (TContext)Activator.CreateInstance(typeof(TContext), GetConnectionString());
        }

        public static void CreateUnitOfWork<T, Tcontext>(ref IUnitOfWork<T> unitOfWork)
            where T : class, IBaseEntity
            where Tcontext : DbContext
        {
            unitOfWork?.Dispose();
            unitOfWork = new UnitOfWork<T>(CreateContext<Tcontext>());
        }
    }
}

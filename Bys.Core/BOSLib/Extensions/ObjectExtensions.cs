using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;

namespace BOSLib.Extensions
{
    public static class ObjectExtensions
    {
        private static ConcurrentDictionary<Type, Dictionary<string, PropertyInfo>> ColumnAttributes = new ConcurrentDictionary<Type, Dictionary<string, PropertyInfo>>();
        
        private static ConcurrentDictionary<Type, PropertyInfo[]> Properties = new ConcurrentDictionary<Type, PropertyInfo[]>();

        public static PropertyInfo[] GetObjectProperties(this object obj)
        {
            if (obj == null)
                return new PropertyInfo[] { };

            Type type = obj is Type ? (Type)obj : obj.GetType();
            PropertyInfo[] allProperties = Properties.GetOrAdd(type, t =>
            {
                return t.GetProperties();
            });
            return allProperties;
        }

        public static Dictionary<string, PropertyInfo> GetColumnAttributes(this object obj)
        {
            Dictionary<string, PropertyInfo> columnProps = new Dictionary<string, PropertyInfo>();
            if (obj == null)
                return columnProps;

            Type type = obj is Type ? (Type)obj : obj.GetType();
            columnProps = ColumnAttributes.GetOrAdd(type, cln =>
            {
                foreach (var property in type.GetObjectProperties())
                {
                    var attributes = property.GetCustomAttributes(typeof(ColumnAttribute), false).ToList();
                    if (!attributes.Any())
                        continue;

                    var columnAttribute = (ColumnAttribute)attributes[0];
                    columnProps.Add(columnAttribute.Name, property);
                }
                return columnProps;
            });
            return columnProps;
        }
    }
}

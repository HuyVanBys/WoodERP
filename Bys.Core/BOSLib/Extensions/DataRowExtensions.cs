using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BOSLib.Extensions
{
    public static class DataRowExtensions
    {
        public static TEntity ConvertToObject<TEntity>(this DataRow dr) where TEntity : class
        {
            Type type = typeof(TEntity);
            object obj = type.InvokeMember("", System.Reflection.BindingFlags.CreateInstance, null, null, null);
            PropertyInfo[] allProperties = obj.GetType().GetProperties();
            Dictionary<string, PropertyInfo> columnProps = obj.GetColumnAttributes();
            foreach (DataColumn column in dr.Table.Columns)
            {
                object objValue = dr[column];
                if (objValue != System.DBNull.Value)
                {
                    PropertyInfo property = obj.GetType().GetProperty(column.ColumnName);
                    if (property == null)
                        columnProps.TryGetValue(column.ColumnName, out property);

                    if (property != null)
                        property.SetValue(obj, objValue, null);
                }
            }
            return (TEntity)obj;
        }
    }
}

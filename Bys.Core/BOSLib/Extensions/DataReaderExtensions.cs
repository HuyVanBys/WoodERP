using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOSLib.Extensions
{
    public static class DataReaderExtensions
    {
        public static IList<TEntity> ConvertToList<TEntity>(this IDataReader data) where TEntity : class
        {
            if (data == null)
                return new List<TEntity>();

            DataTable dt = new DataTable();
            dt.TableName = "Table";
            dt.Load(data);
            IList<TEntity> entities = new List<TEntity>();
            foreach (DataRow dr in dt.Rows)
            {
                TEntity entity = dr.ConvertToObject<TEntity>();
                entities.Add(entity);
            }
            return entities;
        }
    }
}

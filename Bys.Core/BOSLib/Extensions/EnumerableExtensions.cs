using BOSCommon.Constants;
using BOSLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Z.Dapper.Plus;

namespace BOSLib.Extensions
{
    public static class EnumerableExtensions
    {
        public static void InsertOrUpdateObject<TEntity>(this IEnumerable<TEntity> entity) where TEntity : IEntity
        {
            string userName = BysGateway.CurrentUsersInfo.ADUserName;
            DateTime dateNow = BysGateway.CurrentServerDate;
            foreach (var item in entity)
            {
                if (item.Id > 0)
                {
                    var updatedDateProperty = item.GetType().GetProperty(CommonColumn.AAUpdatedUser);
                    if (updatedDateProperty != null)
                        updatedDateProperty.SetValue(item, userName, null);

                    var updatedUserProperty = item.GetType().GetProperty(CommonColumn.AAUpdatedDate);
                    if (updatedUserProperty != null)
                        updatedUserProperty.SetValue(item, dateNow, null);
                }
                else
                {
                    var objectStatus = item.GetType().GetProperty(CommonColumn.AAStatus);
                    if (objectStatus != null)
                    {
                        objectStatus.SetValue(item, ObjectStatus.Alive, null);
                    }
                    var createdDateProperty = item.GetType().GetProperty(CommonColumn.AACreatedUser);
                    if (createdDateProperty != null)
                        createdDateProperty.SetValue(item, userName, null);

                    var createddUserProperty = item.GetType().GetProperty(CommonColumn.AACreatedDate);
                    if (createddUserProperty != null)
                        createddUserProperty.SetValue(item, dateNow, null);
                }
            }
            if (SqlDatabaseHelper.Transaction == null)
            {
                SqlDatabaseHelper.Connection.BulkInsert(entity.Where(o => o.Id == 0));
                SqlDatabaseHelper.Connection.BulkUpdate(entity.Where(o => o.Id > 0));
            }
            else
            {
                SqlDatabaseHelper.Transaction.BulkInsert(entity.Where(o => o.Id == 0));
                SqlDatabaseHelper.Transaction.BulkUpdate(entity.Where(o => o.Id > 0));
            }
        }

        public static void DeleteObject<TEntity>(this IEnumerable<TEntity> entity) where TEntity : IEntity
        {
            bool hasStatusColumn = false;
            string userName = BysGateway.CurrentUsersInfo.ADUserName;
            DateTime dateNow = BysGateway.CurrentServerDate;
            foreach (var item in entity)
            {
                if (item.Id > 0)
                {
                    var objectStatus = item.GetType().GetProperty(CommonColumn.AAStatus);
                    if (objectStatus != null)
                    {
                        hasStatusColumn = true;
                        objectStatus.SetValue(item, ObjectStatus.Delete, null);
                    }
                    var updatedDateProperty = item.GetType().GetProperty(CommonColumn.AAUpdatedUser);
                    if (updatedDateProperty != null)
                        updatedDateProperty.SetValue(item, userName, null);

                    var updatedUserProperty = item.GetType().GetProperty(CommonColumn.AAUpdatedDate);
                    if (updatedUserProperty != null)
                        updatedUserProperty.SetValue(item, dateNow, null);
                }
            }
            if (SqlDatabaseHelper.Transaction == null)
            {
                if (hasStatusColumn)
                    SqlDatabaseHelper.Connection.BulkUpdate(entity.Where(o => o.Id > 0));
                else
                    SqlDatabaseHelper.Connection.BulkDelete(entity.Where(o => o.Id > 0));
            }
            else
            {
                if (hasStatusColumn)
                    SqlDatabaseHelper.Transaction.BulkUpdate(entity.Where(o => o.Id > 0));
                else
                    SqlDatabaseHelper.Transaction.BulkDelete(entity.Where(o => o.Id > 0));
            }
        }

        public static DataTable ToDataTableIds(this IEnumerable<int> entity)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Id", typeof(int)));
            entity?.Distinct()?.All(objectId =>
            {
                if (objectId == 0)
                    return true;

                DataRow dr = dt.NewRow();
                dr["Id"] = objectId;
                dt.Rows.Add(dr);
                return true;
            });
            return dt;
        }
    }
}

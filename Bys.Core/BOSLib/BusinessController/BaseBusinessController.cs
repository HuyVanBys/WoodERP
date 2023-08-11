using BOSLib.Interfaces;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Reflection;
using System.Runtime.InteropServices;

namespace BOSLib
{
    public class BaseBusinessController : IBusinessController, IDisposable
    {
        protected DALBaseProvider dal;

        #region Constructor
        public BaseBusinessController()
        {
            dal = new DALBaseProvider();
        }

        public BaseBusinessController(String strTableName, Type objType)
        {
            dal = new DALBaseProvider(strTableName, objType);
        }

        public BaseBusinessController(Type objType)
        {
            string strTableName = objType.Name.Substring(0, objType.Name.Length - 4);
            dal = new DALBaseProvider(strTableName, objType);
        }
        #endregion

        #region Utility Functions
        public int GetMaxID()
        {
            return dal.GetMaxID() + 1;
        }

        #endregion

        #region Functions for Create,Update,Delete
        public virtual int CreateObject(BusinessObject obj)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            int id = dal.CreateObject(obj);
            dal.SetValueToPrimaryColumn(obj, id);
            return id;
        }

        public virtual int CreateObject(BusinessObject obj, int iObjectID)
        {
            if (iObjectID > 0 && IsExist(iObjectID))
                return -1;

            dal.SetValueToPrimaryColumn(obj, iObjectID);
            return dal.CreateObject(obj);
        }

        public void DeleteEntity<TEntity>(TEntity entity) where TEntity : class
        {
            dal.DeleteEntity(entity);
        }
        //public virtual int CreateObject(BusinessObject obj, int iObjectID, DbTransaction transaction)
        //{
        //    if (IsExist(iObjectID))
        //        return -1;

        //    dal.SetValueToPrimaryColumn(obj, iObjectID);
        //    return dal.CreateObject(obj, transaction);
        //}

        public virtual int CreateObject(BusinessObject obj, DbTransaction transaction)
        {
            //[NUThao] [Improve Speed] [2014-09-09]
            //dal.SetValueToPrimaryColumn(obj, GetMaxID());            
            int id = dal.CreateObject(obj, transaction);
            dal.SetValueToPrimaryColumn(obj, id);
            return id;
            //[NUThao] [Improve Speed] [2014-09-09]
        }

        public virtual int UpdateObject(BusinessObject obj)
        {
            return dal.UpdateObject(obj);
        }

        public virtual int UpdateObject(BusinessObject obj, DbTransaction transaction)
        {
            return dal.UpdateObject(obj, transaction);
        }

        public virtual void DeleteObject(int iObjectID)
        {
            dal.DeleteObject(iObjectID);
        }

        public void DeleteAllObjects()
        {
            dal.DeleteAllObjects();
        }

        public virtual void DeleteByForeignColumn(String strForeignColumn, object objForeignColumnValue)
        {
            dal.DeleteByForeignColumn(strForeignColumn, objForeignColumnValue);
        }


        #endregion

        #region Functions for Get Object

        public virtual object GetTemplateObject()
        {
            return dal.GetTemplateObject();
        }

        public virtual object GetObjectByID(int iObjectID)
        {
            return dal.GetObjectById(iObjectID);
        }

        public virtual TEntity GetObjectByID<TEntity>(int iObjectID) where TEntity : class
        {
            return dal.GetObjectById<TEntity>(iObjectID);
        }

        public virtual DataSet GetDataSetByID(int iObjectID)
        {
            return dal.GetDataSetByID(iObjectID);
        }

        public virtual object GetDeletedObjectByID(int iObjectID)
        {
            return dal.GetDeletedObjectByID(iObjectID);
        }

        public virtual String GetObjectNameByID(int iObjectID)
        {
            return dal.GetObjectNameByID(iObjectID);
        }

        public virtual String GetObjectNoByID(int iObjectID)
        {
            return dal.GetObjectNoByID(iObjectID);
        }

        public virtual object GetObjectByName(String strObjectName)
        {
            return dal.GetObjectByName(strObjectName);
        }

        public virtual object GetObjectByNo(String strObjectNo)
        {
            return dal.GetObjectByNo(strObjectNo);
        }

        public virtual object GetObjectByAANumberInt(int iAANumberInt)
        {
            return dal.GetObjectByAANumberInt(iAANumberInt);
        }

        public virtual int GetObjectIDByName(String strObjectName)
        {
            return dal.GetObjectIDByName(strObjectName);
        }

        public virtual int GetObjectIDByNo(String strObjectNo)
        {
            return dal.GetObjectIDByNo(strObjectNo);
        }

        public virtual DataSet GetAllObjects()
        {
            return dal.GetAllObject();
        }

        public virtual DataSet GetAllProfileObjects()
        {
            return dal.GetAllProfileObjects();
        }

        public virtual DataSet GetAllAliveObjects()
        {
            return dal.GetAllAliveObjects();
        }

        public virtual DataSet GetObjectsForDataLookup(String[] arrColumns, int iMaxResults)
        {
            String strQuery = String.Format("Select TOP({0}) ", iMaxResults);
            foreach (String strColumn in arrColumns)
            {
                strQuery += String.Format("[{0}],", strColumn);
            }
            strQuery = strQuery.Remove(strQuery.Length - 1, 1);
            strQuery += String.Format(" FROM [{0}] WHERE [AAStatus]='Alive'", dal.TableName);
            DbCommand cmd = SqlDatabaseHelper.GetQuery(strQuery);
            return (DataSet)SqlDatabaseHelper.RunQuery(cmd);
        }

        public virtual DataSet GetObjectsByIDForDataLookup(String[] arrColumns, int iObjectID)
        {
            String strQuery = "Select ";
            String strPrimaryColumn = new BOSDbUtil().GetTablePrimaryColumn(dal.TableName);

            foreach (String strColumn in arrColumns)
            {
                strQuery += String.Format("[{0}],", strColumn);
            }
            strQuery = strQuery.Remove(strQuery.Length - 1, 1);
            strQuery += String.Format(" FROM [{0}] WHERE [{1}]={2} AND [AAStatus]='Alive'", dal.TableName, strPrimaryColumn, iObjectID);
            DbCommand cmd = SqlDatabaseHelper.GetQuery(strQuery);
            return (DataSet)SqlDatabaseHelper.RunQuery(cmd);
        }

        public virtual DataSet GetObjectsForDataLookup(String[] arrColumns, int iMaxResults, String strCondition)
        {
            String strQuery = String.Format("Select TOP({0}) ", iMaxResults);
            foreach (String strColumn in arrColumns)
            {
                strQuery += String.Format("[{0}],", strColumn);
            }
            strQuery = strQuery.Remove(strQuery.Length - 1, 1);
            strQuery += String.Format(" FROM [{0}] WHERE [AAStatus]='Alive'", dal.TableName);
            strQuery += " AND " + strCondition;

            DbCommand cmd = SqlDatabaseHelper.GetQuery(strQuery);
            return (DataSet)SqlDatabaseHelper.RunQuery(cmd);
        }

        public virtual DataSet GetObjectsForDataLookupByDefault()
        {
            string tableName = dal.TableName;
            if (!string.IsNullOrEmpty(tableName))
            {
                BOSDbUtil dbUtil = new BOSDbUtil();

                string primaryColumn = dbUtil.GetTablePrimaryColumn(tableName);
                string columnNo = primaryColumn.Substring(0, primaryColumn.Length - 2) + "No";
                string columnName = primaryColumn.Substring(0, primaryColumn.Length - 2) + "Name";

                String strQuery = String.Format("Select [{0}]", primaryColumn);

                bool isExists = dbUtil.ColumnIsExist(tableName, columnNo);
                if (isExists)
                    strQuery += String.Format(", [{0}]", columnNo);

                isExists = dbUtil.ColumnIsExist(tableName, columnName);
                if (isExists)
                    strQuery += String.Format(", [{0}]", columnName);

                strQuery += String.Format(" FROM [{0}] WHERE [AAStatus]='Alive'", tableName);

                DbCommand cmd = SqlDatabaseHelper.GetQuery(strQuery);
                return (DataSet)SqlDatabaseHelper.RunQuery(cmd);
            }
            return null;
        }

        /// <summary>
        /// Get Data Set by Query Command
        /// </summary>
        /// <param name="strQuery"></param>
        /// <returns></returns>
        public virtual DataSet GetDataSet(String strQuery)
        {
            return (DataSet)dal.GetDataSet(strQuery);
        }

        /// <summary>
        /// Get an object by a stored procedure and param values
        /// </summary>
        /// <param name="spName">Stored procedure name</param>
        /// <param name="values">Parameter values</param>
        /// <returns>Object</returns>
        public virtual object GetDataObject(string spName, params object[] values)
        {
            return dal.GetDataObject(spName, values);
        }

        /// <summary>
        /// Convert a data set to a list
        /// </summary>
        /// <param name="ds">Given data set</param>
        /// <returns>List contains data</returns>
        public virtual IList GetListFromDataSet(DataSet ds)
        {
            return null;
        }

        public virtual object GetFirstObject()
        {
            return dal.GetFirstObject();
        }

        public virtual int GetFirstObjectID()
        {
            try
            {
                object obj = GetFirstObject();
                if (obj != null)
                    return Convert.ToInt32(dal.GetPrimaryColumnValue(obj));
                return 0;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public virtual object GetObjectFromDataRow(DataRow row)
        {
            return dal.GetObjectFromDataRow(row);
        }

        public DataRow GetDataRowFromBusinessObject(DataRow row, BusinessObject obj)
        {
            foreach (DataColumn column in row.Table.Columns)
            {
                PropertyInfo property = obj.GetType().GetProperty(column.ColumnName);
                if (property != null)
                {
                    object value = property.GetValue(obj, null);
                    row[column.ColumnName] = value;
                    if (value == null && !column.AllowDBNull)
                        row[column.ColumnName] = GetDefultValue(column);
                }
            }
            return row;
        }

        private object GetDefultValue(DataColumn column)
        {
            Type type = column.DataType;
            switch (Type.GetTypeCode(type))
            {
                case TypeCode.Boolean:
                    return false;
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                    return 0;
                case TypeCode.Char:
                case TypeCode.String:
                    return string.Empty;
                default:
                    return default;
            };
        }

        /// <summary>
        /// Get the value of a cell
        /// </summary>
        /// <param name="row">Row contains the cell</param>
        /// <param name="columnName">Name of column containing the cell</param>
        /// <returns>Cell value</returns>
        public object GetRowCellValue(DataRow row, string columnName)
        {
            object value = null;
            if (row[columnName] != DBNull.Value)
            {
                value = row[columnName];
            }
            return value;
        }

        public virtual List<BusinessObject> GetListBusinessObjects()
        {
            List<BusinessObject> businessObjectList = new List<BusinessObject>();
            DataSet ds = GetAllObjects();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    BusinessObject objBusinessObject = (BusinessObject)SqlDatabaseHelper.GetObjectFromDataRow(row, dal.ObjectType);
                    businessObjectList.Add(objBusinessObject);
                }
            }
            BOSDisposeUtility.DisposeDataSet(ds, 0, GCCollectionMode.Forced);
            return businessObjectList;
        }

        public virtual DataSet GetAllDataByForeignColumn(String strForeignColumnName, object objForeignColumnValue)
        {
            return (DataSet)dal.GetAllDataByForeignColumn(strForeignColumnName, objForeignColumnValue);
        }

        public virtual BusinessObject GetFirstObjectByForeignColumn(String strForeignColumnName, object objForeignColumnValue)
        {
            DataSet ds = GetAllDataByForeignColumn(strForeignColumnName, objForeignColumnValue);
            BusinessObject obj = (BusinessObject)dal.GetSingleObject(ds.Tables[0]);
            BOSDisposeUtility.DisposeDataSet(ds, 0, GCCollectionMode.Forced);
            return obj;
        }

        public virtual DataSet GetAllObjectsByObjectParentID(int iObjectParentID)
        {
            return (DataSet)dal.GetAllObjectsByObjectParentID(iObjectParentID);
        }

        public void DeleteAllObjectsByObjectParentID(int iObjectParentID)
        {
            dal.DeleteAllObjectsByObjectParentID(iObjectParentID);
        }

        public bool IsExist(int iObjectID)
        {
            return (GetObjectByID(iObjectID) != null);
        }

        public bool IsExistObjectName(String strObjectName)
        {
            return (GetObjectByName(strObjectName) != null);
        }

        public bool IsExist(String strObjectNo)
        {
            return (GetObjectByNo(strObjectNo) != null);
        }


        public bool IsExistAANumberInt(int iAANumberInt)
        {
            return (GetObjectByAANumberInt(iAANumberInt) != null);
        }



        #endregion

        #region Functions For Get,Delete From Owner
        public virtual DataSet GetAllFromOwner(String strOwnerTable, int iOwnerID, String strSwitcherTable)
        {
            return dal.GetMembersFromOwner(strOwnerTable, iOwnerID, dal.TableName, strSwitcherTable);
        }

        public virtual void DeleteFromOwner(String strOwnerTable, int iOwnerID, String strSwitcherTable)
        {
            dal.DeleteMembersFromOwner(strOwnerTable, iOwnerID, dal.TableName, strSwitcherTable);
        }
        #endregion

        #region Functions for main module:Search,Get New Object In Session,Update Save Status In Session

        public virtual DataSet GetAllNewObjectInSession(String strUserName)
        {
            return dal.GetNewObjectInSession(strUserName);
        }

        public virtual void UpdateObjectSaveStatusInSession(String strUserName)
        {
            dal.UpdateObjectSaveStatusInSession(strUserName);
        }

        public virtual DataSet SearchObject(object objSearch)
        {
            return (DataSet)dal.SearchObject(objSearch);
        }

        public virtual int GetRecordsCount()
        {
            int count = -1;
            String strIDFieldName = dal.TableName.Substring(0, dal.TableName.Length - 1) + "ID";

            String strSQL = String.Format("select count(" + strIDFieldName + ") as count from " + dal.TableName + " where AAStatus = 'Alive' ");
            DbCommand cmd = SqlDatabaseHelper.GetQuery(strSQL);
            DataSet ds = SqlDatabaseHelper.RunQuery(cmd);
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {

                    return Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                }
            }
            return count;
        }
        #endregion                      

        #region Implement Dispose
        // Flag: Has Dispose already been called?
        bool disposed = false;
        // Instantiate a SafeHandle instance.
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            Dispose(true);
            GC.Collect(0, GCCollectionMode.Forced);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                handle.Dispose();
                // Free any other managed objects here.
                //
            }

            disposed = true;
        }
        #endregion
    }
}

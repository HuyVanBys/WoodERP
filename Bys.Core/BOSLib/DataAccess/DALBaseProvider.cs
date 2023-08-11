using BOSCommon.Constants;
using Dapper;
using DevExpress.Utils.Extensions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Globalization;
using System.Linq;
using System.Reflection;
using Z.Dapper.Plus;

namespace BOSLib
{
    /// <summary>
    /// Summary description for DALBaseProvider.
    /// </summary>
    public class DALBaseProvider
    {
        protected string _tableName;
        protected Type _objectType;
        public IDbConnection Connection => SqlDatabaseHelper.Connection;
        #region Constructors
        public DALBaseProvider()
        {

        }

        public DALBaseProvider(string strTableName, Type objType)
        {
            _tableName = strTableName;
            _objectType = objType;
        }
        #endregion

        #region Public Properties
        public string TableName
        {
            get
            {
                return _tableName;
            }
            set
            {
                _tableName = value;
            }
        }

        public Type ObjectType
        {
            get
            {
                return _objectType;
            }
            set
            {
                _objectType = value;
            }
        }
        #endregion

        #region Function for Generate Insert,Update,Select Stored Procedure Name
        private string GenerateInsertStoredProcedureName()
        {
            return string.Format("{0}_Insert", TableName);
        }

        private string GenerateUpdateStoredProcedureName()
        {
            return string.Format("{0}_Update", TableName);
        }

        private string GenerateDeleteStoredProcedureName()
        {
            return string.Format("{0}_Delete", TableName);
        }

        private string GenerateDeleteByForeignColumnStoredProcedureName(String strForeignColumn)
        {
            return string.Format("{0}_DeleteBy{1}", TableName, strForeignColumn);
        }

        private string GenerateDeleteAllStoredProcedureName()
        {
            return string.Format("{0}_DeleteAll", TableName);
        }

        private string GenerateSelectAllStoredProcedureName()
        {
            return string.Format("{0}_SelectAll", TableName);
        }

        private string GenerateSelectAllProfilesStoredProcedureName()
        {
            return string.Format("{0}_SelectAllProfiles", TableName);
        }

        private string GenerateSelectAllAlivesStoredProcedureName()
        {
            return string.Format("{0}_SelectAlive{0}", TableName);
        }

        private string GenerateSelectByPrimaryKeyStoredProcedureName()
        {
            return string.Format("{0}_Select", TableName);
        }

        private string GenerateSelectDeletedByPrimayKeyStoredProcedureName()
        {
            return string.Format("{0}_SelectDeletedByID", TableName);
        }

        private string GenerateSelectByNameStoredProcedureName()
        {
            return string.Format("{0}_SelectByName", TableName);
        }

        private string GenerateSelectByNoStoredProcedureName()
        {
            return string.Format("{0}_SelectByNo", TableName);
        }

        private string GenerateSelectByAANumberIntStoredProcedureName()
        {
            return string.Format("{0}_SelectByAANumberInt", TableName);
        }

        private string GenerateSelectNewObjectInSessionStoredProcedureName()
        {
            return string.Format("{0}_SelectNewInSession", TableName);
        }

        private string GenerateUpdateObjectSaveStatusInSessionStoredProcedureName()
        {
            return string.Format("{0}_UpdateSaveStatusInSession", TableName);
        }

        private string GenerateSearchObjectStoredProcedureName()
        {
            return string.Format("{0}_Search", TableName);
        }

        private string GenerateSelectByForeignColumnStoredProcedureName(String strForeignColumnName)
        {
            return string.Format("{0}_SelectBy{1}", TableName, strForeignColumnName);
        }

        #endregion

        #region Utility Functions
        public void SetValueToPrimaryColumn(object obj, int iObjectID)
        {
            SqlDatabaseHelper.SetValueToPrimaryColumn(obj, this, iObjectID);
        }

        public void SetValueToIDStringColumn(object obj, int iObjectID)
        {
            SqlDatabaseHelper.SetValueToIDStringColumn(obj, this, iObjectID);
        }

        public object GetPrimaryColumnValue(object obj)
        {
            return SqlDatabaseHelper.GetPrimaryColumnValue(obj, this);
        }

        public virtual int GetMaxID()
        {
            return SqlDatabaseHelper.GetMaxID(TableName);
        }

        public DbCommand GetStoredProcedureCommand(String spName)
        {
            return SqlDatabaseHelper.GetStoredProcedure(spName);
        }

        public void AddParameter(DbCommand cmd, String name, DbType type, ParameterDirection direction, object value)
        {
            SqlDatabaseHelper.AddParameter(cmd, name, type, direction, value);
        }

        /// <summary>
        /// Execute a stored procedure
        /// </summary>
        /// <param name="spName">Stored procedure name</param>
        /// <param name="parameters">Parameters need to be passed to the stored procedure</param>
        public void ExecuteStoredProcedure(String spName, params object[] parameters)
        {
            SqlDatabaseHelper.RunStoredProcedure(spName, parameters);
        }

        public void ExecuteStoredProcedureNonQuery(String spName, params object[] parameters)
        {
            SqlDatabaseHelper.ExecuteNonQuery(spName, parameters);
        }

        public object GetParameterValue(DbCommand cmd, String paramName)
        {
            if (cmd.Parameters[paramName].Value == DBNull.Value)
                return null;
            return cmd.Parameters[paramName].Value;
        }
        #endregion

        #region Create,Update,Delelte Functions
        public virtual int CreateObject<TEntiy>(TEntiy obj) where TEntiy : class
        {
            return SqlDatabaseHelper.InsertObject(obj, this, GenerateInsertStoredProcedureName());
        }

        public virtual int CreateObject<TEntiy>(TEntiy obj, DbTransaction transaction) where TEntiy : class
        {
            return SqlDatabaseHelper.InsertObject(obj, this, GenerateInsertStoredProcedureName(), transaction);
        }

        public virtual int UpdateObject<TEntiy>(TEntiy obj) where TEntiy : class
        {
            return SqlDatabaseHelper.InsertObject(obj, this, GenerateUpdateStoredProcedureName());
        }

        public virtual int UpdateObject<TEntiy>(TEntiy obj, DbTransaction transaction) where TEntiy : class
        {
            return SqlDatabaseHelper.InsertObject(obj, this, GenerateUpdateStoredProcedureName(), transaction);
        }

        public virtual void DeleteObject(int iObjectID)
        {
            DbCommand cmd = SqlDatabaseHelper.GetStoredProcedure(GenerateDeleteStoredProcedureName());
            SqlDatabaseHelper.AddInParameter(cmd, SqlDatabaseHelper.GetPrimaryKeyColumn(TableName), SqlDbType.Int, iObjectID);
            SqlDatabaseHelper.RunStoredProcedure(cmd);
        }

        public virtual void DeleteAllObjects()
        {
            SqlDatabaseHelper.RunStoredProcedure(GenerateDeleteAllStoredProcedureName());
        }

        public virtual void DeleteByForeignColumn(String strForeignColumn, object objValue)
        {
            SqlDatabaseHelper.RunStoredProcedure(GenerateDeleteByForeignColumnStoredProcedureName(strForeignColumn), objValue);
        }

        #endregion

        #region Get Functions

        public virtual object GetObjectById(int iObjectID)
        {
            string primaryKeyColumn = SqlDatabaseHelper.GetPrimaryKeyColumn(TableName);
            string sqlQuery = "SELECT * FROM {0} (NOLOCK) WHERE AAStatus = @Status AND {1} = @ObjectID";
            DataTable dt = new DataTable();
            try
            {
                var result = Connection.ExecuteReader(string.Format(sqlQuery, TableName, primaryKeyColumn), new { Status = ObjectStatus.Alive, ObjectID = iObjectID }, SqlDatabaseHelper.Transaction);
                dt.Load(result);
            }
            catch
            {
                sqlQuery = "SELECT * FROM {0} (NOLOCK) WHERE  {1} = @ObjectID";
                var result = Connection.ExecuteReader(string.Format(sqlQuery, TableName, primaryKeyColumn), new { ObjectID = iObjectID }, SqlDatabaseHelper.Transaction);
                dt.Load(result);
            }
           
            return SqlDatabaseHelper.GetSingleObject(dt, ObjectType);
        }

        public virtual TEntity GetObjectById<TEntity>(int iObjectID) where TEntity : class
        {
            string primaryKeyColumn = SqlDatabaseHelper.GetPrimaryKeyColumn(TableName);
            string sqlQuery = "SELECT * FROM {0} (NOLOCK) WHERE AAStatus = @Status AND {1} = @ObjectID";
            return Connection.QuerySingleOrDefault<TEntity>(string.Format(sqlQuery, TableName, primaryKeyColumn), new { Status = ObjectStatus.Alive, ObjectID = iObjectID }, SqlDatabaseHelper.Transaction);
        }

        public virtual DataSet GetDataSetByID(int iObjectID)
        {
            DbCommand cmd = SqlDatabaseHelper.GetStoredProcedure(GenerateSelectByPrimaryKeyStoredProcedureName());
            SqlDatabaseHelper.AddInParameter(cmd, SqlDatabaseHelper.GetPrimaryKeyColumn(TableName), SqlDbType.Int, iObjectID);
            DataSet ds = SqlDatabaseHelper.RunStoredProcedure(cmd);
            return ds;
        }

        public virtual String GetObjectNameByID(int iObjectID)
        {
            string primaryKeyColumn = SqlDatabaseHelper.GetPrimaryKeyColumn(TableName);
            String strObjectNameColumn = primaryKeyColumn.Substring(0, SqlDatabaseHelper.GetPrimaryKeyColumn(TableName).Length - 2) + "Name";
            string sqlQueryTemplate = "SELECT {0} FROM {1} (NOLOCK) WHERE AAStatus = @Status AND {2} = @ObjectID";
            string strObjectName = string.Empty;
            PropertyInfo property = ObjectType.GetProperty(strObjectNameColumn);
            if (property != null)
            {
                string sqlQuery = string.Format(sqlQueryTemplate, strObjectNameColumn, TableName, primaryKeyColumn);
                strObjectName = Connection.QuerySingleOrDefault<string>(sqlQuery, new { Status = ObjectStatus.Alive, ObjectID = iObjectID }, SqlDatabaseHelper.Transaction);
            }
            return strObjectName;
        }

        public virtual String GetObjectNoByID(int iObjectID)
        {
            string primaryKeyColumn = SqlDatabaseHelper.GetPrimaryKeyColumn(TableName);
            String strObjectNoColumn = primaryKeyColumn.Substring(0, SqlDatabaseHelper.GetPrimaryKeyColumn(TableName).Length - 2) + "No";

            string sqlQueryTemplate = "SELECT {0} FROM {1} (NOLOCK) WHERE AAStatus = @Status AND {2} = @ObjectID";
            string strObjectNo = string.Empty;
            PropertyInfo property = ObjectType.GetProperty(strObjectNoColumn);
            if (property != null)
            {
                string sqlQuery = string.Format(sqlQueryTemplate, strObjectNoColumn, TableName, primaryKeyColumn);
                strObjectNo = Connection.QuerySingleOrDefault<string>(sqlQuery, new { Status = ObjectStatus.Alive, ObjectID = iObjectID }, SqlDatabaseHelper.Transaction);
            }
            return strObjectNo;
        }

        public virtual object GetObjectByName(String strObjectName)
        {
            try
            {
                DataSet ds = SqlDatabaseHelper.RunStoredProcedure(GenerateSelectByNameStoredProcedureName(), strObjectName);
                if (ds.Tables.Count > 0)
                {
                    object obj = SqlDatabaseHelper.GetSingleObject(ds.Tables[0], ObjectType);
                    BOSDisposeUtility.DisposeDataSet(ds, 0, GCCollectionMode.Forced);
                    return obj;
                }
            }
            catch (Exception)
            {
                return null;
            }
            return null;
        }

        public virtual object GetObjectByNo(String strObjectNo)
        {
            try
            {
                DataSet ds = SqlDatabaseHelper.RunStoredProcedure(GenerateSelectByNoStoredProcedureName(), strObjectNo);
                if (ds.Tables.Count > 0)
                {
                    object obj = SqlDatabaseHelper.GetSingleObject(ds.Tables[0], ObjectType);
                    BOSDisposeUtility.DisposeDataSet(ds, 0, GCCollectionMode.Forced);
                    return obj;
                }
            }
            catch (Exception)
            {
                return null;
            }
            return null;
        }

        public virtual object GetObjectByAANumberInt(int iAANumberInt)
        {
            try
            {
                DataSet ds = SqlDatabaseHelper.RunStoredProcedure(GenerateSelectByAANumberIntStoredProcedureName(), iAANumberInt);
                if (ds.Tables.Count > 0)
                {
                    object obj = SqlDatabaseHelper.GetSingleObject(ds.Tables[0], ObjectType);
                    BOSDisposeUtility.DisposeDataSet(ds, 0, GCCollectionMode.Forced);
                    return obj;
                }
            }
            catch (Exception)
            {
                return null;
            }
            return null;
        }

        public virtual int GetObjectIDByName(String strObjectName)
        {
            int iObjectID = 0;
            object obj = GetObjectByName(strObjectName);
            if (obj != null)
            {
                iObjectID = Convert.ToInt32(SqlDatabaseHelper.GetPrimaryColumnValue(obj, this));
            }
            return iObjectID;
        }

        public virtual int GetObjectIDByNo(String strObjectNo)
        {
            int iObjectID = 0;
            object obj = GetObjectByNo(strObjectNo);
            if (obj != null)
            {
                iObjectID = Convert.ToInt32(SqlDatabaseHelper.GetPrimaryColumnValue(obj, this));
            }
            return iObjectID;
        }

        public virtual object GetDeletedObjectByID(int iObjectID)
        {
            DbCommand cmd = SqlDatabaseHelper.GetStoredProcedure(GenerateSelectDeletedByPrimayKeyStoredProcedureName());
            SqlDatabaseHelper.AddInParameter(cmd, SqlDatabaseHelper.GetPrimaryKeyColumn(TableName), SqlDbType.Int, iObjectID);
            DataSet ds = SqlDatabaseHelper.RunStoredProcedure(cmd);
            if (ds.Tables.Count <= 0)
                return null;
            object obj = SqlDatabaseHelper.GetSingleObject(ds.Tables[0], ObjectType);
            BOSDisposeUtility.DisposeDataSet(ds, 0, GCCollectionMode.Forced);
            return obj;
        }

        public string GetStringParamsQuery(params object[] paramValues)
        {
            //spName = "";
            List<string> arrParams = new List<string>();
            paramValues.ForEach(value =>
            {
                if (value == null || value == DBNull.Value)
                {
                    arrParams.Add("NULL");
                    return;
                }
                Type type = value.GetType();
                switch (Type.GetTypeCode(type))
                {
                    case TypeCode.Boolean:
                        arrParams.Add(((bool)value) ? "1" : "0");
                        break;

                    case TypeCode.Int16:
                    case TypeCode.UInt16:
                    case TypeCode.Int32:
                    case TypeCode.UInt32:
                    case TypeCode.Int64:
                    case TypeCode.UInt64:
                        arrParams.Add(value.Equals(0) ? "NULL" : value.ToString());
                        break;
                    case TypeCode.Decimal:
                        arrParams.Add(value.Equals(0) ? "NULL" : ((decimal)(value)).ToString(CultureInfo.InvariantCulture));
                        break;
                    case TypeCode.Double:
                        arrParams.Add(value.Equals(0) ? "NULL" : ((double)(value)).ToString(CultureInfo.InvariantCulture));
                        break;
                    case TypeCode.Single:
                        arrParams.Add(value.Equals(0) ? "NULL" : ((float)(value)).ToString(CultureInfo.InvariantCulture));
                        break;
                    case TypeCode.DateTime:
                        arrParams.Add(string.Format("'{0}'", ((DateTime)value).ToString("yyyy/MM/dd HH:mm")));
                        break;
                    case TypeCode.Char:
                    case TypeCode.String:
                        arrParams.Add(string.IsNullOrEmpty(value.ToString()) ? "NULL" : string.Format("'{0}'", value));
                        break;
                    default:
                        arrParams.Add(string.Format("'{0}'", value));
                        break;
                };
            });
            return string.Join(", ", arrParams.ToArray());
        }

        private object GetDefaultValueQueryProp(object value, DbType dbType)
        {
            switch (dbType)
            {
                case DbType.Int16:
                case DbType.Int32:
                case DbType.Int64:
                case DbType.UInt16:
                case DbType.UInt32:
                case DbType.UInt64:
                case DbType.Double:
                case DbType.Decimal:
                case DbType.Single:
                case DbType.Currency:
                    if (value?.Equals(0) ?? true)
                        return null;
                    break;
                case DbType.String:
                case DbType.AnsiString:
                case DbType.StringFixedLength:
                case DbType.AnsiStringFixedLength:
                    if (string.IsNullOrWhiteSpace(value?.ToString() ?? string.Empty))
                        return null;
                    break;
                default:
                    break;
            }
            return value;
        }


        public DataSet GetDataSet(string spName, params object[] paramValues)
        {
            try
            {
                DbCommand cmd = SqlDatabaseHelper.GetStoredProcCommand(spName, paramValues);
                var parameters = new DynamicParameters();
                int readIndex = 0;
                foreach (DbParameter param in cmd.Parameters)
                {
                    if (param.Direction == ParameterDirection.ReturnValue)
                        continue;

                    object value = GetDefaultValueQueryProp(paramValues[readIndex], param.DbType);
                    parameters.Add(param.ParameterName, value, param.DbType, param.Direction);
                    readIndex++;
                }
                DataSet ds = new DataSet();
                var results = Connection.ExecuteReader(spName, parameters, commandTimeout: 60, commandType: CommandType.StoredProcedure);
                readIndex = 0;
                do
                {
                    DataTable dr = new DataTable();
                    dr.TableName = string.Format("Table{0}", readIndex == 0 ? "" : readIndex.ToString());
                    dr.Load(results);
                    ds.Tables.Add(dr);
                    readIndex++;
                } while (!results.IsClosed);
                return ds;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public DataSet GetTimeOutDataSet(string spName, int timeout, params object[] paramValues)
        {
            try
            {
                DbCommand cmd = SqlDatabaseHelper.GetStoredProcCommand(spName, paramValues);
                var parameters = new DynamicParameters();
                int readIndex = 0;
                foreach (DbParameter param in cmd.Parameters)
                {
                    if (param.Direction == ParameterDirection.ReturnValue)
                        continue;

                    object value = GetDefaultValueQueryProp(paramValues[readIndex], param.DbType);
                    parameters.Add(param.ParameterName, value, param.DbType, param.Direction);
                    readIndex++;
                }
                DataSet ds = new DataSet();
                var results = Connection.ExecuteReader(spName, parameters, commandTimeout: timeout, commandType: CommandType.StoredProcedure);
                readIndex = 0;
                do
                {
                    DataTable dr = new DataTable();
                    dr.TableName = string.Format("Table{0}", readIndex == 0 ? "" : readIndex.ToString());
                    dr.Load(results);
                    ds.Tables.Add(dr);
                    readIndex++;
                } while (!results.IsClosed);
                return ds;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        /// <summary>
        /// Get Data Set By Query Command
        /// </summary>
        /// <param name="strQuery"></param>
        /// <returns></returns>
        public DataSet GetDataSet(String strQuery)
        {
            DbCommand cmd = SqlDatabaseHelper.GetQuery(strQuery);
            return SqlDatabaseHelper.RunQuery(cmd);
        }

        public DataSet GetDataSet(DbCommand cmd)
        {
            return SqlDatabaseHelper.RunStoredProcedure(cmd);
        }

        public virtual object GetTemplateObject()
        {
            String strSQL = String.Format("Select * From [dbo].[{0}] (NOLOCK) Where [{1}]='Template'", TableName, CommonColumn.AAStatus);
            DbCommand cmd = SqlDatabaseHelper.GetQuery(strSQL);
            DataSet ds = SqlDatabaseHelper.RunQuery(cmd);
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    object obj = SqlDatabaseHelper.GetSingleObject(ds.Tables[0], ObjectType);
                    BOSDisposeUtility.DisposeDataSet(ds, 0, GCCollectionMode.Forced);
                    return obj;
                }
            }
            return null;
        }

        public object GetDataObject(string spName, params object[] paramValues)
        {
            DataSet ds = SqlDatabaseHelper.RunStoredProcedure(spName, paramValues);
            object obj = GetSingleObject(ds.Tables[0]);
            BOSDisposeUtility.DisposeDataSet(ds, 0, GCCollectionMode.Forced);
            return obj;
        }

        /// <summary>
        /// Get single value from returned result by executing a stored procedure
        /// </summary>
        /// <param name="spName">Stored procedure name</param>
        /// <param name="paramValues">Parameters are passed in the stored procedure</param>
        /// <returns>Value</returns>
        public object GetSingleValue(string spName, params object[] paramValues)
        {
            DataSet ds = GetDataSet(spName, paramValues);
            if (ds == null)
                return null;

            object value = null;
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0][0] != DBNull.Value)
                {
                    value = ds.Tables[0].Rows[0][0];
                }
            }
            BOSDisposeUtility.DisposeDataSet(ds, 0, GCCollectionMode.Forced);
            return value;
        }

        public object GetSingleObject(DataTable dt)
        {
            return SqlDatabaseHelper.GetSingleObject(dt, ObjectType);
        }

        public object GetFirstObject()
        {
            DataSet ds = GetAllObject();
            object obj = GetSingleObject(ds.Tables[0]);
            BOSDisposeUtility.DisposeDataSet(ds, 0, GCCollectionMode.Forced);
            return obj;
        }

        public object GetObjectFromDataRow(DataRow row)
        {
            return SqlDatabaseHelper.GetObjectFromDataRow(row, ObjectType);
        }

        public DataSet GetNewObjectInSession(String strUserName)
        {
            return SqlDatabaseHelper.RunStoredProcedure(GenerateSelectNewObjectInSessionStoredProcedureName(), strUserName);
        }

        public void UpdateObjectSaveStatusInSession(String strUserName)
        {
            SqlDatabaseHelper.RunStoredProcedure(GenerateUpdateObjectSaveStatusInSessionStoredProcedureName(), strUserName);
        }

        public DataSet SearchObject(object objSearch)
        {
            DbCommand cmd = SqlDatabaseHelper.GetStoredProcedure(GenerateSearchObjectStoredProcedureName());
            SqlDatabaseHelper.AddParameterForSearchProperties(objSearch, cmd);
            return SqlDatabaseHelper.RunStoredProcedure(cmd);
        }

        public DataSet GetAllDataByForeignColumn(String strForeignColumnName, object objValue)
        {
            return SqlDatabaseHelper.RunStoredProcedure(GenerateSelectByForeignColumnStoredProcedureName(strForeignColumnName), objValue);

        }

        public virtual DataSet GetAllProfileObjects()
        {
            return SqlDatabaseHelper.RunStoredProcedure(GenerateSelectAllProfilesStoredProcedureName());
        }

        public virtual DataSet GetAllObject()
        {
            return SqlDatabaseHelper.RunStoredProcedure(GenerateSelectAllStoredProcedureName());
        }

        public virtual DataSet GetAllAliveObjects()
        {
            return SqlDatabaseHelper.RunStoredProcedure(GenerateSelectAllAlivesStoredProcedureName());
        }

        //public virtual DbTransaction CreateTransaction()
        //{
        //    return SqlDatabaseHelper.CreateTransaction();
        //}

        #endregion

        #region Function for get,delete all record From parent
        public DataSet GetAllObjectsByObjectParentID(int iObjectParentID)
        {
            String strPrimaryKey = SqlDatabaseHelper.GetPrimaryKeyColumn(TableName);
            String strParentObjectIDForeignKey = strPrimaryKey.Substring(0, strPrimaryKey.Length - 2) + "ParentID";
            String strQuery = String.Format("Select *, (select COUNT(*) from [{0}] (NOLOCK) tbl2 where tbl2.[{1}] = tbl1.[{3}] and tbl2.AAStatus = 'Alive') as TheNumberOfChild From [{0}] (NOLOCK) tbl1 Where AAStatus = 'Alive' And ([{1}]={2}) And ({2}>0)",
               TableName, strParentObjectIDForeignKey, iObjectParentID, strPrimaryKey);
            DbCommand cmd = SqlDatabaseHelper.GetQuery(strQuery);
            return (DataSet)SqlDatabaseHelper.RunQuery(cmd);
        }

        public void DeleteAllObjectsByObjectParentID(int iObjectParentID)
        {
            String strPrimaryKey = SqlDatabaseHelper.GetPrimaryKeyColumn(TableName);
            String strParentObjectIDForeignKey = strPrimaryKey.Substring(0, strPrimaryKey.Length - 2) + "ParentID";
            if (SqlDatabaseHelper.ColumnIsExistInTable(TableName, strParentObjectIDForeignKey))
            {
                //String strQuery = String.Format("Update [{0}] Set AAStatus = 'Delete' Where ([{1}]={2}) And ({2}>0)", TableName, strParentObjectIDForeignKey, iObjectParentID);
                String strQuery = String.Format("DECLARE @ID INT = {2} DECLARE @DeleteTable TABLE (DeleteID int) INSERT INTO @DeleteTable SELECT @ID DECLARE @temp TABLE (ID int) INSERT INTO @temp SELECT @ID " +
                    " WHILE((SELECT COUNT(1) FROM @temp) > 0) BEGIN INSERT INTO @DeleteTable SELECT [{3}] FROM [{0}]  WHERE AAStatus ='Alive' AND [{1}] IN (SELECT DeleteID FROM @DeleteTable)" +
                    " DELETE FROM @temp " +
                    " UPDATE [{0}] SET AAStatus ='Delete' WHERE [{3}] in(SELECT DeleteID FROM @DeleteTable) " +
                    " INSERT INTO @temp SELECT [{3}] FROM [{0}]  WHERE AAStatus ='Alive' AND [{1}] IN (SELECT DeleteID FROM @DeleteTable) " +
                    " END ", TableName, strParentObjectIDForeignKey, iObjectParentID, strPrimaryKey);
                DbCommand cmd = SqlDatabaseHelper.GetQuery(strQuery);
                SqlDatabaseHelper.RunQuery(cmd);
            }
        }
        #endregion

        #region Functions For Get,Delete Members From Owner and Switcher table
        public DataSet GetMembersFromOwner(String strOwnerTable, int iOwnerID, String strMemberTable, String strSwitcherTable)
        {
            String strOwnerPrimaryColumn = SqlDatabaseHelper.GetPrimaryKeyColumn(strOwnerTable);
            String strSwitcherPrimaryColumn = SqlDatabaseHelper.GetPrimaryKeyColumn(strSwitcherTable);
            String strMemberPrimaryColumn = SqlDatabaseHelper.GetPrimaryKeyColumn(strMemberTable);

            String strSwitcherQuery = String.Format(
                                    "Select [{0}] From [{1}] (NOLOCK) Where [{1}].[{2}] IN (Select [{2}] From [{3}] Where [{3}].[{2}]={4})",
                                    strMemberPrimaryColumn, strSwitcherTable,
                                    strOwnerPrimaryColumn, strOwnerTable, iOwnerID);
            String strMemberQuery = String.Format("Select * From [{0}] Where [{1}] IN ({2})",
                                                strMemberTable, strMemberPrimaryColumn, strSwitcherQuery);
            DbCommand cmd = SqlDatabaseHelper.GetQuery(strMemberQuery);
            return (DataSet)SqlDatabaseHelper.RunQuery(cmd);
        }

        public DataSet DeleteMembersFromOwner(String strOwnerTable, int iOwnerID, String strMemberTable, String strSwitcherTable)
        {
            String strOwnerPrimaryColumn = SqlDatabaseHelper.GetPrimaryKeyColumn(strOwnerTable);
            String strSwitcherPrimaryColumn = SqlDatabaseHelper.GetPrimaryKeyColumn(strSwitcherTable);
            String strMemberPrimaryColumn = SqlDatabaseHelper.GetPrimaryKeyColumn(strMemberTable);

            String strSwitcherQuery = String.Format(
                                    "Select [{0}] From [{1}] (NOLOCK) Where [{1}].[{2}] IN (Select [{2}] From [{3}] Where [{3}].[{2}]={4}))",
                                    strMemberPrimaryColumn, strSwitcherTable,
                                    strOwnerPrimaryColumn, strOwnerTable, iOwnerID);
            String strMemberQuery = String.Format("Detete From [{0}] Where [{1}] IN ({2})",
                                                strMemberTable, strMemberPrimaryColumn, strSwitcherQuery);
            DbCommand cmd = SqlDatabaseHelper.GetQuery(strMemberQuery);
            return (DataSet)SqlDatabaseHelper.RunQuery(cmd);
        }

        public void DeleteEntity<TEntity>(TEntity entity) where TEntity : class
        {
            var isList = false;

            var type = typeof(TEntity);

            if (type.IsArray)
            {
                isList = true;
                type = type.GetElementType();
            }
            else if (type.IsGenericType)
            {
                var typeInfo = type.GetTypeInfo();
                bool implementsGenericIEnumerableOrIsGenericIEnumerable =
                    typeInfo.ImplementedInterfaces.Any(ti => ti.IsGenericType && ti.GetGenericTypeDefinition() == typeof(IEnumerable<>)) ||
                    typeInfo.GetGenericTypeDefinition() == typeof(IEnumerable<>);

                if (implementsGenericIEnumerableOrIsGenericIEnumerable)
                {
                    isList = true;
                    type = type.GetGenericArguments()[0];
                }
            }
            string userName = BysGateway.CurrentUsersInfo.ADUserName;
            DateTime dateNow = DateTime.Now;
            bool isValidObjectStatus = false;
            if (isList)
            {
                IEnumerable list = (IEnumerable)entity;
                foreach (var item in list)
                {
                    var objectStatus = item.GetType().GetProperty(CommonColumn.AAStatus);
                    if (objectStatus != null)
                    {
                        isValidObjectStatus = true;
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
            else
            {
                PropertyInfo property = type.GetProperty(CommonColumn.AAStatus);
                var objectStatus = type.GetProperty(CommonColumn.AAStatus);
                if (objectStatus != null)
                {
                    isValidObjectStatus = true;
                    objectStatus.SetValue(entity, ObjectStatus.Delete, null);
                }
                var updatedDateProperty = type.GetProperty(CommonColumn.AAUpdatedUser);
                if (updatedDateProperty != null)
                    updatedDateProperty.SetValue(entity, userName, null);

                var updatedUserProperty = type.GetProperty(CommonColumn.AAUpdatedDate);
                if (updatedUserProperty != null)
                    updatedUserProperty.SetValue(entity, dateNow, null);
            }

            if (isValidObjectStatus)
                Connection.BulkUpdate(entity);
            else
                Connection.BulkDelete(entity);
        }
        #endregion
    }
}

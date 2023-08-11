using BOSCommon.Enums;
using BOSCommon.Extensions;
using BOSLib.Entities;
using BOSLib.Extensions;
using Dapper;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Z.Dapper.Plus;

namespace BOSLib
{
    /// <summary>
    /// Summary description for Class1.
    /// </summary>
    /// <summary>
    /// Summary description for DatabaseHelper.
    /// </summary>
    public class SqlDatabaseHelper
    {
        private static BysSqlDatabase Database { get; set; }

        public static string ConnectionString { get; set; }

        public static IDbConnection Connection => Database.Connection;

        private static IDbTransaction _transaction;

        public static IDbTransaction Transaction
        {
            get => GetTransaction();
            set { _transaction = value; }
        }

        #region "Constructor"
        static SqlDatabaseHelper()
        {
            try
            {
                ConnectionString = GetConnectionStringFromRegistry();
                if (ConnectionString.IsNullOrWhiteSpace())
                    ConnectionString = GetConnectionStringFromConfig();

                Database = new BysSqlDatabase(ConnectionString);
                InitCommonData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static void InitCommonData()
        {
            string sqlQuery = @"
                SELECT 
	                col.TABLE_CATALOG AS [Database],
                    col.TABLE_SCHEMA AS Owner,
                    col.TABLE_NAME AS TableName,
                    col.COLUMN_NAME AS ColumnName,
                    col.ORDINAL_POSITION AS OrdinalPosition,
                    col.COLUMN_DEFAULT AS DefaultSetting,
                    col.DATA_TYPE AS DataType,
                    col.CHARACTER_MAXIMUM_LENGTH AS [MaxLength],
                    col.DATETIME_PRECISION AS DatePrecision,
                    col.NUMERIC_PRECISION AS NumberPrecision,
                    col.NUMERIC_SCALE AS NumberScale,
                    CAST(CASE 
			                WHEN col.IS_NULLABLE = 'NO' THEN 0
                            ELSE 1
                         END AS BIT) AS IsNullable,
                    COLUMNPROPERTY(OBJECT_ID('[' + col.TABLE_SCHEMA + '].[' + col.TABLE_NAME + ']'), col.COLUMN_NAME, 'IsIdentity') AS IsIdentity,
                    COLUMNPROPERTY(OBJECT_ID('[' + col.TABLE_SCHEMA + '].[' + col.TABLE_NAME + ']'), col.COLUMN_NAME, 'IsComputed') AS IsComputed,
                    CAST(ISNULL(pk.is_primary_key, 0) AS BIT) AS IsPrimaryKey
                FROM INFORMATION_SCHEMA.COLUMNS AS col
                    LEFT JOIN
                    (
                        SELECT SCHEMA_NAME(o.schema_id) AS TABLE_SCHEMA,
                               o.name AS TABLE_NAME,
                               c.name AS COLUMN_NAME,
                               i.is_primary_key
                        FROM sys.indexes AS i
                            JOIN sys.index_columns AS ic
                                ON i.object_id = ic.object_id
                                   AND i.index_id = ic.index_id
                            JOIN sys.objects AS o
                                ON i.object_id = o.object_id
                            LEFT JOIN sys.columns AS c
                                ON ic.object_id = c.object_id
                                   AND c.column_id = ic.column_id
                        WHERE i.is_primary_key = 1
                    ) AS pk ON col.TABLE_NAME = pk.TABLE_NAME
                        AND col.TABLE_SCHEMA = pk.TABLE_SCHEMA
                        AND col.COLUMN_NAME = pk.COLUMN_NAME
                ORDER BY col.TABLE_NAME,
	                col.ORDINAL_POSITION;
            ";
            BysGateway.TableColumns = Connection.Query<BysTableColumn>(sqlQuery).ToList();
            BysGateway.Tables = BysGateway.TableColumns?.Select(o => new { o.Owner, o.TableName })?.Distinct()?.Select(o => new BysTable() { Owner = o.Owner, Name = o.TableName })?.ToList();
            sqlQuery = @"
                SELECT 
	                SCHEMA_NAME(fk_tab.schema_id) AS ForeignSchemaName
	                , fk_tab.name  AS ForeignTableName
	                , cst.fk_name AS ForeignColumnName
	                , SCHEMA_NAME(pk_tab.schema_id) AS PrimarySchemaName
	                , pk_tab.name  AS PrimaryTableName
	                , cst.pk_name AS PrimaryColumnName
                    , fk.name AS ConstraintName
                FROM sys.foreign_keys fk
                    INNER JOIN sys.tables fk_tab
                        ON fk_tab.object_id = fk.parent_object_id
                    INNER JOIN sys.tables pk_tab
                        ON pk_tab.object_id = fk.referenced_object_id
                    CROSS APPLY
	                (
		                SELECT 
			                fk_col.name  AS fk_name
			                , pk_col.name  AS pk_name
		                FROM sys.foreign_key_columns fk_cst
			                INNER JOIN sys.columns fk_col ON fk_cst.parent_object_id = fk_col.object_id AND fk_cst.parent_column_id = fk_col.column_id
			                INNER JOIN sys.columns pk_col ON fk_cst.referenced_object_id = pk_col.object_id AND fk_cst.referenced_column_id = pk_col.column_id
		                WHERE fk_cst.parent_object_id = fk_tab.object_id
			                  AND fk_cst.constraint_object_id = fk.object_id
	                ) AS cst 
                ORDER BY SCHEMA_NAME(fk_tab.schema_id) + '.' + fk_tab.name,
                         SCHEMA_NAME(pk_tab.schema_id) + '.' + pk_tab.name
            ";
            BysGateway.TableConstraints = Connection.Query<BysTableConstraint>(sqlQuery).ToList();
            sqlQuery = @"
                SELECT 
	                DISTINCT
	                DB_NAME() AS [Database],
	                SCHEMA_NAME(tb.schema_id) AS [Owner],
	                tb.name AS TableName,
	                col.name AS ColumnName,
	                COLUMNPROPERTY(col.object_id, col.name, 'ordinal') AS OrdinalPosition,
                    convert(nvarchar(4000),
		                OBJECT_DEFINITION(col.default_object_id)) AS DefaultSetting,
                    ISNULL(TYPE_NAME(col.system_type_id), tb.name)	 AS DataType,
                    COLUMNPROPERTY(col.object_id, col.name, 'charmaxlen') AS [MaxLength],
                    convert(smallint, CASE -- datetime/smalldatetime
		                WHEN col.system_type_id IN (40, 41, 42, 43, 58, 61) THEN ODBCSCALE(col.system_type_id, col.scale) END) AS DatePrecision,
                    convert(tinyint, CASE -- int/decimal/numeric/real/float/money
		                WHEN col.system_type_id IN (48, 52, 56, 59, 60, 62, 106, 108, 122, 127) THEN col.precision
		                END) AS NumberPrecision,
                    convert(int, CASE	-- datetime/smalldatetime
		                WHEN col.system_type_id IN (40, 41, 42, 43, 58, 61) THEN NULL
		                ELSE ODBCSCALE(col.system_type_id, col.scale) END) AS NumberScale,
                    col.is_nullable AS IsNullable,
	                COLUMNPROPERTY(OBJECT_ID('[' + SCHEMA_NAME(tb.schema_id) + '].[' + tb.name + ']'), col.name, 'IsIdentity') AS IsIdentity,
                    COLUMNPROPERTY(OBJECT_ID('[' + SCHEMA_NAME(tb.schema_id) + '].[' + tb.name + ']'), col.name, 'IsComputed') AS IsComputed,
                    CAST(ISNULL(pk.is_primary_key, 0) AS BIT) AS IsPrimaryKey
                FROM SYS.table_types tb
	                JOIN sys.columns col ON col.object_id = tb.type_table_object_id
	                LEFT JOIN
	                (
                        SELECT SCHEMA_NAME(o.schema_id) AS TABLE_SCHEMA,
                                o.name AS TABLE_NAME,
                                c.name AS COLUMN_NAME,
                                i.is_primary_key
                        FROM sys.indexes AS i
                            JOIN sys.index_columns AS ic
                                ON i.object_id = ic.object_id
                                    AND i.index_id = ic.index_id
                            JOIN sys.objects AS o
                                ON i.object_id = o.object_id
                            LEFT JOIN sys.columns AS c
                                ON ic.object_id = c.object_id
                                    AND c.column_id = ic.column_id
                        WHERE i.is_primary_key = 1
                    ) AS pk ON tb.NAME = pk.TABLE_NAME
                        AND SCHEMA_NAME(tb.schema_id) = pk.TABLE_SCHEMA
                        AND col.name = pk.COLUMN_NAME";
            BysGateway.DefinedTypeColumns = Connection.Query<BysTableColumn>(sqlQuery).ToList();
        }

        private static IDbTransaction GetTransaction()
        {
            return _transaction?.Connection == null ? null : _transaction;
        }

        private static string GetConnectionStringFromConfig()
        {
            string connectionString = string.Empty;
            Crypto cryp = new Crypto();
            string serverName = ConfigurationManager.AppSettings["ServerName"];
            string databaseName = ConfigurationManager.AppSettings["DatabaseName"];
            string userID = cryp.DecryptNew(ConfigurationManager.AppSettings["UserID"], true);
            string password = cryp.DecryptNew(ConfigurationManager.AppSettings["Password"], true);
            if (serverName.IsNullOrWhiteSpace() || databaseName.IsNullOrWhiteSpace() || userID.IsNullOrWhiteSpace() || password.IsNullOrWhiteSpace())
            {
                connectionString = ConfigurationManager.AppSettings.Get("ConnectionString");
                SqlConnectionStringBuilder connBuilder = new SqlConnectionStringBuilder(connectionString);
                serverName = connBuilder.DataSource;
                databaseName = connBuilder.InitialCatalog;
                userID = cryp.DecryptNew(connBuilder.UserID, true);
                password = cryp.DecryptNew(connBuilder.Password, true);
            }
            return string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3}", serverName, databaseName, userID, password);
        }

        public enum SaveActionType
        {
            Create, Update, Delete, DeleteWithList
        }
        public static void SaveItemObject(DataTable dt, int mainObjectID, string tableName, string actionType, string UserName)
        {
            var cmd = new SqlCommand();
            if (actionType == "Create")
            {
                cmd.CommandText = "Create" + "_" + tableName;
            }
            else if (actionType == "Update")
            {
                cmd.CommandText = "Update" + "_" + tableName;
            }
            else if (actionType == "Delete")
            {
                cmd.CommandText = "Delete" + "_" + tableName;
            }

            cmd.CommandType = CommandType.StoredProcedure;

            if (actionType != "Delete")
            {
                var param = new SqlParameter();
                param.ParameterName = "@" + tableName;
                param.SqlDbType = SqlDbType.Structured;
                cmd.Parameters.Add(param);
            }

            var param2 = new SqlParameter();
            param2.ParameterName = "@UserName";
            param2.SqlDbType = SqlDbType.NVarChar;
            cmd.Parameters.Add(param2);

            var param3 = new SqlParameter();
            param3.ParameterName = "@MainObjectID";
            param3.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(param3);

            if (actionType != "Delete")
            {
                cmd.Parameters["@" + tableName].Value = dt;
            }
            cmd.Parameters["@UserName"].Value = UserName;
            cmd.Parameters["@MainObjectID"].Value = mainObjectID;
            Database.ExecuteNonQuery(cmd);
        }
        public static void UpdateItemObject(DataTable dt, int mainObjectID, string tableName, string store, string UserName)
        {
            var cmd = new SqlCommand();
            cmd.CommandText = store;

            cmd.CommandType = CommandType.StoredProcedure;

            var param = new SqlParameter();
            param.ParameterName = "@" + tableName;
            param.SqlDbType = SqlDbType.Structured;
            cmd.Parameters.Add(param);

            var param2 = new SqlParameter();
            param2.ParameterName = "@UserName";
            param2.SqlDbType = SqlDbType.NVarChar;
            cmd.Parameters.Add(param2);

            var param3 = new SqlParameter();
            param3.ParameterName = "@MainObjectID";
            param3.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(param3);

            cmd.Parameters["@" + tableName].Value = dt;
            cmd.Parameters["@UserName"].Value = UserName;
            cmd.Parameters["@MainObjectID"].Value = mainObjectID;
            Database.ExecuteNonQuery(cmd);
        }
        public static void SaveItemObjectOverTimeOut(DataTable dt, int mainObjectID, string tableName, string actionType, string UserName)
        {
            var cmd = new SqlCommand();
            if (actionType == "Create")
            {
                cmd.CommandText = "Create" + "_" + tableName;
            }
            else if (actionType == "Update")
            {
                cmd.CommandText = "Update" + "_" + tableName;
            }
            else if (actionType == "Delete")
            {
                cmd.CommandText = "Delete" + "_" + tableName;
            }


            cmd.CommandType = CommandType.StoredProcedure;

            if (actionType != "Delete")
            {
                var param = new SqlParameter();
                param.ParameterName = "@" + tableName;
                param.SqlDbType = SqlDbType.Structured;
                cmd.Parameters.Add(param);
            }

            var param2 = new SqlParameter();
            param2.ParameterName = "@UserName";
            param2.SqlDbType = SqlDbType.NVarChar;
            cmd.Parameters.Add(param2);

            var param3 = new SqlParameter();
            param3.ParameterName = "@MainObjectID";
            param3.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(param3);

            if (actionType != "Delete")
            {
                cmd.Parameters["@" + tableName].Value = dt;
            }
            cmd.Parameters["@UserName"].Value = UserName;
            cmd.Parameters["@MainObjectID"].Value = mainObjectID;
            cmd.CommandTimeout = 9999;
            Database.ExecuteNonQuery(cmd);
        }
        public static DataSet GetDataUsingStringType(DataTable dt, string typeName, string storedProcedureName)
        {
            var cmd = new SqlCommand();
            cmd.CommandText = storedProcedureName;
            cmd.CommandType = CommandType.StoredProcedure;
            var param = new SqlParameter();
            param.ParameterName = "@" + typeName;
            param.SqlDbType = SqlDbType.Structured;
            cmd.Parameters.Add(param);
            cmd.Parameters["@" + typeName].Value = dt;
            return Database.ExecuteDataSet(cmd);
        }

        public static void DeleteItemObject(DataTable dt, string tableName, string UserName)
        {
            var cmd = new SqlCommand();

            cmd.CommandText = SaveActionType.DeleteWithList.ToString() + "_" + tableName;
            cmd.CommandType = CommandType.StoredProcedure;
            var param = new SqlParameter();
            param.ParameterName = "@" + tableName;
            param.SqlDbType = SqlDbType.Structured;
            cmd.Parameters.Add(param);
            var param2 = new SqlParameter();
            param2.ParameterName = "@UserName";
            param2.SqlDbType = SqlDbType.NVarChar;
            cmd.Parameters.Add(param2);
            cmd.Parameters["@" + tableName].Value = dt;

            cmd.Parameters["@UserName"].Value = UserName;
            Database.ExecuteNonQuery(cmd);
        }

        public static void DeleteItemObjectOverTimeOut(DataTable dt, string tableName, string UserName)
        {
            var cmd = new SqlCommand();

            cmd.CommandText = SaveActionType.DeleteWithList.ToString() + "_" + tableName;
            cmd.CommandType = CommandType.StoredProcedure;
            var param = new SqlParameter();
            param.ParameterName = "@" + tableName;
            param.SqlDbType = SqlDbType.Structured;
            cmd.Parameters.Add(param);
            var param2 = new SqlParameter();
            param2.ParameterName = "@UserName";
            param2.SqlDbType = SqlDbType.NVarChar;
            cmd.Parameters.Add(param2);
            cmd.Parameters["@" + tableName].Value = dt;

            cmd.Parameters["@UserName"].Value = UserName;
            cmd.CommandTimeout = 9999;
            Database.ExecuteNonQuery(cmd);
        }

        public static String GetConnectionStringFromRegistry()
        {
            String result;

            RegistryWorker regW = new RegistryWorker();
            regW.SubKey = "SOFTWARE\\BYS";
            regW.SubKey = regW.SubKey + "\\ConnectionString";
            String strDatabase = regW.Read("Database");
            String strServer = regW.Read("Server");
            String strUser = regW.Read("User");
            string strPassword = regW.Read("Password");

            if (!String.IsNullOrEmpty(strServer))
            {
                Crypto cryp = new Crypto();
                strPassword = cryp.Decrypt(strPassword);
                result = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3}", strServer, strDatabase, strUser, strPassword);
                return result;
            }
            return String.Empty;
        }

        public static void SwitchConnection(String strConnectionString)
        {
            Database = new BysSqlDatabase(strConnectionString);
        }

        public static void RollbackToLocalConnection()
        {
            Database = new BysSqlDatabase(ConnectionString);
        }

        public static BysSqlDatabase CreateConnection(string connectionString)
        {
            return new BysSqlDatabase(connectionString);
        }
        #endregion

        #region "Get Object Functions"
        public static object GetSingleObject(DataTable dt, Type type)
        {
            try
            {
                if (dt.Rows.Count <= 0)
                    return null;
                object obj = GetObjectFromDataRow(dt.Rows[0], type);
                return obj;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static object GetObjectFromDataRow(DataRow row, Type type)
        {
            object obj = type.InvokeMember("", System.Reflection.BindingFlags.CreateInstance, null, null, null);
            PropertyInfo[] allProperties = obj.GetType().GetProperties();
            Dictionary<string, PropertyInfo> columnProps = type.GetColumnAttributes();
            foreach (DataColumn column in row.Table.Columns)
            {
                object objValue = row[column];
                if (objValue != System.DBNull.Value)
                {
                    PropertyInfo property = obj.GetType().GetProperty(column.ColumnName);
                    if (property == null)
                        columnProps.TryGetValue(column.ColumnName, out property);

                    if (property != null)
                        property.SetValue(obj, objValue, null);
                }
            }
            return obj;
        }

        public static void SetValueToPrimaryColumn(object obj, DALBaseProvider provider, int iObjectID)
        {
            string strPrimaryKeyColumn = GetPrimaryKeyColumn(provider.TableName);
            Type objType = obj.GetType();
            Dictionary<string, PropertyInfo> columnProps = obj.GetColumnAttributes();
            PropertyInfo property = objType.GetProperty(strPrimaryKeyColumn);
            if (property == null)
                columnProps.TryGetValue(strPrimaryKeyColumn, out property);
            if (property != null)
                property.SetValue(obj, iObjectID, null);
        }

        public static void SetValueToIDStringColumn(object obj, DALBaseProvider provider, int iObjectID)
        {
            string strPrimaryKeyColumn = GetPrimaryKeyColumn(provider.TableName);
            Type objType = obj.GetType();
            Dictionary<string, PropertyInfo> columnProps = obj.GetColumnAttributes();
            PropertyInfo property = objType.GetProperty(strPrimaryKeyColumn + "String");
            if (property == null)
                columnProps.TryGetValue(strPrimaryKeyColumn, out property);
            if (property != null)
                property.SetValue(obj, iObjectID.ToString(), null);
        }

        public static object GetPrimaryColumnValue(object obj, DALBaseProvider provider)
        {
            string strPrimaryKeyColumn = GetPrimaryKeyColumn(provider.TableName);
            Type objType = obj.GetType();
            Dictionary<string, PropertyInfo> columnProps = obj.GetColumnAttributes();
            PropertyInfo property = objType.GetProperty(strPrimaryKeyColumn);
            if (property == null)
                columnProps.TryGetValue(strPrimaryKeyColumn, out property);
            if (property == null)
                return default;
            object objValue = property.GetValue(obj, null);
            return objValue;
        }

        #endregion

        #region Table,Column,Query Helpers
        public static string GetPrimaryKeyColumn(string strTableName)
        {
            return BysGateway.TableColumns.Where(o => o.TableName == strTableName && o.IsPrimaryKey).Select(o => o.ColumnName).FirstOrDefault() ?? string.Empty;
        }

        public static string GetPrimaryTableWhichForeignColumnReferenceTo(String strForeignTableName, String strForeignColumnName)
        {
            return BysGateway.TableConstraints.Where(o => o.ForeignTableName == strForeignTableName && o.ForeignColumnName == strForeignColumnName).Select(o => o.PrimaryTableName).FirstOrDefault() ?? string.Empty;
        }

        public static DataSet GetTableColumn(String strTableName, String strColumnName)
        {
            String strQuery = String.Format("SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{0}' AND COLUMN_NAME = '{1}'", strTableName, strColumnName);
            DbCommand cmd = GetQuery(strQuery);
            return RunQuery(cmd);
        }

        public static List<BysTableColumn> GetTableColumn(string strTableName)
        {
            return BysGateway.TableColumns.Where(o => o.TableName == strTableName).ToList();
        }

        public static bool ColumnIsExistInTable(string strTableName, string strColumnName)
        {
            DataSet ds = GetTableColumn(strTableName, strColumnName);
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    BOSDisposeUtility.DisposeDataSet(ds, 0, GCCollectionMode.Forced);
                    return true;
                }
            }
            BOSDisposeUtility.DisposeDataSet(ds, 0, GCCollectionMode.Forced);
            return false;
        }

        public static String GetQueryCommandByTableNameAndTableQueryKey(String strTableName, String strTableQueryKey)
        {
            String strQueryCommand = String.Empty;
            DbCommand cmd = SqlDatabaseHelper.GetQuery(String.Format("SELECT * FROM [dbo].[STTableQueries] WHERE ([STTableQueryTableName]='{0}')AND([STTableQueryKey]='{1}')", strTableName, strTableQueryKey));
            DataSet ds = SqlDatabaseHelper.RunQuery(cmd);
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    strQueryCommand = ds.Tables[0].Rows[0]["STTableQueryCommand"].ToString();
                }
            }
            BOSDisposeUtility.DisposeDataSet(ds, 0, GCCollectionMode.Forced);
            return strQueryCommand;
        }

        public static void InsertQueryCommand(String strQueryCommand, String strTableName, String strQueryKey)
        {
            String strCommand = String.Format("INSERT INTO [dbo].[STTableQueries] ([STTableQueryID],[STTableQueryTableName],[STTableQueryKey],[STTableQueryCommand]) VALUES({0},'{1}','{2}','{3}')", GetMaxID("STTableQueries") + 1, strTableName, strQueryKey, strQueryCommand);
            DbCommand cmd = GetQuery(strCommand);
            Database.ExecuteNonQuery(cmd);
        }
        #endregion

        #region "Add Parameter Functions"
        public static int GetMaxID(string tableName)
        {
            int MaxID = 0;
            String sqlCommand = String.Format("SELECT Max({0}) AS MaxID FROM [{1}]", GetPrimaryKeyColumn(tableName), tableName);
            DbCommand cmd = Database.GetSqlStringCommand(sqlCommand);
            DataSet ds = Database.ExecuteDataSet(cmd);
            if (ds.Tables.Count > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];
                if (row[0].ToString() != "")
                    MaxID = (int)row[0];
            }
            BOSDisposeUtility.DisposeDataSet(ds, 0, GCCollectionMode.Forced);
            return MaxID;
        }

        public static void AddInParameter(DbCommand cmd, string name, SqlDbType type, Object objValue)
        {
            Database.AddInParameter(cmd, name, type, objValue);
        }

        public static void AddParameter(DbCommand cmd, string name, DbType type, ParameterDirection direction, object value)
        {
            SqlParameter param = new SqlParameter(name, value);
            param.DbType = type;
            param.Direction = direction;
            cmd.Parameters.Add(param);
        }

        public static void AddParameterForObject(object obj, DALBaseProvider provider, DbCommand cmd)
        {
            try
            {
                List<BysTableColumn> columns = BysGateway.TableColumns.Where(o => o.TableName == provider.TableName).ToList();
                System.Reflection.PropertyInfo[] properties = provider.ObjectType.GetProperties();
                Dictionary<string, PropertyInfo> columnProps = obj.GetColumnAttributes();
                columns.ForEach(o =>
                {
                    PropertyInfo propertyInfo = null;
                    columnProps.TryGetValue(o.ColumnName, out propertyInfo);
                    if (propertyInfo == null)
                        propertyInfo = properties.Where(f => f.Name == o.ColumnName).FirstOrDefault();

                    if (propertyInfo == null)
                        return;

                    object objValue = propertyInfo.GetValue(obj, null);
                    if (propertyInfo.PropertyType.Equals(typeof(Int32)))
                    {
                        if (o.IsPrimaryKey && cmd.CommandText.Contains("_Insert"))
                        {
                            Database.AddOutParameter(cmd, o.ColumnName, SqlDbType.Int, sizeof(int));
                        }
                        else
                            Database.AddInParameter(cmd, o.ColumnName, SqlDbType.Int, objValue);
                    }
                    else if (propertyInfo.PropertyType.Equals(typeof(Boolean)))
                        Database.AddInParameter(cmd, o.ColumnName, SqlDbType.Bit, objValue);
                    else if (propertyInfo.PropertyType.Equals(typeof(short)))
                        Database.AddInParameter(cmd, o.ColumnName, SqlDbType.SmallInt, objValue);
                    else if (propertyInfo.PropertyType.Equals(typeof(byte)))
                        Database.AddInParameter(cmd, o.ColumnName, SqlDbType.TinyInt, objValue);
                    else if (propertyInfo.PropertyType.Equals(typeof(double)))
                    {
                        if (double.IsInfinity((double)objValue))
                        {
                            objValue = 0.0;
                        }
                        Database.AddInParameter(cmd, o.ColumnName, SqlDbType.Float, objValue);
                    }
                    else if (propertyInfo.PropertyType.Equals(typeof(decimal)))
                    {
                        Database.AddParameter(cmd, o.ColumnName, DbType.Decimal, 24, ParameterDirection.Input, true, 18, 5, o.ColumnName, DataRowVersion.Default, objValue);
                    }
                    else if ((propertyInfo.PropertyType.Equals(typeof(String))) || (propertyInfo.PropertyType.Equals(typeof(string))))
                        Database.AddInParameter(cmd, o.ColumnName, SqlDbType.NVarChar, objValue);
                    else if (propertyInfo.PropertyType.Equals(typeof(DateTime)))
                    {
                        if ((DateTime)objValue == DateTime.MinValue)
                        {
                            objValue = DateTime.MaxValue;
                        }
                        Database.AddInParameter(cmd, o.ColumnName, SqlDbType.DateTime, objValue);
                    }
                    else if (propertyInfo.PropertyType.Equals(typeof(byte[])))
                    {
                        Database.AddInParameter(cmd, o.ColumnName, SqlDbType.VarBinary, objValue);
                    }
                });
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void AddParameterForSearchProperties(object obj, DbCommand cmd)
        {
            PropertyInfo[] searchProperties = obj.GetType().GetProperties();
            for (int i = 0; i < searchProperties.Length; i++)
            {
                object objValue = searchProperties[i].GetValue(obj, null);
                String strParamName = searchProperties[i].Name;
                if (searchProperties[i].Name.Equals("TopResults"))
                {
                    Database.AddInParameter(cmd, strParamName, SqlDbType.Int, objValue);
                }
                else
                {
                    if (searchProperties[i].PropertyType.Equals(typeof(Int32)))
                    {
                        Database.AddInParameter(cmd, searchProperties[i].Name, SqlDbType.Int, objValue);

                    }
                    else if (searchProperties[i].PropertyType.Equals(typeof(Boolean)))
                        Database.AddInParameter(cmd, searchProperties[i].Name, SqlDbType.Bit, objValue);
                    else if (searchProperties[i].PropertyType.Equals(typeof(short)))
                        Database.AddInParameter(cmd, searchProperties[i].Name, SqlDbType.SmallInt, objValue);
                    else if (searchProperties[i].PropertyType.Equals(typeof(double)))
                        Database.AddInParameter(cmd, searchProperties[i].Name, SqlDbType.Float, objValue);
                    else if (searchProperties[i].PropertyType.Equals(typeof(decimal)))
                    {
                        //Database.AddInParameter(cmd, searchProperties[i].Name, SqlDbType.Decimal, objValue);
                        SqlParameter parameterIn = new SqlParameter(searchProperties[i].Name, SqlDbType.Decimal);
                        parameterIn.Precision = 18;
                        parameterIn.Scale = 5;
                        parameterIn.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(parameterIn);
                    }
                    else if ((searchProperties[i].PropertyType.Equals(typeof(String))) || (searchProperties[i].PropertyType.Equals(typeof(string))))
                        Database.AddInParameter(cmd, searchProperties[i].Name, SqlDbType.NVarChar, objValue);
                    else if (searchProperties[i].PropertyType.Equals(typeof(DateTime)))
                    {
                        if ((DateTime)objValue == DateTime.MinValue)
                            continue;
                        Database.AddInParameter(cmd, searchProperties[i].Name, SqlDbType.DateTime, objValue);
                    }
                    else if (searchProperties[i].PropertyType.Equals(typeof(byte[])))
                    {
                        Database.AddInParameter(cmd, searchProperties[i].Name, SqlDbType.VarBinary, objValue);
                    }
                }
            }
        }
        #endregion

        #region "Excute Store Procedured Functions"

        public static int InsertObject(object obj, DALBaseProvider provider, string spName)
        {
            try
            {
                DbCommand cmd = Database.GetStoredProcCommand(spName);
                AddParameterForObject(obj, provider, cmd);

                Database.ExecuteNonQuery(cmd);
                int ret = (int)Database.GetParameterValue(cmd, GetPrimaryKeyColumn(provider.TableName));
                return ret;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void Insert<T>(T entity) where T : class
        {
            Connection.BulkInsert(entity);
        }

        public static int InsertObject(object obj, DALBaseProvider provider, string spName, DbTransaction transaction)
        {
            try
            {
                //Prepare Command to excute with transaction
                DbCommand cmd = Database.GetStoredProcCommand(spName);
                AddParameterForObject(obj, provider, cmd);
                cmd.Transaction = transaction;

                //Excute command and commit if have not any exception
                Database.ExecuteNonQuery(cmd, transaction);
                transaction.Commit();

                //return value
                int ret = (int)Database.GetParameterValue(cmd, GetPrimaryKeyColumn(provider.TableName));
                return ret;

            }
            catch (Exception e)
            {
                transaction.Rollback();
                throw e;
            }
        }

        //public static DataSet RunStoredProcedure(string spName)
        //{
        //    DbCommand cmd = Database.GetStoredProcCommand(spName);
        //    return Database.ExecuteDataSet(cmd);
        //}

        //public static DataSet RunStoredProcedure(DbCommand cmd)
        //{
        //    try
        //    {
        //        return Database.ExecuteDataSet(cmd);
        //    }
        //    catch (SqlException e)
        //    {
        //        throw e;
        //    }
        //}

        public static DataSet RunStoredProcedure(string spName)
        {
            DbCommand cmd = Database.GetStoredProcCommand(spName);
            return Database.ExecuteDataSet(cmd);
        }

        public static DataSet RunStoredProcedure(DbCommand cmd)
        {
            try
            {
                return Database.ExecuteDataSet(cmd);
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        public static DataSet RunStoredProcedure(string spName, params object[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                object value = values[i];
                if (value != null)
                {
                    if (value.GetType() != typeof(bool))
                    {
                        if (value.Equals(0) || value.Equals(string.Empty))
                        {
                            values[i] = null;
                        }
                    }
                }
            }
            return Database.ExecuteDataSet(spName, values);
        }

        public static DataSet RunStoredProcedure(SqlDatabase database, string spName, params object[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                object value = values[i];
                if (value != null)
                {
                    if (value.GetType() != typeof(bool))
                    {
                        if (value.Equals(0) || value.Equals(string.Empty))
                        {
                            values[i] = null;
                        }
                    }
                }
            }
            return Database.ExecuteDataSet(spName, values);
        }

        public static DbCommand GetStoredProcedure(string spName)
        {
            return Database.GetStoredProcCommand(spName);
        }

        public static object RunStoreProcedure(DbCommand cmd, string retVariable)
        {
            Database.ExecuteNonQuery(cmd);
            return (object)Database.GetParameterValue(cmd, retVariable);
        }

        public static void ExecuteNonQuery(String spName, params object[] values)
        {
            DbCommand cmd = Database.GetStoredProcCommand(spName, values);
            cmd.CommandTimeout = 9999;
            Database.ExecuteNonQuery(cmd);
        }

        public static void ExecuteNonQuery(Database database, String spName, params object[] values)
        {
            Database.ExecuteNonQuery(spName, values);
        }

        public static bool TestConnection()
        {
            return SqlDatabaseHelper.TestConnection(Database);
        }

        public static bool TestConnection(SqlDatabase database)
        {
            try
            {
                String strTestQuery = "Select * From [CSCompanys]";
                DbCommand cmd = Database.GetSqlStringCommand(strTestQuery);
                Database.ExecuteDataSet(cmd);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        #endregion

        #region Transaction Functions
        public static DbTransaction BeginTransaction()
        {
            _transaction = Connection.BeginTransaction(IsolationLevel.Serializable);
            return (DbTransaction)_transaction;
        }

        public static void CommitTransaction()
        {
            _transaction?.Commit();
        }

        public static void RollbackTransaction()
        {
            _transaction?.Rollback();
            _transaction?.Dispose();
        }
        #endregion

        #region "Execute Query String"
        public static DbCommand GetQuery(String strQueryCommand)
        {
            return Database.GetSqlStringCommand(strQueryCommand);
        }

        public static DbCommand GetStoredProcCommand(String strQueryCommand, params object[] paramValues)
        {
            return Database.GetStoredProcCommand(strQueryCommand, paramValues);
        }

        public static DbCommand GetQuery(String strTableName, String strTableQueryKey, String strQueryCommand)
        {
            String strCommandFromDB = GetQueryCommandByTableNameAndTableQueryKey(strTableName, strTableQueryKey);
            if (String.IsNullOrEmpty(strCommandFromDB))
            {
                InsertQueryCommand(strQueryCommand, strTableName, strTableQueryKey);
                return Database.GetSqlStringCommand(strQueryCommand);
            }
            else
            {
                return Database.GetSqlStringCommand(strCommandFromDB);
            }
        }

        private static string GetWhereClause(string strQueryCommand)
        {
            if (strQueryCommand.Contains("WHERE"))
            {
                return strQueryCommand.Substring(strQueryCommand.IndexOf("WHERE"));
            }
            else
                return string.Empty;
        }


        public static string[] GetParameters(string strQueryCommand)
        {
            string[] parameters = new string[0];
            string strWhereClause = GetWhereClause(strQueryCommand);
            if (!string.IsNullOrEmpty(strWhereClause))
            {
                do
                {
                    strWhereClause = strWhereClause.Substring(strWhereClause.IndexOf("@"));
                    string strParameter = strWhereClause.Substring(1, strWhereClause.IndexOf(")") - 1);
                    //string strParameter=strWhereClause.Substring(strWhereClause.IndexOf("@"),
                    Array.Resize(ref parameters, parameters.Length + 1);
                    parameters[parameters.Length - 1] = strParameter;
                    strWhereClause = strWhereClause.Substring(strParameter.Length + 1);
                    if (strWhereClause.StartsWith(")"))
                        strWhereClause = strWhereClause.Substring(1);
                } while (strWhereClause.Contains("@"));

                return parameters;
            }
            else
                return null;
        }

        public static DataSet RunQuery(string strTableName, string strQueryCommandKey, string strQueryCommand, params object[] paramValues)
        {
            DbCommand cmd = GetQuery(strTableName, strQueryCommandKey, strQueryCommand);
            string[] parameters = GetParameters(strQueryCommand);
            if (parameters != null)
            {
                for (int i = 0; i < parameters.Length; i++)
                {
                    if (paramValues[i].GetType().Equals(typeof(int)))
                        Database.AddInParameter(cmd, parameters[i], SqlDbType.Int, paramValues[i]);
                    else if (paramValues[i].GetType().Equals(typeof(bool)))
                        Database.AddInParameter(cmd, parameters[i], SqlDbType.Bit, paramValues[i]);
                    else if (paramValues[i].GetType().Equals(typeof(short)))
                        Database.AddInParameter(cmd, parameters[i], SqlDbType.SmallInt, paramValues[i]);
                    else if (paramValues[i].GetType().Equals(typeof(double)))
                        Database.AddInParameter(cmd, parameters[i], SqlDbType.Float, paramValues[i]);
                    else if (paramValues[i].GetType().Equals(typeof(decimal)))
                        Database.AddInParameter(cmd, parameters[i], SqlDbType.Decimal, paramValues[i]);
                    else if (paramValues[i].GetType().Equals(typeof(String)) || paramValues[i].GetType().Equals(typeof(string)))
                        Database.AddInParameter(cmd, parameters[i], SqlDbType.NVarChar, paramValues[i]);
                    else if (paramValues[i].GetType().Equals(typeof(DateTime)))
                        Database.AddInParameter(cmd, parameters[i], SqlDbType.DateTime, paramValues[i]);
                    else if (paramValues[i].GetType().Equals(typeof(byte[])))
                        Database.AddInParameter(cmd, parameters[i], SqlDbType.VarBinary, paramValues[i]);
                    else
                        continue;
                }
            }
            return (DataSet)RunQuery(cmd);
        }

        public static DataSet RunQuery(DbCommand cmd)
        {
            return Database.ExecuteDataSet(cmd);
        }

        public static string GetTableHistory(string modulePrefix)
        {
            string historyTableName = string.Empty;
            switch ((ModulePrefix)Enum.Parse(typeof(ModulePrefix), modulePrefix))
            {
                case ModulePrefix.AC:
                    historyTableName = "ACHistorys";
                    break;
                case ModulePrefix.AD:
                    historyTableName = "ADHistorys";
                    break;
                case ModulePrefix.AP:
                    historyTableName = "APHistorys";
                    break;
                case ModulePrefix.AR:
                    historyTableName = "ARHistorys";
                    break;
                case ModulePrefix.BR:
                    historyTableName = "BRHistorys";
                    break;
                case ModulePrefix.IC:
                    historyTableName = "ICHistorys";
                    break;
                case ModulePrefix.MM:
                    historyTableName = "MMHistorys";
                    break;
                case ModulePrefix.PM:
                    historyTableName = "PMHistorys";
                    break;
                case ModulePrefix.VM:
                    historyTableName = "VMHistorys";
                    break;
                default:
                    break;
            }
            return historyTableName;
        }

        public static DataTable CreateDataTabeHistory(string historyTableName)
        {
            if (historyTableName.IsNullOrWhiteSpace())
                return null;

            DataTable dt = new DataTable();
            var columnList = BysGateway.DefinedTypeColumns.Where(o => o.TableName == "Type_" + historyTableName).OrderBy(o => o.OrdinalPosition).ToList();
            columnList.All(col =>
            {
                Type type = col.GetAssemblyDbType();
                if (type == null)
                    return true;

                DataColumn column = dt.Columns.Add(col.ColumnName, type);
                column.AllowDBNull = col.IsNullable;
                column.Unique = col.IsPrimaryKey;
                return true;
            });
            return dt;
        }
        #endregion
    }
}

using BOSLib.Extensions;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Reflection;
namespace BOSLib
{
    public class BOSDbUtil : BaseBusinessController
    {
        #region SP Name
        private readonly string spGetAllTables = "GEDBUtil_SelectAllTables";

        private readonly string spGetTableByName = "GEDBUtil_SelectTableByName";

        private readonly string spGetTableColumns = "GEDBUtil_SelectTableColumns";

        private readonly string spGetColumnsByTableNameAndColumnNameBeginWith = "GEDBUtil_SelectColumnsByTableNameAndColumnNameBeginWith";

        private readonly string spGetNotAllowNullTableColumns = "GEDBUtil_SelectNotAllowNullTableColumns";

        private readonly string spGetTableHaveMCode = "GEDBUtil_SelectTableHaveMCode";

        private readonly string spGetMCodeColumnsFromTable = "GEDBUtil_SelectMCodeColumnsFromTable";

        private readonly string spGetTableKeyColumns = "GEDBUtil_SelectTableKeyColumns";

        private readonly string spGetTableForeignKeys = "GEDBUtil_SelectTableForeignKeys";

        private readonly string spGetTablePrimaryKeys = "GEDBUtil_SelectTablePrimaryKeys";

        private readonly string spGetTableForeignKey = "GEDBUtil_SelectTableForeignKey";

        private readonly string spGetTablePrimaryKey = "GEDBUtil_SelectTablePrimaryKey";

        private readonly string spGetTableUniqueContraint = "GEDBUtil_SelectTableUniqueConstraint";

        private readonly string spGetPrimaryTableAndColumnWhichForeignColumnReferenceTo = "GEDBUtil_SelectPrimaryTableAndColumnWhichForeignColumnReferenceTo";

        private readonly string spGetTableColumn = "GEDBUtil_SelectTableColumn";

        private readonly string spGetSaveStatusInSessionColumn = "GEDBUtil_SelectSaveStatusInSessionColumn";

        private readonly string spGetAllStoredProcedures = "GEDBUtil_SelectAllStoredProcedures";

        private readonly string spGetStoredProcedureByTableName = "GEDBUtil_SelectStoredProcedureByTableName";

        private readonly string spGetStoredProcedureByName = "GEDBUtil_SelectStoredProcedureByName";

        private readonly string spGetStoredProcedureTextByID = "GEDBUtil_SelectStoredProcedureTextByID";

        private readonly string spGetStoredProcedureTextByStoredProcedureName = "GEDBUtil_SelectStoredProcedureTextByStoredProcedureName";

        private readonly string spGetColumnDescriptionByTableNameAndColumnName = "GEDBUtil_SelectColumnDescriptionByTableNameAndColumnName";

        private readonly string spGetAllViews = "GEDBUtil_SelectAllViews";

        private readonly string spGetViewTextByViewName = "GEDBUtil_SelectViewTextByViewName";

        private readonly string spGetViewColumns = "GEDBUtil_SelectViewColumns";

        private readonly string spGetViewColumn = "GEDBUtil_SelectViewColumn";

        #endregion

        public BOSDbUtil()
        {
            dal = new DALBaseProvider();
        }

        public DataSet GetNotAllowNullTableColumns(String strTableName)
        {
            String strQuery = String.Format("SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{0}' AND IS_NULLABLE = 'NO'", strTableName);
            return (DataSet)dal.GetDataSet(strQuery);

        }

        public DataSet GetTableColumn(String strTableName, String strColumnName)
        {
            String strQuery = String.Format("SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{0}' AND COLUMN_NAME = '{1}'", strTableName, strColumnName);
            return (DataSet)dal.GetDataSet(strQuery);
        }

        public bool ColumnIsExist(String strTableName, String strColumnName)
        {
            return BysGateway.TableColumns.Any(o => o.TableName == strTableName && o.ColumnName == strColumnName);
        }

        public String GetColumnDbType(String strTableName, String strColumnName)
        {
            String strColumnDbType = String.Empty;
            DataSet dsColumn = GetTableColumn(strTableName, strColumnName);
            if (dsColumn.Tables.Count > 0)
            {
                if (dsColumn.Tables[0].Rows.Count > 0)
                {
                    strColumnDbType = dsColumn.Tables[0].Rows[0]["DATA_TYPE"].ToString();
                    if (strColumnDbType == "varchar" || strColumnDbType == "nvarchar" || strColumnDbType == "varbinary")
                        strColumnDbType += "(" + dsColumn.Tables[0].Rows[0]["CHARACTER_MAXIMUM_LENGTH"].ToString() + ")";
                }
            }
            return strColumnDbType;
        }

        public String GetColumnDataType(String strTableName, String strColumnName)
        {
            String strColumnDataType = String.Empty;
            DataSet dsColumn = GetTableColumn(strTableName, strColumnName);
            if (dsColumn.Tables.Count > 0)
            {
                if (dsColumn.Tables[0].Rows.Count > 0)
                {
                    strColumnDataType = dsColumn.Tables[0].Rows[0]["DATA_TYPE"].ToString();
                }
            }
            return strColumnDataType;
        }

        public bool ColumnIsAllowNull(String strTableName, String strColumnName)
        {
            if (BysGateway.TableColumns.Where(o => o.TableName == strTableName && o.ColumnName == strColumnName).FirstOrDefault() == null)
                return true;
            return BysGateway.TableColumns.Where(o => o.TableName == strTableName && o.ColumnName == strColumnName).Select(o => o.IsNullable).FirstOrDefault();
        }

        public DataSet GetTableForeignKeys(String strTableName)
        {
            String strQuery = String.Format("SELECT kcu.* FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE kcu, INFORMATION_SCHEMA.TABLE_CONSTRAINTS tc WHERE kcu.TABLE_NAME = '{0}' AND kcu.CONSTRAINT_NAME = tc.CONSTRAINT_NAME AND tc.CONSTRAINT_TYPE = 'FOREIGN KEY'", strTableName);
            return (DataSet)dal.GetDataSet(strQuery);
        }

        public String GetTablePrimaryColumn(String strTableName)
        {
            return BysGateway.TableColumns.Where(o => o.TableName == strTableName && o.IsPrimaryKey).Select(o => o.ColumnName).FirstOrDefault() ?? string.Empty;
        }




        public bool IsForeignKey(String strTableName, String strColumnName)
        {
            if (strColumnName.Contains("FK_"))
                return true;
            //DataSet dsForeignKey = GetTableForeignKey(strTableName, strColumnName);
            //if (dsForeignKey.Tables.Count > 0)
            //{
            //    if (dsForeignKey.Tables[0].Rows.Count > 0)
            //        return true;
            //}         
            string primaryTable = GetPrimaryTableWhichForeignColumnReferenceTo(strTableName, strColumnName);
            if (primaryTable != string.Empty)
                return true;
            return false;
        }

        public bool IsPrimaryKey(String strTableName, String strColumnName)
        {
            String strPrimaryKey = GetTablePrimaryColumn(strTableName);
            if (strPrimaryKey == strColumnName)
                return true;
            return false;
        }

        public String GetPrimaryTableWhichForeignColumnReferenceTo(String strForeignTableName, String strForeignColumnName)
        {
            return BysGateway.TableConstraints.Where(o => o.ForeignTableName == strForeignTableName && o.ForeignColumnName == strForeignColumnName).Select(o => o.PrimaryTableName).FirstOrDefault(); ;
        }

        public DataSet ExecuteQuery(String strQuery)
        {
            DbCommand cmd = SqlDatabaseHelper.GetQuery(strQuery);
            return (DataSet)SqlDatabaseHelper.RunQuery(cmd);
        }

        public void SetPropertyValue(BusinessObject obj, String strPropertyName, object value)
        {
            if (obj == null) return;
            Type objType = obj.GetType();
            Dictionary<string, PropertyInfo> columnProps = obj.GetColumnAttributes();
            PropertyInfo property = objType.GetProperty(strPropertyName);
            if (property == null)
                columnProps.TryGetValue(strPropertyName, out property);
            if (property != null)
                property.SetValue(obj, value, null);
        }

        public void SetPropertyValue(object obj, String strPropertyName, object value)
        {
            if (obj == null) return;
            Type objType = obj.GetType();
            Dictionary<string, PropertyInfo> columnProps = obj.GetColumnAttributes();
            PropertyInfo property = objType.GetProperty(strPropertyName);
            if (property == null)
                columnProps.TryGetValue(strPropertyName, out property);
            if (property != null)
                property.SetValue(obj, value, null);
        }

        public object GetPropertyValue(BusinessObject obj, String strPropertyName)
        {
            if (obj == null) return null;
            Type objType = obj.GetType();
            Dictionary<string, PropertyInfo> columnProps = obj.GetColumnAttributes();
            PropertyInfo property = objType.GetProperty(strPropertyName);
            if (property == null)
                columnProps.TryGetValue(strPropertyName, out property);
            if (property != null)
                return property.GetValue(obj, null);
            return null;
        }

        public object GetPropertyValue(object obj, String strPropertyName)
        {
            if (obj == null) return null;
            Type objType = obj.GetType();
            Dictionary<string, PropertyInfo> columnProps = obj.GetColumnAttributes();
            PropertyInfo property = objType.GetProperty(strPropertyName);
            if (property == null)
                columnProps.TryGetValue(strPropertyName, out property);
            if (property != null)
                return property.GetValue(obj, null);
            return null;
        }

        public String GetPropertyStringValue(object obj, String strPropertyName)
        {
            object objValue = GetPropertyValue(obj, strPropertyName);
            if (objValue != null)
                return objValue.ToString();
            return String.Empty;
        }

        public int GetPropertyIntValue(object obj, String strPropertyName)
        {
            object objValue = GetPropertyValue(obj, strPropertyName);
            if (objValue != null)
                return Convert.ToInt32(objValue);
            return 0;
        }

        public String GetStoredProcedureTextByStoredProcedureName(String strStoredProcedureName)
        {
            String strStoredProceduretext = String.Empty;
            String strQuery = String.Format("SELECT sc.* FROM syscomments sc, sysobjects so WHERE sc.id = so.id AND so.name = '{0}' AND so.type = 'P'", strStoredProcedureName);
            DataSet dsStoredProcedureText = dal.GetDataSet(strQuery);
            if (dsStoredProcedureText.Tables.Count > 0)
            {
                foreach (DataRow rowStoredProcedureText in dsStoredProcedureText.Tables[0].Rows)
                {
                    strStoredProceduretext += rowStoredProcedureText["text"].ToString();
                }
            }

            return strStoredProceduretext;

        }

        public void ExecuteNonQuery(String spName, params object[] values)
        {
            SqlDatabaseHelper.ExecuteNonQuery(spName, values);
        }

        public void ExecuteNonQuery(Database database, String spName, params object[] values)
        {
            SqlDatabaseHelper.ExecuteNonQuery(database, spName, values);
        }


        public DataSet GetViewColumn(String strViewName, String strColumnName)
        {
            String strQuery = String.Format("SELECT * FROM INFORMATION_SCHEMA.VIEW_COLUMN_USAGE WHERE VIEW_NAME = '{0}' AND COLUMN_NAME = '{1}'", strViewName, strColumnName);
            return (DataSet)dal.GetDataSet(strQuery);
        }

        /// <summary>
        /// Get table name by its column's name
        /// </summary>
        /// <param name="columnName">Column name</param>
        /// <returns>Table name</returns>
        public string GetTableNameByColumnName(string columnName)
        {
            string query = string.Format("SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE COLUMN_NAME = '{0}'", columnName);
            DataSet ds = dal.GetDataSet(query);
            string tableName = string.Empty;
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return Convert.ToString(ds.Tables[0].Rows[0]["TABLE_NAME"]);
            }
            return string.Empty;
        }

        public DateTime GetLastCreatedDateOfTable(String strTableName)
        {
            try
            {
                DateTime dtLastCreatedDate = DateTime.MinValue;
                String strAACreatedDateColumn = "AACreatedDate";
                if (ColumnIsExist(strTableName, strAACreatedDateColumn))
                {
                    String strQuery = String.Format("Select MAX([{0}]) From [{1}] Where DATEDIFF(d, [{0}], '9999-12-31') > 0", strAACreatedDateColumn, strTableName);
                    DbCommand cmd = SqlDatabaseHelper.GetQuery(strQuery);
                    DataSet ds = SqlDatabaseHelper.RunQuery(cmd);
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                            dtLastCreatedDate = Convert.ToDateTime(ds.Tables[0].Rows[0][0]);
                    }
                }

                return dtLastCreatedDate;
            }
            catch (Exception e)
            {
                return DateTime.MinValue;
            }
        }

        public DateTime GetLastUpdatedDateOfTable(String strTableName)
        {
            try
            {
                DateTime dtLastUpdatedDate = DateTime.MinValue;
                String strAAUpdatedDate = "AAUpdatedDate";
                if (strTableName == "ICProducts") return dtLastUpdatedDate;
                if (ColumnIsExist(strTableName, strAAUpdatedDate))
                {
                    String strQuery = String.Format("Select MAX([{0}]) From [{1}] Where DATEDIFF(d, [{0}], '9999-12-31') > 0", strAAUpdatedDate, strTableName);
                    DbCommand cmd = SqlDatabaseHelper.GetQuery(strQuery);
                    DataSet ds = SqlDatabaseHelper.RunQuery(cmd);
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                            dtLastUpdatedDate = Convert.ToDateTime(ds.Tables[0].Rows[0][0]);
                    }
                }

                return dtLastUpdatedDate;
            }
            catch (Exception e)
            {
                return DateTime.MinValue;
            }
        }
        public DataSet GetListCreateAndUpdatedDateOfListTable(DataTable tb, string typeName, string storeName)
        {
            return SqlDatabaseHelper.GetDataUsingStringType(tb, typeName, storeName);
        }

        public DataSet GetDataSet(Database database, string spName, params object[] values)
        {
            return SqlDatabaseHelper.RunStoredProcedure((SqlDatabase)database, spName, values);
        }

        public DateTime GetCurrentServerDate()
        {
            return Convert.ToDateTime(dal.GetSingleValue("GetCurrentServerDate"));
        }
    }
}

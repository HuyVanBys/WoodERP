

using BOSERP;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

public static class SaveItemWithDataTableType
{
    public static void SaveItem<T>(List<T> listItem, string primaryKey, string tableName, int mainObjectID, string userName)
    {
        BOSDbUtil dbUtil = new BOSDbUtil();

        List<T> newList = new List<T>();
        List<T> updateList = new List<T>();

        foreach (T obj in listItem)
        {
            int id = Convert.ToInt32(dbUtil.GetPropertyValue(obj, primaryKey));
            if (id == 0)
            {
                newList.Add(obj);
            }
            else
            {
                updateList.Add(obj);
            }
        }

        STToolbarsController rController = new STToolbarsController();
        List<string> colList = rController.UserDefinedTableTypeColumnName("Type_" + tableName);

        //delete
        //SaveItemObjectByDataTableType(null, mainObjectID, tableName, SaveActionType.Delete);
        SqlDatabaseHelper.SaveItemObject(null, mainObjectID, tableName, "Delete", userName);

        //update 
        if (updateList.Count > 0)
        {
            DataTable updateTable = CollectionExtensions.AsDataTable<T>(updateList, colList);
            //SaveItemObjectByDataTableType(updateTable, mainObjectID, tableName, SaveActionType.Update);
            SqlDatabaseHelper.SaveItemObject(updateTable, mainObjectID, tableName, "Update", userName);
        }

        //create
        if (newList.Count > 0)
        {
            DataTable newTable = CollectionExtensions.AsDataTable<T>(newList, colList);
            SqlDatabaseHelper.SaveItemObject(newTable, mainObjectID, tableName, "Create", userName);
        }
    }

    public static void SaveItemObjectByDataTableType(DataTable dt, int mainObjectID, string tableName, SaveActionType actionType, string userName)
    {
        String strDatabase = ConfigurationManager.AppSettings["DatabaseName"];
        String strServer = ConfigurationManager.AppSettings["ServerName"];
        String strUser = ConfigurationManager.AppSettings["UserID"];
        string strPassword = ConfigurationManager.AppSettings["Password"];


        CryptorEngine crypt = new CryptorEngine();
        strPassword = crypt.Decrypt(strPassword, true);
        strUser = crypt.Decrypt(strUser, true);

        String strBranchConnectionString = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3}", strServer, strDatabase, strUser, strPassword);

        using (var conn = new SqlConnection(strBranchConnectionString))
        {
            conn.Open();
            var cmd = new SqlCommand();
            if (actionType == SaveActionType.Create)
            {
                cmd.CommandText = SaveActionType.Create.ToString() + "_" + tableName;
            }
            else if (actionType == SaveActionType.Update)
            {
                cmd.CommandText = SaveActionType.Update.ToString() + "_" + tableName;
            }
            else if (actionType == SaveActionType.Delete)
            {
                cmd.CommandText = SaveActionType.Delete.ToString() + "_" + tableName;
            }


            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;

            if (actionType != SaveActionType.Delete)
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

            if (actionType != SaveActionType.Delete)
            {
                cmd.Parameters["@" + tableName].Value = dt;
            }
            cmd.Parameters["@UserName"].Value = userName;
            cmd.Parameters["@MainObjectID"].Value = mainObjectID;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }

    public static void DeleteItem<T>(List<T> listItem, string tableName, string userName)
    {
        BOSDbUtil dbUtil = new BOSDbUtil();
        STToolbarsController rController = new STToolbarsController();
        List<string> colList = rController.UserDefinedTableTypeColumnName("Type_" + tableName);
        //delete
        int maxRercords = 10000;
        if (listItem.Count > 0)
        {
            int iter = Convert.ToInt32(Math.Ceiling(listItem.Count / (decimal)maxRercords));
            for (int i = 0; i < iter; i++)
            {
                DataTable deleteTable = CollectionExtensions.AsDataTable<T>(listItem.Skip(i * maxRercords).Take(maxRercords).ToList(), colList);
                SqlDatabaseHelper.DeleteItemObject(deleteTable, tableName, userName);
            }
        }
    }
    public static void DeleteItemOverTimeOut<T>(List<T> listItem, string tableName, string userName)
    {
        BOSDbUtil dbUtil = new BOSDbUtil();
        STToolbarsController rController = new STToolbarsController();
        List<string> colList = rController.UserDefinedTableTypeColumnName("Type_" + tableName);
        //delete
        int maxRercords = 10000;
        if (listItem.Count > 0)
        {
            int iter = Convert.ToInt32(Math.Ceiling(listItem.Count / (decimal)maxRercords));
            for (int i = 0; i < iter; i++)
            {
                DataTable deleteTable = CollectionExtensions.AsDataTable<T>(listItem.Skip(i * maxRercords).Take(maxRercords).ToList(), colList);
                SqlDatabaseHelper.DeleteItemObjectOverTimeOut(deleteTable, tableName, userName);
            }
        }
    }

    public static void DeleteItemObjectByDataTableType(DataTable dt, string tableName, string userName)
    {
        String strDatabase = ConfigurationManager.AppSettings["DatabaseName"];
        String strServer = ConfigurationManager.AppSettings["ServerName"];
        String strUser = ConfigurationManager.AppSettings["UserID"];
        string strPassword = ConfigurationManager.AppSettings["Password"];


        CryptorEngine crypt = new CryptorEngine();
        strPassword = crypt.Decrypt(strPassword, true);
        strUser = crypt.Decrypt(strUser, true);

        String strBranchConnectionString = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3}", strServer, strDatabase, strUser, strPassword);

        using (var conn = new SqlConnection(strBranchConnectionString))
        {
            conn.Open();
            var cmd = new SqlCommand();

            cmd.CommandText = SaveActionType.DeleteWithList.ToString() + "_" + tableName;



            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;


            var param = new SqlParameter();
            param.ParameterName = "@" + tableName;
            param.SqlDbType = SqlDbType.Structured;
            cmd.Parameters.Add(param);


            var param2 = new SqlParameter();
            param2.ParameterName = "@UserName";
            param2.SqlDbType = SqlDbType.NVarChar;
            cmd.Parameters.Add(param2);




            cmd.Parameters["@" + tableName].Value = dt;

            cmd.Parameters["@UserName"].Value = userName;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }

    public static void SaveItemWithoutDelete<T>(List<T> listItem, string primaryKey, string tableName, int mainObjectID, string userName)
    {
        BOSDbUtil dbUtil = new BOSDbUtil();

        List<T> newList = new List<T>();
        List<T> updateList = new List<T>();

        for (int i = 0; i < listItem.Count(); i++)
        {
            T obj = listItem[i];
            int id = Convert.ToInt32(dbUtil.GetPropertyValue(obj, primaryKey));
            if (id == 0)
            {
                newList.Add(obj);
            }
            else
            {
                updateList.Add(obj);
            }
        }

        STToolbarsController rController = new STToolbarsController();
        List<string> colList = rController.UserDefinedTableTypeColumnName("Type_" + tableName);
        int maxRercords = 10000;
        //update 
        if (updateList.Count > 0)
        {
            int iterSave = Convert.ToInt32(Math.Ceiling(updateList.Count / (decimal)maxRercords));
            for (int i = 0; i < iterSave; i++)
            {
                DataTable updateTable = CollectionExtensions.AsDataTable<T>(updateList.Skip(i * maxRercords).Take(maxRercords).ToList(), colList);
                SqlDatabaseHelper.SaveItemObject(updateTable, mainObjectID, tableName, "Update", userName);
            }

        }

        //create
        if (newList.Count > 0)
        {
            int iterSave = Convert.ToInt32(Math.Ceiling(newList.Count / (decimal)maxRercords));
            for (int i = 0; i < iterSave; i++)
            {
                DataTable newTable = CollectionExtensions.AsDataTable<T>(newList.Skip(i * maxRercords).Take(maxRercords).ToList(), colList);
                SqlDatabaseHelper.SaveItemObject(newTable, mainObjectID, tableName, "Create", userName);
            }
        }
    }
    public static void UpdateColumnItem<T>(List<T> listItem, string primaryKey, string tableName, int mainObjectID, string userName, string store)
    {
        BOSDbUtil dbUtil = new BOSDbUtil();

        List<T> newList = new List<T>();
        List<T> updateList = new List<T>();

        for (int i = 0; i < listItem.Count(); i++)
        {
            T obj = listItem[i];
            int id = Convert.ToInt32(dbUtil.GetPropertyValue(obj, primaryKey));
            if (id > 0)
                updateList.Add(obj);
        }

        STToolbarsController rController = new STToolbarsController();
        List<string> colList = rController.UserDefinedTableTypeColumnName("Type_" + tableName);
        int maxRercords = 10000;
        //update 
        if (updateList.Count > 0)
        {
            int iterSave = Convert.ToInt32(Math.Ceiling(updateList.Count / (decimal)maxRercords));
            for (int i = 0; i < iterSave; i++)
            {
                DataTable updateTable = CollectionExtensions.AsDataTable<T>(updateList.Skip(i * maxRercords).Take(maxRercords).ToList(), colList);
                SqlDatabaseHelper.UpdateItemObject(updateTable, mainObjectID, tableName, store, userName);
            }

        }

    }
    public static void SaveItemWithoutDeleteOverTimeOut<T>(List<T> listItem, string primaryKey, string tableName, int mainObjectID, string userName)
    {
        BOSDbUtil dbUtil = new BOSDbUtil();

        List<T> newList = new List<T>();
        List<T> updateList = new List<T>();

        for (int i = 0; i < listItem.Count(); i++)
        {
            T obj = listItem[i];
            int id = Convert.ToInt32(dbUtil.GetPropertyValue(obj, primaryKey));
            if (id == 0)
            {
                newList.Add(obj);
            }
            else
            {
                updateList.Add(obj);
            }
        }

        STToolbarsController rController = new STToolbarsController();
        List<string> colList = rController.UserDefinedTableTypeColumnName("Type_" + tableName);
        int maxRercords = 10000;
        //update 
        if (updateList.Count > 0)
        {
            int iterSave = Convert.ToInt32(Math.Ceiling(updateList.Count / (decimal)maxRercords));
            for (int i = 0; i < iterSave; i++)
            {
                DataTable updateTable = CollectionExtensions.AsDataTable<T>(updateList.Skip(i * maxRercords).Take(maxRercords).ToList(), colList);
                SqlDatabaseHelper.SaveItemObjectOverTimeOut(updateTable, mainObjectID, tableName, "Update", userName);
            }

        }

        //create
        if (newList.Count > 0)
        {
            int iterSave = Convert.ToInt32(Math.Ceiling(newList.Count / (decimal)maxRercords));
            for (int i = 0; i < iterSave; i++)
            {
                DataTable newTable = CollectionExtensions.AsDataTable<T>(newList.Skip(i * maxRercords).Take(maxRercords).ToList(), colList);
                SqlDatabaseHelper.SaveItemObjectOverTimeOut(newTable, mainObjectID, tableName, "Create", userName);
            }
        }
    }
}

public enum SaveActionType
{
    Create, Update, Delete, DeleteWithList
}
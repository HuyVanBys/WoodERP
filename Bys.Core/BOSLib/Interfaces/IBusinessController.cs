using System;
using System.Collections;
using System.Data;

namespace BOSLib.Interfaces
{
    public interface IBusinessController
    {
        string GetObjectNameByID(int objectID);

        bool IsExist(int objectID);

        bool IsExist(string strObjectNo);

        int GetObjectIDByNo(string objectNo);

        DataSet GetAllDataByForeignColumn(String strForeignColumnName, object objForeignColumnValue);

        DataSet GetDataSet(string strQuery);

        DataSet GetDataSetByID(int iObjectID);

        DataSet GetAllObjects();

        object GetTemplateObject();

        object GetObjectByNo(string strObjectNo);

        object GetObjectByID(int iObjectID);

        string GetObjectNoByID(int iObjectID);

        int UpdateObject(BusinessObject obj);

        DataRow GetDataRowFromBusinessObject(DataRow row, BusinessObject obj);

        int CreateObject(BusinessObject obj);

        int CreateObject(BusinessObject obj, int iObjectID);

        void DeleteObject(int iObjectID);

        DataSet GetAllObjectsByObjectParentID(int iObjectParentID);

        void DeleteFromOwner(String strOwnerTable, int iOwnerID, String strSwitcherTable);

        void DeleteByForeignColumn(String strForeignColumn, object objForeignColumnValue);

        void DeleteAllObjects();

        object GetObjectFromDataRow(DataRow row);

        void DeleteAllObjectsByObjectParentID(int iObjectParentID);

        DataSet GetAllAliveObjects();

        IList GetListFromDataSet(DataSet ds);
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BOSLib
{
    public interface IBaseModuleERP : IBaseModule
    {
        #region Control Events
        void Control_Click(object sender, EventArgs e);
        void Control_MouseUp(object sender, MouseEventArgs e);
        void Control_TextChanged(object sender, EventArgs e);
        void Control_Validated(object sender, EventArgs e);
        void Control_EditValueChanged(object sender, EventArgs e);
        void Control_Enter(object sender, EventArgs e);
        void Control_Leave(object sender, EventArgs e);
        void Control_KeyDown(object sender, KeyEventArgs e);
        void Control_KeyUp(object sender, KeyEventArgs e);
        #endregion        

        SortedList GetLookupTableCollection();
        SortedList GetLookupTableUpdatedDateCollection();
        SortedList<string, GELookupTablesInfo> GetLookupTableObjects();
        List<GELookupTablesInfo> GetLookupTableList();
        List<STScreensInfo> GetSystemScreen();
        List<STFieldsInfo> GetSystemFields();
        List<STFieldColumnsInfo> GetSystemFieldColumns();
        List<STFieldPermissionsInfo> GetSystemFieldPermissions();
        SortedList GetSystemFieldColumnPermissions();
        List<STFieldEventsInfo> GetSystemFieldEvents();
        List<STFieldEventFunctionsInfo> GetSystemFieldEventFunctions();
        List<AAColumnAliasInfo> GetSystemAlias();
        string GetProductType(int ProductID);
        SortedList GetSystemFieldFormatGroup();
        List<STFieldFormatGroupsInfo> GetSystemFieldFormatList();
        int GetCurrentUserGroupID();
        DataSet GetLookupTableData(string lookupTableName);
        String GetTreePrimaryTableWhichForeignColumnReferenceTo(String strForeignTableName, String strForeignColumnName);
        String GetTablePrimaryColumn(String strTableName);
        bool IsForeignKey(String strTableName, String strColumnName);
        void RemoveSystemFieldColumnsByFieldID(int fieldID, string commodityType);
        void AddSystemFieldColumns(List<STFieldColumnsInfo> collection);
        void AddSystemField(STFieldsInfo objFieldsInfo);
        //void UpdateLookupTableUpdatedDateCollection(string tableName, DateTime datetime);
        //void UpdateLookupTables(string tableName, DataSet ds);
        //void UpdateExchangeRateByCurrency(int currencyID);
        DateTime GetServerDate();
    }
}
using System;
using System.Collections.Generic;
using System.Data;

namespace BOSLib
{
    #region STFieldFormats
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:STFieldFormatsController
    //Created Date:Friday, September 26, 2008
    //-----------------------------------------------------------

    public class STFieldFormatsController : BaseBusinessController
    {
        public STFieldFormatsController()
        {
            dal = new DALBaseProvider("STFieldFormats", typeof(STFieldFormatsInfo));
        }

        public DataSet GetFieldFormatsByModuleNameAndTableName(String strModuleName, String strTableName)
        {
            return dal.GetDataSet("STFieldFormats_SelectByModuleNameAndTableName", strModuleName, strTableName);
        }

        public STFieldFormatsInfo GetFieldFormatByModuleNameAndTableNameAndColumnName(String strModuleName, String strTableName, String strColumnName)
        {
            return (STFieldFormatsInfo)dal.GetDataObject("STFieldFormats_SelectByModuleNameAndTableNameAndColumnName", strModuleName, strTableName, strColumnName);
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<STFieldFormatsInfo> fieldFormatsList = new List<STFieldFormatsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    STFieldFormatsInfo fieldFormatsInfo = (STFieldFormatsInfo)GetObjectFromDataRow(row);
                    fieldFormatsList.Add(fieldFormatsInfo);
                }
            }
            ds.Dispose();
            return fieldFormatsList;
        }

        public List<STFieldFormatsInfo> GetFieldFormatForConfig(String strModuleName, String strTableName)
        {
            DataSet ds = dal.GetDataSet("STFieldFormats_GetFieldFormatForConfig", strTableName, strModuleName);
            return (List<STFieldFormatsInfo>)GetListFromDataSet(ds);
        }

    }
    #endregion
}
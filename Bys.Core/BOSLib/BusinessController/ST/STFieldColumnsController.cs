using System;
using System.Data;

namespace BOSLib
{
    #region STFieldColumns
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:STFieldColumnsController
    //Created Date:Monday, March 26, 2007
    //-----------------------------------------------------------

    public class STFieldColumnsController : BaseBusinessController
    {
        public STFieldColumnsController()
        {
            dal = new DALBaseProvider("STFieldColumns", typeof(STFieldColumnsInfo));
        }

        public DataSet GetFieldColumnsByFieldID(int fieldID)
        {
            String query = String.Format("SELECT * FROM STFieldColumns WHERE STFieldID = {0} ORDER BY STFieldColumnVisibleIndex", fieldID);
            return GetDataSet(query);
        }

        /// <summary>
        /// Get first field the column with the specified binding field name belongs to
        /// </summary>
        /// <param name="fieldName">Field name the column is bound to</param>
        /// <returns>Field object</returns>
        public STFieldsInfo GetFirstFieldByColumnFieldName(string columnFieldName)
        {
            DataSet ds = dal.GetDataSet("STFieldColumns_GetFirstFieldByColumnFieldName", columnFieldName);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                STFieldsController objFieldsController = new STFieldsController();
                STFieldsInfo objFieldsInfo = (STFieldsInfo)objFieldsController.GetObjectFromDataRow(ds.Tables[0].Rows[0]);
                ds.Dispose();
                return objFieldsInfo;
            }
            return null;
        }

        public void DeleteBySTFieldIDAndCommodityType(int fieldID, string commodityType)
        {
            dal.ExecuteStoredProcedure("STFieldColumns_DeleteBySTFieldIDAndCommodityType", fieldID, commodityType);
        }
    }
    #endregion
}
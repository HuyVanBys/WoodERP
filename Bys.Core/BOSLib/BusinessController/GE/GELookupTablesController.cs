using System;
using System.Data;


namespace BOSLib
{
    #region GELookupTables
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:GELookupTablesController
    //Created Date:Wednesday, March 12, 2008
    //-----------------------------------------------------------

    public class GELookupTablesController : BaseBusinessController
    {
        public GELookupTablesController()
        {
            dal = new DALBaseProvider("GELookupTables", typeof(GELookupTablesInfo));
        }

        public GELookupTablesInfo GetObjectByTableName(String tableName)
        {
            String query = String.Format("SELECT * FROM GELookupTables WHERE AAStatus = 'Alive' AND GELookupTableName = '{0}'", tableName);
            DataSet ds = GetDataSet(query);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return (GELookupTablesInfo)GetObjectFromDataRow(ds.Tables[0].Rows[0]);
            return null;
        }
    }
    #endregion
}
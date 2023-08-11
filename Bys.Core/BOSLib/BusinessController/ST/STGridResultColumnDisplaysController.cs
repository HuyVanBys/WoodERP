using System;
using System.Data;



namespace BOSLib
{
    #region GridResultColumnDisplayController
    /// <summary>
    /// This object represents the properties and methods of a GridResultColumnDisplay.
    /// </summary>
    public class STGridResultColumnDisplaysController : BaseBusinessController
    {
        #region SP Name

        //Select By ForeignKey Queries
        private readonly string spGetSTGridResultColumnDisplaysBySTModuleID = "STGridResultColumnDisplays_SelectBySTModuleID";
        private readonly string spGetSTGridResultColumnDisplaysByName = "STGridResultColumnDisplays_SelectByName";
        private readonly string spGetSTGridResultsColumnDisplaysBySTModuleNameAndSTGridResultColumnName = "STGridResultColumnDisplays_SelectBySTModuleNameAndSTGridResultColumnName";
        private readonly string spGetSTGridResultColumnDisplaysBySTModuleName = "STGridResultColumnDisplays_SelectBySTModuleName";


        //Delete by foreignkey Queries
        /*Remove cause of not use
        private readonly string spDeleteSTGridResultColumnDisplaysBySTModuleID = "STGridResultColumnDisplays_DeleteBySTModuleID";*/

        private readonly string spDeleteSTGridResultColumnDisplaysBySTModuleName = "STGridResultColumnDipslays_DeleteBySTModuleName";
        private readonly string spDeleteSTGridResultColumnDisplaysByName = "STGridResultColumnDipslays_DeleteByName";

        #endregion
        public STGridResultColumnDisplaysController()
        {
            //dal =new STGridResultColumnDisplaysDAL();
            dal = new DALBaseProvider("STGridResultColumnDisplays", typeof(STGridResultColumnDisplaysInfo));
        }


        public DataSet GetGridResultColumnDisplaysByModuleID(int iModuleID)
        {
            return (DataSet)dal.GetDataSet(spGetSTGridResultColumnDisplaysBySTModuleID, iModuleID);
        }

        public DataSet GetGridResultColumnDisplaysByModuleName(String strModuleName)
        {
            return (DataSet)dal.GetDataSet(spGetSTGridResultColumnDisplaysBySTModuleName, strModuleName);
        }

        public DataSet GetGridResultColumnDisplaysByName(String strName)
        {
            return (DataSet)dal.GetDataSet(spGetSTGridResultColumnDisplaysByName, strName);
        }


        public new bool IsExist(String strModuleName)
        {
            bool result = false;
            DataSet ds = GetGridResultColumnDisplaysByModuleName(strModuleName);
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                    result = true;
            }
            ds.Dispose();
            return result;
        }
        public bool IsExistByName(String strName)
        {
            bool result = false;
            DataSet ds = GetGridResultColumnDisplaysByName(strName);
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                    result = true;
            }
            ds.Dispose();
            return result;
        }

        public STGridResultColumnDisplaysInfo GetGridResultColumnDisplayByModuleNameAndColumnName(String strModuleName, String strColumnName)
        {
            return (STGridResultColumnDisplaysInfo)dal.GetDataObject(spGetSTGridResultsColumnDisplaysBySTModuleNameAndSTGridResultColumnName,
                                                                     strModuleName, strColumnName);
        }

        public void DeleteGridResultColumnDisplayByModuleName(String strModuleName)
        {
            dal.GetDataSet(spDeleteSTGridResultColumnDisplaysBySTModuleName, strModuleName);
        }

        public void DeleteGridResultColumnDisplayByName(String strName)
        {
            dal.GetDataSet(spDeleteSTGridResultColumnDisplaysByName, strName);
        }

    }
    #endregion
}

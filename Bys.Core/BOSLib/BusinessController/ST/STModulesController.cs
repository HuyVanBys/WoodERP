using System;
using System.Collections.Generic;
using System.Data;


namespace BOSLib
{
    public class STModulesController : BaseBusinessController
    {

        public STModulesController()
        {
            //dal = new STModulesDAL();
            dal = new DALBaseProvider("STModules", typeof(STModulesInfo));
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<STModulesInfo> modulesList = new List<STModulesInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    STModulesInfo objModulesInfo = (STModulesInfo)GetObjectFromDataRow(row);
                    modulesList.Add(objModulesInfo);
                }
            }
            ds.Dispose();
            return modulesList;
        }

        public bool IsMainModule(String strModuleName)
        {
            bool isMainModule = true;
            STModulesInfo objSTModulesInfo = (STModulesInfo)GetObjectByName(strModuleName);
            if (objSTModulesInfo != null)
            {
                if (objSTModulesInfo.STModuleMain == 0)
                    isMainModule = false;
            }
            return isMainModule;
        }

        /// <summary>
        /// Get all modules
        /// </summary>
        /// <returns>List of all modules</returns>
        public DataSet GetAllModules()
        {
            DataSet ds = dal.GetDataSet("STModules_GetAllModules");
            return ds;
        }

        //[NUThao] [Improve Speed] [2014-09-09]
        public List<STModulesInfo> GetAllModulesByUserNameAndLanguageName(string userName, string languageName)
        {
            DataSet ds = dal.GetDataSet("STModules_GetAllModulesByUserNameAndLanguageName", userName, languageName);

            List<STModulesInfo> result = new List<STModulesInfo>();
            if (ds != null && ds.Tables.Count != 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    STModulesInfo module = GetObjectFromDataRow(row) as STModulesInfo;
                    result.Add(module);
                }
            }
            ds.Dispose();
            return result;
        }

        public List<STModulesInfo> GetAllModuleList()
        {
            DataSet ds = dal.GetDataSet("STModules_GetAllModules");
            return (List<STModulesInfo>)GetListFromDataSet(ds);
        }

        public DataSet GetAllModuleStocks()
        {
            DataSet ds = dal.GetDataSet("STModules_GetAllModuleStocks");
            return ds;
        }

        public DataSet GetAllModuleForDefaultDescConfig()
        {
            DataSet ds = dal.GetDataSet("STModules_GetAllModuleForDefaultDescConfig");
            return ds;
        }
    }
}

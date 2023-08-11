using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region PMProjectNormHistorys
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:PMProjectNormHistorysController
    //Created Date:Wednesday, April 4, 2018
    //-----------------------------------------------------------

    public class PMProjectNormHistorysController : BaseBusinessController
    {
        public PMProjectNormHistorysController()
        {
            dal = new DALBaseProvider("PMProjectNormHistorys", typeof(PMProjectNormHistorysInfo));
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<PMProjectNormHistorysInfo> projectNormHistorys = new List<PMProjectNormHistorysInfo>();
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    PMProjectNormHistorysInfo objProjectNormHistorysInfo = (PMProjectNormHistorysInfo)GetObjectFromDataRow(row);
                    projectNormHistorys.Add(objProjectNormHistorysInfo);
                }
            }
            ds.Dispose();
            return projectNormHistorys;
        }
        public List<PMProjectNormHistorysInfo> GetProjectNormHistorysBySomeCriteria(
                                    int PMProjectID,
                                    DateTime? searchHistoryFromDateView,
                                    DateTime? searchHistoryToDateView)
        {
            DataSet ds = dal.GetDataSet("PMProjectNormHistorys_GetProjectNormHistorysBySomeCriteria",
                                        searchHistoryFromDateView,
                                        searchHistoryToDateView,
                                        PMProjectID);
            return (List<PMProjectNormHistorysInfo>)GetListFromDataSet(ds);
        }
    }
    #endregion
}
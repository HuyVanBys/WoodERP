﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region ADReportViewRefParams
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ADReportViewRefParamsController
    //Created Date:Wednesday, April 17, 2019
    //-----------------------------------------------------------

    public class ADReportViewRefParamsController : BaseBusinessController
    {
        public ADReportViewRefParamsController()
        {
            dal = new DALBaseProvider("ADReportViewRefParams", typeof(ADReportViewRefParamsInfo));
        }
        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<ADReportViewRefParamsInfo> list = new List<ADReportViewRefParamsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ADReportViewRefParamsInfo obj = (ADReportViewRefParamsInfo)GetObjectFromDataRow(row);
                    list.Add(obj);
                }
            }
            ds.Dispose();
            return list;
        }
        public List<ADReportViewRefParamsInfo> GetViewRefParamByReportViewID(int ReportViewRefID)
        {
            DataSet ds = dal.GetDataSet("ADReportViewRefParams_GetViewRefParamByReportViewID", ReportViewRefID);
            return (List<ADReportViewRefParamsInfo>)GetListFromDataSet(ds);
        }
        public List<ADReportViewRefParamsInfo> GetTemplateParam(int TemplateID)
        {
            DataSet ds = dal.GetDataSet("ADReportViewRefParams_GetTemplateParam", TemplateID);
            return (List<ADReportViewRefParamsInfo>)GetListFromDataSet(ds);
        }
    }
    #endregion
}
﻿using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region HRSocialInsuranceDeclarations
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HRSocialInsuranceDeclarationsController
    //Created Date:Tuesday, December 24, 2019
    //-----------------------------------------------------------

    public class HRSocialInsuranceDeclarationsController : BaseBusinessController
    {
        public HRSocialInsuranceDeclarationsController()
        {
            dal = new DALBaseProvider("HRSocialInsuranceDeclarations", typeof(HRSocialInsuranceDeclarationsInfo));
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<HRSocialInsuranceDeclarationsInfo> list = new List<HRSocialInsuranceDeclarationsInfo>();
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    HRSocialInsuranceDeclarationsInfo obj = (HRSocialInsuranceDeclarationsInfo)GetObjectFromDataRow(row);
                    list.Add(obj);
                }
            }
            return list;
        }

        public DataSet GetSocialInsuranceDeclarationList(string no, string name, string type, DateTime dateFrom, DateTime dateTo)
        {
            DataSet ds = dal.GetDataSet("HRSocialInsuranceDeclarations_GetSocialInsuranceDeclarationList", no, name, type, dateFrom, dateTo);
            return ds;
        }

        public List<HRSocialInsuranceDeclarationsInfo> GetSocialInsuranceDeclarationListForShow(int? employeeID, string type)
        {
            DataSet ds = dal.GetDataSet("HRSocialInsuranceDeclarations_GetSocialInsuranceDeclarationListForShow", employeeID, type);
            return (List<HRSocialInsuranceDeclarationsInfo>)GetListFromDataSet(ds);
        }
    }
    #endregion
}
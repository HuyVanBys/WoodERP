﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region ICProductOutsourcings
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICProductOutsourcingsController
    //Created Date:15 Tháng Mười Một 2018
    //-----------------------------------------------------------

    public class ICProductOutsourcingsController : BaseBusinessController
    {
        public ICProductOutsourcingsController()
        {
            dal = new DALBaseProvider("ICProductOutsourcings", typeof(ICProductOutsourcingsInfo));
        }

        public List<ICProductOutsourcingsInfo> GetAllObjectByProductParentID(int productParentID)
        {
            DataSet ds = dal.GetDataSet("ICProductOutsourcings_GetAllObjectByProductParentID", productParentID);
            return (List<ICProductOutsourcingsInfo>)GetListFromDataSet(ds);
        }

        public List<ICProductOutsourcingsInfo> GetDetailProductOutsourcingProductParentID(int productParentID)
        {
            DataSet ds = dal.GetDataSet("ICProductOutsourcings_GetDetailProductOutsourcingProductParentID", productParentID);
            return (List<ICProductOutsourcingsInfo>)GetListFromDataSet(ds);
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<ICProductOutsourcingsInfo> productOutsourcingList = new List<ICProductOutsourcingsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ICProductOutsourcingsInfo objProductAlternativesInfo = (ICProductOutsourcingsInfo)GetObjectFromDataRow(row);
                    productOutsourcingList.Add(objProductAlternativesInfo);
                }
            }
            ds.Dispose();
            return productOutsourcingList;
        }
    }
    #endregion
}
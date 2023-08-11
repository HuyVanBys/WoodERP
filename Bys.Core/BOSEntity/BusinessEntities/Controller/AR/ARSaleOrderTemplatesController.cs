﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region ARSaleOrderTemplates
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARSaleOrderTemplatesController
    //Created Date:Wednesday, October 28, 2015
    //-----------------------------------------------------------

    public class ARSaleOrderTemplatesController : BaseBusinessController
    {
        public ARSaleOrderTemplatesController()
        {
            dal = new DALBaseProvider("ARSaleOrderTemplates", typeof(ARSaleOrderTemplatesInfo));
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<ARSaleOrderTemplatesInfo> saleOrderTemplates = new List<ARSaleOrderTemplatesInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ARSaleOrderTemplatesInfo objSaleOrderTemplatesInfo = (ARSaleOrderTemplatesInfo)GetObjectFromDataRow(row);
                    saleOrderTemplates.Add(objSaleOrderTemplatesInfo);
                }
            }
            ds.Dispose();
            return saleOrderTemplates;
        }

        public List<ARSaleOrderTemplatesInfo> GetSOTemplateBySaleOrderID(int saleOrderID)
        {
            DataSet ds = dal.GetDataSet("ARSaleOrderTemplates_GetSOTemplateBySaleOrderID", saleOrderID);
            return (List<ARSaleOrderTemplatesInfo>)GetListFromDataSet(ds);
        }
    }
    #endregion
}
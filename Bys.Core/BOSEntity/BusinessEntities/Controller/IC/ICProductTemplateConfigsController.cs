﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region ICProductTemplateConfigs
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICProductTemplateConfigsController
    //Created Date:Friday, April 26, 2019
    //-----------------------------------------------------------

    public class ICProductTemplateConfigsController : BaseBusinessController
    {
        public ICProductTemplateConfigsController()
        {
            dal = new DALBaseProvider("ICProductTemplateConfigs", typeof(ICProductTemplateConfigsInfo));
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<ICProductTemplateConfigsInfo> ProductTemplateList = new List<ICProductTemplateConfigsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ICProductTemplateConfigsInfo objProductTemplatesInfo = (ICProductTemplateConfigsInfo)GetObjectFromDataRow(row);
                    ProductTemplateList.Add(objProductTemplatesInfo);
                }
            }
            ds.Dispose();
            return ProductTemplateList;
        }

        public List<ICProductTemplateConfigsInfo> GetAllProductTemplate()
        {
            DataSet ds = dal.GetDataSet("ICProductTemplateConfigs_GetAllProductTemplate");
            return (List<ICProductTemplateConfigsInfo>)GetListFromDataSet(ds);
        }

        public List<ICProductTemplateConfigsInfo> GetAllProductTemplateByConfigID(int productTemplateConfigID)
        {
            DataSet ds = dal.GetDataSet("ICProductTemplateConfigs_GetAllProductTemplateByConfigID", productTemplateConfigID);
            return (List<ICProductTemplateConfigsInfo>)GetListFromDataSet(ds);
        }

        public void RemoveAllNotContainObject(string productTemplateConfigRef)
        {
            dal.ExecuteStoredProcedure("ICProductTemplateConfigs_RemoveAllNotContainObject", productTemplateConfigRef);
        }
    }
    #endregion
}
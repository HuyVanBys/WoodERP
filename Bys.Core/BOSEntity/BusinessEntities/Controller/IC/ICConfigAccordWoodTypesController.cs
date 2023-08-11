﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region ICConfigAccordWoodTypes
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICConfigAccordWoodTypesController
    //Created Date:Tuesday, March 26, 2019
    //-----------------------------------------------------------

    public class ICConfigAccordWoodTypesController : BaseBusinessController
    {
        public ICConfigAccordWoodTypesController()
        {
            dal = new DALBaseProvider("ICConfigAccordWoodTypes", typeof(ICConfigAccordWoodTypesInfo));
        }
        public List<ICConfigAccordWoodTypesInfo> GetConfigAccordWoodTypeByAttributeType(string attributeType)
        {
            DataSet ds = dal.GetDataSet("ICConfigAccordWoodTypes_GetConfigAccordWoodTypeByAttributeType", attributeType);
            return (List<ICConfigAccordWoodTypesInfo>)GetListFromDataSet(ds);
        }
        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<ICConfigAccordWoodTypesInfo> productAttribute = new List<ICConfigAccordWoodTypesInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ICConfigAccordWoodTypesInfo objProductAttributesInfo = (ICConfigAccordWoodTypesInfo)GetObjectFromDataRow(row);
                    productAttribute.Add(objProductAttributesInfo);
                }
            }
            ds.Dispose();
            return productAttribute;
        }
    }
    #endregion
}
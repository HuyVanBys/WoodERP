﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region ICProductAttributes
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICProductAttributesController
    //Created Date:Friday, October 16, 2015
    //-----------------------------------------------------------

    public class ICProductAttributesController : BaseBusinessController
    {
        public ICProductAttributesController()
        {
            dal = new DALBaseProvider("ICProductAttributes", typeof(ICProductAttributesInfo));
        }
        public DataSet GetCatcheData()
        {
            return dal.GetDataSet("ICProductAttributes_GetCatcheData");
        }
        public List<ICProductAttributesInfo> GetProductAttributesByProductAttributeGroup(string productAttributeGroup)
        {
            DataSet ds = dal.GetDataSet("ICProductAttributes_GetProductAttributesByProductAttributeGroup", productAttributeGroup);
            return (List<ICProductAttributesInfo>)GetListFromDataSet(ds);
        }
        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<ICProductAttributesInfo> productAttribute = new List<ICProductAttributesInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ICProductAttributesInfo objProductAttributesInfo = (ICProductAttributesInfo)GetObjectFromDataRow(row);
                    productAttribute.Add(objProductAttributesInfo);
                }
            }
            ds.Dispose();
            return productAttribute;
        }

        /// <summary>
        /// Get ICProductAttributes by ProductAttributeGroup
        /// </summary>
        /// <param name="ProductAttributeGroup">ProductAttributeGroup</param>
        /// <returns>List ICProductAttributesInfo </returns>
        public ICProductAttributesInfo GetProductAttributesProductAttributeValue(string productAttributeValue)
        {
            DataSet ds = dal.GetDataSet("ICProductAttributes_GetProductAttributesProductAttributeValue", productAttributeValue);
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ICProductAttributesInfo objProductAttributesInfo = (ICProductAttributesInfo)GetObjectFromDataRow(row);
                    ds.Dispose();
                    return objProductAttributesInfo;
                }
            }
            ds.Dispose();
            return null;
        }
        /// <summary>
        /// Get ICProductAttributes by ProductAttributeGroup
        /// </summary>
        /// <param name="ProductAttributeGroup">ProductAttributeGroup</param>
        /// <returns>List ICProductAttributesInfo </returns>
        public ICProductAttributesInfo GetProductAttributesByGroupAndValue(string productAttributeGroup, string productAttributeValue)
        {
            DataSet ds = dal.GetDataSet("ICProductAttributes_GetProductAttributesByGroupAndValue", productAttributeGroup, productAttributeValue);
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ICProductAttributesInfo objProductAttributesInfo = (ICProductAttributesInfo)GetObjectFromDataRow(row);
                    ds.Dispose();
                    return objProductAttributesInfo;
                }
            }
            ds.Dispose();
            return null;
        }
        public List<ICProductAttributesInfo> GetProductAttributeValueByICProductID(int productID)
        {
            DataSet ds = dal.GetDataSet("ICProductAttributes_GetProductAttributeValueByICProductID", productID);
            return (List<ICProductAttributesInfo>)GetListFromDataSet(ds);
        }
        public List<ICProductAttributesInfo> GetProductColorAttributeValueByICProductID(int productID)
        {
            DataSet ds = dal.GetDataSet("ICProductAttributes_GetProductColorAttributeValueByICProductID", productID);
            return (List<ICProductAttributesInfo>)GetListFromDataSet(ds);
        }
        public List<ICProductAttributesInfo> GetProductAttributeValueByWoodType()
        {
            DataSet ds = dal.GetDataSet("ICProductAttributes_GetProductAttributeValueByWoodType");
            return (List<ICProductAttributesInfo>)GetListFromDataSet(ds);
        }

        public List<ICProductAttributesInfo> GetProductAttributeValueByWoodTypeAndAddMaterial()
        {
            DataSet ds = dal.GetDataSet("ICProductAttributes_GetProductAttributeValueByWoodTypeAndAddMaterial");
            return (List<ICProductAttributesInfo>)GetListFromDataSet(ds);
        }

        public List<ICProductAttributesInfo> GetProductAttributeByProductAttributeReference(string productAttributeReference)
        {
            DataSet ds = dal.GetDataSet("ICProductAttributes_GetProductAttributeByProductAttributeReference", productAttributeReference);
            return (List<ICProductAttributesInfo>)GetListFromDataSet(ds);
        }

        public List<ICProductAttributesInfo> GetProductAttributeByProductAttributeReferenceByCharater(string productAttributeReference, string charater)
        {
            DataSet ds = dal.GetDataSet("ICProductAttributes_GetProductAttributeByProductAttributeReferenceByCharater", productAttributeReference, charater);
            return (List<ICProductAttributesInfo>)GetListFromDataSet(ds);
        }

        public List<ICProductAttributesInfo> GetProductAttributeByNoRef(string productAttributeReference)
        {
            DataSet ds = dal.GetDataSet("ICProductAttributes_GetProductAttributeByNoRef", productAttributeReference);
            return (List<ICProductAttributesInfo>)GetListFromDataSet(ds);
        }
        public DataSet GetWoodTypeData()
        {
            DataSet ds = dal.GetDataSet("ICProductAttributes_GetProductAttributesProductAttributeValue", "WoodType");
            return ds;
        }
        public List<ICProductAttributesInfo> GetAttributeValueBywoodTypeIDAndAttributeType(int woodTypeID, string attributeType)
        {
            DataSet ds = dal.GetDataSet("ICProductAttributes_GetAttributeValueBywoodTypeIDAndAttributeType", woodTypeID, attributeType);
            return (List<ICProductAttributesInfo>)GetListFromDataSet(ds);
        }
    }
    #endregion
}
using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region ICDepartmentAttributeValues
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICDepartmentAttributeValuesController
    //Created Date:Tuesday, March 02, 2010
    //-----------------------------------------------------------

    public class ICDepartmentAttributeValuesController : BaseBusinessController
    {
        public ICDepartmentAttributeValuesController()
        {
            dal = new DALBaseProvider("ICDepartmentAttributeValues", typeof(ICDepartmentAttributeValuesInfo));
        }

        /// <summary>
        /// Get department attribute value list
        /// </summary>
        /// <returns>List of the department attribute value</returns>
        public List<ICDepartmentAttributeValuesInfo> GetDepartmentAttributeValuesList()
        {
            List<ICDepartmentAttributeValuesInfo> departmentAttributeValueList = new List<ICDepartmentAttributeValuesInfo>();
            DataSet ds = dal.GetDataSet("ICDepartmentAttributeValues_GetDepartmentAttributeValuesList");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ICDepartmentAttributeValuesInfo objDepartmentAttributeValuesInfo = (ICDepartmentAttributeValuesInfo)GetObjectFromDataRow(row);
                    departmentAttributeValueList.Add(objDepartmentAttributeValuesInfo);
                }
            }
            return departmentAttributeValueList;
        }

        /// <summary>
        /// Count the values of an attribute
        /// </summary>
        /// <param name="attributeID">Attribute id</param>
        /// <returns>Value count</returns>
        public int GetValueCountByAttributeID(int attributeID)
        {
            return Convert.ToInt32(dal.GetSingleValue("ICDepartmentAttributeValues_GetValueCountByAttributeID", attributeID));
        }
        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<ICDepartmentAttributeValuesInfo> attributes = new List<ICDepartmentAttributeValuesInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ICDepartmentAttributeValuesInfo attribute = (ICDepartmentAttributeValuesInfo)GetObjectFromDataRow(row);
                    attributes.Add(attribute);
                }
            }
            ds.Dispose();
            return attributes;
        }
        public List<ICDepartmentAttributeValuesInfo> GetListFromDepartmentAttributeID(int attributeID)
        {
            DataSet ds = dal.GetDataSet("ICDepartmentAttributeValues_GetListByDepartmentAttributeID", attributeID);
            return (List<ICDepartmentAttributeValuesInfo>)GetListFromDataSet(ds);
        }

        public List<ICDepartmentAttributeValuesInfo> GetDepartmentAttributeValuesByDepartmentID(int attributeID)
        {
            DataSet ds = dal.GetDataSet("ICDepartmentAttributeValues_GetDepartmentAttributeValuesByDepartmentID", attributeID);
            return (List<ICDepartmentAttributeValuesInfo>)GetListFromDataSet(ds);
        }
        public List<ICDepartmentAttributeValuesInfo> GetDepartmentAttributeByDepartmentAttributeReference(string departmentAttributeKey)
        {
            DataSet ds = dal.GetDataSet("ICDepartmentAttributeValues_GetDepartmentAttributeByDepartmentAttributeReference", departmentAttributeKey);
            return (List<ICDepartmentAttributeValuesInfo>)GetListFromDataSet(ds);
        }

    }
    #endregion
}
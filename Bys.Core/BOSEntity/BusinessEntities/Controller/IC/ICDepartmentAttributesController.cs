using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region ICDepartmentAttributes
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICDepartmentAttributesController
    //Created Date:Tuesday, March 02, 2010
    //-----------------------------------------------------------

    public class ICDepartmentAttributesController : BaseBusinessController
    {
        public ICDepartmentAttributesController()
        {
            dal = new DALBaseProvider("ICDepartmentAttributes", typeof(ICDepartmentAttributesInfo));
        }

        /// <summary>
        /// Get attributes of a department
        /// </summary>
        /// <param name="departmentID">Department id</param>
        /// <returns>List of attributes</returns>
        public DataSet GetAllAttributesByDepartmentID(int departmentID)
        {
            DataSet ds = dal.GetDataSet("ICDepartmentAttributes_GetAttributesByDepartmentID", departmentID);
            return ds;
        }

        /// <summary>
        /// Get all attributes
        /// </summary>
        /// <returns>List of attributes</returns>
        public List<ICDepartmentAttributesInfo> GetAllAttributes()
        {
            DataSet ds = dal.GetAllObject();
            return (List<ICDepartmentAttributesInfo>)GetListFromDataSet(ds);
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<ICDepartmentAttributesInfo> attributes = new List<ICDepartmentAttributesInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ICDepartmentAttributesInfo attribute = (ICDepartmentAttributesInfo)GetObjectFromDataRow(row);
                    attributes.Add(attribute);
                }
            }
            ds.Dispose();
            return attributes;
        }
    }
    #endregion
}